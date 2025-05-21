Imports System.Text
Module mSQLInsert

    Public Function fg_Historial(ByVal pProcedimiento As String, ByVal pDescripcion As String) As Boolean
        Dim dt As New DataTable("dtBodegasMoldes")
        Try
            Dim qry As New StringBuilder

            qry.Append(" INSERT INTO APGS.dbo.SEG_Aplicaciones_Historial ")
            qry.Append(" (Aplicacion,Procedimiento,Descripcion,UsuarioAPG,UsuarioDominio,IP,Bit_Fecha) ")
            qry.Append(" VALUES  ")
            qry.Append(" ('" + My.Application.Info.Title.ToString + "','" + pProcedimiento + "','" + pDescripcion + "', ")
            qry.Append(" '" + My.Settings.log_Usuario.ToString + "','" + Environment.UserName.ToString + "','" + mSQLSelect.GetIPv4Address() + "',GETDATE()) ")

            ConectarSQLGT_DT(qry.ToString) 'Ejecutar
            Return True

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return False
        End Try
    End Function




    Public Function INSERT_Plantilla(ByVal pArrayList As ArrayList) As Boolean
        Dim qry As String = String.Empty
        Dim pDate As Date = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
        'Dim dt As New DataTable("dtCampanaEncabezado")

        Try
            qry = " INSERT INTO APGProduccion.dbo.PROD_CatPlantillas"
            qry += " (Nombre,"
            qry += " TipoLista,"
            qry += " DeLinea,"
            qry += " CodigoArticuloPadre,"
            qry += " NumeroCampana,"
            qry += " StockMayorA,"
            qry += " StockMenorA,"
            qry += " DeudaRolMayorA,"
            qry += " DeudaCampanaMayorA,"
            qry += " DeudaProyeccionMayorA,"
            qry += " Color,"
            qry += " CodigoArticuloInicial,"
            qry += " CodigoArticuloFinal,"
            qry += " CodigoCliente,"
            qry += " StockMenorMinimo)"
            qry += " VALUES("
            qry += " '" + pArrayList(0).ToString + "',"
            qry += " 'Plantillas',"
            qry += " '" + pArrayList(1) + "',"
            qry += " '" + pArrayList(2) + "',"
            qry += " '" + pArrayList(3) + "',"
            qry += " '" + pArrayList(4) + "',"
            qry += " '" + pArrayList(5) + "',"
            qry += " '" + pArrayList(6) + "',"
            qry += " '" + pArrayList(7) + "',"
            qry += " '" + pArrayList(8) + "',"
            qry += " '" + pArrayList(9) + "',"
            qry += " '" + pArrayList(10) + "',"
            qry += " '" + pArrayList(11) + "',"
            qry += " '" + pArrayList(12) + "',"
            qry += " '" + pArrayList(13).ToString + "')"

            mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function INSERT_Ordenes_Encabezado(ByVal pArrayList As ArrayList) As Boolean
        Dim qry As String = String.Empty
        Dim pDate As Date = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
        'Dim dt As New DataTable("dtCampanaEncabezado")

        Try
            qry = " INSERT INTO APGProduccion.dbo.PROD_Ordenes_Encabezado"
            qry += " (CodigoArticulo, "
            qry += " Stock,"
            qry += " Ensamble,"
            qry += " Produccion,"
            qry += " DeudaRol,"
            qry += " DeudaCampana,"
            qry += " DeudaProyeccion,"
            qry += " Minimo,"
            qry += " Maximo,"
            qry += " Sugerido,"
            qry += " Comentarios,"
            qry += " Bit_UsuarioCreacion,"
            qry += " Bit_FechaCreacion)"
            qry += " VALUES ("
            qry += " '" + pArrayList(0) + "',"
            qry += " '" + pArrayList(1) + "',"
            qry += " '" + pArrayList(2) + "',"
            qry += " '" + pArrayList(3) + "',"
            qry += " '" + pArrayList(4) + "',"
            qry += " '" + pArrayList(5) + "',"
            qry += " '" + pArrayList(6) + "',"
            qry += " '" + pArrayList(7) + "',"
            qry += " '" + pArrayList(8) + "',"
            qry += " '" + pArrayList(9) + "',"
            qry += " '" + pArrayList(10) + "',"
            qry += " '" + My.Settings.log_Usuario.ToString + "',"
            qry += " CONVERT(DATE,GetDate(),111))"

            mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function INSERT_Ordenes_Encabezado(ByVal dtEncabezado As DataTable, ByVal dtAnalisisXArticulo As DataTable) As String
        Dim qry As String = String.Empty
        Dim pDate As Date = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
        'Dim dt As New DataTable("dtCampanaEncabezado")

        Try
            qry = " INSERT INTO APGProduccion.dbo.PROD_Ordenes_Encabezado"
            qry += " (CodigoArticulo, "
            qry += " Stock,"
            qry += " Ensamble,"
            qry += " Produccion,"
            qry += " DeudaRol,"
            qry += " DeudaCampana,"
            qry += " DeudaProyeccion,"
            qry += " Minimo,"
            qry += " Maximo,"
            qry += " Sugerido,"
            qry += " Comentarios,"
            qry += " Bit_UsuarioCreacion,"
            qry += " Bit_FechaCreacion)"
            qry += " OUTPUT INSERTED.Id "
            qry += " VALUES ("
            qry += " '" + dtEncabezado.Rows(0)("CodigoArticulo").ToString + "',"
            qry += " '" + dtAnalisisXArticulo.Rows(0)("Stock").ToString + "',"
            qry += " '" + dtAnalisisXArticulo.Rows(0)("Ensamble").ToString + "',"
            qry += " '" + dtAnalisisXArticulo.Rows(0)("Produccion").ToString + "',"
            qry += " '" + dtAnalisisXArticulo.Rows(0)("DeudaRol").ToString + "',"
            qry += " '" + dtAnalisisXArticulo.Rows(0)("DeudaCampana").ToString + "',"
            qry += " '" + dtAnalisisXArticulo.Rows(0)("DeudaProyeccion").ToString + "',"
            qry += " '" + dtAnalisisXArticulo.Rows(0)("StockMinimo").ToString + "',"
            qry += " '" + dtAnalisisXArticulo.Rows(0)("StockMaximo").ToString + "',"
            qry += " '0',"
            qry += " ' ',"
            qry += " '" + My.Settings.log_Usuario.ToString + "',"
            qry += " CONVERT(DATE,GetDate(),111))"

            Dim dtResultado As New DataTable("dtResultado")

            dtResultado = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar

            Return dtResultado.Rows(0)("Id").ToString

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function INSERT_Ordenes_Detalle_Temporal(ByVal dt As DataTable) As Boolean

        Dim pDate As Date = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)

        Try
            For i = 0 To dt.Rows.Count - 1
                Dim qry As New StringBuilder
                qry.Append(" INSERT INTO APGProduccion.dbo.PROD_Ordenes_Detalle_Temporal")
                qry.Append(" (Id,")
                qry.Append(" Id_Nivel1,")
                qry.Append(" Id_Nivel2,")
                qry.Append(" Tipo,")
                qry.Append(" NumeroSAP,")
                qry.Append(" Prioridad,")
                qry.Append(" CodigoArticulo,")
                qry.Append(" Unidades,")
                qry.Append(" Origen,")
                qry.Append(" Destino,")
                qry.Append(" Color,")
                qry.Append(" GrupoCliente,")
                qry.Append(" CodigoCliente,")
                qry.Append(" NumeroOrden,")
                qry.Append(" NumeroCampana,")
                qry.Append(" Entrega,")
                qry.Append(" Comentario_Nivel1,")
                qry.Append(" Comentario_Nivel2,")
                qry.Append(" SAP,")
                qry.Append(" Estatus,")
                qry.Append(" Bit_UsuarioCreacion,")
                qry.Append(" Bit_FechaCreacion")
                qry.Append(" )")
                qry.Append(" VALUES")
                qry.Append(" ('" + dt.Rows(i)("Id").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Id_Nivel1").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Id_Nivel2").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Tipo").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("NumeroSAP").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Prioridad").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("CodigoArticulo").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Unidades").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Origen").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Destino").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Color").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("GrupoCliente").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("CodigoCliente").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("NumeroOrden").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("NumeroCampana").ToString + "',")

                If dt.Rows(i)("Entrega").ToString = String.Empty Then
                    qry.Append(" NULL,")
                Else
                    Dim FechaEntrega As String = String.Empty
                    FechaEntrega = dt.Rows(i)("Entrega").ToString.Substring(6, 4)
                    FechaEntrega += "-" + dt.Rows(i)("Entrega").ToString.Substring(3, 2)
                    FechaEntrega += "-" + dt.Rows(i)("Entrega").ToString.Substring(0, 2)

                    qry.Append(" '" + FechaEntrega + "',")
                End If


                qry.Append(" '" + dt.Rows(i)("Comentario_Nivel1").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Comentario_Nivel2").ToString + "',")
                qry.Append(" '0',")
                qry.Append(" '1',")
                qry.Append(" '" + My.Settings.log_Usuario.ToString + "',")
                qry.Append(" CONVERT(DATE,GetDate(),111))")

                mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Next

            Return True

        Catch ex As Exception
            mMensajes.msg_Error("INSERT_Ordenes_Detalle  " + ex.Message.ToString)
            Return False
        End Try

    End Function

    Public Function INSERT_Ordenes_Detalle(ByVal dt As DataTable) As Boolean

        Dim pDate As Date = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)

        Try
            For i = 0 To dt.Rows.Count - 1
                Dim qry As New StringBuilder
                qry.Append(" INSERT INTO APGProduccion.dbo.PROD_Ordenes_Detalle")
                qry.Append(" (Id,")
                qry.Append(" Id_Nivel1,")
                qry.Append(" Id_Nivel2,")
                qry.Append(" Tipo,")
                qry.Append(" NumeroSAP,")
                qry.Append(" CodigoArticulo,")
                qry.Append(" Unidades,")
                qry.Append(" Origen,")
                qry.Append(" Destino,")
                qry.Append(" Color,")
                qry.Append(" GrupoCliente,")
                qry.Append(" CodigoCliente,")
                qry.Append(" NumeroOrden,")
                qry.Append(" NumeroCampana,")
                qry.Append(" Entrega,")
                qry.Append(" Comentario_Nivel1,")
                qry.Append(" Comentario_Nivel2,")
                qry.Append(" SAP,")
                qry.Append(" Estatus,")
                qry.Append(" Bit_UsuarioCreacion,")
                qry.Append(" Bit_FechaCreacion")
                qry.Append(" )")
                qry.Append(" VALUES")
                qry.Append(" ('" + dt.Rows(i)("Id").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Id_Nivel1").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Id_Nivel2").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Tipo").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("NumeroSAP").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("CodigoArticulo").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Unidades").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Origen").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Destino").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Color").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("GrupoCliente").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("CodigoCliente").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("NumeroOrden").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("NumeroCampana").ToString + "',")

                If dt.Rows(i)("Entrega").ToString = String.Empty Then
                    qry.Append(" NULL,")
                Else
                    Dim FechaEntrega As String = String.Empty
                    FechaEntrega = dt.Rows(i)("Entrega").ToString.Substring(6, 4)
                    FechaEntrega += "-" + dt.Rows(i)("Entrega").ToString.Substring(3, 2)
                    FechaEntrega += "-" + dt.Rows(i)("Entrega").ToString.Substring(0, 2)

                    qry.Append(" '" + FechaEntrega + "',")
                End If


                qry.Append(" '" + dt.Rows(i)("Comentario_Nivel1").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Comentario_Nivel2").ToString + "',")
                qry.Append(" '0',")
                qry.Append(" '1',")
                qry.Append(" '" + My.Settings.log_Usuario.ToString + "',")
                qry.Append(" CONVERT(DATE,GetDate(),111))")

                mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Next

            Return True

        Catch ex As Exception
            mMensajes.msg_Error("INSERT_Ordenes_Detalle  " + ex.Message.ToString)
            Return False
        End Try

    End Function

    Public Function INSERT_Ordenes_Detalle(ByVal dt As DataTable, ByVal pId As String, ByVal pSAP As String) As Boolean

        Dim pDate As Date = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)

        Try
            For i = 0 To dt.Rows.Count - 1
                Dim qry As New StringBuilder
                qry.Append(" INSERT INTO APGProduccion.dbo.PROD_Ordenes_Detalle")
                qry.Append(" (Id,")
                qry.Append(" Id_Nivel1,")
                qry.Append(" Id_Nivel2,")
                qry.Append(" Tipo,")
                qry.Append(" NumeroSAP,")
                qry.Append(" CodigoArticulo,")
                qry.Append(" Unidades,")
                qry.Append(" Origen,")
                qry.Append(" Destino,")
                qry.Append(" Color,")
                qry.Append(" GrupoCliente,")
                qry.Append(" CodigoCliente,")
                qry.Append(" NumeroOrden,")
                qry.Append(" NumeroCampana,")
                qry.Append(" Entrega,")
                qry.Append(" Comentario_Nivel1,")
                qry.Append(" Comentario_Nivel2,")
                qry.Append(" SAP,")
                qry.Append(" Estatus,")
                qry.Append(" Bit_UsuarioCreacion,")
                qry.Append(" Bit_FechaCreacion")
                qry.Append(" )")
                qry.Append(" VALUES")
                qry.Append(" ('" + pId + "',")
                qry.Append(" '" + dt.Rows(i)("Id_Nivel1").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Id_Nivel2").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Tipo").ToString + "',")
                qry.Append(" '" + pSAP + "',")
                qry.Append(" '" + dt.Rows(i)("CodigoArticulo").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Unidades").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Origen").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Destino").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Color").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("GrupoCliente").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("CodigoCliente").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("NumeroOrden").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("NumeroCampana").ToString + "',")

                If dt.Rows(i)("Entrega").ToString = String.Empty Then
                    qry.Append(" NULL,")
                Else
                    Dim FechaEntrega As String = String.Empty
                    FechaEntrega = dt.Rows(i)("Entrega").ToString.Substring(6, 4)
                    FechaEntrega += "-" + dt.Rows(i)("Entrega").ToString.Substring(3, 2)
                    FechaEntrega += "-" + dt.Rows(i)("Entrega").ToString.Substring(0, 2)

                    qry.Append(" '" + FechaEntrega + "',")
                End If


                qry.Append(" '" + dt.Rows(i)("Comentario_Nivel1").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Comentario_Nivel2").ToString + "',")
                qry.Append(" '1',")
                qry.Append(" '1',")
                qry.Append(" '" + My.Settings.log_Usuario.ToString + "',")
                qry.Append(" CONVERT(DATE,GetDate(),111))")

                mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Next

            Return True

        Catch ex As Exception
            mMensajes.msg_Error("INSERT_Ordenes_Detalle  " + ex.Message.ToString)
            Return False
        End Try

    End Function

    Public Function INSERT_Ordenes_Detalle(ByVal dt As DataTable, ByVal pCorrelativo As String, ByVal pId As String, ByVal pSAP As String) As Boolean

        Dim pDate As Date = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)

        Try
            Dim qry As New StringBuilder
            qry.Append(" INSERT INTO APGProduccion.dbo.PROD_Ordenes_Detalle")
            qry.Append(" (Id,")
            qry.Append(" Id_Nivel1,")
            qry.Append(" Id_Nivel2,")
            qry.Append(" Tipo,")
            qry.Append(" NumeroSAP,")
            qry.Append(" CodigoArticulo,")
            qry.Append(" Unidades,")
            qry.Append(" Origen,")
            qry.Append(" Destino,")
            qry.Append(" Color,")
            qry.Append(" GrupoCliente,")
            qry.Append(" CodigoCliente,")
            qry.Append(" NumeroOrden,")
            qry.Append(" NumeroCampana,")
            qry.Append(" Entrega,")
            qry.Append(" Comentario_Nivel1,")
            qry.Append(" Comentario_Nivel2,")
            qry.Append(" SAP,")
            qry.Append(" Estatus,")
            qry.Append(" Bit_UsuarioCreacion,")
            qry.Append(" Bit_FechaCreacion")
            qry.Append(" )")
            qry.Append(" VALUES")
            qry.Append(" ('" + pId + "',")
            qry.Append(" '" + dt.Rows(pCorrelativo)("Id_Nivel1").ToString + "',")
            qry.Append(" '" + dt.Rows(pCorrelativo)("Id_Nivel2").ToString + "',")
            qry.Append(" '" + dt.Rows(pCorrelativo)("Tipo").ToString + "',")
            qry.Append(" '" + pSAP + "',")
            qry.Append(" '" + dt.Rows(pCorrelativo)("CodigoArticulo").ToString + "',")
            qry.Append(" '" + dt.Rows(pCorrelativo)("Unidades").ToString + "',")
            qry.Append(" '0',")
            'qry.Append(" '" + dt.Rows(pCorrelativo)("Origen").ToString + "',")
            qry.Append(" '" + dt.Rows(pCorrelativo)("Destino").ToString + "',")
            qry.Append(" '" + dt.Rows(pCorrelativo)("Color").ToString + "',")
            qry.Append(" '" + dt.Rows(pCorrelativo)("GrupoCliente").ToString + "',")
            qry.Append(" '" + dt.Rows(pCorrelativo)("CodigoCliente").ToString + "',")
            qry.Append(" '" + dt.Rows(pCorrelativo)("NumeroOrden").ToString + "',")
            qry.Append(" '" + dt.Rows(pCorrelativo)("NumeroCampana").ToString + "',")

            If dt.Rows(pCorrelativo)("Entrega").ToString = String.Empty Then
                qry.Append(" NULL,")
            Else
                Dim FechaEntrega As String = String.Empty
                FechaEntrega = dt.Rows(pCorrelativo)("Entrega").ToString.Substring(6, 4)
                FechaEntrega += "-" + dt.Rows(pCorrelativo)("Entrega").ToString.Substring(3, 2)
                FechaEntrega += "-" + dt.Rows(pCorrelativo)("Entrega").ToString.Substring(0, 2)

                qry.Append(" '" + FechaEntrega + "',")
            End If


            qry.Append(" '" + dt.Rows(pCorrelativo)("Comentario_Nivel1").ToString + "',")
            qry.Append(" '" + dt.Rows(pCorrelativo)("Comentario_Nivel2").ToString + "',")
            qry.Append(" '1',")
            qry.Append(" '1',")
            qry.Append(" '" + My.Settings.log_Usuario.ToString + "',")
            qry.Append(" CONVERT(DATE,GetDate(),111))")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar


            Return True

        Catch ex As Exception
            mMensajes.msg_Error("INSERT_Ordenes_Detalle  " + ex.Message.ToString)
            Return False
        End Try

    End Function




    Public Function INSERT_OrdenesEnsambleProduccion_DetalleTemporal(ByVal dt As DataTable) As Boolean

        Dim pDate As Date = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)

        Try
            For i = 0 To dt.Rows.Count - 1
                Dim qry As New StringBuilder
                qry.Append(" INSERT INTO APGProduccion.dbo.PROD_Ordenes_Detalle_Temporal")
                qry.Append(" (Id,")
                qry.Append(" Id_Nivel1,")
                qry.Append(" Id_Nivel2,")
                qry.Append(" Tipo,")
                qry.Append(" NumeroSAP,")
                qry.Append(" CodigoArticulo,")
                qry.Append(" Unidades,")
                qry.Append(" Origen,")
                qry.Append(" Destino,")
                qry.Append(" Color,")
                qry.Append(" GrupoCliente,")
                qry.Append(" CodigoCliente,")
                qry.Append(" NumeroOrden,")
                qry.Append(" NumeroCampana,")
                qry.Append(" Entrega,")
                qry.Append(" Comentario_Nivel1,")
                qry.Append(" Comentario_Nivel2,")
                qry.Append(" SAP,")
                qry.Append(" Estatus,")
                qry.Append(" Bit_UsuarioCreacion,")
                qry.Append(" Bit_FechaCreacion")
                qry.Append(" )")
                qry.Append(" VALUES")
                qry.Append(" ('" + dt.Rows(i)("Id").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Id_Nivel1").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Id_Nivel2").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Tipo").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("NumeroSAP").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("CodigoArticulo").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Unidades").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Origen").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Destino").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Color").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("GrupoCliente").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("CodigoCliente").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("NumeroOrden").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("NumeroCampana").ToString + "',")

                If dt.Rows(i)("Entrega").ToString = String.Empty Then
                    qry.Append(" NULL,")
                Else
                    Dim FechaEntrega As String = String.Empty
                    FechaEntrega = dt.Rows(i)("Entrega").ToString.Substring(6, 4)
                    FechaEntrega += "-" + dt.Rows(i)("Entrega").ToString.Substring(3, 2)
                    FechaEntrega += "-" + dt.Rows(i)("Entrega").ToString.Substring(0, 2)

                    qry.Append(" '" + FechaEntrega + "',")
                End If


                qry.Append(" '" + dt.Rows(i)("Comentario_Nivel1").ToString + "',")
                qry.Append(" '" + dt.Rows(i)("Comentario_Nivel2").ToString + "',")
                qry.Append(" '0',")
                qry.Append(" '1',")
                qry.Append(" '" + My.Settings.log_Usuario.ToString + "',")
                qry.Append(" CONVERT(DATE,GetDate(),111))")

                mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Next

            Return True

        Catch ex As Exception
            mMensajes.msg_Error("INSERT_Ordenes_Detalle  " + ex.Message.ToString)
            Return False
        End Try

    End Function





    Public Function INSERT_CodigoProducido_Nuevo(ByVal pCodigoArticulo As String, ByVal pNombreArticulo As String) As Boolean

        Dim pDate As Date = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)

        Try

            Dim qry As New StringBuilder
            qry.Append(" INSERT INTO APGProduccion.dbo.PROD_CodigosProducidos ")
            qry.Append(" (Id, ")
            qry.Append(" Descripcion, ")
            qry.Append(" Material1, ")
            qry.Append(" Material2, ")
            qry.Append(" Molde, ")
            qry.Append(" Estatus, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha) ")
            qry.Append(" Values('" + pCodigoArticulo + "', ")
            qry.Append(" '" + pNombreArticulo + "', ")
            qry.Append(" '', ")
            qry.Append(" '', ")
            qry.Append(" '', ")
            qry.Append(" '1', ")
            qry.Append(" '" + My.Settings.log_Usuario.ToString + "',")
            qry.Append(" CONVERT(DATE,GetDate(),111))")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error("INSERT_Ordenes_Detalle  " + ex.Message.ToString)
            Return False
        End Try

    End Function


    Public Function SET_ValidarDisponibilidad_Insertar(ByVal pPrograma As String, ByVal pVentana As String, ByVal pdtCodigoArticulo As DataTable) As Boolean
        Dim dt As New DataTable("dtBodegasMoldes")
        Try
            Dim qry As New StringBuilder


            For i = 0 To pdtCodigoArticulo.Rows.Count - 1
                qry.Append(" INSERT INTO APGProduccion.dbo.PROD_Estatus_Articulos ")
                qry.Append(" (Programa, ")
                qry.Append(" Ventana, ")
                qry.Append(" CodigoArticulo, ")
                qry.Append(" Bit_Usuario")
                qry.Append(" ) ")
                qry.Append(" VALUES('" + pPrograma + "', ")
                qry.Append(" '" + pVentana + "', ")
                qry.Append(" '" + pdtCodigoArticulo.Rows(i)("CodigoArticulo").ToString + "', ")
                qry.Append(" '" + My.Settings.log_Usuario.ToString + "'")
                qry.Append(" ) ")
            Next

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function
#Region "MOLDES"

    Public Function SET_Moldes(ByVal pId As String, ByVal pMoldeSerie As String, ByVal pNombre As String, ByVal pCavidades As String, ByVal pUnidades As String, ByVal pPorcIneficiencia As String, _
                               ByVal pComentarios As String, ByVal pStatus As String) As Boolean
        Dim dt As New DataTable("dtBodegasMoldes")
        Try
            Dim qry As New StringBuilder


            qry.Append(" INSERT INTO APGProduccion.dbo.PROD_Moldes ")
            qry.Append(" (Id, ")
            qry.Append(" MoldeSerie, ")
            qry.Append(" Nombre, ")
            qry.Append(" Cavidades, ")
            qry.Append(" Unidades, ")
            qry.Append(" PorcIneficiencia, ")
            qry.Append(" Comentarios, ")
            qry.Append(" Estatus, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha) ")
            qry.Append(" VALUES('" + pId + "', ")
            qry.Append(" '" + pMoldeSerie + "', ")
            qry.Append(" '" + pNombre + "', ")
            qry.Append(" '" + pCavidades + "', ")
            qry.Append(" '" + pUnidades + "', ")
            qry.Append(" '" + pPorcIneficiencia + "', ")
            qry.Append(" '" + pComentarios + "', ")
            qry.Append(" '" + pStatus + "', ")
            qry.Append(" '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" GetDate()) ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function


    Public Function SET_Moldes_Maquinas(ByVal pMolde As String, ByVal pMaquina As String, ByVal pMaterial1 As String, ByVal pMaterial2 As String, ByVal pPrioridad As String) As Boolean
        Dim dt As New DataTable("dtBodegasMoldesMaquinas")
        Try
            Dim qry As New StringBuilder


            qry.Append(" INSERT INTO APGProduccion.dbo.PROD_MoldesMaquinas ")
            qry.Append(" (Molde, ")
            qry.Append(" Maquina, ")
            qry.Append(" Material1, ")
            qry.Append(" Material2, ")
            qry.Append(" Prioridad, ")
            qry.Append(" Estatus, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha) ")
            qry.Append(" VALUES  ")
            qry.Append(" ('" + pMolde + "',  ")
            qry.Append(" '" + pMaquina + "', ")
            qry.Append(" '" + pMaterial1 + "', ")
            qry.Append(" '" + pMaterial2 + "', ")
            qry.Append(" '" + pPrioridad + "', ")
            qry.Append(" '1',")
            qry.Append(" '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" GetDate()) ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function SET_ComponentesMaquinas(ByVal pComponente As String, ByVal pMaquina As String, ByVal pPrioridad As String) As Boolean
        Dim dt As New DataTable("dtBodegasMoldesMaquinas")
        Try
            Dim qry As New StringBuilder


            qry.Append(" INSERT INTO APGProduccion.dbo.PROD_ComponentesMaquinas ")
            qry.Append(" (Componente, ")
            qry.Append(" Maquina, ")
            qry.Append(" Prioridad, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha) ")
            qry.Append(" VALUES ")
            qry.Append(" ('" + pComponente + "', ")
            qry.Append(" '" + pMaquina + "', ")
            qry.Append(" '" + pPrioridad + "', ")
            qry.Append(" '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" GetDate()) ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function


