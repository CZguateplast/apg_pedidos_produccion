Public Class frmOrdenCerrar

#Region "Carga Inicial"
    Private Sub Sub_Seguridad()
        Try
            mSeguridad.APG_Seguridad(Me, barbtnCerrar)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub frmCerrarAR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Sub_Seguridad()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region "Grid Horizontal"
    Private Sub grdviewCerrarEnsamble_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grdviewCerrarEnsamble.SelectionChanged
        Try
            Dim Rows As New ArrayList()
            Dim pGridView As DevExpress.XtraGrid.Views.Grid.GridView = grdviewCerrarEnsamble
            For I = 0 To pGridView.SelectedRowsCount() - 1
                If (pGridView.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(pGridView.GetDataRow(pGridView.GetSelectedRows()(I)))
                End If
            Next

            If Rows.Count = Nothing Then
                mSQLDelete.SET_ValidarDisponibilidad_Eliminar("ProduccionPedidos", Me.Name.ToString)
                Exit Sub
            End If

            mSQLDelete.SET_ValidarDisponibilidad_Eliminar("ProduccionPedidos", Me.Name.ToString)

            Dim pColumna As String = "CodigoArticulo"
            For j = 0 To Rows.Count - 1
                If Not mFunciones.FCN_ValidarDisponiblidad_CerrarOrdenes("'" + Rows(j)(pColumna) + "'", Me.Name.ToString) Then
                    grdviewCerrarEnsamble.UnselectRow(e.ControllerRow)
                End If
            Next
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub MostrarOrdenesFabricacion()
        Try
            Dim dt As New DataTable("dtEnsambles")
            If txtDiasAtraso.EditValue = "" Then
                dt = mSQLSelect.GET_Listado_OrdenesEnsamble("-1", vpTipoOrden)
            Else
                dt = mSQLSelect.GET_Listado_OrdenesEnsamble(txtDiasAtraso.EditValue, vpTipoOrden)
            End If
            DsCerrarAR1.Tables("dsdtCerrarAR").Clear()
            DsCerrarAR1.Tables("dsdtCerrarAR").Merge(dt)
            grdviewCerrarEnsamble.UnselectRow(0)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub
#End Region
#Region "Botones"
    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick

        Try

            vpCodigoArticulo = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewCerrarEnsamble, "NumSAP")

            If mMensajes.msg_Ordenes_StatusCerrar() Then
                ssmEsperar.ShowWaitForm()
                Dim pArray As ArrayList
                pArray = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewCerrarEnsamble)

                For i = 0 To pArray.Count - 1
                    Dim pNumOrden As String = pArray(i)("NumSAP").ToString

                    'mDIAPI.SAP_DIAPI_Produccion_StatusLiberado(pNumOrden)
                    'mDIAPI.SAP_DIAPI_Produccion_StatusCerrado(pNumOrden)

                    If pArray(i)("Estado").ToString = "Liberado" Then
                        mDIAPI.SAP_DIAPI_Produccion_StatusCerrado(pNumOrden)
                    Else
                        mDIAPI.SAP_DIAPI_Produccion_StatusLiberado(pNumOrden)
                        mDIAPI.SAP_DIAPI_Produccion_StatusCerrado(pNumOrden)
                    End If
                Next

            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            MostrarOrdenesFabricacion()
            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
            frmTemporal_OrdenesCerradasResultado.ShowDialog()
        End Try

    End Sub
    Private Sub sbtnMostrar_Click(sender As Object, e As EventArgs) Handles sbtnMostrar.Click
        MostrarOrdenesFabricacion()
    End Sub

#End Region
#Region "Carga Final"
    Private Sub frmCerrarAR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            mSQLDelete.SET_ValidarDisponibilidad_Eliminar("ProduccionPedidos", Me.Name.ToString)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

#End Region
End Class