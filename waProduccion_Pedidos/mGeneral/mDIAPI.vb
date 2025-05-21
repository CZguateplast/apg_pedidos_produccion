Imports System.Threading
Imports DevExpress.XtraSplashScreen
Imports waProduccion_Pedidos.splEsperar

Module mDIAPI

    Public Function SAP_DIAPI_OrdenesProduccion(ByVal dtEncabezado As DataTable, ByVal dtDetalle As DataTable) As String
        'Public Function SAP_DIAPI_OrdenesEnsamble() As Boolean
        Try
            Try
                ConectarDIAPIGT()

                If Not (oCompanyGT.Connected) Then
                    Throw New Exception("Debe conectarse a sap!")
                End If

                oCompanyGT.StartTransaction() 'Inicia la Transaccion

                'crear un objeto tipo producto
                'Dim oPedido As SAPbobsCOM.Documents
                Dim oPedido As SAPbobsCOM.ProductionOrders

                'instanciar la variable
                oPedido = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders)

                oPedido.DueDate = DateTime.Now
                oPedido.ItemNo = dtEncabezado.Rows(0)("CodigoArticulo").ToString
                oPedido.PlannedQuantity = dtEncabezado.Rows(0)("Unidades").ToString
                oPedido.Warehouse = dtEncabezado.Rows(0)("Destino").ToString
                oPedido.UserFields.Fields.Item("U_Tipo").Value = "0"
                oPedido.Remarks = dtEncabezado.Rows(0)("Comentario_Nivel1").ToString

                For i = 0 To dtDetalle.Rows.Count - 1
                    If Not i = 0 Then
                        oPedido.Lines.Add()
                    End If

                    oPedido.Lines.ItemNo = dtDetalle.Rows(i)("CodigoArticulo").ToString
                    oPedido.Lines.PlannedQuantity = dtDetalle.Rows(i)("Unidades").ToString
                    'oPedido.Lines.Warehouse = dtEncabezado.Rows(0)("Destino").ToString 'se deja el destino default de SAP

                Next

                Dim oResultado As Integer

                oResultado = oPedido.Add()
                If (oResultado = 0) Then
                    Dim mDocEntry As String = String.Empty
                    Dim mDocNum As String = String.Empty

                    oCompanyGT.GetNewObjectCode(mDocEntry)
                    oPedido.GetByKey(mDocEntry)
                    mDocNum = oPedido.DocumentNumber
                    oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)



                    'MsgBox("Su orden se ha grabado exitosamente. NUMERO ORDEN ENSAMBLE SAP = < " + mDocNum + " >.", MsgBoxStyle.OkOnly, "SAP DIAPI")

                    Return mDocNum
                Else
                    MsgBox(oCompanyGT.GetLastErrorDescription())
                    oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                    Return Nothing
                End If

            Catch ex As Exception
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                MsgBox(ex.Message)
                Return Nothing
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            DesconectarDIAPIGT()
        End Try

    End Function
    Public Function SAP_DIAPI_OrdenesProduccion(ByVal pTipo As String, ByVal pCodigoArticulo As String, ByVal pFechaCreacion As Date, ByVal pFechaFinalizacion As Date, ByVal pCantidadPlanificada As String,
                                                ByVal pAlmacen As String, ByVal pTipoOrden As String, ByVal pComentarios As String, ByVal dtDetalle As DataTable,
                                                ByVal pSplash As DevExpress.XtraSplashScreen.SplashScreenManager) As String

        'Public Function SAP_DIAPI_OrdenesEnsamble() As Boolean
        Try
            Try
                If Not pSplash.IsSplashFormVisible() Then : pSplash.ShowWaitForm() : End If

                pSplash.SetWaitFormCaption("Conectando DB")
                pSplash.SetWaitFormDescription("Guatemala")

                ConectarDIAPIGT()
                If Not (oCompanyGT.Connected) Then : Throw New Exception("Debe conectarse a sap!") : End If
                oCompanyGT.StartTransaction() 'Inicia la Transaccion

                pSplash.SetWaitFormCaption("Grabando")
                pSplash.SetWaitFormDescription(pCodigoArticulo)


                'crear un objeto tipo producto
                'Dim oPedido As SAPbobsCOM.Documents
                Dim oPedido As SAPbobsCOM.ProductionOrders

                'instanciar la variable
                oPedido = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders)

                oPedido.ProductionOrderType = pTipo
                oPedido.DueDate = pFechaFinalizacion
                oPedido.ItemNo = pCodigoArticulo
                oPedido.PlannedQuantity = pCantidadPlanificada
                oPedido.Warehouse = pAlmacen
                oPedido.UserFields.Fields.Item("U_Tipo").Value = pTipoOrden
                oPedido.Remarks = pComentarios

                For i = 0 To dtDetalle.Rows.Count - 1
                    pSplash.SetWaitFormCaption("Grabando Detalle")
                    pSplash.SetWaitFormDescription("Linea" + i.ToString)
                    If Not i = 0 Then
                        oPedido.Lines.Add()
                    End If
                    oPedido.Lines.ItemNo = dtDetalle.Rows(i)("CodigoArticulo").ToString
                    oPedido.Lines.BaseQuantity = dtDetalle.Rows(i)("CantidadBase").ToString
                    oPedido.Lines.PlannedQuantity = dtDetalle.Rows(i)("Solicitado").ToString
                    oPedido.Lines.Warehouse = dtDetalle.Rows(i)("Almacen").ToString 'se deja el destino default de SAP
                Next

                Dim oResultado As Integer

                oResultado = oPedido.Add()
                If (oResultado = 0) Then
                    Dim mDocEntry As String = String.Empty
                    Dim mDocNum As String = String.Empty

                    oCompanyGT.GetNewObjectCode(mDocEntry)
                    oPedido.GetByKey(mDocEntry)
                    mDocNum = oPedido.DocumentNumber
                    oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)

                    If pSplash.IsSplashFormVisible() Then : pSplash.CloseWaitForm() : End If
                    MsgBox("Su orden se ha grabado exitosamente. SAP = < " + mDocNum + " >.", MsgBoxStyle.OkOnly, "SAP DIAPI")

                    Return mDocNum
                Else
                    If pSplash.IsSplashFormVisible() Then : pSplash.CloseWaitForm() : End If
                    MsgBox(oCompanyGT.GetLastErrorDescription())
                    oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                    Return Nothing
                End If

            Catch ex As Exception
                If pSplash.IsSplashFormVisible() Then : pSplash.CloseWaitForm() : End If
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                MsgBox(ex.Message)
                Return Nothing
            End Try

        Catch ex As Exception
            If pSplash.IsSplashFormVisible() Then : pSplash.CloseWaitForm() : End If
            MsgBox(ex.Message)
            Return Nothing
        Finally
            If pSplash.IsSplashFormVisible() Then : pSplash.CloseWaitForm() : End If
            DesconectarDIAPIGT()
        End Try

    End Function
    Public Function SAP_DIAPI_OrdenesProduccion_Actualizar_Almacen(ByVal pSAP As String, ByVal pAlmacen As String, ByVal pSplash As DevExpress.XtraSplashScreen.SplashScreenManager) As String
        Try

            pSplash.ShowWaitForm()
            pSplash.SetWaitFormCaption("Conectando DB")
            pSplash.SetWaitFormDescription("Guatemala")
            ConectarDIAPIGT()

            If Not (oCompanyGT.Connected) Then
                Throw New Exception("Debe conectarse a sap!")
            End If

            oCompanyGT.StartTransaction() 'Inicia la Transaccion

            Dim oPedido As SAPbobsCOM.ProductionOrders 'crear un objeto tipo producto'Dim oPedido As SAPbobsCOM.Documents
            oPedido = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders) 'instanciar la variable

            pSplash.SetWaitFormCaption("Actualizando Bodega...")
            pSplash.SetWaitFormDescription(pAlmacen.ToString + " ...")

            oPedido.GetByKey(pSAP)
            oPedido.Warehouse = pAlmacen
            'oPedido.UserFields.Fields.Item("U_TipoOrden").Value = pAlmacen

            Dim oResultado As Integer
            oResultado = oPedido.Update
            If (oResultado = 0) Then
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                If pSplash.IsSplashFormVisible Then : pSplash.CloseWaitForm() : End If
                'mMensajes.msg_Proceso_ok()
                Return True
            Else
                MsgBox(oCompanyGT.GetLastErrorDescription())
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                mMensajes.msg_Proceso_Error()
                Return False
            End If

        Catch ex As Exception
            If pSplash.IsSplashFormVisible Then : pSplash.CloseWaitForm() : End If
            oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
            MsgBox(ex.Message)
            Return False
        Finally
            If pSplash.IsSplashFormVisible Then : pSplash.CloseWaitForm() : End If
            DesconectarDIAPIGT()
        End Try

    End Function

    Public Function SAP_DIAPI_OrdenesProduccion_Actualizar_TipoOrden(ByVal pSAP As String, ByVal pTipoOrden As String, ByVal pSplash As DevExpress.XtraSplashScreen.SplashScreenManager) As String
        Try

            pSplash.ShowWaitForm()
            pSplash.SetWaitFormCaption("Conectando DB")
            pSplash.SetWaitFormDescription("Guatemala")
            ConectarDIAPIGT()

            If Not (oCompanyGT.Connected) Then
                Throw New Exception("Debe conectarse a sap!")
            End If

            oCompanyGT.StartTransaction() 'Inicia la Transaccion

            Dim oPedido As SAPbobsCOM.ProductionOrders 'crear un objeto tipo producto'Dim oPedido As SAPbobsCOM.Documents
            oPedido = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders) 'instanciar la variable

            pSplash.SetWaitFormCaption("Actualizando Tipo...")
            pSplash.SetWaitFormDescription(pTipoOrden.ToString + " ...")

            oPedido.GetByKey(pSAP)
            oPedido.UserFields.Fields.Item("U_Tipo").Value = pTipoOrden

            Dim oResultado As Integer
            oResultado = oPedido.Update
            If (oResultado = 0) Then
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                If pSplash.IsSplashFormVisible Then : pSplash.CloseWaitForm() : End If
                'mMensajes.msg_Proceso_ok()
                Return True
            Else
                MsgBox(oCompanyGT.GetLastErrorDescription())
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                mMensajes.msg_Proceso_Error()
                Return False
            End If

        Catch ex As Exception
            If pSplash.IsSplashFormVisible Then : pSplash.CloseWaitForm() : End If
            oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
            MsgBox(ex.Message)
            Return False
        Finally
            If pSplash.IsSplashFormVisible Then : pSplash.CloseWaitForm() : End If
            DesconectarDIAPIGT()
        End Try
    End Function

    Public Function SAP_DIAPI_OrdenesProduccion_Actualizar_Almacen_Detalle(ByVal pSAP As String, ByVal pLinea As Integer, ByVal pAlmacen As String, ByVal pSplash As DevExpress.XtraSplashScreen.SplashScreenManager) As Boolean
        Try

            pSplash.ShowWaitForm()
            pSplash.SetWaitFormCaption("Conectando DB")
            pSplash.SetWaitFormDescription("Guatemala")
            ConectarDIAPIGT()

            If Not (oCompanyGT.Connected) Then
                Throw New Exception("Debe conectarse a sap!")
            End If

            oCompanyGT.StartTransaction() 'Inicia la Transaccion

            Dim oPedido As SAPbobsCOM.ProductionOrders 'crear un objeto tipo producto'Dim oPedido As SAPbobsCOM.Documents
            oPedido = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders) 'instanciar la variable

            pSplash.SetWaitFormCaption("Actualizando Bodega...")
            pSplash.SetWaitFormDescription(pAlmacen.ToString + " ...")

            oPedido.GetByKey(pSAP)
            For i = 0 To oPedido.Lines.Count - 1
                oPedido.Lines.SetCurrentLine(i)
                If oPedido.Lines.LineNumber = pLinea Then
                    oPedido.Lines.Warehouse = pAlmacen
                    Dim oResultado As Integer
                    oResultado = oPedido.Update

                    If (oResultado = 0) Then
                        oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                        If pSplash.IsSplashFormVisible Then : pSplash.CloseWaitForm() : End If
                        'mMensajes.msg_Proceso_ok()
                        Return True
                    Else
                        MsgBox(oCompanyGT.GetLastErrorDescription())
                        oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                        mMensajes.msg_Proceso_Error()
                        Return False
                    End If
                End If
            Next

            'For I = 0 To oPedido.PriceList.Count - 1
            '    oPedido.PriceList.SetCurrentLine(I)
            '    If oPedido.PriceList.PriceList = pListaPrecio Then
            '        oPedido.PriceList.Price = pPrecio
            '        oPedido.PriceList.Currency = pMoneda
            '        Dim oResultado As Integer
            '        oResultado = oPedido.Update
            '        If (oResultado = 0) Then
            '            oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
            '            'MsgBox("Su orden se ha grabado exitosamente. NUMERO ORDEN ENSAMBLE SAP = < " + mDocNum + " >.", MsgBoxStyle.OkOnly, "SAP DIAPI")
            '            Return True
            '        Else
            '            MsgBox(oCompanyGT.GetLastErrorDescription())
            '            oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
            '            Return False
            '        End If

            '    End If
            'Next

            Return False
        Catch ex As Exception
            If pSplash.IsSplashFormVisible Then : pSplash.CloseWaitForm() : End If
            oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
            MsgBox(ex.Message)
            Return False
        Finally
            If pSplash.IsSplashFormVisible Then : pSplash.CloseWaitForm() : End If
            DesconectarDIAPIGT()
        End Try

    End Function
    Public Function SAP_DIAPI_RecibosProduccion(ByVal pFecha As String, ByVal dtDetalle As DataTable, ByVal pReferencia As String, ByVal pComentario As String, ByVal pSplash As DevExpress.XtraSplashScreen.SplashScreenManager) As String
        'Public Function SAP_DIAPI_OrdenesEnsamble() As Boolean
        'ByVal dtEncabezado As DataTable, 
        Try
            pSplash.ShowWaitForm()
            pSplash.SetWaitFormCaption("Conectando DB")
            pSplash.SetWaitFormDescription("Guatemala")
            ConectarDIAPIGT()

            If Not (oCompanyGT.Connected) Then
                Throw New Exception("Debe conectarse a sap!")
            End If

            oCompanyGT.StartTransaction() 'Inicia la Transaccion

            'crear un objeto tipo producto
            Dim oReceiptProd As SAPbobsCOM.Documents
            'Dim oPedido As SAPbobsCOM.ProductionOrders

            'instanciar la variable
            oReceiptProd = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenEntry)

            pSplash.SetWaitFormCaption("Transacción...")
            pSplash.SetWaitFormDescription("Recibo...")

            oReceiptProd.DocDate = pFecha
            oReceiptProd.Reference2 = pReferencia
            oReceiptProd.Comments = pComentario

            For i = 0 To dtDetalle.Rows.Count - 1

                oReceiptProd.Lines.BaseEntry = dtDetalle.Rows(i)("SAP").ToString
                oReceiptProd.Lines.BaseType = "202"
                oReceiptProd.Lines.TransactionType = SAPbobsCOM.BoTransactionTypeEnum.botrntComplete
                oReceiptProd.Lines.Quantity = dtDetalle.Rows(i)("Cargar").ToString
                oReceiptProd.Lines.WarehouseCode = dtDetalle.Rows(i)("Bodega").ToString
                oReceiptProd.Lines.Add()

            Next

            Dim oResultado As Integer
            oResultado = oReceiptProd.Add()

            If (oResultado = 0) Then
                Dim mDocEntry As String = String.Empty
                Dim mDocNum As String = String.Empty

                oCompanyGT.GetNewObjectCode(mDocEntry)
                oReceiptProd.GetByKey(mDocEntry)
                mDocNum = oReceiptProd.DocNum
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)

                If pSplash.IsSplashFormVisible Then : pSplash.CloseWaitForm() : End If


                MsgBox("Su recibo se ha grabado exitosamente. " + Environment.NewLine + " # RECIBO SAP = [ " + mDocNum + " ].", MsgBoxStyle.OkOnly, "RECIBOS SAP DIAPI")

                Return mDocNum
            Else
                If pSplash.IsSplashFormVisible Then : pSplash.CloseWaitForm() : End If
                MsgBox(oCompanyGT.GetLastErrorDescription())
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                Return Nothing
            End If

        Catch ex As Exception
            If pSplash.IsSplashFormVisible Then : pSplash.CloseWaitForm() : End If
            oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
            MsgBox(ex.Message)
            Return Nothing

        Finally
            If pSplash.IsSplashFormVisible Then : pSplash.CloseWaitForm() : End If
            DesconectarDIAPIGT()
        End Try

    End Function
    Public Function SAP_DIAPI_EmisionProduccion(ByVal pFecha As String, ByVal pReferencia As String, ByVal pComentario As String, ByVal dtDetalle As DataTable, ByVal pSplash As DevExpress.XtraSplashScreen.SplashScreenManager) As String
        Try
            pSplash.ShowWaitForm()
            pSplash.SetWaitFormCaption("Conectando DB")
            pSplash.SetWaitFormDescription("Guatemala")
            ConectarDIAPIGT()

            If Not (oCompanyGT.Connected) Then : Throw New Exception("Debe conectarse a sap!") : End If
            oCompanyGT.StartTransaction() 'Inicia la Transaccion
            Dim oReceiptProd As SAPbobsCOM.Documents 'crear un objeto tipo producto
            oReceiptProd = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenExit) 'instanciar la variable

            pSplash.SetWaitFormCaption("Transacción...")
            pSplash.SetWaitFormDescription("Recibo...")

            oReceiptProd.DocDate = pFecha
            oReceiptProd.Reference2 = pReferencia
            oReceiptProd.Comments = pComentario

            For i = 0 To dtDetalle.Rows.Count - 1

                oReceiptProd.Lines.BaseEntry = dtDetalle.Rows(i)("SAP").ToString
                'oReceiptProd.Lines.BaseType = "202"
                'oReceiptProd.Lines.TransactionType = SAPbobsCOM.BoTransactionTypeEnum.botrntComplete
                'oReceiptProd.Lines.TransactionType = SAPbobsCOM.BoTransactionTypeEnum.botrntReject
                oReceiptProd.Lines.Quantity = dtDetalle.Rows(i)("Cargar").ToString
                oReceiptProd.Lines.Add()

            Next

            Dim oResultado As Integer
            oResultado = oReceiptProd.Add()

            If (oResultado = 0) Then
                Dim mDocEntry As String = String.Empty
                Dim mDocNum As String = String.Empty

                oCompanyGT.GetNewObjectCode(mDocEntry)
                oReceiptProd.GetByKey(mDocEntry)
                mDocNum = oReceiptProd.DocNum
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)

                If pSplash.IsSplashFormVisible Then : pSplash.CloseWaitForm() : End If


                MsgBox("Su Emision de Produccion se ha grabado exitosamente. " + Environment.NewLine + " # EMISION SAP = [ " + mDocNum + " ].", MsgBoxStyle.OkOnly, "RECIBOS SAP DIAPI")

                Return mDocNum
            Else
                If pSplash.IsSplashFormVisible Then : pSplash.CloseWaitForm() : End If
                MsgBox(oCompanyGT.GetLastErrorDescription())
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                Return Nothing
            End If

        Catch ex As Exception
            If pSplash.IsSplashFormVisible Then : pSplash.CloseWaitForm() : End If
            oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
            MsgBox(ex.Message)
            Return Nothing

        Finally
            If pSplash.IsSplashFormVisible Then : pSplash.CloseWaitForm() : End If
            DesconectarDIAPIGT()
        End Try

    End Function

