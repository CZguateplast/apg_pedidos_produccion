Module mMensajes



#Region "Grabar" ' -----------------------------------------------------------------------------
    Public Function msg_Grabar() As Boolean
        If MsgBox("Desea GRABAR la información?", MsgBoxStyle.YesNo, "*** Grabar ***") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function msg_GrabarMoldes(ByVal pMolde As String, ByVal pMoldeSerie As String) As Boolean
        If MsgBox("Desea Grabar el Molde Id ( " + pMolde + " ) de Serie ( " + pMoldeSerie + " )?", MsgBoxStyle.YesNo, "Grabar Información") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub msg_GrabarMoldes_Ok(ByVal pMolde As String, ByVal pMoldeSerie As String)
        Try
            MsgBox("El Molde Id ( " + pMolde + " ) de Serie ( " + pMoldeSerie + " ) se ha grabado Correctamente.", MsgBoxStyle.OkOnly, "Grabado Información")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub msg_GrabarMoldes_Error(ByVal pMolde As String, ByVal pMoldeSerie As String)
        Try
            MsgBox("El Molde Id ( " + pMolde + " ) de Serie ( " + pMoldeSerie + " ) no se ha podido actualizar. Intente de Nuevo!", MsgBoxStyle.OkOnly, "Grabado Información")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub




#End Region

#Region "CodigosProducidos"
    Public Function msg_GrabarCodigosProducidos(ByVal pId As String, ByVal pMolde As String) As Boolean
        If MsgBox("Desea Grabar el Codigo Producido Id ( " + pId + " ) con molde (" + pMolde + ") ?", MsgBoxStyle.YesNo, "Grabar Información") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub msg_GrabarCodigosProducidos_Ok(ByVal pId As String, ByVal pMolde As String)
        Try
            MsgBox("El Codigo Producido con Id ( " + pId + " ) Molde (" + pMolde + ") se ha grabado Correctamente.", MsgBoxStyle.OkOnly, "Grabado Información")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub msg_GrabarCodigosProducidos_Error(ByVal pId As String, ByVal pMolde As String)
        Try
            MsgBox("El Codigo Producido con Id ( " + pId + " ) Molde (" + pMolde + ")  no se ha podido Grabar. Intente de Nuevo!", MsgBoxStyle.OkOnly, "Grabado Información")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Function msg_ActualizarCodigosProducidos(ByVal pId As String, ByVal pMolde As String) As Boolean
        If MsgBox("Desea ACTUALIZAR el Codigo Producido Id ( " + pId + " ) Molde (" + pMolde + ")?", MsgBoxStyle.YesNo, "Actualizar Información") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub msg_ActualizarCodigosProducidos_Ok(ByVal pId As String, ByVal pMolde As String)
        Try
            MsgBox("El Codigo Producido Id ( " + pId + " ) Molde (" + pMolde + ") se ha Actualizado Correctamente.", MsgBoxStyle.OkOnly, "Actualizar Información")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub msg_ActualizarCodigosProducidos_Error(ByVal pId As String, ByVal pMolde As String)
        Try
            MsgBox("El Codigo Producido Id ( " + pId + " ) Molde (" + pMolde + ")  no se ha podido actualizar. Intente de Nuevo!", MsgBoxStyle.OkOnly, "Actualizar Información")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

#End Region

#Region "AsigMoldes_Maquinas"
    Public Function msg_ActualizarMoldesMaquinas(ByVal pMolde As String, ByVal pMaquina As String, ByVal pMaterial1 As String, ByVal pMaterial2 As String) As Boolean
        If MsgBox("Desea ACTUALIZAR la siguiente Relacion de Molde ( " + pMolde + " ) Maquina (" + pMaquina + ") Material1 (" + pMaterial1 + ") Material2 (" + pMaterial2 + ")?", MsgBoxStyle.YesNo, "Actualizar Información") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub msg_ActualizarMoldesMaquinas_Ok(ByVal pMolde As String, ByVal pMaquina As String, ByVal pMaterial1 As String, ByVal pMaterial2 As String)
        Try
            MsgBox("La Relacion de Molde ( " + pMolde + " ) Maquina (" + pMaquina + ") Material1 (" + pMaterial1 + ") Material2 (" + pMaterial2 + ") se ha Actualizado Correctamente.", MsgBoxStyle.OkOnly, "Actualizar Información")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub msg_ActualizarMoldesMaquinas_Error(ByVal pMolde As String, ByVal pMaquina As String, ByVal pMaterial1 As String, ByVal pMaterial2 As String)
        Try
            MsgBox("La Relacion de Molde ( " + pMolde + " ) Maquina (" + pMaquina + ") Material1 (" + pMaterial1 + ") Material2 (" + pMaterial2 + ")  no se ha podido actualizar. Intente de Nuevo!", MsgBoxStyle.OkOnly, "Actualizar Información")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
