Imports DevExpress.XtraReports.UI
Public Class frmCodigosImpresion_XCodigo

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub tbarInstrucciones_Impresion_ItemDoubleClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tbarInstrucciones_Impresion.ItemDoubleClick
        Try

            Dim dtCodigos As New DataTable()
            dtCodigos = mSQLSelect.GET_Catalogo_AR_CP_CC_Padres()

            frmTemporal_Lista.ppTabla = dtCodigos
            frmTemporal_Lista.ShowDialog()

            Dim pCodigo As String = String.Empty
            pCodigo = frmTemporal_Lista.ppResultado

            If pCodigo = Nothing Then
                Throw New Exception("Seleccione un codigo Valido")
            End If

            '''' COMIENZA EL CODIGO PARA EJECUTAR


            '--------------------------------------------------------------------------------------------------------------------------
            ' PARAMETROS DE ARTICULO

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

            For Each foundFile As String In My.Computer.FileSystem.GetFiles(
             pPath, FileIO.SearchOption.SearchAllSubDirectories, "" + pCodigo + "*")
                dt.Rows.Add(foundFile.ToString)
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
End Class