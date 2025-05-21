Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Public Class frmTemporal_MaquinasParaTrabajar


    Private pCodigoPadre As String
    Private pNombre As String
    Private pMaquinaSeleccionada As String
    Private pBoolean As Boolean
    Private pTipoProceso As String

    Public Property ppCodigoPadre() As String
        Get
            Return pCodigoPadre
        End Get
        Set(ByVal Value As String)
            pCodigoPadre = Value
        End Set
    End Property



    Public Property ppNombre() As String
        Get
            Return pNombre
        End Get
        Set(ByVal Value As String)
            pNombre = Value
        End Set
    End Property

    Public Property ppMaquinaSeleccionada() As String
        Get
            Return pMaquinaSeleccionada
        End Get
        Set(ByVal Value As String)
            pMaquinaSeleccionada = Value
        End Set
    End Property
    Public Property ppBoolean() As Boolean
        Get
            Return pBoolean
        End Get
        Set(ByVal Value As Boolean)
            pBoolean = Value
        End Set
    End Property

    Private Sub frmTemporal_MaquinasParaTrabajar_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub


    'SI ES "M" LA BUSQUEDA DE RESULTADO LA HACE POR MOLDE
    'SI ES "G" LA BUSQUEDA DE RESULTADO LA HACE POR GRUPO DE MAQUINA

    Public Property ppTipoProceso() As String
        Get
            Return pTipoProceso
        End Get
        Set(ByVal Value As String)
            pTipoProceso = Value
        End Set
    End Property
    

    Private Sub frmTemporal_MaquinasParaTrabajar_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

            If pCodigoPadre = String.Empty Then
                Exit Sub
            End If

            Dim dt As New DataTable()
            'dt = mSQLSelect.GET_Temporal_MaquinasParaTrabajar(pCodigoPadre) 'SE SUSTITUYE CON SP

            If pTipoProceso = Nothing Then
                dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_MaquinasCompatibles " + pCodigoPadre)
                lbTitulo.Text = "MAQUINAS DISPONIBLES PARA TRABAJAR"
            ElseIf ppTipoProceso = "M" Then
                dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_MaquinasCompatibles " + pCodigoPadre)
                lbTitulo.Text = "MAQUINAS DISPONIBLES PARA TRABAJAR"
            ElseIf ppTipoProceso = "G" Then
                dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_MaquinasCompatibles_XGrupoMaquina " + pCodigoPadre)
                lbTitulo.Text = "MAQUINAS DISPONIBLES PARA TRABAJAR [Por Grupo de Maquina]"
            End If



            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            Dim pHorasPendientes As String = String.Empty
            For i = 0 To dt.Rows.Count - 1
                pHorasPendientes = Nothing
                'pHorasPendientes = mSQLSelect.GET_Maquinas_HorasPendienteTrabajo(dt.Rows(i)("Maquina")) SUSTITUYE SP
                Dim dtHorasPendiente As New DataTable()
                dtHorasPendiente = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_Maquina_HorasPendienteTrabajo " + dt.Rows(i)("Maquina").ToString)
                If Not dtHorasPendiente.Rows.Count = Nothing Then
                    pHorasPendientes = dtHorasPendiente.Rows(0)(0).ToString
                End If
                If Not pHorasPendientes = Nothing Then
                    dt.Rows(i)("HorasPendientes") = Val(pHorasPendientes)
                End If
            Next

            txtCodigoPadre.EditValue = ppCodigoPadre
            txtNombre.EditValue = ppNombre

            DsTemporal_MaquinasParaTrabajar1.Tables(DsTemporal_MaquinasParaTrabajar1.dsdtTemporal_MaquinasParaTrabajar.TableName.ToString).Clear()
            DsTemporal_MaquinasParaTrabajar1.Tables(DsTemporal_MaquinasParaTrabajar1.dsdtTemporal_MaquinasParaTrabajar.TableName.ToString).Merge(dt)


            ' Create an empty Bar series and add it to the chart.
            Dim series As New Series("Series1", ViewType.Bar)
            Dim chart As ChartControl = ChartControl1
            chart.Series.Add(series)

            ' Generate a data table and bind the series to it.
            series.DataSource = dt

            ' Specify data members to bind the series.
            series.ArgumentScaleType = ScaleType.Numerical
            series.ArgumentDataMember = "Maquina"
            series.ValueScaleType = ScaleType.Numerical
            series.ValueDataMembers.AddRange(New String() {"HorasPendientes"})
            series.ValueScaleType = ScaleType.Numerical


            ' Set some properties to get a nice-looking chart.
            CType(series.View, SideBySideBarSeriesView).ColorEach = True
            CType(chart.Diagram, XYDiagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.False
            chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False

            ' Dock the chart into its parent and add it to the current form.
            'chart.Dock = DockStyle.Fill
            'Me.Controls.Add(chart)








        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub





    Private Sub barbtnAceptar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAceptar.ItemClick
        Try
            FCN_MaquinaSeleccionada()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub FCN_MaquinaSeleccionada()
        Try
            Dim pMaquina As String = String.Empty

            pMaquina = mFunciones.FCN_GetCellValue(grdviewMaquinasParaTrabajar, "Maquina")
            If pMaquina = String.Empty Then
                Exit Sub
            End If

            ppMaquinaSeleccionada = pMaquina
            ppBoolean = True
            Me.Close()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            ppBoolean = False
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub grdviewMaquinasParaTrabajar_DoubleClick(sender As Object, e As EventArgs) Handles grdviewMaquinasParaTrabajar.DoubleClick
        Try
            FCN_MaquinaSeleccionada()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


End Class