#Region "NuevoEnsambles"

    Public Function SAP_DIAPI_OrdenesEnsamble1(ByVal dtEncabezado As DataTable, ByVal dtDetalle As DataTable) As String
        'Public Function SAP_DIAPI_OrdenesEnsamble() As Boolean
        Try
            Try
                ConectarDIAPIGT()


                If Not (oCompanyGT.Connected) Then
                    Throw New Exception("Debe conectarse a sap!")
                End If

                oCompanyGT.StartTransaction() 'Inicia la Transaccion

                'crear un objeto tipo producto
                'Dim oPedido As SAPbobsCOM.Documents
                Dim oPedido As SAPbobsCOM.ProductionOrders

                'instanciar la variable
                oPedido = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders)

                oPedido.DueDate = DateTime.Now
                oPedido.ItemNo = dtEncabezado.Rows(0)("CodigoArticulo").ToString
                oPedido.PlannedQuantity = dtEncabezado.Rows(0)("Unidades").ToString
                oPedido.Warehouse = dtEncabezado.Rows(0)("Destino").ToString
                oPedido.UserFields.Fields.Item("U_Tipo").Value = dtEncabezado.Rows(0)("Origen").ToString
                oPedido.UserFields.Fields.Item("U_NBS_Priority").Value = dtEncabezado.Rows(0)("Prioridad").ToString
                oPedido.Remarks = dtEncabezado.Rows(0)("Comentario_Nivel1").ToString

                For i = 0 To dtDetalle.Rows.Count - 1
                    If Not i = 0 Then
                        oPedido.Lines.Add()
                    End If

                    oPedido.Lines.ItemNo = dtDetalle.Rows(i)("CodigoArticulo").ToString
                    oPedido.Lines.PlannedQuantity = dtDetalle.Rows(i)("Unidades").ToString
                    oPedido.Lines.Warehouse = dtDetalle.Rows(0)("Origen").ToString

                Next

                Dim oResultado As Integer

                oResultado = oPedido.Add()
                If (oResultado = 0) Then
                    Dim mDocEntry As String = String.Empty
                    Dim mDocNum As String = String.Empty

                    oCompanyGT.GetNewObjectCode(mDocEntry)
                    oPedido.GetByKey(mDocEntry)
                    mDocNum = oPedido.DocumentNumber
                    oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)



                    'MsgBox("Su orden se ha grabado exitosamente. NUMERO ORDEN ENSAMBLE SAP = < " + mDocNum + " >.", MsgBoxStyle.OkOnly, "SAP DIAPI")

                    Return mDocNum
                Else
                    MsgBox(oCompanyGT.GetLastErrorDescription())
                    oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                    Return Nothing
                End If

            Catch ex As Exception
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                MsgBox(ex.Message)
                Return Nothing
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            DesconectarDIAPIGT()
        End Try

    End Function

    Public Function SAP_DIAPI_OrdenesProduccion1(ByVal dtEncabezado As DataTable, ByVal dtDetalle As DataTable, ByVal pId As Integer) As String
        'Public Function SAP_DIAPI_OrdenesEnsamble() As Boolean
        Try
            Try
                ConectarDIAPIGT()

                If Not (oCompanyGT.Connected) Then
                    Throw New Exception("Debe conectarse a sap!")
                End If

                oCompanyGT.StartTransaction() 'Inicia la Transaccion

                'crear un objeto tipo producto
                'Dim oPedido As SAPbobsCOM.Documents
                Dim oPedido As SAPbobsCOM.ProductionOrders

                'instanciar la variable
                oPedido = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders)

                oPedido.DueDate = DateTime.Now
                oPedido.ItemNo = dtEncabezado.Rows(pId)("CodigoArticulo").ToString
                oPedido.PlannedQuantity = dtEncabezado.Rows(pId)("Unidades").ToString
                oPedido.Warehouse = dtEncabezado.Rows(pId)("Destino").ToString
                oPedido.UserFields.Fields.Item("U_Tipo").Value = "0"
                oPedido.UserFields.Fields.Item("U_NBS_Priority").Value = dtEncabezado.Rows(pId)("Prioridad").ToString
                oPedido.Remarks = dtEncabezado.Rows(pId)("Comentario_Nivel1").ToString

                For i = 0 To dtDetalle.Rows.Count - 1
                    If Not i = 0 Then
                        oPedido.Lines.Add()
                    End If

                    oPedido.Lines.ItemNo = dtDetalle.Rows(i)("CodigoArticulo").ToString
                    oPedido.Lines.PlannedQuantity = dtDetalle.Rows(i)("Unidades").ToString
                    'oPedido.Lines.Warehouse = dtEncabezado.Rows(0)("Destino").ToString 'se deja el destino default de SAP

                Next

                Dim oResultado As Integer

                oResultado = oPedido.Add()
                If (oResultado = 0) Then
                    Dim mDocEntry As String = String.Empty
                    Dim mDocNum As String = String.Empty

                    oCompanyGT.GetNewObjectCode(mDocEntry)
                    oPedido.GetByKey(mDocEntry)
                    mDocNum = oPedido.DocumentNumber
                    oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)



                    'MsgBox("Su orden se ha grabado exitosamente. NUMERO ORDEN ENSAMBLE SAP = < " + mDocNum + " >.", MsgBoxStyle.OkOnly, "SAP DIAPI")

                    Return mDocNum
                Else
                    MsgBox(oCompanyGT.GetLastErrorDescription())
                    oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                    Return Nothing
                End If

            Catch ex As Exception
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                MsgBox(ex.Message)
                Return Nothing
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            DesconectarDIAPIGT()
        End Try

    End Function


