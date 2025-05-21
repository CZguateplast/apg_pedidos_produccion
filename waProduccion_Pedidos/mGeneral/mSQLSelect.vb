Imports System.Text

Module mSQLSelect

    Public Function GetIPv4Address() As String
        GetIPv4Address = String.Empty
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

        For Each ipheal As System.Net.IPAddress In iphe.AddressList
            If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                GetIPv4Address = ipheal.ToString()
            End If
        Next
    End Function

    Public Function GET_Pilotos(ByRef oCantidad As Integer) As Integer
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulosRelacionados")

        Try
            qry = "  SELECT count(Id)[Pilotos] FROM Ventas.dbo.EXP_Cat_Pilotos"
            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            oCantidad = dt.Rows(0)(0)
            Return oCantidad

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Usuario(ByVal pFirma As String) As DataTable
        Dim dt As New DataTable("dtBodegasMoldes")
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT * ")
            qry.Append(" from APGS.dbo.SEG_Usuarios ")
            qry.Append(" where UsuarioId = '" + pFirma + "' ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_SEG_Catalogos(ByVal pTipo As String, ByVal pValor As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT * ")
            qry.Append(" FROM APGS.dbo.SEG_Catalogos ")
            qry.Append(" WHERE Tipo = '" + pTipo + "' ")
            qry.Append(" AND Valor = '" + pValor + "'")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function



    Public Function GET_OrdenesProduccion_Temporal() As DataTable
        Dim dt As New DataTable("dtBodegasMoldes")
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" Id, ")
            qry.Append(" Id_Nivel1, ")
            qry.Append(" Id_Nivel2, ")
            qry.Append(" Tipo, ")
            qry.Append(" Prioridad, ")
            qry.Append(" NumeroSAP, ")
            qry.Append(" CodigoArticulo, ")
            qry.Append(" Unidades, ")
            qry.Append(" Origen, ")
            qry.Append(" Destino, ")
            qry.Append(" Color, ")
            qry.Append(" GrupoCliente, ")
            qry.Append(" CodigoCliente, ")
            qry.Append(" NumeroOrden, ")
            qry.Append(" NumeroCampana, ")
            qry.Append(" Entrega, ")
            qry.Append(" Comentario_Nivel1, ")
            qry.Append(" Comentario_Nivel2, ")
            qry.Append(" SAP, ")
            qry.Append(" Estatus, ")
            qry.Append(" Bit_UsuarioCreacion, ")
            qry.Append(" Bit_FechaCreacion, ")
            qry.Append(" Bit_UsuarioModificacion, ")
            qry.Append(" Bit_FechaModificacion ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle_Temporal ")
            qry.Append(" WHERE Bit_UsuarioCreacion = '" + My.Settings.log_Usuario.ToString + "' ")
            qry.Append(" ORDER BY Id,Id_Nivel1 ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Pilotos(ByRef oRow As DataTable) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulosRelacionados")

        Try
            qry = "  SELECT * FROM Ventas.dbo.EXP_Cat_Pilotos"
            oRow = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return oRow

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Stock_XArticulo(ByVal pCodigoArticulo As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtStockDetalle")

        Try
            qry = "  SELECT"
            qry += " UPPER(C.ItemCode) [CodigoArticulo],"
            qry += " UPPER(C.ItemName) [NombreArticulo],"

            qry += " CASE "
            qry += " WHEN C.U_NoDeLinea = 0 THEN 'SI'"
            qry += " WHEN C.U_NoDeLinea = 1 THEN 'NO' "
            qry += " END [DeLinea],"

            qry += " UPPER(B.WhsCode) [Bodega], "
            qry += " CONVERT(INTEGER, A.OnHand) [Stock]"
            qry += " FROM SBOGuateplast.dbo.OITW A "
            qry += " LEFT JOIN SBOGUATEPLAST.DBO.OWHS B ON B.WhsCode = A.WhsCode "
            qry += " LEFT JOIN SBOGuateplast.dbo.OITM C ON C.ItemCode = A.ItemCode"
            qry += " WHERE A.ItemCode = " + pCodigoArticulo + " "
            qry += " AND A.OnHand <> '0'"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Articulo(ByVal pCodigoArticulo As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulo")

        Try
            qry = " SELECT "
            qry += " UPPER(ItemCode) [CodigoArticulo],"
            qry += " UPPER(ItemName) [NombreArticulo],"
            qry += " InvntryUom [UM],"
            qry += " UPPER(CodeBars) [CodigoBarras],"
            qry += " CASE"
            qry += " WHEN U_NoDeLinea = 0 THEN 'SI'"
            qry += " WHEN U_NoDeLinea = 1 THEN 'NO' "
            qry += " END [DeLinea]"
            qry += " FROM SBOGuateplast.dbo.OITM"
            qry += " WHERE ItemCode = " + pCodigoArticulo + ""

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_FORMATO_ControlProduccionRecibos() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT TOP 0")
            qry.Append(" A.DocNum [SAP], ")
            qry.Append(" CONVERT(INTEGER,'') [Cargar], ")
            qry.Append(" A.Comments [Comentarios] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A  ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Recibos_ControlProduccion(ByVal pNumerosSAP As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" A.DocNum [SAP], ")
            qry.Append(" CASE  ")
            qry.Append(" WHEN A.Status = 'R' THEN 'Liberado'  ")
            qry.Append(" WHEN A.Status = 'P' THEN 'Planeado' 	 ")
            qry.Append(" WHEN A.Status = 'L' THEN 'Close'  ")
            qry.Append(" END [Estado], ")
            qry.Append(" A.Warehouse [Bodega], ")
            qry.Append(" A.ItemCode [CodigoArticulo],  ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" CONVERT(INTEGER,B.OnHand) [Stock], ")
            qry.Append(" CONVERT(INTEGER,B.IsCommited) [Comprometido], ")
            qry.Append(" CONVERT(INTEGER,A.PlannedQty) [Planeado], ")
            qry.Append(" CONVERT(INTEGER,A.CmpltQty) [Completado],  ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (A.PlannedQty - A.CmpltQty) > 0 THEN (A.PlannedQty - A.CmpltQty) ELSE '0' END) [Pendiente], ")
            qry.Append(" CONVERT(INTEGER,'') [Cargar], ")
            qry.Append(" A.Comments [Comentarios] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A  ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.DocNum in (" + pNumerosSAP + ") ")
            qry.Append(" AND Status IN ('R','P') ")
            qry.Append(" ORDER BY CodigoArticulo ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_OrdenesProduccionEnsamble_Aplicar(ByVal pCodigoArticulo As String, ByVal pTipo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" A.DocNum [SAP], ")
            qry.Append(" CASE  ")
            qry.Append(" WHEN A.Status = 'R' THEN 'Liberado'  ")
            qry.Append(" WHEN A.Status = 'P' THEN 'Planeado' 	 ")
            qry.Append(" WHEN A.Status = 'L' THEN 'Close'  ")
            qry.Append(" END [Estado], ")
            qry.Append(" A.Warehouse [Bodega], ")
            qry.Append(" A.ItemCode [CodigoArticulo],  ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" CONVERT(INTEGER,B.OnHand) [Stock], ")
            qry.Append(" CONVERT(INTEGER,B.IsCommited) [Comprometido], ")
            qry.Append(" CONVERT(INTEGER,A.PlannedQty) [Planeado], ")
            qry.Append(" CONVERT(INTEGER,A.CmpltQty) [Completado],  ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (A.PlannedQty - A.CmpltQty) > 0 THEN (A.PlannedQty - A.CmpltQty) ELSE '0' END) [Pendiente], ")
            qry.Append(" CONVERT(INTEGER,'') [Cargar], ")
            qry.Append(" A.Comments [Comentarios] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A  ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.ItemCode LIKE ('" + pCodigoArticulo + "%')   ")
            qry.Append(" AND Type = '" + pTipo + "' ")
            qry.Append(" AND Status IN ('R','P') ")
            qry.Append(" ORDER BY CodigoArticulo ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_OrdenesProduccionEnsamble_PendienteAplicar(ByVal pTipo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" A.DocNum [SAP], ")
            qry.Append(" CASE  ")
            qry.Append(" WHEN A.Status = 'R' THEN 'Liberado'  ")
            qry.Append(" WHEN A.Status = 'P' THEN 'Planeado' 	 ")
            qry.Append(" WHEN A.Status = 'L' THEN 'Close'  ")
            qry.Append(" END [Estado], ")
            qry.Append(" A.Warehouse [Bodega], ")
            qry.Append(" A.ItemCode [CodigoArticulo],  ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" CONVERT(INTEGER,A.PlannedQty) [Planeado], ")
            qry.Append(" CONVERT(INTEGER,A.CmpltQty) [Completado],  ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (A.PlannedQty - A.CmpltQty) > 0 THEN (A.PlannedQty - A.CmpltQty) ELSE '0' END) [Pendiente], ")
            qry.Append(" CONVERT(INTEGER,'') [Cargar], ")
            qry.Append(" A.Comments [Comentarios] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A  ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" AND Type = '" + pTipo + "' ")
            qry.Append(" WHERE Status IN ('R','P') ")
            qry.Append(" ORDER BY CodigoArticulo ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_OrdenesProduccionEnsamble_PendientesAplicar(ByVal pNumSapExcepciones As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" A.DocNum [SAP], ")
            qry.Append(" CASE  ")
            qry.Append(" WHEN A.Status = 'R' THEN 'Liberado'  ")
            qry.Append(" WHEN A.Status = 'P' THEN 'Planeado' 	 ")
            qry.Append(" WHEN A.Status = 'L' THEN 'Close'  ")
            qry.Append(" END [Estado], ")
            qry.Append(" A.Warehouse [Bodega], ")
            qry.Append(" A.ItemCode [CodigoArticulo],  ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" CONVERT(INTEGER,A.PlannedQty) [Planeado], ")
            qry.Append(" CONVERT(INTEGER,A.CmpltQty) [Completado],  ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (A.PlannedQty - A.CmpltQty) > 0 THEN (A.PlannedQty - A.CmpltQty) ELSE '0' END) [Pendiente], ")
            qry.Append(" CONVERT(INTEGER,'') [Cargar], ")
            qry.Append(" A.Comments [Comentarios] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A  ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" WHERE Status IN ('R','P') ")
            qry.Append(" AND A.DocNum NOT IN (" + pNumSapExcepciones + ") ")
            qry.Append(" ORDER BY CodigoArticulo ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_OrdenesProduccionEnsamble_Aplicar_NumSAP(ByVal pSAP As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" A.DocNum [SAP], ")
            qry.Append(" CASE  ")
            qry.Append(" WHEN A.Status = 'R' THEN 'Liberado'  ")
            qry.Append(" WHEN A.Status = 'P' THEN 'Planeado' 	 ")
            qry.Append(" WHEN A.Status = 'L' THEN 'Close'  ")
            qry.Append(" END [Estado], ")
            qry.Append(" A.Warehouse [Bodega], ")
            qry.Append(" A.ItemCode [CodigoArticulo],  ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" CONVERT(INTEGER,B.OnHand) [Stock], ")
            qry.Append(" CONVERT(INTEGER,B.IsCommited) [Comprometido], ")
            qry.Append(" CONVERT(INTEGER,A.PlannedQty) [Planeado], ")
            qry.Append(" CONVERT(INTEGER,A.CmpltQty) [Completado],  ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (A.PlannedQty - A.CmpltQty) > 0 THEN (A.PlannedQty - A.CmpltQty) ELSE '0' END) [Pendiente], ")
            qry.Append(" CONVERT(INTEGER,'') [Cargar], ")
            qry.Append(" A.Comments [Comentarios] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A  ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.DocNum = ('" + pSAP + "')   ")
            qry.Append(" AND Status IN ('R','P') ")
            qry.Append(" ORDER BY CodigoArticulo ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_Catalogo_AR_CP_Padres() As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulo")

        Try
            qry = " SELECT "
            qry += " UPPER(ItemCode) [CodigoArticulo],"
            qry += " UPPER(ItemName) [NombreArticulo],"
            qry += " UPPER(CodeBars) [CodigoBarras],"
            qry += " CASE"
            qry += " WHEN U_NoDeLinea = 0 THEN 'SI'"
            qry += " WHEN U_NoDeLinea = 1 THEN 'NO' "
            qry += " END [DeLinea]"
            qry += " FROM SBOGuateplast.dbo.OITM"
            qry += " WHERE (ItemCode like 'AR%' OR ItemCode like 'CP%')"
            qry += " AND LEN(ItemCode) = '8'"


            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_Catalogo_CC_Hijos() As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulo")

        Try
            qry = " SELECT "
            qry += " UPPER(ItemCode) [CodigoArticulo],"
            qry += " UPPER(ItemName) [NombreArticulo],"
            qry += " UPPER(CodeBars) [CodigoBarras],"
            qry += " CASE"
            qry += " WHEN U_NoDeLinea = 0 THEN 'SI'"
            qry += " WHEN U_NoDeLinea = 1 THEN 'NO' "
            qry += " END [DeLinea]"
            qry += " FROM SBOGuateplast.dbo.OITM"
            qry += " WHERE (ItemCode like 'CC%')"
            'qry += " AND LEN(ItemCode) > '8'"
            qry += " AND FrozenFor = 'N'"



            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Catalogo_AR_CP_CC_Padres() As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulo")

        Try
            qry = " SELECT "
            qry += " UPPER(ItemCode) [CodigoArticulo],"
            qry += " UPPER(ItemName) [NombreArticulo],"
            qry += " UPPER(CodeBars) [CodigoBarras],"
            qry += " CASE"
            qry += " WHEN U_NoDeLinea = 0 THEN 'SI'"
            qry += " WHEN U_NoDeLinea = 1 THEN 'NO' "
            qry += " END [DeLinea]"
            qry += " FROM SBOGuateplast.dbo.OITM"
            qry += " WHERE (ItemCode like 'AR%' OR ItemCode like 'CP%' OR ItemCode like 'CC%')"
            qry += " AND LEN(ItemCode) = '8'"


            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Catalogo_AR_CP_Hijos() As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulo")

        Try
            qry = " SELECT "
            qry += " UPPER(ItemCode) [CodigoArticulo],"
            qry += " UPPER(ItemName) [NombreArticulo],"
            qry += " UPPER(CodeBars) [CodigoBarras],"
            qry += " CASE"
            qry += " WHEN U_NoDeLinea = 0 THEN 'SI'"
            qry += " WHEN U_NoDeLinea = 1 THEN 'NO' "
            qry += " END [DeLinea]"
            qry += " FROM SBOGuateplast.dbo.OITM"
            qry += " WHERE (ItemCode like 'AR%' OR ItemCode like 'CP%')"
            qry += " AND LEN(ItemCode) > '8'"


            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Catalogo_Hijos(ByVal pCodigoPadre As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulo")

        Try
            qry = " SELECT "
            qry += " UPPER(ItemCode) [CodigoArticulo],"
            qry += " UPPER(ItemName) [NombreArticulo],"
            qry += " UPPER(CodeBars) [CodigoBarras],"
            qry += " CASE"
            qry += " WHEN U_NoDeLinea = 0 THEN 'SI'"
            qry += " WHEN U_NoDeLinea = 1 THEN 'NO' "
            qry += " END [DeLinea]"
            qry += " FROM SBOGuateplast.dbo.OITM"
            qry += " WHERE ItemCode like ('" + pCodigoPadre + "%')"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_ArticulosARconEx(ByVal pCodigoEx As String) As DataTable
        Try
            Dim qry As New StringBuilder
            If pCodigoEx = String.Empty Then
                pCodigoEx = "'AR'"
            End If

            qry.Append(" SELECT UPPER(ItemCode) [CodigoArticulo], ")
            qry.Append(" UPPER(ItemName) [NombreArticulo], ")
            qry.Append(" ISNULL(CodeBars,'')[CodigoBarras], ")
            qry.Append(" CASE WHEN U_NoDeLinea = '1' THEN 'NO' ")
            qry.Append(" WHEN U_NoDeLinea = '0' THEN 'SI' END [DeLinea] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM ")
            'qry.Append(" WHERE ItemCode LIKE ('AR%') AND LEN(ItemCode) > 8 AND ItemCode NOT IN (" + pCodigoEx + ")")    --PARA PODER INCLUIR CODIGOS PADRES
            qry.Append(" WHERE ItemCode LIKE ('AR%')  AND ItemCode NOT IN (" + pCodigoEx + ")")
            qry.Append(" ORDER BY ItemCode ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ArticulosAR(ByVal pCodigoArticulo As String) As DataTable

        pCodigoArticulo = LTrim(RTrim(pCodigoArticulo))

        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT A.ItemCode [CodigoArticulo], ")
            qry.Append(" A.ItemName [NombreArticulo], ")
            qry.Append(" CASE WHEN (B.ItemCode) IS NULL THEN 'NO'  ")
            qry.Append(" ELSE 'SI' END [El Salvador], ")
            qry.Append(" CASE WHEN (C.ItemCode) IS NULL THEN 'NO'  ")
            qry.Append(" ELSE 'SI' END [Costa Rica], ")
            qry.Append(" CASE WHEN (D.ItemCode) IS NULL THEN 'NO'  ")
            qry.Append(" ELSE 'SI' END [Mexico] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM A ")
            qry.Append(" LEFT JOIN ElSalvador.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" LEFT JOIN CR.dbo.OITM C ON C.ItemCode = A.ItemCode ")
            qry.Append(" LEFT JOIN SBO_MX.dbo.OITM D ON D.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.ItemCode in (" + pCodigoArticulo + ") ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ArticulosAR_ElSalvador() As DataTable

        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT A.ItemCode [CodigoArticulo], ")
            qry.Append(" A.ItemName [NombreArticulo], ")
            qry.Append(" CASE WHEN (B.ItemCode) IS NULL THEN 'NO'  ")
            qry.Append(" ELSE 'SI' END [El Salvador], ")
            qry.Append(" CASE WHEN (C.ItemCode) IS NULL THEN 'NO'  ")
            qry.Append(" ELSE 'SI' END [Costa Rica], ")
            qry.Append(" CASE WHEN (D.ItemCode) IS NULL THEN 'NO'  ")
            qry.Append(" ELSE 'SI' END [Mexico] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM A ")
            qry.Append(" LEFT JOIN ElSalvador.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" LEFT JOIN CR.dbo.OITM C ON C.ItemCode = A.ItemCode ")
            qry.Append(" LEFT JOIN SBO_MX.dbo.OITM D ON D.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.ItemCode in ( ")
            qry.Append(" ItemCode [CodigoArticulo] ")
            qry.Append(" FROM ElSalvador.dbo.OITM ")
            qry.Append(" WHERE ItemCode LIKE ('AR%') ")
            qry.Append(" AND LEN(ItemCode) > 8 ")
            qry.Append(" ) ORDER BY A.ItemCode ASC ")
            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ArticulosAR_CostaRica() As DataTable

        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT A.ItemCode [CodigoArticulo], ")
            qry.Append(" A.ItemName [NombreArticulo], ")
            qry.Append(" CASE WHEN (B.ItemCode) IS NULL THEN 'NO'  ")
            qry.Append(" ELSE 'SI' END [El Salvador], ")
            qry.Append(" CASE WHEN (C.ItemCode) IS NULL THEN 'NO'  ")
            qry.Append(" ELSE 'SI' END [Costa Rica], ")
            qry.Append(" CASE WHEN (D.ItemCode) IS NULL THEN 'NO'  ")
            qry.Append(" ELSE 'SI' END [Mexico] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM A ")
            qry.Append(" LEFT JOIN ElSalvador.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" LEFT JOIN CR.dbo.OITM C ON C.ItemCode = A.ItemCode ")
            qry.Append(" LEFT JOIN SBO_MX.dbo.OITM D ON D.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.ItemCode in ( ")
            qry.Append(" SELECT ")
            qry.Append(" ItemCode [CodigoArticulo] ")
            qry.Append(" FROM CR.dbo.OITM ")
            qry.Append(" WHERE ItemCode LIKE ('AR%') ")
            qry.Append(" AND LEN(ItemCode) > 8 ")
            qry.Append(" ) ORDER BY A.ItemCode ASC ")
            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    'MOD 06/02/2024

    Public Function GET_ArticulosAR_Mexico() As DataTable

        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT A.ItemCode [CodigoArticulo], ")
            qry.Append(" A.ItemName [NombreArticulo], ")
            qry.Append(" CASE WHEN (B.ItemCode) IS NULL THEN 'NO'  ")
            qry.Append(" ELSE 'SI' END [El Salvador], ")
            qry.Append(" CASE WHEN (C.ItemCode) IS NULL THEN 'NO'  ")
            qry.Append(" ELSE 'SI' END [Costa Rica], ")
            qry.Append(" CASE WHEN (D.ItemCode) IS NULL THEN 'NO'  ")
            qry.Append(" ELSE 'SI' END [Mexico] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM A ")
            qry.Append(" LEFT JOIN ElSalvador.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" LEFT JOIN CR.dbo.OITM C ON C.ItemCode = A.ItemCode ")
            qry.Append(" LEFT JOIN SBO_MX.dbo.OITM D ON D.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.ItemCode in ( ")
            qry.Append(" SELECT ")
            qry.Append(" ItemCode [CodigoArticulo] ")
            qry.Append(" FROM SBO_MX.dbo.OITM ")
            qry.Append(" WHERE ItemCode LIKE ('AR%') ")
            qry.Append(" AND LEN(ItemCode) > 8 ")
            qry.Append(" ) ORDER BY A.ItemCode ASC ")
            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ArticulosARGrupo(ByVal pGrupo As String) As DataTable

        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT A.ItemCode [CodigoArticulo], ")
            qry.Append(" A.ItemName [NombreArticulo],  ")
            qry.Append(" CASE WHEN (B.ItemCode) IS NULL THEN 'NO'   ")
            qry.Append(" ELSE 'SI' END [El Salvador],  ")
            qry.Append(" CASE WHEN (C.ItemCode) IS NULL THEN 'NO'   ")
            qry.Append(" ELSE 'SI' END [Costa Rica],  ")
            qry.Append(" CASE WHEN (D.ItemCode) IS NULL THEN 'NO'  ")
            qry.Append(" ELSE 'SI' END [Mexico] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM A  ")
            qry.Append(" LEFT JOIN ElSalvador.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" LEFT JOIN CR.dbo.OITM C ON C.ItemCode = A.ItemCode ")
            qry.Append(" LEFT JOIN SBO_MX.dbo.OITM D ON D.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.ItemCode LIKE ('AR%')  ")
            qry.Append(" AND LEN(A.ItemCode) > 8  ")
            qry.Append(" AND  A.ItmsGrpCod in ('" + pGrupo + "') ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Catalogo_GrupoArticulos() As DataTable

        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" ItmsGrpCod [Id], ")
            qry.Append(" UPPER(ItmsGrpNam) [Nombre] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITB ")
            qry.Append(" ORDER BY ItmsGrpNam ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_ProduccionPlaneada_XArticulo(ByVal pCodigoArticulo As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtStockDetalle")

        Try
            qry = "  SELECT"
            qry += " DocEntry [NumOrden],"
            qry += " CONVERT(DATE,PostDate,111) [Fecha],"
            qry += " ItemCode [CodigoArticulo],"
            qry += " CONVERT(INTEGER,PlannedQty) [Planeado],"
            qry += " CONVERT(INTEGER,CmpltQty) [Completado],"
            qry += " CONVERT(INTEGER,(PlannedQty - CmpltQty)) [Diferencia],"
            qry += " UPPER(Comments) [Comentarios]"
            qry += " FROM SBOGuateplast.dbo.OWOR"
            qry += " WHERE ItemCode = " + pCodigoArticulo + ""
            qry += " AND Status IN ('P')"
            qry += " AND U_Tipo IN ('0')"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_ProduccionLiberada_XArticulo(ByVal pCodigoArticulo As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtStockDetalle")

        Try
            qry = "  SELECT"
            qry += " DocEntry [NumOrden],"
            qry += " CONVERT(DATE,PostDate,111) [Fecha],"
            qry += " ItemCode [CodigoArticulo],"
            qry += " CONVERT(INTEGER,PlannedQty) [Planeado],"
            qry += " CONVERT(INTEGER,CmpltQty) [Completado],"
            qry += " CONVERT(INTEGER,(PlannedQty - CmpltQty)) [Diferencia],"
            qry += " UPPER(Comments) [Comentarios]"
            qry += " FROM SBOGuateplast.dbo.OWOR"
            qry += " WHERE ItemCode = " + pCodigoArticulo + ""
            qry += " AND Status IN ('R')"
            qry += " AND U_Tipo IN ('0')"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_EnsamblePlaneado_XArticulo(ByVal pCodigoArticulo As String, ByVal pOrigenes As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtEnsamblePlaneado")

        Try
            qry = "  SELECT"
            qry += " DocEntry [NumOrden],"
            qry += " CONVERT(DATE,PostDate,111) [Fecha],"
            qry += " ItemCode [CodigoArticulo],"
            qry += " CONVERT(INTEGER,PlannedQty) [Planeado],"
            qry += " CONVERT(INTEGER,CmpltQty) [Completado],"
            qry += " CONVERT(INTEGER,(PlannedQty - CmpltQty)) [Diferencia],"
            qry += " CASE"
            qry += " WHEN U_Tipo = '1' THEN 'ENSAMBLE'"
            qry += " WHEN U_Tipo = '2' THEN 'IMPRENTA'"
            qry += " WHEN U_Tipo = '3' THEN 'PEINES'"
            qry += " WHEN U_Tipo = '4' THEN 'PRADERA'"
            qry += " END [Destino],"
            qry += " UPPER(Comments) [Comentarios]"
            qry += " FROM SBOGuateplast.dbo.OWOR"
            qry += " WHERE ItemCode = " + pCodigoArticulo + ""
            qry += " AND Status IN ('P')"
            qry += " AND U_Tipo IN (" + pOrigenes + ")"
            qry += " ORDER BY Destino ASC, Fecha DESC"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_EnsambleLiberado_XArticulo(ByVal pCodigoArticulo As String, ByVal pOrigenes As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtEnsambleLiberado")

        Try
            qry = "  SELECT"
            qry += " DocEntry [NumOrden],"
            qry += " CONVERT(DATE,PostDate,111) [Fecha],"
            qry += " ItemCode [CodigoArticulo],"
            qry += " CONVERT(INTEGER,PlannedQty) [Planeado],"
            qry += " CONVERT(INTEGER,CmpltQty) [Completado],"
            qry += " CONVERT(INTEGER,(PlannedQty - CmpltQty)) [Diferencia],"
            qry += " CASE"
            qry += " WHEN U_Tipo = '1' THEN 'ENSAMBLE'"
            qry += " WHEN U_Tipo = '2' THEN 'IMPRENTA'"
            qry += " WHEN U_Tipo = '3' THEN 'PEINES'"
            qry += " WHEN U_Tipo = '4' THEN 'PRADERA'"
            qry += " END [Destino],"
            qry += " UPPER(Comments) [Comentarios]"
            qry += " FROM SBOGuateplast.dbo.OWOR"
            qry += " WHERE ItemCode = " + pCodigoArticulo + ""
            qry += " AND Status IN ('R')"
            qry += " AND U_Tipo IN (" + pOrigenes + ")"
            qry += " ORDER BY Destino ASC, Fecha DESC"


            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_EnsambleLiberado01234_XArticulo(ByVal pCodigoArticulo As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtEnsambleLiberado")

        Try
            qry = "  SELECT"
            qry += " DocEntry [NumOrden],"
            qry += " CONVERT(DATE,PostDate,111) [Fecha],"
            qry += " ItemCode [CodigoArticulo],"
            qry += " CONVERT(INTEGER,PlannedQty) [Planeado],"
            qry += " CONVERT(INTEGER,CmpltQty) [Completado],"
            qry += " CONVERT(INTEGER,(PlannedQty - CmpltQty)) [Diferencia],"
            qry += " CASE"
            qry += " WHEN U_Tipo = '1' THEN 'ENSAMBLE'"
            qry += " WHEN U_Tipo = '2' THEN 'IMPRENTA'"
            qry += " WHEN U_Tipo = '3' THEN 'PEINES'"
            qry += " WHEN U_Tipo = '4' THEN 'PRADERA'"
            qry += " END [Destino],"
            qry += " UPPER(Comments) [Comentarios]"
            qry += " FROM SBOGuateplast.dbo.OWOR"
            qry += " WHERE ItemCode = " + pCodigoArticulo + ""
            qry += " AND Status IN ('R')"
            qry += " AND U_Tipo IN ('1','2','3','4')"
            qry += " ORDER BY Destino ASC, Fecha DESC"


            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_DeudaRol_XArticulo(ByVal pCodigoArticulo As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtEnsamblePlaneado")

        Try
            qry = "  SELECT"

            qry += " B.DocNum [NumOrden],"

            qry += " convert(DATE,B.DocDate,111) [Fecha],"
            qry += " convert(DATE,B.DocDueDate,111) [Entrega],"
            qry += " B.CardCode [Codigo Cliente],"
            qry += " UPPER(B.CardName) [Nombre Cliente],"
            qry += " CONVERT(INTEGER,A.Quantity) [Solicitado],"
            qry += " CONVERT(INTEGER,A.DelivrdQty) [Facturado],"
            qry += " CONVERT(INTEGER,A.OpenCreQty) [Pendiente],"
            qry += " A.Currency [Moneda],"
            qry += " CONVERT(DECIMAL(18,2),A.LineTotal) [Valor],"
            qry += " UPPER(B.Comments) [Comentarios]"
            qry += " FROM SBOGuateplast.dbo.RDR1 A"
            qry += " LEFT JOIN SBOGuateplast.dbo.ORDR B ON B.DocEntry = A.DocEntry"
            qry += " WHERE ItemCode = " + pCodigoArticulo + ""
            qry += " AND A.LineStatus = 'O'"
            qry += " AND B.DocStatus = 'O'"
            qry += " AND CANCELED = 'N'"
            qry += " AND (B.U_NameCamp IS NULL OR B.U_NameCamp = '')"


            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_DeudaProyeccion_XArticulo(ByVal pCodigoArticulo As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtDeudaProyeccion")

        Try
            qry = "  SELECT"

            qry += " Id,"
            qry += " NombreCampana,"
            qry += " Proyectado,"
            qry += " Facturado,"
            qry += " CASE "
            qry += " WHEN Proyectado > Facturado THEN Proyectado - Facturado "
            qry += " ELSE 0 "
            qry += " END [Diferencia],"
            qry += " FechaEntrega,"
            qry += " FechaInicio,"
            qry += " FechaFinal"
            qry += " FROM"
            qry += " (SELECT "
            qry += " B.Id [Id],"
            qry += " B.NombreCampana [NombreCampana],"
            qry += " CONVERT(INTEGER,ISNULL(A2.Proyectado,0)) [Proyectado],"
            qry += " (SELECT "
            qry += " ISNULL(CONVERT(INTEGER,SUM(A1.Quantity)),0) [Facturado]"
            qry += " FROM SBOGuateplast.dbo.INV1 A1"
            qry += " LEFT JOIN SBOGuateplast.dbo.OINV B1 ON B1.DocEntry = A1.DocEntry"
            qry += " WHERE A1.BaseEntry IN "
            qry += " (SELECT DISTINCT AA.DocEntry"
            qry += " FROM SBOGuateplast.dbo.DLN1 AA"
            qry += " WHERE AA.BaseEntry IN "
            qry += " (SELECT DISTINCT AAA.DocEntry"
            qry += " FROM SBOGuateplast.dbo.ORDR AAA"
            qry += " LEFT JOIN SBOGuateplast.dbo.RDR1 BBB ON BBB.DocEntry = AAA.DocEntry"
            qry += " WHERE AAA.U_NameCamp COLLATE SQL_Latin1_General_CP850_CI_AS = B.Id"
            qry += " AND BBB.ItemCode = " + pCodigoArticulo + ""
            qry += " AND AAA.CANCELED = 'N')"
            qry += " AND AA.ItemCode = " + pCodigoArticulo + ""
            qry += " AND AA.TargetType <> '16')"
            qry += " AND A1.ItemCode = " + pCodigoArticulo + ""
            qry += " AND A1.TargetType <> '14') [Facturado],"
            qry += " CONVERT(DATE,B.FechaEntrega) [FechaEntrega],"
            qry += " CONVERT(DATE,b.FechaInicio) [FechaInicio],"
            qry += " Convert(DATE,B.FechaFinal) [FechaFinal]"
            qry += " FROM Ventas.dbo.CAM_Detalle A2"
            qry += " LEFT JOIN Ventas.dbo.CAM_Encabezado B ON B.Id = A2.Id "
            qry += " LEFT JOIN ("
            qry += " SELECT "
            qry += " AA.U_nameCamp,"
            qry += " BB.ItemCode,"
            qry += " Sum(BB.Quantity) [Quantity]"
            qry += " FROM"
            qry += " SBOGuateplast.dbo.OINV AA"
            qry += " LEFT JOIN SBOGuateplast.dbo.INV1 BB ON BB.DocEntry = AA.DocEntry"
            qry += " WHERE BB.ItemCode = " + pCodigoArticulo + ""
            qry += " AND U_NameCamp COLLATE SQL_Latin1_General_CP850_CI_AS "
            qry += " IN("
            qry += " SELECT "
            qry += " AAA.Id"
            qry += " FROM Ventas.dbo.CAM_Encabezado AAA"
            qry += " WHERE AAA.FechaFinal > GETDATE()"
            qry += " AND AAA.Distribuidor = 'False'"
            qry += " AND LEN(AAA.Id) < 8"
            qry += " )"
            qry += " AND AA.DocStatus = 'O'"
            qry += " AND BB.InvntSttus = 'O'"
            qry += " AND AA.CANCELED = 'N'"
            qry += " GROUP BY AA.U_NameCamp,BB.ItemCode) C ON C.U_NameCamp = B.Id COLLATE SQL_Latin1_General_CP850_CI_AS "
            qry += " WHERE A2.CodigoArticulo = " + pCodigoArticulo + ""
            qry += " AND B.Distribuidor = 'False'"
            qry += " AND LEN(A2.Id) < 8"
            qry += " AND B.FechaFinal > GETDATE()"
            qry += " ) [Qry1]"



            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_DeudaCampana_XArticulo(ByVal pCodigoArticulo As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtStockDetalle")

        Try
            qry = "  SELECT "
            qry += " A1.U_NameCamp [Id],"
            qry += " UPPER(c1.NombreCampana) [NombreCampana],"
            qry += " A1.DocNum [NumOrden],"
            qry += " a1.CardCode [CodigoCliente],"
            qry += " UPPER(a1.CardName) [NombreCliente],"
            qry += " CONVERT(INTEGER,B1.OpenQty) [Pendiente],"
            qry += " CONVERT(DATE,a1.DocDate,111) [Fecha],"
            qry += " CONVERT(DATE,a1.DocDueDate,111) [Entrega]"
            qry += " FROM SBOGuateplast.dbo.ORDR A1"
            qry += " LEFT JOIN SBOGuateplast.dbo.RDR1 B1 ON B1.DocEntry = A1.DocEntry "
            qry += " LEFT JOIN Ventas.dbo.CAM_Encabezado C1 ON C1.Id = A1.U_NameCamp COLLATE SQL_Latin1_General_CP850_CI_AS"
            qry += " WHERE B1.ItemCode = " + pCodigoArticulo + ""
            qry += " AND A1.CANCELED = 'N'"
            qry += " AND A1.DocStatus = 'O'"
            qry += " AND B1.OpenQty > '0'"
            qry += " AND A1.U_NameCamp <> ''"
            qry += " ORDER BY Id"


            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Ensamble_XArticulo(ByVal pCodigoArticulo As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtStockDetalle")

        Try
            qry = "      SELECT"
            qry += " DocEntry [NumDocumento],"
            qry += " PostDate [Fecha],"
            qry += " ItemCode [CodigoArticulo],"
            qry += " PlannedQty [Cantidad Planeada],"
            qry += " CmpltQty [Cantidad Completada],"
            qry += " (PlannedQty - CmpltQty) [Cantidad Pendiente]"
            qry += " FROM SBOGuateplast.dbo.OWOR"
            qry += " WHERE ItemCode = '" + pCodigoArticulo + "'"
            qry += " and Status in ('R','P')"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_AnalisisNecesidades(ByVal pDeLinea As String, ByVal pColor As String, ByVal pCodigoPadre As String,
                                            ByVal pCodigoPadreDel As String, ByVal pCodigoPadreAl As String, ByVal pTipoStock As String, ByVal pPorcStock As String,
                                            ByVal pStockMenorA As String, ByVal pStockMayorA As String,
                                            ByVal pCampana As String, ByVal pCliente As String,
                                            ByVal pDeudaRol As String, ByVal pDeudaCampana As String, ByVal pDeudaProyeccion As String, ByVal pDeudaEnsamble As String) As DataTable

        Dim qry As New StringBuilder
        Dim dt As New DataTable("dtStockDetalle")

        Try
            'qry.Append(" SELECT ")
            'qry.Append(" DeLinea, ")
            'qry.Append(" CodigoArticulo, ")
            'qry.Append(" NombreArticulo, ")
            'qry.Append(" Color, ")
            'qry.Append(" Stock, ")
            'qry.Append(" Produccion, ")
            'qry.Append(" Ensamble, ")
            'qry.Append(" TotalPositivo, ")
            'qry.Append(" Rol, ")
            'qry.Append(" Campana, ")
            'qry.Append(" Proyeccion, ")
            'qry.Append(" DeudaEnsamble, ")
            'qry.Append(" TotalNegativo, ")
            'qry.Append(" Disponible, ")
            'qry.Append(" Sugerido, ")
            'qry.Append(" StockMinimo, ")
            'qry.Append(" StockMaximo ")
            'qry.Append(" FROM( ")
            ''INICIO AGRUPADO
            'qry.Append(" SELECT  ")
            'qry.Append(" MAX(DeLinea)[DeLinea], ")
            'qry.Append(" CodigoArticulo, ")
            'qry.Append(" MAX(NombreArticulo) [NombreArticulo], ")
            'qry.Append(" MAX(Color) [Color], ")
            'qry.Append(" SUM(Stock)[Stock], ")
            'qry.Append(" SUM(Produccion)[Produccion], ")
            'qry.Append(" SUM(Ensamble)[Ensamble], ")
            'qry.Append(" SUM(Stock)+ SUM(Produccion) + SUM(Ensamble) [TotalPositivo], ")
            'qry.Append(" SUM(Rol) [Rol], ")
            'qry.Append(" SUM(Campana) [Campana], ")
            'qry.Append(" SUM(Proyeccion)[Proyeccion], ")
            'qry.Append(" SUM(DeudaEnsamble)[DeudaEnsamble], ")
            ''SUM(ROL) + SUM(Campana) + SUM(DeudaEnsamble) [TotalNegativo], ")
            'qry.Append(" CASE ")
            'qry.Append(" WHEN SUM(Campana) > SUM(Proyeccion) THEN ")
            'qry.Append(" SUM(ROL) + SUM(Campana) + SUM(DeudaEnsamble)  ")
            'qry.Append(" ELSE ")
            'qry.Append(" SUM(ROL) + SUM(Proyeccion) + SUM(DeudaEnsamble)  ")
            'qry.Append(" End ")
            'qry.Append(" [TotalNegativo], ")


            'qry.Append(" (SUM(Stock)+ SUM(Produccion) + SUM(Ensamble)) - (SUM(ROL) + SUM(Campana) + SUM(DeudaEnsamble)) [Disponible], ")
            'qry.Append(" CASE WHEN  ")
            'qry.Append(" SUM(StockMaximo) > 1 THEN ")
            'qry.Append(" SUM(StockMaximo) - ((SUM(Stock)+ SUM(Produccion) + SUM(Ensamble)) - (SUM(ROL) + SUM(Campana) + SUM(Proyeccion) + SUM(DeudaEnsamble))) ELSE '0' END [Sugerido], ")
            'qry.Append(" SUM(StockMinimo) [StockMinimo], ")
            'qry.Append(" SUM(StockMaximo)[StockMaximo] ")
            'qry.Append(" FROM ")
            ''INICIO UNION DE SELECT
            'qry.Append(" (SELECT  ")
            'qry.Append(" CASE  ")
            'qry.Append(" WHEN A1.U_NoDeLinea = '0' THEN 'SI' WHEN A1.U_NoDeLinea = '1' THEN 'NO' END [DeLinea],  ")
            'qry.Append(" UPPER(A1.ItemCode) [CodigoArticulo],  ")
            'qry.Append(" UPPER(A1.ItemName) [NombreArticulo],  ")
            'qry.Append(" UPPER(A1.U_Color) [Color],  ")
            'qry.Append(" CONVERT(INTEGER,ISNULL(A1.OnHand,0)) [Stock], ")
            'qry.Append(" CONVERT(INTEGER,A1.MinLevel) [StockMinimo],  ")
            'qry.Append(" CONVERT(INTEGER, A1.MaxLevel) [StockMaximo], ")
            'qry.Append(" '' [Produccion] , ")
            'qry.Append(" '' [Ensamble], ")
            'qry.Append(" '' [Rol], ")
            'qry.Append(" '' [Campana], ")
            'qry.Append(" '' [Proyeccion], ")
            'qry.Append(" '' [DeudaEnsamble]   ")
            'qry.Append(" FROM SBOGuateplast.dbo.OITM A1 WITH (NOLOCK, INDEX(OITM_PRIMARY)) ")
            'qry.Append(" WHERE A1.ItemCode LIKE ('AR%')  ")
            'qry.Append(" AND LEN(A1.ItemCode) > 8 ")

            'qry.Append(" UNION ALL ")

            ''PRODUCCIONES
            'qry.Append(" SELECT ")
            'qry.Append(" '' [DeLinea], ")
            'qry.Append(" A2.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            'qry.Append(" '' [NombreArticulo], ")
            'qry.Append(" '' [Color], ")
            'qry.Append(" '' [Stock], ")
            'qry.Append(" '' [StockMinimo], ")
            'qry.Append(" '' [StockMaximo], ")
            'qry.Append(" ISNULL(SUM( ")
            'qry.Append(" CASE WHEN PlannedQty > CmpltQty THEN  ")
            'qry.Append(" CONVERT(INTEGER,(PlannedQty - CmpltQty))  ")
            'qry.Append(" ELSE '0'  ")
            'qry.Append(" END),0) [Produccion], ")
            'qry.Append(" '' [Ensamble], ")
            'qry.Append(" '' [Rol], ")
            'qry.Append(" '' [Campana], ")
            'qry.Append(" '' [Proyeccion], ")
            'qry.Append(" '' [DeudaEnsamble]   ")
            'qry.Append(" FROM SBOGuateplast.dbo.OWOR A2 WITH (NOLOCK) ")
            'qry.Append(" WHERE A2.ItemCode LIKE ('AR%')  ")
            'qry.Append(" AND A2.Status IN ('P','R')  ")
            'qry.Append(" AND A2.U_Tipo IN ('0') ")
            'qry.Append(" GROUP BY A2.ItemCode ")

            'qry.Append(" UNION ALL ")
            ''ENSAMBLES
            'qry.Append(" SELECT ")
            'qry.Append(" '' [DeLinea], ")
            'qry.Append(" A2.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            'qry.Append(" '' [NombreArticulo], ")
            'qry.Append(" '' [Color], ")
            'qry.Append(" '' [Stock], ")
            'qry.Append(" '' [StockMinimo], ")
            'qry.Append(" '' [StockMaximo],  ")
            'qry.Append(" '' [Produccion], ")
            'qry.Append(" ISNULL(SUM( ")
            'qry.Append(" CASE WHEN PlannedQty > CmpltQty THEN  ")
            'qry.Append(" CONVERT(INTEGER,(PlannedQty - CmpltQty))  ")
            'qry.Append(" ELSE '0'  ")
            'qry.Append(" END),0) [Ensamble],  ")
            'qry.Append(" '' [Rol], ")
            'qry.Append(" '' [Campana], ")
            'qry.Append(" '' [Proyeccion], ")
            'qry.Append(" '' [DeudaEnsamble]     ")
            'qry.Append(" FROM SBOGuateplast.dbo.OWOR A2 WITH (NOLOCK) ")
            'qry.Append(" WHERE A2.ItemCode LIKE ('AR%')   ")
            'qry.Append(" AND A2.Status IN ('P','R')  ")
            'qry.Append(" AND A2.U_Tipo IN ('1','2','3','4') ")
            'qry.Append(" GROUP BY A2.ItemCode ")

            'qry.Append(" UNION ALL ")

            ''DEUDA ROL
            'qry.Append(" SELECT ")
            'qry.Append(" '' [DeLinea], ")
            'qry.Append(" b3.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            'qry.Append(" '' [NombreArticulo], ")
            'qry.Append(" '' [Color], ")
            'qry.Append(" '' [Stock], ")
            'qry.Append(" '' [StockMinimo], ")
            'qry.Append(" '' [StockMaximo],  ")
            'qry.Append(" '' [Produccion],   ")
            'qry.Append(" '' [Ensamble], ")
            'qry.Append(" ISNULL(CONVERT(INTEGER,SUM(B3.OpenQty)),0) [Rol],  ")
            'qry.Append(" '' [Campana], ")
            'qry.Append(" '' [Proyeccion], ")
            'qry.Append(" '' [DeudaEnsamble]  ")
            'qry.Append(" FROM SBOGuateplast.dbo.ORDR A3 WITH (NOLOCK, INDEX(ORDR_DOC_STATUS)) ")
            'qry.Append(" LEFT JOIN SBOGuateplast.dbo.RDR1 B3 WITH (NOLOCK, INDEX(RDR1_PRIMARY)) ON B3.DocEntry = A3.DocEntry   ")
            'qry.Append(" WHERE B3.LineStatus = 'O'  ")
            'qry.Append(" AND A3.DocStatus = 'O'  ")
            'qry.Append(" AND A3.CANCELED = 'N'  ")
            'qry.Append(" AND (A3.U_NameCamp IS NULL OR A3.U_NameCamp = '') ")
            'qry.Append(" GROUP BY B3.ItemCode ")

            'qry.Append(" UNION ALL ")


            'qry.Append(" SELECT ")
            ''DEUDA ROL
            'qry.Append(" '' [DeLinea], ")
            'qry.Append(" B.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            'qry.Append(" '' [NombreArticulo], ")
            'qry.Append(" '' [Color], ")
            'qry.Append(" '' [Stock], ")
            'qry.Append(" '' [StockMinimo], ")
            'qry.Append(" '' [StockMaximo],  ")
            'qry.Append(" '' [Produccion],   ")
            'qry.Append(" '' [Ensamble], ")
            'qry.Append(" CONVERT(INTEGER,SUM(B.OpenQty)) [Rol],  ")
            'qry.Append(" '' [Campana], ")
            'qry.Append(" '' [Proyeccion], ")
            'qry.Append(" '' [DeudaEnsamble]  ")
            'qry.Append(" FROM SBOGuateplast.dbo.OINV A WITH (NOLOCK, INDEX(OINV_STS_CNCL)) ")
            'qry.Append(" LEFT JOIN SBOGuateplast.DBO.INV1 B WITH (NOLOCK, INDEX(INV1_PRIMARY)) ON B.DocEntry = A.DocEntry ")
            'qry.Append(" WHERE A.isIns = 'Y' ")
            'qry.Append(" AND A.InvntSttus = 'O' ")
            'qry.Append(" GROUP BY B.ItemCode ")

            'qry.Append(" UNION ALL ")

            ''DEUDA CAMPANA
            'qry.Append(" SELECT  ")
            'qry.Append(" '' [DeLinea], ")
            'qry.Append(" b3.ItemCode  COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            'qry.Append(" '' [NombreArticulo], ")
            'qry.Append(" '' [Color], ")
            'qry.Append(" '' [Stock], ")
            'qry.Append(" '' [StockMinimo], ")
            'qry.Append(" '' [StockMaximo],  ")
            'qry.Append(" '' [Produccion],   ")
            'qry.Append(" '' [Ensamble], ")
            'qry.Append(" '' [Rol], ")
            'qry.Append(" ISNULL(CONVERT(INTEGER,SUM(B3.OpenQty)),0) [Campana], ")
            'qry.Append(" '' [Proyeccion], ")
            'qry.Append(" '' [DeudaEnsamble]   ")
            'qry.Append(" FROM SBOGuateplast.dbo.ORDR A3 WITH (NOLOCK, INDEX(ORDR_DOC_STATUS)) ")
            'qry.Append(" LEFT JOIN SBOGuateplast.dbo.RDR1 B3 WITH (NOLOCK , INDEX(RDR1_PRIMARY)) ON B3.DocEntry = A3.DocEntry   ")
            'qry.Append(" WHERE B3.LineStatus = 'O'  ")
            'qry.Append(" AND A3.DocStatus = 'O'  ")
            'qry.Append(" AND A3.CANCELED = 'N'  ")
            'qry.Append(" AND (A3.U_NameCamp IS NOT NULL AND A3.U_NameCamp > 1) ")
            'qry.Append(" GROUP BY B3.ItemCode ")

            'qry.Append(" UNION ALL ")

            ''DEUDA PROYECCION DE CAMPAÑA
            'qry.Append(" SELECT ")
            'qry.Append(" '' [DeLinea], ")
            'qry.Append(" CodigoArticulo [CodigoArticulo], ")
            'qry.Append(" '' [NombreArticulo], ")
            'qry.Append(" '' [Color], ")
            'qry.Append(" '' [Stock], ")
            'qry.Append(" '' [StockMinimo], ")
            'qry.Append(" '' [StockMaximo],  ")
            'qry.Append(" '' [Produccion],   ")
            'qry.Append(" '' [Ensamble], ")
            'qry.Append(" '' [Rol],  ")
            'qry.Append(" '' [Campana], ")
            'qry.Append(" CONVERT(INTEGER,SUM(CASE  ")
            'qry.Append(" WHEN Proyectado > Facturado   ")
            'qry.Append(" THEN (Proyectado - Facturado)  ")
            'qry.Append(" ELSE '0'  ")
            'qry.Append(" END))[Proyeccion],  ")
            'qry.Append(" '' [DeudaEnsamble]  ")
            'qry.Append(" FROM ")
            'qry.Append(" (SELECT  ")
            'qry.Append(" BB1.CodigoArticulo, ")
            'qry.Append(" BB1.Proyectado,  ")
            'qry.Append(" (	SELECT  ISNULL(CONVERT(INTEGER,SUM(A5.Quantity)),0) [Facturado]  ")
            'qry.Append(" FROM SBOGuateplast.dbo.INV1 A5 WITH (NOLOCK, INDEX(INV1_BASE_ENTRY)) ")
            'qry.Append(" LEFT JOIN SBOGuateplast.dbo.OINV B1 WITH (NOLOCK, INDEX(OINV_PRIMARY)) ON B1.DocEntry = A5.DocEntry   ")
            'qry.Append(" WHERE A5.BaseEntry IN  ( ")
            'qry.Append(" Select DISTINCT ")
            'qry.Append(" AA.DocEntry ")
            'qry.Append(" FROM SBOGuateplast.dbo.DLN1 AA  ")
            'qry.Append(" WHERE AA.BaseEntry IN  ( ")
            'qry.Append(" SELECT DISTINCT AAA.DocEntry  ")
            'qry.Append(" FROM SBOGuateplast.dbo.ORDR AAA WITH (NOLOCK, INDEX(ORDR_DOC_STATUS)) ")
            'qry.Append(" LEFT JOIN SBOGuateplast.dbo.RDR1 BBB WITH (NOLOCK, INDEX(RDR1_ITM_WHS_SH)) ON BBB.DocEntry = AAA.DocEntry   ")
            'qry.Append(" WHERE AAA.U_NameCamp = AA1.Id COLLATE Latin1_General_CI_AI ")
            'qry.Append(" AND BBB.ItemCode  = BB1.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            'qry.Append(" AND AAA.CANCELED = 'N' ")
            'qry.Append(" AND AAA.DocDate > (GETDATE() - 1000) ")
            'qry.Append(" ) ")
            'qry.Append(" AND AA.ItemCode  = BB1.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            'qry.Append(" AND AA.TargetType <> '16' ")
            'qry.Append(" AND AA.DocDate > (GETDATE() - 1000) ")
            'qry.Append(" ) ")
            'qry.Append(" AND A5.ItemCode = BB1.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            'qry.Append(" AND A5.TargetType <> '14' ")
            'qry.Append(" AND B1.DocDate > (GETDATE() - 1000) ")
            'qry.Append(" ) [Facturado]  ")
            'qry.Append(" FROM Ventas.dbo.CAM_Encabezado AA1 WITH (NOLOCK) ")
            'qry.Append(" LEFT JOIN Ventas.dbo.CAM_Detalle BB1 WITH (NOLOCK) ON BB1.Id = AA1.Id COLLATE SQL_Latin1_General_CP850_CI_AS   ")
            'qry.Append(" WHERE FechaFinal > GETDATE() ")
            'qry.Append(" AND LEN(AA1.Id) < 8  ")
            'qry.Append(" AND AA1.Distribuidor = '0' ")
            'qry.Append(" ) [QRY] ")
            'qry.Append(" GROUP BY CodigoArticulo ")

            'qry.Append(" UNION ALL ")

            ''PRODUCCIONES
            'qry.Append(" SELECT ")
            'qry.Append(" '' [DeLinea], ")
            'qry.Append(" B2.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            'qry.Append(" '' [NombreArticulo], ")
            'qry.Append(" '' [Color], ")
            'qry.Append(" '' [Stock], ")
            'qry.Append(" '' [StockMinimo], ")
            'qry.Append(" '' [StockMaximo], ")
            'qry.Append(" '' [Produccion], ")
            'qry.Append(" '' [Ensamble], ")
            'qry.Append(" '' [Rol], ")
            'qry.Append(" '' [Campana], ")
            'qry.Append(" '' [Proyeccion], ")
            'qry.Append(" ISNULL(SUM( ")
            'qry.Append(" CASE WHEN B2.PlannedQty > (CmpltQty * B2.BaseQty) THEN  ")
            'qry.Append(" CONVERT(INTEGER,(B2.PlannedQty - (CmpltQty * B2.BaseQty)))  ")
            'qry.Append(" ELSE '0'  ")
            'qry.Append(" END),0) [DeudaEnsamble]  ")
            'qry.Append(" FROM SBOGuateplast.dbo.OWOR A2 WITH (NOLOCK,INDEX(OWOR_PRIMARY)) ")
            'qry.Append(" LEFT JOIN SBOGuateplast.dbo.WOR1 B2 WITH (NOLOCK, INDEX(WOR1_PRIMARY)) ON B2.DocEntry = A2.DocEntry ")
            'qry.Append(" WHERE B2.ItemCode LIKE ('AR%')  ")
            'qry.Append(" AND A2.Status IN ('P','R')  ")
            'qry.Append(" AND A2.U_Tipo IN ('0','1','2','3','4') ")
            'qry.Append(" GROUP BY B2.ItemCode ")

            'qry.Append(" ) QRY1  ")
            ''FIN DE UNION DE SELECT

            'qry.Append(" GROUP BY CodigoArticulo  ")
            ''FIN DE AGRUPADO
            'qry.Append(" ) QRY2  ")

            qry.Append(" SELECT ")
            qry.Append(" DeLinea, ")
            qry.Append(" CodigoArticulo, ")
            qry.Append(" NombreArticulo, ")
            qry.Append(" Color, ")
            qry.Append(" Stock, ")
            qry.Append(" Produccion, ")
            qry.Append(" Ensamble, ")
            qry.Append(" TotalPositivo, ")
            qry.Append(" Rol, ")
            qry.Append(" Campana, ")
            qry.Append(" Proyeccion, ")
            qry.Append(" DeudaEnsamble, ")
            qry.Append(" TotalNegativo, ")
            qry.Append(" Disponible, ")
            qry.Append(" Sugerido, ")
            qry.Append(" StockMinimo, ")
            qry.Append(" StockMaximo ")

            qry.Append(" FROM( ")
            '--INICIO AGRUPADO
            qry.Append(" SELECT  ")
            qry.Append(" MAX(DeLinea)[DeLinea], ")
            qry.Append(" CodigoArticulo, ")
            qry.Append(" MAX(NombreArticulo) [NombreArticulo], ")
            qry.Append(" MAX(Color) [Color], ")
            qry.Append(" SUM(Stock)[Stock], ")
            qry.Append(" SUM(Produccion)[Produccion], ")
            qry.Append(" SUM(Ensamble)[Ensamble], ")
            qry.Append(" SUM(Stock)+ SUM(Produccion) + SUM(Ensamble) [TotalPositivo], ")
            qry.Append(" SUM(Rol) [Rol], ")
            qry.Append(" SUM(Campana) [Campana], ")
            qry.Append(" SUM(Proyeccion)[Proyeccion], ")
            qry.Append(" SUM(DeudaEnsamble)[DeudaEnsamble], ")
            qry.Append(" CASE  ")
            qry.Append(" WHEN SUM(Campana) > SUM(Proyeccion) THEN ")
            qry.Append(" SUM(ROL) + SUM(Campana) + SUM(DeudaEnsamble)  ")
            qry.Append(" ELSE ")
            qry.Append(" SUM(ROL) + SUM(Proyeccion) + SUM(DeudaEnsamble)  ")
            qry.Append(" End ")
            qry.Append(" [TotalNegativo], ")
            qry.Append(" (SUM(Stock)+ SUM(Produccion) + SUM(Ensamble)) - (SUM(ROL) + SUM(Campana) + SUM(DeudaEnsamble)) [Disponible], ")
            qry.Append(" CASE WHEN  ")
            qry.Append(" SUM(StockMaximo) > 1 THEN ")
            qry.Append(" SUM(StockMaximo) - ((SUM(Stock)+ SUM(Produccion) + SUM(Ensamble)) - (SUM(ROL) + SUM(Campana) + SUM(Proyeccion) + SUM(DeudaEnsamble))) ELSE '0' END [Sugerido], ")
            qry.Append(" SUM(StockMinimo) [StockMinimo], ")
            qry.Append(" SUM(StockMaximo)[StockMaximo] ")
            qry.Append(" FROM ")
            '--INICIO UNION DE SELECT
            qry.Append(" (SELECT   ")
            qry.Append(" CASE  ")
            qry.Append(" WHEN A1.U_NoDeLinea = '0' THEN 'SI' WHEN A1.U_NoDeLinea = '1' THEN 'NO' END [DeLinea],  ")
            qry.Append(" UPPER(A1.ItemCode) [CodigoArticulo],  ")
            qry.Append(" UPPER(A1.ItemName) [NombreArticulo],  ")
            qry.Append(" UPPER(A1.U_Color) [Color],  ")
            qry.Append(" CONVERT(INTEGER,ISNULL(A1.OnHand,0)) [Stock], ")
            qry.Append(" CONVERT(INTEGER,A1.MinLevel) [StockMinimo],  ")
            qry.Append(" CONVERT(INTEGER, A1.MaxLevel) [StockMaximo], ")
            qry.Append(" '' [Produccion] , ")
            qry.Append(" '' [Ensamble], ")
            qry.Append(" '' [Rol], ")
            qry.Append(" '' [Campana], ")
            qry.Append(" '' [Proyeccion], ")
            qry.Append(" '' [DeudaEnsamble]   ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM A1 WITH (NOLOCK, INDEX(OITM_PRIMARY)) ")
            qry.Append(" WHERE A1.ItemCode LIKE ('AR%')  ")
            qry.Append(" AND LEN(A1.ItemCode) > 8 ")
            qry.Append(" UNION ALL ")
            '--PRODUCCIONES
            qry.Append(" SELECT  ")
            qry.Append(" '' [DeLinea], ")
            qry.Append(" A2.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            qry.Append("             '' [NombreArticulo], ")
            qry.Append(" '' [Color], ")
            qry.Append(" '' [Stock], ")
            qry.Append(" '' [StockMinimo], ")
            qry.Append(" '' [StockMaximo], ")
            qry.Append(" ISNULL(SUM( ")
            qry.Append(" CASE WHEN PlannedQty > CmpltQty THEN  ")
            qry.Append(" CONVERT(INTEGER,(PlannedQty - CmpltQty))  ")
            qry.Append(" ELSE '0'  ")
            qry.Append(" END),0) [Produccion], ")
            qry.Append(" '' [Ensamble], ")
            qry.Append(" '' [Rol], ")
            qry.Append(" '' [Campana], ")
            qry.Append(" '' [Proyeccion], ")
            qry.Append(" '' [DeudaEnsamble]   ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A2 WITH (NOLOCK) ")
            qry.Append(" WHERE A2.ItemCode LIKE ('AR%')  ")
            qry.Append(" AND A2.Status IN ('P','R')  ")
            qry.Append(" AND A2.U_Tipo IN ('0') ")
            qry.Append(" GROUP BY A2.ItemCode ")
            qry.Append(" UNION ALL ")
            '--ENSAMBLES
            qry.Append(" SELECT ")
            qry.Append(" '' [DeLinea], ")
            qry.Append(" A2.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            qry.Append(" '' [NombreArticulo], ")
            qry.Append(" '' [Color], ")
            qry.Append(" '' [Stock], ")
            qry.Append(" '' [StockMinimo], ")
            qry.Append(" '' [StockMaximo],  ")
            qry.Append(" '' [Produccion], ")
            qry.Append(" ISNULL(SUM( ")
            qry.Append(" CASE WHEN PlannedQty > CmpltQty THEN  ")
            qry.Append(" CONVERT(INTEGER,(PlannedQty - CmpltQty))  ")
            qry.Append(" ELSE '0'  ")
            qry.Append(" END),0) [Ensamble],  ")
            qry.Append(" '' [Rol], ")
            qry.Append(" '' [Campana], ")
            qry.Append(" '' [Proyeccion], ")
            qry.Append(" '' [DeudaEnsamble]     ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A2 WITH (NOLOCK) ")
            qry.Append(" WHERE A2.ItemCode LIKE ('AR%')   ")
            qry.Append(" AND A2.Status IN ('P','R')  ")
            qry.Append(" AND A2.U_Tipo IN ('1','2','3','4') ")
            qry.Append(" GROUP BY A2.ItemCode ")
            qry.Append(" UNION ALL ")
            '--DEUDA ROL
            qry.Append(" SELECT ")
            qry.Append(" '' [DeLinea], ")
            qry.Append(" b3.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            qry.Append(" '' [NombreArticulo], ")
            qry.Append(" '' [Color], ")
            qry.Append(" '' [Stock], ")
            qry.Append(" '' [StockMinimo], ")
            qry.Append(" '' [StockMaximo],  ")
            qry.Append(" '' [Produccion],   ")
            qry.Append(" '' [Ensamble], ")
            qry.Append(" ISNULL(CONVERT(INTEGER,SUM(B3.OpenQty)),0) [Rol],  ")
            qry.Append(" '' [Campana], ")
            qry.Append(" '' [Proyeccion], ")
            qry.Append(" '' [DeudaEnsamble]  ")
            qry.Append(" FROM SBOGuateplast.dbo.ORDR A3 WITH (NOLOCK, INDEX(ORDR_DOC_STATUS)) ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.RDR1 B3 WITH (NOLOCK, INDEX(RDR1_PRIMARY)) ON B3.DocEntry = A3.DocEntry  ")
            qry.Append(" WHERE B3.LineStatus = 'O'  ")
            qry.Append(" AND A3.DocStatus = 'O'  ")
            qry.Append(" AND A3.CANCELED = 'N'  ")
            qry.Append(" AND ISNULL(A3.U_NameCamp,'') = '' ")
            qry.Append(" GROUP BY B3.ItemCode ")

            qry.Append(" UNION ALL ")


            qry.Append(" SELECT  ")
            '--DEUDA ROL
            qry.Append(" '' [DeLinea], ")
            qry.Append(" B.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            qry.Append(" '' [NombreArticulo], ")
            qry.Append(" '' [Color], ")
            qry.Append(" '' [Stock], ")
            qry.Append(" '' [StockMinimo], ")
            qry.Append(" '' [StockMaximo],  ")
            qry.Append(" '' [Produccion],   ")
            qry.Append(" '' [Ensamble], ")
            qry.Append(" CONVERT(INTEGER,SUM(B.OpenQty)) [Rol],  ")
            qry.Append(" '' [Campana], ")
            qry.Append(" '' [Proyeccion], ")
            qry.Append(" '' [DeudaEnsamble]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OINV A WITH (NOLOCK, INDEX(OINV_STS_CNCL)) ")
            qry.Append(" LEFT JOIN SBOGuateplast.DBO.INV1 B WITH (NOLOCK, INDEX(INV1_PRIMARY)) ON B.DocEntry = A.DocEntry ")
            qry.Append(" WHERE A.isIns = 'Y' ")
            qry.Append(" AND A.InvntSttus = 'O' ")
            qry.Append(" GROUP BY B.ItemCode ")

            qry.Append(" UNION ALL ")
            '--DEUDA CAMPANA
            qry.Append(" SELECT   ")
            qry.Append(" '' [DeLinea], ")
            qry.Append(" b3.ItemCode  COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            qry.Append(" '' [NombreArticulo], ")
            qry.Append(" '' [Color], ")
            qry.Append(" '' [Stock], ")
            qry.Append(" '' [StockMinimo], ")
            qry.Append(" '' [StockMaximo],  ")
            qry.Append(" '' [Produccion],   ")
            qry.Append(" '' [Ensamble], ")
            qry.Append(" '' [Rol], ")
            qry.Append(" ISNULL(CONVERT(INTEGER,SUM(B3.OpenQty)),0) [Campana], ")
            qry.Append(" '' [Proyeccion], ")
            qry.Append(" '' [DeudaEnsamble]   ")
            qry.Append(" FROM SBOGuateplast.dbo.ORDR A3 WITH (NOLOCK, INDEX(ORDR_DOC_STATUS)) ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.RDR1 B3 WITH (NOLOCK , INDEX(RDR1_PRIMARY)) ON B3.DocEntry = A3.DocEntry  ")
            qry.Append(" WHERE B3.LineStatus = 'O'  ")
            qry.Append(" AND A3.DocStatus = 'O'  ")
            qry.Append(" AND A3.CANCELED = 'N'  ")
            qry.Append(" AND (A3.U_NameCamp IS NOT NULL AND A3.U_NameCamp > 1) ")
            qry.Append(" GROUP BY B3.ItemCode ")

            qry.Append(" UNION ALL ")
            '-- DEUDA PROYECCION DE CAMPAÑA
            qry.Append(" SELECT ")
            qry.Append(" '' [DeLinea], ")
            qry.Append(" CodigoArticulo [CodigoArticulo], ")
            qry.Append(" '' [NombreArticulo], ")
            qry.Append(" '' [Color], ")
            qry.Append(" '' [Stock], ")
            qry.Append(" '' [StockMinimo], ")
            qry.Append(" '' [StockMaximo],  ")
            qry.Append(" '' [Produccion],   ")
            qry.Append(" '' [Ensamble], ")
            qry.Append(" '' [Rol],  ")
            qry.Append(" '' [Campana], ")
            qry.Append(" CONVERT(INTEGER,SUM(CASE  ")
            qry.Append(" WHEN Proyectado > Facturado   ")
            qry.Append(" THEN (Proyectado - Facturado)  ")
            qry.Append(" ELSE '0'  ")
            qry.Append(" END))[Proyeccion],  ")
            qry.Append(" '' [DeudaEnsamble]  ")
            qry.Append(" FROM ")
            qry.Append(" (SELECT  ")
            qry.Append(" BB1.CodigoArticulo, ")
            qry.Append(" BB1.Proyectado,  ")
            qry.Append(" ( SELECT  ISNULL(CONVERT(INTEGER,SUM(A5.Quantity)),0) [Facturado]  ")
            qry.Append(" FROM SBOGuateplast.dbo.INV1 A5 WITH (NOLOCK, INDEX(INV1_BASE_ENTRY)) ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OINV B1 WITH (NOLOCK, INDEX(OINV_PRIMARY)) ON B1.DocEntry = A5.DocEntry  ")
            qry.Append(" WHERE A5.BaseEntry IN  ( ")
            qry.Append(" Select DISTINCT ")
            qry.Append(" AA.DocEntry ")
            qry.Append(" FROM SBOGuateplast.dbo.DLN1 AA WITH (NOLOCK, INDEX(DLN1_BASE_ENTRY)) ")
            qry.Append(" WHERE AA.BaseEntry IN   ")
            qry.Append(" ( ")
            qry.Append(" SELECT DISTINCT AAA.DocEntry  ")
            qry.Append(" FROM SBOGuateplast.dbo.ORDR AAA WITH (NOLOCK, INDEX(ORDR_DATE_PIND)) ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.RDR1 BBB WITH (NOLOCK, INDEX(RDR1_ITM_WHS_SH)) ON BBB.DocEntry = AAA.DocEntry  ")
            qry.Append(" WHERE AAA.U_NameCamp = AA1.Id COLLATE Latin1_General_CI_AI ")
            qry.Append(" AND BBB.ItemCode  = BB1.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            qry.Append(" AND AAA.CANCELED = 'N' ")
            qry.Append(" AND AAA.DocDate >= (GETDATE() - 200) ")
            qry.Append(" ) ")
            qry.Append(" AND AA.ItemCode  = BB1.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            qry.Append(" AND AA.TargetType <> '16' ")
            qry.Append(" AND AA.DocDate >= (GETDATE() - 200) ")
            qry.Append(" ) ")
            qry.Append(" AND A5.ItemCode = BB1.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            qry.Append(" AND A5.TargetType <> '14' ")
            qry.Append(" AND B1.DocDate >= (GETDATE() - 200) ")
            qry.Append(" ) [Facturado]  ")
            qry.Append(" FROM Ventas.dbo.CAM_Encabezado AA1 WITH (NOLOCK) ")
            qry.Append(" LEFT JOIN Ventas.dbo.CAM_Detalle BB1 WITH (NOLOCK) ON BB1.Id = AA1.Id COLLATE SQL_Latin1_General_CP850_CI_AS   ")
            qry.Append(" WHERE FechaFinal > GETDATE() ")
            qry.Append(" AND LEN(AA1.Id) < 8  ")
            qry.Append(" AND AA1.Distribuidor = '0' ")
            qry.Append(" ) [QRY] ")
            qry.Append(" GROUP BY CodigoArticulo ")

            qry.Append(" UNION ALL ")
            '--PRODUCCIONES
            qry.Append(" SELECT  ")
            qry.Append(" '' [DeLinea], ")
            qry.Append(" B2.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            qry.Append(" '' [NombreArticulo], ")
            qry.Append(" '' [Color], ")
            qry.Append(" '' [Stock], ")
            qry.Append(" '' [StockMinimo], ")
            qry.Append(" '' [StockMaximo], ")
            qry.Append(" '' [Produccion], ")
            qry.Append(" '' [Ensamble], ")
            qry.Append(" '' [Rol], ")
            qry.Append(" '' [Campana], ")
            qry.Append(" '' [Proyeccion], ")
            qry.Append(" ISNULL(SUM( ")
            qry.Append(" CASE WHEN B2.PlannedQty > (CmpltQty * B2.BaseQty) THEN  ")
            qry.Append(" CONVERT(INTEGER,(B2.PlannedQty - (CmpltQty * B2.BaseQty))) ")
            qry.Append(" ELSE '0'  ")
            qry.Append(" END),0) [DeudaEnsamble]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A2 WITH (NOLOCK,INDEX(OWOR_PRIMARY)) ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.WOR1 B2 WITH (NOLOCK, INDEX(WOR1_PRIMARY)) ON B2.DocEntry = A2.DocEntry ")
            qry.Append(" WHERE B2.ItemCode LIKE ('AR%')  ")
            qry.Append(" AND A2.Status IN ('P','R')  ")
            qry.Append(" AND A2.U_Tipo IN ('0','1','2','3','4') ")
            qry.Append(" GROUP BY B2.ItemCode ")

            qry.Append(" ) QRY1  ")
            '--FIN DE UNION DE SELECT
            qry.Append(" GROUP BY CodigoArticulo ")
            '--FIN DE AGRUPADO
            qry.Append(" ) QRY2 ")



            'FILTROS

            qry.Append(" WHERE Rol >= '" + pDeudaRol + "' AND Campana >=  '" + pDeudaCampana + "' AND Proyeccion >= '" + pDeudaProyeccion + "' AND DeudaEnsamble >= '" + pDeudaEnsamble + "'  ")
            If Not pDeLinea = Nothing Then : qry.Append(" AND DeLinea = '" + pDeLinea + "'  ") : End If
            If Not pColor = Nothing Then : qry.Append(" AND Color = '" + pColor + "'  ") : End If
            If Not pCodigoPadre = Nothing Then : qry.Append(" AND CodigoArticulo LIKE ('" + pCodigoPadre + "%')  ") : End If
            If Not pCodigoPadreAl = Nothing Then : qry.Append(" AND CodigoArticulo BETWEEN  '" + pCodigoPadreDel + "' AND (select MAX(itemcode) from SBOGuateplast.dbo.OITM where ItemCode like '" + pCodigoPadreAl + "%')  ") : End If

            Select Case pTipoStock
                Case "Ninguno"

                Case "MenorMinimo"
                    qry.Append(" AND Stock < StockMinimo  ")
                Case "MenorMaximo"
                    qry.Append(" AND Stock < StockMaximo  ")
                Case "EntreMinimoMaximo"
                    qry.Append(" AND Stock BETWEEN StockMinimo AND StockMaximo AND Stock > 0  ")
                Case "Menor%Minimo"
                    qry.Append(" AND (Stock <= (StockMinimo * 1.15) AND Stock > 0)  ")
                Case "MenorProyeccion"
                    qry.Append(" AND TotalPositivo < Proyeccion  ")
                Case "DisponibleMenorMinimo"
                    qry.Append(" AND (Disponible < StockMinimo AND StockMinimo > 0)  ")
                Case "TOP50"
                    qry.Append(" AND CodigoArticulo in (SELECT ItemCode ")
                    qry.Append(" FROM SBOGuateplast.dbo.OITM ")
                    qry.Append(" WHERE ItemCode LIKE ('AR%') ")
                    qry.Append(" AND U_GrupoRastreo > 0 ")
                    qry.Append(" AND LEN(ItemCode) > 8)  ")
                Case "DisponibleMenor2M"
                    qry.Append(" AND (Disponible < (StockMinimo + StockMinimo) AND StockMinimo > 0) ")

            End Select

            If Not pStockMenorA = Nothing Then : qry.Append(" AND Stock < '" + pStockMenorA + "'  ") : End If
            If Not pStockMayorA = Nothing Then : qry.Append(" AND Stock > '" + pStockMayorA + "'  ") : End If

            If Not pCampana = Nothing Then : qry.Append(" AND CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS IN (SELECT CodigoArticulo FROM Ventas.dbo.CAM_Detalle WHERE Id = ('" + pCampana + "'))") : End If

            If Not pCliente = Nothing Then
                qry.Append(" AND CodigoArticulo IN (SELECT DISTINCT B3.ItemCode   ")
                qry.Append(" FROM SBOGuateplast.dbo.ORDR A3  ")
                qry.Append(" LEFT JOIN SBOGuateplast.dbo.RDR1 B3 ON B3.DocEntry = A3.DocEntry   ")
                qry.Append(" WHERE A3.CardCode = '" + pCliente + "' AND B3.LineStatus = 'O' AND A3.DocStatus = 'O' AND A3.CANCELED = 'N')  ")
            End If



            '


            'qry.Append(" AND CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS IN (SELECT CodigoArticulo FROM Ventas.dbo.CAM_Detalle WHERE Id = ('10260'))  ")

            'qry.Append(" AND CodigoArticulo IN (SELECT DISTINCT B3.ItemCode   ")
            'qry.Append(" FROM SBOGuateplast.dbo.ORDR A3  ")
            'qry.Append(" LEFT JOIN SBOGuateplast.dbo.RDR1 B3 ON B3.DocEntry = A3.DocEntry   ")
            'qry.Append(" WHERE A3.CardCode = 'C02914' AND B3.LineStatus = 'O' AND A3.DocStatus = 'O' AND A3.CANCELED = 'N')  ")

            'qry.Append(" ORDER BY CodigoArticulo ASC ") Se quito por eficiencia del qry



            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    'Public Function GET_AnalisisNecesidades(ByVal pDeLinea As String, ByVal pColor As String, ByVal pCodigoPadre As String, _
    '                                        ByVal pCodigoPadreDel As String, ByVal pCodigoPadreAl As String, ByVal pTipoStock As String, ByVal pPorcStock As String, _
    '                                        ByVal pStockMenorA As String, ByVal pStockMayorA As String, _
    '                                        ByVal pCampana As String, ByVal pCliente As String, _
    '                                        ByVal pDeudaRol As String, ByVal pDeudaCampana As String, ByVal pDeudaProyeccion As String, ByVal pDeudaEnsamble As String) As DataTable

    '    Dim qry As New StringBuilder
    '    Dim dt As New DataTable("dtStockDetalle")

    '    Try
    '        qry.Append(" SELECT ")
    '        qry.Append(" DeLinea, ")
    '        qry.Append(" CodigoArticulo, ")
    '        qry.Append(" NombreArticulo, ")
    '        qry.Append(" Color, ")
    '        qry.Append(" Stock, ")
    '        qry.Append(" Produccion, ")
    '        qry.Append(" Ensamble, ")
    '        qry.Append(" TotalPositivo, ")
    '        qry.Append(" Rol, ")
    '        qry.Append(" Campana, ")
    '        qry.Append(" Proyeccion, ")
    '        qry.Append(" DeudaEnsamble, ")
    '        qry.Append(" TotalNegativo, ")
    '        qry.Append(" Disponible, ")
    '        qry.Append(" Sugerido, ")
    '        qry.Append(" StockMinimo, ")
    '        qry.Append(" StockMaximo ")
    '        qry.Append(" FROM( ")
    '        'INICIO AGRUPADO
    '        qry.Append(" SELECT  ")
    '        qry.Append(" MAX(DeLinea)[DeLinea], ")
    '        qry.Append(" CodigoArticulo, ")
    '        qry.Append(" MAX(NombreArticulo) [NombreArticulo], ")
    '        qry.Append(" MAX(Color) [Color], ")
    '        qry.Append(" SUM(Stock)[Stock], ")
    '        qry.Append(" SUM(Produccion)[Produccion], ")
    '        qry.Append(" SUM(Ensamble)[Ensamble], ")
    '        qry.Append(" SUM(Stock)+ SUM(Produccion) + SUM(Ensamble) [TotalPositivo], ")
    '        qry.Append(" SUM(Rol) [Rol], ")
    '        qry.Append(" SUM(Campana) [Campana], ")
    '        qry.Append(" SUM(Proyeccion)[Proyeccion], ")
    '        qry.Append(" SUM(DeudaEnsamble)[DeudaEnsamble], ")
    '        'SUM(ROL) + SUM(Campana) + SUM(DeudaEnsamble) [TotalNegativo], ")
    '        qry.Append(" CASE ")
    '        qry.Append(" WHEN SUM(Campana) > SUM(Proyeccion) THEN ")
    '        qry.Append(" SUM(ROL) + SUM(Campana) + SUM(DeudaEnsamble)  ")
    '        qry.Append(" ELSE ")
    '        qry.Append(" SUM(ROL) + SUM(Proyeccion) + SUM(DeudaEnsamble)  ")
    '        qry.Append(" End ")
    '        qry.Append(" [TotalNegativo], ")


    '        qry.Append(" (SUM(Stock)+ SUM(Produccion) + SUM(Ensamble)) - (SUM(ROL) + SUM(Campana) + SUM(DeudaEnsamble)) [Disponible], ")
    '        qry.Append(" CASE WHEN  ")
    '        qry.Append(" SUM(StockMaximo) > 1 THEN ")
    '        qry.Append(" SUM(StockMaximo) - ((SUM(Stock)+ SUM(Produccion) + SUM(Ensamble)) - (SUM(ROL) + SUM(Campana) + SUM(Proyeccion) + SUM(DeudaEnsamble))) ELSE '0' END [Sugerido], ")
    '        qry.Append(" SUM(StockMinimo) [StockMinimo], ")
    '        qry.Append(" SUM(StockMaximo)[StockMaximo] ")
    '        qry.Append(" FROM ")
    '        'INICIO UNION DE SELECT
    '        qry.Append(" (SELECT  ")
    '        qry.Append(" CASE  ")
    '        qry.Append(" WHEN A1.U_NoDeLinea = '0' THEN 'SI' WHEN A1.U_NoDeLinea = '1' THEN 'NO' END [DeLinea],  ")
    '        qry.Append(" UPPER(A1.ItemCode) [CodigoArticulo],  ")
    '        qry.Append(" UPPER(A1.ItemName) [NombreArticulo],  ")
    '        qry.Append(" UPPER(A1.U_Color) [Color],  ")
    '        qry.Append(" CONVERT(INTEGER,ISNULL(A1.OnHand,0)) [Stock], ")
    '        qry.Append(" CONVERT(INTEGER,A1.MinLevel) [StockMinimo],  ")
    '        qry.Append(" CONVERT(INTEGER, A1.MaxLevel) [StockMaximo], ")
    '        qry.Append(" '' [Produccion] , ")
    '        qry.Append(" '' [Ensamble], ")
    '        qry.Append(" '' [Rol], ")
    '        qry.Append(" '' [Campana], ")
    '        qry.Append(" '' [Proyeccion], ")
    '        qry.Append(" '' [DeudaEnsamble]   ")
    '        qry.Append(" FROM SBOGuateplast.dbo.OITM A1 WITH (NOLOCK) ")
    '        qry.Append(" WHERE A1.ItemCode LIKE ('AR%')  ")
    '        qry.Append(" AND LEN(A1.ItemCode) > 8 ")

    '        qry.Append(" UNION ALL ")

    '        'PRODUCCIONES
    '        qry.Append(" SELECT ")
    '        qry.Append(" '' [DeLinea], ")
    '        qry.Append(" A2.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
    '        qry.Append(" '' [NombreArticulo], ")
    '        qry.Append(" '' [Color], ")
    '        qry.Append(" '' [Stock], ")
    '        qry.Append(" '' [StockMinimo], ")
    '        qry.Append(" '' [StockMaximo], ")
    '        qry.Append(" ISNULL(SUM( ")
    '        qry.Append(" CASE WHEN PlannedQty > CmpltQty THEN  ")
    '        qry.Append(" CONVERT(INTEGER,(PlannedQty - CmpltQty))  ")
    '        qry.Append(" ELSE '0'  ")
    '        qry.Append(" END),0) [Produccion], ")
    '        qry.Append(" '' [Ensamble], ")
    '        qry.Append(" '' [Rol], ")
    '        qry.Append(" '' [Campana], ")
    '        qry.Append(" '' [Proyeccion], ")
    '        qry.Append(" '' [DeudaEnsamble]   ")
    '        qry.Append(" FROM SBOGuateplast.dbo.OWOR A2 WITH (NOLOCK) ")
    '        qry.Append(" WHERE A2.ItemCode LIKE ('AR%')  ")
    '        qry.Append(" AND A2.Status IN ('P','R')  ")
    '        qry.Append(" AND A2.U_Tipo IN ('0') ")
    '        qry.Append(" GROUP BY A2.ItemCode ")

    '        qry.Append(" UNION ALL ")
    '        'ENSAMBLES
    '        qry.Append(" SELECT ")
    '        qry.Append(" '' [DeLinea], ")
    '        qry.Append(" A2.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
    '        qry.Append(" '' [NombreArticulo], ")
    '        qry.Append(" '' [Color], ")
    '        qry.Append(" '' [Stock], ")
    '        qry.Append(" '' [StockMinimo], ")
    '        qry.Append(" '' [StockMaximo],  ")
    '        qry.Append(" '' [Produccion], ")
    '        qry.Append(" ISNULL(SUM( ")
    '        qry.Append(" CASE WHEN PlannedQty > CmpltQty THEN  ")
    '        qry.Append(" CONVERT(INTEGER,(PlannedQty - CmpltQty))  ")
    '        qry.Append(" ELSE '0'  ")
    '        qry.Append(" END),0) [Ensamble],  ")
    '        qry.Append(" '' [Rol], ")
    '        qry.Append(" '' [Campana], ")
    '        qry.Append(" '' [Proyeccion], ")
    '        qry.Append(" '' [DeudaEnsamble]     ")
    '        qry.Append(" FROM SBOGuateplast.dbo.OWOR A2 WITH (NOLOCK) ")
    '        qry.Append(" WHERE A2.ItemCode LIKE ('AR%')   ")
    '        qry.Append(" AND A2.Status IN ('P','R')  ")
    '        qry.Append(" AND A2.U_Tipo IN ('1','2','3','4') ")
    '        qry.Append(" GROUP BY A2.ItemCode ")

    '        qry.Append(" UNION ALL ")

    '        'DEUDA ROL
    '        qry.Append(" SELECT ")
    '        qry.Append(" '' [DeLinea], ")
    '        qry.Append(" b3.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
    '        qry.Append(" '' [NombreArticulo], ")
    '        qry.Append(" '' [Color], ")
    '        qry.Append(" '' [Stock], ")
    '        qry.Append(" '' [StockMinimo], ")
    '        qry.Append(" '' [StockMaximo],  ")
    '        qry.Append(" '' [Produccion],   ")
    '        qry.Append(" '' [Ensamble], ")
    '        qry.Append(" ISNULL(CONVERT(INTEGER,SUM(B3.OpenQty)),0) [Rol],  ")
    '        qry.Append(" '' [Campana], ")
    '        qry.Append(" '' [Proyeccion], ")
    '        qry.Append(" '' [DeudaEnsamble]  ")
    '        qry.Append(" FROM SBOGuateplast.dbo.ORDR A3 WITH (NOLOCK) ")
    '        qry.Append(" LEFT JOIN SBOGuateplast.dbo.RDR1 B3 WITH (NOLOCK) ON B3.DocEntry = A3.DocEntry  ")
    '        qry.Append(" WHERE B3.LineStatus = 'O'  ")
    '        qry.Append(" AND A3.DocStatus = 'O'  ")
    '        qry.Append(" AND A3.CANCELED = 'N'  ")
    '        qry.Append(" AND (A3.U_NameCamp IS NULL OR A3.U_NameCamp = '') ")
    '        qry.Append(" GROUP BY B3.ItemCode ")

    '        qry.Append(" UNION ALL ")


    '        qry.Append(" SELECT ")
    '        'DEUDA ROL
    '        qry.Append(" '' [DeLinea], ")
    '        qry.Append(" B.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
    '        qry.Append(" '' [NombreArticulo], ")
    '        qry.Append(" '' [Color], ")
    '        qry.Append(" '' [Stock], ")
    '        qry.Append(" '' [StockMinimo], ")
    '        qry.Append(" '' [StockMaximo],  ")
    '        qry.Append(" '' [Produccion],   ")
    '        qry.Append(" '' [Ensamble], ")
    '        qry.Append(" CONVERT(INTEGER,SUM(B.OpenQty)) [Rol],  ")
    '        qry.Append(" '' [Campana], ")
    '        qry.Append(" '' [Proyeccion], ")
    '        qry.Append(" '' [DeudaEnsamble]  ")
    '        qry.Append(" FROM SBOGuateplast.dbo.OINV A WITH (NOLOCK) ")
    '        qry.Append(" LEFT JOIN SBOGuateplast.DBO.INV1 B WITH (NOLOCK) ON B.DocEntry = A.DocEntry ")
    '        qry.Append(" WHERE A.isIns = 'Y' ")
    '        qry.Append(" AND A.InvntSttus = 'O' ")
    '        qry.Append(" GROUP BY B.ItemCode ")

    '        qry.Append(" UNION ALL ")

    '        'DEUDA CAMPANA
    '        qry.Append(" SELECT  ")
    '        qry.Append(" '' [DeLinea], ")
    '        qry.Append(" b3.ItemCode  COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
    '        qry.Append(" '' [NombreArticulo], ")
    '        qry.Append(" '' [Color], ")
    '        qry.Append(" '' [Stock], ")
    '        qry.Append(" '' [StockMinimo], ")
    '        qry.Append(" '' [StockMaximo],  ")
    '        qry.Append(" '' [Produccion],   ")
    '        qry.Append(" '' [Ensamble], ")
    '        qry.Append(" '' [Rol], ")
    '        qry.Append(" ISNULL(CONVERT(INTEGER,SUM(B3.OpenQty)),0) [Campana], ")
    '        qry.Append(" '' [Proyeccion], ")
    '        qry.Append(" '' [DeudaEnsamble]   ")
    '        qry.Append(" FROM SBOGuateplast.dbo.ORDR A3 WITH (NOLOCK) ")
    '        qry.Append(" LEFT JOIN SBOGuateplast.dbo.RDR1 B3 WITH (NOLOCK) ON B3.DocEntry = A3.DocEntry  ")
    '        qry.Append(" WHERE B3.LineStatus = 'O'  ")
    '        qry.Append(" AND A3.DocStatus = 'O'  ")
    '        qry.Append(" AND A3.CANCELED = 'N'  ")
    '        qry.Append(" AND (A3.U_NameCamp IS NOT NULL AND A3.U_NameCamp > 1) ")
    '        qry.Append(" GROUP BY B3.ItemCode ")

    '        qry.Append(" UNION ALL ")

    '        'DEUDA PROYECCION DE CAMPAÑA
    '        qry.Append(" SELECT ")
    '        qry.Append(" '' [DeLinea], ")
    '        qry.Append(" CodigoArticulo [CodigoArticulo], ")
    '        qry.Append(" '' [NombreArticulo], ")
    '        qry.Append(" '' [Color], ")
    '        qry.Append(" '' [Stock], ")
    '        qry.Append(" '' [StockMinimo], ")
    '        qry.Append(" '' [StockMaximo],  ")
    '        qry.Append(" '' [Produccion],   ")
    '        qry.Append(" '' [Ensamble], ")
    '        qry.Append(" '' [Rol],  ")
    '        qry.Append(" '' [Campana], ")
    '        qry.Append(" CONVERT(INTEGER,SUM(CASE  ")
    '        qry.Append(" WHEN Proyectado > Facturado   ")
    '        qry.Append(" THEN (Proyectado - Facturado)  ")
    '        qry.Append(" ELSE '0'  ")
    '        qry.Append(" END))[Proyeccion],  ")
    '        qry.Append(" '' [DeudaEnsamble]  ")
    '        qry.Append(" FROM ")
    '        qry.Append(" (SELECT  ")
    '        qry.Append(" BB1.CodigoArticulo, ")
    '        qry.Append(" BB1.Proyectado,  ")
    '        qry.Append(" (	SELECT  ISNULL(CONVERT(INTEGER,SUM(A5.Quantity)),0) [Facturado]  ")
    '        qry.Append(" FROM SBOGuateplast.dbo.INV1 A5 WITH (NOLOCK) ")
    '        qry.Append(" LEFT JOIN SBOGuateplast.dbo.OINV B1 WITH (NOLOCK) ON B1.DocEntry = A5.DocEntry  ")
    '        qry.Append(" WHERE A5.BaseEntry IN  ( ")
    '        qry.Append(" Select DISTINCT ")
    '        qry.Append(" AA.DocEntry ")
    '        qry.Append(" FROM SBOGuateplast.dbo.DLN1 AA  ")
    '        qry.Append(" WHERE AA.BaseEntry IN  ( ")
    '        qry.Append(" SELECT DISTINCT AAA.DocEntry  ")
    '        qry.Append(" FROM SBOGuateplast.dbo.ORDR AAA WITH (NOLOCK) ")
    '        qry.Append(" LEFT JOIN SBOGuateplast.dbo.RDR1 BBB WITH (NOLOCK) ON BBB.DocEntry = AAA.DocEntry  ")
    '        qry.Append(" WHERE AAA.U_NameCamp = AA1.Id COLLATE Latin1_General_CI_AI ")
    '        qry.Append(" AND BBB.ItemCode  = BB1.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS  ")
    '        qry.Append(" AND AAA.CANCELED = 'N' ")
    '        qry.Append(" AND AAA.DocDate > (GETDATE() - 1000) ")
    '        qry.Append(" ) ")
    '        qry.Append(" AND AA.ItemCode  = BB1.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS  ")
    '        qry.Append(" AND AA.TargetType <> '16' ")
    '        qry.Append(" AND AA.DocDate > (GETDATE() - 1000) ")
    '        qry.Append(" ) ")
    '        qry.Append(" AND A5.ItemCode = BB1.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS  ")
    '        qry.Append(" AND A5.TargetType <> '14' ")
    '        qry.Append(" AND B1.DocDate > (GETDATE() - 1000) ")
    '        qry.Append(" ) [Facturado]  ")
    '        qry.Append(" FROM Ventas.dbo.CAM_Encabezado AA1 WITH (NOLOCK) ")
    '        qry.Append(" LEFT JOIN Ventas.dbo.CAM_Detalle BB1 WITH (NOLOCK) ON BB1.Id = AA1.Id COLLATE SQL_Latin1_General_CP850_CI_AS   ")
    '        qry.Append(" WHERE FechaFinal > GETDATE() ")
    '        qry.Append(" AND LEN(AA1.Id) < 8  ")
    '        qry.Append(" AND AA1.Distribuidor = '0' ")
    '        qry.Append(" ) [QRY] ")
    '        qry.Append(" GROUP BY CodigoArticulo ")

    '        qry.Append(" UNION ALL ")

    '        'PRODUCCIONES
    '        qry.Append(" SELECT ")
    '        qry.Append(" '' [DeLinea], ")
    '        qry.Append(" B2.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
    '        qry.Append(" '' [NombreArticulo], ")
    '        qry.Append(" '' [Color], ")
    '        qry.Append(" '' [Stock], ")
    '        qry.Append(" '' [StockMinimo], ")
    '        qry.Append(" '' [StockMaximo], ")
    '        qry.Append(" '' [Produccion], ")
    '        qry.Append(" '' [Ensamble], ")
    '        qry.Append(" '' [Rol], ")
    '        qry.Append(" '' [Campana], ")
    '        qry.Append(" '' [Proyeccion], ")
    '        qry.Append(" ISNULL(SUM( ")
    '        qry.Append(" CASE WHEN B2.PlannedQty > (CmpltQty * B2.BaseQty) THEN  ")
    '        qry.Append(" CONVERT(INTEGER,(B2.PlannedQty - (CmpltQty * B2.BaseQty)))  ")
    '        qry.Append(" ELSE '0'  ")
    '        qry.Append(" END),0) [DeudaEnsamble]  ")
    '        qry.Append(" FROM SBOGuateplast.dbo.OWOR A2 WITH (NOLOCK) ")
    '        qry.Append(" LEFT JOIN SBOGuateplast.dbo.WOR1 B2 WITH (NOLOCK) ON B2.DocEntry = A2.DocEntry ")
    '        qry.Append(" WHERE B2.ItemCode LIKE ('AR%')  ")
    '        qry.Append(" AND A2.Status IN ('P','R')  ")
    '        qry.Append(" AND A2.U_Tipo IN ('0','1','2','3','4') ")
    '        qry.Append(" GROUP BY B2.ItemCode ")

    '        qry.Append(" ) QRY1  ")
    '        'FIN DE UNION DE SELECT

    '        qry.Append(" GROUP BY CodigoArticulo  ")
    '        'FIN DE AGRUPADO
    '        qry.Append(" ) QRY2  ")

    '        'FILTROS

    '        qry.Append(" WHERE Rol >= '" + pDeudaRol + "' AND Campana >=  '" + pDeudaCampana + "' AND Proyeccion >= '" + pDeudaProyeccion + "' AND DeudaEnsamble >= '" + pDeudaEnsamble + "'  ")
    '        If Not pDeLinea = Nothing Then : qry.Append(" AND DeLinea = '" + pDeLinea + "'  ") : End If
    '        If Not pColor = Nothing Then : qry.Append(" AND Color = '" + pColor + "'  ") : End If
    '        If Not pCodigoPadre = Nothing Then : qry.Append(" AND CodigoArticulo LIKE ('" + pCodigoPadre + "%')  ") : End If
    '        If Not pCodigoPadreAl = Nothing Then : qry.Append(" AND CodigoArticulo BETWEEN  '" + pCodigoPadreDel + "' AND (select MAX(itemcode) from SBOGuateplast.dbo.OITM where ItemCode like '" + pCodigoPadreAl + "%')  ") : End If

    '        Select Case pTipoStock
    '            Case "Ninguno"

    '            Case "MenorMinimo"
    '                qry.Append(" AND Stock < StockMinimo  ")
    '            Case "MenorMaximo"
    '                qry.Append(" AND Stock < StockMaximo  ")
    '            Case "EntreMinimoMaximo"
    '                qry.Append(" AND Stock BETWEEN StockMinimo AND StockMaximo AND Stock > 0  ")
    '            Case "Menor%Minimo"
    '                qry.Append(" AND (Stock <= (StockMinimo * 1.15) AND Stock > 0)  ")
    '            Case "MenorProyeccion"
    '                qry.Append(" AND TotalPositivo < Proyeccion  ")
    '            Case "DisponibleMenorMinimo"
    '                qry.Append(" AND (Disponible < StockMinimo AND StockMinimo > 0)  ")
    '            Case "TOP50"
    '                qry.Append(" AND CodigoArticulo in (SELECT ItemCode ")
    '                qry.Append(" FROM SBOGuateplast.dbo.OITM ")
    '                qry.Append(" WHERE ItemCode LIKE ('AR%') ")
    '                qry.Append(" AND U_GrupoRastreo > 0 ")
    '                qry.Append(" AND LEN(ItemCode) > 8)  ")
    '        End Select

    '        If Not pStockMenorA = Nothing Then : qry.Append(" AND Stock < '" + pStockMenorA + "'  ") : End If
    '        If Not pStockMayorA = Nothing Then : qry.Append(" AND Stock > '" + pStockMayorA + "'  ") : End If

    '        If Not pCampana = Nothing Then : qry.Append(" AND CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS IN (SELECT CodigoArticulo FROM Ventas.dbo.CAM_Detalle WHERE Id = ('" + pCampana + "'))") : End If

    '        If Not pCliente = Nothing Then
    '            qry.Append(" AND CodigoArticulo IN (SELECT DISTINCT B3.ItemCode   ")
    '            qry.Append(" FROM SBOGuateplast.dbo.ORDR A3  ")
    '            qry.Append(" LEFT JOIN SBOGuateplast.dbo.RDR1 B3 ON B3.DocEntry = A3.DocEntry   ")
    '            qry.Append(" WHERE A3.CardCode = '" + pCliente + "' AND B3.LineStatus = 'O' AND A3.DocStatus = 'O' AND A3.CANCELED = 'N')  ")
    '        End If



    '        '


    '        'qry.Append(" AND CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS IN (SELECT CodigoArticulo FROM Ventas.dbo.CAM_Detalle WHERE Id = ('10260'))  ")

    '        'qry.Append(" AND CodigoArticulo IN (SELECT DISTINCT B3.ItemCode   ")
    '        'qry.Append(" FROM SBOGuateplast.dbo.ORDR A3  ")
    '        'qry.Append(" LEFT JOIN SBOGuateplast.dbo.RDR1 B3 ON B3.DocEntry = A3.DocEntry   ")
    '        'qry.Append(" WHERE A3.CardCode = 'C02914' AND B3.LineStatus = 'O' AND A3.DocStatus = 'O' AND A3.CANCELED = 'N')  ")

    '        qry.Append(" ORDER BY CodigoArticulo ASC ")



    '        dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

    '        Return dt

    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message)
    '        Return Nothing
    '    End Try
    'End Function

    Public Function GET_AnalisisNecesidades(ByVal pCodigoArticulo As String) As DataTable

        Dim qry As New StringBuilder
        Dim dt As New DataTable("dtStockDetalle")

        Try
            'qry.Append(" SELECT ")
            'qry.Append(" DeLinea, ")
            'qry.Append(" CodigoArticulo, ")
            'qry.Append(" NombreArticulo, ")
            'qry.Append(" Color, ")
            'qry.Append(" Stock, ")
            'qry.Append(" Produccion, ")
            'qry.Append(" Ensamble, ")
            'qry.Append(" TotalPositivo, ")
            'qry.Append(" Rol, ")
            'qry.Append(" Campana, ")
            'qry.Append(" Proyeccion, ")
            'qry.Append(" DeudaEnsamble, ")
            'qry.Append(" TotalNegativo, ")
            'qry.Append(" Disponible, ")
            'qry.Append(" Sugerido, ")
            'qry.Append(" StockMinimo, ")
            'qry.Append(" StockMaximo ")
            'qry.Append(" FROM( ")
            ''INICIO AGRUPADO
            'qry.Append(" SELECT  ")
            'qry.Append(" MAX(DeLinea)[DeLinea], ")
            'qry.Append(" CodigoArticulo, ")
            'qry.Append(" MAX(NombreArticulo) [NombreArticulo], ")
            'qry.Append(" MAX(Color) [Color], ")
            'qry.Append(" SUM(Stock)[Stock], ")
            'qry.Append(" SUM(Produccion)[Produccion], ")
            'qry.Append(" SUM(Ensamble)[Ensamble], ")
            'qry.Append(" SUM(Stock)+ SUM(Produccion) + SUM(Ensamble) [TotalPositivo], ")
            'qry.Append(" SUM(Rol) [Rol], ")
            'qry.Append(" SUM(Campana) [Campana], ")
            'qry.Append(" SUM(Proyeccion)[Proyeccion], ")
            'qry.Append(" SUM(DeudaEnsamble)[DeudaEnsamble], ")
            ''SUM(ROL) + SUM(Campana) + SUM(DeudaEnsamble) [TotalNegativo], ")
            'qry.Append(" CASE ")
            'qry.Append(" WHEN SUM(Campana) > SUM(Proyeccion) THEN ")
            'qry.Append(" SUM(ROL) + SUM(Campana) + SUM(DeudaEnsamble)  ")
            'qry.Append(" ELSE ")
            'qry.Append(" SUM(ROL) + SUM(Proyeccion) + SUM(DeudaEnsamble)  ")
            'qry.Append(" End ")
            'qry.Append(" [TotalNegativo], ")


            'qry.Append(" (SUM(Stock)+ SUM(Produccion) + SUM(Ensamble)) - (SUM(ROL) + SUM(Campana) + SUM(DeudaEnsamble)) [Disponible], ")
            'qry.Append(" CASE WHEN  ")
            'qry.Append(" SUM(StockMaximo) > 1 THEN ")
            'qry.Append(" SUM(StockMaximo) - ((SUM(Stock)+ SUM(Produccion) + SUM(Ensamble)) - (SUM(ROL) + SUM(Campana) + SUM(Proyeccion) + SUM(DeudaEnsamble))) ELSE '0' END [Sugerido], ")
            'qry.Append(" SUM(StockMinimo) [StockMinimo], ")
            'qry.Append(" SUM(StockMaximo)[StockMaximo] ")
            'qry.Append(" FROM ")
            ''INICIO UNION DE SELECT
            'qry.Append(" (SELECT  ")
            'qry.Append(" CASE  ")
            'qry.Append(" WHEN A1.U_NoDeLinea = '0' THEN 'SI' WHEN A1.U_NoDeLinea = '1' THEN 'NO' END [DeLinea],  ")
            'qry.Append(" UPPER(A1.ItemCode) [CodigoArticulo],  ")
            'qry.Append(" UPPER(A1.ItemName) [NombreArticulo],  ")
            'qry.Append(" UPPER(A1.U_Color) [Color],  ")
            'qry.Append(" CONVERT(INTEGER,ISNULL(A1.OnHand,0)) [Stock], ")
            'qry.Append(" CONVERT(INTEGER,A1.MinLevel) [StockMinimo],  ")
            'qry.Append(" CONVERT(INTEGER, A1.MaxLevel) [StockMaximo], ")
            'qry.Append(" '' [Produccion] , ")
            'qry.Append(" '' [Ensamble], ")
            'qry.Append(" '' [Rol], ")
            'qry.Append(" '' [Campana], ")
            'qry.Append(" '' [Proyeccion], ")
            'qry.Append(" '' [DeudaEnsamble]   ")
            'qry.Append(" FROM SBOGuateplast.dbo.OITM A1 WITH (NOLOCK, INDEX(OITM_PRIMARY)) ")
            'qry.Append(" WHERE A1.ItemCode LIKE ('AR%')  ")
            'qry.Append(" AND LEN(A1.ItemCode) > 8 ")

            'qry.Append(" UNION ALL ")

            ''PRODUCCIONES
            'qry.Append(" SELECT ")
            'qry.Append(" '' [DeLinea], ")
            'qry.Append(" A2.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            'qry.Append(" '' [NombreArticulo], ")
            'qry.Append(" '' [Color], ")
            'qry.Append(" '' [Stock], ")
            'qry.Append(" '' [StockMinimo], ")
            'qry.Append(" '' [StockMaximo], ")
            'qry.Append(" ISNULL(SUM( ")
            'qry.Append(" CASE WHEN PlannedQty > CmpltQty THEN  ")
            'qry.Append(" CONVERT(INTEGER,(PlannedQty - CmpltQty))  ")
            'qry.Append(" ELSE '0'  ")
            'qry.Append(" END),0) [Produccion], ")
            'qry.Append(" '' [Ensamble], ")
            'qry.Append(" '' [Rol], ")
            'qry.Append(" '' [Campana], ")
            'qry.Append(" '' [Proyeccion], ")
            'qry.Append(" '' [DeudaEnsamble]   ")
            'qry.Append(" FROM SBOGuateplast.dbo.OWOR A2 WITH (NOLOCK) ")
            'qry.Append(" WHERE A2.ItemCode LIKE ('AR%')  ")
            'qry.Append(" AND A2.Status IN ('P','R')  ")
            'qry.Append(" AND A2.U_Tipo IN ('0') ")
            'qry.Append(" GROUP BY A2.ItemCode ")

            'qry.Append(" UNION ALL ")
            ''ENSAMBLES
            'qry.Append(" SELECT ")
            'qry.Append(" '' [DeLinea], ")
            'qry.Append(" A2.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            'qry.Append(" '' [NombreArticulo], ")
            'qry.Append(" '' [Color], ")
            'qry.Append(" '' [Stock], ")
            'qry.Append(" '' [StockMinimo], ")
            'qry.Append(" '' [StockMaximo],  ")
            'qry.Append(" '' [Produccion], ")
            'qry.Append(" ISNULL(SUM( ")
            'qry.Append(" CASE WHEN PlannedQty > CmpltQty THEN  ")
            'qry.Append(" CONVERT(INTEGER,(PlannedQty - CmpltQty))  ")
            'qry.Append(" ELSE '0'  ")
            'qry.Append(" END),0) [Ensamble],  ")
            'qry.Append(" '' [Rol], ")
            'qry.Append(" '' [Campana], ")
            'qry.Append(" '' [Proyeccion], ")
            'qry.Append(" '' [DeudaEnsamble]     ")
            'qry.Append(" FROM SBOGuateplast.dbo.OWOR A2 WITH (NOLOCK) ")
            'qry.Append(" WHERE A2.ItemCode LIKE ('AR%')   ")
            'qry.Append(" AND A2.Status IN ('P','R')  ")
            'qry.Append(" AND A2.U_Tipo IN ('1','2','3','4') ")
            'qry.Append(" GROUP BY A2.ItemCode ")

            'qry.Append(" UNION ALL ")

            ''DEUDA ROL
            'qry.Append(" SELECT ")
            'qry.Append(" '' [DeLinea], ")
            'qry.Append(" b3.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            'qry.Append(" '' [NombreArticulo], ")
            'qry.Append(" '' [Color], ")
            'qry.Append(" '' [Stock], ")
            'qry.Append(" '' [StockMinimo], ")
            'qry.Append(" '' [StockMaximo],  ")
            'qry.Append(" '' [Produccion],   ")
            'qry.Append(" '' [Ensamble], ")
            'qry.Append(" ISNULL(CONVERT(INTEGER,SUM(B3.OpenQty)),0) [Rol],  ")
            'qry.Append(" '' [Campana], ")
            'qry.Append(" '' [Proyeccion], ")
            'qry.Append(" '' [DeudaEnsamble]  ")
            'qry.Append(" FROM SBOGuateplast.dbo.ORDR A3 WITH (NOLOCK, INDEX(ORDR_DOC_STATUS)) ")
            'qry.Append(" LEFT JOIN SBOGuateplast.dbo.RDR1 B3 WITH (NOLOCK, INDEX(RDR1_PRIMARY)) ON B3.DocEntry = A3.DocEntry   ")
            'qry.Append(" WHERE B3.LineStatus = 'O'  ")
            'qry.Append(" AND A3.DocStatus = 'O'  ")
            'qry.Append(" AND A3.CANCELED = 'N'  ")
            'qry.Append(" AND (A3.U_NameCamp IS NULL OR A3.U_NameCamp = '') ")
            'qry.Append(" GROUP BY B3.ItemCode ")

            'qry.Append(" UNION ALL ")


            'qry.Append(" SELECT ")
            ''DEUDA ROL
            'qry.Append(" '' [DeLinea], ")
            'qry.Append(" B.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            'qry.Append(" '' [NombreArticulo], ")
            'qry.Append(" '' [Color], ")
            'qry.Append(" '' [Stock], ")
            'qry.Append(" '' [StockMinimo], ")
            'qry.Append(" '' [StockMaximo],  ")
            'qry.Append(" '' [Produccion],   ")
            'qry.Append(" '' [Ensamble], ")
            'qry.Append(" CONVERT(INTEGER,SUM(B.OpenQty)) [Rol],  ")
            'qry.Append(" '' [Campana], ")
            'qry.Append(" '' [Proyeccion], ")
            'qry.Append(" '' [DeudaEnsamble]  ")
            'qry.Append(" FROM SBOGuateplast.dbo.OINV A WITH (NOLOCK, INDEX(OINV_STS_CNCL)) ")
            'qry.Append(" LEFT JOIN SBOGuateplast.DBO.INV1 B WITH (NOLOCK, INDEX(INV1_PRIMARY)) ON B.DocEntry = A.DocEntry ")
            'qry.Append(" WHERE A.isIns = 'Y' ")
            'qry.Append(" AND A.InvntSttus = 'O' ")
            'qry.Append(" GROUP BY B.ItemCode ")

            'qry.Append(" UNION ALL ")

            ''DEUDA CAMPANA
            'qry.Append(" SELECT  ")
            'qry.Append(" '' [DeLinea], ")
            'qry.Append(" b3.ItemCode  COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            'qry.Append(" '' [NombreArticulo], ")
            'qry.Append(" '' [Color], ")
            'qry.Append(" '' [Stock], ")
            'qry.Append(" '' [StockMinimo], ")
            'qry.Append(" '' [StockMaximo],  ")
            'qry.Append(" '' [Produccion],   ")
            'qry.Append(" '' [Ensamble], ")
            'qry.Append(" '' [Rol], ")
            'qry.Append(" ISNULL(CONVERT(INTEGER,SUM(B3.OpenQty)),0) [Campana], ")
            'qry.Append(" '' [Proyeccion], ")
            'qry.Append(" '' [DeudaEnsamble]   ")
            'qry.Append(" FROM SBOGuateplast.dbo.ORDR A3 WITH (NOLOCK, INDEX(ORDR_DOC_STATUS)) ")
            'qry.Append(" LEFT JOIN SBOGuateplast.dbo.RDR1 B3 WITH (NOLOCK , INDEX(RDR1_PRIMARY)) ON B3.DocEntry = A3.DocEntry   ")
            'qry.Append(" WHERE B3.LineStatus = 'O'  ")
            'qry.Append(" AND A3.DocStatus = 'O'  ")
            'qry.Append(" AND A3.CANCELED = 'N'  ")
            'qry.Append(" AND (A3.U_NameCamp IS NOT NULL AND A3.U_NameCamp > 1) ")
            'qry.Append(" GROUP BY B3.ItemCode ")

            'qry.Append(" UNION ALL ")

            ''DEUDA PROYECCION DE CAMPAÑA
            'qry.Append(" SELECT ")
            'qry.Append(" '' [DeLinea], ")
            'qry.Append(" CodigoArticulo [CodigoArticulo], ")
            'qry.Append(" '' [NombreArticulo], ")
            'qry.Append(" '' [Color], ")
            'qry.Append(" '' [Stock], ")
            'qry.Append(" '' [StockMinimo], ")
            'qry.Append(" '' [StockMaximo],  ")
            'qry.Append(" '' [Produccion],   ")
            'qry.Append(" '' [Ensamble], ")
            'qry.Append(" '' [Rol],  ")
            'qry.Append(" '' [Campana], ")
            'qry.Append(" CONVERT(INTEGER,SUM(CASE  ")
            'qry.Append(" WHEN Proyectado > Facturado   ")
            'qry.Append(" THEN (Proyectado - Facturado)  ")
            'qry.Append(" ELSE '0'  ")
            'qry.Append(" END))[Proyeccion],  ")
            'qry.Append(" '' [DeudaEnsamble]  ")
            'qry.Append(" FROM ")
            'qry.Append(" (SELECT  ")
            'qry.Append(" BB1.CodigoArticulo, ")
            'qry.Append(" BB1.Proyectado,  ")
            'qry.Append(" (	SELECT  ISNULL(CONVERT(INTEGER,SUM(A5.Quantity)),0) [Facturado]  ")
            'qry.Append(" FROM SBOGuateplast.dbo.INV1 A5 WITH (NOLOCK, INDEX(INV1_BASE_ENTRY)) ")
            'qry.Append(" LEFT JOIN SBOGuateplast.dbo.OINV B1 WITH (NOLOCK, INDEX(OINV_PRIMARY)) ON B1.DocEntry = A5.DocEntry   ")
            'qry.Append(" WHERE A5.BaseEntry IN  ( ")
            'qry.Append(" Select DISTINCT ")
            'qry.Append(" AA.DocEntry ")
            'qry.Append(" FROM SBOGuateplast.dbo.DLN1 AA WITH (NOLOCK, INDEX(DLN1_BASE_ENTRY))  ")
            'qry.Append(" WHERE AA.BaseEntry IN  ( ")
            'qry.Append(" SELECT DISTINCT AAA.DocEntry  ")
            'qry.Append(" FROM SBOGuateplast.dbo.ORDR AAA WITH (NOLOCK, INDEX(ORDR_DOC_STATUS)) ")
            'qry.Append(" LEFT JOIN SBOGuateplast.dbo.RDR1 BBB WITH (NOLOCK, INDEX(RDR1_ITM_WHS_SH)) ON BBB.DocEntry = AAA.DocEntry  ")
            'qry.Append(" WHERE AAA.U_NameCamp = AA1.Id COLLATE Latin1_General_CI_AI ")
            'qry.Append(" AND BBB.ItemCode  = BB1.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            'qry.Append(" AND AAA.CANCELED = 'N' ")
            'qry.Append(" AND AAA.DocDate > (GETDATE() - 1000) ")
            'qry.Append(" ) ")
            'qry.Append(" AND AA.ItemCode  = BB1.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            'qry.Append(" AND AA.TargetType <> '16' ")
            'qry.Append(" AND AA.DocDate > (GETDATE() - 1000) ")
            'qry.Append(" ) ")
            'qry.Append(" AND A5.ItemCode = BB1.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            'qry.Append(" AND A5.TargetType <> '14' ")
            'qry.Append(" AND B1.DocDate > (GETDATE() - 1000) ")
            'qry.Append(" ) [Facturado]  ")
            'qry.Append(" FROM Ventas.dbo.CAM_Encabezado AA1 WITH (NOLOCK) ")
            'qry.Append(" LEFT JOIN Ventas.dbo.CAM_Detalle BB1 WITH (NOLOCK) ON BB1.Id = AA1.Id COLLATE SQL_Latin1_General_CP850_CI_AS   ")
            'qry.Append(" WHERE FechaFinal > GETDATE() ")
            'qry.Append(" AND LEN(AA1.Id) < 8  ")
            'qry.Append(" AND AA1.Distribuidor = '0' ")
            'qry.Append(" ) [QRY] ")
            'qry.Append(" GROUP BY CodigoArticulo ")

            'qry.Append(" UNION ALL ")

            ''PRODUCCIONES
            'qry.Append(" SELECT ")
            'qry.Append(" '' [DeLinea], ")
            'qry.Append(" B2.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            'qry.Append(" '' [NombreArticulo], ")
            'qry.Append(" '' [Color], ")
            'qry.Append(" '' [Stock], ")
            'qry.Append(" '' [StockMinimo], ")
            'qry.Append(" '' [StockMaximo], ")
            'qry.Append(" '' [Produccion], ")
            'qry.Append(" '' [Ensamble], ")
            'qry.Append(" '' [Rol], ")
            'qry.Append(" '' [Campana], ")
            'qry.Append(" '' [Proyeccion], ")
            'qry.Append(" ISNULL(SUM( ")
            'qry.Append(" CASE WHEN B2.PlannedQty > (CmpltQty * B2.BaseQty) THEN  ")
            'qry.Append(" CONVERT(INTEGER,(B2.PlannedQty - (CmpltQty * B2.BaseQty)))  ")
            'qry.Append(" ELSE '0'  ")
            'qry.Append(" END),0) [DeudaEnsamble]  ")
            'qry.Append(" FROM SBOGuateplast.dbo.OWOR A2 WITH (NOLOCK,INDEX(OWOR_PRIMARY)) ")
            'qry.Append(" LEFT JOIN SBOGuateplast.dbo.WOR1 B2 WITH (NOLOCK, INDEX(WOR1_PRIMARY)) ON B2.DocEntry = A2.DocEntry ")
            'qry.Append(" WHERE B2.ItemCode LIKE ('AR%')  ")
            'qry.Append(" AND A2.Status IN ('P','R')  ")
            'qry.Append(" AND A2.U_Tipo IN ('0','1','2','3','4') ")
            'qry.Append(" GROUP BY B2.ItemCode ")

            'qry.Append(" ) QRY1  ")
            ''FIN DE UNION DE SELECT

            'qry.Append(" GROUP BY CodigoArticulo  ")
            ''FIN DE AGRUPADO
            'qry.Append(" ) QRY2  ")

            qry.Append(" SELECT ")
            qry.Append(" DeLinea, ")
            qry.Append(" CodigoArticulo, ")
            qry.Append(" NombreArticulo, ")
            qry.Append(" Color, ")
            qry.Append(" Stock, ")
            qry.Append(" Produccion, ")
            qry.Append(" Ensamble, ")
            qry.Append(" TotalPositivo, ")
            qry.Append(" Rol, ")
            qry.Append(" Campana, ")
            qry.Append(" Proyeccion, ")
            qry.Append(" DeudaEnsamble, ")
            qry.Append(" TotalNegativo, ")
            qry.Append(" Disponible, ")
            qry.Append(" Sugerido, ")
            qry.Append(" StockMinimo, ")
            qry.Append(" StockMaximo ")

            qry.Append(" FROM( ")
            '--INICIO AGRUPADO
            qry.Append(" SELECT  ")
            qry.Append(" MAX(DeLinea)[DeLinea], ")
            qry.Append(" CodigoArticulo, ")
            qry.Append(" MAX(NombreArticulo) [NombreArticulo], ")
            qry.Append(" MAX(Color) [Color], ")
            qry.Append(" SUM(Stock)[Stock], ")
            qry.Append(" SUM(Produccion)[Produccion], ")
            qry.Append(" SUM(Ensamble)[Ensamble], ")
            qry.Append(" SUM(Stock)+ SUM(Produccion) + SUM(Ensamble) [TotalPositivo], ")
            qry.Append(" SUM(Rol) [Rol], ")
            qry.Append(" SUM(Campana) [Campana], ")
            qry.Append(" SUM(Proyeccion)[Proyeccion], ")
            qry.Append(" SUM(DeudaEnsamble)[DeudaEnsamble], ")
            qry.Append(" CASE  ")
            qry.Append(" WHEN SUM(Campana) > SUM(Proyeccion) THEN ")
            qry.Append(" SUM(ROL) + SUM(Campana) + SUM(DeudaEnsamble)  ")
            qry.Append(" ELSE ")
            qry.Append(" SUM(ROL) + SUM(Proyeccion) + SUM(DeudaEnsamble)  ")
            qry.Append(" End ")
            qry.Append(" [TotalNegativo], ")
            qry.Append(" (SUM(Stock)+ SUM(Produccion) + SUM(Ensamble)) - (SUM(ROL) + SUM(Campana) + SUM(DeudaEnsamble)) [Disponible], ")
            qry.Append(" CASE WHEN  ")
            qry.Append(" SUM(StockMaximo) > 1 THEN ")
            qry.Append(" SUM(StockMaximo) - ((SUM(Stock)+ SUM(Produccion) + SUM(Ensamble)) - (SUM(ROL) + SUM(Campana) + SUM(Proyeccion) + SUM(DeudaEnsamble))) ELSE '0' END [Sugerido], ")
            qry.Append(" SUM(StockMinimo) [StockMinimo], ")
            qry.Append(" SUM(StockMaximo)[StockMaximo] ")
            qry.Append(" FROM ")
            '--INICIO UNION DE SELECT
            qry.Append(" (SELECT   ")
            qry.Append(" CASE  ")
            qry.Append(" WHEN A1.U_NoDeLinea = '0' THEN 'SI' WHEN A1.U_NoDeLinea = '1' THEN 'NO' END [DeLinea],  ")
            qry.Append(" UPPER(A1.ItemCode) [CodigoArticulo],  ")
            qry.Append(" UPPER(A1.ItemName) [NombreArticulo],  ")
            qry.Append(" UPPER(A1.U_Color) [Color],  ")
            qry.Append(" CONVERT(INTEGER,ISNULL(A1.OnHand,0)) [Stock], ")
            qry.Append(" CONVERT(INTEGER,A1.MinLevel) [StockMinimo],  ")
            qry.Append(" CONVERT(INTEGER, A1.MaxLevel) [StockMaximo], ")
            qry.Append(" '' [Produccion] , ")
            qry.Append(" '' [Ensamble], ")
            qry.Append(" '' [Rol], ")
            qry.Append(" '' [Campana], ")
            qry.Append(" '' [Proyeccion], ")
            qry.Append(" '' [DeudaEnsamble]   ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM A1 WITH (NOLOCK, INDEX(OITM_PRIMARY)) ")
            qry.Append(" WHERE A1.ItemCode LIKE ('AR%')  ")
            qry.Append(" AND LEN(A1.ItemCode) > 8 ")
            qry.Append(" UNION ALL ")
            '--PRODUCCIONES
            qry.Append(" SELECT  ")
            qry.Append(" '' [DeLinea], ")
            qry.Append(" A2.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            qry.Append("             '' [NombreArticulo], ")
            qry.Append(" '' [Color], ")
            qry.Append(" '' [Stock], ")
            qry.Append(" '' [StockMinimo], ")
            qry.Append(" '' [StockMaximo], ")
            qry.Append(" ISNULL(SUM( ")
            qry.Append(" CASE WHEN PlannedQty > CmpltQty THEN  ")
            qry.Append(" CONVERT(INTEGER,(PlannedQty - CmpltQty))  ")
            qry.Append(" ELSE '0'  ")
            qry.Append(" END),0) [Produccion], ")
            qry.Append(" '' [Ensamble], ")
            qry.Append(" '' [Rol], ")
            qry.Append(" '' [Campana], ")
            qry.Append(" '' [Proyeccion], ")
            qry.Append(" '' [DeudaEnsamble]   ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A2 WITH (NOLOCK) ")
            qry.Append(" WHERE A2.ItemCode LIKE ('AR%')  ")
            qry.Append(" AND A2.Status IN ('P','R')  ")
            qry.Append(" AND A2.U_Tipo IN ('0') ")
            qry.Append(" GROUP BY A2.ItemCode ")
            qry.Append(" UNION ALL ")
            '--ENSAMBLES
            qry.Append(" SELECT ")
            qry.Append(" '' [DeLinea], ")
            qry.Append(" A2.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            qry.Append(" '' [NombreArticulo], ")
            qry.Append(" '' [Color], ")
            qry.Append(" '' [Stock], ")
            qry.Append(" '' [StockMinimo], ")
            qry.Append(" '' [StockMaximo],  ")
            qry.Append(" '' [Produccion], ")
            qry.Append(" ISNULL(SUM( ")
            qry.Append(" CASE WHEN PlannedQty > CmpltQty THEN  ")
            qry.Append(" CONVERT(INTEGER,(PlannedQty - CmpltQty))  ")
            qry.Append(" ELSE '0'  ")
            qry.Append(" END),0) [Ensamble],  ")
            qry.Append(" '' [Rol], ")
            qry.Append(" '' [Campana], ")
            qry.Append(" '' [Proyeccion], ")
            qry.Append(" '' [DeudaEnsamble]     ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A2 WITH (NOLOCK) ")
            qry.Append(" WHERE A2.ItemCode LIKE ('AR%')   ")
            qry.Append(" AND A2.Status IN ('P','R')  ")
            qry.Append(" AND A2.U_Tipo IN ('1','2','3','4') ")
            qry.Append(" GROUP BY A2.ItemCode ")
            qry.Append(" UNION ALL ")
            '--DEUDA ROL
            qry.Append(" SELECT ")
            qry.Append(" '' [DeLinea], ")
            qry.Append(" b3.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            qry.Append(" '' [NombreArticulo], ")
            qry.Append(" '' [Color], ")
            qry.Append(" '' [Stock], ")
            qry.Append(" '' [StockMinimo], ")
            qry.Append(" '' [StockMaximo],  ")
            qry.Append(" '' [Produccion],   ")
            qry.Append(" '' [Ensamble], ")
            qry.Append(" ISNULL(CONVERT(INTEGER,SUM(B3.OpenQty)),0) [Rol],  ")
            qry.Append(" '' [Campana], ")
            qry.Append(" '' [Proyeccion], ")
            qry.Append(" '' [DeudaEnsamble]  ")
            qry.Append(" FROM SBOGuateplast.dbo.ORDR A3 WITH (NOLOCK, INDEX(ORDR_DOC_STATUS)) ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.RDR1 B3 WITH (NOLOCK, INDEX(RDR1_PRIMARY)) ON B3.DocEntry = A3.DocEntry  ")
            qry.Append(" WHERE B3.LineStatus = 'O'  ")
            qry.Append(" AND A3.DocStatus = 'O'  ")
            qry.Append(" AND A3.CANCELED = 'N'  ")
            qry.Append(" AND ISNULL(A3.U_NameCamp,'') = '' ")
            qry.Append(" GROUP BY B3.ItemCode ")

            qry.Append(" UNION ALL ")


            qry.Append(" SELECT  ")
            '--DEUDA ROL
            qry.Append(" '' [DeLinea], ")
            qry.Append(" B.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            qry.Append(" '' [NombreArticulo], ")
            qry.Append(" '' [Color], ")
            qry.Append(" '' [Stock], ")
            qry.Append(" '' [StockMinimo], ")
            qry.Append(" '' [StockMaximo],  ")
            qry.Append(" '' [Produccion],   ")
            qry.Append(" '' [Ensamble], ")
            qry.Append(" CONVERT(INTEGER,SUM(B.OpenQty)) [Rol],  ")
            qry.Append(" '' [Campana], ")
            qry.Append(" '' [Proyeccion], ")
            qry.Append(" '' [DeudaEnsamble]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OINV A WITH (NOLOCK, INDEX(OINV_STS_CNCL)) ")
            qry.Append(" LEFT JOIN SBOGuateplast.DBO.INV1 B WITH (NOLOCK, INDEX(INV1_PRIMARY)) ON B.DocEntry = A.DocEntry ")
            qry.Append(" WHERE A.isIns = 'Y' ")
            qry.Append(" AND A.InvntSttus = 'O' ")
            qry.Append(" GROUP BY B.ItemCode ")

            qry.Append(" UNION ALL ")
            '--DEUDA CAMPANA
            qry.Append(" SELECT   ")
            qry.Append(" '' [DeLinea], ")
            qry.Append(" b3.ItemCode  COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            qry.Append(" '' [NombreArticulo], ")
            qry.Append(" '' [Color], ")
            qry.Append(" '' [Stock], ")
            qry.Append(" '' [StockMinimo], ")
            qry.Append(" '' [StockMaximo],  ")
            qry.Append(" '' [Produccion],   ")
            qry.Append(" '' [Ensamble], ")
            qry.Append(" '' [Rol], ")
            qry.Append(" ISNULL(CONVERT(INTEGER,SUM(B3.OpenQty)),0) [Campana], ")
            qry.Append(" '' [Proyeccion], ")
            qry.Append(" '' [DeudaEnsamble]   ")
            qry.Append(" FROM SBOGuateplast.dbo.ORDR A3 WITH (NOLOCK, INDEX(ORDR_DOC_STATUS)) ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.RDR1 B3 WITH (NOLOCK , INDEX(RDR1_PRIMARY)) ON B3.DocEntry = A3.DocEntry  ")
            qry.Append(" WHERE B3.LineStatus = 'O'  ")
            qry.Append(" AND A3.DocStatus = 'O'  ")
            qry.Append(" AND A3.CANCELED = 'N'  ")
            qry.Append(" AND (A3.U_NameCamp IS NOT NULL AND A3.U_NameCamp > 1) ")
            qry.Append(" GROUP BY B3.ItemCode ")

            qry.Append(" UNION ALL ")
            '-- DEUDA PROYECCION DE CAMPAÑA
            qry.Append(" SELECT ")
            qry.Append(" '' [DeLinea], ")
            qry.Append(" CodigoArticulo [CodigoArticulo], ")
            qry.Append(" '' [NombreArticulo], ")
            qry.Append(" '' [Color], ")
            qry.Append(" '' [Stock], ")
            qry.Append(" '' [StockMinimo], ")
            qry.Append(" '' [StockMaximo],  ")
            qry.Append(" '' [Produccion],   ")
            qry.Append(" '' [Ensamble], ")
            qry.Append(" '' [Rol],  ")
            qry.Append(" '' [Campana], ")
            qry.Append(" CONVERT(INTEGER,SUM(CASE  ")
            qry.Append(" WHEN Proyectado > Facturado   ")
            qry.Append(" THEN (Proyectado - Facturado)  ")
            qry.Append(" ELSE '0'  ")
            qry.Append(" END))[Proyeccion],  ")
            qry.Append(" '' [DeudaEnsamble]  ")
            qry.Append(" FROM ")
            qry.Append(" (SELECT  ")
            qry.Append(" BB1.CodigoArticulo, ")
            qry.Append(" BB1.Proyectado,  ")
            qry.Append(" ( SELECT  ISNULL(CONVERT(INTEGER,SUM(A5.Quantity)),0) [Facturado]  ")
            qry.Append(" FROM SBOGuateplast.dbo.INV1 A5 WITH (NOLOCK, INDEX(INV1_BASE_ENTRY)) ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OINV B1 WITH (NOLOCK, INDEX(OINV_PRIMARY)) ON B1.DocEntry = A5.DocEntry  ")
            qry.Append(" WHERE A5.BaseEntry IN  ( ")
            qry.Append(" Select DISTINCT ")
            qry.Append(" AA.DocEntry ")
            qry.Append(" FROM SBOGuateplast.dbo.DLN1 AA WITH (NOLOCK, INDEX(DLN1_BASE_ENTRY)) ")
            qry.Append(" WHERE AA.BaseEntry IN   ")
            qry.Append(" ( ")
            qry.Append(" SELECT DISTINCT AAA.DocEntry  ")
            qry.Append(" FROM SBOGuateplast.dbo.ORDR AAA WITH (NOLOCK, INDEX(ORDR_DATE_PIND)) ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.RDR1 BBB WITH (NOLOCK, INDEX(RDR1_ITM_WHS_SH)) ON BBB.DocEntry = AAA.DocEntry  ")
            qry.Append(" WHERE AAA.U_NameCamp = AA1.Id COLLATE Latin1_General_CI_AI ")
            qry.Append(" AND BBB.ItemCode  = BB1.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            qry.Append(" AND AAA.CANCELED = 'N' ")
            qry.Append(" AND AAA.DocDate >= (GETDATE() - 200) ")
            qry.Append(" ) ")
            qry.Append(" AND AA.ItemCode  = BB1.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            qry.Append(" AND AA.TargetType <> '16' ")
            qry.Append(" AND AA.DocDate >= (GETDATE() - 200) ")
            qry.Append(" ) ")
            qry.Append(" AND A5.ItemCode = BB1.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            qry.Append(" AND A5.TargetType <> '14' ")
            qry.Append(" AND B1.DocDate >= (GETDATE() - 200) ")
            qry.Append(" ) [Facturado]  ")
            qry.Append(" FROM Ventas.dbo.CAM_Encabezado AA1 WITH (NOLOCK) ")
            qry.Append(" LEFT JOIN Ventas.dbo.CAM_Detalle BB1 WITH (NOLOCK) ON BB1.Id = AA1.Id COLLATE SQL_Latin1_General_CP850_CI_AS   ")
            qry.Append(" WHERE FechaFinal > GETDATE() ")
            qry.Append(" AND LEN(AA1.Id) < 8  ")
            qry.Append(" AND AA1.Distribuidor = '0' ")
            qry.Append(" ) [QRY] ")
            qry.Append(" GROUP BY CodigoArticulo ")

            qry.Append(" UNION ALL ")
            '--PRODUCCIONES
            qry.Append(" SELECT  ")
            qry.Append(" '' [DeLinea], ")
            qry.Append(" B2.ItemCode COLLATE DATABASE_DEFAULT [CodigoArticulo], ")
            qry.Append(" '' [NombreArticulo], ")
            qry.Append(" '' [Color], ")
            qry.Append(" '' [Stock], ")
            qry.Append(" '' [StockMinimo], ")
            qry.Append(" '' [StockMaximo], ")
            qry.Append(" '' [Produccion], ")
            qry.Append(" '' [Ensamble], ")
            qry.Append(" '' [Rol], ")
            qry.Append(" '' [Campana], ")
            qry.Append(" '' [Proyeccion], ")
            qry.Append(" ISNULL(SUM( ")
            qry.Append(" CASE WHEN B2.PlannedQty > (CmpltQty * B2.BaseQty) THEN  ")
            qry.Append(" CONVERT(INTEGER,(B2.PlannedQty - (CmpltQty * B2.BaseQty))) ")
            qry.Append(" ELSE '0'  ")
            qry.Append(" END),0) [DeudaEnsamble]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A2 WITH (NOLOCK,INDEX(OWOR_PRIMARY)) ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.WOR1 B2 WITH (NOLOCK, INDEX(WOR1_PRIMARY)) ON B2.DocEntry = A2.DocEntry ")
            qry.Append(" WHERE B2.ItemCode LIKE ('AR%')  ")
            qry.Append(" AND A2.Status IN ('P','R')  ")
            qry.Append(" AND A2.U_Tipo IN ('0','1','2','3','4') ")
            qry.Append(" GROUP BY B2.ItemCode ")

            qry.Append(" ) QRY1  ")
            '--FIN DE UNION DE SELECT
            qry.Append(" GROUP BY CodigoArticulo ")
            '--FIN DE AGRUPADO
            qry.Append(" ) QRY2 ")

            'FILTROS

            qry.Append(" WHERE CodigoArticulo IN (" + pCodigoArticulo + ")")

            'qry.Append(" ORDER BY CodigoArticulo ASC ")



            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function





    'Public Function GET_AnalisisArticulos_XFiltro(ByVal pDeLinea As String, ByVal pColor As String, ByVal pCodigoArticulo As String, ByVal pCodigoArticuloInicial As String, ByVal pCodigoArticuloFinal As String, _
    '                                              ByVal pStockMenorMinimo As Boolean, ByVal pMayorStock As Integer, ByVal pMenorStock As Integer, ByVal pCampana As String, ByVal pCodigoCliente As String, _
    '                                              ByVal pMayorDeudaRol As Integer, ByVal pMayorDeudaCampana As Integer, ByVal pMayorDeudaProyeccion As Integer) As DataTable
    '    Dim qry As String = String.Empty
    '    'Dim qry As StringBuilder

    '    Dim dt As New DataTable("dtAnalisisArticulos")

    '    Try
    '        'qry.Append(" SELECT ")
    '        'qry.Append(" DeLinea,")
    '        qry = " SELECT"
    '        qry += " DeLinea,"
    '        qry += " CodigoArticulo,"
    '        qry += " NombreArticulo,"
    '        qry += " Color,"
    '        qry += " Stock,"
    '        qry += " Ensamble,"
    '        qry += " Produccion,"
    '        qry += " DeudaRol,"
    '        qry += " DeudaCampana,"
    '        qry += " DeudaProyeccion,"
    '        qry += " StockMinimo,"
    '        qry += " StockMaximo"
    '        qry += " FROM (SELECT  "
    '        qry += " CASE "
    '        qry += " WHEN A1.U_NoDeLinea = '0' THEN 'SI' "
    '        qry += " WHEN A1.U_NoDeLinea = '1' THEN 'NO' "
    '        qry += " END [DeLinea], "
    '        qry += " UPPER(A1.ItemCode) [CodigoArticulo], "
    '        qry += " UPPER(A1.ItemName) [NombreArticulo], "
    '        qry += " UPPER(A1.U_Color) [Color], "
    '        qry += " CONVERT(INTEGER,ISNULL(A1.OnHand,0)) [Stock], "
    '        qry += " (SELECT "
    '        qry += " ISNULL(SUM("
    '        qry += " CASE "
    '        qry += " WHEN PlannedQty > CmpltQty  THEN CONVERT(INTEGER,(PlannedQty - CmpltQty)) "
    '        qry += " ELSE '0' "
    '        qry += " END),0) [Diferencia] "
    '        qry += " FROM SBOGuateplast.dbo.OWOR A2 "
    '        qry += " WHERE A2.ItemCode = A1.ItemCode"
    '        qry += " AND A2.Status IN ('P','R') "
    '        qry += " AND A2.U_Tipo IN ('1','2','3','4')) [Ensamble], "

    '        qry += " (SELECT "
    '        qry += " ISNULL(SUM("
    '        qry += " CASE "
    '        qry += " WHEN PlannedQty > CmpltQty  "
    '        qry += " THEN CONVERT(INTEGER,(PlannedQty - CmpltQty)) "
    '        qry += " ELSE '0' "
    '        qry += " END),0) [Diferencia] "
    '        qry += " FROM SBOGuateplast.dbo.OWOR A2 "
    '        qry += " WHERE A2.ItemCode = A1.ItemCode AND A2.Status IN ('P','R') AND A2.U_Tipo IN ('0')"
    '        qry += " ) [Produccion], "

    '        qry += " (SELECT  "
    '        qry += " ISNULL(CONVERT(INTEGER,SUM(B3.OpenQty)),0) [DeudaRol] "
    '        qry += " FROM SBOGuateplast.dbo.ORDR A3 "
    '        qry += " LEFT JOIN SBOGuateplast.dbo.RDR1 B3 ON B3.DocEntry = A3.DocEntry "
    '        qry += " WHERE B3.ItemCode = A1.ItemCode"
    '        qry += " AND B3.LineStatus = 'O' "
    '        qry += " AND A3.DocStatus = 'O' "
    '        qry += " AND A3.CANCELED = 'N' "
    '        qry += " AND A3.U_NameCamp IS NULL"
    '        qry += " ) [DeudaRol], "

    '        qry += " (SELECT  "
    '        qry += " ISNULL(CONVERT(INTEGER,SUM(B3.OpenQty)),0) [DeudaCampana] "
    '        qry += " FROM SBOGuateplast.dbo.ORDR A3 "
    '        qry += " LEFT JOIN SBOGuateplast.dbo.RDR1 B3 ON B3.DocEntry = A3.DocEntry "
    '        qry += " WHERE B3.ItemCode = A1.ItemCode"
    '        qry += " AND B3.LineStatus = 'O' "
    '        qry += " AND A3.DocStatus = 'O' "
    '        qry += " AND A3.CANCELED = 'N' "
    '        qry += " AND A3.U_NameCamp <> ''"
    '        qry += " ) [DeudaCampana], "

    '        qry += " ISNULL((SELECT SUM("
    '        qry += " CASE "
    '        qry += " WHEN Proyectado > Facturado  THEN (Proyectado - Facturado) "
    '        qry += " ELSE '0' "
    '        qry += " END) [DeudaProyeccion] "
    '        qry += " FROM (SELECT BB1.Proyectado, ("
    '        qry += " SELECT  ISNULL(CONVERT(INTEGER,SUM(A5.Quantity)),0"
    '        qry += " ) [Facturado] "
    '        qry += " FROM SBOGuateplast.dbo.INV1 A5 "
    '        qry += " LEFT JOIN SBOGuateplast.dbo.OINV B1 ON B1.DocEntry = A5.DocEntry "
    '        qry += " WHERE A5.BaseEntry IN  ("
    '        qry += " Select DISTINCT"
    '        qry += " AA.DocEntry"
    '        qry += " FROM SBOGuateplast.dbo.DLN1 AA "
    '        qry += " WHERE AA.BaseEntry IN  ("
    '        qry += " SELECT DISTINCT AAA.DocEntry "
    '        qry += " FROM SBOGuateplast.dbo.ORDR AAA "
    '        qry += " LEFT JOIN SBOGuateplast.dbo.RDR1 BBB ON BBB.DocEntry = AAA.DocEntry "
    '        qry += " WHERE AAA.U_NameCamp COLLATE SQL_Latin1_General_CP850_CI_AS = AA1.Id "
    '        qry += " AND BBB.ItemCode = A1.ItemCode "
    '        qry += " AND AAA.CANCELED = 'N') "
    '        qry += " AND AA.ItemCode = A1.ItemCode "
    '        qry += " AND AA.TargetType <> '16') "
    '        qry += " AND A5.ItemCode = A1.ItemCode "
    '        qry += " AND A5.TargetType <> '14') [Facturado] "
    '        qry += " FROM Ventas.dbo.CAM_Encabezado AA1 "
    '        qry += " LEFT JOIN Ventas.dbo.CAM_Detalle BB1 ON BB1.Id = AA1.Id  "
    '        qry += " WHERE FechaFinal > GETDATE()"
    '        qry += " AND LEN(AA1.Id) < 8 "
    '        qry += " AND AA1.Distribuidor = '0' "
    '        qry += " AND BB1.CodigoArticulo = A1.ItemCode COLLATE SQL_Latin1_General_CP850_CI_AS) [Qry2]),0"
    '        qry += " ) [DeudaProyeccion], "

    '        qry += " CONVERT(INTEGER,A1.MinLevel) [StockMinimo], "
    '        qry += " Convert(Integer, A1.MaxLevel) [StockMaximo]"
    '        qry += " FROM SBOGuateplast.dbo.OITM A1 "
    '        qry += " WHERE A1.ItemCode LIKE ('AR%') "
    '        qry += " AND LEN(A1.ItemCode) > 8"
    '        qry += " ) [QRY1]"

    '        qry += " WHERE CodigoArticulo LIKE ('AR%')"

    '        If Not pDeLinea = String.Empty Then : qry += " AND DeLinea = '" + pDeLinea + "'" : End If
    '        If Not pColor = String.Empty Then : qry += " AND Color = '" + pColor + "'" : End If

    '        If Not pCodigoArticulo = String.Empty Then : qry += " AND CodigoArticulo LIKE ('" + pCodigoArticulo + "%')" : End If
    '        If Not pCodigoArticuloInicial = String.Empty And Not pCodigoArticuloFinal = String.Empty Then : qry += " AND CodigoArticulo BETWEEN  '" + pCodigoArticuloInicial + "' AND (select MAX(itemcode) from SBOGuateplast.dbo.OITM where ItemCode like '" + pCodigoArticuloFinal + "%')" : End If
    '        'If Not pCodigoArticuloInicial = String.Empty And Not pCodigoArticuloFinal = String.Empty Then : qry += " AND CodigoArticulo BETWEEN  '" + pCodigoArticuloInicial + "' AND '" + pCodigoArticuloFinal + "'" : End If
    '        If pStockMenorMinimo = True Then : qry += " AND Stock < StockMinimo" : End If
    '        If Not pMayorStock = 0 Then : qry += " AND Stock > '" + pMayorStock.ToString + "'" : End If
    '        If Not pMenorStock = 0 Then : qry += " AND Stock < '" + pMenorStock.ToString + "'" : End If
    '        If Not pCampana = String.Empty Then : qry += " AND CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS IN (SELECT CodigoArticulo FROM Ventas.dbo.CAM_Detalle WHERE Id = ('" + pCampana + "'))" : End If

    '        If Not pCodigoCliente = String.Empty Then
    '            qry += " AND CodigoArticulo IN (SELECT DISTINCT B3.ItemCode  "
    '            qry += " FROM SBOGuateplast.dbo.ORDR A3 "
    '            qry += " LEFT JOIN SBOGuateplast.dbo.RDR1 B3 ON B3.DocEntry = A3.DocEntry "
    '            qry += " WHERE A3.CardCode = '" + pCodigoCliente + "' AND B3.LineStatus = 'O' AND A3.DocStatus = 'O' AND A3.CANCELED = 'N')"
    '        End If

    '        'If Not pMayorDeudaRol = 0 And Not pMayorDeudaCampana = 0 And Not pMayorDeudaProyeccion = 0 Then
    '        If pMayorDeudaRol > 0 And pMayorDeudaCampana = 0 And pMayorDeudaProyeccion = 0 Then : qry += " AND DeudaRol > '" + pMayorDeudaRol.ToString + "'" : End If
    '        If pMayorDeudaRol = 0 And pMayorDeudaCampana > 0 And pMayorDeudaProyeccion = 0 Then : qry += " AND DeudaCampana > '" + pMayorDeudaCampana.ToString + "'" : End If
    '        If pMayorDeudaRol = 0 And pMayorDeudaCampana = 0 And pMayorDeudaProyeccion > 0 Then : qry += " AND DeudaProyeccion > '" + pMayorDeudaProyeccion.ToString + "'" : End If

    '        If pMayorDeudaRol > 0 And pMayorDeudaCampana > 0 And pMayorDeudaProyeccion = 0 Then : qry += " AND (DeudaRol >= '" + pMayorDeudaRol.ToString + "' OR DeudaCampana >= '" + pMayorDeudaCampana.ToString + "')" : End If
    '        If pMayorDeudaRol > 0 And pMayorDeudaCampana = 0 And pMayorDeudaProyeccion > 0 Then : qry += " AND (DeudaRol >= '" + pMayorDeudaRol.ToString + "' OR DeudaProyeccion >= '" + pMayorDeudaProyeccion.ToString + "')" : End If
    '        If pMayorDeudaRol = 0 And pMayorDeudaCampana > 0 And pMayorDeudaProyeccion > 0 Then : qry += " AND (DeudaCampana >= '" + pMayorDeudaCampana.ToString + "' OR DeudaProyeccion >= '" + pMayorDeudaProyeccion.ToString + "')" : End If

    '        If pMayorDeudaRol > 0 And pMayorDeudaCampana > 0 And pMayorDeudaProyeccion > 0 Then : qry += " AND (DeudaRol >= '" + pMayorDeudaRol.ToString + "' OR DeudaCampana >=  '" + pMayorDeudaCampana.ToString + "' OR DeudaProyeccion >= '" + pMayorDeudaProyeccion.ToString + "')" : End If

    '        'End If

    '        'qry += " ORDER BY CodigoArticulo ASC"


    '        'If Not pMayorDeudaRol = 0 Then : qry += " AND DeudaRol > '" + pMayorDeudaRol.ToString + "'" : End If
    '        'If Not pMayorDeudaCampana = 0 Then : qry += " AND DeudaCampana > '" + pMayorDeudaCampana.ToString + "'" : End If
    '        'If Not pMayorDeudaProyeccion = 0 Then : qry += " AND DeudaProyeccion > '" + pMayorDeudaProyeccion.ToString + "'" : End If


    '        dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

    '        Return dt

    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message)
    '        Return Nothing
    '    End Try
    'End Function

    Public Function GET_AnalisisArticulos_XFiltro(ByVal pCodigosArticulos As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtAnalisisArticulos")

        Try
            'qry = " SELECT "
            'qry += " CASE"
            'qry += " WHEN A1.U_NoDeLinea = '0' THEN 'SI'"
            'qry += " WHEN A1.U_NoDeLinea = '1' THEN 'NO'"
            'qry += " END [DeLinea],"
            'qry += " UPPER(A1.ItemCode) [CodigoArticulo],"
            'qry += " UPPER(A1.ItemName) [NombreArticulo],"
            'qry += " CONVERT(INTEGER,ISNULL(A1.OnHand,0)) [Stock],"

            'qry += " (SELECT"
            'qry += " ISNULL(SUM(CASE"
            'qry += " WHEN PlannedQty > CmpltQty "
            'qry += " THEN CONVERT(INTEGER,(PlannedQty - CmpltQty))"
            'qry += " ELSE '0'"
            'qry += " END),0) [Diferencia]"
            'qry += " FROM SBOGuateplast.dbo.OWOR A2"
            'qry += " WHERE A2.ItemCode = A1.ItemCode"
            'qry += " AND A2.Status IN ('P','R')"
            'qry += " AND A2.U_Tipo IN ('1','2','3','4')) [Ensamble],"

            'qry += " (SELECT"
            'qry += " ISNULL(SUM(CASE"
            'qry += " WHEN PlannedQty > CmpltQty "
            'qry += " THEN CONVERT(INTEGER,(PlannedQty - CmpltQty))"
            'qry += " ELSE '0'"
            'qry += " END),0) [Diferencia]"
            'qry += " FROM SBOGuateplast.dbo.OWOR A2"
            'qry += " WHERE A2.ItemCode = A1.ItemCode"
            'qry += " AND A2.Status IN ('P','R')"
            'qry += " AND A2.U_Tipo IN ('0')) [Produccion],"

            'qry += " (SELECT "
            'qry += " ISNULL(CONVERT(INTEGER,SUM(B3.OpenQty)),0) [DeudaRol]"
            'qry += " FROM SBOGuateplast.dbo.ORDR A3"
            'qry += " LEFT JOIN SBOGuateplast.dbo.RDR1 B3 ON B3.DocEntry = A3.DocEntry"
            'qry += " WHERE B3.ItemCode = A1.ItemCode"
            'qry += " AND B3.LineStatus = 'O'"
            'qry += " AND A3.DocStatus = 'O'"
            'qry += " AND A3.CANCELED = 'N'"
            'qry += " AND (A3.U_NameCamp IS NULL or A3.U_NameCamp = '')) [DeudaRol],"

            'qry += " (SELECT "
            'qry += " ISNULL(CONVERT(INTEGER,SUM(B3.OpenQty)),0) [DeudaRol]"
            'qry += " FROM SBOGuateplast.dbo.ORDR A3"
            'qry += " LEFT JOIN SBOGuateplast.dbo.RDR1 B3 ON B3.DocEntry = A3.DocEntry"
            'qry += " WHERE B3.ItemCode = A1.ItemCode"
            'qry += " AND B3.LineStatus = 'O'"
            'qry += " AND A3.DocStatus = 'O'"
            'qry += " AND A3.CANCELED = 'N'"
            'qry += " AND A3.U_NameCamp <> '') [DeudaCampana],"

            'qry += " ISNULL((SELECT"
            'qry += " SUM(CASE"
            'qry += " WHEN Proyectado > Facturado "
            'qry += " THEN (Proyectado - Facturado)"
            'qry += " ELSE '0'"
            'qry += " END) [DeudaProyeccion]"
            'qry += " FROM"
            'qry += " (SELECT"
            'qry += " BB1.Proyectado,"
            'qry += " (SELECT "
            'qry += " ISNULL(CONVERT(INTEGER,SUM(A5.Quantity)),0) [Facturado]"
            'qry += " FROM SBOGuateplast.dbo.INV1 A5"
            'qry += " LEFT JOIN SBOGuateplast.dbo.OINV B1 ON B1.DocEntry = A5.DocEntry"
            'qry += " WHERE A5.BaseEntry IN "
            'qry += " (SELECT DISTINCT AA.DocEntry"
            'qry += " FROM SBOGuateplast.dbo.DLN1 AA"
            'qry += " WHERE AA.BaseEntry IN "
            'qry += " (SELECT DISTINCT AAA.DocEntry"
            'qry += " FROM SBOGuateplast.dbo.ORDR AAA"
            'qry += " LEFT JOIN SBOGuateplast.dbo.RDR1 BBB ON BBB.DocEntry = AAA.DocEntry"
            'qry += " WHERE AAA.U_NameCamp COLLATE SQL_Latin1_General_CP850_CI_AS = AA1.Id"
            'qry += " AND BBB.ItemCode = A1.ItemCode"
            'qry += " AND AAA.CANCELED = 'N')"
            'qry += " AND AA.ItemCode = A1.ItemCode"
            'qry += " AND AA.TargetType <> '16')"
            'qry += " AND A5.ItemCode = A1.ItemCode"
            'qry += " AND A5.TargetType <> '14') [Facturado]"
            'qry += " FROM Ventas.dbo.CAM_Encabezado AA1"
            'qry += " LEFT JOIN Ventas.dbo.CAM_Detalle BB1 ON BB1.Id = AA1.Id "
            'qry += " WHERE FechaFinal > GETDATE()"
            'qry += " AND LEN(AA1.Id) < 8"
            'qry += " AND AA1.Distribuidor = '0'"
            'qry += " AND BB1.CodigoArticulo = A1.ItemCode COLLATE SQL_Latin1_General_CP850_CI_AS) [Qry2]),0) [DeudaProyeccion],"

            'qry += " CONVERT(INTEGER,A1.MinLevel) [StockMinimo],"
            'qry += " CONVERT(INTEGER, A1.MaxLevel) [StockMaximo]"
            'qry += " FROM SBOGuateplast.dbo.OITM A1"
            'qry += " WHERE A1.ItemCode in (" + pCodigosArticulos + ")"
            'qry += " AND LEN(A1.ItemCode) > 8"

            qry += " SELECT"
            qry += " 	CASE"
            qry += " 		WHEN A1.U_NoDeLinea = '0' THEN"
            qry += " 			'SI' "
            qry += " 		WHEN A1.U_NoDeLinea = '1' THEN"
            qry += " 			'NO' "
            qry += " 	END As [DeLinea], "
            qry += " 	UPPER(A1.ItemCode) [CodigoArticulo], "
            qry += " 	UPPER(A1.ItemName) [NombreArticulo], "
            qry += " 	CONVERT(INTEGER, ISNULL(A1.OnHand, 0)) [Stock], "
            qry += " 	ISNULL(C1.Diferencia, 0) As [Ensamble], "
            qry += " 	ISNULL(C2.Diferencia, 0) As [Produccion], "
            qry += " 	ISNULL(C3.DeudaRol, 0) As [DeudaRol], "
            qry += " 	ISNULL(C4.DeudaRol, 0) AS [DeudaCampana], "
            qry += " 	ISNULL(tot.DeudaProyeccion,0) AS [DeudaProyeccion], "
            qry += " 	CONVERT(INTEGER, A1.MinLevel) [StockMinimo], "
            qry += " 	CONVERT(INTEGER, A1.MaxLevel) [StockMaximo] "
            qry += " FROM"
            qry += " 	SBOGuateplast.dbo.OITM A1 WITH (NOLOCK) "
            qry += " 	LEFT OUTER JOIN"
            qry += " 		("
            qry += " 			SELECT"
            qry += " 				A2.ItemCode,"
            qry += " 				ISNULL(SUM( "
            qry += " 				CASE"
            qry += " 					WHEN PlannedQty > CmpltQty THEN"
            qry += " 						CONVERT(INTEGER, (PlannedQty - CmpltQty )) "
            qry += " 					ELSE"
            qry += " 						'0' "
            qry += " 				END), 0) [Diferencia] "
            qry += " 			FROM"
            qry += " 				SBOGuateplast.dbo.OWOR A2 WITH (NOLOCK) "
            qry += " 			WHERE"
            qry += " 				A2.Status IN ('P', 'R' )"
            qry += " 				AND A2.U_Tipo IN ('1', '2', '3', '4' )"
            qry += " 			Group by"
            qry += " 				A2.ItemCode "
            qry += " 		)"
            qry += " 		C1 "
            qry += " 		on A1.ItemCode = C1.ItemCode"
            qry += " 	LEFT OUTER JOIN"
            qry += " 		("
            qry += " 			SELECT"
            qry += " 				A2.ItemCode,"
            qry += " 				ISNULL(SUM( "
            qry += " 				CASE"
            qry += " 					WHEN PlannedQty > CmpltQty THEN"
            qry += " 						CONVERT(INTEGER, (PlannedQty - CmpltQty )) "
            qry += " 					ELSE"
            qry += " 						'0' "
            qry += " 				END), 0) [Diferencia] "
            qry += " 			FROM"
            qry += " 				SBOGuateplast.dbo.OWOR A2 WITH (NOLOCK)"
            qry += " 			WHERE"
            qry += " 				A2.Status IN ('P', 'R' )"
            qry += " 				AND A2.U_Tipo IN ('0' )"
            qry += " 			GROUP BY"
            qry += " 				A2.ItemCode "
            qry += " 		)"
            qry += " 		C2 "
            qry += " 		ON A1.ItemCode = C2.ItemCode "
            qry += " 	LEFT OUTER JOIN"
            qry += " 		("
            qry += " 			SELECT"
            qry += " 				B3.ItemCode,"
            qry += " 				ISNULL(CONVERT(INTEGER, SUM(B3.OpenQty)), 0) [DeudaRol] "
            qry += " 			FROM"
            qry += " 				SBOGuateplast.dbo.ORDR A3 WITH (NOLOCK) "
            qry += " 				LEFT JOIN"
            qry += " 					SBOGuateplast.dbo.RDR1 B3 WITH (NOLOCK) "
            qry += " 					ON B3.DocEntry = A3.DocEntry"
            qry += " 			WHERE"
            qry += " 				B3.LineStatus = 'O' "
            qry += " 				AND A3.DocStatus = 'O' "
            qry += " 				AND A3.CANCELED = 'N' "
            qry += " 				AND "
            qry += " 				(A3.U_NameCamp IS NULL "
            qry += " 					or A3.U_NameCamp = '' )"
            qry += " 			group by"
            qry += " 				B3.ItemCode "
            qry += " 		)"
            qry += " 		C3 "
            qry += " 		ON A1.ItemCode = C3.ItemCode"
            qry += " 	LEFT OUTER JOIN"
            qry += " 		("
            qry += " 			SELECT"
            qry += " 				B3.ItemCode,"
            qry += " 				ISNULL(CONVERT(INTEGER, SUM(B3.OpenQty)), 0) [DeudaRol] "
            qry += " 			FROM"
            qry += " 				SBOGuateplast.dbo.ORDR A3 WITH (NOLOCK) "
            qry += " 				LEFT JOIN"
            qry += " 					SBOGuateplast.dbo.RDR1 B3 WITH (NOLOCK) "
            qry += " 					ON B3.DocEntry = A3.DocEntry "
            qry += " 			WHERE"
            qry += " 				B3.LineStatus = 'O' "
            qry += " 				AND A3.DocStatus = 'O' "
            qry += " 				AND A3.CANCELED = 'N'"
            qry += " 				AND A3.U_NameCamp <> '' "
            qry += " 			GROUP BY"
            qry += " 				B3.ItemCode "
            qry += " 		)"
            qry += " 		C4 "
            qry += " 		ON A1.ItemCode = C4.ItemCode "
            qry += " 	LEFT OUTER JOIN"
            qry += " 		("
            qry += " 			SELECT"
            qry += " 				pro.ItemCode,"
            qry += " 			  SUM( "
            qry += " 			  CASE"
            qry += " 				 WHEN ISNULL(pro.Proyectado,0) > isnull(fac.Facturado,0) THEN"
            qry += " 					ISNULL(pro.Proyectado,0) - isnull(fac.Facturado,0)  "
            qry += " 				 ELSE"
            qry += " 					0 "
            qry += " 			  END"
            qry += " 		) [DeudaProyeccion] "
            qry += " 		FROM "
            qry += " 			("
            qry += " 				Select "
            qry += " 					det.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS As ItemCode, "
            qry += " 					det.Id As DocEntry, "
            qry += " 					SUM(det.Proyectado) As Proyectado  "
            qry += " 				From "
            qry += " 					Ventas.dbo.CAM_Encabezado cab WITH (NOLOCK)  "
            qry += " 					INNER JOIN "
            qry += " 						Ventas.dbo.CAM_Detalle det WITH (NOLOCK) "
            qry += " 						ON det.Id = cab.Id "
            qry += " 				Where "
            qry += " 					FechaFinal > GETDATE() "
            qry += " 					AND LEN(cab.Id) < 8 "
            qry += " 					AND cab.Distribuidor = '0' "
            qry += " 					AND det.CodigoArticulo in "
            qry += " 					(" + pCodigosArticulos + ") "
            qry += " 				Group by "
            qry += " 					det.CodigoArticulo, "
            qry += " 					det.Id "
            qry += " 			) pro 	"
            qry += " 			LEFT OUTER JOIN "
            qry += " 			(SELECT "
            qry += " 				ped.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS As ItemCode,"
            qry += " 				ped.DocEntry,"
            qry += " 				SUM( "
            qry += " 				CASE "
            qry += " 					WHEN fac.TargetType <> ( 14) THEN "
            qry += " 						ISNULL(fac.Quantity, 0)  "
            qry += " 					ELSE "
            qry += " 						0  "
            qry += " 				END) AS Facturado  "
            qry += " 			FROM "
            qry += " 				( "
            qry += " 					Select "
            qry += " 						det.CodigoArticulo, "
            qry += " 						det.Proyectado, "
            qry += " 						det.Id As DocEntry  "
            qry += " 					From "
            qry += " 						Ventas.dbo.CAM_Encabezado cab WITH (NOLOCK) "
            qry += " 						INNER JOIN "
            qry += " 							Ventas.dbo.CAM_Detalle det WITH (NOLOCK)  "
            qry += " 							ON det.Id = cab.Id  "
            qry += " 					Where "
            qry += " 						FechaFinal > GETDATE()  "
            qry += " 						AND LEN(cab.Id) < 8  "
            qry += " 						AND cab.Distribuidor = '0'  "
            qry += " 						AND det.CodigoArticulo in (" + pCodigosArticulos + ")"
            qry += " 				) ped "
            qry += " 				LEFT OUTER JOIN "
            qry += " 					SBOGuateplast.dbo.ORDR cab WITH (NOLOCK) "
            qry += " 					ON ped.DocEntry COLLATE SQL_Latin1_General_CP850_CI_AS = cab.U_NameCamp  "
            qry += " 				INNER JOIN "
            qry += " 					SBOGuateplast.dbo.RDR1 det WITH (NOLOCK,INDEX(RDR1_PRIMARY)) "
            qry += " 					ON cab.DocEntry = det.DocEntry "
            qry += " 					AND ped.CodigoArticulo = det.ItemCode COLLATE SQL_Latin1_General_CP850_CI_AS "
            qry += " 				INNER JOIN "
            qry += " 					SBOGuateplast.dbo.DLN1 ent WITH (NOLOCK)  "
            qry += " 					ON det.DocEntry = ent.BaseEntry  "
            qry += " 					AND ent.ItemCode = ped.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS "
            qry += " 					AND ent.TargetType <> '16' "
            qry += " 				INNER JOIN "
            qry += " 					SBOGuateplast.dbo.INV1 fac WITH (NOLOCK, INDEX(INV1_BASE_ENTRY))  "
            qry += " 					ON ent.DocEntry = fac.BaseEntry  "
            qry += " 					AND fac.ItemCode = ped.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS "
            qry += " 			WHERE "
            qry += " 				cab.CANCELED = 'N' "
            qry += " 				AND cab.U_NameCamp IS NOT NULL "
            qry += " 				AND ped.CodigoArticulo In"
            qry += " 				(" + pCodigosArticulos + " )"
            qry += " 			GROUP BY"
            qry += " 				ped.CodigoArticulo, ped.DocEntry ) fac "
            qry += " 				on pro.ItemCode = fac.ItemCode And "
            qry += " 					pro.DocEntry = fac.DocEntry "
            qry += " 			GROUP BY pro.ItemCode"
            qry += " 		) tot "
            qry += " 		on A1.ItemCode = tot.ItemCode "
            qry += " WHERE"
            qry += " 	A1.ItemCode in (" + pCodigosArticulos + ")"
            qry += " 	AND LEN(A1.ItemCode) > 8"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_RelacionCP(ByVal pCodigoArticulo As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtAnalisisArticulos")

        Try
            qry = "  SELECT DISTINCT "
            qry += " Molde [Molde], "
            qry += " B.Nombre,"
            qry += " A.Estatus [Estatus]"
            qry += " FROM APGProduccion.dbo.PROD_CodigosProducidos A "
            qry += " LEFT JOIN APGProduccion.dbo.PROD_Moldes B ON B.Id = A.Molde"
            qry += " WHERE Molde IN  ( "
            qry += " Select DISTINCT C.Molde "
            qry += " FROM SBOGuateplast.dbo.OITT A "
            qry += " LEFT JOIN SBOGuateplast.dbo.ITT1 B ON B.Father = A.Code "
            qry += " LEFT JOIN APGProduccion.dbo.PROD_CodigosProducidos C ON C.Id COLLATE SQL_Latin1_General_CP850_CI_AS = SUBSTRING(B.Code,1,8)   "
            qry += " WHERE A.Code LIKE ('" + pCodigoArticulo + "%') "
            qry += " AND B.Code LIKE ('CP%') "
            qry += " AND C.Molde > '0' ) "
            qry += " AND A.Estatus = 'True' "
            qry += " ORDER BY Molde ASC "


            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_MoldesPorCodigo(ByVal pCodigoArticulo As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtAnalisisArticulos")

        Try
            qry = "  SELECT DISTINCT "
            qry += " Molde [Molde], "
            qry += " B.Nombre,"
            qry += " A.Estatus [Estatus]"
            qry += " FROM APGProduccion.dbo.PROD_CodigosProducidos A "
            qry += " LEFT JOIN APGProduccion.dbo.PROD_Moldes B ON B.Id = A.Molde"
            qry += " WHERE Molde IN  ( "
            qry += " Select DISTINCT C.Molde "
            qry += " FROM SBOGuateplast.dbo.OITT A "
            qry += " LEFT JOIN SBOGuateplast.dbo.ITT1 B ON B.Father = A.Code "
            qry += " LEFT JOIN APGProduccion.dbo.PROD_CodigosProducidos C ON C.Id COLLATE SQL_Latin1_General_CP850_CI_AS = SUBSTRING(B.Code,1,8)   "
            qry += " WHERE A.Code LIKE ('" + pCodigoArticulo + "%') "
            qry += " AND B.Code LIKE ('CP%') "
            qry += " AND C.Molde > '0' ) "
            qry += " AND A.Estatus = 'True' "
            qry += " ORDER BY Molde ASC "


            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_RelacionARLista(ByVal pCodigosMolde As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtRelacionARLista")

        Try
            qry = " SELECT"
            qry += " ItemCode [CodigoPadre]"
            qry += " FROM SBOGuateplast.dbo.OITM"
            qry += " WHERE ItemCode IN ("
            qry += " Select DISTINCT"
            qry += " SUBSTRING(Father,1,8)  [CodigoPadre]"
            qry += " FROM SBOGuateplast.dbo.ITT1 A"
            qry += " WHERE SUBSTRING(A.Code,1,8) COLLATE SQL_Latin1_General_CP1_CI_AS IN"
            qry += " ("
            qry += " Select DISTINCT"
            qry += " Id"
            qry += " FROM APGProduccion.dbo.PROD_CodigosProducidos"
            qry += " WHERE Molde IN (" + pCodigosMolde + ")"
            qry += " )"
            qry += " AND LEN(Father) = 8"
            qry += " AND Father LIKE ('AR%')"
            qry += " )"
            qry += " ORDER BY ItemName ASC"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_ArticulosHijosPorMolde(ByVal pCodigosMolde As String) As DataTable
        Try

            Dim qry As New StringBuilder

            qry.Append(" SELECT DISTINCT ")
            qry.Append(" Father [CodigoArticulo] ")
            qry.Append(" FROM SBOGuateplast.dbo.ITT1 A ")
            qry.Append(" WHERE SUBSTRING(A.Code,1,8) COLLATE SQL_Latin1_General_CP1_CI_AS IN ")
            qry.Append(" (SELECT DISTINCT ")
            qry.Append(" Id ")
            qry.Append(" FROM APGProduccion.dbo.PROD_CodigosProducidos ")
            qry.Append(" WHERE Molde IN (" + pCodigosMolde + ") ")
            qry.Append(" ) ")
            qry.Append(" AND LEN(Father) > 8 ")
            qry.Append(" AND Father LIKE ('AR%') ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_RelacionARPadres(ByVal pCodigosARPadres As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtRelacionARPadres")

        Try
            qry = " SELECT A.ItemCode [CodigoArticulo],"
            qry += " A.ItemName [NombreArticulo],"
            qry += " (SELECT CONVERT(INTEGER,SUM(OnHand)) [Stock]"
            qry += " FROM SBOGuateplast.dbo.OITM"
            qry += " WHERE ItemCode LIKE (A.ItemCode + '%')"
            qry += " AND LEN(ItemCode) > 8"
            qry += " ) [Stock],"
            qry += " (SELECT"
            qry += " ISNULL(SUM(CASE"
            qry += " WHEN PlannedQty > CmpltQty "
            qry += " THEN CONVERT(INTEGER,(PlannedQty - CmpltQty))"
            qry += " ELSE '0'"
            qry += " END),0) [Diferencia]"
            qry += " FROM SBOGuateplast.dbo.OWOR A2"
            qry += " WHERE A2.ItemCode LIKE (SUBSTRING(A.ItemCode,1,8) +'%')"
            qry += " AND LEN(A2.ItemCode) > '8'"
            qry += " AND A2.Status IN ('P','R')"
            qry += " AND A2.U_Tipo IN ('1','2','3','4')) [Ensamble],"

            qry += " (SELECT"
            qry += " ISNULL(SUM(CASE"
            qry += " WHEN PlannedQty > CmpltQty "
            qry += " THEN CONVERT(INTEGER,(PlannedQty - CmpltQty))"
            qry += " ELSE '0'"
            qry += " END),0) [Diferencia]"
            qry += " FROM SBOGuateplast.dbo.OWOR A2"
            qry += " WHERE A2.ItemCode LIKE (SUBSTRING(A.ItemCode,1,8) +'%')"
            qry += " AND LEN(A2.ItemCode) > '8'"
            qry += " AND A2.Status IN ('P','R')"
            qry += " AND A2.U_Tipo IN ('0')) [Produccion],"

            qry += " (SELECT"
            qry += " ISNULL(CONVERT(INTEGER,SUM(B3.OpenQty)),0) [DeudaRol]"
            qry += " FROM SBOGuateplast.dbo.ORDR A3"
            qry += " LEFT JOIN SBOGuateplast.dbo.RDR1 B3 ON B3.DocEntry = A3.DocEntry"
            qry += " WHERE B3.ItemCode LIKE (SUBSTRING(A.ItemCode,1,8) +'%')"
            qry += " AND LEN(B3.ItemCode) > '8'"
            qry += " AND B3.LineStatus = 'O'"
            qry += " AND A3.DocStatus = 'O'"
            qry += " AND A3.CANCELED = 'N'"
            qry += " AND A3.U_NameCamp IS NULL) [DeudaRol],"

            qry += " (SELECT"
            qry += " ISNULL(CONVERT(INTEGER,SUM(B3.OpenQty)),0) [DeudaRol]"
            qry += " FROM SBOGuateplast.dbo.ORDR A3"
            qry += " LEFT JOIN SBOGuateplast.dbo.RDR1 B3 ON B3.DocEntry = A3.DocEntry"
            qry += " WHERE B3.ItemCode LIKE (SUBSTRING(A.ItemCode,1,8) +'%')"
            qry += " AND LEN(B3.ItemCode) > '8'"
            qry += " AND B3.LineStatus = 'O'"
            qry += " AND A3.DocStatus = 'O'"
            qry += " AND A3.CANCELED = 'N'"
            qry += " AND A3.U_NameCamp <> '') [DeudaCampana],"


            qry += " ISNULL((SELECT"
            qry += " SUM(CASE"
            qry += " WHEN Proyectado > Facturado"
            qry += " THEN (Proyectado - Facturado)"
            qry += " ELSE '0'"
            qry += " END) [DeudaProyeccion]"
            qry += " FROM"
            qry += " (SELECT"
            qry += " BB1.Proyectado,"
            qry += " (SELECT "
            qry += " ISNULL(CONVERT(INTEGER,SUM(A5.Quantity)),0) [Facturado]"
            qry += " FROM SBOGuateplast.dbo.INV1 A5"
            qry += " LEFT JOIN SBOGuateplast.dbo.OINV B1 ON B1.DocEntry = A5.DocEntry"
            qry += " WHERE A5.BaseEntry IN "
            qry += " (SELECT DISTINCT AA.DocEntry"
            qry += " FROM SBOGuateplast.dbo.DLN1 AA"
            qry += " WHERE AA.BaseEntry IN "
            qry += " (SELECT DISTINCT AAA.DocEntry"
            qry += " FROM SBOGuateplast.dbo.ORDR AAA"
            qry += " LEFT JOIN SBOGuateplast.dbo.RDR1 BBB ON BBB.DocEntry = AAA.DocEntry"
            qry += " WHERE AAA.U_NameCamp COLLATE SQL_Latin1_General_CP850_CI_AS = AA1.Id"
            qry += " AND BBB.ItemCode LIKE (SUBSTRING(A.ItemCode,1,8) +'%')"
            qry += " AND LEN(BBB.ItemCode) > '8'"
            qry += " AND AAA.CANCELED = 'N')"
            qry += " AND AA.ItemCode LIKE (SUBSTRING(A.ItemCode,1,8) +'%')"
            qry += " AND LEN(AA.ItemCode) > '8'"
            qry += " AND AA.TargetType <> '16')"
            qry += " AND A5.ItemCode LIKE (SUBSTRING(A.ItemCode,1,8) +'%')"
            qry += " AND LEN(A5.ItemCode) > '8'"
            qry += " AND A5.TargetType <> '14') [Facturado]"
            qry += " FROM Ventas.dbo.CAM_Encabezado AA1"
            qry += " LEFT JOIN Ventas.dbo.CAM_Detalle BB1 ON BB1.Id = AA1.Id"
            qry += " WHERE FechaFinal > GETDATE()"
            qry += " AND LEN(AA1.Id) < 8"
            qry += " AND AA1.Distribuidor = '0'"
            qry += " AND BB1.CodigoArticulo LIKE (SUBSTRING(A.ItemCode,1,8) +'%') COLLATE SQL_Latin1_General_CP850_CI_AS) [Qry2]),0) [DeudaProyeccion]   "


            qry += " FROM SBOGuateplast.dbo.OITM A"
            qry += " WHERE A.ItemCode in (" + pCodigosARPadres + ")"
            qry += " GROUP BY A.ItemCode,A.ItemName"


            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ArticulosRelacionados_XArticuloPadre(ByVal pCodigoPadre As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulosRelacionados")

        Try
            qry = " SELECT"
            qry += " ItemCode [CodigoArticulo]"
            qry += " FROM SBOGuateplast.dbo.OITM"
            qry += " WHERE ItemCode LIKE '" + pCodigoPadre + "%'"
            qry += " AND LEN(ItemCode) > '8'"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_ListaMaterialesAR_XArticulo(ByVal pCodigoArticulo As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulosRelacionados")

        Try
            qry = " SELECT"
            qry += " ItemCode [CodigoArticulo]"
            qry += " FROM SBOGuateplast.dbo.OITM"
            qry += " WHERE ItemCode = " + pCodigoArticulo + ""

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ListaMaterialesCP_XArticulo(ByVal pCodigoArticulo As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulosRelacionados")

        Try
            qry = " SELECT"
            qry += " A.Code [CodigoArticulo],"
            qry += " B.Code [CodigoCP],"
            qry += " C.ItemName [NombreCP],"
            qry += " CONVERT(INTEGER,C.OnHand) [Stock],"
            qry += " C.InvntryUom [U/M],"
            qry += " B.Quantity [Cantidad], "
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Almacen] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode =  B.Code"
            qry += " AND WhsCode = 'Almacen'"
            qry += " ) [Almacen],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Metasa] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode =  B.Code"
            qry += " AND WhsCode = 'Metasa'"
            qry += " ) [Metasa],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Pradera] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode =  B.Code"
            qry += " AND WhsCode = 'Pradera'"
            qry += " ) [Pradera],"

            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Pradera] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode = B.Code"
            qry += " AND WhsCode = 'MaquinaB'"
            qry += " ) [MaquinaB],"

            qry += "  (SELECT  ISNULL(SUM(  CASE  WHEN PlannedQty > CmpltQty  THEN CONVERT(INTEGER,(PlannedQty - CmpltQty))  ELSE '0'  END),0) [Diferencia]  "
            qry += " FROM SBOGuateplast.dbo.OWOR A2  "
            qry += "    WHERE A2.ItemCode = C.ItemCode"
            qry += " AND A2.Status IN ('P','R') "
            qry += " AND A2.U_Tipo IN ('0')) [Produccion],  "

            qry += " (SELECT  ISNULL(SUM(  CASE  WHEN a2.PlannedQty > A2.CmpltQty  THEN CONVERT(INTEGER,(A2.PlannedQty - A2.CmpltQty)* B2.BaseQty)  ELSE '0'  END),0) [Diferencia]  "
            qry += " FROM SBOGuateplast.dbo.OWOR A2  "
            qry += " LEFT JOIN SBOGuateplast.dbo.WOR1 B2 ON B2.DocEntry = A2.DocEntry  "
            qry += " WHERE B2.ItemCode = C.ItemCode AND A2.Status IN ('P','R') "
            qry += " AND A2.U_Tipo IN ('0','1')) [Comprometido], "

            qry += " CONVERT(DECIMAL(18,2),'0') [Producir]"
            qry += " FROM SBOGuateplast.dbo.OITT A"
            qry += " LEFT JOIN SBOGuateplast.dbo.ITT1 B ON B.Father = A.Code"
            qry += " LEFT JOIN SBOGuateplast.dbo.OITM C ON C.ItemCode = B.Code"
            qry += " WHERE A.Code = " + pCodigoArticulo + ""
            qry += " AND (B.Code LIKE ('CP%')"
            qry += " OR B.Code LIKE ('AR%'))"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ListaMaterialesAnalisisARCP(ByVal pCodigoArticulo As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulosRelacionados")

        Try
            qry = " SELECT"
            qry += " A.Code [CodigoArticulo],"
            qry += " B.Code [CodigoCP],"
            qry += " C.ItemName [NombreCP],"
            qry += " CONVERT(INTEGER,C.OnHand) [Stock],"
            qry += " C.InvntryUom [U/M],"
            qry += " B.Quantity [Cantidad], "
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Almacen] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode =  B.Code"
            qry += " AND WhsCode = 'Almacen'"
            qry += " ) [Almacen],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Metasa] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode =  B.Code"
            qry += " AND WhsCode = 'Metasa'"
            qry += " ) [Metasa],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Pradera] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode =  B.Code"
            qry += " AND WhsCode = 'Pradera'"
            qry += " ) [Pradera],"

            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Pradera] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode = B.Code"
            qry += " AND WhsCode = 'MaquinaB'"
            qry += " ) [MaquinaB],"

            qry += "  (SELECT  ISNULL(SUM(  CASE  WHEN PlannedQty > CmpltQty  THEN CONVERT(INTEGER,(PlannedQty - CmpltQty))  ELSE '0'  END),0) [Diferencia]  "
            qry += " FROM SBOGuateplast.dbo.OWOR A2  "
            qry += "    WHERE A2.ItemCode = C.ItemCode"
            qry += " AND A2.Status IN ('P','R') "
            qry += " AND A2.U_Tipo IN ('0')) [Produccion],  "

            qry += " (SELECT  ISNULL(SUM(  CASE  WHEN a2.PlannedQty > A2.CmpltQty  THEN CONVERT(INTEGER,(A2.PlannedQty - A2.CmpltQty)* B2.BaseQty)  ELSE '0'  END),0) [Diferencia]  "
            qry += " FROM SBOGuateplast.dbo.OWOR A2  "
            qry += " LEFT JOIN SBOGuateplast.dbo.WOR1 B2 ON B2.DocEntry = A2.DocEntry  "
            qry += " WHERE B2.ItemCode = C.ItemCode AND A2.Status IN ('P','R') "
            qry += " AND A2.U_Tipo IN ('0','1','2','3','4')) [Comprometido], "

            qry += " CONVERT(DECIMAL(18,2),'0') [Producir],"
            qry += " CONVERT(DECIMAL(18,0),C.MinLevel) [MinLevel],"
            qry += " CONVERT(DECIMAL(18,0),C.MaxLevel) [MaxLevel]"
            qry += " FROM SBOGuateplast.dbo.OITT A"
            qry += " LEFT JOIN SBOGuateplast.dbo.ITT1 B ON B.Father = A.Code"
            qry += " LEFT JOIN SBOGuateplast.dbo.OITM C ON C.ItemCode = B.Code"
            qry += " WHERE A.Code = " + pCodigoArticulo + ""
            qry += " AND (B.Code LIKE ('CP%')"
            qry += " OR B.Code LIKE ('AR%'))"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_ListaMaterialesAnalisisARCPCC(ByVal pCodigoArticulo As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulosRelacionados")

        Try
            qry = " SELECT"
            qry += " A.Code [CodigoArticulo],"
            qry += " B.Code [CodigoCP],"
            qry += " C.ItemName [NombreCP],"
            qry += " CONVERT(INTEGER,C.OnHand) [Stock],"
            qry += " C.InvntryUom [U/M],"
            qry += " B.Quantity [Cantidad], "
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Almacen] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode =  B.Code"
            qry += " AND WhsCode = 'Almacen'"
            qry += " ) [Almacen],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Metasa] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode =  B.Code"
            qry += " AND WhsCode = 'Metasa'"
            qry += " ) [Metasa],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Pradera] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode =  B.Code"
            qry += " AND WhsCode = 'Pradera'"
            qry += " ) [Pradera],"

            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Pradera] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode = B.Code"
            qry += " AND WhsCode = 'MaquinaB'"
            qry += " ) [MaquinaB],"

            qry += "  (SELECT  ISNULL(SUM(  CASE  WHEN PlannedQty > CmpltQty  THEN CONVERT(INTEGER,(PlannedQty - CmpltQty))  ELSE '0'  END),0) [Diferencia]  "
            qry += " FROM SBOGuateplast.dbo.OWOR A2  "
            qry += "    WHERE A2.ItemCode = C.ItemCode"
            qry += " AND A2.Status IN ('P','R') "
            qry += " AND A2.U_Tipo IN ('0')) [Produccion],  "

            qry += " (SELECT  ISNULL(SUM(  CASE  WHEN a2.PlannedQty > A2.CmpltQty  THEN CONVERT(INTEGER,(A2.PlannedQty - A2.CmpltQty)* B2.BaseQty)  ELSE '0'  END),0) [Diferencia]  "
            qry += " FROM SBOGuateplast.dbo.OWOR A2  "
            qry += " LEFT JOIN SBOGuateplast.dbo.WOR1 B2 ON B2.DocEntry = A2.DocEntry  "
            qry += " WHERE B2.ItemCode = C.ItemCode AND A2.Status IN ('P','R') "
            qry += " AND A2.U_Tipo IN ('0','1','2','3','4')) [Comprometido], "

            qry += " CONVERT(DECIMAL(18,2),'0') [Producir],"
            qry += " CONVERT(DECIMAL(18,0),C.MinLevel) [MinLevel],"
            qry += " CONVERT(DECIMAL(18,0),C.MaxLevel) [MaxLevel]"
            qry += " FROM SBOGuateplast.dbo.OITT A"
            qry += " LEFT JOIN SBOGuateplast.dbo.ITT1 B ON B.Father = A.Code"
            qry += " LEFT JOIN SBOGuateplast.dbo.OITM C ON C.ItemCode = B.Code"
            qry += " WHERE A.Code = " + pCodigoArticulo + ""
            qry += " AND (B.Code LIKE ('CP%')"
            qry += " OR B.Code LIKE ('AR%')"
            qry += " OR B.Code LIKE ('CC%'))"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ListaMaterialesAnalisisARCPCCMO(ByVal pCodigoArticulo As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulosRelacionados")

        Try
            qry = " SELECT"
            qry += " A.Code [CodigoArticulo],"
            qry += " B.Code [CodigoCP],"
            qry += " C.ItemName [NombreCP],"
            qry += " CONVERT(INTEGER,C.OnHand) [Stock],"
            qry += " C.InvntryUom [U/M],"
            qry += " B.Quantity [Cantidad], "
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Almacen] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode =  B.Code"
            qry += " AND WhsCode = 'BodegaSJ'"
            qry += " ) [Almacen],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Metasa] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode =  B.Code"
            qry += " AND WhsCode = 'PI'"
            qry += " ) [Metasa],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Pradera] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode =  B.Code"
            qry += " AND WhsCode = 'PT'"
            qry += " ) [Pradera],"

            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Pradera] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode = B.Code"
            qry += " AND WhsCode = 'MaquinaB'"
            qry += " ) [MaquinaB],"

            qry += "  (SELECT  ISNULL(SUM(  CASE  WHEN PlannedQty > CmpltQty  THEN CONVERT(INTEGER,(PlannedQty - CmpltQty))  ELSE '0'  END),0) [Diferencia]  "
            qry += " FROM SBOGuateplast.dbo.OWOR A2  "
            qry += "    WHERE A2.ItemCode = C.ItemCode"
            qry += " AND A2.Status IN ('P','R') "
            qry += " AND A2.U_Tipo IN ('0')) [Produccion],  "

            qry += " (SELECT  ISNULL(SUM(  CASE  WHEN a2.PlannedQty > A2.CmpltQty  THEN CONVERT(INTEGER,(A2.PlannedQty - A2.CmpltQty)* B2.BaseQty)  ELSE '0'  END),0) [Diferencia]  "
            qry += " FROM SBOGuateplast.dbo.OWOR A2  "
            qry += " LEFT JOIN SBOGuateplast.dbo.WOR1 B2 ON B2.DocEntry = A2.DocEntry  "
            qry += " WHERE B2.ItemCode = C.ItemCode AND A2.Status IN ('P','R') "
            qry += " AND A2.U_Tipo IN ('0','1','2','3','4')) [Comprometido], "

            qry += " CONVERT(DECIMAL(18,2),'0') [Producir],"
            qry += " CONVERT(DECIMAL(18,0),C.MinLevel) [MinLevel],"
            qry += " CONVERT(DECIMAL(18,0),C.MaxLevel) [MaxLevel]"
            qry += " FROM SBOGuateplast.dbo.OITT A"
            qry += " LEFT JOIN SBOGuateplast.dbo.ITT1 B ON B.Father = A.Code"
            qry += " LEFT JOIN SBOGuateplast.dbo.OITM C ON C.ItemCode = B.Code"
            qry += " WHERE A.Code = " + pCodigoArticulo + ""
            qry += " AND (B.Code LIKE ('CP%')"
            qry += " OR B.Code LIKE ('AR%')"
            qry += " OR B.Code LIKE ('CC%')"
            qry += " OR B.Code LIKE ('MO%'))"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_ListaMaterialesARCPCC() As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulosRelacionados")

        Try
            qry = " SELECT "
            qry += " UPPER(A.ItemCode) [CodigoArticulo],"
            qry += " UPPER(A.ItemName) [NombreArticulo],"
            qry += " ISNULL(A.CodeBars,'') [CodigoBarras],"
            qry += " CONVERT(DECIMAL(18,0),A.OnHand) [Stock],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Almacen] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode = A.ItemCode"
            qry += " AND WhsCode = 'Almacen'"
            qry += " ) [Almacen],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Metasa] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode = A.ItemCode"
            qry += " AND WhsCode = 'Metasa'"
            qry += " ) [Metasa],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Pradera] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode = A.ItemCode"
            qry += " AND WhsCode = 'Pradera'"
            qry += " ) [Pradera]"
            qry += " FROM SBOGuateplast.dbo.OITM A"
            qry += " WHERE (Len(A.ItemCode) > 8 "
            qry += " AND (A.ItemCode LIKE ('AR%') OR A.ItemCode LIKE ('CP%') OR A.ItemCode LIKE ('CC%'))) "
            qry += " OR A.ItemCode IN ('MOENSAM','MOIMPRE','MOOPER')"



            'qry += " WHERE Len(A.ItemCode) > 8"
            'qry += " AND (A.ItemCode LIKE ('AR%')"
            'qry += " OR A.ItemCode LIKE ('CP%')"
            'qry += " OR A.ItemCode LIKE ('MO%'))"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_ListaMaterialesARCP() As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulosRelacionados")

        Try
            qry = " SELECT "
            qry += " UPPER(A.ItemCode) [CodigoArticulo],"
            qry += " UPPER(A.ItemName) [NombreArticulo],"
            qry += " ISNULL(A.CodeBars,'') [CodigoBarras],"
            qry += " CONVERT(DECIMAL(18,0),A.OnHand) [Stock],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Almacen] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode = A.ItemCode"
            qry += " AND WhsCode = 'Almacen'"
            qry += " ) [Almacen],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Metasa] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode = A.ItemCode"
            qry += " AND WhsCode = 'Metasa'"
            qry += " ) [Metasa],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Pradera] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode = A.ItemCode"
            qry += " AND WhsCode = 'Pradera'"
            qry += " ) [Pradera]"
            qry += " FROM SBOGuateplast.dbo.OITM A"
            qry += " WHERE (Len(A.ItemCode) > 8 "
            qry += " AND (A.ItemCode LIKE ('AR%') OR A.ItemCode LIKE ('CP%'))) "
            qry += " OR A.ItemCode IN ('MOENSAM','MOIMPRE','MOOPER')"



            'qry += " WHERE Len(A.ItemCode) > 8"
            'qry += " AND (A.ItemCode LIKE ('AR%')"
            'qry += " OR A.ItemCode LIKE ('CP%')"
            'qry += " OR A.ItemCode LIKE ('MO%'))"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_ListaMaterialesARCP(ByVal pCodigoARCP As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulosRelacionados")

        Try
            qry = " SELECT "
            qry += " A.ItemCode [CodigoArticulo],"
            qry += " A.ItemName [NombreArticulo],"
            qry += " ISNULL(A.CodeBars,'') [CodigoBarras],"
            qry += " CONVERT(DECIMAL(18,0),A.OnHand) [Stock],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Almacen] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode = A.ItemCode"
            qry += " AND WhsCode = 'Almacen'"
            qry += " ) [Almacen],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Metasa] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode = A.ItemCode"
            qry += " AND WhsCode = 'Metasa'"
            qry += " ) [Metasa],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Pradera] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode = A.ItemCode"
            qry += " AND WhsCode = 'Pradera'"
            qry += " ) [Pradera]"
            qry += " FROM SBOGuateplast.dbo.OITM A"
            qry += " LEFT JOIN SBOGuateplast.dbo.OITW B ON B.ItemCode = A.ItemCode"
            qry += " WHERE Len(A.ItemCode) > 8"
            qry += " AND A.ItemCode = (" + pCodigoARCP + ")"


            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_ListaMaterialesCC_XArticulo(ByVal pNumSAP As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulosRelacionados")

        Try

            qry = " SELECT "
            qry += " ("
            qry += " SELECT CodigoArticulo FROM APGProduccion.dbo.PROD_Ordenes_Detalle"
            qry += " WHERE Id = " + pNumSAP + ""
            qry += " AND Tipo = 'EE'"
            qry += " )[CodigoArticulo],"
            qry += " A.CodigoArticulo [CodigoCC],"
            qry += " B.ItemName [NombreCC],"
            qry += " CONVERT(INTEGER,B.OnHand) [Stock],"
            qry += " B.InvntryUom [U/M],"
            qry += " A.Unidades [Cantidad],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Almacen] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode =  A.CodigoArticulo COLLATE SQL_Latin1_General_CP1_CI_AS"
            qry += " AND WhsCode = 'Almacen'"
            qry += " ) [Almacen],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Metasa] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode =  A.CodigoArticulo COLLATE SQL_Latin1_General_CP1_CI_AS"
            qry += " AND WhsCode = 'Metasa'"
            qry += " ) [Metasa],"
            qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Pradera] FROM SBOGuateplast.dbo.OITW"
            qry += " WHERE ItemCode =  A.CodigoArticulo COLLATE SQL_Latin1_General_CP1_CI_AS"
            qry += " AND WhsCode = 'Pradera'"
            qry += " ) [Pradera],"
            qry += " CONVERT(DECIMAL(18,2),'0') [Producir]"
            qry += " FROM APGProduccion.dbo.PROD_Ordenes_Detalle A"
            qry += " LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.CodigoArticulo COLLATE SQL_Latin1_General_CP1_CI_AS"
            qry += " WHERE Id = " + pNumSAP + ""
            qry += " AND Tipo IN ('ED','EA')"
            qry += " ORDER BY Tipo DESC, CodigoArticulo ASC"



            'qry = " SELECT"
            'qry += " A.Code [CodigoArticulo],"
            'qry += " B.Code [CodigoCC],"
            'qry += " C.ItemName [NombreCC],"
            'qry += " CONVERT(INTEGER,C.OnHand) [Stock],"
            'qry += " C.InvntryUom [U/M],"
            'qry += " B.Quantity [Cantidad], "
            'qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Almacen] FROM SBOGuateplast.dbo.OITW"
            'qry += " WHERE ItemCode =  B.Code"
            'qry += " AND WhsCode = 'Almacen'"
            'qry += " ) [Almacen],"
            'qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Metasa] FROM SBOGuateplast.dbo.OITW"
            'qry += " WHERE ItemCode =  B.Code"
            'qry += " AND WhsCode = 'Metasa'"
            'qry += " ) [Metasa],"
            'qry += " (SELECT CONVERT(DECIMAL(18,0),ISNULL(OnHand,0)) [Pradera] FROM SBOGuateplast.dbo.OITW"
            'qry += " WHERE ItemCode =  B.Code"
            'qry += " AND WhsCode = 'Pradera'"
            'qry += " ) [Pradera],"
            'qry += " CONVERT(DECIMAL(18,2),'0') [Producir]"
            'qry += " FROM SBOGuateplast.dbo.OITT A"
            'qry += " LEFT JOIN SBOGuateplast.dbo.ITT1 B ON B.Father = A.Code"
            'qry += " LEFT JOIN SBOGuateplast.dbo.OITM C ON C.ItemCode = B.Code"
            'qry += " WHERE A.Code = " + pCodigoArticulo + ""
            'qry += " ORDER BY B.Code DESC"
            ''qry += " AND B.Code LIKE ('CC%')"


            'dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            'Return dt



            'qry = " SELECT"
            'qry += " A.Code [CodigoArticulo],"
            'qry += " B.Code [CodigoCC],"
            'qry += " C.ItemName [NombreCC],"
            'qry += " CONVERT(INTEGER,C.OnHand) [Stock],"
            'qry += " C.InvntryUom [U/M],"
            'qry += " B.Quantity [Cantidad], "
            'qry += " CONVERT(INTEGER,'0') [Sugerido],"
            'qry += " CONVERT(INTEGER,'0') [Producir]"
            'qry += " FROM SBOGuateplast.dbo.OITT A"
            'qry += " LEFT JOIN SBOGuateplast.dbo.ITT1 B ON B.Father = A.Code"
            'qry += " LEFT JOIN SBOGuateplast.dbo.OITM C ON C.ItemCode = B.Code"
            'qry += " WHERE A.Code = " + pCodigoArticulo + ""
            'qry += " AND B.Code LIKE ('CC%')"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_PROD_CatListados(ByVal pTipoLista As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtCatListados")

        Try
            qry = " SELECT Id [Id],"
            qry += " Nombre [Nombre]"
            qry += " FROM APGProduccion.dbo.PROD_CatListados"
            qry += " WHERE TipoListado = '" + pTipoLista + "'"
            qry += " ORDER BY OrdenPor ASC"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Catalogo_Colores() As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtLista_Colores")

        Try
            qry = " SELECT "
            qry += "Code [Id],"
            qry += "Name [Nombre]"
            qry += "FROM SBOGuateplast.dbo.[@COLOR]"
            qry += "ORDER BY Code"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Catalogo_Colores(ByVal pColor As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtLista_Colores")

        Try
            qry = " SELECT "
            qry += "Code [Id],"
            qry += "Name [Nombre]"
            qry += "FROM SBOGuateplast.dbo.[@COLOR]"
            qry += "WHERE Code = '" + pColor + "'"
            qry += "ORDER BY Code"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_Listado_GrupoClientes() As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtGrupoClientes")

        Try
            qry = " SELECT "
            qry += " CONVERT(INTEGER,GroupCode) [Id],"
            qry += " UPPER(GroupName) [Nombre]"
            qry += " FROM SBOGuateplast.dbo.OCRG"
            qry += " WHERE GroupType = 'C' "
            qry += " ORDER BY GroupName"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Catalogo_ClientesDisponibles() As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtClientesDisponibles")

        Try
            qry = "  SELECT "
            qry += " A.CardCode [CodigoCliente],"
            qry += " A.CardName [NombreCliente],"
            qry += " CASE WHEN A.U_BloqueadoCXC = 'N' THEN 'NO' ELSE 'SI' END [Bloqueado]"
            qry += " FROM SBOGuateplast.dbo.OCRD A"
            qry += " WHERE CardCode LIKE ('C%')"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try


    End Function

    Public Function GET_Listado_ClientesDisponibles(ByVal pCodigoCliente As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtClientesDisponibles")

        Try
            qry = "  SELECT "
            qry += " A.CardCode [CodigoCliente],"
            qry += " A.CardName [NombreCliente],"
            qry += " CASE WHEN A.U_BloqueadoCXC = 'N' THEN 'NO' ELSE 'SI' END [Bloqueado]"
            qry += " FROM SBOGuateplast.dbo.OCRD A"
            qry += " WHERE CardCode = ('" + pCodigoCliente + "')"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try


    End Function


    Public Function GET_Listado_OrdenesVentaDisponibles() As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtOrdenesVentaDisponibles")

        Try
            qry = "  SELECT TOP 20000 "
            qry += " DocNum [NumOrden],"
            qry += " CONVERT(DATE,DocDate,111) [Fecha],"
            qry += " UPPER(CardCode) [CodigoCliente],"
            qry += " UPPER(CardName) [NombreCliente],"
            qry += " ISNULL(NumAtCard,0) [PO],"
            qry += " CONVERT(DECIMAL(18,2),DocTotal) [ValorQ],"
            qry += " CASE WHEN DocStatus = 'C' THEN 'Cerrado'"
            qry += " WHEN DocStatus = 'O' THEN 'Abierto'"
            qry += " ELSE ' ' "
            qry += " END [Estatus],"
            qry += " CASE WHEN CANCELED = 'Y' THEN 'SI'"
            qry += " WHEN CANCELED = 'N' THEN 'NO'"
            qry += " ELSE ' ' "
            qry += " END [Cancelado]"
            qry += " FROM SBOGuateplast.dbo.ORDR"
            qry += " WHERE CANCELED = 'N'"
            qry += " ORDER BY DocDate DESC,DocNum DESC"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try


    End Function
    Public Function GET_Listado_OrdenesVentaDisponibles(ByVal pNumeroOrden) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtOrdenesVentaDisponiblesXNumero")

        Try
            qry = "  SELECT "
            qry += " DocNum [NumOrden],"
            qry += " CONVERT(DATE,DocDate,111) [Fecha],"
            qry += " UPPER(CardCode) [CodigoCliente],"
            qry += " UPPER(CardName) [NombreCliente],"
            qry += " ISNULL(NumAtCard,0) [PO],"
            qry += " CONVERT(DECIMAL(18,2),DocTotal) [ValorQ],"
            qry += " CASE WHEN DocStatus = 'C' THEN 'Cerrado'"
            qry += " WHEN DocStatus = 'O' THEN 'Abierto'"
            qry += " ELSE ' ' "
            qry += " END [Estatus],"
            qry += " CASE WHEN CANCELED = 'Y' THEN 'SI'"
            qry += " WHEN CANCELED = 'N' THEN 'NO'"
            qry += " ELSE ' ' "
            qry += " END [Cancelado]"
            qry += " FROM SBOGuateplast.dbo.ORDR"
            qry += " WHERE DocNum = '" + pNumeroOrden + "'"
            qry += " ORDER BY DocDate DESC,DocNum DESC"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try


    End Function


    Public Function GET_Listado_Campanas() As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtCampanaVigente")

        Try
            qry = " SELECT "
            qry += " Id,"
            qry += " NombreCampana,"
            qry += " Pais,"
            qry += " Moneda,"
            qry += " Ano,"
            qry += " FechaInicio,"
            qry += " FechaFinal,"
            qry += " FechaEntrega,"
            qry += " Estatus"
            qry += " FROM Ventas.dbo.CAM_Encabezado"
            qry += " WHERE Len(Id) < 7"
            qry += " ORDER BY Ano DESC,Id ASC"


            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Listado_Campanas_Detalle(ByVal pId As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtCampanaVigente")

        Try
            qry = " SELECT DISTINCT CodigoArticulo "
            qry += " FROM Ventas.dbo.CAM_Detalle "
            qry += " WHERE Id IN (" + pId + ") "


            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Listado_CampanaVigentes() As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtCampanaVigente")

        Try
            qry = "  SELECT Id,"
            qry += " NombreCampana,"
            qry += " Pais,"
            qry += " Moneda,"
            qry += " FechaEntrega,"
            qry += " FechaInicio,"
            qry += " FechaFinal"
            qry += " FROM Ventas.dbo.CAM_Encabezado A"
            qry += " WHERE A.FechaFinal >= CONVERT(DATE,GETDATE(),111)"
            qry += " ORDER BY A.FechaInicio ASC"


            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Listado_CampanaVigentes(ByVal pCampana As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtCampanaVigente")

        Try
            qry = "  SELECT Id,"
            qry += " NombreCampana,"
            qry += " Pais,"
            qry += " Moneda,"
            qry += " FechaEntrega,"
            qry += " FechaInicio,"
            qry += " FechaFinal"
            qry += " FROM Ventas.dbo.CAM_Encabezado A"
            qry += " WHERE Id in ('" + pCampana + "')"
            qry += " ORDER BY A.FechaInicio ASC"


            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ArticuloCP(ByVal pCodigoCP As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticuloCP")

        Try
            qry = "  SELECT "
            qry += "  UPPER(A.ItemCode) [CodigoCP],"
            qry += " UPPER(A.ItemName) [NombreCP],"
            qry += " '0' [U/M],"
            qry += " A.OnHand [Stock],"
            qry += " (SELECT ISNULL(CONVERT(DECIMAL(18,0),OnHand),0) FROM sboguateplast.dbo.oitw"
            qry += " where ItemCode = A.itemCode and WhsCode = 'Almacen') [Almacen],"
            qry += " (SELECT ISNULL(CONVERT(DECIMAL(18,0),OnHand),0) FROM sboguateplast.dbo.oitw"
            qry += " where ItemCode = A.itemCode and WhsCode = 'Metasa') [Metasa],"
            qry += " (SELECT ISNULL(CONVERT(DECIMAL(18,0),OnHand),0) FROM sboguateplast.dbo.oitw"
            qry += " where ItemCode = A.itemCode and WhsCode = 'Pradera') [Pradera],"

            qry += " (SELECT  ISNULL(SUM(  CASE  WHEN PlannedQty > CmpltQty  THEN CONVERT(INTEGER,(PlannedQty - CmpltQty))  ELSE '0'  END),0) [Diferencia]  "
            qry += " FROM SBOGuateplast.dbo.OWOR A2  "
            qry += " WHERE A2.ItemCode = A.ItemCode"
            qry += " AND A2.Status IN ('P','R') "
            qry += " AND A2.U_Tipo IN ('0')) [Produccion],  "

            qry += " (SELECT  ISNULL(SUM(  CASE  WHEN a2.PlannedQty > A2.CmpltQty  THEN CONVERT(INTEGER,(A2.PlannedQty - A2.CmpltQty)* B2.BaseQty)  ELSE '0'  END),0) [Diferencia]  "
            qry += " FROM SBOGuateplast.dbo.OWOR A2  "
            qry += " LEFT JOIN SBOGuateplast.dbo.WOR1 B2 ON B2.DocEntry = A2.DocEntry  "
            qry += " WHERE B2.ItemCode = A.ItemCode AND A2.Status IN ('P','R') "
            qry += " AND A2.U_Tipo IN ('0','1')) [Comprometido], "

            qry += " '0' [Cantidad]"
            qry += " FROM SBOGuateplast.dbo.OITM A"
            qry += " WHERE A.ItemCode = '" + pCodigoCP + "'"


            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_Listado_ArticuloCP() As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticuloCP")

        Try
            qry = "  SELECT"
            qry += " ItemCode [CodigoArticulo],"
            qry += " ItemName [NombreArticulo]FROM SBOGuateplast.dbo.OITM"
            qry += " WHERE ItemCode LIKE ('AR%')"
            qry += " AND LEN(ItemCode) = 8"
            qry += " ORDER BY ItemCode ASC"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Listado_ArticuloCP2() As DataTable
        Dim dt As New DataTable("dtArticuloCP")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT ")
            qry.Append(" ItemCode [CodigoArticulo], ")
            qry.Append(" ItemName [NombreArticulo], ")
            qry.Append(" CASE WHEN U_NoDeLinea = '1' THEN 'NO' ELSE 'SI' END [DeLinea] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM ")
            qry.Append(" WHERE ItemCode like ('CP%') ")
            qry.Append(" AND LEN(ItemCode) <= '8' ")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Listado_ArticuloAR_Hijos() As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticuloCP")

        Try
            qry = "  SELECT"
            qry += " ItemCode [CodigoArticulo],"
            qry += " ItemName [NombreArticulo]FROM SBOGuateplast.dbo.OITM"
            qry += " WHERE ItemCode LIKE ('AR%')"
            qry += " AND LEN(ItemCode) > 8"
            qry += " ORDER BY ItemCode ASC"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Validar_NombrePlantilla(ByVal pNombrePlantilla As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtNombrePlantillas")

        Try
            qry = "  SELECT COUNT(Nombre) [Cantidad] "
            qry += " FROM APGProduccion.dbo.PROD_CatPlantillas"
            qry += " WHERE Nombre = '" + pNombrePlantilla + "'"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Listado_Plantilla() As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtNombrePlantillas")

        Try
            qry = "  SELECT Nombre,"
            qry += " TipoLista,"
            qry += " DeLinea,"
            qry += " CodigoArticuloPadre,"
            qry += " NumeroCampana,"
            qry += " CodigoCliente,"
            qry += " StockMayorA,"
            qry += " StockMenorA,"
            qry += " DeudaRolMayorA,"
            qry += " DeudaCampanaMayorA,"
            qry += " DeudaProyeccionMayorA,"
            qry += " Color,"
            qry += " CodigoArticuloInicial,"
            qry += " CodigoArticuloFinal,"
            qry += " StockMenorMinimo"
            qry += " FROM APGProduccion.dbo.PROD_CatPlantillas"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Plantilla_XNombre(ByVal pNombrePlantilla As String) As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtNombrePlantillas")

        Try
            qry = "  SELECT Nombre,"
            qry += " TipoLista,"
            qry += " DeLinea,"
            qry += " CodigoArticuloPadre,"
            qry += " NumeroCampana,"
            qry += " CodigoCliente,"
            qry += " StockMayorA,"
            qry += " StockMenorA,"
            qry += " DeudaRolMayorA,"
            qry += " DeudaCampanaMayorA,"
            qry += " DeudaProyeccionMayorA,"
            qry += " Color,"
            qry += " CodigoArticuloInicial,"
            qry += " CodigoArticuloFinal,"
            qry += " StockMenorMinimo"
            qry += " FROM APGProduccion.dbo.PROD_CatPlantillas"
            qry += " WHERE Nombre = '" + pNombrePlantilla + "'"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_PROD_Ordenes_Encabezado() As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtPROD_Ordenes_Encabezado")

        Try
            qry = " SELECT TOP 0 * FROM APGProduccion.dbo.PROD_Ordenes_Detalle "

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_PROD_OrdenesEnsambleProduccion_Detalle_Temporal_TOP0() As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtPROD_Ordenes_Encabezado")

        Try
            qry = " SELECT TOP 0 * FROM APGProduccion.dbo.PROD_Ordenes_Detalle_Temporal "

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_PROD_IdTransaccion() As Integer
        Dim qry As New StringBuilder
        Dim dt As New DataTable("dtPROD_IdTransaccion")

        Try
            qry.Append(" SELECT MAX(Id)[Id]")
            qry.Append("FROM APGProduccion.dbo.PROD_Ordenes_Encabezado")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return dt.Rows(0)(0)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Listado_Bodegas() As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtListadoBodegas")

        Try
            qry = " SELECT WhsCode [Id],"
            qry += " WhsName [Nombre]"
            qry += " FROM OWHS"
            qry += " WHERE  WhsName IS NOT NULL "

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
#Region "CrearTablas"

    Public Function CrearTabla_OrdenesSubidas() As DataTable

        Dim dt As New DataTable("dtOrdenesSubidas")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT TOP 0")
            qry.Append(" '' [Tipo], ")
            qry.Append(" NumeroSAP,")
            qry.Append(" CodigoArticulo,")
            qry.Append(" Unidades,")
            qry.Append(" Origen,")
            qry.Append(" Destino")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

#End Region



#Region "DI_API"
    Public Function GET_OrdenesEnsamble_ASubir() As DataTable
        Dim qry As New StringBuilder
        Dim dt As New DataTable("dtOrdenesEnsambleASubir")

        Try
            qry.Append(" SELECT DISTINCT Id ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle ")
            qry.Append(" WHERE Tipo = 'EE' ")
            qry.Append(" AND SAP = '0' ")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_OrdenesProduccion_ASubir() As DataTable
        Dim qry As New StringBuilder
        Dim dt As New DataTable("dtOrdenesProduccionASubir")

        Try
            qry.Append(" SELECT DISTINCT Id ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle ")
            qry.Append(" WHERE Tipo = 'PE' ")
            qry.Append(" AND SAP = '0' ")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_ListaMaterialesCP_ASubir(ByVal pCodigoArticulo As String, ByVal pCantidad As String) As DataTable
        Dim qry As New StringBuilder
        Dim dt As New DataTable("dtListaMateriales_Asubir")

        Try
            qry.Append(" SELECT B.Code, ")
            qry.Append(" CONVERT(DECIMAL(18,4),(B.Quantity * '" + pCantidad + "')) [Cantidad] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITT A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.ITT1 B ON B.Father = A.Code")
            qry.Append(" WHERE A.Code = '" + pCodigoArticulo + "'")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_EE(ByVal pID As String) As DataTable

        Dim dt As New DataTable("dtEEcount")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT DISTINCT Id_Nivel1 ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle")
            qry.Append(" WHERE tipo = 'EE' AND SAP = 0 AND Id = '" + pID + "'")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_EE(ByVal pID As String, ByVal pNivel1 As String) As DataTable

        Dim dt As New DataTable("dtEEcount")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT * FROM APGProduccion.dbo.PROD_Ordenes_Detalle")
            qry.Append(" WHERE tipo = 'EE' ")
            qry.Append(" AND Id = '" + pID + "'")
            qry.Append(" AND Id_Nivel1 = '" + pNivel1 + "'")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_PE(ByVal pID As String) As DataTable

        Dim dt As New DataTable("dtEEcount")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT DISTINCT Id_Nivel1 ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle")
            qry.Append(" WHERE tipo = 'PE' AND SAP = 0 AND Id = '" + pID + "'")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_PD(ByVal pID As String, ByVal pId_Nivel1 As String) As DataTable

        Dim dt As New DataTable("dtPDcount")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT Id_Nivel2 ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle")
            qry.Append(" WHERE tipo = 'PE' AND SAP = 0 AND Id = '" + pID + "' AND Id_Nivel1 = '" + pId_Nivel1 + "' ")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_PE(ByVal pID As String, ByVal pId_Nivel1 As String, ByVal pID_Nivel2 As String) As DataTable

        Dim dt As New DataTable("dtPDcount")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT * ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle")
            qry.Append(" WHERE tipo = 'PE' AND SAP = 0 AND Id = '" + pID + "' AND Id_Nivel1 = '" + pId_Nivel1 + "' and Id_Nivel2 = '" + pID_Nivel2 + "' ")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_PDetalle(ByVal pCodigoArticulo As String, ByVal pCantidad As String) As DataTable

        Dim dt As New DataTable("dtPDcount")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT B.Code [CodigoArticulo],")
            qry.Append(" CONVERT(DECIMAL(18,4),(B.Quantity * '" + pCantidad + "')) [Unidades]")
            qry.Append(" FROM SBOGuateplast.dbo.OITT A")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.ITT1 B ON B.Father = A.Code")
            qry.Append(" WHERE A.Code = '" + pCodigoArticulo + "'")
            qry.Append(" AND NOT B.Code LIKE ('CC%') ")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function



    Public Function GET_ED(ByVal pID As String, ByVal pNivel1 As String) As DataTable

        Dim dt As New DataTable("dtEEcount")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT * FROM APGProduccion.dbo.PROD_Ordenes_Detalle")
            qry.Append(" WHERE tipo = 'ED' ")
            qry.Append(" AND Id = '" + pID + "'")
            qry.Append(" AND Id_Nivel1 = '" + pNivel1 + "'")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Temporal_Recibos(ByVal pId As String) As DataTable

        Dim dt As New DataTable("dtEEcount")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT")
            qry.Append(" C.DocNum [NumOrden],")
            qry.Append(" B.DocNum [Recibo],")
            qry.Append(" CONVERT(DATE,B.DocDate,111) [Fecha],")
            qry.Append(" A.ItemCode [CodigoArticulo],")
            qry.Append(" D.ItemName [NombreArticulo],")
            qry.Append(" CASE WHEN D.U_NoDeLinea = '0' THEN 'SI'")
            qry.Append(" ELSE 'NO' ")
            qry.Append(" END [DeLinea],")
            qry.Append(" CONVERT(DECIMAL(18,0),C.PlannedQty) [Planeado],")
            qry.Append(" CONVERT(DECIMAL(18,0),A.Quantity) [Completado],")
            qry.Append(" B.Comments [Comentarios] ")
            qry.Append(" FROM sboguateplast.dbo.IGN1 A")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OIGN B ON B.DocEntry = A.DocEntry")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OWOR C ON C.DocEntry = A.BaseEntry")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM D ON A.ItemCode = D.ItemCode")
            qry.Append(" WHERE A.BaseEntry = '" + pId + "'")
            qry.Append(" AND b.CANCELED = 'N'")
            qry.Append(" AND b.DocStatus = 'O'")
            qry.Append(" ORDER BY B.DocDate DESC,B.DocNum DESC")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Temporal_AnalisisVenta(ByVal pCodigoArticulo As String) As DataTable

        Dim dt As New DataTable("dtEEcount")

        Try
            Dim qry As New StringBuilder
            qry.Append(" set nocount on; ")
            qry.Append(" set ansi_warnings Off; ")
            qry.Append(" Declare @Datos1 table ( ")
            qry.Append(" Codigo nvarchar(20) default '' ")
            qry.Append(" ,Mes nvarchar(10) default '' ")
            qry.Append(" ,Venta int default 0 ")
            qry.Append(" ) ")
            qry.Append(" ;With ventas as ( ")
            qry.Append(" Select ")
            qry.Append(" b.ItemCode as Codigo ")
            qry.Append(" ,datediff(month, b.DocDate, GETDATE()) as Mes ")
            qry.Append(" ,convert(int, SUM(B.Quantity)) as Unidades ")
            qry.Append(" FROM ")
            qry.Append(" INV1 b WITH (NOLOCK INDEX=Guateplast_INV1_001) ")
            qry.Append(" where ")
            qry.Append(" datediff(month, b.DocDate, GETDATE()) between 1 and  15 ")
            qry.Append(" group by ")
            qry.Append(" b.ItemCode ")
            qry.Append(" ,datediff(month, b.DocDate, GETDATE()) ")
            qry.Append(" ), NC as ( ")
            qry.Append(" Select ")
            qry.Append(" b.ItemCode as Codigo2 ")
            qry.Append(" ,datediff(month, b.DocDate, GETDATE()) as Mes2 ")
            qry.Append(" ,convert(int, SUM(B.Quantity*-1)) as Unidades2 ")
            qry.Append(" FROM ")
            qry.Append(" RIN1 b WITH (NOLOCK index=Guateplast_RIN1_001) ")
            qry.Append(" where ")
            qry.Append(" datediff(month, b.DocDate, GETDATE()) between 1 and  15 ")
            qry.Append(" group by ")
            qry.Append(" b.ItemCode ")
            qry.Append(" ,datediff(month, b.DocDate, GETDATE()) ")
            qry.Append(" ) ")
            qry.Append(" insert into @Datos1 ")
            qry.Append(" Select ")
            qry.Append(" a.Codigo ")
            qry.Append(" ,a.Mes   ")
            qry.Append(" ,a.Unidades + ISNULL(b.Unidades2,0) as Venta ")
            qry.Append(" from ")
            qry.Append(" ventas a left join NC b on a.Codigo = b.Codigo2 and a.Mes = b.Mes2 ")

            qry.Append(" delete @Datos1 where Codigo is null; ")

            qry.Append(" ;WITH Ventas as ( ")
            qry.Append(" Select ")
            qry.Append(" Codigo ")
            qry.Append(" ,SUM(Venta) as VentaTotal_UN ")
            qry.Append(" ,SUM(Case when Mes = 15 then Venta else 0 end) as U_15 ")
            qry.Append(" ,SUM(Case when Mes = 14 then Venta else 0 end) as U_14 ")
            qry.Append(" ,SUM(Case when Mes = 13 then Venta else 0 end) as U_13 ")
            qry.Append(" ,SUM(Case when Mes = 12 then Venta else 0 end) as U_12 ")
            qry.Append(" ,SUM(Case when Mes = 11 then Venta else 0 end) as U_11 ")
            qry.Append(" ,SUM(Case when Mes = 10 then Venta else 0 end) as U_10 ")
            qry.Append(" ,SUM(Case when Mes = 9  then Venta else 0 end) as U_09 ")
            qry.Append(" ,SUM(Case when Mes = 8  then Venta else 0 end) as U_08 ")
            qry.Append(" ,SUM(Case when Mes = 7  then Venta else 0 end) as U_07 ")
            qry.Append(" ,SUM(Case when Mes = 6  then Venta else 0 end) as U_06 ")
            qry.Append(" ,SUM(Case when Mes = 5  then Venta else 0 end) as U_05 ")
            qry.Append(" ,SUM(Case when Mes = 4  then Venta else 0 end) as U_04 ")
            qry.Append(" ,SUM(Case when Mes = 3  then Venta else 0 end) as U_03 ")
            qry.Append(" ,SUM(Case when Mes = 2  then Venta else 0 end) as U_02 ")
            qry.Append(" ,SUM(Case when Mes = 1  then Venta else 0 end) as U_01 ")
            qry.Append(" FROM ")
            qry.Append(" @Datos1 ")
            qry.Append(" GROUP BY ")
            qry.Append(" Codigo ")
            qry.Append(" ), ")
            qry.Append(" Detalles as ( ")
            qry.Append(" select ")
            qry.Append(" Codigo ")
            qry.Append(" ,MAX(Venta) as Maximo ")
            qry.Append(" ,sum(Case when isnull(Venta,0) <> 0 then 1 else 0 end) as MesesConValor ")
            qry.Append(" ,sum(Case when isnull(Venta,0) < 3 then 1 else 0 end) as Menores3 ")
            qry.Append(" from @Datos1 ")
            qry.Append(" group by ")
            qry.Append(" Codigo ")
            qry.Append(" ) ")
            qry.Append(" Select ")
            qry.Append(" A.ItemCode ")
            qry.Append(" ,a.ItemName ")
            qry.Append(" ,CASE A.U_NoDeLinea when 0 then 'SI' else 'NO' end as [TIPO_ART]")
            qry.Append(" ,b.U_15 ")
            qry.Append(" ,b.U_14 ")
            qry.Append(" ,b.U_13 ")
            qry.Append(" ,b.U_12 ")
            qry.Append(" ,b.U_11 ")
            qry.Append(" ,b.U_10 ")
            qry.Append(" ,b.U_09 ")
            qry.Append(" ,b.U_08 ")
            qry.Append(" ,b.U_07 ")
            qry.Append(" ,b.U_06 ")
            qry.Append(" ,b.U_05 ")
            qry.Append(" ,b.U_04 ")
            qry.Append(" ,b.U_03 ")
            qry.Append(" ,b.U_02 ")
            qry.Append(" ,b.U_01 ")
            qry.Append(" ,b.VentaTotal_UN AS TOT_UV ")
            qry.Append(" ,Convert(int, a.OnHand) as STOCK ")
            qry.Append(" ,Convert(int, a.MinLevel) as STOCK_MIN ")
            qry.Append(" ,Convert(int, a.MaxLevel) as STOCK_MAX ")
            qry.Append(" ,isnull(c.Maximo,0) as MUVM ")
            qry.Append(" ,isnull(c.MesesConValor,0) as M_CMOV ")
            qry.Append(" ,ISNULL(c.Menores3,0) as M_CM3U ")
            qry.Append(" ,COALESCE ( (isnull(b.VentaTotal_UN,0) - isnull(c.Maximo,0)) /NULLIF (((isnull(c.MesesConValor,0)-1)- ISNULL(c.Menores3,0)),0)  ,0) as MOV_PROM_COMP ")
            qry.Append(" ,COALESCE ( (isnull(b.VentaTotal_UN,0) ) /NULLIF (((isnull(c.MesesConValor,0))),0)  ,0) as MOV_PROM_SIMP ")
            qry.Append(" ,COALESCE ( convert(int, a.Onhand)/ NULLIF(COALESCE ( (isnull(b.VentaTotal_UN,0) - isnull(c.Maximo,0)) /NULLIF (((isnull(c.MesesConValor,0)-1)- ISNULL(c.Menores3,0)),0)  ,0) ,0),0) AS MI_PC ")
            qry.Append(" ,COALESCE ( convert(int, a.Onhand)/ NULLIF(COALESCE ( (isnull(b.VentaTotal_UN,0) ) / NULLIF ((isnull(c.MesesConValor,0)),0),0),0),0) AS MI_PS ")
            qry.Append(" ,(b.U_12 + b.U_11 + b.U_10) [SumProy3M] ")
            qry.Append(" ,((b.U_12 + b.U_11 + b.U_10)/3) [ProProy3M]      ")
            qry.Append(" FROM ")
            qry.Append(" OITM A ")
            qry.Append(" left join Ventas B ON A.ItemCode = b.Codigo ")
            qry.Append(" left join Detalles C on a.ItemCode = c.Codigo ")
            qry.Append(" where ")
            qry.Append(" ISNULL(b.VentaTotal_UN,0) <> 0 ")
            qry.Append(" AND A.ItemCode = " + pCodigoArticulo + "    ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Impresion_OrdenSeleccionada(ByVal pId As String) As DataTable

        Dim dt As New DataTable("dtEEcount")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT ")
            qry.Append(" CONVERT(NCHAR,A.Bit_FechaCreacion,103) [Bit_FechaCreacion], ")
            qry.Append(" A.Id, ")
            qry.Append(" A.Id_Nivel1, ")
            qry.Append(" A.Id_Nivel2, ")
            qry.Append(" CASE WHEN A.Tipo = 'EE' THEN 'Ensamble' ")
            qry.Append(" WHEN A.Tipo = 'PE' THEN 'Produccion' END [Tipo], ")
            qry.Append(" A.NumeroSAP, ")
            qry.Append(" A.CodigoArticulo, ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" CONVERT(INTEGER,A.Unidades) [Unidades], ")
            qry.Append(" CASE WHEN A.Origen = '0' THEN 'Produccion' ")
            qry.Append(" WHEN A.Origen = '1' THEN 'Ensamble'  ")
            qry.Append(" WHEN A.Origen = '2' THEN 'Imprenta' ")
            qry.Append(" WHEN A.Origen = '3' THEN 'Peines'  ")
            qry.Append(" WHEN A.Origen = '4' THEN 'Pradera'  ")
            qry.Append(" End 'Origen', ")
            qry.Append(" A.Destino, ")
            qry.Append(" A.Bit_UsuarioCreacion ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS ")
            qry.Append(" WHERE A.Id IN (" + pId + ")")
            qry.Append(" AND (A.Tipo = 'EE' OR A.Tipo = 'PE') ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Impresion_OrdenesDisponibles() As DataTable

        Dim dt As New DataTable("dtEEcount")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT ")
            qry.Append(" A.Bit_FechaCreacion [Fecha], ")
            'qry.Append(" CONVERT(NCHAR,A.Bit_FechaCreacion,103) [Fecha], ")
            qry.Append(" A.Id [Id], ")
            qry.Append(" A.CodigoArticulo [CodigoArticulo], ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" A.Bit_UsuarioCreacion [Usuario] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Encabezado A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS ")
            qry.Append(" ORDER BY A.Id DESC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_AnalisisCP(ByVal pCodigoCP As String) As DataTable

        Dim dt As New DataTable("dtAnalisisCP")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT  ")
            qry.Append(" DeLinea, ")
            qry.Append(" CodigoArticulo, ")
            qry.Append(" NombreArticulo, ")
            qry.Append(" StockTotal, ")
            qry.Append(" Almacen,Metasa, ")
            qry.Append(" Pradera, ")
            qry.Append(" Produccion, ")
            qry.Append(" Comprometido , ")
            qry.Append(" ((StockTotal + Produccion)- comprometido) [Disponible] ")
            qry.Append(" FROM ( ")
            qry.Append(" SELECT ")
            qry.Append(" CASE WHEN A.U_NoDeLinea = '1' THEN 'NO' ELSE 'SI' END [DeLinea], ")
            qry.Append(" A.ItemCode [CodigoArticulo], ")
            qry.Append(" A.ItemName [NombreArticulo], ")
            qry.Append(" CONVERT(INTEGER,A.OnHand) [StockTotal], ")
            qry.Append(" (Select ISNULL(CONVERT(INTEGER,OnHand),0) FROM SBOGuateplast.dbo.OITW WHERE ItemCode = A.ItemCode AND WhsCode = 'Almacen')[Almacen], ")
            qry.Append(" (Select ISNULL(CONVERT(INTEGER,OnHand),0) FROM SBOGuateplast.dbo.OITW WHERE ItemCode = A.ItemCode AND WhsCode = 'Metasa')[Metasa], ")
            qry.Append(" (Select ISNULL(CONVERT(INTEGER,OnHand),0) FROM SBOGuateplast.dbo.OITW WHERE ItemCode = A.ItemCode AND WhsCode = 'Pradera')[Pradera], ")
            qry.Append(" (SELECT ")
            qry.Append(" ISNULL(SUM( ")
            qry.Append(" CASE ")
            qry.Append(" WHEN PlannedQty > CmpltQty ")
            qry.Append(" THEN CONVERT(INTEGER,(PlannedQty - CmpltQty)) ")
            qry.Append(" ELSE '0' ")
            qry.Append(" END),0) [Diferencia] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A2 ")
            qry.Append(" WHERE A2.ItemCode = A.ItemCode AND A2.Status IN ('P','R') AND A2.U_Tipo IN ('0')) [Produccion], ")
            qry.Append(" (SELECT ")
            qry.Append(" ISNULL(SUM( ")
            qry.Append(" CASE ")
            qry.Append(" WHEN a2.PlannedQty > A2.CmpltQty ")
            qry.Append(" THEN CONVERT(INTEGER,(A2.PlannedQty - A2.CmpltQty)* B2.BaseQty) ")
            qry.Append(" ELSE '0' ")
            qry.Append(" END),0) [Diferencia] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A2 ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.WOR1 B2 ON B2.DocEntry = A2.DocEntry ")
            qry.Append(" WHERE B2.ItemCode = A.ItemCode AND A2.Status IN ('P','R') AND A2.U_Tipo IN ('0','1')) [Comprometido] ")
            qry.Append(" FROM SBOGuateplast.	dbo.OITM A ")
            qry.Append(" WHERE A.ItemCode LIKE '" + pCodigoCP + "%' ")
            qry.Append(" AND LEN(A.ItemCode) > '8') B ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Temporal_DeudaEnsamble(ByVal pCodigoArticulo As String, ByVal pOrigenes As String) As DataTable

        Dim dt As New DataTable("dtTemporalDeudaEnsamble")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT ")
            qry.Append(" A2.DocNum [NumOrden], ")
            qry.Append(" CONVERT(DATE,A2.DueDate) [Fecha], ")
            qry.Append(" b2.ItemCode [CodigoArticulo], ")
            qry.Append(" C2.ItemName [NombreArticulo], ")
            qry.Append(" CONVERT(INTEGER,b2.PlannedQty) [Planeado], ")
            qry.Append(" CONVERT(INTEGER,(a2.CmpltQty * b2.BaseQty)) [Completado], ")
            qry.Append(" ISNULL( ")
            qry.Append(" CASE ")
            qry.Append(" WHEN a2.PlannedQty > A2.CmpltQty ")
            qry.Append(" THEN CONVERT(INTEGER,(A2.PlannedQty - A2.CmpltQty)* B2.BaseQty) ")
            qry.Append(" ELSE '0' ")
            qry.Append(" END,0) [Diferencia], ")
            qry.Append(" CASE ")
            qry.Append(" WHEN U_Tipo = '0' THEN 'PRODUCCION' ")
            qry.Append(" WHEN U_Tipo = '1' THEN 'ENSAMBLE' ")
            qry.Append(" WHEN U_Tipo = '2' THEN 'IMPRENTA' ")
            qry.Append(" WHEN U_Tipo = '3' THEN 'PEINES' ")
            qry.Append(" WHEN U_Tipo = '4' THEN 'PRADERA' ")
            qry.Append(" END [Destino], ")
            qry.Append(" A2.Comments [Comentarios] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A2 ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.WOR1 B2 ON B2.DocEntry = A2.DocEntry ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM C2 ON C2.ItemCode = B2.ItemCode ")
            qry.Append(" WHERE B2.ItemCode = " + pCodigoArticulo + " AND A2.Status IN ('P','R') AND A2.U_Tipo IN (" + pOrigenes + ") ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Listado_OrdenesEnsamble(ByVal pDias As String, ByVal pTipoOrden As String) As DataTable

        Dim dt As New DataTable("dtTemporalDeudaEnsamble")

        Try
            Dim qry As New StringBuilder
            qry.Append(" Select ")
            qry.Append(" DocNum [NumSAP], ")
            qry.Append(" CASE  ")
            qry.Append(" WHEN Status = 'R' THEN 'Liberado'  ")
            qry.Append(" WHEN Status = 'P' THEN 'Planeado' 	 ")
            qry.Append(" WHEN Status = 'L' THEN 'Close'  ")
            qry.Append(" END [Estado], ")

            qry.Append(" CASE ")
            qry.Append(" WHEN Type = 'S' THEN 'Estándar' ")
            qry.Append(" WHEN Type = 'P' THEN 'Especial' ")
            qry.Append(" WHEN Type = 'D' THEN 'Desmontar' ")
            qry.Append(" END [Tipo], ")

            qry.Append(" CASE  ")
            qry.Append(" WHEN U_Tipo = '0' THEN 'Producción'  ")
            qry.Append(" WHEN U_Tipo = '1' THEN 'Ensamble'  ")
            qry.Append(" WHEN U_Tipo = '2' THEN 'Imprenta' ")
            qry.Append(" WHEN U_Tipo = '3' THEN 'Peines'  ")
            qry.Append(" WHEN U_Tipo = '4' THEN 'Pradera'  ")
            qry.Append(" ELSE '' ")
            qry.Append(" END [Origen], ")

            qry.Append(" A.ItemCode [CodigoArticulo], ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" CONVERT(INTEGER,PlannedQty) [Planeado], ")
            qry.Append(" CONVERT(INTEGER,CmpltQty) [Completado], ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (PlannedQty - CmpltQty) > 0 THEN (PlannedQty - CmpltQty) ELSE '0' END) [Pendiente], ")
            qry.Append(" CONVERT(DATE,PostDate,105) [Creación], ")
            qry.Append(" CONVERT(DATE,DueDate,105) [Vencimiento], ")
            qry.Append(" CONVERT(INTEGER,CONVERT(DATE,GETDATE(),105) - PostDate) [Dias Atrasado], ")
            qry.Append(" A.Comments [Comentarios]")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.ItemCode LIKE ('" + pTipoOrden + "%')  ")
            qry.Append(" AND Status IN ('R','P') ")
            qry.Append(" AND CONVERT(INTEGER,CONVERT(DATE,GETDATE(),105) - PostDate) > '" + pDias + "' ")
            qry.Append(" ORDER BY NumSAP DESC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_Listado_OrdenesProduccion() As DataTable

        Dim dt As New DataTable("dtListado_Produccion")

        Try
            Dim qry As New StringBuilder
            qry.Append(" Select ")
            qry.Append(" DocNum [NumSAP], ")
            qry.Append(" CASE  ")
            qry.Append(" WHEN Status = 'R' THEN 'Liberado'  ")
            qry.Append(" WHEN Status = 'P' THEN 'Planeado' 	 ")
            qry.Append(" WHEN Status = 'L' THEN 'Close'  ")
            qry.Append(" END [Estado], ")

            qry.Append(" CASE ")
            qry.Append(" WHEN Type = 'S' THEN 'Estándar' ")
            qry.Append(" WHEN Type = 'P' THEN 'Especial' ")
            qry.Append(" WHEN Type = 'D' THEN 'Desmontar' ")
            qry.Append(" END [Tipo], ")

            qry.Append(" CASE  ")
            qry.Append(" WHEN U_Tipo = '0' THEN 'Producción'  ")
            qry.Append(" WHEN U_Tipo = '1' THEN 'Ensamble'  ")
            qry.Append(" WHEN U_Tipo = '2' THEN 'Imprenta' ")
            qry.Append(" WHEN U_Tipo = '3' THEN 'Peines'  ")
            qry.Append(" WHEN U_Tipo = '4' THEN 'Pradera'  ")
            qry.Append(" ELSE '' ")
            qry.Append(" END [Origen], ")

            qry.Append(" ItemCode [CodigoArticulo], ")
            qry.Append(" CONVERT(INTEGER,PlannedQty) [Planeado], ")
            qry.Append(" CONVERT(INTEGER,CmpltQty) [Completado], ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (PlannedQty - CmpltQty) > 0 THEN (PlannedQty - CmpltQty) ELSE '0' END) [Pendiente], ")
            qry.Append(" CONVERT(DATE,PostDate,105) [Creación], ")
            qry.Append(" CONVERT(DATE,DueDate,105) [Vencimiento], ")
            qry.Append(" CONVERT(INTEGER,CONVERT(DATE,GETDATE(),105) - PostDate) [Dias Atrasado], ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR ")
            qry.Append(" WHERE ItemCode LIKE ('CP%')  ")
            qry.Append(" AND Status IN ('R','P') ")
            qry.Append(" ORDER BY NumSAP DESC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Listado_OrdenesOtras() As DataTable

        Dim dt As New DataTable("dtListado_Produccion")

        Try
            Dim qry As New StringBuilder
            qry.Append(" Select ")
            qry.Append(" DocNum [NumSAP], ")
            qry.Append(" CASE  ")
            qry.Append(" WHEN Status = 'R' THEN 'Liberado'  ")
            qry.Append(" WHEN Status = 'P' THEN 'Planeado' 	 ")
            qry.Append(" WHEN Status = 'L' THEN 'Close'  ")
            qry.Append(" END [Estado], ")

            qry.Append(" CASE ")
            qry.Append(" WHEN Type = 'S' THEN 'Estándar' ")
            qry.Append(" WHEN Type = 'P' THEN 'Especial' ")
            qry.Append(" WHEN Type = 'D' THEN 'Desmontar' ")
            qry.Append(" END [Tipo], ")

            qry.Append(" CASE  ")
            qry.Append(" WHEN U_Tipo = '0' THEN 'Producción'  ")
            qry.Append(" WHEN U_Tipo = '1' THEN 'Ensamble'  ")
            qry.Append(" WHEN U_Tipo = '2' THEN 'Imprenta' ")
            qry.Append(" WHEN U_Tipo = '3' THEN 'Peines'  ")
            qry.Append(" WHEN U_Tipo = '4' THEN 'Pradera'  ")
            qry.Append(" ELSE '' ")
            qry.Append(" END [Origen], ")

            qry.Append(" ItemCode [CodigoArticulo], ")
            qry.Append(" CONVERT(INTEGER,PlannedQty) [Planeado], ")
            qry.Append(" CONVERT(INTEGER,CmpltQty) [Completado], ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (PlannedQty - CmpltQty) > 0 THEN (PlannedQty - CmpltQty) ELSE '0' END) [Pendiente], ")
            qry.Append(" CONVERT(DATE,PostDate,105) [Creación], ")
            qry.Append(" CONVERT(DATE,DueDate,105) [Vencimiento], ")
            qry.Append(" CONVERT(INTEGER,CONVERT(DATE,GETDATE(),105) - PostDate) [Dias Atrasado] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR ")
            qry.Append(" WHERE ItemCode not LIKE ('AR%') ")
            qry.Append(" AND ItemCode not LIKE ('CP%') ")
            qry.Append(" AND Status IN ('R','P') ")
            qry.Append(" ORDER BY NumSAP DESC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_Temporal_OrdenesCerradas(ByVal pNumSAP As String) As DataTable

        Dim dt As New DataTable("dtTemporal_OrdenesCerrar")

        Try
            Dim qry As New StringBuilder
            qry.Append(" Select ")
            qry.Append(" DocNum [NumSAP], ")
            qry.Append(" CASE  ")
            qry.Append(" WHEN Status = 'R' THEN 'Liberado'  ")
            qry.Append(" WHEN Status = 'P' THEN 'Planeado' 	 ")
            qry.Append(" WHEN Status = 'L' THEN 'Cerrado'  ")
            qry.Append(" END [Estado], ")

            qry.Append(" CASE ")
            qry.Append(" WHEN Type = 'S' THEN 'Estándar' ")
            qry.Append(" WHEN Type = 'P' THEN 'Especial' ")
            qry.Append(" WHEN Type = 'D' THEN 'Desmontar' ")
            qry.Append(" END [Tipo], ")

            qry.Append(" CASE  ")
            qry.Append(" WHEN U_Tipo = '0' THEN 'Producción'  ")
            qry.Append(" WHEN U_Tipo = '1' THEN 'Ensamble'  ")
            qry.Append(" WHEN U_Tipo = '2' THEN 'Imprenta' ")
            qry.Append(" WHEN U_Tipo = '3' THEN 'Peines'  ")
            qry.Append(" WHEN U_Tipo = '4' THEN 'Pradera'  ")
            qry.Append(" ELSE '' ")
            qry.Append(" END [Origen], ")

            qry.Append(" A.ItemCode [CodigoArticulo], ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" CONVERT(INTEGER,PlannedQty) [Planeado], ")
            qry.Append(" CONVERT(INTEGER,CmpltQty) [Completado], ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (PlannedQty - CmpltQty) > 0 THEN (PlannedQty - CmpltQty) ELSE '0' END) [Pendiente], ")
            qry.Append(" CONVERT(DATE,PostDate,105) [Creación], ")
            qry.Append(" CONVERT(DATE,DueDate,105) [Vencimiento], ")
            qry.Append(" CONVERT(INTEGER,CONVERT(DATE,GETDATE(),105) - PostDate) [Dias Atrasado], ")
            qry.Append(" CASE WHEN CmpltQty = 0 THEN 'SI' WHEN CONVERT(DECIMAL(18,2),100 - (CmpltQty * 100 / CONVERT(INTEGER,PlannedQty))) > 15  THEN 'SI' ELSE 'NO' END [Email] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.DocNum IN (" + pNumSAP + ") ")
            qry.Append(" ORDER BY A.DocNum ASC")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Temporal_OrdenesCerradas_EnviarPorCorreo(ByVal pNumSAP As String) As DataTable

        Dim dt As New DataTable("dtTemporal_OrdenesCerrar")

        Try
            Dim qry As New StringBuilder
            qry.Append(" Select ")
            qry.Append(" DocNum [NumSAP], ")
            qry.Append(" CASE  ")
            qry.Append(" WHEN Status = 'R' THEN 'Liberado'  ")
            qry.Append(" WHEN Status = 'P' THEN 'Planeado' 	 ")
            qry.Append(" WHEN Status = 'L' THEN 'Cerrado'  ")
            qry.Append(" END [Estado], ")

            qry.Append(" CASE ")
            qry.Append(" WHEN Type = 'S' THEN 'Estándar' ")
            qry.Append(" WHEN Type = 'P' THEN 'Especial' ")
            qry.Append(" WHEN Type = 'D' THEN 'Desmontar' ")
            qry.Append(" END [Tipo], ")

            qry.Append(" CASE  ")
            qry.Append(" WHEN U_Tipo = '0' THEN 'Producción'  ")
            qry.Append(" WHEN U_Tipo = '1' THEN 'Ensamble'  ")
            qry.Append(" WHEN U_Tipo = '2' THEN 'Imprenta' ")
            qry.Append(" WHEN U_Tipo = '3' THEN 'Peines'  ")
            qry.Append(" WHEN U_Tipo = '4' THEN 'Pradera'  ")
            qry.Append(" ELSE '' ")
            qry.Append(" END [Origen], ")

            qry.Append(" A.ItemCode [CodigoArticulo], ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" CONVERT(INTEGER,PlannedQty) [Planeado], ")
            qry.Append(" CONVERT(INTEGER,CmpltQty) [Completado], ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (PlannedQty - CmpltQty) > 0 THEN (PlannedQty - CmpltQty) ELSE '0' END) [Pendiente], ")
            qry.Append(" CONVERT(DATE,PostDate,105) [Creación], ")
            qry.Append(" CONVERT(DATE,DueDate,105) [Vencimiento], ")
            qry.Append(" CONVERT(INTEGER,CONVERT(DATE,GETDATE(),105) - PostDate) [Dias Atrasado], ")
            qry.Append(" CASE WHEN CmpltQty = 0 THEN 'SI' WHEN CONVERT(DECIMAL(18,2),100 - (CmpltQty * 100 / CONVERT(INTEGER,PlannedQty))) > 15  THEN 'SI' ELSE 'NO' END [Email] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.DocNum IN (" + pNumSAP + ") ")
            qry.Append(" AND CONVERT(DECIMAL(18,2),100 - (CmpltQty * 100 / CONVERT(INTEGER,PlannedQty))) > 15 ")
            qry.Append(" ORDER BY A.DocNum ASC")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Listado_CodigosProducidos() As DataTable

        Dim dt As New DataTable("dtTemporal_OrdenesCerrar")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT ")
            qry.Append(" A.Id, ")
            qry.Append(" C.ItemName [Descripcion], ")
            'qry.Append(" A.Descripcion, ")
            qry.Append(" A.Material1, ")
            qry.Append(" A.Material1Porc, ")
            qry.Append(" A.Material2, ")
            qry.Append(" A.Material2Porc, ")
            qry.Append(" A.Material3, ")
            qry.Append(" A.Molde, ")
            qry.Append(" B.Nombre, ")
            qry.Append(" A.Estatus, ")
            qry.Append(" A.Bit_CreacionUsuario, ")
            qry.Append(" A.Bit_CreacionFecha, ")
            qry.Append(" A.Bit_ModificacionUsuario, ")
            qry.Append(" A.Bit_ModificacionFecha ")
            qry.Append(" FROM APGProduccion.dbo.PROD_CodigosProducidos A ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Moldes B ON B.Id = A.Molde ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM C ON C.ItemCode = A.Id COLLATE SQL_Latin1_General_CP1_CI_AS ")
            qry.Append(" ORDER BY Id ASC ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Listado_CodigosProducidos(ByVal pCodigo As String) As DataTable

        Dim dt As New DataTable("dtCodigosProducidos_Seleccion")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT ")
            qry.Append(" A.Id, ")
            qry.Append(" C.ItemName [Descripcion],  ")
            qry.Append(" LTRIM(RTRIM(A.Material1)) [Material1], ")
            qry.Append(" A.Material1Porc, ")
            qry.Append(" LTRIM(RTRIM(A.Material2)) [Material2], ")
            qry.Append(" A.Material2Porc, ")
            qry.Append(" LTRIM(RTRIM(A.Material3)) [Material3], ")
            qry.Append(" A.Molde, ")
            qry.Append(" B.Nombre, ")
            qry.Append(" A.Estatus, ")
            qry.Append(" A.Bit_CreacionUsuario, ")
            qry.Append(" A.Bit_CreacionFecha, ")
            qry.Append(" A.Bit_ModificacionUsuario, ")
            qry.Append(" A.Bit_ModificacionFecha ")
            qry.Append(" FROM APGProduccion.dbo.PROD_CodigosProducidos A ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Moldes B ON B.Id = A.Molde ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM C ON C.ItemCode COLLATE SQL_Latin1_General_CP1_CI_AS = A.Id ")
            qry.Append(" WHERE A.Id = '" + pCodigo + "'")
            qry.Append(" ORDER BY Id ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Impresion_ParametrosOrdenes(ByVal pCodigo As String) As DataTable

        Dim dt As New DataTable("dtCodigosProducidos_Seleccion")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT ")
            qry.Append(" QRY1.Id_Nivel1, ")
            qry.Append(" QRY1.Id_Nivel2, ")
            qry.Append(" (SELECT TOP 1 ")
            qry.Append(" CodigoArticulo ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle AA ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OWOR B ON B.DocNum = AA.NumeroSAP  ")
            qry.Append(" WHERE Id IN ( ")
            qry.Append(" Select C.Id ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A  ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Ordenes_Detalle C ON C.NumeroSAP = A.DocNum ")
            qry.Append(" WHERE A.Status IN ('R','P')  ")
            qry.Append(" AND A.ItemCode LIKE ('" + pCodigo + "%')) ")
            qry.Append(" AND AA.Tipo IN ('PE') ")
            qry.Append(" AND AA.CodigoArticulo LIKE ('" + pCodigo + "%') ")
            qry.Append(" AND AA.Id = QRY1.Id ")
            qry.Append(" ) [CodigoHijo], ")

            qry.Append(" (SELECT TOP 1  SUBSTRING(CodigoArticulo,1,8) [CodigoPadre]  ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle AA   ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OWOR B ON B.DocNum = AA.NumeroSAP    ")
            qry.Append(" WHERE Id IN (   ")
            qry.Append(" Select C.Id  FROM SBOGuateplast.dbo.OWOR A    ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Ordenes_Detalle C ON C.NumeroSAP = A.DocNum   ")
            qry.Append(" WHERE A.Status IN ('R','P')   AND A.ItemCode LIKE ('" + pCodigo + "%'))  AND AA.Tipo IN ('PE')  AND AA.CodigoArticulo LIKE ('" + pCodigo + "%')  AND AA.Id = QRY1.Id  ) [CodigoPadreHijo],   ")
            'qry.Append(" WHERE A.Status IN ('R','P')   AND A.ItemCode LIKE ('CP007141%'))  AND AA.Tipo IN ('PE')  AND AA.CodigoArticulo LIKE ('CP007141%')  AND AA.Id = QRY1.Id  ) [CodigoPadreHijo],   ")

            qry.Append(" (SELECT TOP 1  C.U_Color [ColorHijo]  ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle AA   ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OWOR B ON B.DocNum = AA.NumeroSAP    ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM C ON C.ItemCode = B.ItemCode ")
            qry.Append(" WHERE Id IN (   ")
            qry.Append(" Select C.Id  FROM SBOGuateplast.dbo.OWOR A    ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Ordenes_Detalle C ON C.NumeroSAP = A.DocNum   ")
            qry.Append(" WHERE A.Status IN ('R','P')   AND A.ItemCode LIKE ('" + pCodigo + "%'))   ")
            'qry.Append(" WHERE A.Status IN ('R','P')   AND A.ItemCode LIKE ('CP007141%'))   ")
            qry.Append(" AND AA.Tipo IN ('PE')  AND AA.CodigoArticulo LIKE ('" + pCodigo + "%')  AND AA.Id = QRY1.Id  ) [ColorHijo],   ")
            'qry.Append(" AND AA.Tipo IN ('PE')  AND AA.CodigoArticulo LIKE ('CP007141%')  AND AA.Id = QRY1.Id  ) [ColorHijo],   ")

            qry.Append(" QRY1.Id, ")
            qry.Append(" CASE WHEN QRY1.Tipo = 'EE' THEN 'ENSAMBLE' when QRY1.Tipo = 'PE' THEN 'PRODUCCION' ELSE '' END [Tipo] , ")
            qry.Append(" QRY1.NumeroSAP,CodigoArticulo,SUBSTRING(CodigoArticulo,1,8) [CodigoPadre] ,DD.ItemName [NombreArticulo],DD.U_Color [ColorSAP],DD.CodeBars [CodigoBarras],DD.U_Upc [UPC],QRY1.Unidades, QRY1.Pendiente,")
            qry.Append(" UPPER(BB.Nombre) [Origen],QRY1.Destino,QRY1.Color,CC.GroupName [GrupoCliente],QRY1.CodigoCliente,QRY1.NumeroOrden, ")
            qry.Append(" QRY1.NumeroCampana, QRY1.Entrega, QRY1.Comentario_Nivel1, QRY1.Comentario_Nivel2, QRY1.SAP, QRY1.Estatus, QRY1.Bit_UsuarioCreacion, ")
            qry.Append(" QRY1.Bit_FechaCreacion, QRY1.Bit_UsuarioModificacion, QRY1.Bit_FechaModificacion ")
            qry.Append(" FROM ")
            qry.Append(" (SELECT Id,	Id_Nivel1,	Id_Nivel2,	Tipo,	NumeroSAP,	CodigoArticulo,	Unidades, (B.PlannedQty - B.CmpltQty) [Pendiente],	Origen,	Destino, ")
            qry.Append(" Color,	GrupoCliente,	CodigoCliente,	NumeroOrden,	NumeroCampana,	Entrega, ")
            qry.Append(" CONVERT(VARCHAR(250),Comentario_Nivel1) [Comentario_Nivel1], ")
            qry.Append(" CONVERT(VARCHAR(250),Comentario_Nivel2) [Comentario_Nivel2], ")
            qry.Append(" SAP, Estatus, Bit_UsuarioCreacion, Bit_FechaCreacion, Bit_UsuarioModificacion, Bit_FechaModificacion ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle A  ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OWOR B ON B.DocNum = A.NumeroSAP  ")
            qry.Append(" WHERE Id IN ( ")
            qry.Append(" Select C.Id ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A  ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Ordenes_Detalle C ON C.NumeroSAP = A.DocNum ")
            qry.Append(" WHERE A.Status IN ('R','P')  ")
            qry.Append(" AND A.ItemCode LIKE ('" + pCodigo + "%')) ")
            qry.Append(" AND A.Tipo IN ('EE') ")
            qry.Append(" UNION ")
            qry.Append(" SELECT  ")
            qry.Append(" Id,	Id_Nivel1,	Id_Nivel2,	Tipo,	NumeroSAP,	CodigoArticulo,	Unidades,  (B.PlannedQty - B.CmpltQty) [Pendiente],	Origen,	Destino, ")
            qry.Append(" Color,	GrupoCliente,	CodigoCliente,	NumeroOrden,	NumeroCampana,	Entrega, ")
            qry.Append(" CONVERT(VARCHAR(250),Comentario_Nivel1) [Comentario_Nivel1], ")
            qry.Append(" CONVERT(VARCHAR(250),Comentario_Nivel2) [Comentario_Nivel2], ")
            qry.Append(" SAP, Estatus, Bit_UsuarioCreacion, Bit_FechaCreacion, Bit_UsuarioModificacion, Bit_FechaModificacion ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle A  ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OWOR B ON B.DocNum = A.NumeroSAP  ")
            qry.Append(" WHERE Id IN ( ")
            qry.Append(" Select C.Id ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A  ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Ordenes_Detalle C ON C.NumeroSAP = A.DocNum ")
            qry.Append(" WHERE A.Status IN ('R','P')  ")
            qry.Append(" AND A.ItemCode LIKE ('" + pCodigo + "%')) ")
            qry.Append(" AND A.Tipo IN ('PE') ")
            qry.Append(" AND A.CodigoArticulo LIKE ('" + pCodigo + "%')) QRY1 ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_CatListados BB ON BB.id = QRY1.Origen AND BB.TipoListado = 'Orden_Origen' ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OCRG CC ON CC.GroupCode = QRY1.GrupoCliente ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM DD ON DD.ItemCode = QRY1.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS ")
            'qry.Append(" ORDER BY Id ASC ")
            qry.Append(" ORDER BY CodigoArticulo Desc ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Impresion_ParametrosOrdenes_CodigosArticulos(ByVal pCodigo As String) As DataTable

        Dim dt As New DataTable("dtCodigosProducidos_Seleccion")

        Try
            Dim qry As New StringBuilder
            qry.Append("             SELECT ")
            qry.Append("  QRY1.Id ")
            qry.Append("  FROM ")
            qry.Append("  (SELECT Id,	Id_Nivel1,	Id_Nivel2,	Tipo,	NumeroSAP,	CodigoArticulo,	Unidades, (B.PlannedQty - B.CmpltQty) [Pendiente],	Origen,	Destino, ")
            qry.Append("  Color,	GrupoCliente,	CodigoCliente,	NumeroOrden,	NumeroCampana,	Entrega, ")
            qry.Append("  CONVERT(VARCHAR(250),Comentario_Nivel1) [Comentario_Nivel1], ")
            qry.Append("  CONVERT(VARCHAR(250),Comentario_Nivel2) [Comentario_Nivel2], ")
            qry.Append("  SAP, Estatus, Bit_UsuarioCreacion, Bit_FechaCreacion, Bit_UsuarioModificacion, Bit_FechaModificacion ")
            qry.Append("  FROM APGProduccion.dbo.PROD_Ordenes_Detalle A  ")
            qry.Append("  LEFT JOIN SBOGuateplast.dbo.OWOR B ON B.DocNum = A.NumeroSAP  ")
            qry.Append("  WHERE Id IN ( ")
            qry.Append("  Select C.Id ")
            qry.Append("  FROM SBOGuateplast.dbo.OWOR A  ")
            qry.Append("  LEFT JOIN APGProduccion.dbo.PROD_Ordenes_Detalle C ON C.NumeroSAP = A.DocNum ")
            qry.Append("  WHERE A.Status IN ('R','P')  ")
            qry.Append("  AND A.ItemCode LIKE ('" + pCodigo + "%')) ")
            qry.Append("  AND A.Tipo IN ('EE') ")
            qry.Append("  UNION ")
            qry.Append("  SELECT  ")
            qry.Append("  Id,	Id_Nivel1,	Id_Nivel2,	Tipo,	NumeroSAP,	CodigoArticulo,	Unidades,  (B.PlannedQty - B.CmpltQty) [Pendiente],	Origen,	Destino, ")
            qry.Append("  Color,	GrupoCliente,	CodigoCliente,	NumeroOrden,	NumeroCampana,	Entrega, ")
            qry.Append("  CONVERT(VARCHAR(250),Comentario_Nivel1) [Comentario_Nivel1], ")
            qry.Append("  CONVERT(VARCHAR(250),Comentario_Nivel2) [Comentario_Nivel2], ")
            qry.Append("  SAP, Estatus, Bit_UsuarioCreacion, Bit_FechaCreacion, Bit_UsuarioModificacion, Bit_FechaModificacion ")
            qry.Append("  FROM APGProduccion.dbo.PROD_Ordenes_Detalle A  ")
            qry.Append("  LEFT JOIN SBOGuateplast.dbo.OWOR B ON B.DocNum = A.NumeroSAP  ")
            qry.Append("  WHERE Id IN ( ")
            qry.Append("  Select C.Id ")
            qry.Append("  FROM SBOGuateplast.dbo.OWOR A  ")
            qry.Append("  LEFT JOIN APGProduccion.dbo.PROD_Ordenes_Detalle C ON C.NumeroSAP = A.DocNum ")
            qry.Append("  WHERE A.Status IN ('R','P')  ")
            qry.Append("  AND A.ItemCode LIKE ('" + pCodigo + "%')) ")
            qry.Append("  AND A.Tipo IN ('PE') ")
            qry.Append("  AND A.CodigoArticulo LIKE ('" + pCodigo + "%')) QRY1 ")
            qry.Append("  LEFT JOIN APGProduccion.dbo.PROD_CatListados BB ON BB.id = QRY1.Origen AND BB.TipoListado = 'Orden_Origen' ")
            qry.Append("  LEFT JOIN SBOGuateplast.dbo.OCRG CC ON CC.GroupCode = QRY1.GrupoCliente ")
            qry.Append("  LEFT JOIN SBOGuateplast.dbo.OITM DD ON DD.ItemCode = QRY1.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS ")
            qry.Append("  WHERE SUBSTRING(CodigoArticulo,1,2) IN ('AR')  ")
            qry.Append("  GROUP BY QRY1.Id  ")
            qry.Append("  ORDER BY QRY1.Id ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function



    Public Function GET_Listado(ByVal pTipoListado As String) As DataTable

        Dim dt As New DataTable("dtEstatus")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT Id, ")
            qry.Append(" Nombre, ")
            qry.Append(" Descripcion ")
            qry.Append(" FROM APGProduccion.dbo.PROD_CatListados ")
            qry.Append(" WHERE TipoListado = '" + pTipoListado + "' ")
            qry.Append(" ORDER BY OrdenPor ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Listado_Moldes() As DataTable

        Dim dt As New DataTable("dtEstatus")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT ")
            qry.Append(" Id, ")
            qry.Append(" Nombre, ")
            qry.Append(" Cavidades, ")
            qry.Append(" MaquinaPreferencial, ")
            qry.Append(" Bodega, ")
            qry.Append(" Ubicacion ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Moldes ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Listado_Moldes(ByVal pMolde As String) As DataTable

        Dim dt As New DataTable("dtEstatus")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT * ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Moldes ")
            qry.Append(" WHERE Id = " + pMolde + " ")
            qry.Append(" ORDER BY Id ASC ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Search_Molde(ByVal pMolde As String, ByVal pSerieMolde As String) As DataTable

        Dim dt As New DataTable("dtEstatus")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT * ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Moldes ")
            qry.Append(" WHERE Id = '" + pMolde + "' ")
            qry.Append(" AND MoldeSerie = '" + pSerieMolde + "' ")
            qry.Append(" ORDER BY Id ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Search_Molde() As DataTable

        Dim dt As New DataTable("dtEstatus")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT * ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Moldes ")
            qry.Append(" ORDER BY Id ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Listado_Materiales() As DataTable

        Dim dt As New DataTable("dtMateriales")

        Try
            Dim qry As New StringBuilder
            qry.Append(" SELECT ")
            qry.Append(" Id, ")
            qry.Append(" Descripcion ")
            'qry.Append(" CASE WHEN Estatus = 1 THEN 'Activo' ELSE 'Inactivo' END [Estatus] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Materiales ")
            qry.Append(" WHERE Estatus = 1 ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Listado_CodigosProducidos_Nuevos() As DataTable

        Dim dt As New DataTable("dtMateriales")

        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" ItemCode [CodigoArticulo], ")
            qry.Append(" ItemName [NombreArticulo] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM ")
            qry.Append(" WHERE ItemCode LIKE ('CP%') ")
            qry.Append(" AND LEN(ItemCode) = 8 ")
            qry.Append(" AND ItemCode COLLATE SQL_Latin1_General_CP850_CI_AS not in( ")
            qry.Append(" SELECT Id FROM APGProduccion.dbo.PROD_CodigosProducidos) ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Listado_ParametrosEnsamble_Nuevos() As DataTable

        Dim dt As New DataTable("dtMateriales")

        Try
            Dim qry As New StringBuilder

            qry.Append("  SELECT ")
            qry.Append(" ItemCode [CodigoArticulo],  ")
            qry.Append(" ItemName [NombreArticulo] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM ")
            qry.Append(" WHERE ItemCode LIKE ('AR%')  ")
            qry.Append(" AND LEN(ItemCode) = 8  ")
            qry.Append(" AND ItemCode COLLATE SQL_Latin1_General_CP850_CI_AS not in(  ")
            qry.Append(" SELECT CodigoArticulo FROM APGProduccion.dbo.PROD_Ensamble_Parametros)  ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_Listado_ParametrosProduccion_Nuevos() As DataTable

        Dim dt As New DataTable("dtMateriales")

        Try
            Dim qry As New StringBuilder

            qry.Append("  SELECT ")
            qry.Append(" ItemCode [CodigoArticulo],  ")
            qry.Append(" ItemName [NombreArticulo] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM ")
            qry.Append(" WHERE ItemCode LIKE ('CP%') ")
            qry.Append(" AND LEN(ItemCode) = 8  ")
            qry.Append(" AND ItemCode COLLATE SQL_Latin1_General_CP850_CI_AS not in(  ")
            qry.Append(" SELECT Id FROM APGProduccion.dbo.PROD_Produccion_Parametros) ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_Search_CodigoProducido(ByVal pCodigoArticulo As String) As DataTable

        Dim dt As New DataTable("dtMateriales")

        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT * ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM ")
            qry.Append(" WHERE ItemCode = '" + pCodigoArticulo + "' ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Search_Moldes(ByVal pCodigoMolde As String) As DataTable
        Dim dt As New DataTable("dtMoldes")
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT * ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Moldes ")
            qry.Append(" WHERE Id = '" + pCodigoMolde + "' ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Listado_Maquinas() As DataTable
        Dim dt As New DataTable("dtMoldes")
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT Id, ")
            qry.Append(" Nombre, ")
            qry.Append(" Tipo, ")
            qry.Append(" Grupo ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Maquinas ")
            qry.Append(" ORDER BY Id ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Listado_MaquinasNoAsignadas(ByVal pMaquinas As String) As DataTable
        Dim dt As New DataTable("dtMoldes")
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT id, ")
            qry.Append(" Estatus  ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Maquinas ")

            If Not pMaquinas = String.Empty Then
                qry.Append(" WHERE Id NOT IN (" + pMaquinas + ")  ")
            End If

            qry.Append(" ORDER BY Id ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Listado_MaquinasBodegas() As DataTable
        Dim dt As New DataTable("dtBodegasMoldes")
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT Id [Id], ")
            qry.Append(" Nombre [Nombre], ")
            qry.Append(" Direccion [Direccion], ")
            qry.Append(" Estatus [Estatus] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Bodegas ")
            qry.Append(" ORDER BY Nombre ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Listado_MaquinasBodegas(ByVal pIdBodega As String) As DataTable
        Dim dt As New DataTable("dtBodegasMoldes")
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT Id [Id], ")
            qry.Append(" Nombre [Nombre], ")
            qry.Append(" Direccion [Direccion], ")
            qry.Append(" Estatus [Estatus] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Bodegas ")
            qry.Append(" WHERE Id = '" + pIdBodega + "' ")
            qry.Append(" ORDER BY Nombre ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Validaciones"
    Public Function GET_Validacion_Disponibilidad_CP(ByVal pCodigoArticulo As String) As DataTable
        Dim dt As New DataTable("dtBodegasMoldes")
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ItemCode [CodigoArticulo] FROM SBOGuateplast.dbo.OITM ")
            qry.Append(" WHERE ItemCode = " + pCodigoArticulo + " ")
            qry.Append(" UNION ")
            qry.Append(" SELECT Code [CodigoArticulo]  ")
            qry.Append(" FROM SBOGuateplast.dbo.ITT1 ")
            qry.Append(" WHERE Father = " + pCodigoArticulo + " ")
            qry.Append(" AND (Code LIKE ('AR%') OR Code LIKE ('CP%')) ")
            qry.Append(" UNION  ")
            qry.Append(" SELECT Code [CodigoArticulo] FROM SBOGuateplast.dbo.ITT1 ")
            qry.Append(" WHERE Father IN (  ")
            qry.Append(" SELECT Code [CodigoArticulo]  ")
            qry.Append(" FROM SBOGuateplast.dbo.ITT1 ")
            qry.Append(" WHERE Father = " + pCodigoArticulo + " ")
            qry.Append(" AND (Code LIKE ('AR%') OR Code LIKE ('CP%')))  ")
            qry.Append(" AND (CODE LIKE ('AR%') OR Code LIKE ('CP%')) ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Validacion_CP(ByVal pCodigoArticulo As String) As DataTable
        Dim dt As New DataTable("dtBodegasMoldes")
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" Programa [Programa], ")
            qry.Append(" Ventana [Ventana], ")
            qry.Append(" CodigoArticulo [CodigoArticulo], ")
            qry.Append(" Bit_Usuario [Usuario], ")
            qry.Append(" Bit_Fecha [Fecha/Hora] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Estatus_Articulos ")
            qry.Append(" WHERE CodigoArticulo = " + pCodigoArticulo + " ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Validacion_CP_OtrosUsuarios(ByVal pUsuario As String) As DataTable
        Dim dt As New DataTable("dtBodegasMoldes")
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" Programa [Programa], ")
            qry.Append(" Ventana [Ventana], ")
            qry.Append(" CodigoArticulo [CodigoArticulo], ")
            qry.Append(" Bit_Usuario [Usuario], ")
            qry.Append(" Bit_Fecha [Fecha/Hora] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Estatus_Articulos ")
            qry.Append(" WHERE NOT Bit_Usuario = '" + pUsuario + "' ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Validacion_CP_Formato() As DataTable
        Dim dt As New DataTable("dtBodegasMoldes")
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT TOP 0 ")
            qry.Append(" Programa [Programa], ")
            qry.Append(" Ventana [Ventana], ")
            qry.Append(" CodigoArticulo [CodigoArticulo], ")
            qry.Append(" Bit_Usuario [Usuario], ")
            qry.Append(" Bit_Fecha [Fecha/Hora] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Estatus_Articulos ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    'Public Function GET_Catalogo_Maquinas() As DataTable
    '    Try
    '        Dim qry As New StringBuilder

    '        qry.Append(" SELECT ")
    '        qry.Append(" Id, ")
    '        qry.Append(" Nombre, ")
    '        qry.Append(" Modelo, ")
    '        qry.Append(" Grupo, ")
    '        qry.Append(" CONVERT(TEXT,Tipo) [Tipo],")
    '        qry.Append(" Mantenimiento, ")
    '        qry.Append(" MantenimientoFecha, ")
    '        qry.Append(" Estatus, ")
    '        qry.Append(" Bit_CreacionUsuario, ")
    '        qry.Append(" Bit_CreacionFecha, ")
    '        qry.Append(" Bit_ModificacionUsuario, ")
    '        qry.Append(" Bit_ModificacionFecha ")
    '        qry.Append(" FROM APGProduccion.dbo.PROD_Maquinas ")
    '        qry.Append(" ORDER BY Id ASC ")

    '        Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message)
    '        Return Nothing
    '    End Try
    'End Function

    Public Function GET_Catalogo_Maquinas() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT  ")
            qry.Append("  Id,  ")
            qry.Append(" Nombre,  ")
            qry.Append(" Modelo,  ")
            qry.Append(" Serie, ")
            qry.Append(" Grupo, ")
            qry.Append(" Ubicacion, ")
            qry.Append(" Toneladas, ")
            qry.Append(" LibrasHoras,  ")
            qry.Append(" CONVERT(TEXT,Tipo) [Tipo], ")
            qry.Append(" InyeccionOz, ")
            qry.Append(" InyeccionGr, ")
            qry.Append(" PrensaCierreMAX, ")
            qry.Append(" PrensaCierreMIN, ")
            qry.Append(" PrensaCierreCARRERA, ")
            qry.Append(" CarreraExpulsionMM, ")
            qry.Append(" BarrasDistanciaHOR, ")
            qry.Append(" BarrasDistanciaVER, ")
            qry.Append(" PlatinasDimencionesHOR, ")
            qry.Append(" PlatinasDimencionesVER, ")
            qry.Append(" AnilloCentrador, ")
            qry.Append(" Mantenimiento, ")
            qry.Append(" MantenimientoFecha, ")
            qry.Append(" CambioMolde_Hora, ")
            qry.Append(" Estatus, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha, ")
            qry.Append(" Bit_ModificacionUsuario, ")
            qry.Append(" Bit_ModificacionFecha ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Maquinas ")
            qry.Append(" ORDER BY Id ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Catalogo_Maquinas_ConExcepciones(ByVal pExcepciones As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT  ")
            qry.Append("  Id,  ")
            qry.Append(" Nombre,  ")
            qry.Append(" Modelo,  ")
            qry.Append(" Serie, ")
            qry.Append(" Grupo, ")
            qry.Append(" Ubicacion, ")
            qry.Append(" Toneladas, ")
            qry.Append(" LibrasHoras,  ")
            qry.Append(" CONVERT(TEXT,Tipo) [Tipo], ")
            qry.Append(" InyeccionOz, ")
            qry.Append(" InyeccionGr, ")
            qry.Append(" PrensaCierreMAX, ")
            qry.Append(" PrensaCierreMIN, ")
            qry.Append(" PrensaCierreCARRERA, ")
            qry.Append(" CarreraExpulsionMM, ")
            qry.Append(" BarrasDistanciaHOR, ")
            qry.Append(" BarrasDistanciaVER, ")
            qry.Append(" PlatinasDimencionesHOR, ")
            qry.Append(" PlatinasDimencionesVER, ")
            qry.Append(" AnilloCentrador, ")
            qry.Append(" Mantenimiento, ")
            qry.Append(" MantenimientoFecha, ")
            qry.Append(" Estatus, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha, ")
            qry.Append(" Bit_ModificacionUsuario, ")
            qry.Append(" Bit_ModificacionFecha ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Maquinas ")
            qry.Append(" WHERE Id NOT IN (" + pExcepciones + ") ")
            qry.Append(" AND Estatus = '1' ")
            qry.Append(" ORDER BY Id ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    'Public Function GET_Catalogo_Maquinas(ByVal pMaquina As String) As DataTable
    '    Try
    '        Dim qry As New StringBuilder

    '        qry.Append(" SELECT ")
    '        qry.Append(" Id, ")
    '        qry.Append(" Nombre, ")
    '        qry.Append(" Modelo, ")
    '        qry.Append(" Grupo, ")
    '        qry.Append(" Tipo, ")
    '        qry.Append(" Mantenimiento, ")
    '        qry.Append(" MantenimientoFecha, ")
    '        qry.Append(" Estatus, ")
    '        qry.Append(" Bit_CreacionUsuario, ")
    '        qry.Append(" Bit_CreacionFecha, ")
    '        qry.Append(" Bit_ModificacionUsuario, ")
    '        qry.Append(" Bit_ModificacionFecha ")
    '        qry.Append(" FROM APGProduccion.dbo.PROD_Maquinas ")
    '        qry.Append(" WHERE Id = ('" + pMaquina + "') ")
    '        qry.Append(" ORDER BY Id ASC ")

    '        Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message)
    '        Return Nothing
    '    End Try
    'End Function

    Public Function GET_Catalogo_Maquinas(ByVal pMaquina As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT  ")
            qry.Append("  Id,  ")
            qry.Append(" Nombre,  ")
            qry.Append(" Modelo,  ")
            qry.Append(" Serie, ")
            qry.Append(" Grupo, ")
            qry.Append(" Ubicacion, ")
            qry.Append(" Toneladas, ")
            qry.Append(" LibrasHoras,  ")
            qry.Append(" CONVERT(TEXT,Tipo) [Tipo], ")
            qry.Append(" InyeccionOz, ")
            qry.Append(" InyeccionGr, ")
            qry.Append(" PrensaCierreMAX, ")
            qry.Append(" PrensaCierreMIN, ")
            qry.Append(" PrensaCierreCARRERA, ")
            qry.Append(" CarreraExpulsionMM, ")
            qry.Append(" BarrasDistanciaHOR, ")
            qry.Append(" BarrasDistanciaVER, ")
            qry.Append(" PlatinasDimencionesHOR, ")
            qry.Append(" PlatinasDimencionesVER, ")
            qry.Append(" AnilloCentrador, ")
            qry.Append(" Mantenimiento, ")
            qry.Append(" MantenimientoFecha, ")
            qry.Append(" CambioMolde_Hora, ")
            qry.Append(" Estatus, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha, ")
            qry.Append(" Bit_ModificacionUsuario, ")
            qry.Append(" Bit_ModificacionFecha ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Maquinas ")
            qry.Append(" WHERE Id = ('" + pMaquina + "') ")
            qry.Append(" ORDER BY Id ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_Catalogo_MoldesMaquinas() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" Molde, ")
            qry.Append(" Nombre, ")
            qry.Append(" Maquina, ")
            qry.Append(" Material1, ")
            qry.Append(" Material2, ")
            qry.Append(" UnidadesXHora, ")
            qry.Append(" InyeccionesXHora, ")
            qry.Append(" CostoHoraNormal, ")
            qry.Append(" CostoHoraIncremento, ")
            qry.Append(" A.Estatus, ")
            qry.Append(" A.Bit_CreacionUsuario, ")
            qry.Append(" A.Bit_CreacionFecha, ")
            qry.Append(" A.Bit_ModificacionUsuario, ")
            qry.Append(" A.Bit_ModificacionFecha ")
            qry.Append(" FROM APGProduccion.dbo.PROD_MoldesMaquinas A ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Moldes B ON B.Id = A.Molde ")
            qry.Append(" ORDER BY ")
            qry.Append(" Molde, ")
            qry.Append(" Maquina, ")
            qry.Append(" Material1, ")
            qry.Append(" Material2 Asc ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Catalogo_MoldesMaquinas(ByVal pMolde As String, ByVal pMaquina As String, ByVal pMaterial1 As String, ByVal pMaterial2 As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" Molde, ")
            qry.Append(" Nombre, ")
            qry.Append(" Maquina, ")
            qry.Append(" Material1, ")
            qry.Append(" Material2, ")
            qry.Append(" UnidadesXHora, ")
            qry.Append(" InyeccionesXHora, ")
            qry.Append(" CostoHoraNormal, ")
            qry.Append(" CostoHoraIncremento, ")
            qry.Append(" A.Estatus, ")
            qry.Append(" A.Bit_CreacionUsuario, ")
            qry.Append(" A.Bit_CreacionFecha, ")
            qry.Append(" A.Bit_ModificacionUsuario, ")
            qry.Append(" A.Bit_ModificacionFecha ")
            qry.Append(" FROM APGProduccion.dbo.PROD_MoldesMaquinas A ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Moldes B ON B.Id = A.Molde ")
            qry.Append(" WHERE A.Molde = '" + pMolde + "'  ")
            qry.Append(" AND A.Maquina = '" + pMaquina + "' ")
            qry.Append(" AND A.Material1 = '" + pMaterial1 + "'  ")
            qry.Append(" AND A.Material2 = '" + pMaterial2 + "'  ")
            qry.Append(" ORDER BY ")
            qry.Append(" Molde, ")
            qry.Append(" Maquina, ")
            qry.Append(" Material1, ")
            qry.Append(" Material2 Asc ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Catalogo_MoldesMaquinas(ByVal pMolde As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" Maquina, ")
            qry.Append(" Material1, ")
            qry.Append(" Material2, ")
            qry.Append(" A.Estatus ")
            qry.Append(" FROM APGProduccion.dbo.PROD_MoldesMaquinas A ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Moldes B ON B.Id = A.Molde ")
            qry.Append(" WHERE A.Molde = '" + pMolde + "'  ")
            qry.Append(" ORDER BY ")
            qry.Append(" Prioridad ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Catalogo_ComponentesMaquinas(ByVal pComponente As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" Prioridad, ")
            qry.Append(" Maquina, ")
            qry.Append(" Estatus ")
            qry.Append(" FROM APGProduccion.dbo.PROD_ComponentesMaquinas ")
            qry.Append(" WHERE Componente = '" + pComponente + "' ")
            qry.Append(" ORDER BY Prioridad ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function



    Public Function GET_PorcEficienciaMaquinas() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" Fecha, ")
            qry.Append(" Porcentaje, ")
            qry.Append(" Bit_CreacionFecha, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_ModificacionUsuario, ")
            qry.Append(" Bit_ModificacionFecha ")
            qry.Append(" FROM APGProduccion.dbo.PROD_PorcEficienciaMaquinas ")
            qry.Append(" ORDER BY Fecha DESC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_PorcEficienciaMaquinas(ByVal pFecha As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" Fecha, ")
            qry.Append(" Porcentaje, ")
            qry.Append(" Bit_CreacionFecha, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_ModificacionUsuario, ")
            qry.Append(" Bit_ModificacionFecha ")
            qry.Append(" FROM APGProduccion.dbo.PROD_PorcEficienciaMaquinas ")
            qry.Append(" WHERE Fecha = '" + pFecha + "' ")
            qry.Append(" ORDER BY Fecha DESC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_PorcEficienciaMaquinas_LOG() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" Fecha, ")
            qry.Append(" Porcentaje, ")
            qry.Append(" Bit_CreacionFecha, ")
            qry.Append(" Bit_CreacionUsuario ")
            qry.Append(" FROM APGProduccion.dbo.PROD_PorcEficienciaMaquinas_LOG ")
            qry.Append(" ORDER BY Fecha DESC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

#End Region

    Public Function GET_Catalogo_ListaPrecios() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" ListNum [Id], ")
            qry.Append(" ListName [Nombre] ")
            qry.Append(" FROM SBOGuateplast.dbo.OPLN ")
            qry.Append(" ORDER BY ListNum ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_ListaPrecios(ByVal pListaPrecios As String) As String
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()

            qry.Append(" SELECT ")
            qry.Append(" ListNum [Id], ")
            qry.Append(" ListName [Nombre] ")
            qry.Append(" FROM SBOGuateplast.dbo.OPLN ")
            qry.Append(" WHERE ListNum = '" + pListaPrecios + "' ")
            qry.Append(" ORDER BY ListNum ASC ")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar
            Return dt.Rows(0)("Nombre").ToString

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_ListaPrecios_ArticulosSinPrecios(ByVal pListaPrecios As String) As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()

            qry.Append(" SELECT A.ItemCode [CodigoArticulo] , ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" A.Price [Precio], ")
            qry.Append(" A.Currency [Moneda] ")
            qry.Append(" FROM SBOGuateplast.dbo.ITM1 A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.ItemCode in (select ItemCode from SBOGuateplast.dbo.OITM H ")
            qry.Append(" WHERE H.ItemCode LIKE ('AR%') ")
            qry.Append(" AND LEN(H.ItemCode) > 8) ")
            qry.Append(" AND PriceList = '" + pListaPrecios + "' ")
            qry.Append(" AND Price = '0' ")
            qry.Append(" ORDER BY A.ItemCode ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_ListaPrecios_ArticulosConPrecios(ByVal pListaPrecios As String) As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()

            qry.Append(" SELECT A.ItemCode [CodigoArticulo] , ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" A.Price [Precio], ")
            qry.Append(" A.Currency [Moneda] ")
            qry.Append(" FROM SBOGuateplast.dbo.ITM1 A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.ItemCode in (select ItemCode from SBOGuateplast.dbo.OITM H ")
            qry.Append(" WHERE H.ItemCode LIKE ('AR%') ")
            qry.Append(" AND LEN(H.ItemCode) > 8) ")
            qry.Append(" AND PriceList = '" + pListaPrecios + "' ")
            qry.Append(" AND Price <> '0' ")
            qry.Append(" ORDER BY A.ItemCode ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_ListaPrecios_ArticulosTodos(ByVal pListaPrecios As String) As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()

            qry.Append(" SELECT A.ItemCode [CodigoArticulo] , ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" A.Price [Precio], ")
            qry.Append(" A.Currency [Moneda] ")
            qry.Append(" FROM SBOGuateplast.dbo.ITM1 A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.ItemCode in (select ItemCode from SBOGuateplast.dbo.OITM H ")
            qry.Append(" WHERE H.ItemCode LIKE ('AR%') ")
            qry.Append(" AND LEN(H.ItemCode) > 8) ")
            qry.Append(" AND PriceList = '" + pListaPrecios + "' ")
            qry.Append(" ORDER BY A.ItemCode ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_ListaPrecios_CodigoArticulo(ByVal pCodigoArticulo As String, ByVal pListaPrecios As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT A.ItemCode [CodigoArticulo] , ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" A.Price [Precio], ")
            qry.Append(" A.Currency [Moneda] ")
            qry.Append(" FROM SBOGuateplast.dbo.ITM1 A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.ItemCode in (" + pCodigoArticulo + ")")
            qry.Append(" and PriceList = " + pListaPrecios + " ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_ListaPrecios_GrupoArticulos(ByVal pGrupoArticulos As String, ByVal pListaPrecios As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT A.ItemCode [CodigoArticulo] , ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" A.Price [Precio], ")
            qry.Append(" A.Currency [Moneda] ")
            qry.Append(" FROM SBOGuateplast.dbo.ITM1 A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.ItemCode in (select ItemCode from SBOGuateplast.dbo.OITM H ")
            qry.Append(" WHERE H.ItemCode LIKE ('AR%') ")
            qry.Append(" AND LEN(H.ItemCode) > 8 ")
            qry.Append(" AND H.ItmsGrpCod IN ('" + pGrupoArticulos + "')) ")
            qry.Append(" AND PriceList = " + pListaPrecios + " ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Catalogo_OITM() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" ItemCode [CodigoArticulo], ")
            qry.Append(" ItemName [NombreArticulo], ")
            qry.Append(" BuyUnitMsr [UnidadMedida], ")
            qry.Append(" OnHand [Stock] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM ")
            qry.Append(" ORDER BY ItemCode ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Catalogo_OITM(ByVal pCodigoArticulo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" ItemCode [CodigoArticulo], ")
            qry.Append(" ItemName [NombreArticulo], ")
            qry.Append(" BuyUnitMsr [UnidadMedida] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM ")
            qry.Append(" WHERE ItemCode = '" + pCodigoArticulo + "'")
            qry.Append(" ORDER BY ItemCode ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Stock(ByVal pCodigoArticulo As String, ByVal pBodega As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" ItemCode [CodigoArticulo], ")
            qry.Append(" WhsCode [Bodega], ")
            qry.Append(" OnHand [Stock], ")
            qry.Append(" IsCommited [Comprometido], ")
            qry.Append(" OnOrder [Ensamble] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITW ")
            qry.Append(" WHERE ItemCode = '" + pCodigoArticulo + "' ")
            qry.Append(" AND WhsCode = '" + pBodega + "' ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_Catalogo_CuentasContables() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" AcctCode [CodigoCuenta],  ")
            qry.Append(" Segment_0 + '-' + Segment_1 + '-' + Segment_2 [CodigoFormato], ")
            qry.Append(" AcctName [NombreCuenta] ")
            qry.Append(" FROM SBOGuateplast.dbo.OACT A ")
            qry.Append(" ORDER BY AcctCode ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Catalogo_ListaPrecios(ByVal pCodigoArticulo As String, ByVal pListaPrecios As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ItemCode [CodigoArticulo], ")
            qry.Append(" PriceList [CodigoLista], ")
            qry.Append(" CONVERT(DECIMAL(18,4),Price) [Precio] ")
            qry.Append(" FROM SBOGuateplast.dbo.ITM1 ")
            qry.Append(" WHERE ItemCode = '" + pCodigoArticulo + "' ")
            qry.Append(" AND PriceList = '" + pListaPrecios + "' ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_TrasladosMercaderia_ImpresionEncabezado() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT TOP 1000")
            qry.Append(" A.DocNum [NumSAP], ")
            qry.Append(" CONVERT(DATE,A.DocDate,105) [Fecha], ")
            qry.Append(" CASE WHEN LEN(A.DocTime) = '4' THEN ")
            qry.Append(" SUBSTRING(CONVERT(VARCHAR,A.DocTime),1,2) +':'+ SUBSTRING(CONVERT(VARCHAR,A.DocTime),3,2) ")
            qry.Append(" ELSE ")
            qry.Append(" SUBSTRING(CONVERT(VARCHAR,A.DocTime),1,1) +':'+ SUBSTRING(CONVERT(VARCHAR,A.DocTime),2,2) ")
            qry.Append(" END [Hora], ")
            qry.Append(" A.GroupNum [ListaPrecios], ")
            qry.Append(" B.ListName [ListaNombre], ")
            qry.Append(" A.Comments [Comentarios], ")
            qry.Append(" CONVERT(DECIMAL(18,3),A.DocTotal) [DocTotal], ")
            qry.Append(" A.U_UsuarioAPG [UsuarioAPG] ")
            qry.Append(" FROM SBOGuateplast.dbo.OIGE A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OPLN B ON B.ListNum = A.GroupNum ")
            qry.Append(" ORDER BY A.DocNum DESC ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_TrasladosMercaderia_ImpresionEncabezado(ByVal pDocNum As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" A.DocNum [NumSAP], ")
            qry.Append(" CONVERT(DATE,A.DocDate,105) [Fecha], ")
            qry.Append(" CASE WHEN LEN(A.DocTime) = '4' THEN ")
            qry.Append(" SUBSTRING(CONVERT(VARCHAR,A.DocTime),1,2) +':'+ SUBSTRING(CONVERT(VARCHAR,A.DocTime),3,2) ")
            qry.Append(" ELSE ")
            qry.Append(" SUBSTRING(CONVERT(VARCHAR,A.DocTime),1,1) +':'+ SUBSTRING(CONVERT(VARCHAR,A.DocTime),2,2) ")
            qry.Append(" END [Hora], ")
            qry.Append(" A.GroupNum [ListaPrecios], ")
            qry.Append(" B.ListName [ListaNombre], ")
            qry.Append(" A.Comments [Comentarios], ")
            qry.Append(" CONVERT(DECIMAL(18,3),A.DocTotal) [DocTotal], ")
            qry.Append(" A.U_UsuarioAPG [UsuarioAPG] ")
            qry.Append(" FROM SBOGuateplast.dbo.OIGE A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OPLN B ON B.ListNum = A.GroupNum ")
            qry.Append(" WHERE DocNum = '" + pDocNum + "' ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_TrasladosMercaderia_ImpresionDetalle(ByVal pDocNum As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" B.ItemCode [CodigoArticulo], ")
            qry.Append(" C.ItemName [NombreArticulo], ")
            qry.Append(" C.BuyUnitMsr [UM], ")
            qry.Append(" B.Quantity [Cantidad], ")
            qry.Append(" C.AvgPrice [Costo], ")
            qry.Append(" D.Price [Precio], ")
            qry.Append(" CONVERT(DECIMAL(18,3),B.LineTotal) [TotalLinea] ")
            qry.Append(" FROM SBOGuateplast.dbo.OIGE A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.IGE1 B ON B.DocEntry = A.DocEntry ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM C ON C.ItemCode = B.ItemCode ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.ITM1 D ON D.ItemCode = B.ItemCode AND D.PriceList = A.GroupNum ")
            qry.Append(" WHERE DocNum = '" + pDocNum + "' ")
            qry.Append(" ORDER BY B.ItemCode ASC ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Stock_Bodegas(ByVal pCodigoArticulo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" A.WhsCode [Id], ")
            qry.Append(" B.WhsName [Nombre], ")
            qry.Append(" A.OnHand [Stock] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITW A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OWHS B ON B.WhsCode = A.WhsCode ")
            qry.Append(" WHERE ItemCode = '" + pCodigoArticulo + "' ")
            qry.Append(" ORDER BY A.OnHand Desc ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_CamposActualizar(ByVal pTipoListado As String, ByVal pCampos As String, ByVal pTipoCampo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append("   SELECT Id [Id], ")
            qry.Append("   Nombre [Nombre], ")
            qry.Append("   Estatus [Tipo] ")
            qry.Append("   FROM APGProduccion.dbo.PROD_CatListados ")
            qry.Append("   WHERE TipoListado = '" + pTipoListado + "' ")
            qry.Append("   and id in (" + pCampos + ") ")
            qry.Append("   AND Estatus in (" + pTipoCampo + ") ")
            qry.Append("   ORDER BY OrdenPor ASC ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Catalogo_EnsambleParametros() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" A.CodigoArticulo [CodigoArticulo], ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" A.SegundosXArticulo [SegundosXArticulo], ")
            qry.Append(" A.MinutosXArticulo [MinutosXArticulo], ")
            qry.Append(" A.EnsamblesXHora [EnsamblesXHora], ")
            qry.Append(" A.EquipoPersonas [EquipoPersonas], ")
            qry.Append(" A.Bit_CreacionUsuario, ")
            qry.Append(" A.Bit_CreacionFecha, ")
            qry.Append(" A.Bit_ModificacionUsuario, ")
            qry.Append(" A.Bit_ModificacionFecha ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ensamble_Parametros A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON A.CodigoArticulo = B.ItemCode COLLATE SQL_Latin1_General_CP850_CI_AS ")
            qry.Append(" ORDER BY CodigoArticulo ASC ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Catalogo_EnsambleParametros(ByVal pCodigoArticulo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" A.CodigoArticulo [CodigoArticulo], ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" A.SegundosXArticulo [SegundosXArticulo], ")
            qry.Append(" A.MinutosXArticulo [MinutosXArticulo], ")
            qry.Append(" A.EnsamblesXHora [EnsamblesXHora], ")
            qry.Append(" A.EquipoPersonas [EquipoPersonas], ")
            qry.Append(" A.Bit_CreacionUsuario, ")
            qry.Append(" A.Bit_CreacionFecha, ")
            qry.Append(" A.Bit_ModificacionUsuario, ")
            qry.Append(" A.Bit_ModificacionFecha ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ensamble_Parametros A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON A.CodigoArticulo = B.ItemCode COLLATE SQL_Latin1_General_CP850_CI_AS ")
            qry.Append(" WHERE A.CodigoArticulo in (" + pCodigoArticulo + ") ")
            qry.Append(" ORDER BY CodigoArticulo ASC ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_MoldeMaquinaXPrioridad(ByVal pMolde As String, ByVal pPrioridad As String) As String
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable("dt")

            qry.Append(" SELECT Maquina ")
            qry.Append(" FROM APGProduccion.dbo.PROD_MoldesMaquinas ")
            qry.Append(" WHERE Molde = '" + pMolde + "' ")
            qry.Append(" AND Prioridad = '" + pPrioridad + "' ")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            If dt.Rows.Count = Nothing Then
                Return Nothing
            Else
                Return dt.Rows(0)(0).ToString()
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Componente_MaquinaXPrioridad(ByVal pComponente As String, ByVal pPrioridad As String) As String
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable("dt")

            qry.Append(" SELECT Maquina ")
            qry.Append(" FROM APGProduccion.dbo.PROD_ComponentesMaquinaS ")
            qry.Append(" WHERE Componente = '" + pComponente + "' ")
            qry.Append(" AND Prioridad = '" + pPrioridad + "' ")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            If dt.Rows.Count = Nothing Then
                Return Nothing
            Else
                Return dt.Rows(0)(0).ToString()
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function



    Public Function GET_MoldeMaquinaXPrioridad_ToString(ByVal pCodigoArticulo As String) As String
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable("dt")

            qry.Append(" DECLARE @MaquinasCompatibles VARCHAR(1000) ")
            qry.Append(" SELECT @MaquinasCompatibles = COALESCE(@MaquinasCompatibles + ', ','') + CONVERT(VARCHAR(10),Maquina)  ")
            qry.Append(" FROM APGProduccion.dbo.PROD_MoldesMaquinas ")
            qry.Append(" WHERE Molde = '" + pCodigoArticulo.Substring(2, 6).ToString + "' ")
            qry.Append(" ORDER BY Prioridad ASC ")
            qry.Append(" SELECT C.ItemCode,@MaquinasCompatibles [Colores]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM C  ")
            qry.Append(" WHERE LEN(C.ItemCode) = 8 AND C.ItemCode = '" + pCodigoArticulo.ToString + "' ")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            If dt.Rows.Count = Nothing Then
                Return Nothing
            Else
                Return dt.Rows(0)(0).ToString()
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_OrdenesProduccion_Padres() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" MIN(CONVERT(INT,Prioridad)) [Prioridad], ")
            qry.Append(" CodigoArticulo, ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" SUM(Planeado) [Planeado], ")
            qry.Append(" SUM(Completado) [Completado], ")
            qry.Append(" SUM(Pendiente) [Pendiente]  ")
            qry.Append(" FROM( ")
            qry.Append(" Select  ")
            qry.Append(" a.U_NBS_Priority [Prioridad],")
            qry.Append(" SUBSTRING(A.ItemCode,1,8) [CodigoArticulo],  ")
            qry.Append(" CONVERT(INTEGER,A.PlannedQty) [Planeado], ")
            qry.Append(" CONVERT(INTEGER,A.CmpltQty) [Completado],  ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (A.PlannedQty - A.CmpltQty) > 0 THEN (A.PlannedQty - A.CmpltQty) ELSE '0' END) [Pendiente]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A  ")
            qry.Append(" WHERE A.ItemCode LIKE ('CP%')   ")
            qry.Append(" AND Status IN ('R','P')  ")
            qry.Append(" ) A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.CodigoArticulo ")
            'qry.Append(" WHERE CodigoArticulo = 'CP000125' ")
            qry.Append(" WHERE B.ItemName NOT LIKE '%bolsa%' COLLATE Latin1_General_CI_AI ") 'Búsqueda insensible a mayúsculas/minúsculas
            qry.Append(" GROUP BY CodigoArticulo,B.ItemName ")
            qry.Append(" ORDER BY Prioridad, CodigoArticulo ASC")



            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    'Ordenes de Producion Pero solo muestra Bolsa
    Public Function GET_OrdenesProduccion_Padres_SoloBolsa() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" MIN(CONVERT(INT,Prioridad)) [Prioridad], ")
            qry.Append(" CodigoArticulo, ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" SUM(Planeado) [Planeado], ")
            qry.Append(" SUM(Completado) [Completado], ")
            qry.Append(" SUM(Pendiente) [Pendiente]  ")
            qry.Append(" FROM( ")
            qry.Append(" Select  ")
            qry.Append(" a.U_NBS_Priority [Prioridad],")
            qry.Append(" SUBSTRING(A.ItemCode,1,8) [CodigoArticulo],  ")
            qry.Append(" CONVERT(INTEGER,A.PlannedQty) [Planeado], ")
            qry.Append(" CONVERT(INTEGER,A.CmpltQty) [Completado],  ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (A.PlannedQty - A.CmpltQty) > 0 THEN (A.PlannedQty - A.CmpltQty) ELSE '0' END) [Pendiente]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A  ")
            qry.Append(" WHERE A.ItemCode LIKE ('CP%')   ")
            qry.Append(" AND Status IN ('R','P')  ")
            qry.Append(" ) A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.CodigoArticulo ")
            'qry.Append(" WHERE CodigoArticulo = 'CP000125' ")
            qry.Append(" WHERE B.ItemName LIKE '%bolsa%' COLLATE Latin1_General_CI_AI ") 'Búsqueda insensible a mayúsculas/minúsculas
            qry.Append(" GROUP BY CodigoArticulo,B.ItemName ")
            qry.Append(" ORDER BY Prioridad, CodigoArticulo ASC")



            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function




    Public Function GET_EmergenciasProduccion_Plan(ByVal pCodigoArticulo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT Prioridad, ")
            qry.Append(" CodigoArticulo, ")
            qry.Append(" NombreArticulo, ")
            'qry.Append(" Stock, ")
            qry.Append(" Planeado, ")
            qry.Append(" Completado, ")
            qry.Append(" Pendiente, ")
            qry.Append(" '' [ColoresPendientes], ")
            qry.Append(" '' [ColorInicio], ")
            qry.Append(" '' [Cliente], ")
            qry.Append(" '' [Campaña], ")
            'qry.Append(" CONVERT(DATE,'',105) [FechaDespacho], ")
            qry.Append(" '' [Observacion] ")
            qry.Append(" FROM ")
            qry.Append(" (SELECT  ")
            qry.Append(" MIN(CONVERT(INT,Prioridad)) [Prioridad],  ")
            qry.Append(" CodigoArticulo,  ")
            qry.Append(" B.ItemName [NombreArticulo],  ")
            qry.Append(" SUM(Planeado) [Planeado],  ")
            qry.Append(" SUM(Completado) [Completado],  ")
            qry.Append(" SUM(Pendiente) [Pendiente], ")
            qry.Append(" MAX(CONVERT(INTEGER,B.OnHand)) [Stock] ")
            qry.Append(" FROM(  ")
            qry.Append(" Select   ")
            qry.Append(" a.U_NBS_Priority [Prioridad], ")
            qry.Append(" SUBSTRING(A.ItemCode,1,8) [CodigoArticulo],   ")
            qry.Append(" CONVERT(INTEGER,A.PlannedQty) [Planeado],  ")
            qry.Append(" CONVERT(INTEGER,A.CmpltQty) [Completado],   ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (A.PlannedQty - A.CmpltQty) > 0 THEN (A.PlannedQty - A.CmpltQty) ELSE '0' END) [Pendiente] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A   ")
            qry.Append(" WHERE A.ItemCode LIKE ('CP%')    ")
            qry.Append(" AND Status IN ('R','P')   ")
            qry.Append(" ) A  ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.CodigoArticulo  ")
            qry.Append(" GROUP BY CodigoArticulo,B.ItemName) QRY  ")
            qry.Append(" WHERE CodigoArticulo IN (" + pCodigoArticulo + ") ")
            qry.Append(" ORDER BY Prioridad, CodigoArticulo ASC ")



            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_OrdenesProduccion_Hijos(ByVal pCodigoPadre As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" CodigoArticulo, ")
            qry.Append(" NombreArticulo, ")
            qry.Append(" SUBSTRING(CodigoArticulo,1,8) [CodigoPadre], ")
            qry.Append(" Color, ")
            qry.Append(" SUM(Planeado) [Planeado], ")
            qry.Append(" SUM(Completado) [Completado], ")
            qry.Append(" SUM(Pendiente) [Pendiente], ")
            qry.Append(" SUM(Pendiente) [ProdFinal]  ")
            qry.Append(" FROM( ")
            qry.Append(" Select  ")
            qry.Append(" A.ItemCode [CodigoArticulo],  ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" B.U_Color [Color], ")
            qry.Append(" CONVERT(INTEGER,A.PlannedQty) [Planeado], ")
            qry.Append(" CONVERT(INTEGER,A.CmpltQty) [Completado],  ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (A.PlannedQty - A.CmpltQty) > 0 THEN (A.PlannedQty - A.CmpltQty) ELSE '0' END) [Pendiente]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A  ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.ItemCode LIKE ('CP%')   ")
            qry.Append(" AND Status IN ('R','P')  ")
            qry.Append(" ) A ")
            qry.Append(" WHERE SUBSTRING(CodigoArticulo,1,8) = '" + pCodigoPadre + "' ")
            qry.Append(" GROUP BY CodigoArticulo,NombreArticulo,Color ")
            qry.Append(" ORDER BY CodigoArticulo ASC ")



            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_OrdenesProduccion_ByCodigoArticulo(ByVal pCodigoArticulo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" CONVERT(INT,A.DocNum) [NumSAP], ")
            qry.Append(" A.U_NBS_Priority [Prioridad], ")
            qry.Append(" A.ItemCode [CodigoArticulo],   ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" CONVERT(INTEGER,A.PlannedQty) [Planeado],  ")
            qry.Append(" CONVERT(INTEGER,A.CmpltQty) [Completado],   ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (A.PlannedQty - A.CmpltQty) > 0 THEN (A.PlannedQty - A.CmpltQty) ELSE '0' END) [Pendiente]   ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A   ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.ItemCode LIKE ('" + pCodigoArticulo + "%')    ")
            qry.Append(" AND Status IN ('R','P')   ")
            qry.Append(" ORDER BY A.ItemCode ASC, A.PlannedQty DESC ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return Nothing
        End Try
    End Function

    'Public Function GET_OrdenesProduccion_Orden(ByVal pCodigoTipo As String, ByVal pCodigoArticulo As String) As DataTable
    '    Try
    '        Dim qry As New StringBuilder

    '        qry.Append("  SELECT ")
    '        qry.Append("  A.DocNum [NumSAP],  ")
    '        qry.Append("  CASE   ")
    '        qry.Append("  WHEN Status = 'R' THEN 'Liberado'   ")
    '        qry.Append("  WHEN Status = 'P' THEN 'Planeado' 	  ")
    '        qry.Append("  WHEN Status = 'L' THEN 'Close'   ")
    '        qry.Append("  END [Estado],  ")
    '        qry.Append("   CASE  ")
    '        qry.Append("  WHEN Type = 'S' THEN 'Estándar'  ")
    '        qry.Append("  WHEN Type = 'P' THEN 'Especial'  ")
    '        qry.Append("  WHEN Type = 'D' THEN 'Desmontar'  ")
    '        qry.Append("  END [Tipo],  ")
    '        qry.Append("  CONVERT(INTEGER,PlannedQty) [Planeado],  ")
    '        qry.Append("  CONVERT(INTEGER,CmpltQty) [Completado],  ")
    '        qry.Append("  CONVERT(INTEGER,CASE WHEN (PlannedQty - CmpltQty) > 0 THEN (PlannedQty - CmpltQty) ELSE '0' END) [Pendiente],  ")
    '        qry.Append("  CONVERT(DATE,PostDate,105) [Creación],  ")
    '        qry.Append("  CONVERT(DATE,DueDate,105) [Vencimiento],  ")
    '        qry.Append("  CONVERT(INTEGER,CONVERT(DATE,GETDATE(),105) - PostDate) [Dias Atrasado], ")
    '        qry.Append("  C.Origen, ")
    '        qry.Append("  C.Destino [Destino], ")
    '        qry.Append("  C.GrupoCliente [GrupoCliente], ")
    '        qry.Append("  C.CodigoCliente [CodigoCliente], ")
    '        qry.Append("  C.NumeroOrden [NumeroOrden], ")
    '        qry.Append("  C.NumeroCampana [Campaña], ")
    '        qry.Append("  C.Entrega [Entrega], ")
    '        qry.Append("  C.Comentario_Nivel1 [Comentario1], ")
    '        qry.Append("  C.Comentario_Nivel2 [Comentario2], ")
    '        qry.Append("  C.Bit_UsuarioCreacion [Creacion] ")
    '        qry.Append("  FROM SBOGuateplast.dbo.OWOR A  ")
    '        qry.Append("  LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode  ")
    '        qry.Append("  LEFT JOIN APGProduccion.dbo.PROD_Ordenes_Detalle C ON C.NumeroSAP = A.DocNum  AND (C.Tipo = 'EE' OR C.Tipo = 'PE')")
    '        qry.Append("  WHERE A.ItemCode LIKE ('" + pCodigoTipo + "%')   ")
    '        qry.Append("  AND Status IN ('R','P')  ")
    '        qry.Append("  AND A.ItemCode = '" + pCodigoArticulo + "' ")
    '        qry.Append("  ORDER BY A.DocNum DESC ")

    '        Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar
    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.InnerException.ToString)
    '        Return Nothing
    '    End Try
    'End Function

    Public Function GET_OrdenesProduccion_Orden(ByVal pCodigoTipo As String, ByVal pCodigoArticulo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" A.DocNum [NumSAP], ")
            qry.Append(" CASE  ")
            qry.Append(" WHEN Status = 'R' THEN 'Liberado'  ")
            qry.Append(" WHEN Status = 'P' THEN 'Planeado' 	 ")
            qry.Append(" WHEN Status = 'L' THEN 'Close'  ")
            qry.Append(" END [Estado], ")
            qry.Append("  CASE ")
            qry.Append(" WHEN Type = 'S' THEN 'Estándar' ")
            qry.Append(" WHEN Type = 'P' THEN 'Especial' ")
            qry.Append(" WHEN Type = 'D' THEN 'Desmontar' ")
            qry.Append(" END [Tipo], ")
            qry.Append(" CONVERT(INTEGER,PlannedQty) [Planeado], ")
            qry.Append(" CONVERT(INTEGER,CmpltQty) [Completado], ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (PlannedQty - CmpltQty) > 0 THEN (PlannedQty - CmpltQty) ELSE '0' END) [Pendiente], ")
            qry.Append(" CONVERT(DATE,PostDate,105) [Creación], ")
            qry.Append(" CONVERT(DATE,DueDate,105) [Vencimiento], ")

            ' **Option 1: Convert PostDate to DATETIME before subtraction**
            ' qry.Append(" CONVERT(INTEGER, CONVERT(DATE, GETDATE(), 105) - CONVERT(DATETIME, PostDate, 105)) [Dias Atrasado], ")

            ' **Option 2: Use DATEDIFF function**
            qry.Append(" DATEDIFF(DAY, CONVERT(DATE, PostDate, 105), CONVERT(DATE, GETDATE(), 105)) [Dias Atrasado], ")

            qry.Append(" C.Origen, ")
            qry.Append(" C.Destino [Destino], ")
            qry.Append(" C.GrupoCliente [GrupoCliente], ")
            qry.Append(" C.CodigoCliente [CodigoCliente], ")
            qry.Append(" C.NumeroOrden [NumeroOrden], ")
            qry.Append(" C.NumeroCampana [Campaña], ")
            qry.Append(" C.Entrega [Entrega], ")
            qry.Append(" C.Comentario_Nivel1 [Comentario1], ")
            qry.Append(" C.Comentario_Nivel2 [Comentario2], ")
            qry.Append(" C.Bit_UsuarioCreacion [Creacion] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Ordenes_Detalle C ON C.NumeroSAP = A.DocNum AND (C.Tipo = 'EE' OR C.Tipo = 'PE')")
            qry.Append(" WHERE A.ItemCode LIKE ('" + pCodigoTipo + "%')  ")
            qry.Append(" AND Status IN ('R','P') ")
            qry.Append(" AND A.ItemCode = '" + pCodigoArticulo + "' ")
            qry.Append(" ORDER BY A.DocNum DESC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar
        Catch ex As Exception
            mMensajes.msg_Error(ex.InnerException.ToString)
            Return Nothing
        End Try
    End Function


    Public Function GET_OrdenesProduccion_Impresion(ByVal pCodigoArticulo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append("  SELECT ")
            qry.Append("  A.ItemCode [CodigoArticulo],")
            qry.Append("  A.DocNum [NumSAP],  ")
            qry.Append("  CASE   ")
            qry.Append("  WHEN Status = 'R' THEN 'Liberado'   ")
            qry.Append("  WHEN Status = 'P' THEN 'Planeado' 	  ")
            qry.Append("  WHEN Status = 'L' THEN 'Close'   ")
            qry.Append("  END [Estado],  ")
            qry.Append("   CASE  ")
            qry.Append("  WHEN Type = 'S' THEN 'Estándar'  ")
            qry.Append("  WHEN Type = 'P' THEN 'Especial'  ")
            qry.Append("  WHEN Type = 'D' THEN 'Desmontar'  ")
            qry.Append("  END [Tipo],  ")
            qry.Append("  CONVERT(INTEGER,PlannedQty) [Planeado],  ")
            qry.Append("  CONVERT(INTEGER,CmpltQty) [Completado],  ")
            qry.Append("  CONVERT(INTEGER,CASE WHEN (PlannedQty - CmpltQty) > 0 THEN (PlannedQty - CmpltQty) ELSE '0' END) [Pendiente],  ")
            qry.Append("  CONVERT(DATE,PostDate,105) [Creación],  ")
            qry.Append("  CONVERT(DATE,DueDate,105) [Vencimiento],  ")
            'qry.Append("  CONVERT(INTEGER,CONVERT(DATE,GETDATE(),105) - PostDate) [Dias Atrasado], ")
            ' **Option 2: Use DATEDIFF function**
            qry.Append(" DATEDIFF(DAY, CONVERT(DATE, PostDate, 105), CONVERT(DATE, GETDATE(), 105)) [Dias Atrasado], ")
            qry.Append("  C.Origen, ")
            qry.Append("  C.Destino [Destino], ")
            qry.Append("  C.GrupoCliente [GrupoCliente], ")
            qry.Append("  C.CodigoCliente [CodigoCliente], ")
            qry.Append("  C.NumeroOrden [NumeroOrden], ")
            qry.Append("  C.NumeroCampana [Campaña], ")
            qry.Append("  C.Entrega [Entrega], ")
            qry.Append("  C.Comentario_Nivel1 [Comentario1], ")
            qry.Append("  C.Comentario_Nivel2 [Comentario2], ")
            qry.Append("  C.Bit_UsuarioCreacion [Creacion] ")
            qry.Append("  FROM SBOGuateplast.dbo.OWOR A  ")
            qry.Append("  LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode  ")
            qry.Append("  LEFT JOIN APGProduccion.dbo.PROD_Ordenes_Detalle C ON C.NumeroSAP = A.DocNum ")
            qry.Append("  WHERE A.ItemCode LIKE ('CP%')   ")
            qry.Append("  AND Status IN ('R','P')  ")
            qry.Append("  AND A.ItemCode Like ('" + pCodigoArticulo.Substring(0, 8).ToString + "%') ")
            qry.Append("  ORDER BY A.DocNum DESC ")



            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_MoldesMaquinasTrabajar(ByVal pCodigoArticulo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append("  SELECT Maquina ")
            qry.Append("  FROM APGProduccion.dbo.PROD_MoldesMaquinas ")
            qry.Append("  WHERE Molde = '" + pCodigoArticulo + "' ")
            qry.Append("  ORDER BY Prioridad ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    'Public Function GET_MoldesMaquinasParametros(ByVal pCodigoArticulo As String) As DataTable
    '    Try
    '        Dim qry As New StringBuilder

    '        qry.Append("  SELECT A.Id, ")
    '        qry.Append("  A.Nombre,  ")
    '        qry.Append("  A.Cavidades,  ")
    '        qry.Append("  A.Unidades,  ")
    '        qry.Append("  B.Nombre [Bodega], ")
    '        qry.Append("  A.Ubicacion, ")
    '        qry.Append("  A.MaquinaPreferencial ")
    '        qry.Append("  FROM APGProduccion.dbo.PROD_Moldes A ")
    '        qry.Append("  LEFT JOIN APGProduccion.dbo.PROD_CatListados B ON B.id = A.Bodega AND B.TipoListado = 'Moldes_Bodegas' ")
    '        qry.Append("  WHERE A.Id = '" + pCodigoArticulo + "' ")

    '        Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message)
    '        Return Nothing
    '    End Try
    'End Function

    Public Function GET_MoldesMaquinasParametros(ByVal pCodigoArticulo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append("  SELECT A.Id, ")
            qry.Append("  A.Nombre,  ")
            qry.Append("  A.Cavidades,  ")
            qry.Append("  A.Unidades,  ")
            qry.Append("  B.Nombre [Bodega], ")
            qry.Append("  A.Ubicacion, ")
            qry.Append("  A.MaquinaPreferencial ")
            qry.Append("  FROM APGProduccion.dbo.PROD_Moldes A ")
            qry.Append("  LEFT JOIN APGProduccion.dbo.PROD_CatListados B ON B.id = A.Bodega AND B.TipoListado = 'Moldes_Bodegas' ")
            qry.Append("  WHERE A.Id = '" + pCodigoArticulo + "' ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GETALL_OITM(ByVal pCodigoArticulo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append("  SELECT ")
            qry.Append("  * ")
            qry.Append("  FROM SboGuateplast.dbo.OITM ")
            qry.Append("  WHERE ItemCode IN (" + pCodigoArticulo + ")")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GETALL_OITM_Basico() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append("  SELECT ")
            qry.Append("  ItemCode [CodigoArticulo], ")
            qry.Append("  ItemName [NombreArticulo], ")
            qry.Append("  U_Color [Color], ")
            qry.Append("  CodeBars [CodigoBarras], ")
            qry.Append("  CASE WHEN U_NoDeLinea = '0' THEN ")
            qry.Append("  'SI' ELSE 'NO' END [DeLinea] ")
            qry.Append("  FROM SBOGuateplast.dbo.OITM ")
            qry.Append("  ORDER BY ItemCode ASC ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function



    Public Function GETALL_UPC() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append("  SELECT CONVERT(INT,substring(U_Upc,1,5)) [U_UPC] ")
            qry.Append("  FROM SBOGuateplast.dbo.OITM ")
            qry.Append("  WHERE U_Upc Is Not NULL ")
            qry.Append("  AND U_Upc > 0 ")
            qry.Append("  ORDER BY U_Upc ASC ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    'Public Function GET_MoldesProduccionParametrosSAP(ByVal pCodigoArticulo As String) As DataTable
    '    Try
    '        Dim qry As New StringBuilder

    '        qry.Append(" SELECT  ")
    '        qry.Append(" CONVERT(DECIMAL(18,1),U_ProduccionPorHora) [ArticulosHora], ")
    '        qry.Append(" CONVERT(DECIMAL(18,1),U_ProduccionPorHora * 12) [ArticulosTurno],   ")
    '        qry.Append(" CASE WHEN U_ProduccionPorHora > 0 THEN CONVERT(DECIMAL(18,1),(3600 / (U_ProduccionPorHora / B.Unidades))) ELSE '0' END [Ciclo], ")
    '        qry.Append(" CASE WHEN U_ProduccionPorHora > 0 THEN CONVERT(DECIMAL(18,1),(U_ProduccionPorHora / B.Unidades)) ELSE '0' END [CicloHora], ")
    '        qry.Append(" CASE WHEN U_ProduccionPorHora > 0 THEN CONVERT(DECIMAL(18,1),(U_ProduccionPorHora / B.Unidades) * 12) ELSE '0' END [CicloTurno], ")
    '        qry.Append(" CASE WHEN U_ProduccionPorHora > 0 THEN CONVERT(DECIMAL(18,1),(3600 / (U_ProduccionPorHora / B.Unidades)) - '0.5') ELSE '0' END [CicloMin], ")
    '        qry.Append(" CASE WHEN U_ProduccionPorHora > 0 THEN CONVERT(DECIMAL(18,1),(3600 / (U_ProduccionPorHora / B.Unidades)) + '0.5') ELSE '0' END [CicloMax], ")
    '        qry.Append(" CASE WHEN U_ProduccionPorHora > 0 THEN CONVERT(DECIMAL(18,1),U_PesoenKgsComponete * 1000 * B.Unidades) ELSE '0' END [PesoInyeccionGrms], ")
    '        qry.Append(" CASE WHEN U_ProduccionPorHora > 0 THEN CONVERT(DECIMAL(18,1),(U_PesoenKgsComponete * 1000 * B.Unidades) - 2.5) ELSE '0' END [RangoPesoGrmsMin], ")
    '        qry.Append(" CASE WHEN U_ProduccionPorHora > 0 THEN CONVERT(DECIMAL(18,1),(U_PesoenKgsComponete * 1000 * B.Unidades) + 2.5) ELSE '0' END [RangoPesoGrmsMax], ")
    '        qry.Append(" CASE WHEN U_ProduccionPorHora > 0 THEN CEILING(((U_PesoenKgsComponete * 1000 * B.Unidades) * (U_ProduccionPorHora / B.Unidades))/'453.5924') ELSE '0' END [LbHora], ")
    '        qry.Append(" CASE WHEN U_ProduccionPorHora > 0 THEN CONVERT(DECIMAL(18,1),((CEILING(((U_PesoenKgsComponete * 1000 * B.Unidades) * (U_ProduccionPorHora / B.Unidades)) /'453.5924') * 24) / CONVERT(DECIMAL(18,4),'2.2046'))/'25') ELSE '0' END [Sacos25KG]    ")
    '        qry.Append(" FROM SBOGuateplast.dbo.OITM A   ")
    '        qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_CodigosProducidos AB ON AB.Id COLLATE SQL_Latin1_General_CP1_CI_AS = A.ItemCode  ")
    '        qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Moldes B ON B.Id = AB.Molde ")
    '        qry.Append(" WHERE A.ItemCode = '" + pCodigoArticulo + "' ")

    '        Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message)
    '        Return Nothing
    '    End Try
    'End Function

    Public Function GET_MoldesProduccionParametros(ByVal pCodigoArticulo As String) As DataTable
        Try
            Dim qry As New StringBuilder
            'SUSTITYE SP 
            qry.Append(" SELECT ")
            qry.Append(" A.Id [CodigoArticulo], ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            'qry.Append(" CASE WHEN A.InyeccionHora > 0  THEN CONVERT(DECIMAL(18,1),(3600 / (CONVERT(DECIMAL(18,1),A.InyeccionHora)))) ELSE '0' END [Ciclo], ") ' 2018 06 26
            qry.Append(" CASE WHEN B.U_ProduccionPorHora > 0  THEN CONVERT(DECIMAL(18,1),(3600 / (CONVERT(DECIMAL(18,1),B.U_ProduccionPorHora)))/ 1.05) ELSE '0' END [Ciclo], ")
            qry.Append(" CASE WHEN B.U_ProduccionPorHora > 0 THEN CONVERT(DECIMAL(18,1),B.U_ProduccionPorHora) END [CicloHora], ")
            qry.Append(" CASE WHEN B.U_ProduccionPorHora > 0 THEN CONVERT(DECIMAL(18,1),B.U_ProduccionPorHora * 12) END [CicloTurno], ")

            'MODIFICACION 2019-03-19
            'qry.Append(" CASE WHEN A.InyeccionHora > 0 AND D.Unidades > 0 THEN CONVERT(DECIMAL(18,1),(3600 / (CONVERT(DECIMAL(18,1),A.InyeccionHora))) * 0.975) ELSE '0' END [CicloMin], ")
            'qry.Append(" CASE WHEN A.InyeccionHora > 0 AND D.Unidades > 0 THEN CONVERT(DECIMAL(18,1),(3600 / (CONVERT(DECIMAL(18,1),A.InyeccionHora)) * 1.025)) ELSE '0' END [CicloMax], ")
            qry.Append(" CASE WHEN B.U_ProduccionPorHora > 0 AND D.Unidades > 0 THEN CONVERT(DECIMAL(18, 1), APGProduccion.dbo.mi_Minimo(((3600/((B.U_ProduccionPorHora)*1.05))*0.975),((3600/((B.U_ProduccionPorHora)*1.05))-0.5))) ELSE '0' END [CicloMin], ")
            qry.Append(" CASE WHEN B.U_ProduccionPorHora > 0 AND D.Unidades > 0 THEN CONVERT(DECIMAL(18, 1),APGProduccion.dbo.mi_Maximo(((3600/((B.U_ProduccionPorHora)*1.05))*1.025),((3600/((B.U_ProduccionPorHora)*1.05))+0.5))) ELSE '0' END [CicloMax], ")

            qry.Append(" CASE WHEN A.InyeccionHora > 0 AND D.Unidades > 0 THEN CONVERT(DECIMAL(18,1),(CONVERT(DECIMAL(18,1),A.InyeccionHora))* D.Unidades) ELSE '0' END [ArticulosHora], ")
            qry.Append(" CASE WHEN A.InyeccionHora > 0 AND D.Unidades > 0  THEN CONVERT(DECIMAL(18,1),(A.InyeccionHora * D.Unidades)*12) ELSE '0' END [ArticulosTurno], ")
            qry.Append(" CASE WHEN B.U_PesoenKgsComponete > 0 THEN CONVERT(DECIMAL(18,1),(B.U_PesoenKgsComponete*1000)*0.05) END  [PesoInyeccionVariacionGrms], ")
            qry.Append(" CASE WHEN A.InyeccionGrms > 0 THEN CONVERT(DECIMAL(18,6),A.InyeccionGrms / 1000) END [PesoInyeccionKgs], ")
            qry.Append(" CASE WHEN B.U_PesoenKgsComponete > 0 THEN CONVERT(DECIMAL(18,1),(B.U_PesoenKgsComponete*1000)) END [PesoInyeccionGrms], ")
            qry.Append(" CASE WHEN A.InyeccionGrms > 0 THEN CONVERT(DECIMAL(18,1),A.InyeccionGrms - A.InyeccionVariacion) END [RangoPesoGrmsMin], ")
            qry.Append(" CASE WHEN A.InyeccionGrms > 0 THEN CONVERT(DECIMAL(18,1),A.InyeccionGrms + A.InyeccionVariacion) END [RangoPesoGrmsMax], ")
            qry.Append(" CASE WHEN A.InyeccionHora > 0 AND D.Unidades > 0 THEN CONVERT(DECIMAL(18,1),CEILING(((A.InyeccionGrms * D.Unidades) * (A.InyeccionHora * 0.95))/'453.5924') *  ")
            qry.Append(" CASE WHEN E.Tipo = 'S' THEN 1.35 ELSE 1.08 END) ELSE '0' END [LbHora], ")
            qry.Append(" CASE WHEN A.InyeccionHora > 0 AND D.Unidades > 0 THEN CONVERT(DECIMAL(18,1),((CEILING(((A.InyeccionGrms * D.Unidades) * (A.InyeccionHora * 0.95)) /'453.5924') * 24) / CONVERT(DECIMAL(18,4),'2.2046'))/'25' *  ")
            qry.Append(" CASE WHEN E.Tipo = 'S' THEN 1.35 ELSE 1.08 END ) ELSE '0' END [Sacos25KG], ")
            qry.Append(" A.Bit_CreacionFecha, ")
            qry.Append(" A.Bit_CreacionUsuario, ")
            qry.Append(" A.Bit_ModificacionFecha, ")
            qry.Append(" A.Bit_ModificacionUsuario ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Produccion_Parametros A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.Id COLLATE SQL_Latin1_General_CP850_CI_AS ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_CodigosProducidos C ON C.Id = A.Id ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Moldes D ON D.Id = C.Molde ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Maquinas E ON E.Id = D.MaquinaPreferencial ")
            qry.Append(" WHERE A.Id = '" + pCodigoArticulo + "' ")
            qry.Append(" ORDER BY CodigoArticulo ASC ")

            'ACTUALIZADO 2017 05 25
            'qry.Append(" SELECT ")
            'qry.Append(" A.Id [CodigoArticulo], ")
            'qry.Append(" B.ItemName [NombreArticulo], ")
            'qry.Append(" CASE WHEN A.InyeccionHora > 0 THEN CONVERT(DECIMAL(18,1),(3600 / CONVERT(DECIMAL(18,1),(A.InyeccionHora / D.Unidades)))) ELSE '0' END [Ciclo], ")
            'qry.Append(" CASE WHEN A.InyeccionHora > 0 THEN CONVERT(DECIMAL(18,1),A.InyeccionHora) END [CicloHora], ")
            'qry.Append(" CASE WHEN A.InyeccionHora > 0 THEN CONVERT(DECIMAL(18,1),A.InyeccionHora * 12) END [CicloTurno], ")
            'qry.Append(" CASE WHEN A.InyeccionHora > 0 THEN CONVERT(DECIMAL(18,1),(3600 / (A.InyeccionHora / D.Unidades) - 0.5)) ELSE '0' END [CicloMin], ")
            'qry.Append(" CASE WHEN A.InyeccionHora > 0 THEN CONVERT(DECIMAL(18,1),(3600 / (A.InyeccionHora / D.Unidades) + 0.5)) ELSE '0' END [CicloMax], ")
            'qry.Append(" CASE WHEN A.InyeccionHora > 0 THEN CONVERT(DECIMAL(18,1),(3600 / (A.InyeccionHora / D.Unidades)* D.Unidades)) ELSE '0' END [ArticulosHora], ")
            'qry.Append(" CASE WHEN A.InyeccionHora > 0 THEN CONVERT(DECIMAL(18,1),(A.InyeccionHora * D.Unidades)*12) ELSE '0' END [ArticulosTurno], ")

            'qry.Append(" CASE WHEN A.InyeccionGrms > 0 THEN CONVERT(DECIMAL(18,6),A.InyeccionGrms / 1000) END [PesoInyeccionKgs], ")
            'qry.Append(" CASE WHEN A.InyeccionGrms > 0 THEN CONVERT(DECIMAL(18,1),A.InyeccionGrms) END [PesoInyeccionGrms], ")
            'qry.Append(" CASE WHEN A.InyeccionGrms > 0 THEN CONVERT(DECIMAL(18,1),A.InyeccionGrms - A.InyeccionVariacion) END [RangoPesoGrmsMin], ")
            'qry.Append(" CASE WHEN A.InyeccionGrms > 0 THEN CONVERT(DECIMAL(18,1),A.InyeccionGrms + A.InyeccionVariacion) END [RangoPesoGrmsMax], ")

            'qry.Append(" CASE WHEN A.InyeccionHora > 0 THEN CEILING(((A.InyeccionGrms * D.Unidades) * (A.InyeccionHora))/'453.5924') ELSE '0' END [LbHora], ")
            'qry.Append(" CASE WHEN A.InyeccionHora > 0 THEN CONVERT(DECIMAL(18,1),((CEILING(((A.InyeccionGrms * D.Unidades) * (A.InyeccionHora)) /'453.5924') * 24) / CONVERT(DECIMAL(18,4),'2.2046'))/'25') ELSE '0' END [Sacos25KG] ")
            'qry.Append(" FROM APGProduccion.dbo.PROD_Produccion_Parametros A ")
            'qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.Id COLLATE SQL_Latin1_General_CP850_CI_AS ")
            'qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_CodigosProducidos C ON C.Id = A.Id ")
            'qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Moldes D ON D.Id = C.Molde ")
            'qry.Append(" WHERE A.Id = '" + pCodigoArticulo + "'  ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_MoldesProduccionParametros() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT  ")
            qry.Append(" A.Id [CodigoArticulo], ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            'qry.Append(" CASE WHEN A.InyeccionHora > 0  THEN CONVERT(DECIMAL(18,1),(3600 / (CONVERT(DECIMAL(18,1),A.InyeccionHora)))/ 1.05) ELSE '0' END [Ciclo], ")
            qry.Append(" CASE WHEN B.U_ProduccionPorHora > 0  THEN CONVERT(DECIMAL(18,1),(3600 / (CONVERT(DECIMAL(18,1),B.U_ProduccionPorHora)))/ 1.05) ELSE '0' END [Ciclo], ")
            'qry.Append(" CASE WHEN A.InyeccionHora > 0  THEN CONVERT(DECIMAL(18,1),(3600 / (CONVERT(DECIMAL(18,1),A.InyeccionHora)))) ELSE '0' END [Ciclo], ") 'cambio el 26/06/2018
            'qry.Append(" CASE WHEN A.InyeccionHora > 0 THEN CONVERT(DECIMAL(18,1),A.InyeccionHora) END [CicloHora], ")
            'qry.Append(" CASE WHEN A.InyeccionHora > 0 THEN CONVERT(DECIMAL(18,1),A.InyeccionHora * 12) END [CicloTurno], ")
            qry.Append(" CASE WHEN B.U_ProduccionPorHora > 0 THEN CONVERT(DECIMAL(18,1),B.U_ProduccionPorHora) END [CicloHora], ")
            qry.Append(" CASE WHEN B.U_ProduccionPorHora > 0 THEN CONVERT(DECIMAL(18,1),B.U_ProduccionPorHora * 12) END [CicloTurno], ")

            'qry.Append(" CASE WHEN A.InyeccionHora > 0 AND D.Unidades > 0 THEN CONVERT(DECIMAL(18,1),(3600 / (CONVERT(DECIMAL(18,1),A.InyeccionHora))) * 0.975) ELSE '0' END [CicloMin], ")
            'qry.Append(" CASE WHEN A.InyeccionHora > 0 AND D.Unidades > 0 THEN CONVERT(DECIMAL(18,1),(3600 / (CONVERT(DECIMAL(18,1),A.InyeccionHora)) * 1.025)) ELSE '0' END [CicloMax], ")
            qry.Append(" CASE WHEN B.U_ProduccionPorHora > 0 AND D.Unidades > 0 THEN CONVERT(DECIMAL(18, 1), APGProduccion.dbo.mi_Minimo(((3600/((B.U_ProduccionPorHora)*1.05))*0.975),((3600/((B.U_ProduccionPorHora)*1.05))-0.5))) ELSE '0' END [CicloMin], ")
            qry.Append(" CASE WHEN B.U_ProduccionPorHora > 0 AND D.Unidades > 0 THEN CONVERT(DECIMAL(18, 1),APGProduccion.dbo.mi_Maximo(((3600/((B.U_ProduccionPorHora)*1.05))*1.025),((3600/((B.U_ProduccionPorHora)*1.05))+0.5))) ELSE '0' END [CicloMax], ")


            qry.Append(" CASE WHEN A.InyeccionHora > 0 AND D.Unidades > 0 THEN CONVERT(DECIMAL(18,1),(CONVERT(DECIMAL(18,1),A.InyeccionHora))* D.Unidades) ELSE '0' END [ArticulosHora], ")
            qry.Append(" CASE WHEN A.InyeccionHora > 0 AND D.Unidades > 0  THEN CONVERT(DECIMAL(18,1),(A.InyeccionHora * D.Unidades)*12) ELSE '0' END [ArticulosTurno], ")
            qry.Append(" CASE WHEN A.InyeccionGrms > 0 THEN CONVERT(DECIMAL(18,6),A.InyeccionGrms / 1000) END [PesoInyeccionKgs], ")
            'qry.Append(" CASE WHEN A.InyeccionGrms > 0 THEN CONVERT(DECIMAL(18,1),A.InyeccionGrms) END [PesoInyeccionGrms], ")
            qry.Append(" CASE WHEN B.U_PesoenKgsComponete > 0 THEN CONVERT(DECIMAL(18,1),(B.U_PesoenKgsComponete*1000)) END [PesoInyeccionGrms], ")
            qry.Append(" CASE WHEN A.InyeccionGrms > 0 THEN CONVERT(DECIMAL(18,1),A.InyeccionGrms - A.InyeccionVariacion) END [RangoPesoGrmsMin], ")
            qry.Append(" CASE WHEN A.InyeccionGrms > 0 THEN CONVERT(DECIMAL(18,1),A.InyeccionGrms + A.InyeccionVariacion) END [RangoPesoGrmsMax], ")
            qry.Append(" CASE WHEN A.InyeccionHora > 0 AND D.Unidades > 0 THEN CONVERT(DECIMAL(18,1),CEILING(((A.InyeccionGrms * D.Unidades) * (A.InyeccionHora * 0.95))/'453.5924') *  ")
            qry.Append(" CASE WHEN E.Tipo = 'S' THEN 1.35 ELSE 1.08 END) ELSE '0' END [LbHora], ")
            qry.Append(" CASE WHEN A.InyeccionHora > 0 AND D.Unidades > 0 THEN CONVERT(DECIMAL(18,1),((CEILING(((A.InyeccionGrms * D.Unidades) * (A.InyeccionHora * 0.95)) /'453.5924') * 24) / CONVERT(DECIMAL(18,4),'2.2046'))/'25' *  ")
            qry.Append(" CASE WHEN E.Tipo = 'S' THEN 1.35 ELSE 1.08 END ) ELSE '0' END [Sacos25KG], ")
            qry.Append(" A.Bit_CreacionFecha, ")
            qry.Append(" A.Bit_CreacionUsuario, ")
            qry.Append(" A.Bit_ModificacionFecha, ")
            qry.Append(" A.Bit_ModificacionUsuario ")

            qry.Append(" FROM APGProduccion.dbo.PROD_Produccion_Parametros A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.Id COLLATE SQL_Latin1_General_CP850_CI_AS ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_CodigosProducidos C ON C.Id = A.Id ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Moldes D ON D.Id = C.Molde ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Maquinas E ON E.Id = D.MaquinaPreferencial ")
            qry.Append(" ORDER BY CodigoArticulo ASC ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_MoldesProduccionParametros(ByVal pCodigoArticulo As String, ByVal pInyeccionHora As String, ByVal pInyeccionGrms As String) As DataTable
        Try
            Dim qry As New StringBuilder

            If pInyeccionHora = String.Empty Then pInyeccionHora = "0"
            If pInyeccionGrms = String.Empty Then pInyeccionGrms = "0"

            qry.Append(" DECLARE @InyeccionHora AS INT ")
            qry.Append(" SET @InyeccionHora = " + pInyeccionHora + " ")
            qry.Append(" DECLARE @InyeccionGrms AS DECIMAL(18,6) ")
            qry.Append(" SET @InyeccionGrms = " + pInyeccionGrms + " ")
            qry.Append(" DECLARE @CodigoComponente AS VARCHAR(20) ")
            qry.Append(" SET @CodigoComponente = '" + pCodigoArticulo + "' ")

            qry.Append(" SELECT ")
            qry.Append(" A.Id [CodigoArticulo], ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" CASE WHEN @InyeccionHora > 0  THEN CONVERT(DECIMAL(18,1),(3600 / (CONVERT(DECIMAL(18,1),@InyeccionHora)))/ 1.05) ELSE '0' END [Ciclo], ")
            qry.Append(" CASE WHEN @InyeccionHora > 0 THEN CONVERT(DECIMAL(18,1),@InyeccionHora) END [CicloHora], ")
            qry.Append(" CASE WHEN @InyeccionHora > 0 THEN CONVERT(DECIMAL(18,1),@InyeccionHora * 12) END [CicloTurno], ")
            qry.Append(" CASE WHEN @InyeccionHora > 0 AND D.Unidades > 0 THEN CONVERT(DECIMAL(18,1),((3600 / (CONVERT(DECIMAL(18,1),@InyeccionHora))) /1.05)  * 0.975) ELSE '0' END [CicloMin], ")
            qry.Append(" CASE WHEN @InyeccionHora > 0 AND D.Unidades > 0 THEN CONVERT(DECIMAL(18,1),((3600 / (CONVERT(DECIMAL(18,1),@InyeccionHora)) /1.05)  * 1.025)) ELSE '0' END [CicloMax], ")
            qry.Append(" CASE WHEN @InyeccionHora > 0 AND D.Unidades > 0 THEN CONVERT(DECIMAL(18,1),(CONVERT(DECIMAL(18,1),@InyeccionHora))* D.Unidades) ELSE '0' END [ArticulosHora], ")
            qry.Append(" CASE WHEN @InyeccionHora > 0 AND D.Unidades > 0  THEN CONVERT(DECIMAL(18,1),(@InyeccionHora * D.Unidades)*12) ELSE '0' END [ArticulosTurno], ")
            qry.Append(" CASE WHEN @InyeccionGrms > 0 THEN CONVERT(DECIMAL(18,6),@InyeccionGrms / 1000) END [PesoInyeccionKgs], ")
            qry.Append(" CASE WHEN @InyeccionGrms > 0 THEN CONVERT(DECIMAL(18,1),@InyeccionGrms) END [PesoInyeccionGrms], ")
            qry.Append(" CASE WHEN @InyeccionGrms > 0 THEN CONVERT(DECIMAL(18,1),@InyeccionGrms - A.InyeccionVariacion) END [RangoPesoGrmsMin], ")
            qry.Append(" CASE WHEN @InyeccionGrms > 0 THEN CONVERT(DECIMAL(18,1),@InyeccionGrms + A.InyeccionVariacion) END [RangoPesoGrmsMax], ")
            qry.Append(" CASE WHEN @InyeccionHora > 0 AND D.Unidades > 0 THEN CONVERT(DECIMAL(18,1),CEILING(((@InyeccionGrms * D.Unidades) * (@InyeccionHora * 0.95))/'453.5924') *  ")
            qry.Append(" CASE WHEN E.Tipo = 'S' THEN 1.35 ELSE 1.08 END) ELSE '0' END [LbHora], ")
            qry.Append(" CASE WHEN @InyeccionHora > 0 AND D.Unidades > 0 THEN CONVERT(DECIMAL(18,1),((CEILING(((@InyeccionGrms * D.Unidades) * (@InyeccionHora * 0.95)) /'453.5924') * 24) / CONVERT(DECIMAL(18,4),'2.2046'))/'25' *  ")
            qry.Append(" CASE WHEN E.Tipo = 'S' THEN 1.35 ELSE 1.08 END ) ELSE '0' END [Sacos25KG], ")
            qry.Append(" A.Bit_CreacionFecha, ")
            qry.Append(" A.Bit_CreacionUsuario, ")
            qry.Append(" A.Bit_ModificacionFecha, ")
            qry.Append(" A.Bit_ModificacionUsuario  ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Produccion_Parametros A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.Id COLLATE SQL_Latin1_General_CP850_CI_AS ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_CodigosProducidos C ON C.Id = A.Id ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Moldes D ON D.Id = C.Molde ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Maquinas E ON E.Id = D.MaquinaPreferencial ")
            qry.Append(" WHERE A.Id = @CodigoComponente ")
            qry.Append(" ORDER BY CodigoArticulo ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function




#Region "ListaPreciosActualizar"
    Public Function GET_ListaPreciosActualizar_CodigosPadres() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" A.U_GrupoRastreo [GrupoRastreo], ")
            qry.Append(" A.ItemCode [CodigoPadre], ")
            qry.Append(" A.ItemName [NombrePadre] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM A ")
            qry.Append(" WHERE Not U_GrupoRastreo Is NULL ")
            qry.Append(" AND LEN(ItemCode) = 8 ")
            qry.Append(" ORDER BY A.U_GrupoRastreo,ItemCode ASC ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_ListaPreciosActualizar_CodigosPadres(ByVal pCodigoArticulo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" A.U_GrupoRastreo [GrupoRastreo], ")
            qry.Append(" A.ItemCode [CodigoPadre], ")
            qry.Append(" A.ItemName [NombrePadre] ")
            qry.Append(" FROM " + My.Settings.log_DB.ToString + ".dbo.OITM A ")
            qry.Append(" WHERE A.ItemCode in (" + pCodigoArticulo + ") ")
            'qry.Append(" AND LEN(ItemCode) = 8 ")
            qry.Append(" ORDER BY A.U_GrupoRastreo,ItemCode ASC ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    'Public Function GET_ListaPreciosActualizar_CodigosHijos(ByVal pCodigoPadre As String) As DataTable
    '    Try
    '        Dim qry As New StringBuilder

    '        qry.Append(" SELECT ")
    '        qry.Append(" CASE WHEN A.U_NoDeLinea = '0' THEN 'SI' ")
    '        qry.Append(" WHEN A.U_NoDeLinea = '1' THEN 'NO' ")
    '        qry.Append(" ELSE '' END [DeLinea], ")
    '        qry.Append(" A.ItemCode [CodigoArticulo], ")
    '        qry.Append(" A.ItemName [NombreArticulo], ")
    '        qry.Append(" A.CodeBars [CodigoBarras], ")

    '        qry.Append(" (Select Sum(CONVERT(DECIMAL(18,6),B.Price * AA.Quantity))   ")
    '        qry.Append(" FROM SBOGuateplast.dbo.ITT1 AA  ")
    '        qry.Append(" LEFT JOIN SBOGuateplast.dbo.ITM1 B ON B.ItemCode = AA.Code AND B.PriceList = 1 ")
    '        qry.Append(" WHERE Father = A.ItemCode  ) [CostoTotal],   ")

    '        'qry.Append(" (Select CONVERT(DECIMAL(18,6),Sum(Price * Quantity))  ")
    '        'qry.Append(" FROM SBOGuateplast.dbo.ITT1 ")
    '        'qry.Append(" WHERE Father = A.ItemCode ")
    '        'qry.Append(" ) [CostoTotal], ")

    '        qry.Append(" (SELECT  ")
    '        qry.Append(" CONVERT(DECIMAL(18,6),X.Price) [PrecioActual] ")
    '        qry.Append(" FROM SBOGuateplast.dbo.ITM1 X ")
    '        qry.Append(" WHERE PriceList = 1 ")
    '        qry.Append(" AND X.ItemCode = A.ItemCode) [CostoActual], ")
    '        qry.Append(" CONVERT(DECIMAL(18,6),AvgPrice) [CostoSTD] ")
    '        qry.Append(" FROM SBOGuateplast.dbo.OITM A ")
    '        qry.Append(" WHERE Len(ItemCode) > 8 ")
    '        qry.Append(" AND ItemCode LIKE ('" + pCodigoPadre + "%') ")


    '        Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message)
    '        Return Nothing
    '    End Try
    'End Function


    Public Function GET_ListaPreciosActualizar_CodigosHijos(ByVal pCodigoPadre As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" CASE WHEN U_NoDeLinea = 1 THEN 'NO'  ")
            qry.Append(" WHEN U_NoDeLinea = '0' THEN 'SI' ")
            qry.Append(" ELSE '' END [DeLinea], ")
            qry.Append(" isnull(CodeBars,'') [CodigoBarras], ")
            qry.Append(" ItemCode [CodigoArticulo], ")
            qry.Append(" ItemName [NombreArticulo], ")
            qry.Append(" CONVERT(DECIMAL(18,0),A.OnHand) [Stock], ")
            qry.Append(" (SELECT  ")
            qry.Append(" CONVERT(DECIMAL(18,6),SUM(X.Quantity * X1.Price)) [CostoTotal] ")
            qry.Append(" FROM " + My.Settings.log_DB.ToString + ".dbo.ITT1 X ")
            qry.Append(" LEFT JOIN " + My.Settings.log_DB.ToString + ".dbo.ITM1 X1 ON X1.ItemCode = X.Code AND X1.PriceList = '1' ")
            qry.Append(" WHERE Father = A.ItemCode ")
            qry.Append(" ) [CostoTotal], ")
            qry.Append(" (SELECT CONVERT(DECIMAL(18,6),Price) [CostoLP]  ")
            qry.Append(" FROM " + My.Settings.log_DB.ToString + ".dbo.ITM1 ")
            qry.Append(" WHERE ItemCode = A.ItemCode ")
            qry.Append(" AND PriceList = '1') [CostoActual], ")
            qry.Append(" A.AvgPrice [CostoSTD] ")
            qry.Append(" FROM " + My.Settings.log_DB.ToString + ".dbo.OITM A ")
            qry.Append(" WHERE LEN(A.ItemCode) > 8 ")
            qry.Append(" AND A.ItemCode IN  ")
            qry.Append(" (SELECT ItemCode [CodigoArticulo] ")
            qry.Append(" FROM " + My.Settings.log_DB.ToString + ".dbo.OITM ")
            qry.Append(" WHERE ItemCode LIKE ('" + pCodigoPadre + "%') ")
            qry.Append(" AND LEN(ItemCode) > 8 ")
            qry.Append(" UNION ")
            qry.Append(" SELECT DISTINCT Code [CodigoArticulo] ")
            qry.Append(" FROM " + My.Settings.log_DB.ToString + ".dbo.ITT1 ")
            qry.Append(" WHERE Father LIKE ('" + pCodigoPadre + "%') ")
            qry.Append(" AND Code LIKE ('AR%') ")
            qry.Append(" AND LEN(Code) > 8) ")



            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ListaPreciosActualizar_ListaMateriales(ByVal pCodigoHijo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            'lISTAPRECIOS
            qry.Append(" SELECT ")
            qry.Append(" Y.Father [CodigoArticulo], ")
            qry.Append(" Y.ChildNum [Num], ")
            qry.Append(" Y.Code [Componente], ")
            qry.Append(" Y2.ItemName [Nombre], ")
            qry.Append(" Y.Quantity [Cantidad], ")
            qry.Append(" CASE WHEN SUBSTRING(Y.Code,1,2) = 'CP' THEN ")
            qry.Append(" (SELECT  ")
            qry.Append(" CONVERT(DECIMAL(18,6),SUM(X.Quantity * X1.Price)) [CostoTotal] ")
            qry.Append(" FROM " + My.Settings.log_DB.ToString + ".dbo.ITT1 X ")
            qry.Append(" LEFT JOIN " + My.Settings.log_DB.ToString + ".dbo.ITM1 X1 ON X1.ItemCode = X.Code AND X1.PriceList = '1' ")
            qry.Append(" WHERE x.Father = Y.Code ")
            qry.Append(" ) ")
            qry.Append(" ELSE  ")
            qry.Append(" (SELECT CONVERT(DECIMAL(18,6),(Z.Price * Y.Quantity)) [CostoTotal] ")
            qry.Append(" FROM " + My.Settings.log_DB.ToString + ".dbo.ITM1 Z ")
            qry.Append(" WHERE Z.ItemCode = Y.Code ")
            qry.Append(" AND Z.PriceList = '1') ")
            qry.Append(" End ")
            qry.Append(" [CostoTotal], ")
            qry.Append(" (SELECT CONVERT(DECIMAL(18,6),Price) [CostoLP]  ")
            qry.Append(" FROM " + My.Settings.log_DB.ToString + ".dbo.ITM1 ")
            qry.Append(" WHERE ItemCode = Y.Code ")
            qry.Append(" AND PriceList = '1')  ")
            qry.Append(" [CostoActual], ")
            qry.Append(" Y2.AvgPrice [CostoSTD] ")
            qry.Append(" FROM " + My.Settings.log_DB.ToString + ".dbo.ITT1 Y ")
            qry.Append(" LEFT JOIN " + My.Settings.log_DB.ToString + ".dbo.ITM1 Y1 ON Y1.ItemCode = Y.Code AND Y1.PriceList = '1' ")
            qry.Append(" LEFT JOIN " + My.Settings.log_DB.ToString + ".dbo.OITM Y2 ON Y2.ItemCode = Y.Code ")
            qry.Append(" WHERE Father = '" + pCodigoHijo + "' ")
            qry.Append(" ORDER BY Y.Code DESC ")



            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Listado_CodigoArticulos_Hijos(ByVal pCodigoPadre As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" CASE WHEN U_NoDeLinea = '1' THEN 'NO' ")
            qry.Append(" WHEN U_NoDeLinea = '0' THEN 'SI' ")
            qry.Append(" ELSE '' END [DeLinea], ")
            qry.Append(" ItemCode [CodigoArticulo], ")
            qry.Append(" ItemName [NombreArticulo], ")
            qry.Append(" CodeBars [CodigoBarras] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM ")
            qry.Append(" WHERE ItemCode LIKE ('" + pCodigoPadre + "%') ")
            qry.Append(" AND LEN(ItemCode) > 8 ")



            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Listado_CodigoArticulos_MasArticulosEnListaMateriales(ByVal pCodigoArticulo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" ItemCode [CodigoArticulo] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM A ")
            qry.Append(" WHERE A.ItemCode = '" + pCodigoArticulo + "' ")
            qry.Append(" UNION ")
            qry.Append(" SELECT  ")
            qry.Append(" Code [CodigoArticulo] ")
            qry.Append(" FROM SBOGuateplast.dbo.ITT1 ")
            qry.Append(" WHERE Father = '" + pCodigoArticulo + "' ")
            qry.Append(" AND Code LIKE ('AR%') ")




            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Fill_EnsambleProduccion_PendienteSubir(ByVal pTipo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" Id_Nivel1, ")
            qry.Append(" Id_Nivel2, ")
            qry.Append(" Tipo, ")
            qry.Append(" NumeroSAP, ")
            qry.Append(" Prioridad, ")
            qry.Append(" CodigoArticulo, ")
            qry.Append(" Unidades, ")
            qry.Append(" Origen, ")
            qry.Append(" Destino, ")
            qry.Append(" Color, ")
            qry.Append(" GrupoCliente, ")
            qry.Append(" CodigoCliente, ")
            qry.Append(" NumeroOrden, ")
            qry.Append(" NumeroCampana, ")
            qry.Append(" Entrega, ")
            qry.Append(" Comentario_Nivel1, ")
            qry.Append(" Comentario_Nivel2, ")
            qry.Append(" SAP, ")
            qry.Append(" Estatus, ")
            qry.Append(" Bit_UsuarioCreacion, ")
            qry.Append(" Bit_FechaCreacion ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle_Temporal ")
            qry.Append(" WHERE Tipo = '" + pTipo + "' ")
            qry.Append(" AND Bit_UsuarioCreacion = '" + My.Settings.log_Usuario.ToString + "' ")
            qry.Append(" ORDER BY Id_Nivel1 ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function



    Public Function GET_Fill_EnsambleProduccion_PendienteSubir(ByVal pTipo As String, ByVal pLinea As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" Id_Nivel1, ")
            qry.Append(" Id_Nivel2, ")
            qry.Append(" Tipo, ")
            qry.Append(" NumeroSAP, ")
            qry.Append(" Prioridad, ")
            qry.Append(" CodigoArticulo, ")
            qry.Append(" Unidades, ")
            qry.Append(" Origen, ")
            qry.Append(" Destino, ")
            qry.Append(" Color, ")
            qry.Append(" GrupoCliente, ")
            qry.Append(" CodigoCliente, ")
            qry.Append(" NumeroOrden, ")
            qry.Append(" NumeroCampana, ")
            qry.Append(" Entrega, ")
            qry.Append(" Comentario_Nivel1, ")
            qry.Append(" Comentario_Nivel2, ")
            qry.Append(" SAP, ")
            qry.Append(" Estatus, ")
            qry.Append(" Bit_UsuarioCreacion, ")
            qry.Append(" Bit_FechaCreacion ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle_Temporal ")
            qry.Append(" WHERE Tipo = '" + pTipo + "' ")
            qry.Append(" AND Bit_UsuarioCreacion = '" + My.Settings.log_Usuario.ToString + "' ")
            qry.Append(" And Id_Nivel1 = '" + pLinea + "' ")
            qry.Append(" ORDER BY Id_Nivel1 ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Fill_EnsambleProduccion_PendienteSubirCompleto(ByVal pLinea As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" Id_Nivel1, ")
            qry.Append(" Id_Nivel2, ")
            qry.Append(" Tipo, ")
            qry.Append(" NumeroSAP, ")
            qry.Append(" Prioridad, ")
            qry.Append(" CodigoArticulo, ")
            qry.Append(" Unidades, ")
            qry.Append(" Origen, ")
            qry.Append(" Destino, ")
            qry.Append(" Color, ")
            qry.Append(" GrupoCliente, ")
            qry.Append(" CodigoCliente, ")
            qry.Append(" NumeroOrden, ")
            qry.Append(" NumeroCampana, ")
            qry.Append(" Entrega, ")
            qry.Append(" Comentario_Nivel1, ")
            qry.Append(" Comentario_Nivel2, ")
            qry.Append(" SAP, ")
            qry.Append(" Estatus, ")
            qry.Append(" Bit_UsuarioCreacion, ")
            qry.Append(" Bit_FechaCreacion ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle_Temporal ")
            qry.Append(" WHERE Tipo IN ('ED','EA') ")
            qry.Append(" AND Bit_UsuarioCreacion = '" + My.Settings.log_Usuario.ToString + "' ")
            qry.Append(" And Id_Nivel1 = '" + pLinea + "' ")
            qry.Append(" ORDER BY Id_Nivel1 ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Fill_EnsambleProduccion_ConListaExcluir(ByVal pCodigoArticulo As String, ByVal pNumerosSAPNoIncluir As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" CASE WHEN A.U_Tipo = '0' THEN 'PRODUCCION' END [Tipo],  ")
            qry.Append(" CONVERT(VARCHAR(50),A.DocNum) [NumeroSAP], ")
            qry.Append(" B.ItemCode [CodigoHijo], ")
            qry.Append(" B.ItemCode [CodigoArticulo], ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" A.Warehouse [Destino], ")
            qry.Append(" PlannedQty [Unidades], ")
            qry.Append(" A.PlannedQty - A.CmpltQty [Pendiente], ")
            qry.Append(" A.Comments [Comentario_Nivel1] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.ItemCode LIKE ('" + pCodigoArticulo + "%') ")
            qry.Append(" AND A.Status IN ('R','P') ")
            qry.Append(" AND A.U_Tipo = '0' ")
            If Not pNumerosSAPNoIncluir = String.Empty Or Not pNumerosSAPNoIncluir = Nothing Then
                qry.Append(" AND DocNum NOT IN (" + pNumerosSAPNoIncluir + ") ")
            End If



            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Fill_EnsambleProduccion_ConListaIncluir(ByVal pCodigoArticulo As String, ByVal pNumerosSAPIncluir As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" CASE WHEN A.U_Tipo = '0' THEN 'PRODUCCION' END [Tipo],  ")
            qry.Append(" CONVERT(VARCHAR(50),A.DocNum) [NumeroSAP], ")
            qry.Append(" B.ItemCode [CodigoHijo], ")
            qry.Append(" B.ItemCode [CodigoArticulo], ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" A.Warehouse [Destino], ")
            qry.Append(" PlannedQty [Unidades], ")
            qry.Append(" A.PlannedQty - A.CmpltQty [Pendiente], ")
            qry.Append(" A.Comments [Comentario_Nivel1] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.ItemCode LIKE ('" + pCodigoArticulo + "%') ")
            qry.Append(" AND A.Status IN ('R','P') ")
            qry.Append(" AND A.U_Tipo = '0' ")
            If Not pNumerosSAPIncluir = String.Empty Or pNumerosSAPIncluir = Nothing Then
                qry.Append(" AND DocNum IN (" + pNumerosSAPIncluir + ") ")
            End If



            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_Fill_Empaque(ByVal pCodigoPadre As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" OpcionEmpaque, ")
            qry.Append(" Tipo, ")
            qry.Append(" CodigoComprado, ")
            qry.Append(" Unidades, ")
            qry.Append(" Unidadmedida, ")
            qry.Append(" Observacion ")
            qry.Append(" FROM APGProduccion.dbo.prod_Empaque_Parametros ")
            qry.Append(" WHERE CodigoPadre = '" + pCodigoPadre + "' ")
            qry.Append(" ORDER BY OpcionEmpaque, Tipo ASC")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Fill_Empaque_Opciones(ByVal pCodigoPadre As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT DISTINCT OpcionEmpaque  ")
            qry.Append(" FROM APGProduccion.dbo.prod_Empaque_Parametros ")
            qry.Append(" WHERE CodigoPadre = '" + pCodigoPadre + "' ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ProduccionOrden_Encabezado(ByVal pNumSAP As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" A.DocEntry [DocEntry], ")
            qry.Append(" A.DocNum [NumSAP], ")
            qry.Append(" CASE  ")
            qry.Append(" WHEN Type = 'S' THEN 'Estándar'  ")
            qry.Append(" WHEN Type = 'P' THEN 'Especial'  ")
            qry.Append(" WHEN Type = 'D' THEN 'Desmontar'  ")
            qry.Append(" END [Tipo],  ")
            qry.Append("  CASE ")
            qry.Append(" WHEN Status = 'R' THEN 'Liberado'  ")
            qry.Append(" WHEN Status = 'P' THEN 'Planificado'  ")
            qry.Append(" WHEN Status = 'L' THEN 'Cerrado' ")
            qry.Append(" END [Estado],  ")
            'qry.Append(" Status [Estado],  ")
            qry.Append(" A.ItemCode [CodigoArticulo], ")
            qry.Append(" C.ItemName [NombreArticulo], ")
            qry.Append(" CONVERT(integer,A.PlannedQty) [Planeado], ")
            qry.Append(" A.Uom [UnidadMedida], ")
            qry.Append(" A.Warehouse [Almacen], ")
            qry.Append(" B.SeriesName [Serie], ")
            'qry.Append(" CONVERT(VARCHAR(10),CONVERT(DATE,A.PostDate,105)) [FechaFabricacion], ")
            'qry.Append(" CONVERT(VARCHAR(10),CONVERT(DATE,A.DueDate,105)) [FechaFinalizacion], ")
            qry.Append(" CONVERT(DATE,A.PostDate,105) [FechaFabricacion], ")
            qry.Append(" CONVERT(DATE,A.DueDate,105) [FechaFinalizacion], ")
            qry.Append(" D.USER_CODE [Usuario], ")
            qry.Append(" A.U_NBS_Priority [Prioridad], ")
            qry.Append(" A.U_Tipo [TipoOrden], ")
            qry.Append(" A.Comments [Comentarios] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.NNM1 B ON B.Series = A.Series ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM C ON C.ItemCode = A.ItemCode ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OUSR D ON D.USERID = A.UserSign ")
            qry.Append(" WHERE DocNum = '" + pNumSAP + "' ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_ProduccionOrden_Encabezado_XCodigo(ByVal pCodigo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" 0 [DocEntry], ")
            qry.Append(" 0 [NumSAP], ")
            qry.Append(" '' [Tipo], ")
            qry.Append(" 'Planificado' [Estado], ")
            qry.Append(" ItemCode [CodigoArticulo], ")
            qry.Append(" ItemName [NombreArticulo], ")
            qry.Append(" 0 [Planeado], ")
            qry.Append(" SalUnitMsr [UnidadMedida], ")
            qry.Append(" DfltWH [Almacen], ")
            qry.Append(" 'Primario' [Serie], ")
            qry.Append(" CONVERT(DATE,GETDATE(),105) [FechaFabricacion], ")
            qry.Append(" CONVERT(DATE,GETDATE(),105) [FechaFinalizacion], ")
            qry.Append(" 'APG_Default' [Usuario], ")
            qry.Append(" 999 [Prioridad], ")
            qry.Append(" 0 [TipoOrden], ")
            qry.Append(" '' [Comentarios] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM ")
            qry.Append(" WHERE ItemCode = '" + pCodigo + "' ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_ProduccionOrden_Detalle(ByVal pNumSAP As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" B.LineNum [NumLinea], ")
            qry.Append(" B.ItemCode [CodigoArticulo], ")
            qry.Append(" C.ItemName [NombreArticulo], ")
            qry.Append(" B.BaseQty [CantidadBase], ")
            qry.Append(" B.PlannedQty [Requerido], ")
            qry.Append(" C.OnHand [Stock], ")
            'qry.Append(" C.OnOrder [Solicitado], ")
            qry.Append(" B.PlannedQty [Solicitado], ")
            qry.Append(" B.WareHouse [Almacen] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.WOR1 B ON B.DocEntry = A.DocEntry ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM C ON C.ItemCode = B.ItemCode ")
            qry.Append(" WHERE DocNum = '" + pNumSAP + "' ")
            qry.Append(" ORDER BY NumLinea ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ProduccionOrden_Detalle_XCodigo(ByVal pCodigo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT  ")
            qry.Append(" A.ChildNum [NumLinea], ")
            qry.Append(" A.Code [CodigoArticulo], ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" A.Quantity [CantidadBase], ")
            qry.Append(" CONVERT(DECIMAL(18,6),0) [Requerido], ")
            qry.Append(" B.OnHand [Stock], ")
            qry.Append(" CONVERT(DECIMAL(18,0),0) [Solicitado], ")
            qry.Append(" A.Warehouse [Almacen] ")
            qry.Append(" FROM SBOGuateplast.dbo.ITT1 A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.Code ")
            qry.Append(" WHERE Father = '" + pCodigo + "' ")
            qry.Append(" ORDER BY NumLinea ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


#End Region

#Region "Mantenimiento Articulos"
    Public Function GET_OITM_Hijos() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" ItemCode [CodigoArticulo], ")
            qry.Append(" ItemName [NombreArticulo], ")
            qry.Append(" U_Color [Color], ")
            qry.Append(" CodeBars [CodigoBarras], ")
            qry.Append(" OnHand [Stock], ")
            qry.Append(" IsCommited [Comprometido], ")
            qry.Append(" OnOrder [Produccion], ")
            qry.Append(" MaxLevel [StockMaximo], ")
            qry.Append(" MinLevel [StockMinimo], ")
            qry.Append(" DfltWH [Bodega] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM ")
            qry.Append(" WHERE Len(ItemCode) > 8 ")
            qry.Append(" ORDER BY ItemCode ASC ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_OITM(ByVal pCodigoArticulo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" * ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM ")
            qry.Append(" WHERE ItemCode in (" + pCodigoArticulo + ") ")
            qry.Append(" ORDER BY ItemCode ASC")



            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function Validar_CodigoPadre(ByVal pCodigoPadre As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT * ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM A ")
            qry.Append(" WHERE SUBSTRING(A.ItemCode,1,8) IN ('" + pCodigoPadre + "') ")
            qry.Append(" AND LEN(A.ItemCode) = 8 ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Colores(ByVal pCodigoPadre As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT A.U_Color [Id], ")
            qry.Append(" B.Name [Nombre],  ")
            qry.Append(" CONVERT(BIT,A.U_NoDeLinea) [DeLinea]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.[@COLOR] B ON B.Code = A.U_Color ")
            qry.Append(" WHERE SUBSTRING(A.ItemCode,1,8) IN ('" + pCodigoPadre + "') ")
            qry.Append(" AND LEN(A.ItemCode) > 8 ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ListaMateriales(ByVal pCodigoArticulo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" A.Father [Padre], ")
            qry.Append(" A.ChildNum [NumLinea], ")
            qry.Append(" A.Code [CodigoArticulo], ")
            qry.Append(" C.ItemName [NombreArticulo],")
            qry.Append(" A.Quantity [Cantidad], ")
            qry.Append(" A.Warehouse [Bodega] ")
            qry.Append(" FROM SBOGuateplast.dbo.ITT1 A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM C ON C.ItemCode = A.Code ")
            qry.Append(" WHERE Father IN (" + pCodigoArticulo + ") ")
            qry.Append(" ORDER BY A.ChildNum ASC ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

#End Region

    Public Function GET_OrdenesEnsamble_Duplicar(ByVal pId As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" CONVERT(INTEGER,'999') [Prioridad], ")
            qry.Append(" CodigoArticulo [CodigoArticulo], ")
            qry.Append(" B.ItemName [NombreArticulo],")
            qry.Append(" CONVERT(VARCHAR,CONVERT(INTEGER,Unidades)) [CantidadEnsamble],")
            qry.Append(" Origen [Origen], ")
            qry.Append(" Destino [Destino], ")
            qry.Append(" Color [Color], ")
            qry.Append(" CONVERT(VARCHAR,GrupoCliente) [GrupoCliente], ")
            qry.Append(" CodigoCliente [CodigoCliente], ")
            qry.Append(" CONVERT(INTEGER,NumeroOrden) [NumOrden], ")
            qry.Append(" NumeroCampana [NumCampana], ")
            qry.Append(" Entrega [FechaEntrega], ")
            qry.Append(" Comentario_Nivel1 [Comentarios] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS ")
            qry.Append(" WHERE Id = '" + pId + "' ")
            qry.Append(" AND Tipo = 'EE' ")
            qry.Append(" ORDER BY CodigoArticulo ASC ")



            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_OrdenesProduccion_Duplicar(ByVal pId As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" C.Father [CodigoArticulo], ")
            qry.Append(" CONVERT(INTEGER,'999') [Prioridad], ")
            qry.Append(" Origen [OrigenAR], ")
            qry.Append(" A.CodigoArticulo [CodigoCP], ")
            qry.Append(" B.ItemName [NombreCP], ")
            qry.Append(" ISNULL(C.Quantity,0) [Cantidad], ") ''AGREGADO 2019 12
            qry.Append(" CONVERT(decimal(18,0),Unidades) [Producir], ")
            qry.Append(" Destino [DestinoCP], ")
            qry.Append(" Comentario_Nivel1 [Comentario] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle A ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Ordenes_Encabezado AB ON AB.Id = A.Id ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS ")
            qry.Append(" FULL JOIN SBOGuateplast.dbo.ITT1 C ON C.Father = AB.CodigoArticulo COLLATE SQL_Latin1_General_CP1_CI_AS  ") ''AGREGADO 2019 12 
            qry.Append(" AND C.Code COLLATE SQL_Latin1_General_CP1_CI_AS =  A.CodigoArticulo ")
            qry.Append(" WHERE A.Id = '" + pId + "' ")
            qry.Append(" AND A.Tipo = 'ED' ")
            qry.Append(" ORDER BY A.CodigoArticulo ASC ")




            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_OrdenesProduccion_Duplicar(ByVal pId As String, ByVal pCodigoArticulo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" T0.Father [CodigoArticulo] , ")
            qry.Append(" CONVERT(INTEGER,'999') [Prioridad], ")
            qry.Append(" 'Almacen' [OrigenAR], ")
            qry.Append(" T0.Code [CodigoCP], ")
            qry.Append(" T1.ItemName [NombreCP], ")
            qry.Append(" T0.Quantity [Cantidad], ")
            qry.Append(" CONVERT(DECIMAL(18,6),0) [Producir], ")
            qry.Append(" 'Almacen' [DestinoCP], ")
            qry.Append(" 'SOLO RECETA ORIGINAL' [Comentario] ")

            qry.Append(" FROM SBOGuateplast.dbo.ITT1 T0 ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM T1 ON T1.ItemCode = T0.Code ")
            qry.Append(" WHERE Father COLLATE SQL_Latin1_General_CP1_CI_AS  = '" + pCodigoArticulo + "'  ")
            qry.Append(" AND CODE COLLATE SQL_Latin1_General_CP1_CI_AS  NOT IN ")
            qry.Append(" ( ")
            qry.Append(" SELECT ")
            qry.Append(" A.CodigoArticulo [CodigoCP] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle A ")
            qry.Append(" WHERE A.Id = '" + pId + "' ")
            qry.Append(" AND A.Tipo = 'ED' ")
            qry.Append(" ) AND Code NOT LIKE ('CC%')  ")




            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function



    Public Function GET_OrdenesEnsambleProduccion_Duplicar(ByVal pCodigoArticulo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" Id, ")
            qry.Append(" CodigoArticulo, ")
            qry.Append(" B.ItemName [NombreArticulo], ")
            qry.Append(" Unidades, ")
            qry.Append(" Destino, ")
            qry.Append(" NumeroSAP, ")
            qry.Append(" GrupoCliente, ")
            qry.Append(" CodigoCliente, ")
            qry.Append(" NumeroOrden [NumOrden], ")
            qry.Append(" NumeroCampana [NumCampana], ")
            qry.Append(" Entrega [FechaEntrega], ")
            qry.Append(" Comentario_Nivel1 [Comentarios], ")
            qry.Append(" Bit_FechaCreacion [FechaCreacion] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS ")
            qry.Append(" WHERE CodigoArticulo = '" + pCodigoArticulo + "' ")
            qry.Append(" ORDER BY Bit_FechaCreacion DESC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_Nombre15Meses() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT TOP 1 ")
            qry.Append(" (DATENAME(MONTH,GETDATE()-30) + ' '+ DATENAME(YEAR,GETDATE()-30) ) [m01], ")
            qry.Append(" (DATENAME(MONTH,GETDATE()-60) + ' '+ DATENAME(YEAR,GETDATE()-60) ) [m02], ")
            qry.Append(" (DATENAME(MONTH,GETDATE()-90) + ' '+ DATENAME(YEAR,GETDATE()-90) ) [m03], ")
            qry.Append(" (DATENAME(MONTH,GETDATE()-120) + ' '+ DATENAME(YEAR,GETDATE()-120) ) [m04], ")
            qry.Append(" (DATENAME(MONTH,GETDATE()-150) + ' '+ DATENAME(YEAR,GETDATE()-150) ) [m05], ")
            qry.Append(" (DATENAME(MONTH,GETDATE()-180) + ' '+ DATENAME(YEAR,GETDATE()-180) ) [m06], ")
            qry.Append(" (DATENAME(MONTH,GETDATE()-210) + ' '+ DATENAME(YEAR,GETDATE()-210) ) [m07], ")
            qry.Append(" (DATENAME(MONTH,GETDATE()-240) + ' '+ DATENAME(YEAR,GETDATE()-240) ) [m08], ")
            qry.Append(" (DATENAME(MONTH,GETDATE()-270) + ' '+ DATENAME(YEAR,GETDATE()-270) ) [m09], ")
            qry.Append(" (DATENAME(MONTH,GETDATE()-300) + ' '+ DATENAME(YEAR,GETDATE()-300) ) [m10], ")
            qry.Append(" (DATENAME(MONTH,GETDATE()-330) + ' '+ DATENAME(YEAR,GETDATE()-330) ) [m11], ")
            qry.Append(" (DATENAME(MONTH,GETDATE()-360) + ' '+ DATENAME(YEAR,GETDATE()-360) ) [m12], ")
            qry.Append(" (DATENAME(MONTH,GETDATE()-390) + ' '+ DATENAME(YEAR,GETDATE()-390) ) [m13], ")
            qry.Append(" (DATENAME(MONTH,GETDATE()-420) + ' '+ DATENAME(YEAR,GETDATE()-420) ) [m14], ")
            qry.Append(" (DATENAME(MONTH,GETDATE()-450) + ' '+ DATENAME(YEAR,GETDATE()-450) ) [m15] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Bodegas ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ColoresProduccion_Pendientes(ByVal pCodigoArticulo As String) As String
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()

            qry.Append(" DECLARE @Colores VARCHAR(1000) ")

            qry.Append(" SELECT @Colores = COALESCE(@Colores + ', ','') + Color ")
            qry.Append(" FROM ")
            qry.Append(" (SELECT DISTINCT B.U_Color [Color] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A  ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.ItemCode LIKE ('CP%')   ")
            qry.Append(" AND Status IN ('R','P')  ")
            qry.Append(" AND SUBSTRING(A.ItemCode,1,8) = '" + pCodigoArticulo + "') QRY1 ")
            qry.Append(" ORDER BY Color ASC ")

            qry.Append(" Select DISTINCT ")
            qry.Append(" @Colores [Color] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A  ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.ItemCode ")
            qry.Append(" WHERE A.ItemCode LIKE ('CP%')   ")
            qry.Append(" AND Status IN ('R','P')  ")
            qry.Append(" AND SUBSTRING(A.ItemCode,1,8) = '" + pCodigoArticulo + "' ")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return dt.Rows(0)(0).ToString


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_EmergenciasProduccion_Transaciones(ByVal pTransaccion As String) As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()

            qry.Append(" SELECT ")
            qry.Append(" Prioridad, ")
            qry.Append(" FechaDespacho [FechaRecibo], ")
            qry.Append(" CodigoArticulo, ")
            qry.Append(" NombreArticulo, ")
            qry.Append(" Stock, ")
            qry.Append(" Planeado, ")
            qry.Append(" Completado, ")
            qry.Append(" Pendiente, ")
            qry.Append(" '' [HorasPendiente], ")
            'qry.Append(" ColoresPendientes [ColoresPendientes], ")
            qry.Append(" '' [ColoresPendientes], ")

            qry.Append(" ColorInicio [ColorInicio], ")
            qry.Append(" Cliente [Cliente], ")
            qry.Append(" Campana [Campaña], ")
            qry.Append(" FechaDespacho [FechaDespacho], ")
            qry.Append(" Observacion [Observacion] ")
            qry.Append(" FROM ")
            qry.Append(" (SELECT MAX(Id) [Id],  ")
            qry.Append(" MIN(CONVERT(INT,C.Prioridad)) [Prioridad],  ")
            qry.Append(" A.CodigoArticulo,  ")
            qry.Append(" B.ItemName [NombreArticulo],  ")
            qry.Append(" C.ColoresPendientes [ColoresPendientes], ")
            qry.Append(" SUM(A.Planeado) [Planeado],  ")
            qry.Append(" SUM(A.Completado) [Completado], ")
            qry.Append(" SUM(A.Pendiente) [Pendiente], ")
            qry.Append(" MAX(CONVERT(INTEGER,B.OnHand)) [Stock], ")
            qry.Append(" MAX(C.ColorInicio) [ColorInicio], ")
            qry.Append(" MAX(C.Cliente) [Cliente], ")
            qry.Append(" MAX(C.Campana) [Campana], ")
            qry.Append(" MAX(C.FechaDespacho) [FechaDespacho], ")
            qry.Append(" CONVERT(VARCHAR(255),C.Observacion) [Observacion] ")
            qry.Append(" FROM(  ")
            qry.Append(" Select   ")
            qry.Append(" a.U_NBS_Priority [Prioridad], ")
            qry.Append(" SUBSTRING(A.ItemCode,1,8) [CodigoArticulo],   ")
            qry.Append(" CONVERT(INTEGER,A.PlannedQty) [Planeado],  ")
            qry.Append(" CONVERT(INTEGER,A.CmpltQty) [Completado],   ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (A.PlannedQty - A.CmpltQty) > 0 THEN (A.PlannedQty - A.CmpltQty) ELSE '0' END) [Pendiente] ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A   ")
            qry.Append(" WHERE A.ItemCode LIKE ('CP%')    ")
            qry.Append(" AND Status IN ('R','P')   ")
            qry.Append(" ) A  ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.CodigoArticulo ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_EmergenciasProduccion_Plan C ON C.CodigoArticulo = A.CodigoArticulo COLLATE SQL_Latin1_General_CP1_CI_AS AND C.Id = '" + pTransaccion + "' ")
            qry.Append(" WHERE C.Id = '" + pTransaccion + "' ")
            qry.Append(" GROUP BY A.CodigoArticulo,B.ItemName,C.ColoresPendientes,CONVERT(VARCHAR(255),C.Observacion)) QRY  ")
            qry.Append(" ORDER BY Prioridad, CodigoArticulo ASC ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_EmergenciasProduccion_UltimoPlan() As String
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()

            qry.Append(" SELECT MAX(Id) [Id] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_EmergenciasProduccion_Encabezado ")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return dt.Rows(0)(0).ToString


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ListaPreciosClientes(ByVal pNumLista As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" A.ListNum [ListaPrecios], ")
            qry.Append(" A.CardCode [CodigoCliente], ")
            qry.Append(" A.CardName [NombreCliente], ")
            qry.Append(" B.GroupName [GrupoCliente], ")
            qry.Append(" A.Currency [Moneda] ")
            qry.Append(" FROM SBOGuateplast.dbo.OCRD A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OCRG B ON B.GroupCode = A.GroupCode ")
            qry.Append(" WHERE ListNum = '" + pNumLista + "' ")
            qry.Append(" ORDER BY CardCode ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ListaPreciosCliente_CodigoCliente(ByVal pCodigoCliente As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" A.ListNum [ListaPrecios], ")
            qry.Append(" A.CardCode [CodigoCliente], ")
            qry.Append(" A.CardName [NombreCliente], ")
            qry.Append(" B.GroupName [GrupoCliente], ")
            qry.Append(" A.Currency [Moneda], ")
            qry.Append(" A.U_Dueno ")
            qry.Append(" FROM SBOGuateplast.dbo.OCRD A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OCRG B ON B.GroupCode = A.GroupCode ")
            qry.Append(" WHERE CardCode = '" + pCodigoCliente + "' ")
            qry.Append(" ORDER BY CardCode ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Catalogo_Dueños() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" ISNULL(A.U_Dueno,'') [Dueno], ")
            qry.Append(" A.CardCode [CodigoCliente], ")
            qry.Append(" A.CardName [NombreCliente] ")
            qry.Append(" FROM SBOGuateplast.dbo.OCRD A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OCRG B ON B.GroupCode = A.GroupCode ")
            qry.Append(" ORDER BY CardCode ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ListaPreciosCliente_Dueño(ByVal pDueno As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" A.ListNum [ListaPrecios], ")
            qry.Append(" A.CardCode [CodigoCliente], ")
            qry.Append(" A.CardName [NombreCliente], ")
            qry.Append(" B.GroupName [GrupoCliente], ")
            qry.Append(" A.Currency [Moneda], ")
            qry.Append(" A.U_Dueno ")
            qry.Append(" FROM SBOGuateplast.dbo.OCRD A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OCRG B ON B.GroupCode = A.GroupCode ")
            qry.Append(" WHERE U_Dueno = '" + pDueno + "' ")
            qry.Append(" ORDER BY CardCode ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ReporteColores() As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" Color, ")
            qry.Append(" Nombre, ")
            qry.Append(" Estado, ")
            qry.Append(" KgColorante, ")
            qry.Append(" ARCPCC, ")
            qry.Append(" ARCPCC_Stock, ")
            qry.Append(" AR_Todos, ")
            qry.Append(" AR_DL, ")
            qry.Append(" AR_DL_Stock, ")
            qry.Append(" AR_NDL, ")
            qry.Append(" AR_NDL_Stock, ")
            qry.Append(" CP_Todos, ")
            qry.Append(" CP_DL, ")
            qry.Append(" CP_DL_Stock, ")
            qry.Append(" CP_NDL, ")
            qry.Append(" CP_NDL_Stock, ")
            qry.Append(" CC_Todos, ")
            qry.Append(" CC_DL, ")
            qry.Append(" CC_DL_Stock, ")
            qry.Append(" CC_NDL, ")
            qry.Append(" CC_NDL_Stock ")
            qry.Append(" FROM ")

            qry.Append(" (SELECT ")
            qry.Append(" A.Code [Color], ")
            qry.Append(" A.Name [Nombre], ")
            qry.Append(" CASE WHEN A.U_Status = '' OR A.U_Status IS NULL THEN 'DeLinea' ")
            qry.Append(" WHEN A.U_Status = 'E' THEN 'Especial' ")
            qry.Append(" WHEN A.U_Status = 'F' THEN 'Formula' ")
            qry.Append(" WHEN A.U_Status = 'D' THEN 'Descontinuado' ")
            qry.Append(" ELSE '' END [Estado], ")

            qry.Append(" (SELECT  ")
            qry.Append(" ISNULL(SUM(OnHand),0) [KgColorante] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM ")
            qry.Append(" WHERE ")
            qry.Append(" U_Color = A.Code ")
            qry.Append(" AND (ItemCode LIKE ('MPAD%') ")
            qry.Append(" OR ItemCode LIKE ('MPAO%') ")
            qry.Append(" OR ItemCode LIKE ('MPAU%') ")
            qry.Append(" OR ItemCode LIKE ('MPCC%') ")
            qry.Append(" OR ItemCode LIKE ('MPCL%') ")
            qry.Append(" OR ItemCode LIKE ('MPCM%') ")
            qry.Append(" OR ItemCode LIKE ('MPCP%') ")
            qry.Append(" OR ItemCode LIKE ('MPCT%'))) ")
            qry.Append(" [KgColorante], ")

            qry.Append(" (SELECT COUNT(T1.ItemCode) [Cantidad] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM T1 ")
            qry.Append(" WHERE ")
            qry.Append(" (T1.ItemCode LIKE ('AR%') ")
            qry.Append(" OR T1.ItemCode LIKE ('CP%') ")
            qry.Append(" OR T1.ItemCode LIKE ('CC%')) ")
            qry.Append(" AND T1.U_Color = A.Code ")
            qry.Append(" ) [ARCPCC], ")

            qry.Append(" (SELECT COUNT(T1.ItemCode) [Cantidad]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM T1 ")
            qry.Append(" WHERE (T1.ItemCode LIKE ('AR%') ")
            qry.Append(" OR T1.ItemCode LIKE ('CP%') ")
            qry.Append(" OR T1.ItemCode LIKE ('CC%')) ")
            qry.Append(" AND T1.U_Color = A.Code ")
            qry.Append(" AND (T1.OnHand > 0 OR T1.OnHand <> NULL) ")
            qry.Append(" ) [ARCPCC_Stock], ")

            qry.Append(" (SELECT COUNT(T1.ItemCode) [Cantidad]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM T1 ")
            qry.Append(" WHERE T1.ItemCode LIKE ('AR%') ")
            qry.Append(" AND T1.U_Color = A.Code ")
            qry.Append(" ) [AR_Todos], ")

            qry.Append(" (SELECT COUNT(T1.ItemCode) [Cantidad]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM T1 ")
            qry.Append(" WHERE T1.U_Color = A.Code ")
            qry.Append(" AND T1.U_NoDeLinea = '0' ")
            qry.Append(" AND T1.ItemCode LIKE ('AR%') ")
            qry.Append(" ) [AR_DL], ")

            qry.Append(" (SELECT COUNT(T1.ItemCode) [Cantidad]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM T1 ")
            qry.Append(" WHERE T1.U_Color = A.Code ")
            qry.Append(" AND T1.OnHand > 0 ")
            qry.Append(" AND T1.U_NoDeLinea = '0'  ")
            qry.Append(" AND T1.ItemCode LIKE ('AR%') ")
            qry.Append(" ) [AR_DL_Stock], ")

            qry.Append(" (SELECT COUNT(T1.ItemCode) [Cantidad] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM T1 ")
            qry.Append(" WHERE T1.U_Color = A.Code ")
            qry.Append(" AND (T1.U_NoDeLinea = '1' OR T1.U_NoDeLinea IS NULL) ")
            qry.Append(" AND T1.ItemCode LIKE ('AR%') ")
            qry.Append(" ) [AR_NDL], ")

            qry.Append(" (SELECT COUNT(T1.ItemCode) [Cantidad]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM T1 ")
            qry.Append(" WHERE T1.U_Color = A.Code ")
            qry.Append(" AND T1.OnHand > 0 ")
            qry.Append(" AND (T1.U_NoDeLinea = '1' OR T1.U_NoDeLinea IS NULL) ")
            qry.Append(" AND T1.ItemCode LIKE ('AR%') ")
            qry.Append(" ) [AR_NDL_Stock], ")

            qry.Append(" (SELECT COUNT(T1.ItemCode) [Cantidad]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM T1 ")
            qry.Append(" WHERE T1.ItemCode LIKE ('CP%') ")
            qry.Append(" AND T1.U_Color = A.Code ")
            qry.Append(" ) [CP_Todos], ")

            qry.Append(" (SELECT COUNT(T1.ItemCode) [Cantidad]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM T1 ")
            qry.Append(" WHERE T1.U_Color = A.Code ")
            qry.Append(" AND T1.U_NoDeLinea = '0' ")
            qry.Append(" AND T1.ItemCode LIKE ('CP%') ")
            qry.Append(" ) [CP_DL], ")

            qry.Append(" (SELECT COUNT(T1.ItemCode) [Cantidad]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM T1 ")
            qry.Append(" WHERE T1.U_Color = A.Code ")
            qry.Append(" AND T1.OnHand > 0 ")
            qry.Append(" AND T1.U_NoDeLinea = '0' ")
            qry.Append(" AND T1.ItemCode LIKE ('CP%') ")
            qry.Append(" ) [CP_DL_Stock], ")

            qry.Append(" (SELECT COUNT(T1.ItemCode) [Cantidad]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM T1 ")
            qry.Append(" WHERE T1.U_Color = A.Code ")
            qry.Append(" AND (T1.U_NoDeLinea = '1' OR T1.U_NoDeLinea IS NULL) ")
            qry.Append(" AND T1.ItemCode LIKE ('CP%') ")
            qry.Append(" ) [CP_NDL], ")

            qry.Append(" (SELECT COUNT(T1.ItemCode) [Cantidad]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM T1 ")
            qry.Append(" WHERE T1.U_Color = A.Code ")
            qry.Append(" AND T1.OnHand > 0 ")
            qry.Append(" AND (T1.U_NoDeLinea = '1' OR T1.U_NoDeLinea IS NULL) ")
            qry.Append(" AND T1.ItemCode LIKE ('CP%') ")
            qry.Append(" ) [CP_NDL_Stock], ")

            qry.Append(" (SELECT COUNT(T1.ItemCode) [Cantidad] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM T1 ")
            qry.Append(" WHERE T1.ItemCode LIKE ('CC%') ")
            qry.Append(" AND T1.U_Color = A.Code ")
            qry.Append(" ) [CC_Todos], ")

            qry.Append(" (SELECT COUNT(T1.ItemCode) [Cantidad]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM T1 ")
            qry.Append(" WHERE T1.U_Color = A.Code ")
            qry.Append(" AND T1.U_NoDeLinea = '0' ")
            qry.Append(" AND T1.ItemCode LIKE ('CC%') ")
            qry.Append(" ) [CC_DL], ")

            qry.Append(" (SELECT COUNT(T1.ItemCode) [Cantidad]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM T1 ")
            qry.Append(" WHERE T1.U_Color = A.Code ")
            qry.Append(" AND T1.OnHand > 0 ")
            qry.Append(" AND T1.U_NoDeLinea = '0' ")
            qry.Append(" AND T1.ItemCode LIKE ('CC%') ")
            qry.Append(" ) [CC_DL_Stock], ")

            qry.Append(" (SELECT COUNT(T1.ItemCode) [Cantidad]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM T1 ")
            qry.Append(" WHERE T1.U_Color = A.Code ")
            qry.Append(" AND (T1.U_NoDeLinea = '1' OR T1.U_NoDeLinea IS NULL) ")
            qry.Append(" AND T1.ItemCode LIKE ('CC%') ")
            qry.Append(" ) [CC_NDL], ")

            qry.Append(" (SELECT COUNT(T1.ItemCode) [Cantidad]  ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM T1 ")
            qry.Append(" WHERE T1.U_Color = A.Code ")
            qry.Append(" AND T1.OnHand > 0 ")
            qry.Append(" AND (T1.U_NoDeLinea = '1' OR T1.U_NoDeLinea IS NULL) ")
            qry.Append(" AND T1.ItemCode LIKE ('CC%') ")
            qry.Append(" ) [CC_NDL_Stock] ")

            qry.Append(" FROM SBOGuateplast.dbo.[@COLOR] A ) QRY1 ")
            ''qry.Append(" ")
            qry.Append(" ORDER BY QRY1.Color ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_Colores_Detalle(ByVal pTipo As String, ByVal pColor As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" T1.U_Color [Color], ")
            qry.Append(" T1.ItemCode [Codigo], ")
            qry.Append(" T1.ItemName [Nombre], ")
            qry.Append(" CASE WHEN T1.U_NoDeLinea = '0' THEN 'SI' ELSE 'NO' END [DeLinea], ")
            qry.Append(" CONVERT(DECIMAL(18,0),T1.OnHand) [Stock] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM T1 ")
            qry.Append(" WHERE T1.ItemCode LIKE ('" + pTipo + "%') ")
            qry.Append(" AND T1.U_Color = '" + pColor + "' ")
            qry.Append(" ORDER BY T1.ItemCode ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_ListaMateriales_MasCostos(ByVal pCodigoArticulo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" A.Father [CodigoPadre], ")
            qry.Append(" A.ChildNum [Fila], ")
            qry.Append(" A.Code [CodigoArticulo], ")
            qry.Append(" A.Quantity [Cantidad], ")
            qry.Append(" A.PriceList [Listaprecios], ")
            qry.Append(" A.Price [Precio], ")
            qry.Append(" A.Currency [Moneda], ")
            qry.Append(" A.OrigPrice [PrecioOrigen], ")
            qry.Append(" A.OrigCurr [MonedaOrigen], ")
            qry.Append(" B.Price [Costo], ")
            qry.Append(" B.Currency [CostoMoneda], ")
            qry.Append(" A.Warehouse [Bodega] ")

            'qry.Append(" FROM SBOGuateTEST.dbo.ITT1 A ")
            'qry.Append(" LEFT JOIN SBOGuateTEST.dbo.ITM1 B ON B.ItemCode = A.Code AND B.PriceList = '1' ")
            qry.Append(" FROM SBOGuateplast.dbo.ITT1 A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.ITM1 B ON B.ItemCode = A.Code AND B.PriceList = '1' ")
            qry.Append(" WHERE Father = '" + pCodigoArticulo + "' ")
            qry.Append(" ORDER BY A.ChildNum ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_Recibos_UltimoIngreso(ByVal pCodigoPadre As String) As String
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()

            qry.Append(" SELECT ")
            'qry.Append(" MAX(B.DocDate) [Fecha] ")
            qry.Append(" CONVERT(DATE,MAX(B.DocDate),111) [Fecha] ")
            qry.Append(" FROM sboguateplast.dbo.IGN1 A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OIGN B ON B.DocEntry = A.DocEntry ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OWOR C ON C.DocEntry = A.BaseEntry ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM D ON A.ItemCode = D.ItemCode ")
            qry.Append(" WHERE A.ItemCode LIKE '" + pCodigoPadre + "%' ")
            qry.Append(" AND Status IN ('R','P') ")
            qry.Append(" AND b.CANCELED = 'N' ")
            qry.Append(" AND b.DocStatus = 'O' ")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            If dt.Rows.Count = Nothing Then
                Return Nothing
            End If

            Return dt.Rows(0)(0).ToString


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_PlanificacionProduccion_Ordenes() As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()

            qry.Append(" SELECT ")
            qry.Append(" CASE WHEN C.Prioridad IS NULL THEN 'NO' ELSE 'SI' END [Emergencia], ")
            qry.Append(" MAX(ISNULL(C.Prioridad,'0')) [Prioridad], ")
            qry.Append(" A.CodigoArticulo,  ")
            qry.Append(" B.ItemName [NombreArticulo],  ")
            qry.Append(" SUM(A.Planeado) [Planeado],  ")
            qry.Append(" SUM(A.Completado) [Completado],  ")
            qry.Append(" SUM(A.Pendiente) [Pendiente], ")
            qry.Append(" MAX(ISNULL(E.MaquinaPreferencial,'0')) [Preferencial]   ")
            qry.Append(" FROM(  ")
            qry.Append(" Select   ")
            qry.Append(" SUBSTRING(A.ItemCode,1,8) [CodigoArticulo],   ")
            qry.Append(" CONVERT(INTEGER,A.PlannedQty) [Planeado],  ")
            qry.Append(" CONVERT(INTEGER,A.CmpltQty) [Completado],   ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (A.PlannedQty - A.CmpltQty) > 0 THEN (A.PlannedQty - A.CmpltQty) ELSE '0' END) [Pendiente]   ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A   ")
            qry.Append(" WHERE A.ItemCode LIKE ('CP%')    ")
            qry.Append(" AND Status IN ('R','P')   ")
            qry.Append(" ) A  ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.CodigoArticulo  ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_EmergenciasProduccion_Plan C ON C.CodigoArticulo = A.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            qry.Append(" AND C.Id = (SELECT MAX(Id) FROM APGProduccion.dbo.PROD_EmergenciasProduccion_Plan) ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_CodigosProducidos D ON D.Id = B.ItemCode COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Moldes E ON E.Id = D.Molde ")
            qry.Append(" WHERE A.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS NOT IN (SELECT CodigoArticulo FROM APGProduccion.dbo.PROD_ProgramacionProduccion) ")
            qry.Append(" GROUP BY A.CodigoArticulo,B.ItemName,C.Prioridad ")
            qry.Append(" ORDER BY C.Prioridad ASC ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_EmergenciasProduccion_Ordenes() As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()

            qry.Append(" SELECT ")
            qry.Append(" CASE WHEN C.Prioridad IS NULL THEN 'NO' ELSE 'SI' END [Emergencia], ")
            qry.Append(" MAX(ISNULL(C.Prioridad,'0')) [Prioridad], ")
            qry.Append(" A.CodigoArticulo,  ")
            qry.Append(" B.ItemName [NombreArticulo],  ")
            qry.Append(" SUM(A.Planeado) [Planeado],  ")
            qry.Append(" SUM(A.Completado) [Completado],  ")
            qry.Append(" SUM(A.Pendiente) [Pendiente], ")
            qry.Append(" MAX(ISNULL(E.MaquinaPreferencial,'0')) [Preferencial]   ")
            qry.Append(" FROM(  ")
            qry.Append(" Select   ")
            qry.Append(" SUBSTRING(A.ItemCode,1,8) [CodigoArticulo],   ")
            qry.Append(" CONVERT(INTEGER,A.PlannedQty) [Planeado],  ")
            qry.Append(" CONVERT(INTEGER,A.CmpltQty) [Completado],   ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (A.PlannedQty - A.CmpltQty) > 0 THEN (A.PlannedQty - A.CmpltQty) ELSE '0' END) [Pendiente]   ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A   ")
            qry.Append(" WHERE A.ItemCode LIKE ('CP%')    ")
            qry.Append(" AND Status IN ('R','P')   ")
            qry.Append(" ) A  ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.CodigoArticulo  ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_EmergenciasProduccion_Plan C ON C.CodigoArticulo = A.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            qry.Append(" AND C.Id = (SELECT MAX(Id) FROM APGProduccion.dbo.PROD_EmergenciasProduccion_Plan) ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_CodigosProducidos D ON D.Id = B.ItemCode COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Moldes E ON E.Id = D.Molde ")
            qry.Append(" GROUP BY A.CodigoArticulo,B.ItemName,C.Prioridad ")
            qry.Append(" ORDER BY C.Prioridad ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_PlanificacionProduccion_Programada(ByVal pCodigoArticulo) As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()

            qry.Append(" SELECT ")
            qry.Append(" MAX(ISNULL(E.MaquinaPreferencial,'0')) [Preferencial] , ")
            qry.Append(" 'En Espera' [Estado], ")
            qry.Append(" MAX(ISNULL(C.Prioridad,'0')) [Prioridad], ")
            qry.Append(" 99 [PrioridadMaquina], ")
            qry.Append(" A.CodigoArticulo,  ")
            qry.Append(" B.ItemName [NombreArticulo],  ")
            qry.Append(" SUM(A.Planeado) [Planeado],  ")
            qry.Append(" SUM(A.Completado) [Completado],  ")
            qry.Append(" SUM(A.Pendiente) [Pendiente], ")
            qry.Append(" '' [ProduccionHora], ")
            qry.Append(" 0 [HorasPendiente], ")
            qry.Append(" '' [Comentarios] ")
            qry.Append(" FROM(  ")
            qry.Append(" Select   ")
            qry.Append(" SUBSTRING(A.ItemCode,1,8) [CodigoArticulo],   ")
            qry.Append(" CONVERT(INTEGER,A.PlannedQty) [Planeado],  ")
            qry.Append(" CONVERT(INTEGER,A.CmpltQty) [Completado],   ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (A.PlannedQty - A.CmpltQty) > 0 THEN (A.PlannedQty - A.CmpltQty) ELSE '0' END) [Pendiente]   ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A   ")
            qry.Append(" WHERE A.ItemCode LIKE ('CP%')    ")
            qry.Append(" AND Status IN ('R','P')   ")
            qry.Append(" ) A  ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.CodigoArticulo  ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_EmergenciasProduccion_Plan C ON C.CodigoArticulo = A.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            qry.Append(" AND C.Id = (SELECT MAX(Id) FROM APGProduccion.dbo.PROD_EmergenciasProduccion_Plan) ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_CodigosProducidos D ON D.Id = B.ItemCode COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Moldes E ON E.Id = D.Molde ")
            qry.Append(" WHERE ItemCode = '" + pCodigoArticulo + "' ")
            qry.Append(" GROUP BY A.CodigoArticulo,B.ItemName,C.Prioridad,E.MaquinaPreferencial ")
            qry.Append(" ORDER BY E.MaquinaPreferencial,C.Prioridad ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_PlanificacionProduccion_Programada() As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()

            qry.Append(" SELECT ")
            'qry.Append(" CONVERT(VARCHAR(2),F.Preferencial) [Preferencial] , ")
            qry.Append(" F.Preferencial [Preferencial] , ")
            qry.Append(" F.Estado [Estado], ")
            qry.Append(" C.Prioridad [Prioridad], ")
            qry.Append(" F.PrioridadMaquina [PrioridadMaquina], ")
            qry.Append(" A.CodigoArticulo,  ")
            qry.Append(" B.ItemName [NombreArticulo],  ")
            qry.Append(" SUM(A.Planeado) [Planeado],  ")
            qry.Append(" SUM(A.Completado) [Completado],  ")
            qry.Append(" SUM(A.Pendiente) [Pendiente], ")
            qry.Append(" '' [ProduccionHora], ")
            qry.Append(" 0 [HorasPendiente], ")
            qry.Append(" F.Comentarios [Comentarios] ")
            qry.Append(" FROM(  ")
            qry.Append(" Select   ")
            qry.Append(" SUBSTRING(A.ItemCode,1,8) [CodigoArticulo],   ")
            qry.Append(" CONVERT(INTEGER,A.PlannedQty) [Planeado],  ")
            qry.Append(" CONVERT(INTEGER,A.CmpltQty) [Completado],   ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (A.PlannedQty - A.CmpltQty) > 0 THEN (A.PlannedQty - A.CmpltQty) ELSE '0' END) [Pendiente]   ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A   ")
            qry.Append(" WHERE A.ItemCode LIKE ('CP%')    ")
            qry.Append(" AND Status IN ('R','P')   ")
            qry.Append(" ) A  ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.CodigoArticulo  ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_EmergenciasProduccion_Plan C ON C.CodigoArticulo = A.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS AND C.Id = (SELECT MAX(Id) FROM APGProduccion.dbo.PROD_EmergenciasProduccion_Plan) ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_CodigosProducidos D ON D.Id = B.ItemCode COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Moldes E ON E.Id = D.Molde ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_ProgramacionProduccion F ON F.CodigoArticulo = A.CodigoArticulo COLLATE SQL_Latin1_General_CP1_CI_AS ")
            qry.Append(" WHERE A.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS IN (SELECT CodigoArticulo FROM APGProduccion.dbo.PROD_ProgramacionProduccion) ")
            qry.Append(" GROUP BY A.CodigoArticulo,F.Preferencial,F.Estado,C.Prioridad,F.PrioridadMaquina,B.ItemCode,B.ItemName,F.Comentarios ")
            qry.Append(" ORDER BY F.Preferencial,F.PrioridadMaquina ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ProgramacionProgramada_Asignada() As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()

            qry.Append(" SELECT ")
            'qry.Append(" CONVERT(VARCHAR(2),F.Preferencial) [Preferencial] , ")
            qry.Append(" F.Preferencial [Preferencial] , ")
            qry.Append(" F.Estado [Estado], ")
            qry.Append(" C.Prioridad [Prioridad], ")
            qry.Append(" F.PrioridadMaquina [PrioridadMaquina], ")
            qry.Append(" A.CodigoArticulo,  ")
            qry.Append(" B.ItemName [NombreArticulo],  ")
            qry.Append(" SUM(A.Planeado) [Planeado],  ")
            qry.Append(" SUM(A.Completado) [Completado],  ")
            qry.Append(" SUM(A.Pendiente) [Pendiente], ")
            qry.Append(" '' [ProduccionHora], ")
            qry.Append(" 0 [HorasPendiente], ")
            qry.Append(" F.Comentarios [Comentarios] ")
            qry.Append(" FROM(  ")
            qry.Append(" Select   ")
            qry.Append(" SUBSTRING(A.ItemCode,1,8) [CodigoArticulo],   ")
            qry.Append(" CONVERT(INTEGER,A.PlannedQty) [Planeado],  ")
            qry.Append(" CONVERT(INTEGER,A.CmpltQty) [Completado],   ")
            qry.Append(" CONVERT(INTEGER,CASE WHEN (A.PlannedQty - A.CmpltQty) > 0 THEN (A.PlannedQty - A.CmpltQty) ELSE '0' END) [Pendiente]   ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A   ")
            qry.Append(" WHERE A.ItemCode LIKE ('CP%')    ")
            qry.Append(" AND Status IN ('R','P')   ")
            qry.Append(" ) A  ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.CodigoArticulo  ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_EmergenciasProduccion_Plan C ON C.CodigoArticulo = A.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS AND C.Id = (SELECT MAX(Id) FROM APGProduccion.dbo.PROD_EmergenciasProduccion_Plan) ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_CodigosProducidos D ON D.Id = B.ItemCode COLLATE SQL_Latin1_General_CP850_CI_AS  ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Moldes E ON E.Id = D.Molde ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_ProgramacionProduccion F ON F.CodigoArticulo = A.CodigoArticulo COLLATE SQL_Latin1_General_CP1_CI_AS ")
            qry.Append(" WHERE A.CodigoArticulo COLLATE SQL_Latin1_General_CP850_CI_AS IN (SELECT CodigoArticulo FROM APGProduccion.dbo.PROD_ProgramacionProduccion) ")
            qry.Append(" GROUP BY A.CodigoArticulo,F.Preferencial,F.Estado,C.Prioridad,F.PrioridadMaquina,B.ItemCode,B.ItemName,F.Comentarios ")
            qry.Append(" ORDER BY F.Preferencial,F.PrioridadMaquina ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_PrioridadMaquina_Siguiente(ByVal pPreferencial As String) As String
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()

            'SUSTITUYE SP sp_MaquinaPrioridad_Siguiente
            qry.Append(" SELECT COUNT(Preferencial) + 1 [Prioridad] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_ProgramacionProduccion ")
            qry.Append(" WHERE Preferencial = '" + pPreferencial + "' ")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar
            If dt.Rows.Count = Nothing Then
                Return 1
            Else
                Return dt.Rows(0)(0).ToString
            End If

            Return Nothing

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_PrioridadMaquina_Maxima(ByVal pPreferencial As String) As String
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()

            qry.Append(" SELECT COUNT(Preferencial) [Prioridad] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_ProgramacionProduccion ")
            qry.Append(" WHERE Preferencial = '" + pPreferencial + "' ")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar
            If dt.Rows.Count = Nothing Then
                Return 1
            Else
                Return dt.Rows(0)(0).ToString
            End If

            Return Nothing

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_Temporal_MaquinasParaTrabajar(ByVal pCodigoPadre As String) As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()
            'DEFINIDO EN SP [sp_MaquinasCompatibles]

            qry.Append(" SELECT ")
            qry.Append(" Molde, ")
            qry.Append(" Estatus, ")
            qry.Append(" Prioridad, ")
            qry.Append(" Maquina, ")
            qry.Append(" 0  [HorasPendientes] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_MoldesMaquinas ")
            qry.Append(" WHERE Molde IN (SELECT Id  ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Moldes ")
            qry.Append(" WHERE Id = (SELECT Molde ")
            qry.Append(" FROM APGProduccion.dbo.PROD_CodigosProducidos ")
            qry.Append(" WHERE Id = '" + pCodigoPadre + "')) ")
            qry.Append(" ORDER BY Prioridad ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_Maquinas_HorasPendienteTrabajo(ByVal pMaquina As String) As String
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()
            'EXISTE sp_Maquina_HorasPendienteTrabajo

            qry.Append(" SELECT SUM(CEILING(Pendiente / ArticulosHora)) [HorasPendienteTrabajo] FROM ")
            qry.Append(" (SELECT  ")
            qry.Append(" (SELECT ")
            qry.Append(" CASE WHEN A.InyeccionHora > 0 AND D.Unidades > 0  ")
            qry.Append(" THEN CONVERT(DECIMAL(18,1),(CONVERT(DECIMAL(18,1),A.InyeccionHora))* D.Unidades)  ")
            qry.Append(" ELSE '0' END [ArticulosHora] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Produccion_Parametros A ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_CodigosProducidos C ON C.Id = A.Id ")
            qry.Append(" LEFT JOIN APGProduccion.dbo.PROD_Moldes D ON D.Id = C.Molde ")
            qry.Append(" WHERE A.Id COLLATE SQL_Latin1_General_CP1_CI_AS = CodigoArticulo) [ArticulosHora], ")
            qry.Append(" Pendiente ")
            qry.Append(" FROM ")
            qry.Append(" (Select   ")
            qry.Append(" SUBSTRING(A.ItemCode,1,8) [CodigoArticulo],   ")
            qry.Append(" SUM(CONVERT(INTEGER,CASE WHEN (A.PlannedQty - A.CmpltQty) > 0 THEN (A.PlannedQty - A.CmpltQty) ELSE '0' END)) [Pendiente]   ")
            qry.Append(" FROM SBOGuateplast.dbo.OWOR A   ")
            qry.Append(" WHERE SUBSTRING(A.ItemCode,1,8) COLLATE SQL_Latin1_General_CP850_CI_AS IN  ")
            qry.Append(" (SELECT CodigoArticulo  ")
            qry.Append(" FROM APGProduccion.dbo.PROD_ProgramacionProduccion ")
            qry.Append(" WHERE Preferencial = '" + pMaquina + "') ")
            qry.Append(" AND Status IN ('R','P')   ")
            qry.Append(" GROUP BY SUBSTRING(A.ItemCode,1,8)) QRY1  ")
            qry.Append(" ) QRY2  ")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar
            If dt.Rows.Count = Nothing Then
                Return Nothing
            End If
            Return dt.Rows(0)(0).ToString


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_InstruccionesTrabajo(ByVal pCodigoPadre As String) As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()
            'DEFINIDO EN SP [sp_MaquinasCompatibles]

            qry.Append(" SELECT ")
            qry.Append(" Id, ")
            qry.Append(" Descripcion, ")
            qry.Append(" PersonasEquipoSTD, ")
            qry.Append(" EnfriamientoUnidades, ")
            qry.Append(" Estatus ")
            qry.Append(" FROM APGProduccion.dbo.PROD_InstruccionesTrabajo_Parametros ")
            qry.Append(" WHERE Id IN ('" + pCodigoPadre + "') ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GET_DescripcionFotografia(ByVal pFotografia As String, ByVal pTipoLibreria As String) As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()
            'DEFINIDO EN SP [sp_MaquinasCompatibles]

            qry.Append(" SELECT ")
            qry.Append(" Fotografia [Id], ")
            qry.Append(" Descripcion [Descripcion], ")
            qry.Append(" TipoLibreria [TipoLibreria] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Parametros_Fotografias ")
            qry.Append(" WHERE Fotografia = '" + pFotografia + "' ")
            qry.Append(" AND TipoLibreria = '" + pTipoLibreria + "' ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_Empaques_Cantidad(ByVal pCodigoPadre As String) As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()
            'DEFINIDO EN SP [sp_MaquinasCompatibles]

            qry.Append(" SELECT COUNT(*) [NumEmpaques]  ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Empaques_Parametros ")
            qry.Append(" WHERE Id = '" + pCodigoPadre + "' ")


            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_Procedimientos_OITM(ByVal pCodigoPadre As String) As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()
            'DEFINIDO EN SP [sp_MaquinasCompatibles]

            qry.Append(" SELECT  ")
            qry.Append(" CASE WHEN U_NoDeLinea = '0' THEN 'SI' ELSE 'NO' END [DeLinea], ")
            qry.Append(" ItemCode  [CodigoArticulo], ")
            qry.Append(" ItemName [NombreArticulo], ")
            qry.Append(" FrgnName [NombreIngles], ")
            qry.Append(" ItmsGrpCod [Grupo], ")
            qry.Append(" CodeBars [CodigoBarras], ")
            qry.Append(" OnHand [Stock], ")
            qry.Append(" IsCommited [Comprometido], ")
            qry.Append(" OnOrder [Produccion] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITM ")
            qry.Append(" WHERE ItemCode = '" + pCodigoPadre + "' ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_Parametros_Fotografias(ByVal pCodigo As String, ByVal pTipoLibreria As String) As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()
            'DEFINIDO EN SP [sp_MaquinasCompatibles]

            qry.Append(" SELECT Fotografia,Descripcion,TipoLibreria,Bit_CreacionUsuario,Bit_CreacionFecha ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Parametros_Fotografias ")
            qry.Append(" WHERE TipoLibreria = '" + pTipoLibreria + "'  ")
            qry.Append(" AND Fotografia = '" + pCodigo + "' ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_Codigo_EstadoProceso(ByVal pCodigo As String) As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()
            'DEFINIDO EN SP [sp_MaquinasCompatibles]

            qry.Append(" SELECT  ")
            qry.Append(" CASE WHEN Estado = 'En Proceso' THEN '1'  ")
            qry.Append(" WHEN Estado = 'En Espera' THEN '0'  ")
            qry.Append(" ELSE '0' ")
            qry.Append(" END [Estado] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_ProgramacionProduccion ")
            qry.Append(" WHERE CodigoArticulo = '" + pCodigo + "' ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_PorcentajeInyeccionVariacion(ByVal pMaquina As String) As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()
            'DEFINIDO EN SP [sp_MaquinasCompatibles]

            qry.Append(" SELECT  ")
            qry.Append(" CASE WHEN Tipo = 'I' THEN '2.5' ")
            qry.Append(" ELSE '5' END [Porcentaje] ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Maquinas ")
            qry.Append(" WHERE Id = '" + pMaquina + "' ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_CargaProduccion_Existentes(ByVal pListadoCodigos As String) As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()
            'DEFINIDO EN SP [sp_MaquinasCompatibles]

            qry.Append(" SELECT COUNT(Cantidad) [Cantidad] FROM ")
            qry.Append(" (SELECT DISTINCT ")
            qry.Append(" Id [Cantidad] ")
            qry.Append(" FROM APGProduccion.dbo.[PROD_Produccion_Parametros] ")
            qry.Append(" WHERE Id IN (" + pListadoCodigos + ") ")
            qry.Append(" ) QRY1 ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_CargaProduccion_ExistenteCodigo(ByVal pCodigo As String) As Boolean
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()
            'DEFINIDO EN SP [sp_MaquinasCompatibles]

            qry.Append(" SELECT  ")
            qry.Append(" COUNT(Id) [Cantidad]  ")
            qry.Append(" FROM APGProduccion.dbo.[PROD_Produccion_Parametros] ")
            qry.Append(" WHERE Id = '" + pCodigo + "'")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            If dt.Rows.Count = Nothing Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_ListaMateriales_Encabezado(ByVal pCodigo As String) As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()
            'DEFINIDO EN SP [sp_MaquinasCompatibles]

            qry.Append(" SELECT ")
            qry.Append(" A.Code [Codigo], ")
            qry.Append(" B.ItemName [Nombre], ")
            qry.Append(" A.Qauntity [Cantidad], ")
            qry.Append(" A.ToWH [Almacen], ")
            qry.Append(" A.PriceList [ListaPrecios] ")
            qry.Append(" FROM SBOGuateplast.dbo.OITT A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.Code ")
            qry.Append(" WHERE Code = '" + pCodigo + "' ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GET_ListaMateriales_Detalle(ByVal pCodigo As String) As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()
            'DEFINIDO EN SP [sp_MaquinasCompatibles]

            qry.Append(" SELECT  ")
            qry.Append(" A.ChildNum [Linea], ")
            qry.Append(" A.Code [Codigo], ")
            qry.Append(" B.ItemName [Nombre], ")
            qry.Append(" A.Quantity [Cantidad], ")
            qry.Append(" B.InvntryUom [U/M], ")
            qry.Append(" A.Warehouse [Almacen], ")
            qry.Append(" A.PriceList [ListaPrecios] ")
            qry.Append(" FROM SBOGuateplast.dbo.ITT1 A ")
            qry.Append(" LEFT JOIN SBOGuateplast.dbo.OITM B ON B.ItemCode = A.Code ")
            qry.Append(" WHERE Father = '" + pCodigo + "' ")
            qry.Append(" ORDER BY ChildNum ASC ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GET_ValidarCodigo_paraActualizar(ByVal pCodigo As String, ByVal pMolde As String) As DataTable
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()
            'DEFINIDO EN SP [sp_MaquinasCompatibles]


            qry.Append(" DECLARE @Codigo as VARCHAR(10) ")
            qry.Append(" DECLARE @CodigoExisteCP as INTEGER ")
            qry.Append(" DECLARE @CodigoExisteParametros as INTEGER ")
            qry.Append(" DECLARE @Molde as INTEGER ")
            qry.Append(" DECLARE @MoldeExiste as INTEGER ")
            qry.Append(" SET @Codigo = '" + pCodigo + "'  ")
            qry.Append(" SET @Molde = '" + pMolde + "' ")

            qry.Append(" SELECT @CodigoExisteCP = COUNT(Id) FROM APGProduccion.dbo.PROD_CodigosProducidos ")
            qry.Append(" WHERE Id = @Codigo ")

            qry.Append(" SELECT @MoldeExiste = COUNT(Id) FROM APGProduccion.dbo.PROD_Moldes ")
            qry.Append(" WHERE Id = @Molde ")

            qry.Append(" SELECT @CodigoExisteParametros = COUNT(Id) FROM APGProduccion.dbo.PROD_Produccion_Parametros ")
            qry.Append(" WHERE Id = @Codigo ")

            qry.Append(" IF @CodigoExisteCP = 0  ")
            qry.Append(" SELECT 'CP No existe en DB' ")
            qry.Append(" ELSE ")
            qry.Append(" IF @MoldeExiste = 0  ")
            qry.Append(" SELECT 'Molde NO existe en DB' ")
            qry.Append(" ELSE ")
            qry.Append(" IF @CodigoExisteParametros = 0  ")
            qry.Append(" SELECT 'Insertar' ")
            qry.Append(" ELSE ")
            qry.Append(" SELECT 'Actualizar' ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function


End Module
