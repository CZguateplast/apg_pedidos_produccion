Imports DevExpress.XtraReports.UI

Public Class frmOrdenProduccionImpresion

    Private Sub frmOrdenProduccionImpresion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            If vpCodigoArticulo = String.Empty Then : Me.Close() : End If

            If Not Sub_Fill_Molde() Then : mMensajes.msg_Informacion("No existen parametros de Molde.") : End If
            If Not Sub_Fill_ComponentesProducidos() Then : mMensajes.msg_Informacion("No existen parametros de Componentes.") : End If
            If Not Sub_Fill_Maquinas() Then : mMensajes.msg_Informacion("No existen parametros de Maquina.") : End If
            If Not Sub_Fill_Produccion_Paremetros() Then : mMensajes.msg_Informacion("No existen parametros de Produccion.") : End If

            Dim pCantidad As Decimal = "0.00"
            pCantidad = frmOrdenProduccionDisponibles.colProdFinal.SummaryItem.SummaryValue

            If Not (txtCicloHora.EditValue = String.Empty Or _
                txtUnidades.EditValue = String.Empty) Then
                pCantidad = (Val(pCantidad) / txtUnidades.EditValue) / Val(txtCicloHora.EditValue)
                txtHorasReq.EditValue = Math.Ceiling(pCantidad)
                'txtTurnosReq.EditValue = Math.Ceiling(pCantidad / 12)
                txtTurnosReq.EditValue = Format(Val(pCantidad / 12), "0.0")
            End If





        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    'Private Sub Sub_Fill_Ordenes()
    '    Try
    '        Dim dtImpresionOrdenes As New DataTable("dtImpresionOrdenes")
    '        dtImpresionOrdenes = mSQLSelect.GET_Impresion_ParametrosOrdenes(vpCodigoArticulo)

    '        If dtImpresionOrdenes.Rows.Count = Nothing Then
    '            Exit Sub
    '        End If

    '        DsOrdenProduccionImpresion.Tables(DsOrdenProduccionImpresion.dsdtImpresionOrdenes.TableName.ToString).Clear()
    '        DsOrdenProduccionImpresion.Tables(DsOrdenProduccionImpresion.dsdtImpresionOrdenes.TableName.ToString).Merge(dtImpresionOrdenes)


    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message.ToString)
    '    End Try
    'End Sub

    Private Function Sub_Fill_ComponentesProducidos() As Boolean
        Try
            'Dim dt As New DataTable("dtMaquinas")
            'dt = mSQLSelect.GET_Listado_CodigosProducidos(vpCodigoArticulo)

            'If dt.Rows.Count = Nothing Then
            '    Return False
            'End If

            'txtMaterial1.EditValue = dt.Rows(0)("Material1").ToString
            'txtMaterial1Porc.EditValue = dt.Rows(0)("Material1Porc").ToString
            'txtMaterial2.EditValue = dt.Rows(0)("Material2").ToString
            'txtMaterial2Porc.EditValue = dt.Rows(0)("Material2Porc").ToString
            'txtMaterial3.EditValue = dt.Rows(0)("Material3").ToString
            'Return True


            'PARAMETROS DE MATERIALES
            Dim dtMateriales As New DataTable("dt")
            dtMateriales = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.Material_Porcentaje '" + vpCodigoArticulo + "'")
            If Not dtMateriales.Rows.Count = Nothing Then

                txtMaterial1.EditValue = dtMateriales.Rows(0)("Codigo").ToString
                txtMaterial1Porc.EditValue = dtMateriales.Rows(0)("Porcentaje").ToString

                If dtMateriales.Rows.Count = 2 Then
                    txtMaterial2.EditValue = dtMateriales.Rows(1)("Codigo").ToString
                    txtMaterial2Porc.EditValue = dtMateriales.Rows(1)("Porcentaje").ToString
                Else
                    txtMaterial2.EditValue = String.Empty
                    txtMaterial2Porc.EditValue = Nothing
                End If

                If dtMateriales.Rows.Count = 3 Then
                    txtMaterial3.EditValue = dtMateriales.Rows(2)("Codigo").ToString
                    'txtMaterial3.EditValue = dtMateriales.Rows(2)("Porcentaje").ToString
                Else
                    txtMaterial3.EditValue = String.Empty
                    'txtMaterial3Porc.EditValue = Nothing
                End If

                Return True
            Else
                Return False
            End If




        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return False
        End Try
    End Function
    Private Function Sub_Fill_Maquinas() As Boolean
        Try
            Dim dtMoldes As New DataTable("CodigosProducidosMoldes")
            dtMoldes = GET_Listado_CodigosProducidos(vpCodigoArticulo)
            If dtMoldes.Rows.Count = Nothing Then
                Return False
            End If

            Dim dt As New DataTable("dtMaquinas")
            dt = mSQLSelect.GET_MoldesMaquinasTrabajar(dtMoldes.Rows(0)("Molde").ToString)

            DsOrdenProduccionImpresion.Tables(DsOrdenProduccionImpresion.dsdtMoldesMaquinasTrabajar.TableName.ToString).Clear()

            If dt.Rows.Count = Nothing Then
                Return False
            End If

            DsOrdenProduccionImpresion.Tables(DsOrdenProduccionImpresion.dsdtMoldesMaquinasTrabajar.TableName.ToString).Merge(dt)
            Return True
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return False
        End Try
    End Function
    Private Function Sub_Fill_Molde() As Boolean
        Try
            Dim dtMoldes As New DataTable("CodigosProducidosMoldes")
            dtMoldes = GET_Listado_CodigosProducidos(vpCodigoArticulo)
            If dtMoldes.Rows.Count = Nothing Then
                Return False
            End If

            Dim dt As New DataTable("dtMaquinas")
            dt = mSQLSelect.GET_MoldesMaquinasParametros(dtMoldes.Rows(0)("Molde").ToString)

            txtMoldeId.EditValue = String.Empty
            txtMoldeNombre.EditValue = String.Empty
            txtMoldeCavidades.EditValue = String.Empty
            txtUnidades.EditValue = String.Empty
            txtMoldeBodega.EditValue = String.Empty
            txtMoldeUbicacion.EditValue = String.Empty
            txtMaquinaPreferencial.EditValue = String.Empty

            If dt.Rows.Count = Nothing Then
                Return False
            End If

            txtMoldeId.EditValue = dt.Rows(0)("Id").ToString
            txtMoldeNombre.EditValue = dt.Rows(0)("Nombre").ToString
            txtMoldeCavidades.EditValue = dt.Rows(0)("Cavidades").ToString
            txtUnidades.EditValue = dt.Rows(0)("Unidades").ToString
            txtMoldeBodega.EditValue = dt.Rows(0)("Bodega").ToString
            txtMoldeUbicacion.EditValue = dt.Rows(0)("Ubicacion").ToString
            txtMaquinaPreferencial.EditValue = dt.Rows(0)("MaquinaPreferencial").ToString

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return False
        End Try
    End Function
    Private Function Sub_Fill_Produccion_Paremetros() As Boolean
        Try
            Dim dt As New DataTable("dtMaquinas")
            dt = mSQLSelect.GET_MoldesProduccionParametros(vpCodigoArticulo)

            txtCiclo.EditValue = String.Empty
            txtCicloHora.EditValue = String.Empty
            txtCicloTurno.EditValue = String.Empty
            txtCicloMin.EditValue = String.Empty
            txtCicloMax.EditValue = String.Empty
            txtInyeccion.EditValue = String.Empty
            txtInyeccionMin.EditValue = String.Empty
            txtInyeccionMax.EditValue = String.Empty
            txtLbHora.EditValue = String.Empty
            txtSacosDia.EditValue = String.Empty
            txtHorasReq.EditValue = String.Empty
            txtTurnosReq.EditValue = String.Empty

            If dt.Rows.Count = Nothing Then
                Return False
            Else
                If dt.Rows(0)("ArticulosHora").ToString = "0.0" Then
                    Return False
                End If
            End If


            txtCiclo.EditValue = dt.Rows(0)("Ciclo").ToString
            txtCicloHora.EditValue = dt.Rows(0)("CicloHora").ToString
            txtCicloTurno.EditValue = dt.Rows(0)("CicloTurno").ToString
            txtCicloMin.EditValue = dt.Rows(0)("CicloMin").ToString
            txtCicloMax.EditValue = dt.Rows(0)("CicloMax").ToString
            txtInyeccion.EditValue = dt.Rows(0)("PesoInyeccionGrms").ToString
            txtInyeccionMin.EditValue = dt.Rows(0)("RangoPesoGrmsMin").ToString
            txtInyeccionMax.EditValue = dt.Rows(0)("RangoPesoGrmsMax").ToString
            txtLbHora.EditValue = dt.Rows(0)("LbHora").ToString
            txtSacosDia.EditValue = dt.Rows(0)("Sacos25KG").ToString


            Dim pCantidad As Decimal = "0.00"
            pCantidad = colProdFinal.SummaryItem.SummaryValue

            If Not txtCicloHora.EditValue = String.Empty Then
                pCantidad = Val(pCantidad) / Val(txtCicloHora.EditValue)
                txtHorasReq.EditValue = Math.Ceiling(pCantidad)
                'txtTurnosReq.EditValue = pCantidad / 12))
                txtTurnosReq.EditValue = Format(Val(pCantidad / 12), "0.0")
            End If

            txtTurnosReq.EditValue = String.Empty

            Return True
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return False
        End Try
    End Function

    Private Sub grdviewProduccionHijos_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdviewProduccionHijos.CellValueChanged
        'Try
        '    'Calculo de Horas Requeridas
        '    Dim pCantidad As Decimal = "0.00"
        '    pCantidad = colProdFinal.SummaryItem.SummaryValue

        '    If Not txtCicloHora.EditValue = String.Empty Then
        '        pCantidad = (Val(pCantidad) / txtUnidades.EditValue) / Val(txtCicloHora.EditValue)
        '        txtHorasReq.EditValue = Math.Ceiling(pCantidad)
        '        txtTurnosReq.EditValue = Math.Ceiling(pCantidad / 12)
        '    End If

        'Catch ex As Exception
        '    mMensajes.msg_Error(ex.Message.ToString)
        'End Try
    End Sub


    Private Sub grdviewProduccionHijos_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles grdviewProduccionHijos.ValidateRow
        Try
            'Calculo de Horas Requeridas
            Dim pCantidad As Decimal = "0.00"
            grdviewProduccionHijos.UpdateSummary()
            pCantidad = colProdFinal.SummaryItem.SummaryValue
            pCantidad = grdviewProduccionHijos.Columns("ProdFinal").SummaryItem.SummaryValue

            If Not txtCicloHora.EditValue = String.Empty Then
                pCantidad = (Val(pCantidad) / txtUnidades.EditValue) / Val(txtCicloHora.EditValue)
                txtTurnosReq.EditValue = Format(pCantidad / 12, "0.0")
                txtHorasReq.EditValue = Math.Ceiling(pCantidad)
                'txtTurnosReq.EditValue = Math.Ceiling(pCantidad / 12)

            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnVistaPrevia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnVistaPrevia.ItemClick
        Try
            'If Not grdviewImpresionOrdenesDisponibles.SelectedRowsCount = 0 Then

            If chkDetalle.Checked = True Then
                vpBoolean = True
            Else
                vpBoolean = False
            End If

            Dim dtMoldes As New DataTable("CodigosProducidosMoldes")
            dtMoldes = GET_Listado_CodigosProducidos(vpCodigoArticulo)
            If dtMoldes.Rows.Count = Nothing Then
                mMensajes.msg_Error("No hay parametros de producción")
            End If

            'PARAMETROS DE PRODUCCION
            Dim dt As New DataTable("dtImpresionorden")
            Dim dtParametrosProduccion As New DataTable("dtParametrosProduccion")
            dtParametrosProduccion = mSQLSelect.GET_MoldesProduccionParametros(vpCodigoArticulo)
            If Not dtParametrosProduccion.Rows.Count = Nothing Then
                DsOrdenProduccionImpresion.Tables(DsOrdenProduccionImpresion.dsdtImpresionDatosProduccion.TableName.ToString).Clear()
                DsOrdenProduccionImpresion.Tables(DsOrdenProduccionImpresion.dsdtImpresionDatosProduccion.TableName.ToString).Merge(dtParametrosProduccion)
            End If

            'PARAMETROS DE MOLDE
            Dim dtParametrosMolde As New DataTable("dtParametrosMolde")
            dtParametrosMolde = mSQLSelect.GET_MoldesMaquinasParametros(dtMoldes.Rows(0)("Molde").ToString)

            If Not dtParametrosMolde.Rows.Count = Nothing Then
                DsOrdenProduccionImpresion.Tables(DsOrdenProduccionImpresion.dsdtImpresionDatosMolde.TableName.ToString).Clear()
                DsOrdenProduccionImpresion.Tables(DsOrdenProduccionImpresion.dsdtImpresionDatosMolde.TableName.ToString).Merge(dtParametrosMolde)
            End If

            'PARAMETROS CODIGOS PRODUCIDOS
            Dim dtParametrosCodigosProducidos As New DataTable("dtParametrosCodigosProducidos")
            'dtParametrosCodigosProducidos = mSQLSelect.GET_Listado_CodigosProducidos("CP002432")
            dtParametrosCodigosProducidos = mSQLSelect.GET_Listado_CodigosProducidos(vpCodigoArticulo)
            If Not dtParametrosMolde.Rows.Count = Nothing Then
                DsOrdenProduccionImpresion.Tables(DsOrdenProduccionImpresion.dsdtImpresionDatosCodigosProducidos.TableName.ToString).Clear()
                DsOrdenProduccionImpresion.Tables(DsOrdenProduccionImpresion.dsdtImpresionDatosCodigosProducidos.TableName.ToString).Merge(dtParametrosCodigosProducidos)
            End If

            'PARAMETROS DE ORDENES DE ENSAMBLE Y PRODUCCION

            Dim dtImpresionOrdenes As New DataTable("dtImpresionOrdenes")

            Dim TipoOrdenes As String = String.Empty
            If btsTipoEnsamble.Checked = True Then : vpTipoOrden = "'1'" : Else : vpTipoOrden = "'0'" : End If ' 0 es solo Ensambles a Produccion, 1 es todos los ensambles a todos los destinos.

            dtImpresionOrdenes = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[OrdenesProduccionEnsamble_XPadre] " + vpCodigoArticulo.ToString + "," + vpTipoOrden.ToString)
            'dtImpresionOrdenes = mSQLSelect.GET_Impresion_ParametrosOrdenes(vpCodigoArticulo)
            'dtImpresionOrdenes = mSQLSelect.GET_Impresion_ParametrosOrdenes("CP002432")

            If Not dtImpresionOrdenes.Rows.Count = Nothing Then
                DsOrdenProduccionImpresion.Tables(DsOrdenProduccionImpresion.dsdtImpresionOrdenes.TableName.ToString).Clear()
                DsOrdenProduccionImpresion.Tables(DsOrdenProduccionImpresion.dsdtImpresionOrdenes.TableName.ToString).Merge(dtImpresionOrdenes)
            End If

            'Dim pLista As String = mFunciones.FCN_GET_Columna(dtImpresionOrdenes, "NumeroSAP")
            'Dim dtOrdenesSAP As New DataTable()

            'dtOrdenesSAP = mSQLSelect.GET_Fill_EnsambleProduccion_ConListaExcluir(vpCodigoArticulo, pLista)
            'If Not dtOrdenesSAP.Rows.Count = Nothing Then
            '    DsOrdenProduccionImpresion.Tables(DsOrdenProduccionImpresion.dsdtImpresionOrdenes.TableName.ToString).Merge(dtOrdenesSAP)
            'End If

            Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptOrdenProduccionImpresion
            RPTdocumento.DataSource = Me.DsOrdenProduccionImpresion
            RPTdocumento.DataMember = DsOrdenProduccionImpresion.dsdtProduccionHijos.TableName.ToString
            RPTdocumento.Parameters("pHorasRequeridas").Value = txtHorasReq.EditValue
            RPTdocumento.Parameters("pTurnosRequeridos").Value = txtTurnosReq.EditValue
            RPTdocumento.Parameters("pUsuario").Value = My.Settings.log_Usuario.ToString
            RPTdocumento.RequestParameters = False


            'PARAMETROS DE MATERIALES
            Dim dtMateriales As New DataTable("dt")
            dtMateriales = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.Material_Porcentaje '" + vpCodigoArticulo + "'")
            If Not dtMateriales.Rows.Count = Nothing Then

                RPTdocumento.Parameters("pMat1Codigo").Value = dtMateriales.Rows(0)("Codigo").ToString
                RPTdocumento.Parameters("pMat1Nombre").Value = dtMateriales.Rows(0)("Nombre").ToString
                RPTdocumento.Parameters("pMat1DescripcionCorta").Value = dtMateriales.Rows(0)("DescripcionCorta").ToString
                RPTdocumento.Parameters("pMat1Porcentaje").Value = dtMateriales.Rows(0)("Porcentaje").ToString

                If dtMateriales.Rows.Count = 2 Then
                    RPTdocumento.Parameters("pMat2Codigo").Value = dtMateriales.Rows(1)("Codigo").ToString
                    RPTdocumento.Parameters("pMat2Nombre").Value = dtMateriales.Rows(1)("Nombre").ToString
                    RPTdocumento.Parameters("pMat2Porcentaje").Value = dtMateriales.Rows(1)("Porcentaje").ToString
                    RPTdocumento.Parameters("pMat2DescripcionCorta").Value = dtMateriales.Rows(1)("DescripcionCorta").ToString
                Else
                    RPTdocumento.Parameters("pMat2Codigo").Value = String.Empty
                    RPTdocumento.Parameters("pMat2Nombre").Value = String.Empty
                    RPTdocumento.Parameters("pMat2Porcentaje").Value = Nothing
                End If


                If dtMateriales.Rows.Count = 3 Then
                    RPTdocumento.Parameters("pMat3Codigo").Value = dtMateriales.Rows(2)("Codigo").ToString
                    RPTdocumento.Parameters("pMat3Nombre").Value = dtMateriales.Rows(2)("Nombre").ToString
                    RPTdocumento.Parameters("pMat3DescripcionCorta").Value = dtMateriales.Rows(2)("DescripcionCorta").ToString
                    RPTdocumento.Parameters("pMat3Porcentaje").Value = dtMateriales.Rows(2)("Porcentaje").ToString
                Else
                    RPTdocumento.Parameters("pMat3Codigo").Value = String.Empty
                    RPTdocumento.Parameters("pMat3Nombre").Value = String.Empty
                    RPTdocumento.Parameters("pMat3Porcentaje").Value = Nothing
                End If


                DsOrdenProduccionImpresion.Tables(DsOrdenProduccionImpresion.dsdtMateriales.TableName.ToString).Clear()
                DsOrdenProduccionImpresion.Tables(DsOrdenProduccionImpresion.dsdtMateriales.TableName.ToString).Merge(dtMateriales)
            End If


            'mFunciones.ExportToPNG(RPTdocumento, "Reporte_OrdenProduccion")
            'mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("Prueba", _
            '                                             "OrdenesProduccion", _
            '                                             "Hola", _
            '                                             "Reporte_OrdenProduccion")


            Dim PrintTool As New ReportPrintTool(RPTdocumento)
            PrintTool.ShowRibbonPreviewDialog()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally

        End Try
    End Sub

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btsTipoEnsamble_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btsTipoEnsamble.CheckedChanged
        Try
            If btsTipoEnsamble.Checked = True Then
                btsTipoEnsamble.Caption = "Todos los Ensambles"
            Else
                btsTipoEnsamble.Caption = "Ensambles Solo en Producción"
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimirInstrucciones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirInstrucciones.ItemClick
        Try

            '--------------------------------------------------------------------------------------------------------------------------
            ' PARAMETROS DE ARTICULO
            Dim pCodigo As String = String.Empty
            pCodigo = vpCodigoArticulo

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