#End Region

#Region "PorcEficienciaMaquinas"
    Public Function msg_ActualizarPorcEficienciaMaquinas(ByVal pPorcentaje As String, ByVal pFecha As String) As Boolean
        If MsgBox("Desea ACTUALIZAR el Porcentaje ( " + pPorcentaje + " ) para la Fecha (" + pFecha + ") ?", MsgBoxStyle.YesNo, "Actualizar Información") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function msg_ActualizarPorcEficienciaMaquinas_Ok(ByVal pPorcentaje As String, ByVal pFecha As String) As Boolean
        If MsgBox("El Porcentaje ( " + pPorcentaje + " ) para la Fecha (" + pFecha + ") se ha actualizado exitosamente!", MsgBoxStyle.YesNo, "Actualizar Información") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function msg_ActualizarPorcEficienciaMaquinas_Error(ByVal pPorcentaje As String, ByVal pFecha As String) As Boolean
        If MsgBox("El Porcentaje ( " + pPorcentaje + " ) para la Fecha (" + pFecha + ") No se ha podido actualizar. Intente de Nuevo!", MsgBoxStyle.YesNo, "Actualizar Información") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Maquinas"
    Public Function msg_GrabarMaquina(ByVal pId As String) As Boolean
        If MsgBox("Desea Grabar la Maquina Id ( " + pId + " ) ?", MsgBoxStyle.YesNo, "Grabar Información") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub msg_GrabarMaquina_Ok(ByVal pId As String)
        Try
            MsgBox("La Maquina Id ( " + pId + " ) se ha grabado Correctamente.", MsgBoxStyle.OkOnly, "Grabado Información")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub msg_GrabarMaquina_Error(ByVal pId As String)
        Try
            MsgBox("La Maquina Id ( " + pId + " ) no se ha podido Grabar. Intente de Nuevo!", MsgBoxStyle.OkOnly, "Grabado Información")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Function msg_ActualizarMaquina(ByVal pId As String) As Boolean
        If MsgBox("Desea ACTUALIZAR la Maquina Id ( " + pId + " )?", MsgBoxStyle.YesNo, "Actualizar Información") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub msg_ActualizarMaquina_Ok(ByVal pId As String)
        Try
            MsgBox("La Maquina Id ( " + pId + " )  se ha Actualizado Correctamente.", MsgBoxStyle.OkOnly, "Actualizar Información")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub msg_ActualizarMaquina_Error(ByVal pId As String)
        Try
            MsgBox("La Maquina Id ( " + pId + " )  no se ha podido actualizar. Intente de Nuevo!", MsgBoxStyle.OkOnly, "Actualizar Información")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

#End Region

