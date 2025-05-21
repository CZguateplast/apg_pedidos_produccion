Imports System.Text
Module mSQLUpdate
    Public Function UPDATE_Plantilla(ByVal pArrayList As ArrayList) As Boolean
        Dim qry As String = String.Empty
        Dim pDate As Date = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
        'Dim dt As New DataTable("dtCampanaEncabezado")

        Try
            qry = " UPDATE APGProduccion.dbo.PROD_CatPlantillas"
            qry += " SET "
            qry += " DeLinea = '" + pArrayList(1).ToString + "',"
            qry += " CodigoArticuloPadre = '" + pArrayList(2).ToString + "',"
            qry += " NumeroCampana = '" + pArrayList(3).ToString + "',"
            qry += " StockMayorA = '" + pArrayList(4).ToString + "',"
            qry += " StockMenorA = '" + pArrayList(5).ToString + "',"
            qry += " DeudaRolMayorA = '" + pArrayList(6).ToString + "',"
            qry += " DeudaCampanaMayorA = '" + pArrayList(7).ToString + "',"
            qry += " DeudaProyeccionMayorA = '" + pArrayList(8).ToString + "',"
            qry += " Color = '" + pArrayList(9).ToString + "',"
            qry += " CodigoArticuloInicial = '" + pArrayList(10).ToString + "',"
            qry += " CodigoArticuloFinal = '" + pArrayList(11).ToString + "',"
            qry += " CodigoCliente = '" + pArrayList(12).ToString + "',"
            qry += " StockMenorMinimo = '" + pArrayList(13).ToString + "'"
            qry += " WHERE Nombre = '" + pArrayList(0).ToString + "'"

            mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

#Region "DI API"
    Public Function UPDATE_ENSAMBLE_NoSap_Y_Status(ByVal pNumSAP As String, ByVal pId As String, ByVal pIdNivel1 As String) As Boolean

        Try
            Dim qry As New StringBuilder
            qry.Append(" UPDATE APGProduccion.dbo.PROD_Ordenes_Detalle")
            qry.Append(" SET NumeroSAP = '" + pNumSAP + "',")
            qry.Append(" SAP = '1'")
            qry.Append(" WHERE Id = '" + pId + "'")
            qry.Append(" AND Id_Nivel1 = '" + pIdNivel1 + "' ")
            qry.Append(" AND (Tipo = 'EE' OR Tipo = 'ED')")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function UPDATE_PRODUCCION_NoSap_Y_Status(ByVal pNumSAP As String, ByVal pId As String, ByVal pIdNivel1 As String, ByVal pIdNivel2 As String) As Boolean

        Try
            Dim qry As New StringBuilder
            qry.Append(" UPDATE APGProduccion.dbo.PROD_Ordenes_Detalle")
            qry.Append(" SET NumeroSAP = '" + pNumSAP + "',")
            qry.Append(" SAP = '1'")
            qry.Append(" WHERE Id = '" + pId + "'")
            qry.Append(" AND Id_Nivel1 = '" + pIdNivel1 + "' ")
            qry.Append(" AND Id_Nivel2 = '" + pIdNivel2 + "'")
            qry.Append(" AND Tipo = 'PE'")


            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    'Public Function UPDATE_CodigosProducidos(ByVal ByVal pDescripcion As String, ByVal pMaterial1 As String, ByVal pMaterial2 As String, ByVal pMolde As String _
    '                                         , ByVal pEstatus As String) As Boolean

    '    Try
    '        Dim qry As New StringBuilder
    '        qry.Append(" UPDATE APGProduccion.dbo.PROD_CodigosProducidos ")
    '        qry.Append(" SET  ")
    '        qry.Append(" Descripcion = '" + pDescripcion + "', ")
    '        qry.Append(" Material1 = '" + pMaterial1 + "', ")
    '        qry.Append(" Material2 = '" + pMaterial2 + "', ")
    '        qry.Append(" Molde = '" + pMolde + "', ")
    '        qry.Append(" Estatus = '" + pEstatus + "', ")
    '        qry.Append(" Bit_ModificacionUsuario = '" + My.Settings.log_Usuario.ToString + "', ")
    '        qry.Append(" Bit_ModificacionFecha = CONVERT(DATE,GetDate(),111) ")
    '        qry.Append(" WHERE Id = 'CP005356' ")


    '        mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

    '        Return True

    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message)
    '        Return False
    '    End Try
    'End Function

