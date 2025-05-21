Public Class frmAsignarComponentesMaquinas

    Private Sub frmAsignarComponentesMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Sub_CargarCodigosProducidos()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub Sub_CargarCodigosProducidos()
        Try
            Dim dt As New DataTable("dtCodigosProducidos")
            dt = mSQLSelect.GET_Listado_CodigosProducidos()

            If Not dt.Rows.Count = Nothing Then
                DsAsignarComponentesMaquinas1.Tables(DsAsignarComponentesMaquinas1.dsdtComponentes.TableName.ToString).Clear()
                DsAsignarComponentesMaquinas1.Tables(DsAsignarComponentesMaquinas1.dsdtComponentes.TableName.ToString).Merge(dt)
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
        

    End Sub

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnSeleccionar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSeleccionar.ItemClick
        Try
            Try
                Sub_SeleccionarComponente(mFunciones.FCN_GetCellValue(grdviewComponentes, "Id"))
            Catch ex As Exception
                mMensajes.msg_Error(ex.Message.ToString)
            End Try
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub Sub_SeleccionarComponente(ByVal pCodigoComponente As String)
        Try
            '---------------Llenar Controles de Referencia
            txtCodigoComponente.EditValue = pCodigoComponente
            txtNombreComponente.EditValue = mFunciones.FCN_GetCellValue(grdviewComponentes, "Descripcion")
            txtMolde.EditValue = mFunciones.FCN_GetCellValue(grdviewComponentes, "Molde")

            '-----------------Declarar Variables
            Dim dtMaquinasDisponibles As New DataTable()
            Dim pMaquinasAsignadas As String = "0"

            '-----------------Maquinas Asignadas
            '-----------------------------------
            Dim pComponente As String = mFunciones.FCN_GetCellValue(grdviewComponentes, "Id")
            Dim dt As New DataTable()
            dt = mSQLSelect.GET_Catalogo_ComponentesMaquinas(pComponente)
            'Borrar Grid Asignados
            DsAsignarComponentesMaquinas1.Tables(DsAsignarComponentesMaquinas1.dsdtMaquinasAsignadas.TableName.ToString).Clear()
            If Not dt.Rows.Count = Nothing Then
                DsAsignarComponentesMaquinas1.Tables(DsAsignarComponentesMaquinas1.dsdtMaquinasAsignadas.TableName.ToString).Merge(dt)
            End If

            '-----------------Maquinas Disponibles
            '-----------------------------------
            If Not grdviewMaquinasAsignadas.RowCount = Nothing Then
                pMaquinasAsignadas = mFunciones.FCN_GetColumn(grdviewMaquinasAsignadas, "Maquina")
            End If

            dtMaquinasDisponibles = mSQLSelect.GET_Catalogo_Maquinas_ConExcepciones(pMaquinasAsignadas)

            'Borrar Grid Disponibles
            DsAsignarComponentesMaquinas1.Tables(DsAsignarComponentesMaquinas1.dsdtMaquinasDisponibles.TableName.ToString).Clear()

            'Llenar Grid Disponibles
            If Not dtMaquinasDisponibles.Rows.Count = Nothing Then
                DsAsignarComponentesMaquinas1.Tables(DsAsignarComponentesMaquinas1.dsdtMaquinasDisponibles.TableName.ToString).Merge(dtMaquinasDisponibles)
            End If





        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewComponentes_DoubleClick(sender As Object, e As EventArgs) Handles grdviewComponentes.DoubleClick
        Try
            Sub_SeleccionarComponente(mFunciones.FCN_GetCellValue(grdviewComponentes, "Id"))
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewMaquinasDisponibles_DoubleClick(sender As Object, e As EventArgs) Handles grdviewMaquinasDisponibles.DoubleClick
        Try

            If grdviewMaquinasDisponibles.RowCount = Nothing Then
                Exit Sub
            End If

            Dim pComponente As String = String.Empty
            Dim pMaquinas As String = String.Empty
            Dim pPrioridad As String = String.Empty

            pComponente = txtCodigoComponente.EditValue
            pMaquinas = mFunciones.FCN_GetCellValue(grdviewMaquinasDisponibles, "Id")
            pPrioridad = grdviewMaquinasAsignadas.RowCount.ToString + 1

            If Not mSQLInsert.SET_ComponentesMaquinas(pComponente, pMaquinas, pPrioridad) Then
                mMensajes.msg_Proceso_Error()
            End If

            Sub_SeleccionarComponente(txtCodigoComponente.EditValue)


            '-----------PENDIENTE DE IMPLEMENTAR EN COMPONENTES SOLO EXISTE EN MOLDES
            '-----------------------------------------------------------------------

            'Dim dt As New DataTable("dtMoldesMaquinas")
            'dt = mSQLSelect.GET_Catalogo_MoldesMaquinas(txtId.EditValue.ToString)
            'If Not dt.Rows.Count = Nothing Then
            '    DsAsigMoldes_Maquinas_Agregar1.Tables("dsdtMaquinasAsignadas").Clear()
            '    DsAsigMoldes_Maquinas_Agregar1.Tables("dsdtMaquinasAsignadas").Merge(dt)
            'End If


            'If pPrioridad = 1 Then
            '    txtMPreferencial.EditValue = slueMaquinas.EditValue.ToString
            'mSQLUpdate.UPDATE_Molde_MaquinaPreferencial(txtId.EditValue.ToString, slueMaquinas.EditValue.ToString)
            'End If

            'slueMaquinas.EditValue = String.Empty
            'slueMaterial1.EditValue = String.Empty
            'slueMaterial2.EditValue = String.Empty


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEliminar.ItemClick
        Try
            If grdviewMaquinasAsignadas.RowCount = Nothing Then
                Exit Sub
            End If

            Dim pComponente As String = String.Empty
            Dim pMaquina As String = String.Empty

            pComponente = txtCodigoComponente.EditValue.ToString
            pMaquina = mFunciones.FCN_GetCellValue(grdviewMaquinasAsignadas, "Maquina")

            If MsgBox("Desea eliminar la Maquina [" + pMaquina + "] del Componente [" + pComponente + "] ? ", MsgBoxStyle.YesNo, "Eliminar") = MsgBoxResult.Yes Then
                If mSQLDelete.DELETE_Componente_Maquinas(pComponente, pMaquina) Then
                    Sub_SeleccionarComponente(pComponente)
                Else
                    mMensajes.msg_Proceso_Error()
                End If
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub FCN_MaquinasAsignadas_Enumerar()
        Try
            If DsAsignarComponentesMaquinas1.dsdtMaquinasAsignadas.Rows.Count = Nothing Then
                Exit Sub
            End If

            For i = 0 To DsAsignarComponentesMaquinas1.dsdtMaquinasAsignadas.Rows.Count - 1
                Dim pComponente As String = String.Empty
                    Dim pMaquina As String = String.Empty
                    Dim pPrioridad As String = String.Empty

                    pComponente = txtCodigoComponente.EditValue.ToString
                    pMaquina = DsAsignarComponentesMaquinas1.dsdtMaquinasAsignadas.Rows(i)("Maquina")
                    pPrioridad = i + 1

                If Not DsAsignarComponentesMaquinas1.dsdtMaquinasAsignadas.Rows(i)("Prioridad") = pPrioridad Then
                    DsAsignarComponentesMaquinas1.dsdtMaquinasAsignadas.Rows(i)("Prioridad") = pPrioridad
                    mSQLUpdate.UPDATE_ComponentesMaquinasAsignadas_Prioridad(pComponente, pMaquina, pPrioridad)
                End If
            Next
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewMaquinasAsignadas_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdviewMaquinasAsignadas.CellValueChanged
        Try
            Dim pComponente As String = String.Empty
            pComponente = txtCodigoComponente.EditValue.ToString

            FCN_MaquinasAsignadas_Enumerar()
            Sub_SeleccionarComponente(pComponente)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewMaquinasAsignadas_RowCountChanged(sender As Object, e As EventArgs) Handles grdviewMaquinasAsignadas.RowCountChanged
    End Sub

    Private Sub FCN_Habilitar_ControlesPrioridad()
        Try
            If grdviewMaquinasAsignadas.FocusedRowHandle = 0 Then
                barbtnSubir.Enabled = False
            Else
                barbtnSubir.Enabled = True
            End If

            If grdviewMaquinasAsignadas.FocusedRowHandle = grdviewMaquinasAsignadas.RowCount - 1 Then
                barbtnBajar.Enabled = False
            Else
                barbtnBajar.Enabled = True
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewMaquinasAsignadas_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdviewMaquinasAsignadas.FocusedRowChanged
        Try
            Dim pComponente As String = String.Empty
            pComponente = txtCodigoComponente.EditValue.ToString
            FCN_MaquinasAsignadas_Enumerar()

            FCN_Habilitar_ControlesPrioridad()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnBajar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBajar.ItemClick
        Try

            Dim pRowActual As Integer = -1
            Dim pComponente As String = String.Empty
            Dim pPrioridadActual As Integer = 0
            Dim pPrioridadSiguiente As Integer = 0
            Dim pMaquinaActual As Integer = 0
            Dim pMaquinaSiguiente As Integer = 0

            pRowActual = grdviewMaquinasAsignadas.FocusedRowHandle
            pComponente = txtCodigoComponente.EditValue.ToString
            pPrioridadActual = mFunciones.FCN_GetCellValue(grdviewMaquinasAsignadas, "Prioridad")
            pPrioridadSiguiente = pPrioridadActual + 1
            pMaquinaActual = mFunciones.FCN_GetCellValue(grdviewMaquinasAsignadas, "Maquina", pRowActual)
            pMaquinaSiguiente = mFunciones.FCN_GetCellValue(grdviewMaquinasAsignadas, "Maquina", pRowActual + 1)

            If grdviewMaquinasAsignadas.FocusedRowHandle < 0 Then
                mMensajes.msg_Informacion("Seleccione una maquina")
                Exit Sub
            End If

            If mSQLUpdate.UPDATE_ComponenteMaquinas_Prioridad(pComponente, pMaquinaActual, pPrioridadSiguiente.ToString) Then
                mSQLUpdate.UPDATE_ComponenteMaquinas_Prioridad(pComponente, pMaquinaSiguiente, pPrioridadActual.ToString)
            End If

            Sub_SeleccionarComponente(pComponente)

            If Not pPrioridadSiguiente = -1 Then
                grdviewMaquinasAsignadas.FocusedRowHandle = pPrioridadSiguiente - 1
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnSubir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSubir.ItemClick
        Try

            Dim pRowActual As Integer = -1
            Dim pComponente As String = String.Empty
            Dim pPrioridadActual As Integer = 0
            Dim pPrioridadAnterior As Integer = 0
            Dim pMaquinaActual As Integer = 0
            Dim pMaquinaAnterior As Integer = 0

            pRowActual = grdviewMaquinasAsignadas.FocusedRowHandle
            pComponente = txtCodigoComponente.EditValue.ToString
            pPrioridadActual = mFunciones.FCN_GetCellValue(grdviewMaquinasAsignadas, "Prioridad")
            pPrioridadAnterior = pPrioridadActual - 1
            pMaquinaActual = mFunciones.FCN_GetCellValue(grdviewMaquinasAsignadas, "Maquina", pRowActual)
            pMaquinaAnterior = mFunciones.FCN_GetCellValue(grdviewMaquinasAsignadas, "Maquina", pRowActual - 1)

            If grdviewMaquinasAsignadas.FocusedRowHandle < 0 Then
                mMensajes.msg_Informacion("Seleccione una maquina")
                Exit Sub
            End If

            If mSQLUpdate.UPDATE_ComponenteMaquinas_Prioridad(pComponente, pMaquinaActual, pPrioridadAnterior.ToString) Then
                mSQLUpdate.UPDATE_ComponenteMaquinas_Prioridad(pComponente, pMaquinaAnterior, pPrioridadActual.ToString)
            End If

            Sub_SeleccionarComponente(pComponente)

            If Not pPrioridadAnterior = -1 Then
                grdviewMaquinasAsignadas.FocusedRowHandle = pPrioridadAnterior - 1
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub



    Private Sub grdviewMaquinasAsignadas_GotFocus(sender As Object, e As EventArgs) Handles grdviewMaquinasAsignadas.GotFocus
        Try
            barbtnSubir.Enabled = True
            barbtnBajar.Enabled = True
            barbtnEliminar.Enabled = True
            FCN_Habilitar_ControlesPrioridad()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewMaquinasAsignadas_LostFocus(sender As Object, e As EventArgs) Handles grdviewMaquinasAsignadas.LostFocus
        Try
            barbtnSubir.Enabled = False
            barbtnBajar.Enabled = False
            barbtnEliminar.Enabled = False
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            If grdviewComponentes.IsFocusedView() Then
                grdviewComponentes.ShowRibbonPrintPreview()
            ElseIf grdviewMaquinasDisponibles.IsFocusedView() Then
                grdviewMaquinasDisponibles.ShowRibbonPrintPreview()
            ElseIf grdviewMaquinasAsignadas.IsFocusedView() Then
                grdviewMaquinasAsignadas.ShowRibbonPrintPreview()
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try
            If grdviewComponentes.IsFocusedView() Then
                mFunciones.FCN_XTRAGRID_Buscar(grdviewComponentes)
            ElseIf grdviewMaquinasDisponibles.IsFocusedView() Then
                mFunciones.FCN_XTRAGRID_Buscar(grdviewMaquinasDisponibles)
            ElseIf grdviewMaquinasAsignadas.IsFocusedView() Then
                mFunciones.FCN_XTRAGRID_Buscar(grdviewMaquinasAsignadas)
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

End Class