#End Region

#Region "LISTA DE PRECIOS"
    Public Function SAP_DIAPI_ListasPrecios_Actualizar(ByVal pListaPrecio As String, ByVal pCodigoArticulo As String, ByVal pPrecio As String, ByVal pMoneda As String) As Boolean
        Try
            ConectarDIAPIGT()

            If Not (oCompanyGT.Connected) Then
                Throw New Exception("Debe conectarse a sap!")
            End If

            oCompanyGT.StartTransaction() 'Inicia la Transaccion

            Dim oPedido As SAPbobsCOM.Items 'crear un objeto tipo producto'Dim oPedido As SAPbobsCOM.Documents
            oPedido = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems) 'instanciar la variable


            oPedido.GetByKey(pCodigoArticulo)

            For I = 0 To oPedido.PriceList.Count - 1
                oPedido.PriceList.SetCurrentLine(I)
                If oPedido.PriceList.PriceList = pListaPrecio Then
                    oPedido.PriceList.Price = pPrecio
                    oPedido.PriceList.Currency = pMoneda
                    Dim oResultado As Integer
                    oResultado = oPedido.Update
                    If (oResultado = 0) Then
                        oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                        'MsgBox("Su orden se ha grabado exitosamente. NUMERO ORDEN ENSAMBLE SAP = < " + mDocNum + " >.", MsgBoxStyle.OkOnly, "SAP DIAPI")
                        Return True
                    Else
                        MsgBox(oCompanyGT.GetLastErrorDescription())
                        oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                        Return False
                    End If

                End If
            Next

            Return True



        Catch ex As Exception
            oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
            MsgBox(ex.Message)
            Return False
        Finally
            DesconectarDIAPIGT()
        End Try

    End Function
    Public Function SAP_DIAPI_ListasPreciosCliente_Actualizar(ByVal pCodigoCliente As String, ByVal pListaPrecio As String) As Boolean
        Try
            ConectarDIAPIGT()

            If Not (oCompanyGT.Connected) Then
                Throw New Exception("Debe conectarse a sap!")
            End If

            oCompanyGT.StartTransaction() 'Inicia la Transaccion

            Dim oTrans As SAPbobsCOM.BusinessPartners 'crear un objeto tipo producto'Dim oPedido As SAPbobsCOM.Documents
            oTrans = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners) 'instanciar la variable


            oTrans.GetByKey(pCodigoCliente)

            oTrans.PriceListNum = pListaPrecio

            Dim oResultado As Integer
            oResultado = oTrans.Update

            If (oResultado = 0) Then
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                Return True
            Else
                MsgBox(oCompanyGT.GetLastErrorDescription())
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                Return False
            End If

            Return True

        Catch ex As Exception
            oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
            MsgBox(ex.Message)
            Return False
        Finally
            DesconectarDIAPIGT()
        End Try

    End Function
#End Region
#Region "LISTA DE MATERIALES"

    'Public Function SAP_DIAPI_ListaMateriales_EliminarItem() As Boolean
    Public Function SAP_DIAPI_ListaMateriales_EliminarItem(ByVal pCodigoArticulo As String) As Boolean
        Try
            If Not oCompanyGT.Connected Then
                ConectarDIAPIGT()
            End If
            'If Not (oCompanyGT.Connected) Then
            '    Throw New Exception("Debe conectarse a sap!")
            'End If

            oCompanyGT.StartTransaction() 'Inicia la Transaccion

            Dim pdtListaMateriales As New DataTable()
            Dim oTrans As SAPbobsCOM.IProductTrees 'crear un objeto tipo producto'Dim oPedido As SAPbobsCOM.Documents
            oTrans = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductTrees) 'instanciar la variable
            oTrans.TreeType = SAPbobsCOM.BoItemTreeTypes.iProductionTree


            pdtListaMateriales = mSQLSelect.GET_ListaMateriales_MasCostos(pCodigoArticulo)
            If pdtListaMateriales.Rows.Count = Nothing Then
                Return Nothing
            End If

            oTrans.GetByKey(pdtListaMateriales.Rows(0)(0).ToString)

            Dim oResultado As Integer
            oResultado = oTrans.Remove

            If (oResultado = 0) Then
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                Return True
            Else
                MsgBox(oCompanyGT.GetLastErrorDescription())
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                Return False
            End If

            Return True

        Catch ex As Exception
            oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
            MsgBox(ex.Message)
            Return False
        Finally
            DesconectarDIAPIGT()
        End Try

    End Function
    Public Function SAP_DIAPI_ListaMateriales_Actualizar(ByVal pCodigoArticulo As String) As Boolean
        'Public Function SAP_DIAPI_ListaMateriales_Actualizar() As Boolean
        Try
            If Not oCompanyGT.Connected Then
                ConectarDIAPIGT()
            End If
            'If Not (oCompanyGT.Connected) Then
            '    Throw New Exception("Debe conectarse a sap!")
            'End If

            oCompanyGT.StartTransaction() 'Inicia la Transaccion

            Dim pdtListaMateriales As New DataTable()
            Dim oTrans As SAPbobsCOM.IProductTrees 'crear un objeto tipo producto'Dim oPedido As SAPbobsCOM.Documents
            oTrans = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductTrees) 'instanciar la variable
            oTrans.TreeType = SAPbobsCOM.BoItemTreeTypes.iProductionTree


            pdtListaMateriales = mSQLSelect.GET_ListaMateriales_MasCostos(pCodigoArticulo)
            If pdtListaMateriales.Rows.Count = Nothing Then
                Return Nothing
            End If

            oTrans.GetByKey(pdtListaMateriales.Rows(0)(0).ToString)

            For I = 0 To oTrans.Items.Count - 1
                oTrans.Items.SetCurrentLine(I)
                oTrans.Items.PriceList = "1"
                oTrans.Items.Price = pdtListaMateriales.Rows(I)("Costo").ToString
            Next

            Dim oResultado As Integer
            oResultado = oTrans.Update

            If (oResultado = 0) Then
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                Return True
            Else
                MsgBox(oCompanyGT.GetLastErrorDescription())
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                Return False
            End If

            Return True

        Catch ex As Exception
            oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
            MsgBox(ex.Message)
            Return False
        Finally
            DesconectarDIAPIGT()
        End Try

    End Function

