Imports DevExpress.XtraNavBar
Imports DevExpress.XtraEditors
Public Class frmControlProduccion_Detalle
    Private pCodigoArticulo As String
    Private pMaquina As String

    Public Property ppMaquina() As String
        Get
            Return pMaquina
        End Get
        Set(ByVal Value As String)

            pMaquina = Value
        End Set
    End Property

    Public Property ppCodigoArticulo() As String
        Get
            Return pCodigoArticulo
        End Get
        Set(ByVal Value As String)

            pCodigoArticulo = Value
        End Set
    End Property


    Private Sub frmControlProduccion_Detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            txtMaquina.EditValue = pMaquina

            Dim dtListaProducciones As New DataTable()
            dtListaProducciones = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_ListadoCodigoArticulo_OrdenesAbiertas_Padre " + "'" + pCodigoArticulo + "%'")

            Dim Producciones As NavBarItem
            If Not dtListaProducciones.Rows.Count = Nothing Then
                For I = 0 To dtListaProducciones.Rows.Count - 1
                    Producciones = New NavBarItem(dtListaProducciones.Rows(I)("CodigoArticulo").ToString)
                    nbgProducciones.ItemLinks.Add(Producciones)
                Next
            End If


            mFunciones.FCN_FILL_SearchLookUpEdit(slueTurno, mSQLSelect.GET_Listado("Tipo_Turno"), "Id", "Nombre")


            






            'Dim navBar As DevExpress.XtraNavBar.NavBarControl = nbarDetalle
            ''navBar.PaintStyleName = "Office 2010 Black"
            'Dim gProducciones As NavBarGroup = New NavBarGroup("Producciones")
            'Dim gEnsambles As NavBarGroup = New NavBarGroup("Ensambles")
            '' Create an Inbox item and assign an image from the SmallImages list to the item.
            'Dim itemInbox As NavBarItem = New NavBarItem("CP003585-RJ-0")
            ''itemInbox.SmallImageIndex = 0
            '' Create an Outbox item.
            'Dim itemOutbox As NavBarItem = New NavBarItem("CP003585-AZ-0")
            ''itemOutbox.SmallImageIndex = 1
            'Dim pControl As DevExpress.XtraEditors.DateEdit = New DevExpress.XtraEditors.DateEdit()
            'Dim Ensambles As NavBarItem = New NavBarItem("AR013585-AZ-0")
            'itemOutbox.SmallImageIndex = 1
            '' Add the created items to the group and the group to the NavBarControl.
            '' Prevent excessive updates using the BeginUpdate and EndUpdate methods.
            ''navBar.BeginUpdate()
            ''navBar.Groups.Add(gProducciones)
            ''navBar.Groups.Add(gEnsambles)
            'gProducciones.ItemLinks.Add(itemInbox)
            'gProducciones.ItemLinks.Add(itemOutbox)
            'gEnsambles.ItemLinks.Add(Ensambles)
            'gProducciones.Expanded = True
            'navBar.EndUpdate()
            'Dim navBar As DevExpress.XtraNavBar.NavBarControl = nbarDetalle
            'Dim gProducciones As NavBarGroup = New NavBarGroup("Producciones")
            'Dim gEnsambles As NavBarGroup = New NavBarGroup("Ensambles")
            'navBar.EndUpdate()




        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub nbgProducciones_ItemChanged(sender As Object, e As EventArgs) Handles nbgProducciones.ItemChanged
        'Try

        '    MsgBox(nbarDetalle.SelectedLink.Caption.ToString())
        'Catch ex As Exception
        '    mMensajes.msg_Error(ex.Message.ToString)
        'End Try
    End Sub

    Private Sub nbarDetalle_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles nbarDetalle.LinkClicked
        Try

            Dim dtProducciones As New DataTable()
            dtProducciones = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_OrdenesAbiertasProduccion_Hijo '" + e.Link.Caption.ToString() + "'")

            DsControlProduccionDetalle.Tables(DsControlProduccionDetalle.dsdtProducciones.TableName.ToString).Clear()
            If Not dtProducciones.Rows.Count = Nothing Then
                DsControlProduccionDetalle.Tables(DsControlProduccionDetalle.dsdtProducciones.TableName.ToString).Merge(dtProducciones)
            End If

            Dim dtEnsambles As New DataTable()
            dtEnsambles = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_OrdenesAbiertasEnsamble_Hijo '" + e.Link.Caption.ToString() + "'")

            DsControlProduccionDetalle.Tables(DsControlProduccionDetalle.dsdtEnsambles.TableName.ToString).Clear()

            If Not dtEnsambles.Rows.Count = Nothing Then
                DsControlProduccionDetalle.Tables(DsControlProduccionDetalle.dsdtEnsambles.TableName.ToString).Merge(dtEnsambles)
            End If


            '------------------------------------------------------------
            'BORRAR CONTROLES--------------------------------------------
            '------------------------------------------------------------

            spinBuenas.EditValue = 0
            spinMalas.EditValue = 0
            spinTotal.EditValue = 0
            spinPendientes.EditValue = 0
            spinEnsambles.EditValue = 0
            timeInicial.EditValue = "00:00"
            timeFinal.EditValue = "00:00"
            TimeTotal.EditValue = "00:00"
            dteTrabajoInicio.EditValue = Nothing
            dteTrabajoFinal.EditValue = Nothing
            mmeComentarios.EditValue = Nothing
            '------------------------------------------------------------
            'BUSCAR TRABAJO EN MAQUINA----------------------------------
            '------------------------------------------------------------
            Dim dtTrabajo_Maquina As New DataTable()
            dtTrabajo_Maquina = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.spPROD_Trabajo_Maquina '" + pMaquina + "','" + pCodigoArticulo + "'")

            If dtTrabajo_Maquina.Rows.Count = Nothing Then
                If MsgBox("Al parecer no tiene una fecha de inicio de trabajo! Desea establercerla como " + DateTime.Now().Date.ToString, MsgBoxStyle.YesNo, "Fecha Inicial de Trabajo...") = MsgBoxResult.Yes Then
                    dteTrabajoInicio.EditValue = DateTime.Now()
                End If
            Else
                dteTrabajoInicio.EditValue = dtTrabajo_Maquina.Rows(0)("FechaInicio")
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try


    End Sub

    Private Sub abangrdviewProducciones_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
        'Try
        '    spinBuenas.EditValue = colProducidos.SummaryItem.SummaryValue
        'Catch ex As Exception
        '    mMensajes.msg_Error(ex.Message.ToString)
        'End Try
    End Sub

    Private Sub abangrdviewProducciones_CustomDrawFooterCell(sender As Object, e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs)
        'Try
        '    spinBuenas.EditValue = colProducidos.SummaryItem.SummaryValue
        'Catch ex As Exception
        '    mMensajes.msg_Error(ex.Message.ToString)
        'End Try
    End Sub



    Private Sub frmControlProduccion_Detalle_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Me.Controls.Clear()
            Me.InitializeComponent()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub



    Private Sub lyviewProducciones_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles lyviewProducciones.CellValueChanged
        Try
            spinBuenas.EditValue = DsControlProduccionDetalle.dsdtProducciones.Compute("SUM(Producidos)", "")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    'Private Sub lyviewProducciones_HiddenEditor(sender As Object, e As EventArgs) Handles lyviewProducciones.HiddenEditor
    '    Try
    '        spinBuenas.EditValue = DsControlProduccionDetalle.dsdtProducciones.Compute("SUM(Producidos)", "")
    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message.ToString)
    '    End Try

    'End Sub

    Private Sub spinMalas_EditValueChanged(sender As Object, e As EventArgs) Handles spinMalas.EditValueChanged
        Try
            fcn_SumaProducciones()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub fcn_SumaProducciones()
        Try
            spinTotal.EditValue = Val(spinBuenas.EditValue) + Val(spinMalas.EditValue)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub spinBuenas_EditValueChanged(sender As Object, e As EventArgs) Handles spinBuenas.EditValueChanged
        Try
            fcn_SumaProducciones()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewEnsambles_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdviewEnsambles.CellValueChanged
        Try
            spinEnsambles.EditValue = DsControlProduccionDetalle.dsdtEnsambles.Compute("SUM(Producidos)", "")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub timeFinal_EditValueChanged(sender As Object, e As EventArgs) Handles timeFinal.EditValueChanged
        'Try
        '    fcn_CalculoHorasTrabajadas()
        'Catch ex As Exception
        '    mMensajes.msg_Error(ex.Message.ToString)
        'End Try
    End Sub

    Private Sub fcn_CalculoHorasTrabajadas()
        Try

            If timeFinal.EditValue = Nothing Then
                Exit Sub
            Else
                If timeInicial.EditValue > timeFinal.EditValue Then
                    mMensajes.msg_Informacion("La Hora Final no puede ser menor a la Hora Inicial.")
                    Exit Sub
                Else
                    TimeTotal.EditValue = timeFinal.EditValue - timeInicial.EditValue
                End If
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub timeInicial_EditValueChanged(sender As Object, e As EventArgs) Handles timeInicial.EditValueChanged
        'Try
        '    fcn_CalculoHorasTrabajadas()
        'Catch ex As Exception
        '    mMensajes.msg_Error(ex.Message.ToString)
        'End Try
    End Sub

    Private Sub timeFinal_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles timeFinal.EditValueChanging
        Try
            Dim pHoras As New TimeSpan
            pHoras = TimeSpan.FromHours(24)
            pHoras = pHoras + e.NewValue


            If e.NewValue = Nothing Then
                e.Cancel = True
                Exit Sub
            Else
                If timeInicial.EditValue > e.NewValue Then
                    TimeTotal.EditValue = pHoras - timeInicial.EditValue
                Else
                    TimeTotal.EditValue = e.NewValue - timeInicial.EditValue
                End If
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub timeInicial_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles timeInicial.EditValueChanging
        Try
            Dim pHoras As New TimeSpan
            pHoras = TimeSpan.FromHours(24)

            If timeFinal.EditValue = Nothing Then
                Exit Sub
            Else
                If e.NewValue > timeFinal.EditValue Then
                    TimeTotal.EditValue = (timeFinal.EditValue + pHoras) - e.NewValue
                Else
                    TimeTotal.EditValue = timeFinal.EditValue - e.NewValue
                End If
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub spinTotal_EditValueChanged(sender As Object, e As EventArgs) Handles spinTotal.EditValueChanged
        Try
            Dim pPendiente As Integer = 0
            Dim pProducido As Integer = 0
            pPendiente = DsControlProduccionDetalle.dsdtProducciones.Compute("SUM(Pendiente)", "")
            pProducido = DsControlProduccionDetalle.dsdtProducciones.Compute("SUM(Producidos)", "")

            spinPendientes.EditValue = pPendiente - pProducido
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub barbtnAceptar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAceptar.ItemClick
        Try


            If txtMaquina.EditValue = Nothing Then
                mMensajes.msg_Error("Falta Numero de Maquina!")
                Exit Sub
            End If

            If dteFechaTurno.EditValue = Nothing Then
                mMensajes.msg_Error("Falta Fecha de Turno!")
                Exit Sub
            End If

            If slueTurno.EditValue = Nothing Then
                mMensajes.msg_Error("Falta informacion de Turno!")
                Exit Sub
            End If

            If TimeTotal.EditValue = Nothing Then
                mMensajes.msg_Error("Debe ingresar Tiempo de Trabajo de Maquina!")
                Exit Sub
            End If

            If spinTotal.EditValue = Nothing And spinEnsambles.EditValue = Nothing Then
                mMensajes.msg_Error("Para continuar es necesario ingresar como minimo un Ensamble o una Orden de Producción!")
                Exit Sub
            End If





            Dim dtProducciones As New DataTable()
            dtProducciones = DsControlProduccionDetalle.dsdtProducciones

            Dim dtDetalleProduccion As New DataTable()
            Dim dtCerrar As New DataTable()
            Dim row As DataRow

            dtDetalleProduccion = GET_FORMATO_ControlProduccionRecibos()
            dtCerrar = GET_FORMATO_ControlProduccionRecibos()


            For i = 0 To dtProducciones.Rows.Count - 1
                If dtProducciones.Rows(i)("Producidos") > 0 Then
                    row = dtDetalleProduccion.NewRow
                    row("SAP") = dtProducciones.Rows(i)("NumeroSAP").ToString
                    row("Cargar") = dtProducciones.Rows(i)("Producidos").ToString
                    row("Comentarios") = dtProducciones.Rows(i)("Comentarios").ToString
                    dtDetalleProduccion.Rows.Add(row)
                End If
            Next

            Dim dtEnsambles As New DataTable()
            dtEnsambles = DsControlProduccionDetalle.dsdtEnsambles

            Dim dtDetalleEnsamble As New DataTable()
            Dim dtCerrarEnsamble As New DataTable()
            Dim rowEnsamble As DataRow

            dtDetalleEnsamble = GET_FORMATO_ControlProduccionRecibos()
            dtCerrarEnsamble = GET_FORMATO_ControlProduccionRecibos()


            For i = 0 To dtEnsambles.Rows.Count - 1
                If dtEnsambles.Rows(i)("Producidos") > 0 Then
                    rowEnsamble = dtDetalleEnsamble.NewRow
                    rowEnsamble("SAP") = dtEnsambles.Rows(i)("NumeroSAP").ToString
                    rowEnsamble("Cargar") = dtEnsambles.Rows(i)("Producidos").ToString
                    rowEnsamble("Comentarios") = dtEnsambles.Rows(i)("Comentarios").ToString
                    dtDetalleEnsamble.Rows.Add(rowEnsamble)
                End If
            Next


            'INICIO -----------------------------------------
            'COPIAR PARAMETROS-------------------------------
            '------------------------------------------------

            frmControlProduccion_Resumen.ppMaquina = txtMaquina.EditValue
            frmControlProduccion_Resumen.ppCodigoPadre = ppCodigoArticulo
            frmControlProduccion_Resumen.txtMaquina.EditValue = txtMaquina.EditValue
            frmControlProduccion_Resumen.dteInicioTrabajo.EditValue = dteTrabajoInicio.EditValue
            frmControlProduccion_Resumen.dteTurno.EditValue = dteFechaTurno.EditValue
            frmControlProduccion_Resumen.slueTurno.EditValue = slueTurno.EditValue
            frmControlProduccion_Resumen.spinBuenas.EditValue = spinBuenas.EditValue
            frmControlProduccion_Resumen.spinMalas.EditValue = spinMalas.EditValue
            frmControlProduccion_Resumen.spinTotalProduccion.EditValue = spinTotal.EditValue
            frmControlProduccion_Resumen.spinProduccionPendiente.EditValue = spinPendientes.EditValue
            frmControlProduccion_Resumen.spinTotalEnsambles.EditValue = spinEnsambles.EditValue
            frmControlProduccion_Resumen.timeInicial.EditValue = timeInicial.EditValue
            frmControlProduccion_Resumen.timeFinal.EditValue = timeFinal.EditValue
            frmControlProduccion_Resumen.timeTotalHoras.EditValue = TimeTotal.EditValue
            frmControlProduccion_Resumen.mmeComentarios.EditValue = mmeComentarios.EditValue

            '------------------------------------------------
            'COPIAR PARAMETROS-------------------------------
            'FINAL ------------------------------------------


            '------------------------------------------------
            'LLAMAR RESUMEN ---------------------------------
            '------------------------------------------------

            frmControlProduccion_Resumen.ppdtProducciones = dtDetalleProduccion
            frmControlProduccion_Resumen.ppdtEnsambles = dtDetalleEnsamble
            frmControlProduccion_Resumen.ShowDialog(Me)



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

End Class