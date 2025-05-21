Imports System.Text
Module mSQLDelete
    Public Function DELETE_Plantilla(ByVal pNombrePlantilla As String) As Boolean
        Dim qry As String = String.Empty
        Dim pDate As Date = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
        'Dim dt As New DataTable("dtCampanaEncabezado")

        Try
            qry = " DELETE FROM APGProduccion.dbo.PROD_CatPlantillas"
            qry += " WHERE Nombre = '" + pNombrePlantilla + "'"

            mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function SET_ValidarDisponibilidad_Eliminar(ByVal pPrograma As String, ByVal pVentana As String) As Boolean
        Dim dt As New DataTable("dtBodegasMoldes")
        Try
            Dim qry As New StringBuilder

            qry.Append(" DELETE FROM APGProduccion.dbo.PROD_Estatus_Articulos ")
            qry.Append(" WHERE Programa = '" + pPrograma + "' ")
            qry.Append(" AND Ventana = '" + pVentana + "' ")
            qry.Append(" AND Bit_Usuario = '" + My.Settings.log_Usuario.ToString + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function SET_ValidarDisponibilidad_Eliminar(ByVal pPrograma As String) As Boolean
        Dim dt As New DataTable("dtBodegasMoldes")
        Try
            Dim qry As New StringBuilder

            qry.Append(" DELETE FROM APGProduccion.dbo.PROD_Estatus_Articulos ")
            qry.Append(" WHERE Programa = '" + pPrograma + "' ")
            qry.Append(" AND Bit_Usuario = '" + My.Settings.log_Usuario.ToString + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function SET_ValidarDisponibilidad_Eliminar(ByVal pPrograma As String, ByVal pVentana As String, ByVal pCodigoArticulo As String) As Boolean
        Dim dt As New DataTable("dtBodegasMoldes")
        Try
            Dim qry As New StringBuilder

            dt = mSQLSelect.GET_Validacion_Disponibilidad_CP(pCodigoArticulo)

            If Not dt.Rows.Count = Nothing Then

                For i = 0 To dt.Rows.Count - 1
                    qry.Append(" DELETE FROM APGProduccion.dbo.PROD_Estatus_Articulos ")
                    qry.Append(" WHERE Programa = '" + pPrograma + "' ")
                    qry.Append(" AND Ventana = '" + pVentana + "' ")
                    qry.Append(" AND CodigoArticulo = '" + dt.Rows(i)("CodigoArticulo").ToString + "' ")
                    qry.Append(" AND Bit_Usuario = '" + My.Settings.log_Usuario.ToString + "' ")
                Next

                mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            End If

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function


    Public Function DELETE_Moldes_Maquinas(ByVal pMolde As String, ByVal pMaquina As String) As Boolean
        Try
            Dim qry As New StringBuilder

            qry.Append(" DELETE FROM APGProduccion.dbo.PROD_MoldesMaquinas ")
            qry.Append(" WHERE Molde = '" + pMolde + "' ")
            qry.Append(" AND Maquina = '" + pMaquina + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function DELETE_Componente_Maquinas(ByVal pComponente As String, ByVal pMaquina As String) As Boolean
        Try
            Dim qry As New StringBuilder

            qry.Append(" DELETE FROM APGProduccion.dbo.PROD_ComponentesMaquinas ")
            qry.Append(" WHERE Componente = '" + pComponente + "' ")
            qry.Append(" AND Maquina = '" + pMaquina + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function DELETE_PROD_Ordenes_Detalle_Temporal() As Boolean
        Try
            Dim qry As New StringBuilder

            qry.Append(" DELETE ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle_Temporal ")
            qry.Append(" WHERE Bit_UsuarioCreacion = '" + My.Settings.log_Usuario.ToString + "' ")


            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function
    Public Function DELETE_PROD_Ordenes_Detalle_Temporal(ByVal pId As String) As Boolean
        Try
            Dim qry As New StringBuilder

            qry.Append(" DELETE ")
            qry.Append(" FROM APGProduccion.dbo.PROD_Ordenes_Detalle_Temporal ")
            qry.Append(" WHERE Bit_UsuarioCreacion = '" + My.Settings.log_Usuario.ToString + "' ")
            qry.Append(" AND Id_Nivel1 = '" + pId + "' ")


            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function


    Public Function DELETE_PlanificacionProduccion_Programada(ByVal pCodigoArticulo As String) As Boolean
        Try
            Dim qry As New StringBuilder

            qry.Append(" DELETE FROM APGProduccion.dbo.PROD_ProgramacionProduccion ")
            qry.Append(" WHERE CodigoArticulo = '" + pCodigoArticulo + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function



End Module