#End Region



    Public Function SAP_DIAPI_Produccion_StatusLiberado(ByVal pNumOrden As String) As Boolean
        Try
            ConectarDIAPIGT()

            If Not (oCompanyGT.Connected) Then
                Throw New Exception("Debe conectarse a sap!")
            End If

            oCompanyGT.StartTransaction() 'Inicia la Transaccion

            Dim oPedido As SAPbobsCOM.ProductionOrders 'crear un objeto tipo producto'Dim oPedido As SAPbobsCOM.Documents
            oPedido = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders) 'instanciar la variable

            oPedido.GetByKey(pNumOrden)
            oPedido.ProductionOrderStatus = SAPbobsCOM.BoProductionOrderStatusEnum.boposReleased

            Dim oResultado As Integer

            oResultado = oPedido.Update
            If (oResultado = 0) Then
                'Dim mDocEntry As String = String.Empty
                'Dim mDocNum As String = String.Empty
                'oCompanyGT.GetNewObjectCode(mDocEntry)
                'oPedido.GetByKey(mDocEntry)
                'mDocNum = oPedido.DocumentNumber
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                'MsgBox("Su orden se ha grabado exitosamente. NUMERO ORDEN ENSAMBLE SAP = < " + mDocNum + " >.", MsgBoxStyle.OkOnly, "SAP DIAPI")
                Return True
            Else
                MsgBox(oCompanyGT.GetLastErrorDescription())
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                Return False
            End If

        Catch ex As Exception
            oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
            MsgBox(ex.Message)
            Return False
        Finally
            DesconectarDIAPIGT()
        End Try

    End Function
    'Cerrar transaccion
    Public Function SAP_DIAPI_Produccion_StatusCerrado(ByVal pNumOrden As String) As Boolean
        Try
            ConectarDIAPIGT()

            If Not (oCompanyGT.Connected) Then
                Throw New Exception("Debe conectarse a sap!")
            End If

            oCompanyGT.StartTransaction() 'Inicia la Transaccion

            Dim oPedido As SAPbobsCOM.ProductionOrders 'crear un objeto tipo producto'Dim oPedido As SAPbobsCOM.Documents
            oPedido = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders) 'instanciar la variable

            oPedido.GetByKey(pNumOrden)
            oPedido.ProductionOrderStatus = SAPbobsCOM.BoProductionOrderStatusEnum.boposClosed 'Cierra la orden con SAP

            Dim oResultado As Integer

            oResultado = oPedido.Update
            If (oResultado = 0) Then
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                Return True
            Else
                MsgBox(oCompanyGT.GetLastErrorDescription())
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                Return False
            End If

        Catch ex As Exception
            oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
            MsgBox(ex.Message)
            Return False
        Finally
            DesconectarDIAPIGT()
        End Try

    End Function
    Public Function SAP_DIAPI_Produccion_UpdatePrioridad(ByVal pNumOrden As String, ByVal pPrioridad As String) As Boolean
        Try
            ConectarDIAPIGT()

            If Not (oCompanyGT.Connected) Then
                ConectarDIAPIGT()
            End If

            oCompanyGT.StartTransaction() 'Inicia la Transaccion

            Dim oPedido As SAPbobsCOM.ProductionOrders 'crear un objeto tipo producto'Dim oPedido As SAPbobsCOM.Documents
            oPedido = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders) 'instanciar la variable

            oPedido.GetByKey(pNumOrden)
            oPedido.UserFields.Fields.Item("U_NBS_Priority").Value = pPrioridad

            Dim oResultado As Integer

            oResultado = oPedido.Update
            If (oResultado = 0) Then
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                Return True
            Else
                MsgBox(oCompanyGT.GetLastErrorDescription())
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                Return False
            End If

        Catch ex As Exception
            oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
            MsgBox(ex.Message)
            Return False
        Finally
            DesconectarDIAPIGT()
        End Try

    End Function
    Public Function SAP_DIAPI_SalidasMercaderia(ByVal dtEncabezado As DataTable, ByVal dtDetalle As DataTable, ByVal pSplash As DevExpress.XtraSplashScreen.SplashScreenManager) As Boolean

        'Public Function SAP_DIAPI_OrdenesEnsamble() As Boolean
        Try
            Try
                ConectarDIAPIGT()

                If Not (oCompanyGT.Connected) Then
                    Throw New Exception("Debe conectarse a sap!")
                End If

                oCompanyGT.StartTransaction() 'Inicia la Transaccion

                'crear un objeto tipo producto
                Dim oTrans As SAPbobsCOM.Documents

                'instanciar la variable
                oTrans = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenExit)


                oTrans.PaymentGroupCode = dtEncabezado.Rows(0)("ListaPrecios")
                oTrans.DocDate = dtEncabezado.Rows(0)("FechaConta")
                oTrans.TaxDate = dtEncabezado.Rows(0)("FechaDocumento")
                oTrans.Reference2 = dtEncabezado.Rows(0)("NumReferencia").ToString
                oTrans.Comments = dtEncabezado.Rows(0)("Comentarios").ToString
                oTrans.JournalMemo = dtEncabezado.Rows(0)("AsientoContable").ToString
                oTrans.UserFields.Fields.Item("U_UsuarioAPG").Value = My.Settings.log_Usuario

                For i = 0 To dtDetalle.Rows.Count - 1
                    If Not i = 0 Then
                        oTrans.Lines.Add()
                    End If

                    oTrans.Lines.ItemCode = dtDetalle.Rows(i)("CodigoArticulo").ToString
                    oTrans.Lines.WarehouseCode = dtDetalle.Rows(i)("Bodega").ToString
                    oTrans.Lines.Quantity = dtDetalle.Rows(i)("Cantidad")
                    oTrans.Lines.AccountCode = dtDetalle.Rows(i)("CuentaContable").ToString

                Next

                Dim oResultado As Integer

                oResultado = oTrans.Add()
                If (oResultado = 0) Then
                    Dim mDocEntry As String = String.Empty
                    Dim mDocNum As String = String.Empty

                    oCompanyGT.GetNewObjectCode(mDocEntry)
                    oTrans.GetByKey(mDocEntry)
                    mDocNum = oTrans.DocNum
                    oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                    'oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)

                    If pSplash.IsSplashFormVisible Then : pSplash.CloseWaitForm() : End If

                    mSQLInsert.SET_SalidasInventario_LOG(frmMercanciasSalidas.Sub_Get_TrasladoMercaderia_Encabezado, mDocNum)

                    MsgBox("Su Transacción se ha grabado exitosamente. Salida de Mercancia # " + mDocNum + ".", MsgBoxStyle.OkOnly, "SAP DIAPI")

                    If MsgBox("Desea Imprimir Documento SAP # " + mDocNum + "?", MsgBoxStyle.YesNo, "Impresión...") = MsgBoxResult.Yes Then
                        frmMercanciasSalidas.Sub_TrasladosMercaderia_Impresion(mDocNum)
                    End If

                    Return True

                Else
                    MsgBox(oCompanyGT.GetLastErrorDescription())
                    oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                    Return False
                End If

            Catch ex As Exception
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                MsgBox(ex.Message)
                Return False
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            DesconectarDIAPIGT()
        End Try

    End Function
    'Public Function SAP_DIAPI_ActualizacionCodigosArticulo(ByVal arrBaseDatos As ArrayList, ByVal arrCodigosActualizar As ArrayList, ByVal dtCamposSAP As DataTable, ByVal dtCamposUsuario As DataTable) As Boolean

    '    'Public Function SAP_DIAPI_OrdenesEnsamble() As Boolean
    '    Try
    '        Try
    '            ConectarDIAPIGT()
    '            ConectarDIAPISV()

    '            If Not (oCompanyGT.Connected) Then
    '                Throw New Exception("Debe conectarse a sap!")
    '            End If
    '            If Not (oCompanyES.Connected) Then
    '                Throw New Exception("Debe conectarse a sap!")
    '            End If

    '            oCompanyGT.StartTransaction() 'Inicia la Transaccion
    '            oCompanyES.StartTransaction() 'Inicia la Transaccion


    '            'crear un objeto tipo producto
    '            Dim oTransGT As SAPbobsCOM.Items
    '            Dim oTransES As SAPbobsCOM.Items

    '            'instanciar la variable
    '            oTransGT = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems)
    '            oTransES = oCompanyES.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems)

    '            'Obtener Codigo Actualizar
    '            oTransGT.GetByKey("AR010040-CRS-0")
    '            oTransES.GetByKey("AR010040-CRS-0")


    '            oTransES.ItemName = oTransGT.ItemName
    '            oTransES.ForeignName = oTransGT.ForeignName
    '            oTransES.BarCode = oTransGT.BarCode
    '            oTransES.ItemsGroupCode = oTransGT.ItemsGroupCode
    '            oTransES.InventoryItem = oTransGT.InventoryItem
    '            oTransES.SalesItem = oTransGT.SalesItem
    '            oTransES.PurchaseItemsPerUnit = oTransGT.PurchaseItemsPerUnit
    '            oTransES.PurchasePackagingUnit = oTransGT.PurchasePackagingUnit
    '            oTransES.SalesItemsPerUnit = oTransGT.SalesItemsPerUnit
    '            oTransES.SalesPackagingUnit = oTransGT.SalesPackagingUnit
    '            oTransES.InventoryUOM = oTransGT.InventoryUOM
    '            oTransES.UserFields.Fields.Item("U_Color").Value = oTransGT.UserFields.Fields.Item("U_Color").Value
    '            oTransES.UserFields.Fields.Item("U_Upc").Value = oTransGT.UserFields.Fields.Item("U_Upc").Value
    '            oTransES.UserFields.Fields.Item("U_NoDeLinea").Value = oTransGT.UserFields.Fields.Item("U_NoDeLinea").Value
    '            oTransES.UserFields.Fields.Item("U_ItemCR").Value = oTransGT.UserFields.Fields.Item("U_ItemCR").Value
    '            oTransES.UserFields.Fields.Item("U_ItemOPS").Value = oTransGT.UserFields.Fields.Item("U_ItemOPS").Value
    '            oTransES.UserFields.Fields.Item("U_ItemGUA").Value = oTransGT.UserFields.Fields.Item("U_ItemGUA").Value
    '            oTransES.UserFields.Fields.Item("U_ItemOPO").Value = oTransGT.UserFields.Fields.Item("U_ItemOPO").Value
    '            oTransES.UserFields.Fields.Item("U_Dun_14").Value = oTransGT.UserFields.Fields.Item("U_Dun_14").Value
    '            oTransES.UserFields.Fields.Item("U_FechadeCreacion").Value = oTransGT.UserFields.Fields.Item("U_FechadeCreacion").Value
    '            oTransES.UserFields.Fields.Item("U_FechaIntroduccion").Value = oTransGT.UserFields.Fields.Item("U_FechaIntroduccion").Value
    '            oTransES.UserFields.Fields.Item("U_Descrip1").Value = oTransGT.UserFields.Fields.Item("U_Descrip1").Value
    '            oTransES.UserFields.Fields.Item("U_Descrip2").Value = oTransGT.UserFields.Fields.Item("U_Descrip2").Value
    '            oTransES.UserFields.Fields.Item("U_DescripSenaliz").Value = oTransGT.UserFields.Fields.Item("U_DescripSenaliz").Value
    '            oTransES.UserFields.Fields.Item("U_DescripcionCorta").Value = oTransGT.UserFields.Fields.Item("U_DescripcionCorta").Value
    '            oTransES.UserFields.Fields.Item("U_DescripTicketCaja").Value = oTransGT.UserFields.Fields.Item("U_DescripTicketCaja").Value

    '            Dim oResultado As Integer
    '            oResultado = oTransES.Update()

    '            If (oResultado = 0) Then


    '                oCompanyES.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
    '                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)

    '                MsgBox("Su Transacción se ha grabado exitosamente. Salida de Mercancia # " + "ar010040-crs-0" + ".", MsgBoxStyle.OkOnly, "SAP DIAPI")

    '                Return True
    '            Else
    '                MsgBox(oCompanyGT.GetLastErrorDescription())
    '                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
    '                Return False
    '            End If

    '        Catch ex As Exception
    '            oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
    '            MsgBox(ex.Message)
    '            Return False
    '        End Try

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return False
    '    Finally
    '        DesconectarDIAPIGT()
    '    End Try

    'End Function
    Public Function SAP_DIAPI_ActualizacionCodigosArticulo(ByVal pAgregar As Boolean, ByVal pActualizar As Boolean, ByVal arrBaseDatos As ArrayList, ByVal arrCodigosActualizar As ArrayList, ByVal dtCamposSAP As DataTable, ByVal pSplash As DevExpress.XtraSplashScreen.SplashScreenManager) As Boolean

        Try
            Try

                'Test pSplash
                If pSplash Is Nothing Then
                    pSplash = New SplashScreenManager(frmArticulosActualizacion, GetType(splEsperar), True, True)
                End If

                'If Not pSplash.IsSplashFormVisible Then : pSplash.ShowWaitForm() : End If

                If Not pSplash.IsSplashFormVisible Then
                    pSplash.ShowWaitForm()
                    pSplash.SetWaitFormCaption("Cargando")
                    pSplash.SetWaitFormDescription("Por favor, espere...")
                    Application.DoEvents() ' Forzar la actualización de la UI
                End If


                'DB
                Dim dbElSalvador As Boolean = False
                Dim dbCostaRica As Boolean = False
                Dim dbMexico As Boolean = False

                'Conectar a DB Guatemala
                If Not oCompanyGT.Connected Then
                    pSplash.SetWaitFormCaption("Conectando DB")
                    pSplash.SetWaitFormDescription("Guatemala")
                    ConectarDIAPIGT()
                Else
                    pSplash.SetWaitFormCaption("Conectando DB")
                    pSplash.SetWaitFormDescription("Guatemala")
                End If

                'Conectar a las demás bases de datos
                For Each db In arrBaseDatos
                    Select Case db.ToString()
                        Case "ElSalvador"
                            If Not oCompanyES.Connected Then
                                If ConectarDIAPISV() Then
                                    pSplash.SetWaitFormCaption("Conectando DB")
                                    pSplash.SetWaitFormDescription("El Salvador")
                                End If
                            Else
                                pSplash.SetWaitFormCaption("Conectando DB")
                                pSplash.SetWaitFormDescription("El Salvador")
                            End If
                            dbElSalvador = True
                        Case "CR"
                            If Not oCompanyCR.Connected Then
                                If ConectarDIAPICR() Then
                                    pSplash.SetWaitFormCaption("Conectando DB")
                                    pSplash.SetWaitFormDescription("Costa Rica")
                                End If
                            Else
                                pSplash.SetWaitFormCaption("Conectando DB")
                                pSplash.SetWaitFormDescription("Costa Rica")
                            End If
                            dbCostaRica = True
                        Case "Mexico"
                            If Not oCompanyMX.Connected Then
                                If ConectarDIAPI_MX() Then
                                    pSplash.SetWaitFormCaption("Conectando DB")
                                    pSplash.SetWaitFormDescription("Mexico")
                                End If
                            Else
                                pSplash.SetWaitFormCaption("Conectando DB")
                                pSplash.SetWaitFormDescription("Mexico")
                            End If
                            dbMexico = True
                    End Select
                Next


                Dim oTransGT As SAPbobsCOM.Items 'crear un objeto tipo producto

                oTransGT = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems)

                For a = 0 To arrCodigosActualizar.Count - 1