#End Region


#Region "MOLDES"
    Public Function UPDATE_Moldes(ByVal pId As String, ByVal pMoldeSerie As String, ByVal pNombre As String, ByVal pCavidades As String, ByVal pUnidades As String, ByVal pMaquinaPreferencial As String, ByVal pUbicacion As String, ByVal pPorcIneficiencia As String,
                                  ByVal pComentario As String, ByVal pStatus As String) As Boolean

        Try
            Dim qry As New StringBuilder
            qry.Append(" UPDATE APGProduccion.dbo.PROD_Moldes ")
            qry.Append(" SET Nombre = '" + pNombre + "', ")
            qry.Append(" Cavidades = '" + pCavidades + "', ")
            qry.Append(" Unidades = '" + pUnidades + "', ")
            qry.Append(" MaquinaPreferencial = '" + pMaquinaPreferencial + "', ")
            qry.Append(" Ubicacion = '" + pUbicacion + "', ")
            qry.Append(" PorcIneficiencia = '" + pPorcIneficiencia + "', ")
            qry.Append(" Comentarios = '" + pComentario + "', ")
            qry.Append(" Estatus = '" + pStatus + "', ")
            qry.Append(" Bit_ModificacionUsuario = '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" Bit_ModificacionFecha = GETDATE() ")
            qry.Append(" WHERE Id = '" + pId + "' ")
            qry.Append(" AND MoldeSerie = '" + pMoldeSerie + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function UPDATE_Moldes(ByVal pPorcIneficiencia As String) As Boolean

        Try
            Dim qry As New StringBuilder
            qry.Append(" UPDATE APGProduccion.dbo.PROD_Moldes ")
            qry.Append(" SET PorcIneficiencia = '" + pPorcIneficiencia + "' ")
            
            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

#End Region

#Region "Maquinas"
    Public Function UPDATE_Maquinas(ByVal pSeleccion As DataTable) As Boolean

        Try
            Dim qry As New StringBuilder
            qry.Append(" UPDATE APGProduccion.dbo.PROD_Maquinas ")
            qry.Append(" SET Nombre= '" + pSeleccion.Rows(0)("Nombre").ToString + "',  ")
            qry.Append(" Modelo= '" + pSeleccion.Rows(0)("Modelo").ToString + "',  ")
            qry.Append(" Serie= '" + pSeleccion.Rows(0)("Serie").ToString + "', ")
            qry.Append(" Grupo= '" + pSeleccion.Rows(0)("Grupo").ToString + "', ")
            qry.Append(" Ubicacion = '" + pSeleccion.Rows(0)("Ubicacion").ToString + "', ")
            qry.Append(" Toneladas = '" + pSeleccion.Rows(0)("Toneladas").ToString + "', ")
            qry.Append(" LibrasHoras = '" + pSeleccion.Rows(0)("LibrasHoras").ToString + "',  ")
            qry.Append(" Tipo = '" + pSeleccion.Rows(0)("Tipo").ToString + "', ")
            qry.Append(" InyeccionOz = '" + pSeleccion.Rows(0)("InyeccionOz").ToString + "', ")
            qry.Append(" InyeccionGr = '" + pSeleccion.Rows(0)("InyeccionGr").ToString + "', ")
            qry.Append(" PrensaCierreMAX = '" + pSeleccion.Rows(0)("PrensaCierreMAX").ToString + "', ")
            qry.Append(" PrensaCierreMIN = '" + pSeleccion.Rows(0)("PrensaCierreMIN").ToString + "', ")
            qry.Append(" PrensaCierreCARRERA = '" + pSeleccion.Rows(0)("PrensaCierreCARRERA").ToString + "', ")
            qry.Append(" CarreraExpulsionMM = '" + pSeleccion.Rows(0)("CarreraExpulsionMM").ToString + "', ")
            qry.Append(" BarrasDistanciaHOR = '" + pSeleccion.Rows(0)("BarrasDistanciaHOR").ToString + "', ")
            qry.Append(" BarrasDistanciaVER = '" + pSeleccion.Rows(0)("BarrasDistanciaVER").ToString + "', ")
            qry.Append(" PlatinasDimencionesHOR = '" + pSeleccion.Rows(0)("PlatinasDimencionesHOR").ToString + "', ")
            qry.Append(" PlatinasDimencionesVER = '" + pSeleccion.Rows(0)("PlatinasDimencionesVER").ToString + "', ")
            qry.Append(" AnilloCentrador = '" + pSeleccion.Rows(0)("AnilloCentrador").ToString + "', ")
            qry.Append(" CambioMolde_Hora = '" + pSeleccion.Rows(0)("CambioMolde_Hora").ToString + "', ")
            qry.Append(" Estatus = '" + pSeleccion.Rows(0)("Estatus").ToString + "',  ")
            qry.Append(" Bit_ModificacionUsuario = '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" Bit_ModificacionFecha = GETDATE() ")
            qry.Append(" where Id = '" + pSeleccion.Rows(0)("Id").ToString + "' ")


            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function UPDATE_CodigosProducidos(ByVal pId As String, ByVal pDescripcion As String, ByVal pMaterial1 As String, ByVal pMaterial1Porc As String, ByVal pMaterial2 As String, _
                            ByVal pMaterial2Porc As String, ByVal pMaterial3 As String, ByVal pMolde As String, ByVal pEstatus As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" UPDATE APGProduccion.dbo.PROD_CodigosProducidos ")
            qry.Append(" SET  ")
            qry.Append(" Descripcion = '" + pDescripcion + "', ")
            qry.Append(" Material1 = '" + pMaterial1 + "', ")
            qry.Append(" Material1Porc = '" + pMaterial1Porc + "', ")
            qry.Append(" Material2 = '" + pMaterial2 + "', ")
            qry.Append(" Material2Porc = '" + pMaterial2Porc + "', ")
            qry.Append(" Material3 = '" + pMaterial3 + "', ")
            qry.Append(" Molde = '" + pMolde + "', ")
            qry.Append(" Estatus = '" + pEstatus + "', ")
            qry.Append(" Bit_ModificacionUsuario = '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" Bit_ModificacionFecha = GETDATE() ")
            qry.Append(" WHERE Id = '" + pId + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

#End Region

#Region "AsigMoldes_Maquinas"
    Public Function UPDATE_AsigMoldes_Maquinas(ByVal pMolde As String, ByVal pMaquina As String, ByVal pMaterial1 As String, ByVal pMaterial2 As String, _
                           ByVal pUnidadesXHora As String, ByVal pInyeccionesXHora As String, ByVal pCostoHoraNormal As String, ByVal pCostoHoraIncremento As String, _
                           ByVal pEstatus As String) As Boolean

        If pUnidadesXHora = String.Empty Then : pUnidadesXHora = "0" : End If
        If pInyeccionesXHora = String.Empty Then : pInyeccionesXHora = "0" : End If
        If pCostoHoraNormal = String.Empty Then : pCostoHoraNormal = "0" : End If
        If pCostoHoraIncremento = String.Empty Then : pCostoHoraIncremento = "0" : End If

        Try
            Dim qry As New StringBuilder

            qry.Append(" UPDATE APGProduccion.dbo.PROD_MoldesMaquinas ")

            qry.Append(" SET  ")
            qry.Append(" UnidadesXHora = '" + pUnidadesXHora + "', ")
            qry.Append(" InyeccionesXHora = '" + pInyeccionesXHora + "', ")
            qry.Append(" CostoHoraNormal = '" + pCostoHoraNormal + "', ")
            qry.Append(" CostoHoraIncremento = '" + pCostoHoraIncremento + "', ")
            qry.Append(" Estatus = '" + pEstatus + "', ")
            qry.Append(" Bit_ModificacionUsuario = '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" Bit_ModificacionFecha = GETDATE() ")

            qry.Append(" WHERE Molde = '" + pMolde + "' ")
            qry.Append(" AND Maquina = '" + pMaquina + "' ")
            qry.Append(" AND Material1 = '" + pMaterial1 + "' ")
            qry.Append(" AND Material2 = '" + pMaterial2 + "' ")
            
            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

#End Region

    Public Function UPDATE_PorcEficienciaMaquinas(ByVal pPorcentaje As String, ByVal pFecha As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" UPDATE APGProduccion.dbo.PROD_PorcEficienciaMaquinas ")
            qry.Append(" SET Porcentaje = '" + pPorcentaje + "', ")
            qry.Append(" Bit_ModificacionUsuario = '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" Bit_ModificacionFecha = GETDATE() ")
            qry.Append(" WHERE Fecha = '" + pFecha + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            SET_PorcEficienciaMaquinas_LOG(pFecha, pPorcentaje) 'Historial de la Tabla
            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function


    Public Function UPDATE_ParametrosEnsamble(ByVal pCodigoArticulo As String, ByVal pSegundosXArticulo As String, ByVal pMinutosXArticulo As String, _
                                              ByVal pEnsamblesXHora As String, ByVal pEquipoPersonas As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" UPDATE APGProduccion.dbo.PROD_Ensamble_Parametros ")
            qry.Append(" SET SegundosXArticulo = '" + pSegundosXArticulo + "', ")
            qry.Append(" MinutosXArticulo = '" + pMinutosXArticulo + "', ")
            qry.Append(" EnsamblesXHora = '" + pEnsamblesXHora + "', ")
            qry.Append(" EquipoPersonas = '" + pEquipoPersonas + "', ")
            qry.Append(" Bit_ModificacionUsuario = '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" Bit_ModificacionFecha = GETDATE() ")
            qry.Append(" WHERE CodigoArticulo = '" + pCodigoArticulo + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function
    Public Function UPDATE_ProduccionParametros(ByVal pCodigoArticulo As String, ByVal pInyeccionGrms As String, ByVal pInyeccionVariacion As String, _
                                                  ByVal pInyeccionHora As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" UPDATE APGProduccion.dbo.PROD_Produccion_Parametros ")
            qry.Append(" SET InyeccionGrms = " + pInyeccionGrms + ", ")
            qry.Append(" InyeccionVariacion = " + pInyeccionVariacion + ", ")
            qry.Append(" InyeccionHora = " + pInyeccionHora + ", ")
            qry.Append(" Bit_ModificacionUsuario = '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" Bit_ModificacionFecha = GETDATE() ")
            qry.Append(" WHERE Id = '" + pCodigoArticulo + "' ")



            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function UPDATE_MoldeMaquinas_Prioridad(ByVal pMolde As String, ByVal pMaquina As String, ByVal pPrioridad As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" UPDATE APGProduccion.dbo.PROD_MoldesMaquinas ")
            qry.Append(" SET Prioridad = '" + pPrioridad + "' ")
            qry.Append(" WHERE Maquina = '" + pMaquina + "' ")
            qry.Append(" AND Molde = '" + pMolde + "' ")


            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function
    Public Function UPDATE_ComponenteMaquinas_Prioridad(ByVal pComponente As String, ByVal pMaquina As String, ByVal pPrioridad As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" UPDATE APGProduccion.dbo.PROD_ComponentesMaquinas ")
            qry.Append(" SET Prioridad = '" + pPrioridad + "' ")
            qry.Append(" WHERE Maquina = '" + pMaquina + "' ")
            qry.Append(" AND Componente = '" + pComponente + "' ")


            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function UPDATE_Molde_MaquinaPreferencial(ByVal pMolde As String, ByVal pMaquinaPreferencial As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" UPDATE APGProduccion.dbo.PROD_Moldes ")
            qry.Append(" SET MaquinaPreferencial = '" + pMaquinaPreferencial + "', ")
            qry.Append(" Bit_ModificacionUsuario = '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" Bit_ModificacionFecha = GETDATE() ")
            qry.Append(" WHERE Id = '" + pMolde + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function UPDATE_ProgramacionProduccion(ByVal pCodigoArticulo As String, ByVal pPreferencial As String, ByVal pEstado As String, ByVal pPrioridad As String, _
                                                  ByVal pPrioridadMaquina As String, ByVal pComentarios As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" UPDATE APGProduccion.dbo.PROD_ProgramacionProduccion ")
            qry.Append(" SET Preferencial = '" + pPreferencial + "', ")
            qry.Append(" Estado = '" + pEstado + "', ")
            qry.Append(" Prioridad = '" + pPrioridad + "', ")
            qry.Append(" PrioridadMaquina = '" + pPrioridadMaquina + "', ")
            qry.Append(" Comentarios = '" + pComentarios + "' ")
            qry.Append(" WHERE CodigoArticulo = '" + pCodigoArticulo + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function UPDATE_ProgramacionProduccion(ByVal pCodigoArticulo As String, ByVal pPreferencial As String, ByVal pPrioridadMaquina As String) As Boolean


        Try
            Dim qry As New StringBuilder

            qry.Append(" UPDATE APGProduccion.dbo.PROD_ProgramacionProduccion ")
            qry.Append(" SET Preferencial = '" + pPreferencial + "', ")
            qry.Append(" PrioridadMaquina = '" + pPrioridadMaquina + "' ")
            qry.Append(" WHERE CodigoArticulo = '" + pCodigoArticulo + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function UPDATE_ProgramacionProduccion_Prioridad(ByVal pCodigoArticulo As String, ByVal pPrioridadMaquina As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" UPDATE APGProduccion.dbo.PROD_ProgramacionProduccion ")
            qry.Append(" SET PrioridadMaquina = '" + pPrioridadMaquina + "' ")
            qry.Append(" WHERE CodigoArticulo = '" + pCodigoArticulo + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function UPDATE_ComponentesMaquinasAsignadas_Prioridad(ByVal pComponente As String, ByVal pMaquina As String, ByVal pPrioridad As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" UPDATE APGProduccion.dbo.PROD_ComponentesMaquinas ")
            qry.Append(" SET Prioridad = '" + pPrioridad + "' ")
            qry.Append(" WHERE Componente = '" + pComponente + "' ")
            qry.Append(" AND Maquina = '" + pMaquina + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function


    Public Function UPDATE_Revalorizacion_EnergiaElectrica(ByVal pCodigo As String, ByVal Porcentaje As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" UPDATE SBOGuateplast.dbo.OITM ")
            qry.Append(" SET U_Molde_Cav = '" + Porcentaje + "' ")
            qry.Append(" WHERE ItemCode = '" + pCodigo + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function UPDATE_AdvertenciasTrabajos(ByVal pId As String, ByVal pNumLinea As String, ByVal pDescripcion As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" UPDATE APGProduccion.dbo.PROD_Advertencias_Parametros ")
            qry.Append(" SET Descripcion = '" + pDescripcion + "', ")
            qry.Append(" Bit_ModificacionUsuario = '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" Bit_ModificacionFecha = GETDATE() ")
            qry.Append(" WHERE Id = '" + pId + "' AND NumLinea = '" + pNumLinea + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function UPDATE_AdvertenciasTrabajos_Enumerar(ByVal pId As String, ByVal pNumLineaAntigua As String, ByVal pNumLineaNueva As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" UPDATE APGProduccion.dbo.PROD_Advertencias_Parametros ")
            qry.Append(" SET NumLinea = '" + pNumLineaNueva + "', ")
            qry.Append(" Bit_ModificacionUsuario = '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" Bit_ModificacionFecha = GETDATE() ")
            qry.Append(" WHERE Id = '" + pId + "' AND NumLinea = '" + pNumLineaAntigua + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function


#Region "CargaProduccion"
    Public Function UPDATE_CargaProduccion_Todo(ByVal pId As String, ByVal pInyeccionGramos As String, ByVal pInyeccionVaracion As String, ByVal pInyeccionHora As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" UPDATE APGProduccion.dbo.[PROD_Produccion_Parametros] ")
            qry.Append(" SET InyeccionGrms = '" + pInyeccionGramos + "',  ")
            qry.Append(" InyeccionVariacion = '" + pInyeccionVaracion + "', ")
            qry.Append(" InyeccionHora = '" + pInyeccionHora + "' ")
            qry.Append(" WHERE Id = '" + pId + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar
            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function
    Public Function UPDATE_CargaProduccion_InyeccionGramos(ByVal pId As String, ByVal pInyeccionGramos As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" UPDATE APGProduccion.dbo.[PROD_Produccion_Parametros] ")
            qry.Append(" SET InyeccionGrms = '" + pInyeccionGramos + "'  ")
            qry.Append(" WHERE Id = '" + pId + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar
            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function UPDATE_CargaProduccion_InyeccionVariacion(ByVal pId As String, ByVal pInyeccionVaracion As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" UPDATE APGProduccion.dbo.[PROD_Produccion_Parametros] ")
            qry.Append(" SET InyeccionVariacion = '" + pInyeccionVaracion + "' ")
            qry.Append(" WHERE Id = '" + pId + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar
            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function UPDATE_CargaProduccion_InyeccionHora(ByVal pId As String, ByVal pInyeccionHora As String) As Boolean
        Try
            Dim qry As New StringBuilder

            qry.Append(" UPDATE APGProduccion.dbo.[PROD_Produccion_Parametros] ")
            qry.Append(" SET  InyeccionHora = '" + pInyeccionHora + "' ")
            qry.Append(" WHERE Id = '" + pId + "' ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar
            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function
#End Region

End Module
