Imports DevExpress.XtraScheduler

Public Class frmProduccionCalendario



    Private Sub frmProduccionCalendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ''LLENAR CODIGO DE ARTICULOS PENDIENTES DE CARGAR AL PLAN DE TRABAJO
            FILL_OrdenesPendientesDeAsignar()


            'TODO: This line of code loads data into the 'APGProduccionDataSet.Resources' table. You can move, or remove it, as needed.
            Me.ResourcesTableAdapter.Fill(Me.APGProduccionDataSet.Resources)
            'TODO: This line of code loads data into the 'APGProduccionDataSet.Appointments' table. You can move, or remove it, as needed.
            Me.AppointmentsTableAdapter.Fill(Me.APGProduccionDataSet.Appointments)

            
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub SchedulerStorage1_AppointmentsChanged(sender As Object, e As PersistentObjectsEventArgs) Handles SchedulerStorage1.AppointmentsChanged, SchedulerStorage1.AppointmentsInserted, SchedulerStorage1.AppointmentsDeleted
        AppointmentsTableAdapter.Update(APGProduccionDataSet)
        APGProduccionDataSet.AcceptChanges()
    End Sub

    Private Sub scCalendario_EditAppointmentFormShowing(sender As Object, e As AppointmentFormEventArgs) Handles scCalendario.EditAppointmentFormShowing
        Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = CType(sender, DevExpress.XtraScheduler.SchedulerControl)
        Dim form As waProduccion_Pedidos.OutlookAppointmentForm = New waProduccion_Pedidos.OutlookAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm)
        Try
            e.DialogResult = form.ShowDialog
            e.Handled = True
            'FCN_Actualizar()
        Finally
            form.Dispose()
        End Try
    End Sub


    Private Sub FILL_OrdenesPendientesDeAsignar()
        Try
            'LLENAR GRID DE ORDENES DE PRODUCCION
            Dim dtOrdenesProduccion As New DataTable()
            'dtOrdenesProduccion = mSQLSelect.GET_PlanificacionProduccion_Ordenes()
            dtOrdenesProduccion = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_OrdenesProduccion_Padres")

            If dtOrdenesProduccion.Rows.Count = Nothing Then
                APGProduccionDataSet.Tables(APGProduccionDataSet.dsdtOrdenesProduccion.TableName.ToString).Clear()
                Exit Sub
            End If

            APGProduccionDataSet.Tables(APGProduccionDataSet.dsdtOrdenesProduccion.TableName.ToString).Clear()
            APGProduccionDataSet.Tables(APGProduccionDataSet.dsdtOrdenesProduccion.TableName.ToString).Merge(dtOrdenesProduccion)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub INSERTAR_Appointment()
        Try
            ''ARTICULOS PROGRAMADOS
            Dim dtOrdenesProgramadas As New DataTable()
            'dtOrdenesProgramadas = GET_PlanificacionProduccion_Programada()
            dtOrdenesProgramadas = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_Calendario_ProgramacionProduccion")

            For I = 0 To dtOrdenesProgramadas.Rows.Count - 1
                Dim pHorasPendiente As String = String.Empty
                Dim pProduccionHora As String = String.Empty
                Dim dtDatosMolde As New DataTable()

                pHorasPendiente = mFunciones.FCN_ProduccionHoras(dtOrdenesProgramadas.Rows(I)("Codigo"), dtOrdenesProgramadas.Rows(I)("Pendiente"))
                If Not pHorasPendiente = Nothing Then
                    dtOrdenesProgramadas.Rows(I)("HorasPendientes") = pHorasPendiente
                Else
                    dtOrdenesProgramadas.Rows(I)("HorasPendientes") = 1
                End If

                'dtDatosMolde = mSQLSelect.GET_MoldesProduccionParametros(dtOrdenesProgramadas.Rows(I)("CodigoArticulo"))
                dtDatosMolde = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_ProduccionParametros " + dtOrdenesProgramadas.Rows(I)("Codigo").ToString)

                If Not dtDatosMolde.Rows.Count = Nothing Then
                    pProduccionHora = dtDatosMolde.Rows(0)("ArticulosHora")
                End If

                If Not pProduccionHora = Nothing Then
                    dtOrdenesProgramadas.Rows(I)("ProduccionXHora") = Convert.ToInt32(pProduccionHora)
                End If

            Next

            Dim pMaquinaAnterior As String = String.Empty
            Dim pMaquinaActual As String = String.Empty
            Dim pFechaActual As New DateTime
            Dim pFechaInicial As New DateTime
            Dim pFechaFinal As New DateTime

            pFechaActual = DateTime.Now()

            Dim pColumn As New DataColumn
            pColumn = New DataColumn("StartDate", Type.GetType("System.DateTime"))
            dtOrdenesProgramadas.Columns.Add(pColumn)
            pColumn = New DataColumn("EndDate", Type.GetType("System.DateTime"))
            dtOrdenesProgramadas.Columns.Add(pColumn)

            For I = 0 To dtOrdenesProgramadas.Rows.Count - 1
                If I = 0 Then
                    pFechaInicial = pFechaActual
                    pFechaFinal = pFechaInicial.AddHours(dtOrdenesProgramadas.Rows(I)("HorasPendientes"))
                    dtOrdenesProgramadas.Rows(I)("StartDate") = pFechaInicial
                    dtOrdenesProgramadas.Rows(I)("EndDate") = pFechaFinal
                Else
                    pMaquinaAnterior = dtOrdenesProgramadas.Rows(I - 1)("ResourceID")
                    pMaquinaActual = dtOrdenesProgramadas.Rows(I)("ResourceID")

                    If pMaquinaActual = pMaquinaAnterior Then
                        pFechaInicial = pFechaFinal.AddHours(12)
                        pFechaFinal = pFechaInicial.AddHours(dtOrdenesProgramadas.Rows(I)("HorasPendientes"))
                        dtOrdenesProgramadas.Rows(I)("StartDate") = Format(pFechaInicial, "yyyy-MM-yy hh:mm:ss")
                        dtOrdenesProgramadas.Rows(I)("EndDate") = Format(pFechaFinal, "yyyy-MM-yy hh:mm:ss")

                    Else
                        pFechaInicial = pFechaActual
                        pFechaFinal = pFechaInicial.AddHours(dtOrdenesProgramadas.Rows(I)("HorasPendientes"))
                        dtOrdenesProgramadas.Rows(I)("StartDate") = Format(pFechaInicial, "yyyy-MM-yy hh:mm:ss")
                        dtOrdenesProgramadas.Rows(I)("EndDate") = Format(pFechaFinal, "yyyy-MM-yy hh:mm:ss")
                    End If
                End If

            Next


            mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_Calendario_Appointments_Delete ")

            'HACER UN INSERT DE LO GUARDADO
            For i = 0 To dtOrdenesProgramadas.Rows.Count - 1
                mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_Calendario_Appointments_Insert " _
                + "'0'," _
                + "'En Proceso'," _
                + "'" + dtOrdenesProgramadas.Rows(i)("Prioridad").ToString + "'," _
                + "'" + dtOrdenesProgramadas.Rows(i)("Codigo").ToString + "'," _
                + "'" + dtOrdenesProgramadas.Rows(i)("NombreCodigo").ToString + "'," _
                + "'" + Format(dtOrdenesProgramadas.Rows(i)("StartDate"), "yyyy-MM-yy hh:mm:ss") + "'," _
                + "'" + Format(dtOrdenesProgramadas.Rows(i)("EndDate"), "yyyy-MM-yy hh:mm:ss") + "'," _
                + "'0'," _
                + "'" + dtOrdenesProgramadas.Rows(i)("Codigo").ToString + "'," _
                + "'Fabrica'," _
                + "'" + dtOrdenesProgramadas.Rows(i)("Codigo").ToString + "'," _
                + "'1'," _
                + "'1'," _
                + "'" + dtOrdenesProgramadas.Rows(i)("ResourceID").ToString + "'," _
                + "'NULL'," _
                + "'NULL'," _
                + "'NULL'," _
                + "'Central America Standard Time'," _
                + "'NULL'," _
                + "'" + dtOrdenesProgramadas.Rows(i)("Planeado").ToString + "'," _
                + "'" + dtOrdenesProgramadas.Rows(i)("Completado").ToString + "'," _
                + "'" + dtOrdenesProgramadas.Rows(i)("Pendiente").ToString + "'," _
                + "'0'," _
                + "'" + dtOrdenesProgramadas.Rows(i)("ProduccionXHora").ToString + "'," _
                + "'" + dtOrdenesProgramadas.Rows(i)("HorasPendientes").ToString + "'")
            Next

            'APGProduccionDataSet.Tables(APGProduccionDataSet.Appointments.TableName.ToString).Clear()
            'APGProduccionDataSet.Tables(APGProduccionDataSet.Appointments.TableName.ToString).Merge(dtOrdenesProgramadas)


            'DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProgramadas.TableName.ToString).Clear()
            'If Not dtOrdenesProgramadas.Rows.Count = Nothing Then
            '    DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProgramadas.TableName.ToString).Merge(dtOrdenesProgramadas)
            'End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub FCN_Ajustar_Split()
        Try
            'pTamaño = 
            ' 275 para Fecha
            ' 400 para Codigo

            Dim pTamaño As Integer = 0

            Select Case xtcCalendario.SelectedTabPage.Name
                Case xtpFecha.Name
                    pTamaño = 275
                Case xtpCodigo.Name
                    pTamaño = 700
            End Select





            Dim pTamanoSplit1 As Integer = 0
            Dim pFormSize As Integer = 0

            pFormSize = Me.Size.Width

            pTamanoSplit1 = Me.Size.Width - pTamaño
            sccCalendario.SplitterPosition = pTamanoSplit1


            'If barbtnMostrar.Down = False Then
            '    sccEnsambleCalculadora.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            '    barbtnMostrar.Caption = "Mostrar"
            'Else
            '    sccEnsambleCalculadora.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
            '    barbtnMostrar.Caption = "Ocultar"
            'End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmProduccionCalendario_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        FCN_Ajustar_Split()
    End Sub

    Private Sub frmProduccionCalendario_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        FCN_Ajustar_Split()
        Me.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub FCN_CargarTrabajos_Asignados()
        Try

            'ARTICULOS PROGRAMADOS
            Dim dtOrdenesProgramadas As New DataTable()
            dtOrdenesProgramadas = GET_PlanificacionProduccion_Programada()

            For I = 0 To dtOrdenesProgramadas.Rows.Count - 1
                dtOrdenesProgramadas.Rows(I)("HorasPendiente") = mFunciones.FCN_ProduccionHoras(dtOrdenesProgramadas.Rows(I)("CodigoArticulo"), dtOrdenesProgramadas.Rows(I)("Pendiente"))
                dtOrdenesProgramadas.Rows(I)("ProduccionHora") = mSQLSelect.GET_MoldesProduccionParametros(dtOrdenesProgramadas.Rows(I)("CodigoArticulo").ToString).Rows(0)("ArticulosHora")
            Next

            Dim pColumn As New DataColumn
            pColumn = New DataColumn("FechaInicial", Type.GetType("System.DateTime"))
            dtOrdenesProgramadas.Columns.Add(pColumn)
            pColumn = New DataColumn("FechaFinal", Type.GetType("System.DateTime"))
            dtOrdenesProgramadas.Columns.Add(pColumn)




            'PROGRAMAR HORAS INICIO

            Dim pMaquinaAnterior As String = String.Empty
            Dim pMaquinaActual As String = String.Empty
            Dim pFechaActual As New DateTime
            Dim pFechaInicial As New DateTime
            Dim pFechaFinal As New DateTime

            pFechaActual = DateTime.Now()

            For I = 0 To dtOrdenesProgramadas.Rows.Count - 1
                If I = 0 Then
                    pFechaInicial = pFechaActual
                    pFechaFinal = pFechaInicial.AddHours(dtOrdenesProgramadas.Rows(I)("HorasPendiente"))
                    dtOrdenesProgramadas.Rows(I)("FechaInicial") = pFechaInicial
                    dtOrdenesProgramadas.Rows(I)("FechaFinal") = pFechaFinal
                Else
                    pMaquinaAnterior = dtOrdenesProgramadas.Rows(I - 1)("Preferencial")
                    pMaquinaActual = dtOrdenesProgramadas.Rows(I)("Preferencial")

                    If pMaquinaActual = pMaquinaAnterior Then
                        pFechaInicial = pFechaFinal.AddHours(12)
                        pFechaFinal = pFechaInicial.AddHours(dtOrdenesProgramadas.Rows(I)("HorasPendiente"))
                        dtOrdenesProgramadas.Rows(I)("FechaInicial") = pFechaInicial
                        dtOrdenesProgramadas.Rows(I)("FechaFinal") = pFechaFinal

                    Else
                        pFechaInicial = pFechaActual
                        pFechaFinal = pFechaInicial.AddHours(dtOrdenesProgramadas.Rows(I)("HorasPendiente"))
                        dtOrdenesProgramadas.Rows(I)("FechaInicial") = pFechaInicial
                        dtOrdenesProgramadas.Rows(I)("FechaFinal") = pFechaFinal
                    End If


                End If

            Next

            'DsTemporal_ProgramacionGrafica1.Tables(DsTemporal_ProgramacionGrafica1.dsdtOrdenesProgramadas.TableName.ToString).Clear()
            'If Not dtOrdenesProgramadas.Rows.Count = Nothing Then
            '    DsTemporal_ProgramacionGrafica1.Tables(DsTemporal_ProgramacionGrafica1.dsdtOrdenesProgramadas.TableName.ToString).Merge(dtOrdenesProgramadas)
            'End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)


        End Try


    End Sub

    Private Sub barbtnActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnActualizar.ItemClick
        Try
            FCN_Actualizar()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub



    Private Sub FCN_Actualizar()
        Try
            'Me.Controls.Clear()
            'Me.InitializeComponent()

            'TODO: This line of code loads data into the 'APGProduccionDataSet.Resources' table. You can move, or remove it, as needed.
            Me.ResourcesTableAdapter.Fill(Me.APGProduccionDataSet.Resources)
            'TODO: This line of code loads data into the 'APGProduccionDataSet.Appointments' table. You can move, or remove it, as needed.
            Me.AppointmentsTableAdapter.Fill(Me.APGProduccionDataSet.Appointments)

            'FCN_Ajustar_Split(275)
            'AppointmentsTableAdapter.Update(APGProduccionDataSet)
            'APGProduccionDataSet.AcceptChanges()
            ''scCalendario.RefreshData()
            'scCalendario.Update()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub xtcCalendario_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtcCalendario.SelectedPageChanged
        FCN_Ajustar_Split()
    End Sub

   

    Private Sub barchkOcultarPanel_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barchkOcultarPanel.CheckedChanged
        Try

            If barchkOcultarPanel.Checked = True Then
                sccCalendario.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                barchkOcultarPanel.Caption = "Mostrar Panel"
            Else
                sccCalendario.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
                barchkOcultarPanel.Caption = "Ocultar Panel"
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class