#Region "Actualizar/Insertar El Salvador"

                    If dbElSalvador = True Then
                        Dim oTransES As SAPbobsCOM.Items 'crear un objeto tipo producto
                        oTransES = oCompanyES.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems) 'instanciar la variable

                        oCompanyGT.StartTransaction()
                        oCompanyES.StartTransaction() 'Inicia la Transaccion
                        oTransGT.GetByKey(arrCodigosActualizar.Item(a)("CodigoArticulo"))

                        If arrCodigosActualizar.Item(a)("El Salvador").ToString = "SI" And pActualizar = True Then
#Region "Actualizar El Salvador"

                            'Actualizar SV
                            pSplash.SetWaitFormCaption("[SV] Actualizando...")
                            pSplash.SetWaitFormDescription(arrCodigosActualizar.Item(a)("CodigoArticulo").ToString)

                            oTransES.GetByKey(arrCodigosActualizar.Item(a)("CodigoArticulo"))

                            Dim CampoSAP As String = String.Empty
                            If Not dtCamposSAP.Rows.Count = Nothing Then
                                For s = 0 To dtCamposSAP.Rows.Count - 1
                                    CampoSAP = dtCamposSAP.Rows(s)("Id")

                                    oTransES.Valid = SAPbobsCOM.BoYesNoEnum.tYES

                                    Select Case CampoSAP
                                        Case "ItemName"
                                            oTransES.ItemName = oTransGT.ItemName
                                        Case "ForeignName"
                                            oTransES.ForeignName = oTransGT.ForeignName
                                        Case "BarCode"
                                            oTransES.BarCode = oTransGT.BarCode
                                        Case "ItemsGroupCode"
                                            oTransES.ItemsGroupCode = oTransGT.ItemsGroupCode
                                        Case "InventoryItem"
                                            oTransES.InventoryItem = oTransGT.InventoryItem
                                        Case "SalesItem"
                                            oTransES.SalesItem = oTransGT.SalesItem
                                        Case "PurchaseItemsPerUnit"
                                            oTransES.PurchaseItemsPerUnit = oTransGT.PurchaseItemsPerUnit
                                        Case "PurchasePackagingUnit"
                                            oTransES.PurchasePackagingUnit = oTransGT.PurchasePackagingUnit
                                        Case "SalesItemsPerUnit"
                                            oTransES.SalesItemsPerUnit = oTransGT.SalesItemsPerUnit
                                        Case "SalesPackagingUnit"
                                            oTransES.SalesPackagingUnit = oTransGT.SalesPackagingUnit
                                        Case "InventoryUOM"
                                            oTransES.InventoryUOM = oTransGT.InventoryUOM

                                            'CAMPOS USUARIO
                                        Case "U_Color"
                                            oTransES.UserFields.Fields.Item("U_Color").Value = oTransGT.UserFields.Fields.Item("U_Color").Value
                                        Case "U_Upc"
                                            oTransES.UserFields.Fields.Item("U_Upc").Value = oTransGT.UserFields.Fields.Item("U_Upc").Value
                                        Case "U_NoDeLinea"
                                            oTransES.UserFields.Fields.Item("U_NoDeLinea").Value = oTransGT.UserFields.Fields.Item("U_NoDeLinea").Value
                                        Case "U_ItemCR"
                                            oTransES.UserFields.Fields.Item("U_ItemCR").Value = oTransGT.UserFields.Fields.Item("U_ItemCR").Value
                                        Case "U_ItemOPS"
                                            oTransES.UserFields.Fields.Item("U_ItemOPS").Value = oTransGT.UserFields.Fields.Item("U_ItemOPS").Value
                                        Case "U_ItemGUA"
                                            oTransES.UserFields.Fields.Item("U_ItemGUA").Value = oTransGT.UserFields.Fields.Item("U_ItemGUA").Value
                                        Case "U_ItemOPO"
                                            oTransES.UserFields.Fields.Item("U_ItemOPO").Value = oTransGT.UserFields.Fields.Item("U_ItemOPO").Value
                                        Case "U_Dun_14"
                                            oTransES.UserFields.Fields.Item("U_Dun_14").Value = oTransGT.UserFields.Fields.Item("U_Dun_14").Value
                                        Case "U_FechadeCreacion"
                                            oTransES.UserFields.Fields.Item("U_FechadeCreacion").Value = oTransGT.UserFields.Fields.Item("U_FechadeCreacion").Value
                                        Case "U_FechaIntroduccion"
                                            oTransES.UserFields.Fields.Item("U_FechaIntroduccion").Value = oTransGT.UserFields.Fields.Item("U_FechaIntroduccion").Value
                                        Case "U_Descrip1"
                                            oTransES.UserFields.Fields.Item("U_Descrip1").Value = oTransGT.UserFields.Fields.Item("U_Descrip1").Value
                                        Case "U_Descrip2"
                                            oTransES.UserFields.Fields.Item("U_Descrip2").Value = oTransGT.UserFields.Fields.Item("U_Descrip2").Value
                                        Case "U_DescripSenaliz"
                                            oTransES.UserFields.Fields.Item("U_DescripSenaliz").Value = oTransGT.UserFields.Fields.Item("U_DescripSenaliz").Value
                                        Case "U_DescripcionCorta"
                                            oTransES.UserFields.Fields.Item("U_DescripcionCorta").Value = oTransGT.UserFields.Fields.Item("U_DescripcionCorta").Value
                                        Case "U_DescripTicketCaja"
                                            oTransES.UserFields.Fields.Item("U_DescripTicketCaja").Value = oTransGT.UserFields.Fields.Item("U_DescripTicketCaja").Value
                                        Case "U_Descontinuado"
                                            If oTransGT.UserFields.Fields.Item("U_Descontinuado").Value = "" Then
                                                oTransES.UserFields.Fields.Item("U_Descontinuado").Value = "S"
                                            End If
                                        Case "U_MostrarEnCatalogo"
                                            oTransES.UserFields.Fields.Item("U_MostrarEnCatalogo").Value = oTransGT.UserFields.Fields.Item("U_MostrarEnCatalogo").Value
                                        Case "U_EmpaqueVta"
                                            oTransES.UserFields.Fields.Item("U_EmpaqueVta").Value = oTransGT.UserFields.Fields.Item("U_EmpaqueVta").Value


                                    End Select

                                Next


                                Dim oResultado As Integer
                                oResultado = oTransES.Update()

                                If (oResultado = 0) Then
                                    oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                                    oCompanyES.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)

                                Else
                                    MsgBox(oCompanyES.GetLastErrorDescription())
                                    oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                                    oCompanyES.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)

                                End If

                            End If
                        ElseIf arrCodigosActualizar.Item(a)("El Salvador").ToString = "NO" And pAgregar = True Then
#End Region

