Imports System
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting
Public Class frmEnsambleOrdenImpresion
    Private mCodigoArticulo As String

    Public Property mmCodigoArticulo() As String
        Get
            Return mCodigoArticulo
        End Get

        Set(ByVal value As String)
            mCodigoArticulo = value
        End Set
    End Property

    Private Sub frmEnsambleOrdenImpresion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Fill_DatosdeArticulo()
            Fill_Ensambles_Hijos()
            Sub_Fill_Parametros_Ensamble()
            Sub_Fill_Parametros_Empaque()
            Fill_InstruccionesTrabajo(mCodigoArticulo)
            Fill_InstruccionesFotografias(mCodigoArticulo)
            Fill_Advertencias(mCodigoArticulo)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Fill_Ordenes_Detalle()
        Try
            'DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtImpresionListaMateriales.TableName.ToString).Clear()
            DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtOrdenesXHijo.TableName.ToString).Clear()

            If vpBoolean = False Then
                Exit Sub
            End If
            Dim dtImpresionOrdenes As New DataTable("dtImpresionOrdenes")

            'dtImpresionOrdenes = mSQLSelect.GET_Impresion_ParametrosOrdenes(vpCodigoArticulo)

            dtImpresionOrdenes = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[OrdenesProduccionEnsamble_XPadre] " + vpCodigoArticulo.ToString + "," + vpTipoOrden.ToString)

            Dim pIndex As Integer = 0


            For i = 0 To dtImpresionOrdenes.Rows.Count - 1
                If i = 0 Then
                    dtImpresionOrdenes.Rows(i)("Id_Nivel2") = pIndex
                Else
                    If dtImpresionOrdenes.Rows(i)("Tipo") = "PRODUCCION" Then
                        If Not dtImpresionOrdenes.Rows(i)("CodigoArticulo") = dtImpresionOrdenes.Rows(i - 1)("CodigoArticulo") Then
                            pIndex = pIndex + 1
                        End If
                    Else
                        pIndex = pIndex + 1
                    End If
                    dtImpresionOrdenes.Rows(i)("Id_Nivel2") = pIndex
                End If
            Next



            If Not dtImpresionOrdenes.Rows.Count = Nothing Then
                DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtOrdenesXHijo.TableName.ToString).Clear()
                DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtOrdenesXHijo.TableName.ToString).Merge(dtImpresionOrdenes)
            End If

            Dim pLista As String = mFunciones.FCN_GET_Columna(dtImpresionOrdenes, "NumeroSAP")
            Dim dtOrdenesSAP As New DataTable()

            dtOrdenesSAP = mSQLSelect.GET_Fill_EnsambleProduccion_ConListaExcluir(vpCodigoArticulo, pLista)
            If Not dtOrdenesSAP.Rows.Count = Nothing Then
                DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtOrdenesXHijo.TableName.ToString).Merge(dtOrdenesSAP)
            End If


            Dim RPTdocumento2 As DevExpress.XtraReports.UI.XtraReport = New xrptOrdenProduccionImpresionResumen

            RPTdocumento2.DataSource = Me.DsEnsambleOrdenImpresion1
            RPTdocumento2.DataMember = DsEnsambleOrdenImpresion1.dsdtOrdenesXHijo.TableName.ToString
            RPTdocumento2.Parameters("pUsuario").Value = My.Settings.log_Usuario.ToString
            RPTdocumento2.CreateDocument()

            Dim pages As PageList = RPTdocumento2.PrintingSystem.Document.Pages
            RPTdocumento2.Pages.AddRange(pages)


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub Fill_InstruccionesFotografias(ByVal pCodigo As String)
        Try
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


            DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtFotoInstruccionesTrabajo.TableName.ToString).Clear()
            DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtFotoInstruccionesTrabajo.TableName.ToString).Merge(dt)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub


    Private Sub Fill_DatosdeArticulo()
        Try
            '--------------------------------------------------------------------------------------------------------------------------
            'FILL DATOS DEL ARTICULO
            Dim dtOITM As New DataTable()
            dtOITM = mSQLSelect.GET_Procedimientos_OITM(mCodigoArticulo)

            'DELETE OITM
            DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtDatos_Articulo.TableName.ToString).Clear()

            'FILL OITM
            If Not dtOITM.Rows.Count = Nothing Then
                DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtDatos_Articulo.TableName.ToString).Merge(dtOITM)
            End If

            '--------------------------------------------------------------------------------------------------------------------------
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub Fill_Ensambles_Hijos()
        Try
            DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtEnsambleOrdenImpresion.TableName.ToString).Clear()

            Dim dt As New DataTable("dtProduccionHijos")
            Dim pCodigoPadre As String = mCodigoArticulo

            If pCodigoPadre = String.Empty Then

                Exit Sub
            End If
            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Ensamble_Ordenes_Hijos] AR," + pCodigoPadre.ToString)
            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtEnsambleOrdenImpresion.TableName.ToString).Merge(dt)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Fill_Parametros_Ensamble()
        Try
            Dim dt As New DataTable("dtParametrosEnsamble")

            dt = mSQLSelect.GET_Catalogo_EnsambleParametros("'" + mCodigoArticulo + "'")

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            txtCodigoArticulo.EditValue = dt.Rows(0)("CodigoArticulo").ToString
            txtNombreArticulo.EditValue = dt.Rows(0)("NombreArticulo").ToString
            txtEnsambleXHora.EditValue = dt.Rows(0)("EnsamblesXHora").ToString
            txtEquipoPersonas.EditValue = dt.Rows(0)("EquipoPersonas").ToString
            txtMinXArticulo.EditValue = dt.Rows(0)("MinutosXArticulo").ToString
            txtSegXArticulo.EditValue = dt.Rows(0)("SegundosXArticulo").ToString

            'DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtParametrosEnsamble.TableName.ToString).Clear()
            DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtParametrosEnsamble.TableName.ToString).Merge(dt)


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Fill_Parametros_Empaque()
        Try

            Dim dt As New DataTable()
            Dim pCodigoPadre As String = mCodigoArticulo

            If pCodigoPadre = String.Empty Then

                Exit Sub
            End If
            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Empaque_Parametros]" + pCodigoPadre.ToString)
            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If


            DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtListaEmpaque.TableName.ToString).Clear()
            DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtListaEmpaque.TableName.ToString).Merge(dt)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Fill_InstruccionesTrabajo(ByVal pCodigo As String)
        Try
            Dim dt As New DataTable()

            dt = mSQLSelect.GET_InstruccionesTrabajo(pCodigo)

            'SI ESTA VACIA BORRAR REGISTROS
            If dt.Rows.Count = Nothing Then
                'DELETE OITM
                DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtInstruccionesTrabajo.TableName.ToString).Clear()

                mmeInstruccionesDeTrabajo.EditValue = String.Empty
                spinEquipoPersonasSTD.EditValue = 0
                spinUnidadesEnfriado.EditValue = 0
                Exit Sub
            End If

            'SI NO ESTA VACIO LLENAR CONTROLES
            mmeInstruccionesDeTrabajo.EditValue = dt.Rows(0)("Descripcion").ToString

            If IsDBNull(dt.Rows(0)("PersonasEquipoSTD").ToString) Then
                spinEquipoPersonasSTD.EditValue = 0
            Else
                spinEquipoPersonasSTD.EditValue = dt.Rows(0)("PersonasEquipoSTD").ToString
            End If

            If IsDBNull(dt.Rows(0)("EnfriamientoUnidades").ToString) Then
                spinUnidadesEnfriado.EditValue = 0
            Else
                spinUnidadesEnfriado.EditValue = dt.Rows(0)("EnfriamientoUnidades").ToString
            End If

            'FILL OITM
            If Not dt.Rows.Count = Nothing Then
                DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtInstruccionesTrabajo.TableName.ToString).Merge(dt)
            End If





        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub Fill_Advertencias(ByVal pCodigo As String)
        Try
            Dim dt As New DataTable()
            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Advertencias_Parametros] '" + pCodigo + "'")

            'BORRAR DATASET
            DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dadtAdvertenciasDeTrabajo.TableName.ToString).Clear()

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If
            'LLENAR DATASET
            DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dadtAdvertenciasDeTrabajo.TableName.ToString).Merge(dt)



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

    Private Sub barbtnImprimirInstrucciones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirInstrucciones.ItemClick
        Try
            '--------------------------------------------------------------------------------------------------------------------------
            'REPORTE

            Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptEnsambleImpresion
            RPTdocumento.DataSource = Me.DsEnsambleOrdenImpresion1
            RPTdocumento.DataMember = DsEnsambleOrdenImpresion1.dsdtDatos_Articulo.TableName.ToString
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

            'FIN DE REPORTE 
            '--------------------------------------------------------------------------------------------------------------------------




        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimir.ItemClick
        Try
            Try
                '--------------------------------------------------------------------------------------------------------------------------
                'REPORTE




                Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptEnsambleResumen
                RPTdocumento.DataSource = Me.DsEnsambleOrdenImpresion1
                RPTdocumento.DataMember = DsEnsambleOrdenImpresion1.dsdtEnsambleOrdenImpresion.TableName.ToString()
                RPTdocumento.RequestParameters = False

                'ENVIO DE PARAMETROS
                vpBoolean = barchkDetalle.EditValue
                vpCodigoArticulo = mCodigoArticulo
                vpTipoOrden = 1

                'Dim RPTdocumento2 As DevExpress.XtraReports.UI.XtraReport = New xrptParametros_InstruccionesTrabajo
                'RPTdocumento2.DataSource = Me.DsParametros_Instrucciones1
                'RPTdocumento2.DataMember = DsParametros_Instrucciones1.dsdtImpresion_Instrucciones.TableName.ToString
                'RPTdocumento2.RequestParameters = False

                'RPTdocumento2.Parameters("pCodigo").Value = pCodigo
                'RPTdocumento2.Parameters("pInstruccionesTrabajo").Value = mmeInstruccionTrabajo.EditValue

                'RPTdocumento2.CreateDocument()

                Dim PrintTool As New ReportPrintTool(RPTdocumento)
                PrintTool.ShowRibbonPreviewDialog()

                'FIN DE REPORTE 
                '--------------------------------------------------------------------------------------------------------------------------




            Catch ex As Exception
                mMensajes.msg_Error(ex.Message.ToString)
            End Try
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try

            mFunciones.FCN_XTRAGRID_ImprimirGrid(grdviewAdvertencias, grdviewImpresionEnsamble, grdviewListaEmpaque)


            'If grdImpresionEnsamble.IsFocused Then
            '    grdviewImpresionEnsamble.ShowRibbonPrintPreview()
            'ElseIf grdAdvertencias.IsFocused Then
            '    grdviewAdvertencias.ShowRibbonPrintPreview()
            'ElseIf grdListaEmpaque.IsFocused Then
            '    grdviewListaEmpaque.ShowRibbonPrintPreview()
            'End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnExportarXlsx_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXlsx.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_ExportarExcel(grdviewImpresionEnsamble, grdviewAdvertencias, grdviewListaEmpaque, sfdSave)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class