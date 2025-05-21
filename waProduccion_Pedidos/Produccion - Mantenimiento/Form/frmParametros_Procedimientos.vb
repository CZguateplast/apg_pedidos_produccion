Imports DevExpress.XtraReports.UI

Public Class frmParametros_Procedimientos

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmParametros_Procedimientos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            Me.Controls.Clear()
            Me.InitializeComponent()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmParametros_Procedimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mFunciones.FCN_FILL_SearchLookUpEdit(slueCodigo, GET_Catalogo_AR_CP_Padres(), "CodigoArticulo", "CodigoArticulo")

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try



    End Sub

    Private Sub Fill_Grid(ByVal pCodigo As String)
        Try
            Dim dt As New DataTable()
            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.Empaque_Parametros '" + pCodigo + "'")

            'BORRAR DATASET
            DsParametros_Procedimientos1.Tables(DsParametros_Procedimientos1.dsdtEmpaque.TableName.ToString).Clear()

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            For I = 0 To dt.Rows.Count - 1
                If Not dt.Rows(I)("Linea").ToString = 1 Then
                    dt.Rows(I)("Comentarios") = String.Empty
                End If
            Next

            'LLENAR DATASET
            DsParametros_Procedimientos1.Tables(DsParametros_Procedimientos1.dsdtEmpaque.TableName.ToString).Merge(dt)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub Fill_Advertencias(ByVal pCodigo As String)
        Try
            Dim dt As New DataTable()
            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Advertencias_Parametros] '" + pCodigo + "'")

            'BORRAR DATASET
            DsParametros_Procedimientos1.Tables(DsParametros_Procedimientos1.dsdtAdvertencias.TableName.ToString).Clear()

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If
            'LLENAR DATASET
            DsParametros_Procedimientos1.Tables(DsParametros_Procedimientos1.dsdtAdvertencias.TableName.ToString).Merge(dt)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub Fill_Controles(ByVal pCodigo As String)
        Try

            Dim dtOITM As New DataTable()
            dtOITM = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[OITM_XArticulo] '" + pCodigo + "'")
            If Not dtOITM.Rows.Count = Nothing Then
                txtDescripcion.EditValue = dtOITM.Rows(0)("ItemName").ToString
                txtDeLinea.EditValue = dtOITM.Rows(0)("DeLinea").ToString
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub


    Private Sub Fill_InstruccionesTrabajo(ByVal pCodigo As String)
        Try
            Dim dt As New DataTable()

            dt = mSQLSelect.GET_InstruccionesTrabajo(pCodigo)

            If dt.Rows.Count = Nothing Then
                mmeInstruccionTrabajo.EditValue = String.Empty
                spinEmpaqueSTD.EditValue = 0
                spinEnfriadoUnidades.EditValue = 0
                Exit Sub
            End If

            mmeInstruccionTrabajo.EditValue = dt.Rows(0)("Descripcion").ToString
            If IsDBNull(dt.Rows(0)("PersonasEquipoSTD").ToString) Then : spinEmpaqueSTD.EditValue = 0 : Else : spinEmpaqueSTD.EditValue = dt.Rows(0)("PersonasEquipoSTD").ToString : End If
            If IsDBNull(dt.Rows(0)("EnfriamientoUnidades").ToString) Then : spinEnfriadoUnidades.EditValue = 0 : Else : spinEnfriadoUnidades.EditValue = dt.Rows(0)("EnfriamientoUnidades").ToString : End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub slueCodigo_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles slueCodigo.EditValueChanging
        Try
            If e.NewValue = Nothing Then
                DsParametros_Procedimientos1.Tables(DsParametros_Procedimientos1.dsdtEmpaque.TableName.ToString).Clear()
                txtDescripcion.EditValue = String.Empty
                txtDeLinea.EditValue = String.Empty
                mmeInstruccionTrabajo.EditValue = String.Empty
                Exit Sub
            End If

            Fill_Grid(e.NewValue.ToString)
            Fill_Advertencias(e.NewValue.ToString)
            Fill_InstruccionesTrabajo(e.NewValue.ToString)

            Fill_Controles(e.NewValue.ToString)
            grdviewEmpaque.ExpandAllGroups()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewAdvertencias_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles grdviewAdvertencias.InitNewRow
        Try

            If slueCodigo.EditValue = Nothing Then : Exit Sub : End If

            Dim pIndex As Integer = Nothing
            pIndex = grdviewAdvertencias.RowCount

            If pIndex = Nothing Then
                pIndex = 1
            Else
                pIndex = pIndex + 1
            End If

            grdviewAdvertencias.SetRowCellValue(e.RowHandle, "Id", slueCodigo.EditValue.ToString)
            grdviewAdvertencias.SetRowCellValue(e.RowHandle, "NumLinea", pIndex)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewAdvertencias_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles grdviewAdvertencias.ValidateRow
        Try
            Dim pIndex As Integer = Nothing
            Dim pCodigo As String = String.Empty
            Dim pLinea As Integer = Nothing
            Dim pDescripcion As String = Nothing

            pIndex = e.RowHandle
            pCodigo = slueCodigo.EditValue.ToString
            pLinea = grdviewAdvertencias.GetRowCellValue(e.RowHandle, "NumLinea")
            pDescripcion = grdviewAdvertencias.GetRowCellValue(e.RowHandle, "Descripcion")

            If pCodigo = Nothing Then : Exit Sub : End If 'Validar que tenga

            If pIndex < 0 Then
                'mMensajes.msg_Informacion("Insertar Codigo:" + pCodigo + " " + Environment.NewLine + "Descripción: " + pDescripcion)
                SET_AdvertenciasTrabajo(pCodigo, pLinea, pDescripcion, "1")
            Else
                'mMensajes.msg_Informacion("Actualizar " + pCodigo + " " + pLinea.ToString + " " + pDescripcion)
                mSQLUpdate.UPDATE_AdvertenciasTrabajos(pCodigo, pLinea.ToString, pDescripcion)
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewAdvertencias_KeyDown(sender As Object, e As KeyEventArgs) Handles grdviewAdvertencias.KeyDown
        Try
            Dim pIndex As Integer = 0
            Dim pColumna As String = String.Empty

            pIndex = grdviewAdvertencias.FocusedRowHandle
            pColumna = grdviewAdvertencias.FocusedColumn.FieldName.ToString

            If pIndex = grdviewAdvertencias.RowCount - 1 And pColumna = "Descripcion" Then
                If e.KeyCode = Keys.Enter Then
                    grdviewAdvertencias.FocusedRowHandle() = (pIndex - 1)
                End If

            ElseIf pIndex < grdviewAdvertencias.RowCount - 1 And pColumna = "Descripcion" Then
                If e.KeyCode = Keys.Enter Then
                    grdviewAdvertencias.FocusedRowHandle() = (pIndex + 1)
                End If

            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnEliminarAdvertencias_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEliminarAdvertencias.ItemClick
        Try
            Dim pCodigo As String = String.Empty
            Dim pLinea As Integer = 0

            pCodigo = grdviewAdvertencias.GetRowCellValue(grdviewAdvertencias.FocusedRowHandle, "Id")
            pLinea = grdviewAdvertencias.GetRowCellValue(grdviewAdvertencias.FocusedRowHandle, "NumLinea")


            If pCodigo = Nothing Or pLinea = Nothing Then
                mMensajes.msg_Proceso_Error()
                Exit Sub
            End If

            mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Advertencias_Parametros_Eliminar] '" + pCodigo + "','" + pLinea.ToString + "'") '[Eliminar de la Base de Datos]

            mFunciones.FCN_XTRAGRID_EliminarFilasSeleccionadas(grdviewAdvertencias) '[Eliminar fila del Grid]
            Sub_Enumerar_AdvertenciasTrabajo() '[Enumerar nuevamente la lista en pantalla]

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Enumerar_AdvertenciasTrabajo()
        Try
            If grdviewAdvertencias.RowCount = Nothing Then
                Exit Sub
            End If

            For i = 0 To grdviewAdvertencias.RowCount - 1
                Dim pNumLineaVieja As String = String.Empty
                pNumLineaVieja = grdviewAdvertencias.GetRowCellValue(i, "NumLinea")

                grdviewAdvertencias.SetRowCellValue(i, "NumLinea", i + 1)

                mSQLUpdate.UPDATE_AdvertenciasTrabajos_Enumerar(slueCodigo.EditValue.ToString, pNumLineaVieja, (i + 1))

            Next

            grdviewAdvertencias.FocusedRowHandle = grdviewAdvertencias.RowCount - 2

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Enumerar_ListaEmpaque()
        Try
            If grdviewEmpaque.RowCount = Nothing Then
                Exit Sub
            End If

            Dim pIndex As Integer = 1
            Dim pIdEmpaque As Integer = 1
            Dim pCodigo As String = String.Empty
            pCodigo = slueCodigo.EditValue.ToString

            For i = 0 To grdviewEmpaque.RowCount - 1

                Dim pNumLineaVieja As String = String.Empty
                pNumLineaVieja = grdviewEmpaque.GetRowCellValue(i, "Id_Empaque")
                grdviewEmpaque.SetRowCellValue(i, "Id_Empaque", pIdEmpaque)

                If pIndex = 1 And Not pNumLineaVieja = Nothing Then
                    mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Empaque_Parametros_Id_UPDATE] '" + pCodigo + "','" + pIdEmpaque.ToString + "','" + pNumLineaVieja.ToString + "'") '[Eliminar de la Base de Datos]
                End If

                If pIndex = 3 Then
                    pIndex = 1
                    pIdEmpaque = pIdEmpaque + 1
                Else
                    pIndex = pIndex + 1
                End If
            Next

            Dim dt As New DataTable()

            DsParametros_Procedimientos1.dsdtEmpaque.AcceptChanges()




            'mMensajes.msg_Error("Prueba")
            'grdviewEmpaque.FocusedRowHandle = grdviewEmpaque.RowCount - 1

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub mmeInstruccionTrabajo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mmeInstruccionTrabajo.Validating
        Try
            Sub_Fill_InstruccionTrabajo()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub mmeInstruccionTrabajo_KeyDown(sender As Object, e As KeyEventArgs) Handles mmeInstruccionTrabajo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                Sub_Fill_InstruccionTrabajo()
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Fill_InstruccionTrabajo()
        Try
            Dim pCodigo As String = String.Empty
            Dim pDescripcion As String = String.Empty
            Dim pUsuario As String = String.Empty

            pCodigo = slueCodigo.EditValue
            pDescripcion = mmeInstruccionTrabajo.EditValue
            pUsuario = My.Settings.log_Usuario.ToString

            If pCodigo = String.Empty Then : Exit Sub : End If

            If mSQLSelect.GET_InstruccionesTrabajo(pCodigo).Rows.Count = Nothing Then
                'INSERT
                mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[InstruccionesTrabajo_Parametros_Insert] '" + pCodigo + "','" + pDescripcion.ToString + "','" + spinEmpaqueSTD.EditValue.ToString + "','" + spinEnfriadoUnidades.EditValue.ToString + "','1','" + pUsuario + "'")
            Else
                'UPDATE
                mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[InstruccionesTrabajo_Parametros_Update] '" + pCodigo + "','" + pDescripcion.ToString + "','" + spinEmpaqueSTD.EditValue.ToString + "','" + spinEnfriadoUnidades.EditValue.ToString + "','1','" + pUsuario + "'")
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnAgregar_ListaEmpaque_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAgregar_ListaEmpaque.ItemClick
        Try
            frmParametros_Empaque_Editar.ppIdEmpaque = Nothing
            frmParametros_Empaque_Editar.ppTipoTrans = "Nuevo"
            frmParametros_Empaque_Editar.ppCodigo = slueCodigo.EditValue
            frmParametros_Empaque_Editar.ppNombre = txtDescripcion.EditValue
            frmParametros_Empaque_Editar.ShowDialog()
            If frmParametros_Empaque_Editar.ppProceso = True Then
                Fill_Grid(slueCodigo.EditValue)
                grdviewEmpaque.ExpandAllGroups()
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEditar.ItemClick
        Try
            If grdviewEmpaque.RowCount = Nothing Then
                mMensajes.msg_Informacion("Seleccione un Empaque valido!")
                Exit Sub
            End If

            Dim pIndex As Integer = Nothing

            If grdviewEmpaque.FocusedRowHandle < 0 Then
                pIndex = grdviewEmpaque.FocusedRowHandle
                pIndex = pIndex * -1
            Else
                pIndex = grdviewEmpaque.GetRowCellValue(grdviewEmpaque.FocusedRowHandle, "Id_Empaque")
            End If

            frmParametros_Empaque_Editar.ppIdEmpaque = pIndex
            frmParametros_Empaque_Editar.ppTipoTrans = "Actualizar"
            frmParametros_Empaque_Editar.ppCodigo = slueCodigo.EditValue
            frmParametros_Empaque_Editar.ppNombre = txtDescripcion.EditValue
            frmParametros_Empaque_Editar.ShowDialog()

            If frmParametros_Empaque_Editar.ppProceso = True Then
                Fill_Grid(slueCodigo.EditValue)
                grdviewEmpaque.ExpandAllGroups()
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnEliminarListaEmpaque_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEliminarListaEmpaque.ItemClick
        Try
            Dim pCodigo As String = String.Empty
            Dim pLinea As Integer = 0
            Dim pIndex As Integer = 0

            If grdviewEmpaque.RowCount = Nothing Or slueCodigo.EditValue = Nothing Then
                Exit Sub
            End If

            pCodigo = slueCodigo.EditValue.ToString

            If grdviewEmpaque.FocusedRowHandle < 0 Then
                pIndex = grdviewEmpaque.FocusedRowHandle
                pIndex = pIndex * -1
            Else
                pIndex = grdviewEmpaque.GetRowCellValue(grdviewEmpaque.FocusedRowHandle, "Id_Empaque")
            End If



            If pCodigo = Nothing Or pIndex = Nothing Then
                mMensajes.msg_Proceso_Error()
                Exit Sub
            End If

            If grdviewEmpaque.SelectedRowsCount = 0 Then
                MsgBox("No puede eliminar la fila seleccionada", vbOKOnly, "Eliminar...")
            Else
                If MsgBox("Desea eliminar la(s) fila(s) seleccionada?", vbYesNo, "Eliminar...") = MsgBoxResult.Yes Then
                    grdviewEmpaque.DeleteSelectedRows()

                    mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Empaque_Parametros_DELETE] '" + pCodigo + "','" + pIndex.ToString + "'") '[Eliminar de la Base de Datos]

                End If
            End If

            'mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Advertencias_Parametros_Eliminar] '" + pCodigo + "','" + pIndex.ToString + "'") '[Eliminar de la Base de Datos]

            DsParametros_Procedimientos1.dsdtEmpaque.AcceptChanges()
            Sub_Enumerar_ListaEmpaque() '[Enumerar nuevamente la lista en pantalla]

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try

            If grdviewAdvertencias.IsFocusedView() Then
                mFunciones.FCN_XTRAGRID_Buscar(grdviewAdvertencias)
            ElseIf grdviewEmpaque.IsFocusedView() Then
                mFunciones.FCN_XTRAGRID_Buscar(grdviewEmpaque)
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try

            mFunciones.FCN_XTRAGRID_ImprimirGrid(grdviewAdvertencias, grdviewEmpaque)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try


    End Sub

    Private Sub barbtnExportarXlsx_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXlsx.ItemClick
        Try

            mFunciones.FCN_XTRAGRID_ExportarExcel(grdviewAdvertencias, grdviewEmpaque, sfdSave)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnVistaFormato_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnVistaFormato.ItemClick
        Try

            '--------------------------------------------------------------------------------------------------------------------------
            ' PARAMETROS DE ARTICULO
            Dim pCodigo As String = String.Empty
            pCodigo = slueCodigo.EditValue

            If pCodigo = Nothing Then
                mMensajes.msg_Error("Ingrese un codigo Válido...")
            End If


            '--------------------------------------------------------------------------------------------------------------------------
            'FILL DATOS DEL ARTICULO
            Dim dtOITM As New DataTable()
            dtOITM = mSQLSelect.GET_Procedimientos_OITM(pCodigo)

            'DELETE OITM
            DsParametros_Instrucciones1.Tables(DsParametros_Instrucciones1.dsdtImpresion_OITM.TableName.ToString).Clear()

            'FILL OITM
            If Not dtOITM.Rows.Count = Nothing Then
                DsParametros_Instrucciones1.Tables(DsParametros_Instrucciones1.dsdtImpresion_OITM.TableName.ToString).Merge(dtOITM)
            End If

            '--------------------------------------------------------------------------------------------------------------------------
            'FILL ADVERTENCIAS DE TRABAJO
            Dim dtAdvertencias As New DataTable()
            dtAdvertencias = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Advertencias_Parametros] '" + pCodigo + "'")

            'DELETE ADVERTENCIAS
            DsParametros_Instrucciones1.Tables(DsParametros_Instrucciones1.dsdtImpresion_Advertencias.TableName.ToString).Clear()

            'FILL ADVERTENCIAS
            If Not dtAdvertencias.Rows.Count = Nothing Then
                DsParametros_Instrucciones1.Tables(DsParametros_Instrucciones1.dsdtImpresion_Advertencias.TableName.ToString).Merge(dtAdvertencias)
            End If

            '--------------------------------------------------------------------------------------------------------------------------
            'FILL INSTRUCCIONES DE TRABAJO

            Dim dtInstrucciones As New DataTable()

            dtInstrucciones = mSQLSelect.GET_InstruccionesTrabajo(pCodigo)

            DsParametros_Instrucciones1.Tables(DsParametros_Instrucciones1.dsdtImpresion_Instrucciones.TableName.ToString).Clear()

            If Not dtInstrucciones.Rows.Count = Nothing Then
                DsParametros_Instrucciones1.Tables(DsParametros_Instrucciones1.dsdtImpresion_Instrucciones.TableName.ToString).Merge(dtInstrucciones)
            End If

            '--------------------------------------------------------------------------------------------------------------------------
            'FILL PARAMETROS DE EMPAQUE

            Dim dtEmpaque As New DataTable()
            dtEmpaque = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.Empaque_Parametros '" + pCodigo + "'")

            'DELETE EMAPQUE
            DsParametros_Instrucciones1.Tables(DsParametros_Instrucciones1.dsdtImpresion_Empaque.TableName.ToString).Clear()

            'FILL EMPAQUE
            If Not dtEmpaque.Rows.Count = Nothing Then
                DsParametros_Instrucciones1.Tables(DsParametros_Instrucciones1.dsdtImpresion_Empaque.TableName.ToString).Merge(dtEmpaque)
            End If

            '--------------------------------------------------------------------------------------------------------------------------
            'FILL PARAMETROS DE EMPAQUE FORMA 2

            Dim dtEmpaque2 As New DataTable()
            dtEmpaque2 = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.Empaque_Parametros_XId '" + pCodigo + "'")

            'BORRAR DATASET
            DsParametros_Instrucciones1.Tables(DsParametros_Instrucciones1.dsdtImpresion_Empaque_Forma2.TableName.ToString).Clear()

            'LLENAR DATASET
            If Not dtEmpaque.Rows.Count = Nothing Then
                DsParametros_Instrucciones1.Tables(DsParametros_Instrucciones1.dsdtImpresion_Empaque_Forma2.TableName.ToString).Merge(dtEmpaque2)
            End If

            '--------------------------------------------------------------------------------------------------------------------------
            'FILL PATH DE FOTOGRAFIAS DE INSTRUCCIONES DE TRABAJO

            'OBTENER PATH PARA BUSQUEDA DE FOTOGRAFIAS DE INSTRUCCIONES DE TRABAJO
            Dim dtPath As New DataTable()
            Dim pPath As String = String.Empty

            dtPath = mSQLSelect.GET_Listado("Directorio_InstruccionesTrabajo")
            If Not dtPath.Rows.Count = Nothing Then
                pPath = dtPath.Rows(0)("Descripcion").ToString
            End If


            'CREACION DE TABLA PARA GUARDAR DIRECTORIOS DE COINCIDENCIAS DE FOTOGRAFIAS
            Dim dt As New DataTable()
            dt.Columns.Add("Path", GetType(String))
            dt.Columns.Add("Descripcion", GetType(String))

            For Each foundFile As String In My.Computer.FileSystem.GetFiles(
             pPath, FileIO.SearchOption.SearchAllSubDirectories, "" + pCodigo + "*")

                dt.Rows.Add(foundFile.ToString)
            Next

            'AGREGAR DESCRIPCION A CADA UNA DE LAS FOTOGRAFIAS
            For i = 0 To dt.Rows.Count - 1
                Dim dtParametros As New DataTable()

                dtParametros = mSQLSelect.GET_Parametros_Fotografias(My.Computer.FileSystem.GetFileInfo(dt.Rows(i)("Path").ToString).Name.ToString.Substring(0, 12), "1")

                If Not dtParametros.Rows.Count = Nothing Then
                    dt.Rows(i)("Descripcion") = dtParametros.Rows(0)("Descripcion").ToString
                End If

                'dt.Rows(i)("Descripcion") = mSQLSelect.GET_Parametros_Fotografias(My.Computer.FileSystem.GetFileInfo(dt.Rows(i)("Path").ToString).Name.ToString.Substring(0, 12), "1").Rows(0)("Descripcion").ToString
            Next


            DsParametros_Instrucciones1.Tables(DsParametros_Instrucciones1.dsdtImpresion_FotoInstruccionesTrabajo.TableName.ToString).Clear()
            DsParametros_Instrucciones1.Tables(DsParametros_Instrucciones1.dsdtImpresion_FotoInstruccionesTrabajo.TableName.ToString).Merge(dt)


            '--------------------------------------------------------------------------------------------------------------------------
            'REPORTE

            Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptParametros_AdvertenciasTrabajo
            RPTdocumento.DataSource = Me.DsParametros_Instrucciones1
            RPTdocumento.DataMember = DsParametros_Instrucciones1.dsdtImpresion_Encabezado.TableName.ToString
            RPTdocumento.RequestParameters = False

            'Dim RPTdocumento2 As DevExpress.XtraReports.UI.XtraReport = New xrptParametros_InstruccionesTrabajo
            'RPTdocumento2.DataSource = Me.DsParametros_Instrucciones1
            'RPTdocumento2.DataMember = DsParametros_Instrucciones1.dsdtImpresion_Instrucciones.TableName.ToString
            'RPTdocumento2.RequestParameters = False

            'RPTdocumento2.Parameters("pCodigo").Value = pCodigo
            'RPTdocumento2.Parameters("pInstruccionesTrabajo").Value = mmeInstruccionTrabajo.EditValue

            'RPTdocumento2.CreateDocument()

            Dim PrintTool As New ReportPrintTool(RPTdocumento)
            PrintTool.ShowRibbonPreviewDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    'Private Sub barbtnPrueba_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtn.ItemClick




    '    '    For Each foundFile As String In My.Computer.FileSystem.GetFiles(
    '    '    My.Computer.FileSystem.SpecialDirectories.MyDocuments,
    '    'Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "AR010040*")

    '    'SELECTOR DE CODIGO A BUSCAR
    '    Dim pCodigo As String = String.Empty
    '    pCodigo = slueCodigo.EditValue
    '    If pCodigo = Nothing Then
    '        mMensajes.msg_Informacion("Ingrese un codigo valido")
    '        Exit Sub
    '    End If
    '    '------------------------------------------------------------


    '    'OBTENER PATH PARA BUSQUEDA DE FOTOGRAFIAS DE INSTRUCCIONES DE TRABAJO
    '    Dim dtPath As New DataTable()
    '    Dim pPath As String = String.Empty

    '    dtPath = mSQLSelect.GET_Listado("Directorio_InstruccionesTrabajo")
    '    If Not dtPath.Rows.Count = Nothing Then
    '        pPath = dtPath.Rows(0)("Descripcion").ToString
    '    End If


    '    'CREACION DE TABLA PARA GUARDAR DIRECTORIOS DE COINCIDENCIAS DE FOTOGRAFIAS
    '    Dim dt As New DataTable()
    '    dt.Columns.Add("Path", GetType(String))

    '    For Each foundFile As String In My.Computer.FileSystem.GetFiles(
    '     pPath, FileIO.SearchOption.SearchAllSubDirectories, "" + pCodigo + "*")

    '        dt.Rows.Add(foundFile.ToString)
    '    Next

    '    DsParametros_Instrucciones1.Tables(DsParametros_Instrucciones1.dsdtImpresion_FotoInstruccionesTrabajo.TableName.ToString).Clear()
    '    DsParametros_Instrucciones1.Tables(DsParametros_Instrucciones1.dsdtImpresion_FotoInstruccionesTrabajo.TableName.ToString).Merge(dt)

    '    'mMensajes.msg_Informacion(dt.Rows.Count.ToString)
    'End Sub

    Private Sub barbtnFotografias_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnFotografias.ItemClick
        Try
            'SELECTOR DE CODIGO A BUSCAR
            Dim pCodigo As String = String.Empty
            pCodigo = slueCodigo.EditValue
            If pCodigo = Nothing Then
                mMensajes.msg_Informacion("Ingrese un codigo valido")
                Exit Sub
            End If
            '------------------------------------------------------------


            frmParametros_Fotografias.ppCodigo = pCodigo
            frmParametros_Fotografias.ppNombre = txtDescripcion.EditValue
            frmParametros_Fotografias.ShowDialog()





        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub



    Private Sub spinEnfriadoUnidades_EditValueChanged(sender As Object, e As EventArgs) Handles spinEnfriadoUnidades.EditValueChanged
        
    End Sub

    
   

    Private Sub spinEmpaqueSTD_Validated(sender As Object, e As EventArgs) Handles spinEmpaqueSTD.Validated
        Try
            Sub_Fill_InstruccionTrabajo()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub spinEnfriadoUnidades_Validated(sender As Object, e As EventArgs) Handles spinEnfriadoUnidades.Validated
        Try
            Sub_Fill_InstruccionTrabajo()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnAyuda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAyuda.ItemClick
        Try
            Dim path = System.IO.Path.Combine(Application.StartupPath, "help/helpAdverInstEmpaProduccion_1.png")
            System.Diagnostics.Process.Start(path)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

   
End Class