#Region "Insertar El Salvador"

                            'Insertar SV
                            pSplash.SetWaitFormCaption("[SV] Agregando...")
                            pSplash.SetWaitFormDescription(arrCodigosActualizar.Item(a)("CodigoArticulo").ToString)

                            oTransGT.GetByKey(arrCodigosActualizar.Item(a)("CodigoArticulo"))

                            oTransES.Valid = SAPbobsCOM.BoYesNoEnum.tYES
                            oTransES.ItemCode = oTransGT.ItemCode
                            oTransES.ItemName = oTransGT.ItemName
                            oTransES.ForeignName = oTransGT.ForeignName
                            oTransES.BarCode = oTransGT.BarCode
                            oTransES.ItemsGroupCode = oTransGT.ItemsGroupCode
                            oTransES.InventoryItem = oTransGT.InventoryItem
                            oTransES.SalesItem = oTransGT.SalesItem
                            oTransES.PurchaseItemsPerUnit = oTransGT.PurchaseItemsPerUnit
                            oTransES.PurchasePackagingUnit = oTransGT.PurchasePackagingUnit
                            oTransES.SalesItemsPerUnit = oTransGT.SalesItemsPerUnit
                            oTransES.SalesPackagingUnit = oTransGT.SalesPackagingUnit
                            oTransES.InventoryUOM = oTransGT.InventoryUOM
                            oTransES.UserFields.Fields.Item("U_Color").Value = oTransGT.UserFields.Fields.Item("U_Color").Value
                            oTransES.UserFields.Fields.Item("U_Upc").Value = oTransGT.UserFields.Fields.Item("U_Upc").Value
                            oTransES.UserFields.Fields.Item("U_NoDeLinea").Value = oTransGT.UserFields.Fields.Item("U_NoDeLinea").Value
                            oTransES.UserFields.Fields.Item("U_ItemCR").Value = oTransGT.UserFields.Fields.Item("U_ItemCR").Value
                            oTransES.UserFields.Fields.Item("U_ItemOPS").Value = oTransGT.UserFields.Fields.Item("U_ItemOPS").Value
                            oTransES.UserFields.Fields.Item("U_ItemGUA").Value = oTransGT.UserFields.Fields.Item("U_ItemGUA").Value
                            oTransES.UserFields.Fields.Item("U_ItemOPO").Value = oTransGT.UserFields.Fields.Item("U_ItemOPO").Value
                            oTransES.UserFields.Fields.Item("U_Dun_14").Value = oTransGT.UserFields.Fields.Item("U_Dun_14").Value
                            oTransES.UserFields.Fields.Item("U_FechadeCreacion").Value = oTransGT.UserFields.Fields.Item("U_FechadeCreacion").Value
                            oTransES.UserFields.Fields.Item("U_FechaIntroduccion").Value = oTransGT.UserFields.Fields.Item("U_FechaIntroduccion").Value
                            oTransES.UserFields.Fields.Item("U_Descrip1").Value = oTransGT.UserFields.Fields.Item("U_Descrip1").Value
                            oTransES.UserFields.Fields.Item("U_Descrip2").Value = oTransGT.UserFields.Fields.Item("U_Descrip2").Value
                            oTransES.UserFields.Fields.Item("U_DescripSenaliz").Value = oTransGT.UserFields.Fields.Item("U_DescripSenaliz").Value
                            oTransES.UserFields.Fields.Item("U_DescripcionCorta").Value = oTransGT.UserFields.Fields.Item("U_DescripcionCorta").Value
                            oTransES.UserFields.Fields.Item("U_DescripTicketCaja").Value = oTransGT.UserFields.Fields.Item("U_DescripTicketCaja").Value
                            If oTransGT.UserFields.Fields.Item("U_Descontinuado").Value = "" Then
                                oTransES.UserFields.Fields.Item("U_Descontinuado").Value = "S"
                            End If

                            oTransES.UserFields.Fields.Item("U_MostrarEnCatalogo").Value = oTransGT.UserFields.Fields.Item("U_MostrarEnCatalogo").Value
                            oTransES.UserFields.Fields.Item("U_EmpaqueVta").Value = oTransGT.UserFields.Fields.Item("U_EmpaqueVta").Value

                            Dim oResultado As Integer
                            oResultado = oTransES.Add()

                            If (oResultado = 0) Then
                                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                                oCompanyES.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)

                            Else
                                MsgBox(oCompanyES.GetLastErrorDescription())
                                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                                oCompanyES.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)

                            End If

                        End If
                    End If
#End Region

#End Region

#Region "Actualizar/Insertar Costa Rica"

                    If dbCostaRica = True Then
                        Dim oTransCR As SAPbobsCOM.Items 'crear un objeto tipo producto
                        oTransCR = oCompanyCR.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems) 'instanciar la variable

                        oCompanyGT.StartTransaction()
                        oCompanyCR.StartTransaction() 'Inicia la Transaccion
                        oTransGT.GetByKey(arrCodigosActualizar.Item(a)("CodigoArticulo"))

                        If arrCodigosActualizar.Item(a)("Costa Rica").ToString = "SI" And pActualizar = True Then
#Region "Actualizar Costa Rica"

                            'Actualizar CR
                            pSplash.SetWaitFormCaption("[CR] Actualizando...")
                            pSplash.SetWaitFormDescription(arrCodigosActualizar.Item(a)("CodigoArticulo").ToString)

                            oTransCR.GetByKey(arrCodigosActualizar.Item(a)("CodigoArticulo"))

                            Dim CampoSAP As String = String.Empty
                            If Not dtCamposSAP.Rows.Count = Nothing Then
                                For s = 0 To dtCamposSAP.Rows.Count - 1
                                    CampoSAP = dtCamposSAP.Rows(s)("Id")

                                    oTransCR.Valid = SAPbobsCOM.BoYesNoEnum.tYES
                                    Select Case CampoSAP
                                        Case "ItemName"
                                            oTransCR.ItemName = oTransGT.ItemName
                                        Case "ForeignName"
                                            oTransCR.ForeignName = oTransGT.ForeignName
                                        Case "BarCode"
                                            oTransCR.BarCode = oTransGT.BarCode
                                        Case "ItemsGroupCode"
                                            oTransCR.ItemsGroupCode = oTransGT.ItemsGroupCode
                                        Case "InventoryItem"
                                            oTransCR.InventoryItem = oTransGT.InventoryItem
                                        Case "SalesItem"
                                            oTransCR.SalesItem = oTransGT.SalesItem
                                        Case "PurchaseItemsPerUnit"
                                            oTransCR.PurchaseItemsPerUnit = oTransGT.PurchaseItemsPerUnit
                                        Case "PurchasePackagingUnit"
                                            oTransCR.PurchasePackagingUnit = oTransGT.PurchasePackagingUnit
                                        Case "SalesItemsPerUnit"
                                            oTransCR.SalesItemsPerUnit = oTransGT.SalesItemsPerUnit
                                        Case "SalesPackagingUnit"
                                            oTransCR.SalesPackagingUnit = oTransGT.SalesPackagingUnit
                                        Case "InventoryUOM"
                                            oTransCR.InventoryUOM = oTransGT.InventoryUOM

                                            'CAMPOS USUARIO
                                        Case "U_Color"
                                            oTransCR.UserFields.Fields.Item("U_Color").Value = oTransGT.UserFields.Fields.Item("U_Color").Value
                                        Case "U_Upc"
                                            oTransCR.UserFields.Fields.Item("U_Upc").Value = oTransGT.UserFields.Fields.Item("U_Upc").Value
                                        Case "U_NoDeLinea"
                                            oTransCR.UserFields.Fields.Item("U_NoDeLinea").Value = oTransGT.UserFields.Fields.Item("U_NoDeLinea").Value
                                        Case "U_ItemCR"
                                            oTransCR.UserFields.Fields.Item("U_ItemCR").Value = oTransGT.UserFields.Fields.Item("U_ItemCR").Value
                                        Case "U_ItemOPS"
                                            oTransCR.UserFields.Fields.Item("U_ItemOPS").Value = oTransGT.UserFields.Fields.Item("U_ItemOPS").Value
                                        Case "U_ItemGUA"
                                            oTransCR.UserFields.Fields.Item("U_ItemGUA").Value = oTransGT.UserFields.Fields.Item("U_ItemGUA").Value
                                        Case "U_ItemOPO"
                                            oTransCR.UserFields.Fields.Item("U_ItemOPO").Value = oTransGT.UserFields.Fields.Item("U_ItemOPO").Value
                                        Case "U_Dun_14"
                                            oTransCR.UserFields.Fields.Item("U_Dun_14").Value = oTransGT.UserFields.Fields.Item("U_Dun_14").Value
                                        Case "U_FechadeCreacion"
                                            oTransCR.UserFields.Fields.Item("U_FechadeCreacion").Value = oTransGT.UserFields.Fields.Item("U_FechadeCreacion").Value
                                        Case "U_FechaIntroduccion"
                                            oTransCR.UserFields.Fields.Item("U_FechaIntroduccion").Value = oTransGT.UserFields.Fields.Item("U_FechaIntroduccion").Value
                                        Case "U_Descrip1"
                                            oTransCR.UserFields.Fields.Item("U_Descrip1").Value = oTransGT.UserFields.Fields.Item("U_Descrip1").Value
                                        Case "U_Descrip2"
                                            oTransCR.UserFields.Fields.Item("U_Descrip2").Value = oTransGT.UserFields.Fields.Item("U_Descrip2").Value
                                        Case "U_DescripSenaliz"
                                            oTransCR.UserFields.Fields.Item("U_DescripSenaliz").Value = oTransGT.UserFields.Fields.Item("U_DescripSenaliz").Value
                                        Case "U_DescripcionCorta"
                                            oTransCR.UserFields.Fields.Item("U_DescripcionCorta").Value = oTransGT.UserFields.Fields.Item("U_DescripcionCorta").Value
                                        Case "U_DescripTicketCaja"
                                            oTransCR.UserFields.Fields.Item("U_DescripTicketCaja").Value = oTransGT.UserFields.Fields.Item("U_DescripTicketCaja").Value
                                        Case "U_Descontinuado"
                                            If oTransGT.UserFields.Fields.Item("U_Descontinuado").Value = "" Then
                                                oTransCR.UserFields.Fields.Item("U_Descontinuado").Value = "S"
                                            End If
                                        Case "U_MostrarEnCatalogo"
                                            oTransCR.UserFields.Fields.Item("U_MostrarEnCatalogo").Value = oTransGT.UserFields.Fields.Item("U_MostrarEnCatalogo").Value
                                        Case "U_EmpaqueVta"
                                            oTransCR.UserFields.Fields.Item("U_EmpaqueVta").Value = oTransGT.UserFields.Fields.Item("U_EmpaqueVta").Value
                                    End Select

                                Next

                                Dim oResultado As Integer
                                oResultado = oTransCR.Update()

                                If (oResultado = 0) Then
                                    oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                                    oCompanyCR.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)

                                Else
                                    MsgBox(oCompanyCR.GetLastErrorDescription())
                                    oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                                    oCompanyCR.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                                End If

                            End If
                        ElseIf arrCodigosActualizar.Item(a)("Costa Rica").ToString = "NO" And pAgregar = True Then
#End Region

