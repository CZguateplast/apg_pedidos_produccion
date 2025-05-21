Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Public Class frmReciboProduccionEnsamble

    Private mCodigoArticulo As String

    Public Property vpCodigoArticulo() As String
        Get
            Return mCodigoArticulo
        End Get
        Set(ByVal Value As String)
            mCodigoArticulo = Value
        End Set
    End Property

    Private Sub frmReciboProduccionEnsamble_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            mCodigoArticulo = String.Empty
            slueCodigoArticulo.EditValue = String.Empty
            DsReciboProduccionEnsamble1.Tables(DsReciboProduccionEnsamble1.dsdtReciboProduccionEnsamble.TableName.ToString).Clear()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub



    Private Sub frmReciboProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            dteFecha.EditValue = DateTime.Now
            mFunciones.FCN_FILL_SearchLookUpEdit(slueCodigoArticulo, mSQLSelect.GET_Catalogo_AR_CP_Padres(), "CodigoArticulo", "CodigoArticulo")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueSAP, GET_OrdenesProduccionEnsamble_PendienteAplicar(slueTipo.EditValue.ToString), "SAP", "SAP")
            mFunciones.FCN_FILL_SearchLookUpEdit(slueTipo, GET_Listado("Tipo_OWOR"), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueDestinoBodega, mSQLSelect.GET_Listado_Bodegas(), "Id", "Nombre")



            If mCodigoArticulo = String.Empty Then
                slueCodigoArticulo.EditValue = String.Empty
            Else
                slueCodigoArticulo.EditValue = mCodigoArticulo
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub slueCodigoArticulo_EditValueChanged(sender As Object, e As EventArgs) Handles slueCodigoArticulo.EditValueChanged
        'Try


        '    Dim dtCodigoArticulo As New DataTable()
        '    dtCodigoArticulo = mSQLSelect.GET_Articulo("'" + slueCodigoArticulo.EditValue + "'")
        '    If dtCodigoArticulo.Rows.Count = Nothing Then
        '        txtNombreArticulo.EditValue = String.Empty
        '        Exit Sub
        '    End If
        '    If slueTipo.EditValue = Nothing Then
        '        mMensajes.msg_Informacion("Debe ingresar un tipo de busqueda")
        '        Exit Sub
        '    End If


        '    txtNombreArticulo.EditValue = dtCodigoArticulo.Rows(0)("NombreArticulo").ToString

        '    Dim dtOrdenesPendientesAplicar As New DataTable()
        '    dtOrdenesPendientesAplicar = GET_OrdenesProduccionEnsamble_Aplicar(slueCodigoArticulo.EditValue.ToString.Substring(0, 8).ToString, slueTipo.EditValue)

        '    If dtOrdenesPendientesAplicar.Rows.Count = Nothing Then
        '        DsReciboProduccionEnsamble1.Tables(DsReciboProduccionEnsamble1.dsdtReciboProduccionEnsamble.TableName.ToString).Clear()
        '        mMensajes.msg_Informacion("NO existen ordenes de Produccion o Ensamble pendientes de aplicar!. Intente con otro Item.")
        '        Exit Sub
        '    End If

        '    DsReciboProduccionEnsamble1.Tables(DsReciboProduccionEnsamble1.dsdtReciboProduccionEnsamble.TableName.ToString).Clear()
        '    DsReciboProduccionEnsamble1.Tables(DsReciboProduccionEnsamble1.dsdtReciboProduccionEnsamble.TableName.ToString).Merge(dtOrdenesPendientesAplicar)






        'Catch ex As Exception
        '    mMensajes.msg_Error(ex.Message.ToString)
        'End Try
    End Sub


    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewReciboProduccionEnsamble_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles grdviewReciboProduccionEnsamble.CellValueChanged
        Try
            If e.Column.FieldName = "SAP" Then
                Dim dt As New DataTable

                dt = mSQLSelect.GET_OrdenesProduccionEnsamble_Aplicar_NumSAP(e.Value.ToString)

                If dt.Rows.Count = Nothing Then : Exit Sub : End If

                grdviewReciboProduccionEnsamble.SetRowCellValue(e.RowHandle, "Estado", dt.Rows(0)("Estado").ToString)
                grdviewReciboProduccionEnsamble.SetRowCellValue(e.RowHandle, "Bodega", dt.Rows(0)("Bodega").ToString)
                grdviewReciboProduccionEnsamble.SetRowCellValue(e.RowHandle, "CodigoArticulo", dt.Rows(0)("CodigoArticulo").ToString)
                grdviewReciboProduccionEnsamble.SetRowCellValue(e.RowHandle, "NombreArticulo", dt.Rows(0)("NombreArticulo").ToString)
                grdviewReciboProduccionEnsamble.SetRowCellValue(e.RowHandle, "Stock", dt.Rows(0)("Stock").ToString)
                grdviewReciboProduccionEnsamble.SetRowCellValue(e.RowHandle, "Comprometido", dt.Rows(0)("Comprometido").ToString)
                grdviewReciboProduccionEnsamble.SetRowCellValue(e.RowHandle, "Planeado", dt.Rows(0)("Planeado").ToString)
                grdviewReciboProduccionEnsamble.SetRowCellValue(e.RowHandle, "Completado", dt.Rows(0)("Completado").ToString)
                grdviewReciboProduccionEnsamble.SetRowCellValue(e.RowHandle, "Pendiente", dt.Rows(0)("Pendiente").ToString)
                grdviewReciboProduccionEnsamble.SetRowCellValue(e.RowHandle, "Comentarios", dt.Rows(0)("Comentarios").ToString)



                If dt.Rows(0)("Estado").ToString = "Planeado" Then
                    If MsgBox("Para poder continuar debe liberar la orden seleccionada. " + Environment.NewLine + "Desea Liberarla", MsgBoxStyle.YesNo, "SAP...") = MsgBoxResult.Yes Then
                        If Not ssmEsperar.IsSplashFormVisible Then : ssmEsperar.ShowWaitForm() : End If
                        ssmEsperar.SetWaitFormCaption("Liberando Orden")
                        ssmEsperar.SetWaitFormDescription(dt.Rows(0)("SAP").ToString)
                        mDIAPI.SAP_DIAPI_Produccion_StatusLiberado(dt.Rows(0)("SAP").ToString)
                        grdviewReciboProduccionEnsamble.SetRowCellValue(e.RowHandle, "Estado", "Liberado")
                        If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
                    End If
                End If

            End If

            Dim pRow As Integer = grdviewReciboProduccionEnsamble.FocusedRowHandle
            Dim pcolumns As String = grdviewReciboProduccionEnsamble.FocusedColumn.FieldName

            If pRow = grdviewReciboProduccionEnsamble.RowCount - 1 And pcolumns = "Cargar" Then
                grdviewReciboProduccionEnsamble.FocusedRowHandle = grdviewReciboProduccionEnsamble.RowCount - 2
            End If

            'Dim View As GridView = CType(sender, GridView)
            ''Dim pCargar As Int32 = CType(View.GetRowCellValue(e.RowHandle, colCargar), Int32)
            'Dim pCargar As Int32
            'If Not IsDBNull(CType(View.GetRowCellValue(e.RowHandle, colCargar), Int32)) Then : pCargar = CType(View.GetRowCellValue(e.RowHandle, colCargar), Int32) : End If


            'If pCargar > 0 Then
            '    MsgBox("Verificar bodegas")
            '    RevisarBodega()

            'End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
        End Try
    End Sub


    Private Sub grdviewReciboProduccionEnsamble_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles grdviewReciboProduccionEnsamble.ValidateRow
        Try
            Dim View As GridView = CType(sender, GridView)
            Dim pcolPendiente As GridColumn = View.Columns("Pendiente")
            Dim pcolCargar As GridColumn = View.Columns("Cargar")

            If Not IsNumeric(mFunciones.FCN_GetCellValue(grdviewReciboProduccionEnsamble, "Cargar", e.RowHandle)) Then
                mMensajes.msg_Informacion("Para poder continuar debe ingresar una cantidad valida. Intente de Nuevo")
                e.Valid = False
                Exit Sub
            End If

            Dim pPendientes As Int32 = CType(View.GetRowCellValue(e.RowHandle, colPendiente), Int32)
            Dim pCargar As Int32 = CType(View.GetRowCellValue(e.RowHandle, colCargar), Int32)

            If pCargar > 0 Then
                MsgBox("Verificar bodegas")
                RevisarBodega()

            End If



            If pCargar > pPendientes Then
                If MsgBox("La cantidad para cargar [ " + pCargar.ToString + " ] es mayor a la cantidad pendiente [ " + pPendientes.ToString + " ]." + Environment.NewLine + " Desea Continuar?", MsgBoxStyle.YesNo, "Error") = MsgBoxResult.Yes Then
                    e.Valid = True
                Else
                    e.Valid = False

                End If
            End If

            '**********************VALIDAR ESTADO DE LA ORDEN DE PRODUCCION QUE SE ENCUENTRE EN LIBERADO PARA PODER APLICAR RECIBO *************************
            If mFunciones.FCN_GetCellValue(grdviewReciboProduccionEnsamble, "Estado", e.RowHandle) = "Planeado" Then
                If MsgBox("Para poder aplicar un Recibo debe liberar la Orden. " + Environment.NewLine + "Desea Liberarla?", MsgBoxStyle.YesNo, "SAP...") = MsgBoxResult.Yes Then
                    If Not ssmEsperar.IsSplashFormVisible Then : ssmEsperar.ShowWaitForm() : End If
                    ssmEsperar.SetWaitFormCaption("Liberando Orden...")
                    ssmEsperar.SetWaitFormDescription(mFunciones.FCN_GetCellValue(grdviewReciboProduccionEnsamble, "SAP", e.RowHandle))
                    mDIAPI.SAP_DIAPI_Produccion_StatusLiberado(mFunciones.FCN_GetCellValue(grdviewReciboProduccionEnsamble, "SAP", e.RowHandle))
                    grdviewReciboProduccionEnsamble.SetRowCellValue(e.RowHandle, "Estado", "Liberado")
                    If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
                    e.Valid = True
                Else
                    e.Valid = False
                End If
            End If

            '**********************RECOMENDAR CERRAR LA ORDEN ACTUAL POR SER UNA CANTIDAD MUY ESCASA PARA MANTENER ABIERTA *************************

            Dim pDiferencia As Int32 = CType(pPendientes - pCargar, Int32)
            Dim pPorcPendiente As Int32 = ((pDiferencia * 100) / pPendientes)

            If pPorcPendiente <= 0 Then
                If MsgBox("Segun el saldo de la Orden despues de aplicado el recibo es cero [0]. " + Environment.NewLine + "Desea Cerrar la Orden durante el proceso?", MsgBoxStyle.YesNo, "SAP...") = MsgBoxResult.Yes Then
                    grdviewReciboProduccionEnsamble.SetRowCellValue(e.RowHandle, "Cerrar", "True")
                    e.Valid = True
                Else
                    e.Valid = True
                End If
            ElseIf pPorcPendiente < 5 Then
                If MsgBox("Segun el saldo de la Orden despues de aplicado el recibo es menos de un [ " + pPorcPendiente.ToString + " %]. " + Environment.NewLine + "Desea Cerrar la Orden durante el proceso?", MsgBoxStyle.YesNo, "SAP...") = MsgBoxResult.Yes Then
                    grdviewReciboProduccionEnsamble.SetRowCellValue(e.RowHandle, "Cerrar", "True")
                    e.Valid = True
                Else
                    e.Valid = True
                End If
            End If




        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub grdviewReciboProduccionEnsamble_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles grdviewReciboProduccionEnsamble.InvalidRowException
        Try
            e.ExceptionMode = ExceptionMode.NoAction
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    'Private Sub grdviewReciboProduccionEnsamble_ValidatingEditor(sender As Object, e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles grdviewReciboProduccionEnsamble.ValidatingEditor
    '    Try

    '        If TryCast(e, EditFormValidateEditorEventArgs).Column.Name = "colCargar" Then
    '            Dim pPendiente As String = mFunciones.FCN_GetCellValue(grdviewReciboProduccionEnsamble, "Pendiente")
    '            Dim pCargar As String = e.Value

    '            If Not pPendiente = String.Empty Or Not pCargar = String.Empty Then
    '                If Val(pCargar) > (pPendiente) Then
    '                    If MsgBox("La cantidad para cargar es mayor a la pendiente de aplicar. Desea Continuar?", MsgBoxStyle.YesNo, "Error") = MsgBoxResult.No Then
    '                        e.Valid = False
    '                    End If
    '                End If
    '            End If
    '        End If

    '        e.Valid = True

    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message.ToString)
    '    End Try
    'End Sub

    
    Private Sub barbtnSAP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSAP.ItemClick
        Try
            If MsgBox("Favor de verificar si esta consumiendo de las bodegas correctas.  Desea continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            Else

                grdviewReciboProduccionEnsamble.CloseEditor()

                Dim dtDetalle As New DataTable()
                Dim dtCerrar As New DataTable()
                Dim row As DataRow

                dtDetalle = GET_OrdenesProduccionEnsamble_Aplicar("Nothing", "Nothing")
                dtCerrar = GET_OrdenesProduccionEnsamble_Aplicar("Nothing", "Nothing")

                For i = 0 To grdviewReciboProduccionEnsamble.RowCount - 1
                    If mFunciones.FCN_GetCellValue(grdviewReciboProduccionEnsamble, "Cargar", i) > 0 Then
                        row = dtDetalle.NewRow
                        row("SAP") = mFunciones.FCN_GetCellValue(grdviewReciboProduccionEnsamble, "SAP", i)
                        row("Bodega") = mFunciones.FCN_GetCellValue(grdviewReciboProduccionEnsamble, "Bodega", i)
                        row("Cargar") = mFunciones.FCN_GetCellValue(grdviewReciboProduccionEnsamble, "Cargar", i)
                        dtDetalle.Rows.Add(row)
                    End If
                Next



                Select Case slueTipo.EditValue
                    Case "S"     'ESTANDAR --------------------------------------------------------------------------------------------------

                        Dim pFecha As String = mFunciones.ConvertirFechaSQL(dteFecha)
                        If SAP_DIAPI_RecibosProduccion(pFecha, dtDetalle, txtRef2.EditValue, txtComentarioRecibo.EditValue, ssmEsperar) Then
                        End If

                    Case "D"    ' DESMONTAR ---------------------------------------------------------------------------------------------------------------------

                        SAP_DIAPI_EmisionProduccion(mFunciones.ConvertirFechaSQL(dteFecha), txtRef2.EditValue, txtComentarioRecibo.EditValue,
                                                    DsReciboProduccionEnsamble1.dsdtReciboProduccionEnsamble, ssmEsperar)

                    Case "P"    ' ESPECIAL ---------------------------------------------------------------------------------------------------------------------
                        mMensajes.msg_Informacion("No hay procedimiento establecido para este tipo. " + Environment.NewLine + "Comuniquese a Informatica.")
                End Select


                'CERRAR ORDENES DE ENSAMBLEPRODUCCION
                For i = 0 To grdviewReciboProduccionEnsamble.RowCount - 1
                    If mFunciones.FCN_GetCellValue(grdviewReciboProduccionEnsamble, "Cerrar", i) = True Then
                        row = dtCerrar.NewRow
                        row("SAP") = mFunciones.FCN_GetCellValue(grdviewReciboProduccionEnsamble, "SAP", i)
                        row("Estado") = mFunciones.FCN_GetCellValue(grdviewReciboProduccionEnsamble, "Estado", i)
                        dtCerrar.Rows.Add(row)
                    End If
                Next

                If Not dtCerrar.Rows.Count = Nothing Then
                    If Not ssmEsperar.IsSplashFormVisible Then : ssmEsperar.ShowWaitForm() : End If
                    ssmEsperar.SetWaitFormCaption("Cerrando Orden")
                    ssmEsperar.SetWaitFormDescription("Espere...")
                    For i = 0 To dtCerrar.Rows.Count - 1
                        ssmEsperar.SetWaitFormDescription(dtCerrar.Rows(i)("SAP").ToString)

                        If dtCerrar.Rows(i)("Estado").ToString = "Liberado" Then
                            ssmEsperar.SetWaitFormCaption("Cerrando Orden")
                            mDIAPI.SAP_DIAPI_Produccion_StatusCerrado(dtCerrar.Rows(i)("SAP").ToString)
                        ElseIf dtCerrar.Rows(i)("Estado").ToString = "Planeado" Then
                            ssmEsperar.SetWaitFormCaption("Liberado Orden")
                            ssmEsperar.SetWaitFormDescription(dtCerrar.Rows(i)("SAP").ToString)
                            mDIAPI.SAP_DIAPI_Produccion_StatusLiberado(dtCerrar.Rows(i)("SAP").ToString)
                            ssmEsperar.SetWaitFormCaption("Cerrando Orden")
                            mDIAPI.SAP_DIAPI_Produccion_StatusCerrado(dtCerrar.Rows(i)("SAP").ToString)
                        End If

                    Next
                End If

                txtRef2.EditValue = String.Empty
                txtComentarioRecibo.EditValue = String.Empty
                txtNombreArticulo.EditValue = String.Empty
                slueCodigoArticulo.EditValue = String.Empty
                DsReciboProduccionEnsamble1.Tables(DsReciboProduccionEnsamble1.dsdtReciboProduccionEnsamble.TableName.ToString).Clear()

                If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If

            End If

        Catch ex As Exception
            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
        End Try
    End Sub

    Private Sub grdviewReciboProduccionEnsamble_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles grdviewReciboProduccionEnsamble.FocusedRowChanged
        Try
            If grdviewReciboProduccionEnsamble.FocusedRowHandle < 0 Then
                grdviewReciboProduccionEnsamble.Columns("SAP").OptionsColumn.AllowEdit = True
                grdviewReciboProduccionEnsamble.Columns("SAP").OptionsColumn.AllowFocus = True
                grdviewReciboProduccionEnsamble.Columns("SAP").OptionsColumn.ReadOnly = False

                grdviewReciboProduccionEnsamble.Columns("Bodega").OptionsColumn.AllowEdit = True
                grdviewReciboProduccionEnsamble.Columns("Bodega").OptionsColumn.AllowFocus = True
                grdviewReciboProduccionEnsamble.Columns("Bodega").OptionsColumn.ReadOnly = False




                grdviewReciboProduccionEnsamble.Columns("CodigoArticulo").OptionsColumn.ReadOnly = False

                mFunciones.FCN_FILL_SearchLookUpEdit(rslueSAP, GET_OrdenesProduccionEnsamble_PendienteAplicar(slueTipo.EditValue.ToString), "SAP", "SAP")

                'If DsReciboProduccionEnsamble1.dsdtReciboProduccionEnsamble.Rows.Count = Nothing Then
                '    mFunciones.FCN_FILL_SearchLookUpEdit(rslueSAP, GET_OrdenesProduccionEnsamble_PendientesAplicar(), "SAP", "SAP")
                'Else
                '    Dim pExepciones As String = mFunciones.FCN_GET_Columna(DsReciboProduccionEnsamble1.dsdtReciboProduccionEnsamble, "SAP")
                '    mFunciones.FCN_FILL_SearchLookUpEdit(rslueSAP, GET_OrdenesProduccionEnsamble_PendientesAplicar(pExepciones), "SAP", "SAP")
                'End If
                
            Else
                grdviewReciboProduccionEnsamble.Columns("SAP").OptionsColumn.AllowEdit = False
                grdviewReciboProduccionEnsamble.Columns("SAP").OptionsColumn.AllowFocus = False
                grdviewReciboProduccionEnsamble.Columns("SAP").OptionsColumn.ReadOnly = True

                grdviewReciboProduccionEnsamble.Columns("Bodega").OptionsColumn.AllowEdit = False
                grdviewReciboProduccionEnsamble.Columns("Bodega").OptionsColumn.AllowFocus = False
                grdviewReciboProduccionEnsamble.Columns("Bodega").OptionsColumn.ReadOnly = True

                grdviewReciboProduccionEnsamble.Columns("CodigoArticulo").OptionsColumn.ReadOnly = False
            End If

            If e.FocusedRowHandle = grdviewReciboProduccionEnsamble.RowCount - 1 Then
                grdviewReciboProduccionEnsamble.Columns("Comentarios").OptionsColumn.TabStop = True
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub grdviewReciboProduccionEnsamble_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles grdviewReciboProduccionEnsamble.InitNewRow
        Try
            If slueTipo.EditValue = Nothing Then
                mMensajes.msg_Informacion("Ingrese Tipo de Recibo a Aplicar")
                Exit Sub
            End If
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueSAP, GET_OrdenesProduccionEnsamble_PendienteAplicar(slueTipo.EditValue.ToString), "SAP", "SAP")

            grdviewReciboProduccionEnsamble.SetRowCellValue(grdviewReciboProduccionEnsamble.FocusedRowHandle, "Cerrar", "False")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub rslueSAP_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles rslueSAP.ButtonClick
   

    End Sub

    Private Sub rslueSAP_Click(sender As Object, e As EventArgs) Handles rslueSAP.Click
        'Try
        '    mFunciones.FCN_FILL_SearchLookUpEdit(rslueSAP, GET_OrdenesProduccionEnsamble_PendientesAplicar(), "SAP", "SAP")
        'Catch ex As Exception
        '    mMensajes.msg_Error(ex.Message.ToString)
        'End Try

    End Sub

    Private Sub rslueSAP_Enter(sender As Object, e As EventArgs) Handles rslueSAP.Enter
        Try
            'If DsReciboProduccionEnsamble1.dsdtReciboProduccionEnsamble.Rows.Count = Nothing Then
            '    mFunciones.FCN_FILL_SearchLookUpEdit(rslueSAP, GET_OrdenesProduccionEnsamble_PendientesAplicar(), "SAP", "SAP")
            'Else
            '    Dim pExepciones As String = mFunciones.FCN_GET_Columna(DsReciboProduccionEnsamble1.dsdtReciboProduccionEnsamble, "SAP")
            '    mFunciones.FCN_FILL_SearchLookUpEdit(rslueSAP, GET_OrdenesProduccionEnsamble_PendientesAplicar(pExepciones), "SAP", "SAP")
            'End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub dteFecha_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles dteFecha.EditValueChanging
        Try
            If e.NewValue > Date.Now Then
                If MsgBox("La fecha ingresada de contabilizacion < " + dteFecha.Text.ToString + " > es mayor a HOY!" + Environment.NewLine + "Desea continuar?", MsgBoxStyle.YesNo, "Verificar Fecha") = MsgBoxResult.No Then
                    e.Cancel = True
                End If

            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    

    
    Private Sub slueCodigoArticulo_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles slueCodigoArticulo.EditValueChanging
        Try

            If e.NewValue = Nothing Then
                Exit Sub
            End If

            Dim dtCodigoArticulo As New DataTable()
            dtCodigoArticulo = mSQLSelect.GET_Articulo("'" + e.NewValue.ToString + "'")
                If dtCodigoArticulo.Rows.Count = Nothing Then
                txtNombreArticulo.EditValue = String.Empty
                e.Cancel = True
                Exit Sub
            End If
            If slueTipo.EditValue = Nothing Then
                mMensajes.msg_Informacion("Debe ingresar un tipo de busqueda")
                e.Cancel = True
                Exit Sub
            End If


            txtNombreArticulo.EditValue = dtCodigoArticulo.Rows(0)("NombreArticulo").ToString

            Dim dtOrdenesPendientesAplicar As New DataTable()
            dtOrdenesPendientesAplicar = GET_OrdenesProduccionEnsamble_Aplicar(e.NewValue.ToString.Substring(0, 8).ToString, slueTipo.EditValue)

            If dtOrdenesPendientesAplicar.Rows.Count = Nothing Then
                DsReciboProduccionEnsamble1.Tables(DsReciboProduccionEnsamble1.dsdtReciboProduccionEnsamble.TableName.ToString).Clear()
                mMensajes.msg_Informacion("NO existen ordenes de Produccion o Ensamble pendientes de aplicar!. Intente con otro Item.")
                Exit Sub
            End If

            DsReciboProduccionEnsamble1.Tables(DsReciboProduccionEnsamble1.dsdtReciboProduccionEnsamble.TableName.ToString).Clear()
            DsReciboProduccionEnsamble1.Tables(DsReciboProduccionEnsamble1.dsdtReciboProduccionEnsamble.TableName.ToString).Merge(dtOrdenesPendientesAplicar)






        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub slueTipo_EditValueChanged(sender As Object, e As EventArgs) Handles slueTipo.EditValueChanged
        Try
            slueCodigoArticulo.EditValue = Nothing
            DsReciboProduccionEnsamble1.Tables(DsReciboProduccionEnsamble1.dsdtReciboProduccionEnsamble.TableName.ToString).Clear()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnExportarXlsx_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXlsx.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_ExportarExcel(grdviewReciboProduccionEnsamble, sfdSave)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEliminar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_EliminarFilasSeleccionadas(grdviewReciboProduccionEnsamble)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnOrdenModificar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnOrdenModificar.ItemClick
        Try
            If grdviewReciboProduccionEnsamble.FocusedRowHandle < 0 Then
                Exit Sub
            End If

            frmOrdenProduccionEnsamble.Text = "Ordenes Produccion Ensamble"
            frmOrdenProduccionEnsamble.ppTipo = "Buscar"
            frmOrdenProduccionEnsamble.ppNumSAP = mFunciones.FCN_GetCellValue(grdviewReciboProduccionEnsamble, "SAP")
            frmOrdenProduccionEnsamble.ShowDialog()

            Dim pBodega As String = frmOrdenProduccionEnsamble.ppBodega
            If Not pBodega = Nothing Then
                grdviewReciboProduccionEnsamble.SetRowCellValue(grdviewReciboProduccionEnsamble.FocusedRowHandle, "Bodega", pBodega)
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub RevisarBodega()
        Try

            'If grdviewReciboProduccionEnsamble.FocusedRowHandle < 0 Then
            '    Exit Sub
            'End If

            frmOrdenProduccionEnsamble.Text = "Ordenes Produccion Ensamble"
            frmOrdenProduccionEnsamble.ppTipo = "Buscar"
            frmOrdenProduccionEnsamble.ppNumSAP = mFunciones.FCN_GetCellValue(grdviewReciboProduccionEnsamble, "SAP")
            frmOrdenProduccionEnsamble.ShowDialog()

            Dim pBodega As String = frmOrdenProduccionEnsamble.ppBodega
            If Not pBodega = Nothing Then
                grdviewReciboProduccionEnsamble.SetRowCellValue(grdviewReciboProduccionEnsamble.FocusedRowHandle, "Bodega", pBodega)
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnDetalleRecibos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDetalleRecibos.ItemClick
        Try
            If grdviewReciboProduccionEnsamble.RowCount = Nothing Then
                MsgBox("Seleccione un numero de SAP Valido")
                Exit Sub
            End If

            frmTemporal_Recibos.ppNumeroSAP = mFunciones.FCN_GetCellValue(grdviewReciboProduccionEnsamble, "SAP")
            frmTemporal_Recibos.ShowDialog()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            grdviewReciboProduccionEnsamble.ShowRibbonPrintPreview()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnAyuda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAyuda.ItemClick
        Try
            Process.Start(Application.StartupPath.ToString + "\Help\helpReciboEmisionProduccion.png")

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewReciboProduccionEnsamble_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles grdviewReciboProduccionEnsamble.CellValueChanging
        Try

            'If e.Column.FieldName = "Cargar" Then
            '    If e.Value = Nothing Then
            '        Exit Sub
            '    End If

            '    If e.Value > 0 Then
            '        MsgBox("Verificar bodegas")

            '        RevisarBodega()

            '    End If
            'End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class