#Region "Actualizar"
    Public Function msg_Actualizar() As Boolean
        If MsgBox("Desea ACTUALIZAR  la información?", MsgBoxStyle.YesNo, "Actualizar Información") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function msg_ActualizarMoldes(ByVal pMolde As String, ByVal pMoldeSerie As String) As Boolean
        If MsgBox("Desea ACTUALIZAR el Molde Id ( " + pMolde + " ) de Serie ( " + pMoldeSerie + " )?", MsgBoxStyle.YesNo, "Actualizar Información") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub msg_ActualizarMoldes_Ok(ByVal pMolde As String, ByVal pMoldeSerie As String)
        Try
            MsgBox("El Molde Id ( " + pMolde + " ) de Serie ( " + pMoldeSerie + " ) se ha Actualizado Correctamente.", MsgBoxStyle.OkOnly, "Actualizar Información")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub msg_ActualizarMoldes_Error(ByVal pMolde As String, ByVal pMoldeSerie As String)
        Try
            MsgBox("El Molde Id ( " + pMolde + " ) de Serie ( " + pMoldeSerie + " ) no se ha podido actualizar. Intente de Nuevo!", MsgBoxStyle.OkOnly, "Actualizar Información")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Public Sub msg_Actualizar(ByVal pCausaActualizar As String)

        Try
            MsgBox("Actualizado con Exito!" + pCausaActualizar, MsgBoxStyle.OkOnly, "*** Actualizar ***")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub
    Public Function msg_ActualizarConDatosSinGuardar() As Boolean
        If MsgBox("Desea ACTUALIZAR  la información? Se perderan todos los cambios que no se hayan guardado", MsgBoxStyle.YesNo, " Info.") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Eliminar" ' ------------------------------------------------------------------------------
    Public Function msg_Eliminar() As Boolean
        If MsgBox("Desea ELIMINAR la información?", MsgBoxStyle.YesNo, "*** Eliminar ***") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Informacion" ' ------------------------------------------------------------------------
    Public Sub msg_Informacion(ByVal pMensaje As String)
        MsgBox(pMensaje, MsgBoxStyle.Information = MsgBoxStyle.OkOnly, "Información")
    End Sub
    Public Sub msg_InformacionIncompleta(ByVal pCampo As String)
        MsgBox("Para continuar ingrese la siguiente informacion: " + pCampo, MsgBoxStyle.Information = MsgBoxStyle.OkOnly, "Información Incompleta")
    End Sub

    Public Sub msg_NoData()
        Try
            MsgBox("No existe informacion para mostrar." + Environment.NewLine + "Intente de Nuevo o comuniquese a Informatica.", MsgBoxStyle.Information = MsgBoxStyle.OkOnly, "NO Data")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Public Function msg_InformacionIncompleta2(ByVal pCampo As String) As Boolean
        If MsgBox("Para continuar ingrese la siguiente informacion: " + pCampo + ". Desea Corregir?", MsgBoxStyle.YesNo, "Información Incompleta") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

#Region "MultipleOpcion"
    Public Function msg_ContinuarSinGuardar()
        Try
            If MsgBox("Desea continuar sin guardar los datos ingresado?", MsgBoxStyle.YesNo, "Alerta") = MsgBoxResult.Yes Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function


#End Region

#Region "Correctos"
    Public Sub msg_Proceso_ok()
        MsgBox("El proceso se ha completado!!!", MsgBoxStyle.Information, "Proceso...")
    End Sub
    Public Sub msg_Proceso_ok(ByVal pCausaOk As String)
        MsgBox("El proceso se ha completado exitosamente!!!" + pCausaOk, MsgBoxStyle.Information, "Proceso...")
    End Sub
#End Region

#Region "Error"
    Public Sub msg_Error(ByVal pMensaje As String)
        MsgBox(pMensaje, MessageBoxIcon.Error, "Error")
    End Sub
    Public Sub msg_Proceso_Error()
        MsgBox("El proceso no se ha podido completar. Intente de nuevo.", MessageBoxIcon.Error, "Proceso...")
    End Sub
    Public Sub msg_Proceso_Error(ByVal pCausaError As String)
        MsgBox("El proceso no se ha podido completar. " + pCausaError + ". Intente de nuevo.", MessageBoxIcon.Error, "Proceso...")
    End Sub
#End Region

#Region "Status"
    Public Function msg_Ordenes_StatusCerrar() As Boolean
        If MsgBox("Desea CERRAR las siguientes Ordenes? " + Environment.NewLine + vpCodigoArticulo, MsgBoxStyle.YesNo, "< Cerrar Ordenes >") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function msg_Ordenes_StatusLiberar() As Boolean
        If MsgBox("Desea LIBERAR las siguientes Ordenes? " + Environment.NewLine + vpCodigoArticulo, MsgBoxStyle.YesNo, "< Liberar Ordenes >") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Validacion"
    Public Sub msg_Validacion_CaracteresEspeciales(ByVal pCaracter As String)
        Try
            MsgBox("Upsss. En esta casilla no se permite el siguiente carácter  " + pCaracter + " .", MsgBoxStyle.OkOnly, "Carácteres Especiales")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub msg_Validacion_Numeros_NO(ByVal pCaracter As String)
        Try
            MsgBox("Upsss. En esta casilla no se permiten numeros ( " + pCaracter + " ).", MsgBoxStyle.OkOnly, "Carácteres Especiales")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub msg_Validacion_Numeros_SI()
        Try
            MsgBox("Upsss. En esta casilla solo se permiten numeros.", MsgBoxStyle.OkOnly, "Carácteres Especiales")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub



#End Region






End Module