#Region "Insertar Costa Rica"
                            'Insertar CR
                            pSplash.SetWaitFormCaption("[CR] Actualizando...")
                            pSplash.SetWaitFormDescription(arrCodigosActualizar.Item(a)("CodigoArticulo").ToString)

                            oTransGT.GetByKey(arrCodigosActualizar.Item(a)("CodigoArticulo"))

                            oTransCR.Valid = SAPbobsCOM.BoYesNoEnum.tYES 'Este campo es obligatorio que este en "Yes" para poder actualizar el Item
                            oTransCR.ItemCode = oTransGT.ItemCode
                            oTransCR.ItemName = oTransGT.ItemName
                            oTransCR.ForeignName = oTransGT.ForeignName
                            oTransCR.BarCode = oTransGT.BarCode
                            oTransCR.ItemsGroupCode = oTransGT.ItemsGroupCode
                            oTransCR.InventoryItem = oTransGT.InventoryItem
                            oTransCR.SalesItem = oTransGT.SalesItem
                            oTransCR.PurchaseItemsPerUnit = oTransGT.PurchaseItemsPerUnit
                            oTransCR.PurchasePackagingUnit = oTransGT.PurchasePackagingUnit
                            oTransCR.SalesItemsPerUnit = oTransGT.SalesItemsPerUnit
                            oTransCR.SalesPackagingUnit = oTransGT.SalesPackagingUnit
                            oTransCR.InventoryUOM = oTransGT.InventoryUOM
                            oTransCR.UserFields.Fields.Item("U_Color").Value = oTransGT.UserFields.Fields.Item("U_Color").Value
                            oTransCR.UserFields.Fields.Item("U_Upc").Value = oTransGT.UserFields.Fields.Item("U_Upc").Value
                            oTransCR.UserFields.Fields.Item("U_NoDeLinea").Value = oTransGT.UserFields.Fields.Item("U_NoDeLinea").Value
                            oTransCR.UserFields.Fields.Item("U_ItemCR").Value = oTransGT.UserFields.Fields.Item("U_ItemCR").Value
                            oTransCR.UserFields.Fields.Item("U_ItemOPS").Value = oTransGT.UserFields.Fields.Item("U_ItemOPS").Value
                            oTransCR.UserFields.Fields.Item("U_ItemGUA").Value = oTransGT.UserFields.Fields.Item("U_ItemGUA").Value
                            oTransCR.UserFields.Fields.Item("U_ItemOPO").Value = oTransGT.UserFields.Fields.Item("U_ItemOPO").Value
                            oTransCR.UserFields.Fields.Item("U_Dun_14").Value = oTransGT.UserFields.Fields.Item("U_Dun_14").Value
                            oTransCR.UserFields.Fields.Item("U_FechadeCreacion").Value = oTransGT.UserFields.Fields.Item("U_FechadeCreacion").Value
                            oTransCR.UserFields.Fields.Item("U_FechaIntroduccion").Value = oTransGT.UserFields.Fields.Item("U_FechaIntroduccion").Value
                            oTransCR.UserFields.Fields.Item("U_Descrip1").Value = oTransGT.UserFields.Fields.Item("U_Descrip1").Value
                            oTransCR.UserFields.Fields.Item("U_Descrip2").Value = oTransGT.UserFields.Fields.Item("U_Descrip2").Value
                            oTransCR.UserFields.Fields.Item("U_DescripSenaliz").Value = oTransGT.UserFields.Fields.Item("U_DescripSenaliz").Value
                            oTransCR.UserFields.Fields.Item("U_DescripcionCorta").Value = oTransGT.UserFields.Fields.Item("U_DescripcionCorta").Value
                            oTransCR.UserFields.Fields.Item("U_DescripTicketCaja").Value = oTransGT.UserFields.Fields.Item("U_DescripTicketCaja").Value
                            If oTransGT.UserFields.Fields.Item("U_Descontinuado").Value = "" Then
                                oTransCR.UserFields.Fields.Item("U_Descontinuado").Value = "S"
                            End If
                            oTransCR.UserFields.Fields.Item("U_MostrarEnCatalogo").Value = oTransGT.UserFields.Fields.Item("U_MostrarEnCatalogo").Value
                            oTransCR.UserFields.Fields.Item("U_EmpaqueVta").Value = oTransGT.UserFields.Fields.Item("U_EmpaqueVta").Value

                            Dim oResultado As Integer
                            oResultado = oTransCR.Add()

                            If (oResultado = 0) Then
                                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                                oCompanyCR.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)

                            Else
                                MsgBox(oCompanyCR.GetLastErrorDescription())
                                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                                oCompanyCR.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)

                            End If

                        End If
                    End If
#End Region

#End Region

#Region "Actualizar/Insertar Mexico"

                    If dbMexico = True Then
                        Dim oTransMX As SAPbobsCOM.Items 'crear un objeto tipo producto
                        oTransMX = oCompanyMX.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems) 'instanciar la variable

                        oCompanyGT.StartTransaction()
                        oCompanyMX.StartTransaction() 'Inicia la Transaccion
                        oTransGT.GetByKey(arrCodigosActualizar.Item(a)("CodigoArticulo"))

                        If arrCodigosActualizar.Item(a)("Mexico").ToString = "SI" And pActualizar = True Then
#Region "Actualizar Mexico"
                            'Actualizar MX
                            pSplash.SetWaitFormCaption("[MX] Actualizando...")
                            pSplash.SetWaitFormDescription(arrCodigosActualizar.Item(a)("CodigoArticulo").ToString)

                            oTransMX.GetByKey(arrCodigosActualizar.Item(a)("CodigoArticulo"))

                            Dim CampoSAP As String = String.Empty
                            If Not dtCamposSAP.Rows.Count = Nothing Then
                                For s = 0 To dtCamposSAP.Rows.Count - 1
                                    CampoSAP = dtCamposSAP.Rows(s)("Id")

                                    oTransMX.Valid = SAPbobsCOM.BoYesNoEnum.tYES
                                    Select Case CampoSAP
                                        Case "ItemName"
                                            oTransMX.ItemName = oTransGT.ItemName
                                        Case "ForeignName"
                                            oTransMX.ForeignName = oTransGT.ForeignName
                                        Case "BarCode"
                                            oTransMX.BarCode = oTransGT.BarCode
                                        Case "ItemsGroupCode"
                                            oTransMX.ItemsGroupCode = oTransGT.ItemsGroupCode
                                        Case "InventoryItem"
                                            oTransMX.InventoryItem = oTransGT.InventoryItem
                                        Case "SalesItem"
                                            oTransMX.SalesItem = oTransGT.SalesItem
                                        Case "PurchaseItemsPerUnit"
                                            oTransMX.PurchaseItemsPerUnit = oTransGT.PurchaseItemsPerUnit
                                        Case "PurchasePackagingUnit"
                                            oTransMX.PurchasePackagingUnit = oTransGT.PurchasePackagingUnit
                                        Case "SalesItemsPerUnit"
                                            oTransMX.SalesItemsPerUnit = oTransGT.SalesItemsPerUnit
                                        Case "SalesPackagingUnit"
                                            oTransMX.SalesPackagingUnit = oTransGT.SalesPackagingUnit
                                        Case "InventoryUOM"
                                            oTransMX.InventoryUOM = oTransGT.InventoryUOM

                                            'CAMPOS USUARIO
                                        Case "U_Color"
                                            oTransMX.UserFields.Fields.Item("U_Color").Value = oTransGT.UserFields.Fields.Item("U_Color").Value
                                        Case "U_Upc"
                                            oTransMX.UserFields.Fields.Item("U_Upc").Value = oTransGT.UserFields.Fields.Item("U_Upc").Value
                                        Case "U_NoDeLinea"
                                            oTransMX.UserFields.Fields.Item("U_NoDeLinea").Value = oTransGT.UserFields.Fields.Item("U_NoDeLinea").Value
                                        Case "U_ItemCR"
                                            oTransMX.UserFields.Fields.Item("U_ItemCR").Value = oTransGT.UserFields.Fields.Item("U_ItemCR").Value
                                        Case "U_ItemOPS"
                                            oTransMX.UserFields.Fields.Item("U_ItemOPS").Value = oTransGT.UserFields.Fields.Item("U_ItemOPS").Value
                                        Case "U_ItemGUA"
                                            oTransMX.UserFields.Fields.Item("U_ItemGUA").Value = oTransGT.UserFields.Fields.Item("U_ItemGUA").Value
                                        Case "U_ItemOPO"
                                            oTransMX.UserFields.Fields.Item("U_ItemOPO").Value = oTransGT.UserFields.Fields.Item("U_ItemOPO").Value
                                        Case "U_Dun_14"
                                            oTransMX.UserFields.Fields.Item("U_Dun_14").Value = oTransGT.UserFields.Fields.Item("U_Dun_14").Value
                                        Case "U_FechadeCreacion"
                                            oTransMX.UserFields.Fields.Item("U_FechadeCreacion").Value = oTransGT.UserFields.Fields.Item("U_FechadeCreacion").Value
                                        Case "U_FechaIntroduccion"
                                            oTransMX.UserFields.Fields.Item("U_FechaIntroduccion").Value = oTransGT.UserFields.Fields.Item("U_FechaIntroduccion").Value
                                        Case "U_Descrip1"
                                            oTransMX.UserFields.Fields.Item("U_Descrip1").Value = oTransGT.UserFields.Fields.Item("U_Descrip1").Value
                                        Case "U_Descrip2"
                                            oTransMX.UserFields.Fields.Item("U_Descrip2").Value = oTransGT.UserFields.Fields.Item("U_Descrip2").Value
                                        Case "U_DescripSenaliz"
                                            oTransMX.UserFields.Fields.Item("U_DescripSenaliz").Value = oTransGT.UserFields.Fields.Item("U_DescripSenaliz").Value
                                        Case "U_DescripcionCorta"
                                            oTransMX.UserFields.Fields.Item("U_DescripcionCorta").Value = oTransGT.UserFields.Fields.Item("U_DescripcionCorta").Value
                                        Case "U_DescripTicketCaja"
                                            oTransMX.UserFields.Fields.Item("U_DescripTicketCaja").Value = oTransGT.UserFields.Fields.Item("U_DescripTicketCaja").Value
                                        Case "U_Descontinuado"
                                            If oTransGT.UserFields.Fields.Item("U_Descontinuado").Value = "" Then
                                                oTransMX.UserFields.Fields.Item("U_Descontinuado").Value = "S"
                                            End If
                                        Case "U_MostrarEnCatalogo"
                                            oTransMX.UserFields.Fields.Item("U_MostrarEnCatalogo").Value = oTransGT.UserFields.Fields.Item("U_MostrarEnCatalogo").Value
                                        Case "U_EmpaqueVta"
                                            oTransMX.UserFields.Fields.Item("U_EmpaqueVta").Value = oTransGT.UserFields.Fields.Item("U_EmpaqueVta").Value
                                    End Select

                                Next


                                Dim oResultado As Integer
                                oResultado = oTransMX.Update()

                                If (oResultado = 0) Then
                                    oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                                    oCompanyMX.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)

                                Else
                                    MsgBox(oCompanyMX.GetLastErrorDescription())
                                    oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                                    oCompanyMX.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)

                                End If

                            End If
                        ElseIf arrCodigosActualizar.Item(a)("Mexico").ToString = "NO" And pAgregar = True Then
#End Region

