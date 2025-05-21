Imports System.Data
Imports System.Text

Module mStoreProcedure
    'Obtener los Parametros de Produccion por Codigo de Articulo
    Public Function GetMoldesProduccionParametros(ByVal CodigoArticulo As String) As DataTable
        Try
            Dim qry As New StringBuilder

            qry.Append("USE [APGProduccion] ")
            qry.Append("EXEC SP_GET_MoldesProduccionParametros '" + CodigoArticulo + "';")
            'qry.Append("CodigoArticulo = '" + CodigoArticulo + "'; ")

            Return mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Prioridad_Mas_Alta_PROD_ComponentesMaquinas(ByVal CodigoArticulo As String) As Integer
        Try
            Dim qry As New StringBuilder

            qry.Append("USE [APGProduccion] ")
            qry.Append("EXEC Prioridad_Mas_Alta_PROD_ComponentesMaquinas'" + CodigoArticulo + "';")

            Dim result As Integer = mConexion.ConectarSQLGT_DT(qry.ToString).Rows(0)(0)

            Return result

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function

End Module
