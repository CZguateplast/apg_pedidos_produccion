Imports System.Text

Module mFunc_TrasladoAlmacen
    Public Function GetAlmacenes() As DataTable
        Dim qry As String = "SELECT whscode, ISNULL(whsname, 'ND') as whsname FROM owhs WHERE whsname is not null"
        Dim almacenes As New DataTable()

        Try
            ' Ejecutar la consulta SQL y obtener el DataTable
            almacenes = mConexion.ConectarSQLGT_DT(qry)

            ' Verificar si almacenes es Nothing, si lo es, crear un nuevo DataTable vacío
            If almacenes Is Nothing Then
                almacenes = New DataTable() ' Esto asegura que siempre se devuelva un DataTable válido
            End If

            ' Devolver el DataTable lleno con los resultados
            Return almacenes

        Catch ex As Exception
            ' Manejo de errores, muestra el mensaje de error
            mMensajes.msg_Error(ex.Message)
            Return New DataTable() ' Devolver un DataTable vacío en caso de error
        End Try
    End Function

    Public Function GetAnalisisTrasladoBodegas(ByVal pBodegaDestino As String, ByVal pBodegasOrigen As String(), ByVal pSoloNegativos As Boolean, ByRef pResult As String) As DataTable
        Dim i As Int16
        Dim strFieldsStock As New StringBuilder
        Dim strQuery As New StringBuilder
        Dim strQueryHeaderTmp As New StringBuilder
        Dim strQueryHeader As String = ""
        Dim strQueryFooter As New StringBuilder
        Dim strQueryResta As New StringBuilder

        Try

            For i = 0 To pBodegasOrigen.Length - 1
                strFieldsStock.Append(String.Format("CAST(ROUND((SELECT OnHand FROM OITW WHERE WhsCode = '{0}' and ItemCode = T1.ItemCode) , 0) AS DECIMAL(18,0)) AS [Stock {0}], ", pBodegasOrigen(i)))

                strQueryFooter.Append(") datos" + pBodegasOrigen(i))

                strQueryHeaderTmp.Remove(0, strQueryHeaderTmp.Length)
                strQueryHeaderTmp.Append(String.Format("(select datos{0}.*, case when ", pBodegasOrigen(i)))
                strQueryResta.Remove(0, strQueryResta.Length)
                strQueryResta.Append(String.Format("(datos{0}.[A pedir]", pBodegasOrigen(i)))
                If i > 0 Then
                    For j = 0 To i - 1
                        strQueryResta.Append(String.Format(" - datos{0}.[Sacar de {1}]", pBodegasOrigen(i), pBodegasOrigen(j)))
                    Next
                End If
                strQueryResta.Append(")")
                strQueryHeaderTmp.Append(String.Format("{0} > 0 and datos{1}.[Stock {1}] >= {0} then {0} when {0} > 0 and datos{1}.[Stock {1}] > 0 and datos{1}.[Stock {1}]< {0} then datos{1}.[Stock {1}] else 0 end as [Sacar de {1}] from ", strQueryResta.ToString, pBodegasOrigen(i)))

                strQueryHeader = strQueryHeaderTmp.ToString + strQueryHeader
            Next

            strQuery.Append(strQueryHeader.Remove(0, 1))

            strQuery.Append("(SELECT	T1.[ItemCode] Producto, ")
            strQuery.Append("		T1.[ItemName] Descripcion, ")
            strQuery.Append("		CAST(ROUND(T1.OnHand, 0) AS DECIMAL(18,0)) AS [Stock General], ")
            strQuery.Append("		CAST(ROUND(T1.[IsCommited] , 0) AS DECIMAL(18,0))AS [Comprometido General], ")
            strQuery.Append("		CAST(ROUND(T1.[OnOrder] , 0) AS DECIMAL(18,0))AS [Solicitado General], ")
            strQuery.Append(String.Format("		CAST(ROUND(T0.[OnHand] , 0) AS DECIMAL(18,0)) AS [Stock {0}], ", pBodegaDestino))
            strQuery.Append(String.Format("		CAST(ROUND(T0.[IsCommited] , 0) AS DECIMAL(18,0)) AS [Comprometido {0}], ", pBodegaDestino))
            strQuery.Append(String.Format("		CAST(ROUND(T0.[OnOrder] , 0) AS DECIMAL(18,0)) AS [Solicitado {0}], ", pBodegaDestino))
            strQuery.Append("       CASE WHEN T0.[OnHand] > 0 THEN ")
            strQuery.Append("           CAST(ROUND(T0.[IsCommited] , 0) AS DECIMAL(18,0)) - CAST(ROUND(T0.[OnOrder] , 0) AS DECIMAL(18,0)) ")
            strQuery.Append("       ELSE ")
            strQuery.Append("           ABS(CAST(ROUND(T0.[OnHand] , 0) AS DECIMAL(18,0))) + CAST(ROUND(T0.[IsCommited] , 0) AS DECIMAL(18,0)) - CAST(ROUND(T0.[OnOrder] , 0) AS DECIMAL(18,0)) ")
            strQuery.Append("       END [Requerido], ")
            strQuery.Append("       CASE WHEN T0.[OnHand] > 0 THEN ")
            strQuery.Append("       	CASE WHEN T0.[OnHand] < CAST(ROUND(T0.[IsCommited] , 0) AS DECIMAL(18,0)) - CAST(ROUND(T0.[OnOrder] , 0) AS DECIMAL(18,0)) THEN ")
            strQuery.Append("       		CAST(ROUND(T0.[IsCommited] , 0) AS DECIMAL(18,0)) - CAST(ROUND(T0.[OnOrder] , 0) AS DECIMAL(18,0)) - CAST(ROUND(T0.[OnHand] , 0) AS DECIMAL(18,0)) ")
            strQuery.Append("       	ELSE ")
            strQuery.Append("               0 ")
            strQuery.Append("           END ")
            strQuery.Append("       ELSE ")
            strQuery.Append("       	ABS(CAST(ROUND(T0.[OnHand] , 0) AS DECIMAL(18,0))) + CAST(ROUND(T0.[IsCommited] , 0) AS DECIMAL(18,0)) - CAST(ROUND(T0.[OnOrder] , 0) AS DECIMAL(18,0)) ")
            strQuery.Append("       END [A Pedir], ")
            strQuery.Append(strFieldsStock.ToString)
            strQuery.Append("		0 as nada ")
            strQuery.Append("FROM OITW T0 INNER JOIN OITM T1 ON T0.ItemCode = T1.ItemCode ")
            strQuery.Append(String.Format("WHERE T0.[WhsCode] = '{0}' ", pBodegaDestino))
            If pSoloNegativos Then strQuery.Append("and T0.[OnHand]<0 ")
            strQuery.Append(strQueryFooter.ToString)

            Dim xset As DataTable = mConexion.ConectarSQLGT_DT(strQuery.ToString)
            Return xset

        Catch ex As Exception
            pResult = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function GetTransaccionesAnteriores(BodegaDestino As String, BodegaOrigen As List(Of String)) As DataTable
        ' Crear una variable para almacenar la consulta SQL
        Dim qry As String = ""

        ' Verificar si BodegaOrigen tiene un solo elemento o más
        If BodegaOrigen.Count = 1 Then
            ' Primera consulta si hay un solo origen
            qry = "SELECT * FROM master.dbo.bit_tranferencias_stock WHERE WhsCodeTarget = '" & BodegaDestino & "' AND WhsCodeSource1 = '" & BodegaOrigen(0) & "' AND TransferDate > CONCAT(YEAR(GETDATE()), '-01-01 00:00:00.00') ORDER BY TransferDate DESC;"
        Else
            ' Segunda consulta si hay más de un origen
            Dim origenes As String = String.Join("','", BodegaOrigen)
            qry = "SELECT * FROM master.dbo.bit_tranferencias_stock WHERE WhsCodeTarget = '" & BodegaDestino & "' AND WhsCodeSource1 IN ('" & origenes & "') AND TransferDate > CONCAT(YEAR(GETDATE()), '-01-01 00:00:00.00') ORDER BY TransferDate DESC;"
        End If

        ' Ejecutar la consulta SQL usando la función ConectarSQLGT_DT y devolver el resultado
        Dim dtTransacciones As DataTable = Nothing
        Try
            dtTransacciones = ConectarSQLGT_DT(qry)
        Catch ex As Exception
            ' Manejar cualquier excepción y mostrar el mensaje de error
            mMensajes.msg_Error("Error en GetTransaccionesAnteriores: " & ex.Message)
        End Try

        ' Devolver el DataTable con los resultados
        Return dtTransacciones
    End Function

    Public Function Traslado()
        Return True
    End Function

End Module