#Region "Insertar Mexico "

                            'Insertar MX
                            pSplash.SetWaitFormCaption("[MX] Actualizando...")
                            pSplash.SetWaitFormDescription(arrCodigosActualizar.Item(a)("CodigoArticulo").ToString)

                            oTransGT.GetByKey(arrCodigosActualizar.Item(a)("CodigoArticulo"))

                            oTransMX.Valid = SAPbobsCOM.BoYesNoEnum.tYES 'Este campo es obligatorio que este en "Yes" para poder actualizar el Item
                            oTransMX.ItemCode = oTransGT.ItemCode
                            oTransMX.ItemName = oTransGT.ItemName
                            oTransMX.ForeignName = oTransGT.ForeignName
                            oTransMX.BarCode = oTransGT.BarCode
                            oTransMX.ItemsGroupCode = oTransGT.ItemsGroupCode
                            oTransMX.InventoryItem = oTransGT.InventoryItem
                            oTransMX.SalesItem = oTransGT.SalesItem
                            oTransMX.PurchaseItemsPerUnit = oTransGT.PurchaseItemsPerUnit
                            oTransMX.PurchasePackagingUnit = oTransGT.PurchasePackagingUnit
                            oTransMX.SalesItemsPerUnit = oTransGT.SalesItemsPerUnit
                            oTransMX.SalesPackagingUnit = oTransGT.SalesPackagingUnit
                            oTransMX.InventoryUOM = oTransGT.InventoryUOM
                            oTransMX.UserFields.Fields.Item("U_Color").Value = oTransGT.UserFields.Fields.Item("U_Color").Value
                            oTransMX.UserFields.Fields.Item("U_Upc").Value = oTransGT.UserFields.Fields.Item("U_Upc").Value
                            oTransMX.UserFields.Fields.Item("U_NoDeLinea").Value = oTransGT.UserFields.Fields.Item("U_NoDeLinea").Value
                            oTransMX.UserFields.Fields.Item("U_ItemCR").Value = oTransGT.UserFields.Fields.Item("U_ItemCR").Value 'Validar este campo si se llama diferente
                            oTransMX.UserFields.Fields.Item("U_ItemOPS").Value = oTransGT.UserFields.Fields.Item("U_ItemOPS").Value
                            oTransMX.UserFields.Fields.Item("U_ItemGUA").Value = oTransGT.UserFields.Fields.Item("U_ItemGUA").Value
                            oTransMX.UserFields.Fields.Item("U_ItemOPO").Value = oTransGT.UserFields.Fields.Item("U_ItemOPO").Value
                            oTransMX.UserFields.Fields.Item("U_Dun_14").Value = oTransGT.UserFields.Fields.Item("U_Dun_14").Value
                            oTransMX.UserFields.Fields.Item("U_FechadeCreacion").Value = oTransGT.UserFields.Fields.Item("U_FechadeCreacion").Value
                            oTransMX.UserFields.Fields.Item("U_FechaIntroduccion").Value = oTransGT.UserFields.Fields.Item("U_FechaIntroduccion").Value
                            oTransMX.UserFields.Fields.Item("U_Descrip1").Value = oTransGT.UserFields.Fields.Item("U_Descrip1").Value
                            oTransMX.UserFields.Fields.Item("U_Descrip2").Value = oTransGT.UserFields.Fields.Item("U_Descrip2").Value
                            oTransMX.UserFields.Fields.Item("U_DescripSenaliz").Value = oTransGT.UserFields.Fields.Item("U_DescripSenaliz").Value
                            oTransMX.UserFields.Fields.Item("U_DescripcionCorta").Value = oTransGT.UserFields.Fields.Item("U_DescripcionCorta").Value
                            oTransMX.UserFields.Fields.Item("U_DescripTicketCaja").Value = oTransGT.UserFields.Fields.Item("U_DescripTicketCaja").Value
                            If oTransGT.UserFields.Fields.Item("U_Descontinuado").Value = "" Then
                                oTransMX.UserFields.Fields.Item("U_Descontinuado").Value = "S"
                            End If
                            oTransMX.UserFields.Fields.Item("U_MostrarEnCatalogo").Value = oTransGT.UserFields.Fields.Item("U_MostrarEnCatalogo").Value
                            oTransMX.UserFields.Fields.Item("U_EmpaqueVta").Value = oTransGT.UserFields.Fields.Item("U_EmpaqueVta").Value

                            Dim oResultado As Integer
                            oResultado = oTransMX.Add()

                            If (oResultado = 0) Then
                                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                                oCompanyMX.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)

                            Else
                                MsgBox(oCompanyMX.GetLastErrorDescription())
                                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                                oCompanyMX.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)

                            End If

                        End If
                    End If
#End Region

#End Region

                Next
                'Al Finalizar la Operacion
                pSplash.SetWaitFormCaption("Operacion Finalizada")
                pSplash.SetWaitFormDescription("Articulos Sincronizados con exito.")
                Return True
            Catch ex As Exception
                If oCompanyGT.InTransaction = True Then
                    oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                End If
                If oCompanyES.InTransaction = True Then
                    oCompanyES.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                End If
                If oCompanyCR.InTransaction = True Then
                    oCompanyCR.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                End If
                If oCompanyMX.InTransaction = True Then
                    oCompanyMX.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                End If
                Return False
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            DesconectarDIAPIGT()
            DesconectarDIAPISV()
            DesconectarDIAPICR()
            DesconectarDIAPI_MX()
            If pSplash.IsSplashFormVisible Then : pSplash.CloseWaitForm() : End If
        End Try
    End Function
    Public Function SAP_DIAPI_ActualizarListaPrecios_Costos(ByVal dtEncabezado As DataTable, ByVal pSplash As DevExpress.XtraSplashScreen.SplashScreenManager) As Boolean

        Try


            For I = 0 To dtEncabezado.Rows.Count - 1
                If dtEncabezado.Rows(I)("Actualizar").ToString = "SI" Then


                    Dim pCodigoArticulo As String = dtEncabezado(I)("CodigoArticulo").ToString
                    Dim pPrecioCosto As String = dtEncabezado(I)("CostoTotal")
                    SAP_DIAPI_ActualizarListaPrecios_Costos(pCodigoArticulo, pPrecioCosto, pSplash)

                    ''ESTA PARTE DE CODIGO ES SOLO UNA PRUEBA EJPEREZ 2019-08-22
                    ''ACTUALIZACION DE LISTA DE MATERIALES
                    ''HACER ACTUALIZACION EN LA BASE DE DATOS
                    'pSplash.SetWaitFormDescription("Actualizando Lista Materiales...")
                    'mDIAPI.SAP_DIAPI_ListaMateriales_Actualizar(dtEncabezado(I)("CodigoArticulo").ToString)
                    ''FINALIZA ACTUALIZACION DE LISTA DE MATERIALES
                    ''ESTA PARTE DE CODIGO ES SOLO UNA PRUEBA EJPEREZ 2019-08-22



                    If Not (oCompanyGT.Connected) Then
                        If ConectarDIAPIGT() = False Then
                            Throw New Exception("Debe conectarse a sap!")
                        End If
                    End If


                    oCompanyGT.StartTransaction() 'INICIAR la Transaccion
                    Dim oTrans As SAPbobsCOM.Items 'CREAR un objeto tipo producto
                    oTrans = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems) 'INSTANCIAR la variable

                    'Splash --------------------------------------------------------------
                    pSplash.SetWaitFormCaption(dtEncabezado(I)("CodigoArticulo").ToString)
                    pSplash.SetWaitFormDescription("Actualizando Costo...")
                    'Splash --------------------------------------------------------------


                    oTrans.Valid = SAPbobsCOM.BoYesNoEnum.tYES 'Este campo es obligatorio que este en "Yes" para poder actualizar el Item
                    oTrans.GetByKey(dtEncabezado(I)("CodigoArticulo").ToString)
                    oTrans.PriceList.SetCurrentLine(0)
                    oTrans.PriceList.Price = dtEncabezado(I)("CostoTotal")

                    Dim oResultado As Integer
                    oResultado = oTrans.Update()
                    If (oResultado = 0) Then
                        oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)  'CONFIRMAR LA TRANSACCION

                        'SE AISLÓ DEL PROCEDIMIENTO NORMAL 
                        ''ACTUALIZACION DE LISTA DE MATERIALES EN BASE DE DATOS ---------------------------------
                        'pSplash.SetWaitFormDescription("Actualizando Lista Materiales...") ' SPLASH ------------
                        'mDIAPI.SAP_DIAPI_ListaMateriales_Actualizar(dtEncabezado(I)("CodigoArticulo").ToString)
                        ''FINALIZA ACTUALIZACION DE LISTA DE MATERIALES
                    Else
                        MsgBox(oCompanyGT.GetLastErrorDescription())
                        oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                        Return False
                    End If
                End If




            Next

            Return True

        Catch ex As Exception
            oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
            MsgBox(ex.Message)
            Return False
        Finally
            DesconectarDIAPIGT()
        End Try

    End Function
    Public Function SAP_DIAPI_ActualizarListaPrecios_Costos(ByVal pCodigoArticulo As String, ByVal pPrecioCosto As String, ByVal pSplash As DevExpress.XtraSplashScreen.SplashScreenManager) As Boolean
        Try
            pSplash.SetWaitFormCaption("Conectando a DB...")
            pSplash.SetWaitFormDescription("Guatemala")


            If Not (oCompanyGT.Connected) Then
                If ConectarDIAPIGT() = False Then
                    Throw New Exception("Debe conectarse a sap!")
                End If
            End If


            oCompanyGT.StartTransaction() 'INICIAR la Transaccion
            Dim oTrans As SAPbobsCOM.Items 'CREAR un objeto tipo producto
            oTrans = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems) 'INSTANCIAR el objeto

            'Splash-------------------------------------------------
            pSplash.SetWaitFormCaption(pCodigoArticulo.ToString)
            pSplash.SetWaitFormDescription("Actualizando Costo...")

            'ENCABEZADO
            oTrans.Valid = SAPbobsCOM.BoYesNoEnum.tYES 'Este campo es obligatorio que este en "Yes" para poder actualizar el Item
            oTrans.GetByKey(pCodigoArticulo)
            oTrans.PriceList.SetCurrentLine(0)
            oTrans.PriceList.Price = pPrecioCosto

            'CREAR LA ACTUALIZACION
            Dim oResultado As Integer
            oResultado = oTrans.Update()
            If (oResultado = 0) Then
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)    'CONFIRMAR LA TRANSACCIÓN
            Else
                MsgBox(oCompanyGT.GetLastErrorDescription())
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)  'RECHAZAR LA TRANSACCIÓN
                Return False
            End If
            Return True
        Catch ex As Exception
            oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack) 'RECHAZAR LA TRANSACCION SI HAY UN ERROR
            MsgBox(ex.Message)
            Return False
        Finally
            DesconectarDIAPIGT()
        End Try
    End Function
End Module
