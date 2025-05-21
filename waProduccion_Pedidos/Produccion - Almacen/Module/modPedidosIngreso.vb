Module modPedidosIngreso
    Public Function SQL_SELECT_PedidosAnalisis() As DataTable
        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtArticulosRelacionados")

        Try
            qry = "  SELECT "
            qry += " CASE WHEN U_NoDeLinea = 1 THEN 'NO' ELSE 'SI' END [DeLinea],"
            qry += " ItemCode,"
            qry += " ItemName,"
            qry += " CONVERT(DECIMAL(18,0),OnHand) [Stock],"

            qry += " /*Ensamble de Produccion*/"
            qry += " (	"
            qry += " SELECT"
            qry += " CONVERT(DECIMAL(18,0),ISNULL((SUM(PlannedQty) - SUM(CmpltQty)),0)) [Pendiente]"
            qry += " FROM SBOGuateplast.dbo.OWOR AA"
            qry += " WHERE ItemCode = A.ItemCode"
            qry += " and Status in ('R','P')"

            qry += " ) [Ensamble] ,"

            qry += " /*Facturas pendientes de despachar NO CAMPAÑA*/"
            qry += " ("
            qry += " select CONVERT(DECIMAL(18,0),ISNULL(SUM(BB.Quantity),0)) [Comprometido] "
            qry += " from SboGuateplast.dbo.ORDR AA"
            qry += " left Join sboguateplast.dbo.RDR1 BB on BB.DocEntry = AA.DocEntry and BB.ItemCode = A.ItemCode"
            qry += " WHERE AA.CANCELED = 'N'"
            qry += " AND AA.DocStatus = 'O'"
            qry += " AND AA.InvntSttus = 'O'"
            qry += " AND BB.LineStatus = 'O'"
            qry += " AND AA.U_NameCamp IS NULL"

            qry += " ) [Comprometido],"

            qry += " /*Facturas pendientes de despachar SI CAMPAÑA*/"

            qry += " ("
            qry += " SELECT CONVERT(DECIMAL(18,0),ISNULL(SUM(BB.Quantity),0)) [Comprometido] "
            qry += " from SboGuateplast.dbo.ORDR AA"
            qry += " left Join sboguateplast.dbo.RDR1 BB on BB.DocEntry = AA.DocEntry and BB.ItemCode = A.ItemCode"
            qry += " WHERE AA.CANCELED = 'N'"
            qry += " AND AA.DocStatus = 'O'"
            qry += " AND AA.InvntSttus = 'O'"
            qry += " AND BB.LineStatus = 'O'"
            qry += " AND AA.U_NameCamp IS NOT NULL"

            qry += " ) [ComprometidoCampaña],"

            qry += " /*CALCULO DE PENDIENTES SEGUN PROYECCIONES EN CAMPANA*/"
            qry += " ISNULL(("
            qry += " 				SELECT "
            qry += " 				/*B.ItemCode [CodigoArticulo],*/"
            qry += " 				/*CONVERT(DECIMAL(18,0),SUM(B.Proyeccion)) [Proyeccion],*/"
            qry += " 				/*CONVERT(DECIMAL(18,0),ISNULL(C.Quantity,0)) [Facturado],*/"
            qry += " 				(SUM(BB.Proyeccion) - isnull(CC.Quantity,0)) [Pendiente]"
            qry += " 				FROM Ventas.dbo.Campana AA"
            qry += " 				LEFT JOIN Ventas.dbo.ProyeccionCampana BB ON BB.CampanaId = AA.CampanaId"
            qry += " 				LEFT JOIN ("
            qry += " 							SELECT "
            qry += " 							BBB.ItemCode,"
            qry += " 							Sum(BBB.Quantity) [Quantity]"
            qry += "             FROM"
            qry += "             SBOGuateplast.dbo.OINV AAA"
            qry += " 							LEFT JOIN SBOGuateplast.dbo.INV1 BBB ON BBB.DocEntry = AAA.DocEntry"
            qry += "             WHERE U_NameCamp"
            qry += " 							IN	("
            qry += " 								SELECT AAAA.CampanaId [CampanaId]"
            qry += " 								FROM Ventas.dbo.Campana AAAA"
            qry += "             WHERE AAAA.FechaFin >= GETDATE() And AAAA.Estado = 1"
            qry += " 								)"
            qry += " 							AND AAA.DocStatus = 'O'"
            qry += " 							AND BBB.InvntSttus = 'O'"
            qry += " 							AND AAA.CANCELED = 'N'"
            qry += " 							GROUP BY BBB.ItemCode) CC ON CC.ItemCode collate SQL_Latin1_General_CP850_CI_AS  = BB.ItemCode "
            qry += " 					WHERE AA.FechaFin >= GETDATE() AND AA.Estado = 1 AND BB.ItemCode collate SQL_Latin1_General_CP850_CI_AS = A.ItemCode"
            qry += " 				GROUP BY BB.ItemCode,CC.Quantity"
            qry += " ),0) [PendienteProyeccion],"
            qry += " CONVERT(DECIMAL(18,0),ISNULL(A.MinLevel,0)) [StockMinimo],"
            qry += " CONVERT(DECIMAL(18,0),ISNULL(A.MaxLevel,0)) [StockMaximo]"

            qry += " FROM SBOGuateplast.dbo.OITM A"
            qry += " WHERE ItemCode LIKE 'AR%'"
            qry += " AND LEN(ItemCode) > 8"

            Application.DoEvents()
            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar
            Application.DoEvents()
            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
End Module