#End Region

#Region "Maquinas"
    Public Function SET_Maquinas(ByVal pSeleccion As DataTable) As Boolean

        Dim dt As New DataTable("dtBodegasMaquinas")
        Try
            Dim qry As New StringBuilder


            qry.Append(" INSERT INTO APGProduccion.dbo.PROD_Maquinas  ")
            qry.Append(" (Id,  ")
            qry.Append(" Nombre,  ")
            qry.Append(" Modelo,  ")
            qry.Append(" Serie, ")
            qry.Append(" Grupo, ")
            qry.Append(" Ubicacion, ")
            qry.Append(" Toneladas, ")
            qry.Append(" LibrasHoras,  ")
            qry.Append(" Tipo, ")
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
            qry.Append(" AnilloCentrador,              ")
            qry.Append(" CambioMolde_Hora, ")
            qry.Append(" Estatus,  ")
            qry.Append(" Bit_CreacionUsuario,  ")
            qry.Append(" Bit_CreacionFecha) ")
            qry.Append(" VALUES ")
            qry.Append(" ('" + pSeleccion.Rows(0)("Id").ToString + "',  ")
            qry.Append(" '" + pSeleccion.Rows(0)("Nombre").ToString + "',  ")
            qry.Append(" '" + pSeleccion.Rows(0)("Modelo").ToString + "',  ")
            qry.Append(" '" + pSeleccion.Rows(0)("Serie").ToString + "', ")
            qry.Append(" '" + pSeleccion.Rows(0)("Grupo").ToString + "', ")
            qry.Append(" '" + pSeleccion.Rows(0)("Ubicacion").ToString + "', ")
            qry.Append(" '" + pSeleccion.Rows(0)("Toneladas").ToString + "', ")
            qry.Append(" '" + pSeleccion.Rows(0)("LibrasHoras").ToString + "',  ")
            qry.Append(" '" + pSeleccion.Rows(0)("Tipo").ToString + "', ")
            qry.Append(" '" + pSeleccion.Rows(0)("InyeccionOz").ToString + "', ")
            qry.Append(" '" + pSeleccion.Rows(0)("InyeccionGr").ToString + "', ")
            qry.Append(" '" + pSeleccion.Rows(0)("PrensaCierreMAX").ToString + "', ")
            qry.Append(" '" + pSeleccion.Rows(0)("PrensaCierreMIN").ToString + "', ")
            qry.Append(" '" + pSeleccion.Rows(0)("PrensaCierreCARRERA").ToString + "', ")
            qry.Append(" '" + pSeleccion.Rows(0)("CarreraExpulsionMM").ToString + "', ")
            qry.Append(" '" + pSeleccion.Rows(0)("BarrasDistanciaHOR").ToString + "', ")
            qry.Append(" '" + pSeleccion.Rows(0)("BarrasDistanciaVER").ToString + "', ")
            qry.Append(" '" + pSeleccion.Rows(0)("PlatinasDimencionesHOR").ToString + "', ")
            qry.Append(" '" + pSeleccion.Rows(0)("PlatinasDimencionesVER").ToString + "', ")
            qry.Append(" '" + pSeleccion.Rows(0)("AnilloCentrador").ToString + "', ")
            qry.Append(" '" + pSeleccion.Rows(0)("CambioMolde_Hora").ToString + "', ")
            qry.Append(" '1', ")
            qry.Append(" '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" GetDate()) ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function SET_CodigosProducidos(ByVal pId As String, ByVal pDescripcion As String, ByVal pMaterial1 As String, ByVal pMaterial1Porc As String, ByVal pMaterial2 As String, _
                            ByVal pMaterial2Porc As String, ByVal pMaterial3 As String, ByVal pMolde As String, ByVal pEstatus As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" INSERT INTO APGProduccion.dbo.PROD_CodigosProducidos ")
            qry.Append(" (Id, ")
            qry.Append(" Descripcion, ")
            qry.Append(" Material1, ")
            qry.Append(" Material1Porc, ")
            qry.Append(" Material2, ")
            qry.Append(" Material2Porc, ")
            qry.Append(" Material3, ")
            qry.Append(" Molde, ")
            qry.Append(" Estatus, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha) ")
            qry.Append(" VALUES ")
            qry.Append(" ('" + pId + "', ")
            qry.Append(" '" + pDescripcion + "', ")
            qry.Append(" '" + pMaterial1 + "', ")
            qry.Append(" '" + pMaterial1Porc + "', ")
            qry.Append(" '" + pMaterial2 + "', ")
            qry.Append(" '" + pMaterial2Porc + "', ")
            qry.Append(" '" + pMaterial3 + "', ")
            qry.Append(" '" + pMolde + "', ")
            qry.Append(" '" + pEstatus + "', ")
            qry.Append(" '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" GetDate()) ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function
