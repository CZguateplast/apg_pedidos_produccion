Public Class frmAsignarMoldesMaquinas

    Private Sub frmAsigMoldes_Maquinas_Agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mSeguridad.APG_Seguridad(Me, barbtnAgregar)
            mSeguridad.APG_Seguridad(Me, barbtnEliminar)

            Sub_Listado_Moldes()

            mFunciones.FCN_FILL_SearchLookUpEdit(slueMaterial1, mSQLSelect.GET_Listado_Materiales(), "Id", "Id")
            mFunciones.FCN_FILL_SearchLookUpEdit(slueMaterial2, mSQLSelect.GET_Listado_Materiales(), "Id", "Id")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Listado_Moldes()
        Dim dt As New DataTable("dtMoldes")
        dt = mSQLSelect.GET_Search_Molde()

        If Not dt.Rows.Count = Nothing Then
            DsAsigMoldes_Maquinas_Agregar1.Tables("dsdtMoldes").Clear()
            DsAsigMoldes_Maquinas_Agregar1.Tables("dsdtMoldes").Merge(dt)
        End If

    End Sub

    Private Sub grdviewMoldes_DoubleClick(sender As Object, e As EventArgs) Handles grdviewMoldes.DoubleClick
        Try
            Sub_SeleccionarMolde()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_SeleccionarMolde()
        Try
            txtId.EditValue = mFunciones.FCN_GetCellValue(grdviewMoldes, "Id", grdviewMoldes.FocusedRowHandle)
            txtNombre.EditValue = mFunciones.FCN_GetCellValue(grdviewMoldes, "Nombre", grdviewMoldes.FocusedRowHandle)
            txtCavidades.EditValue = mFunciones.FCN_GetCellValue(grdviewMoldes, "Cavidades", grdviewMoldes.FocusedRowHandle)
            txtMPreferencial.EditValue = mFunciones.FCN_GetCellValue(grdviewMoldes, "MaquinaPreferencial", grdviewMoldes.FocusedRowHandle)
            mmeComentarios.EditValue = mFunciones.FCN_GetCellValue(grdviewMoldes, "Comentarios", grdviewMoldes.FocusedRowHandle)

            Dim pMolde As String = mFunciones.FCN_GetCellValue(grdviewMoldes, "Id")
            Dim dt As New DataTable("dtMoldesMaquinas")
            dt = mSQLSelect.GET_Catalogo_MoldesMaquinas(pMolde)
            If Not dt.Rows.Count = Nothing Then
                DsAsigMoldes_Maquinas_Agregar1.Tables("dsdtMaquinasAsignadas").Clear()
                DsAsigMoldes_Maquinas_Agregar1.Tables("dsdtMaquinasAsignadas").Merge(dt)
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub LimpiarVistaPrevia()
        Try
            txtId.EditValue = String.Empty
            txtNombre.EditValue = String.Empty
            txtCavidades.EditValue = String.Empty
            txtMPreferencial.EditValue = String.Empty
            mmeComentarios.EditValue = String.Empty

            DsAsigMoldes_Maquinas_Agregar1.Tables("dsdtMaquinasAsignadas").Clear()

            slueMaquinas.EditValue = String.Empty
            slueMaterial1.EditValue = String.Empty
            slueMaterial2.EditValue = String.Empty




        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewMoldes_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdviewMoldes.FocusedRowChanged
        Try
            LimpiarVistaPrevia()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    

    Private Sub slueMaquinas_GotFocus(sender As Object, e As EventArgs) Handles slueMaquinas.GotFocus
        Try
            Dim pMaquinasAsignadas As String = mFunciones.FCN_GET_Columna(grdviewMaquinasAsignadas, "Maquina")
            Dim dt As New DataTable("pMaquinas")
            dt = mSQLSelect.GET_Listado_MaquinasNoAsignadas(pMaquinasAsignadas)

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            mFunciones.FCN_FILL_SearchLookUpEdit(slueMaquinas, dt, "id", "id")




        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAgregar.ItemClick
        Try
            Dim pMaterial1 As String = String.Empty
            If txtId.EditValue.ToString = String.Empty Or _
                slueMaquinas.EditValue.ToString = String.Empty Then
                mMensajes.msg_Informacion("Para agregar una maquina es necesario el [Molde] + [Maquina]. Verifique la información.")
                Exit Sub
            End If

            If MsgBox("Desea asignar el Molde [" + txtId.EditValue.ToString + "] a la Maquina [" + slueMaquinas.EditValue.ToString + "] para poder trabajar?", MsgBoxStyle.YesNo, "Grabar") = MsgBoxResult.No Then
                Exit Sub
            End If

            Dim pPrioridad As String = grdviewMaquinasAsignadas.RowCount.ToString + 1
            If slueMaterial1.EditValue = Nothing Then
                pMaterial1 = String.Empty
            Else
                pMaterial1 = slueMaterial1.EditValue
            End If

            If Not mSQLInsert.SET_Moldes_Maquinas(txtId.EditValue.ToString, slueMaquinas.EditValue.ToString, slueMaterial1.EditValue.ToString, slueMaterial2.EditValue.ToString, pPrioridad) Then
                mMensajes.msg_Error("Se ha producido un error al querer asignar la Maquina al molde. Intente de Nuevo. Si el problema sigue comuniquese al departamento de Informatica.")
            End If

            Dim dt As New DataTable("dtMoldesMaquinas")
            dt = mSQLSelect.GET_Catalogo_MoldesMaquinas(txtId.EditValue.ToString)
            If Not dt.Rows.Count = Nothing Then
                DsAsigMoldes_Maquinas_Agregar1.Tables("dsdtMaquinasAsignadas").Clear()
                DsAsigMoldes_Maquinas_Agregar1.Tables("dsdtMaquinasAsignadas").Merge(dt)
            End If


            If pPrioridad = 1 Then
                txtMPreferencial.EditValue = slueMaquinas.EditValue.ToString
                mSQLUpdate.UPDATE_Molde_MaquinaPreferencial(txtId.EditValue.ToString, slueMaquinas.EditValue.ToString)
            End If

            slueMaquinas.EditValue = String.Empty
            slueMaterial1.EditValue = String.Empty
            slueMaterial2.EditValue = String.Empty


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    
    Private Sub barbtnEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEliminar.ItemClick
        Try
            If grdviewMaquinasAsignadas.RowCount = Nothing Then
                Exit Sub
            End If

            Dim pMaquina As String = mFunciones.FCN_GetCellValue(grdviewMaquinasAsignadas, "Maquina", grdviewMaquinasAsignadas.FocusedRowHandle)

            If pMaquina = String.Empty Then : Exit Sub : End If

            If MsgBox("Desea eliminar la Maquina [" + pMaquina + "] del molde [" + txtId.EditValue.ToString + "] ? ", MsgBoxStyle.YesNo, "Eliminar") = MsgBoxResult.Yes Then
                If mSQLDelete.DELETE_Moldes_Maquinas(txtId.EditValue.ToString, pMaquina) Then
                    mMensajes.msg_Proceso_ok()
                Else
                    mMensajes.msg_Proceso_Error()
                End If
            End If

            Dim dt As New DataTable("dtMoldesMaquinas")
            dt = mSQLSelect.GET_Catalogo_MoldesMaquinas(txtId.EditValue.ToString)
            If Not dt.Rows.Count = Nothing Then
                DsAsigMoldes_Maquinas_Agregar1.Tables("dsdtMaquinasAsignadas").Clear()
                DsAsigMoldes_Maquinas_Agregar1.Tables("dsdtMaquinasAsignadas").Merge(dt)
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnSeleccionar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSeleccionar.ItemClick
        Try
            If grdviewMoldes.SelectedRowsCount = 0 Then
                Exit Sub
            End If
            Sub_SeleccionarMolde()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    
    Private Sub grdviewMaquinasAsignadas_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdviewMaquinasAsignadas.FocusedRowChanged
        Try
            If grdviewMaquinasAsignadas.FocusedRowHandle = grdviewMaquinasAsignadas.RowCount - 1 Then
                barbtnPrioridadAbajo.Enabled = False
            Else
                barbtnPrioridadAbajo.Enabled = True
            End If

            If grdviewMaquinasAsignadas.FocusedRowHandle = 0 Then
                barbtnPrioridadArriba.Enabled = False
            Else
                barbtnPrioridadArriba.Enabled = True
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnPrioridadArriba_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnPrioridadArriba.ItemClick
        Try
            Dim pPrioridadActual As Integer = grdviewMaquinasAsignadas.FocusedRowHandle + 1
            Dim pPrioridadAnterior As Integer = -1
            Dim pMaquinaActual As Integer = -1
            Dim pMaquinaAnterior As Integer = -1

            If grdviewMaquinasAsignadas.FocusedRowHandle < 0 Then
                mMensajes.msg_Informacion("Seleccione una maquina")
                Exit Sub
            End If

            If grdviewMaquinasAsignadas.FocusedRowHandle > 0 Then
                pPrioridadActual = grdviewMaquinasAsignadas.FocusedRowHandle + 1
                pPrioridadAnterior = pPrioridadActual - 1

                

                pMaquinaActual = mSQLSelect.GET_MoldeMaquinaXPrioridad(txtId.EditValue.ToString, pPrioridadActual)
                pMaquinaAnterior = mSQLSelect.GET_MoldeMaquinaXPrioridad(txtId.EditValue.ToString, pPrioridadAnterior.ToString)

                If pPrioridadAnterior = 1 Then
                    If MsgBox("Esta seguro que desea establecer la maquina [" + pMaquinaActual.ToString + "] como maquina Preferencial del Molde [" + txtId.EditValue.ToString + "] ?", MsgBoxStyle.YesNo, "Maquina Preferencial") = MsgBoxResult.No Then
                        Exit Sub
                    Else
                        mSQLUpdate.UPDATE_Molde_MaquinaPreferencial(txtId.EditValue.ToString, pMaquinaActual.ToString)
                        txtMPreferencial.EditValue = pMaquinaActual.ToString
                    End If
                End If



                mSQLUpdate.UPDATE_MoldeMaquinas_Prioridad(txtId.EditValue.ToString, pMaquinaAnterior.ToString, pPrioridadActual.ToString)
                mSQLUpdate.UPDATE_MoldeMaquinas_Prioridad(txtId.EditValue.ToString, pMaquinaActual.ToString, pPrioridadAnterior.ToString)

                Dim dt As New DataTable("dtMaquinasAsignadas")
                dt = mSQLSelect.GET_Catalogo_MoldesMaquinas(txtId.EditValue.ToString)
                If Not dt.Rows.Count = Nothing Then
                    DsAsigMoldes_Maquinas_Agregar1.Tables("dsdtMaquinasAsignadas").Clear()
                    DsAsigMoldes_Maquinas_Agregar1.Tables("dsdtMaquinasAsignadas").Merge(dt)
                End If

                If pPrioridadAnterior > -1 Then
                    grdviewMaquinasAsignadas.FocusedRowHandle = pPrioridadAnterior - 1
                End If

                If pPrioridadAnterior = 1 Then
                    txtMPreferencial.EditValue = pMaquinaActual
                    Sub_Listado_Moldes()
                End If
            End If

            'If pPrioridadActual < 1 Then
            '    pPrioridadAnterior = -1
            'Else

            'End If



            'If Not pPrioridadAnterior < 0 Then


            'End If

            'If pPrioridadAnterior > -1 Then

            'End If






        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnPrioridadAbajo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnPrioridadAbajo.ItemClick
        Try
            Dim pPrioridadActual As Integer = grdviewMaquinasAsignadas.FocusedRowHandle + 1
            Dim pPrioridadSiguiente As Integer = -1
            Dim pMaquinaActual As Integer = -1
            Dim pMaquinaSiguiente As Integer = -1
            Dim pCantidadMaquinas As Integer = grdviewMaquinasAsignadas.RowCount

            If grdviewMaquinasAsignadas.FocusedRowHandle < 0 Then
                mMensajes.msg_Informacion("Seleccione una maquina")
                Exit Sub
            End If

            If pPrioridadActual = pCantidadMaquinas Then
                pPrioridadSiguiente = -1
            Else
                pPrioridadSiguiente = pPrioridadActual + 1
            End If

            


            pMaquinaActual = mSQLSelect.GET_MoldeMaquinaXPrioridad(txtId.EditValue.ToString, pPrioridadActual)

            If Not pPrioridadSiguiente = -1 Then
                pMaquinaSiguiente = mSQLSelect.GET_MoldeMaquinaXPrioridad(txtId.EditValue.ToString, pPrioridadSiguiente.ToString)

                If pPrioridadActual = 1 Then
                    If MsgBox("Esta seguro que desea establecer la maquina [" + pMaquinaSiguiente.ToString + "] como maquina Preferencial del Molde [" + txtId.EditValue.ToString + "] ?", MsgBoxStyle.YesNo, "Maquina Preferencial") = MsgBoxResult.No Then
                        Exit Sub
                    Else
                        txtMPreferencial.EditValue = pMaquinaSiguiente.ToString
                        mSQLUpdate.UPDATE_Molde_MaquinaPreferencial(txtId.EditValue.ToString, pMaquinaSiguiente.ToString)
                        Sub_Listado_Moldes()
                    End If
                End If




                mSQLUpdate.UPDATE_MoldeMaquinas_Prioridad(txtId.EditValue.ToString, pMaquinaSiguiente.ToString, pPrioridadActual.ToString)
            End If

            If Not pPrioridadSiguiente = -1 Then
                mSQLUpdate.UPDATE_MoldeMaquinas_Prioridad(txtId.EditValue.ToString, pMaquinaActual.ToString, pPrioridadSiguiente.ToString)
            End If

            Dim dt As New DataTable("dtMaquinasAsignadas")
            dt = mSQLSelect.GET_Catalogo_MoldesMaquinas(txtId.EditValue.ToString)
            If Not dt.Rows.Count = Nothing Then
                DsAsigMoldes_Maquinas_Agregar1.Tables("dsdtMaquinasAsignadas").Clear()
                DsAsigMoldes_Maquinas_Agregar1.Tables("dsdtMaquinasAsignadas").Merge(dt)
            End If

            If Not pPrioridadSiguiente = -1 Then
                grdviewMaquinasAsignadas.FocusedRowHandle = pPrioridadSiguiente - 1
            End If



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class