#End Region


    Public Function SET_PorcEficienciaMaquinas(ByVal pFecha As String, ByVal pPorcentaje As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" INSERT INTO APGProduccion.dbo.PROD_PorcEficienciaMaquinas ")
            qry.Append(" (Fecha, ")
            qry.Append(" Porcentaje, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha ")
            qry.Append(" ) ")
            qry.Append(" VALUES ( ")
            qry.Append(" '" + pFecha + "', ")
            qry.Append(" '" + pPorcentaje + "', ")
            qry.Append(" '" + My.Settings.log_Usuario + "', ")
            qry.Append(" GETDATE() )  ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            SET_PorcEficienciaMaquinas_LOG(pFecha, pPorcentaje)
            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function
    Public Function SET_PorcEficienciaMaquinas_LOG(ByVal pFecha As String, ByVal pPorcentaje As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" INSERT INTO APGProduccion.dbo.PROD_PorcEficienciaMaquinas_LOG ")
            qry.Append(" (Fecha, ")
            qry.Append(" Porcentaje, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha ")
            qry.Append(" ) ")
            qry.Append(" VALUES ( ")
            qry.Append(" '" + pFecha + "', ")
            qry.Append(" '" + pPorcentaje + "', ")
            qry.Append(" '" + My.Settings.log_Usuario + "', ")
            qry.Append(" GETDATE() )  ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar



            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function
    Public Function SET_SalidasInventario_LOG(ByVal pDt As DataTable, ByVal pNumSAP As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" INSERT INTO APGProduccion.dbo.PROD_SalidasInventario_LOG ")
            qry.Append(" (NumSAP, ")
            qry.Append(" Fecha, ")
            qry.Append(" ListaPrecios, ")
            qry.Append(" Comentarios, ")
            'qry.Append(" DocTotal, ")
            qry.Append(" UsuarioAPG, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha ")
            qry.Append(" ) ")
            qry.Append(" VALUES ")
            qry.Append(" ('" + pNumSAP + "', ")
            qry.Append(" CONVERT(DATE,'" + pDt.Rows(0)("FechaDocumento").ToString + "',105), ")
            qry.Append(" '" + pDt.Rows(0)("ListaPrecios").ToString + "', ")
            qry.Append(" '" + pDt.Rows(0)("Comentarios").ToString + "', ")
            'qry.Append(" '" + pDt.Rows(0)("DocTotal").ToString + "', ")
            qry.Append(" '" + My.Settings.log_Usuario + "', ")
            qry.Append(" '" + My.Settings.log_Usuario + "', ")
            qry.Append(" GETDATE() )  ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function


    Public Function SET_EnsamblesArticulos(ByVal pCodigoArticulo As String, ByVal pSegundosXArticulo As String, ByVal pMinutosXArticulo As String, _
                                              ByVal pEnsamblesXHora As String, ByVal pEquipoPersonas As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" INSERT INTO APGProduccion.dbo.PROD_Ensamble_Parametros ")
            qry.Append(" (CodigoArticulo, ")
            qry.Append(" SegundosXArticulo, ")
            qry.Append(" MinutosXArticulo, ")
            qry.Append(" EnsamblesXHora, ")
            qry.Append(" EquipoPersonas, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha)  ")
            qry.Append(" VALUES ")
            qry.Append(" ('" + pCodigoArticulo + "', ")
            qry.Append(" '" + pSegundosXArticulo + "', ")
            qry.Append(" '" + pMinutosXArticulo + "', ")
            qry.Append(" '" + pEnsamblesXHora + "', ")
            qry.Append(" '" + pEquipoPersonas + "', ")
            qry.Append(" '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" GetDate()) ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function SET_ProduccionParametros(ByVal pCodigoArticulo As String, ByVal pInyeccionGrms As String, ByVal pInyeccionVariacion As String, _
                                                  ByVal pInyeccionHora As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" INSERT INTO APGProduccion.dbo.PROD_Produccion_Parametros ")
            qry.Append(" (Id, ")
            qry.Append(" InyeccionGrms, ")
            qry.Append(" InyeccionVariacion, ")
            qry.Append(" InyeccionHora, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha) ")
            qry.Append(" VALUES ")
            qry.Append(" ('" + pCodigoArticulo + "', ")
            qry.Append(" '" + pInyeccionGrms + "', ")
            qry.Append(" '" + pInyeccionVariacion + "', ")
            qry.Append(" '" + pInyeccionHora + "', ")
            qry.Append(" '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" GetDate()) ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function SET_EmergenciasProduccion_Correlativo() As String

        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable
            qry.Append(" INSERT INTO APGProduccion.dbo.PROD_EmergenciasProduccion_Correlativo ")
            qry.Append(" (Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha) ")
            qry.Append(" OUTPUT INSERTED.Id ")
            qry.Append(" VALUES('" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" GetDate()) ")


            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return dt.Rows(0)("Id").ToString

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function
    Public Function SET_EmergenciasProduccion_Encabezado(ByVal pId As String, ByVal dtDetalle As DataTable) As Boolean

        Try
            Dim qry As New StringBuilder



            For i = 0 To dtDetalle.Rows.Count - 1
                qry.Append(" INSERT INTO APGProduccion.dbo.PROD_EmergenciasProduccion_Encabezado ")
                qry.Append(" (Id, ")
                qry.Append(" Prioridad, ")
                qry.Append(" CodigoArticulo, ")
                qry.Append(" NombreArticulo, ")
                qry.Append(" Planeado, ")
                qry.Append(" Completado, ")
                qry.Append(" Pendiente, ")
                qry.Append(" Bit_CreacionUsuario, ")
                qry.Append(" Bit_CreacionFecha) ")
                qry.Append(" VALUES( ")
                qry.Append(" '" + pId + "', ")
                qry.Append(" '" + dtDetalle.Rows(i)("Prioridad").ToString + "', ")
                qry.Append(" '" + dtDetalle.Rows(i)("CodigoArticulo").ToString + "', ")
                qry.Append(" '" + dtDetalle.Rows(i)("NombreArticulo").ToString + "', ")
                qry.Append(" '" + dtDetalle.Rows(i)("Planeado").ToString + "', ")
                qry.Append(" '" + dtDetalle.Rows(i)("Completado").ToString + "', ")
                qry.Append(" '" + dtDetalle.Rows(i)("Pendiente").ToString + "', ")
                qry.Append(" '" + My.Settings.log_Usuario.ToString + "', ")
                qry.Append(" GetDate()) ")
            Next

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function
    Public Function SET_EmergenciasProduccion_Plan(ByVal pId As String, ByVal dtDetalle As DataTable) As Boolean

        Try
            Dim qry As New StringBuilder



            For i = 0 To dtDetalle.Rows.Count - 1
                qry.Append(" INSERT INTO APGProduccion.dbo.PROD_EmergenciasProduccion_Plan ")
                qry.Append(" (Id, ")
                qry.Append(" Prioridad, ")
                qry.Append(" CodigoArticulo, ")
                qry.Append(" NombreArticulo, ")
                'qry.Append(" Stock, ")
                qry.Append(" Planeado, ")
                qry.Append(" Completado, ")
                qry.Append(" Pendiente, ")
                qry.Append(" ColoresPendientes, ")
                qry.Append(" ColorInicio, ")
                qry.Append(" Cliente, ")
                qry.Append(" Campana, ")
                qry.Append(" FechaDespacho, ")
                qry.Append(" Observacion, ")
                qry.Append(" Bit_CreacionUsuario, ")
                qry.Append(" Bit_CreacionFecha) ")
                qry.Append(" VALUES ")
                qry.Append(" ('" + pId + "', ")
                qry.Append(" '" + dtDetalle.Rows(i)("Prioridad").ToString + "', ")
                qry.Append(" '" + dtDetalle.Rows(i)("CodigoArticulo").ToString + "', ")
                qry.Append(" '" + dtDetalle.Rows(i)("NombreArticulo").ToString + "', ")
                'qry.Append(" '" + dtDetalle.Rows(i)("Stock").ToString + "', ")
                qry.Append(" '" + dtDetalle.Rows(i)("Planeado").ToString + "', ")
                qry.Append(" '" + dtDetalle.Rows(i)("Completado").ToString + "', ")
                qry.Append(" '" + dtDetalle.Rows(i)("Pendiente").ToString + "', ")
                qry.Append(" '" + dtDetalle.Rows(i)("ColoresPendientes").ToString + "', ")
                qry.Append(" '" + dtDetalle.Rows(i)("ColorInicio").ToString + "', ")
                qry.Append(" '" + dtDetalle.Rows(i)("Cliente").ToString + "', ")
                qry.Append(" '" + dtDetalle.Rows(i)("Campaña").ToString + "', ")
                If dtDetalle.Rows(i)("FechaDespacho").ToString = Nothing Then
                    qry.Append(" NULL, ")
                Else
                    qry.Append(" CONVERT(DATE,'" + dtDetalle.Rows(i)("FechaDespacho") + "',105), ")
                End If
                qry.Append(" '" + dtDetalle.Rows(i)("Observacion").ToString + "', ")
                qry.Append(" '" + My.Settings.log_Usuario.ToString + "', ")
                qry.Append(" GetDate()) ")
            Next

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function


    Public Function SET_PROD_ListaPrecios_LOG(ByVal pListaPrecios As String, ByVal pCodigoArticulo As String, ByVal pPrecio As String, ByVal pMoneda As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" INSERT INTO APGProduccion.dbo.PROD_ListaPrecios_LOG ")
            qry.Append(" (NumListaPrecios, ")
            qry.Append(" CodigoArticulo, ")
            qry.Append(" Precio, ")
            qry.Append(" Moneda, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha) ")
            qry.Append(" VALUES( ")
            qry.Append(" '" + pListaPrecios + "', ")
            qry.Append(" '" + pCodigoArticulo + "', ")
            qry.Append(" '" + pPrecio + "', ")
            qry.Append(" '" + pMoneda + "', ")
            qry.Append(" '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" GETDATE()) ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function SET_PlanificacionProduccion_Programada(ByVal pPreferencial As String, ByVal pEstado As String, ByVal pPrioridad As String, ByVal pPrioridadMaquina As String, _
                                                           ByVal pCodigoArticulo As String, ByVal pComentarios As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" INSERT INTO APGProduccion.dbo.PROD_ProgramacionProduccion ")
            qry.Append(" (Preferencial, ")
            qry.Append(" Estado, ")
            qry.Append(" Prioridad, ")
            qry.Append(" PrioridadMaquina, ")
            qry.Append(" CodigoArticulo, ")
            qry.Append(" Comentarios, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha) ")
            qry.Append(" VALUES ")
            qry.Append(" ('" + pPreferencial + "', ")
            qry.Append(" '" + pEstado + "', ")
            qry.Append(" '" + pPrioridad + "', ")
            qry.Append(" '" + pPrioridadMaquina + "', ")
            qry.Append(" '" + pCodigoArticulo + "', ")
            qry.Append(" '" + pComentarios + "', ")
            qry.Append(" '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" GETDATE()) ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function

    Public Function SET_AdvertenciasTrabajo(ByVal pId As String, ByVal pNumLInea As String, ByVal pDescripcion As String, ByVal pEstatus As String) As Boolean

        Try
            Dim qry As New StringBuilder

            qry.Append(" INSERT INTO APGProduccion.dbo.PROD_Advertencias_Parametros ")
            qry.Append(" (Id,NumLinea,Descripcion,Estatus,Bit_CreacionUsuario,Bit_CreacionFecha) ")
            qry.Append(" VALUES ( ")
            qry.Append(" '" + pId + "', ")
            qry.Append(" '" + pNumLInea + "', ")
            qry.Append(" '" + pDescripcion + "', ")
            qry.Append(" '" + pEstatus + "', ")
            qry.Append(" '" + My.Settings.log_Usuario.ToString + "', ")
            qry.Append(" GETDATE()) ")

            mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            Return True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return False
        End Try
    End Function



    Public Function SET_CargaProduccion_(ByVal pCodigo As String, ByVal pInyeccionGrms As String, ByVal pInyeccionVariacion As String, ByVal pInyeccionHora As String, ByRef pError As String) As Boolean
        Try
            Dim qry As New StringBuilder
            Dim dt As New DataTable()

            qry.Append(" DECLARE @Codigo as VARCHAR(10) ")
            qry.Append(" DECLARE @ExisteCP as INTEGER ")
            qry.Append(" DECLARE @ExisteParametros as INTEGER ")

            qry.Append(" SET @Codigo = '" + pCodigo + "' ")
            qry.Append(" SELECT @ExisteCP = COUNT(Id) FROM APGProduccion.dbo.PROD_CodigosProducidos ")
            qry.Append(" WHERE Id = @Codigo ")

            qry.Append(" SELECT @ExisteParametros = COUNT(Id) FROM APGProduccion.dbo.PROD_Produccion_Parametros ")
            qry.Append(" WHERE Id = @Codigo ")

            qry.Append(" IF @ExisteCP = 0  ")
            qry.Append(" SELECT CONVERT(VARCHAR(10),@Codigo) + ' ERROR.No existe <TABLACP>' ")

            qry.Append(" ELSE ")

            qry.Append(" IF @ExisteParametros > 0 ")
            qry.Append(" SELECT CONVERT(VARCHAR(10),@Codigo) + ' Si Existe...' ")

            qry.Append(" ELSE ")

            qry.Append(" INSERT INTO APGProduccion.dbo.[PROD_Produccion_Parametros] ")
            qry.Append(" (Id, InyeccionGrms,InyeccionVariacion,InyeccionHora,Bit_CreacionUsuario,Bit_CreacionFecha) ")
            qry.Append(" VALUES (@Codigo, '" + pInyeccionGrms + "','" + pInyeccionVariacion + "','" + pInyeccionHora + "','" + My.Settings.log_Usuario.ToString + "',GETDATE()); ")

            'qry.Append(" PRINT 'NO SE INGRESO EL CODIGO ' + CONVERT(VARCHAR(10),@Codigo) ")


            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            If dt.Rows.Count > 0 Then
                pError = dt.Rows(0)(0)
                Return False
            End If

            Return True


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return False
        End Try

    End Function



End Module
