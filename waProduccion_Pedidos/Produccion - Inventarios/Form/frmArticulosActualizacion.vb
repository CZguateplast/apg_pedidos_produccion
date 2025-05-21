Imports System.IO
Public Class frmArticulosActualizacion
    Private Sub Sub_Seguridad()
        Try
            mSeguridad.APG_Seguridad(Me, barbtnSAP)
            'MsgBox(clbcBaseDatosActualizar.ItemCount)
            'clbcBaseDatosActualizar.Items.Insert(3, "Mexico")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub frmArticulosActualizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Sub_Seguridad()

            Dim dt As New DataTable("dsdtCatalogos")
            dt = mSQLSelect.GET_PROD_CatListados("Campos_Actualizar")
            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsArticulosActualizacion1.Tables(DsArticulosActualizacion1.dsdtCamposActualizar.TableName.ToString).Clear()
            DsArticulosActualizacion1.Tables(DsArticulosActualizacion1.dsdtCamposActualizar.TableName.ToString).Merge(dt)

            mFunciones.FCN_FILL_SearchLookUpEdit(slueGrupoArticulo, mSQLSelect.GET_Catalogo_GrupoArticulos(), "Id", "Nombre")

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub slueCodigoArticulo_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles slueCodigoArticulo.EditValueChanging
        Try
            If e.NewValue.ToString = String.Empty Then
                Exit Sub
            End If
            If MsgBox("Desea agregar el Articulo [" + e.NewValue.ToString + "] a la lista para actualizar?", MsgBoxStyle.YesNo, "Agregar") = MsgBoxResult.No Then
                e.Cancel = True
                Exit Sub
            End If

            Dim dt As New DataTable("dtArticulosActualizar")
            dt = mSQLSelect.GET_ArticulosAR("'" + e.NewValue.ToString + "'")

            If dt.Rows.Count = Nothing Then
                slueCodigoArticulo.EditValue = String.Empty
                Exit Sub
            End If

            DsArticulosActualizacion1.Tables(DsArticulosActualizacion1.dsdtArticulosActualizar.TableName.ToString).Merge(dt)
            grdArticulosActualizar.Focus()

            e.Cancel = True
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub slueCodigoArticulo_Enter(sender As Object, e As EventArgs) Handles slueCodigoArticulo.Enter
        Try
            mFunciones.FCN_FILL_SearchLookUpEdit(slueCodigoArticulo, mSQLSelect.GET_ArticulosARconEx(mFunciones.FCN_GET_Columna(grdviewArticulosActualizar, "CodigoArticulo")), "CodigoArticulo", "CodigoArticulo")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub barbtnSAP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSAP.ItemClick
        Try
            If grdviewArticulosActualizar.RowCount = Nothing Then
                msg_Error("No existen Articulos para Actualizar. Debe agregar uno como minimo")
                Exit Sub
            End If

            If grdviewCamposActualizar.SelectedRowsCount = Nothing Then
                msg_Error("Seleccione los campos que desea actualizar!")
                Exit Sub
            End If

            Dim pDB As Boolean = False
            For j = 0 To clbcBaseDatosActualizar.Items.Count - 1
                If clbcBaseDatosActualizar.Items.Item(j).CheckState = CheckState.Checked Then
                    pDB = True
                    Exit For
                End If
            Next

            If pDB = False Then
                msg_Error("Seleccione las Compañias que desea Actualizar!")
                Exit Sub
            End If


            Dim pTipoProceso As Boolean = False
            For j = 0 To clbcBaseDatosActualizar.Items.Count - 1
                If clbcTipoProceso.Items.Item(j).CheckState = CheckState.Checked Then
                    pTipoProceso = True
                    Exit For
                End If
            Next

            If pTipoProceso = False Then
                msg_Error("Seleccione el Tipo de Proceso que desea Aplicar!")
                Exit Sub
            End If



            Dim arrBaseDatos As New ArrayList
            For i = 0 To clbcBaseDatosActualizar.Items.Count - 1
                If clbcBaseDatosActualizar.Items.Item(i).CheckState = CheckState.Checked Then
                    arrBaseDatos.Add(clbcBaseDatosActualizar.Items.Item(i).Value.ToString)
                End If
            Next

            Dim pAgregar As Boolean = False
            If clbcTipoProceso.Items.Item("Agregar").CheckState = CheckState.Checked Then
                pAgregar = True
            End If

            Dim pActualizar As Boolean = False
            If clbcTipoProceso.Items.Item("Actualizar").CheckState = CheckState.Checked Then
                pActualizar = True
            End If


            Dim arrArticulosActualizar As ArrayList
            Dim dtCamposSAP As New DataTable("dtCamposSAP")
            Dim dtCamposUsuario As New DataTable("dtCamposUsuario")

            arrArticulosActualizar = mFunciones.FCN_XTRAGRID_GetFilas(grdviewArticulosActualizar)
            dtCamposSAP = mSQLSelect.GET_CamposActualizar("Campos_Actualizar", mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewCamposActualizar, "Id"), "'1','0'")
            dtCamposUsuario = mSQLSelect.GET_CamposActualizar("Campos_Actualizar", mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewCamposActualizar, "Id"), "0")


            If SAP_DIAPI_ActualizacionCodigosArticulo(pAgregar, pActualizar, arrBaseDatos, arrArticulosActualizar, dtCamposSAP, ssmActualizando) Then
                DsArticulosActualizacion1.Tables(DsArticulosActualizacion1.dsdtArticulosActualizar.TableName.ToString).Clear()
                mMensajes.msg_Informacion("La actualizacion de los Articulos se ha completado exitosamente")
            Else
                mMensajes.msg_Informacion("A existido un error en el procedimiento! Favor Revise y vuelva a intentarlo.")
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEliminar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_EliminarFilasSeleccionadas(grdviewArticulosActualizar)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub


    Private Sub slueGrupoArticulo_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles slueGrupoArticulo.EditValueChanging
        Try
            If e.NewValue.ToString = String.Empty Then
                Exit Sub
            End If
            If MsgBox("Desea agregar el Articulo [" + e.NewValue.ToString + "] a la lista para actualizar?", MsgBoxStyle.YesNo, "Agregar") = MsgBoxResult.No Then
                e.Cancel = True
                Exit Sub
            End If

            Dim dt As New DataTable("dtArticulosActualizar")
            dt = mSQLSelect.GET_ArticulosARGrupo(e.NewValue.ToString)

            If dt.Rows.Count = Nothing Then
                slueCodigoArticulo.EditValue = String.Empty
                Exit Sub
            End If

            DsArticulosActualizacion1.Tables(DsArticulosActualizacion1.dsdtArticulosActualizar.TableName.ToString).Clear()
            DsArticulosActualizacion1.Tables(DsArticulosActualizacion1.dsdtArticulosActualizar.TableName.ToString).Merge(dt)
            grdArticulosActualizar.Focus()

            e.Cancel = True
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnExcel_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnExcel.ButtonClick
#Region "Anterior"
        'ofdExcel.FileName = ""
        'ofdExcel.Title = "Abrir Archivo"
        'ofdExcel.Filter = "Archivos CSV|*.csv"

        'If ofdExcel.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    btnExcel.EditValue = ofdExcel.FileName.ToString



        '    mmeArchivoExcel.EditValue = System.IO.File.ReadAllText(btnExcel.EditValue)


        '    Dim arrCodigoArticulos As New ArrayList
        '    Dim ArregloLine As String = String.Empty

        '    For i = 0 To mmeArchivoExcel.Lines.Count - 1
        '        If Not mmeArchivoExcel.Lines(i).ToString = Nothing Then
        '            If Len(mmeArchivoExcel.Lines(i).ToString) = "13" Then
        '                ArregloLine = mmeArchivoExcel.Lines(i).Substring(0, 13).ToString
        '            ElseIf Len(mmeArchivoExcel.Lines(i).ToString) = "14" Then
        '                ArregloLine = mmeArchivoExcel.Lines(i).Substring(0, 14).ToString
        '            End If

        '        End If

        '        arrCodigoArticulos.Add(ArregloLine)
        '    Next
        '    If arrCodigoArticulos.Count = Nothing Then
        '        mMensajes.msg_Informacion("No existen datos para leer en el Archivo de Excel")
        '        Exit Sub
        '    End If
        '    DsArticulosActualizacion1.Tables(DsArticulosActualizacion1.dsdtArticulosActualizar.TableName.ToString).Clear()

        '    Dim dt As New DataTable("dtArticulosActualizar")
        '    Dim pArticulo As String
        '    For j = 0 To arrCodigoArticulos.Count - 2
        '        pArticulo = LTrim(RTrim(arrCodigoArticulos.Item(j).ToString))
        '        dt = mSQLSelect.GET_ArticulosAR("'" + pArticulo + "'")
        '        If Not dt.Rows.Count = Nothing Then
        '            DsArticulosActualizacion1.Tables(DsArticulosActualizacion1.dsdtArticulosActualizar.TableName.ToString).Merge(dt)
        '        Else
        '            mMensajes.msg_Informacion("El Codigo " + arrCodigoArticulos.Item(j).ToString + " no fue encontrado en nuestra base de datos!")
        '        End If
        '    Next


        'End If
#End Region

#Region "Nuevo"
        ofdExcel.FileName = ""
        ofdExcel.Title = "Abrir Archivo"
        ofdExcel.Filter = "Archivos CSV|*.csv"

        If ofdExcel.ShowDialog() = Windows.Forms.DialogResult.OK Then
            btnExcel.EditValue = ofdExcel.FileName.ToString

            ' Leer todo el contenido del archivo
            Dim lines As String() = System.IO.File.ReadAllLines(btnExcel.EditValue)
            Dim codigoArticulos As New List(Of String)

            ' Procesar cada línea
            For Each line In lines
                If Not String.IsNullOrWhiteSpace(line) Then
                    Dim codigo As String = line.Trim()
                    If codigo.Length = 13 OrElse codigo.Length = 14 Then
                        codigoArticulos.Add(codigo.Substring(0, codigo.Length))
                    End If
                End If
            Next

            If codigoArticulos.Count = 0 Then
                mMensajes.msg_Informacion("No existen datos para leer en el Archivo de Excel")
                Exit Sub
            End If

            ' Limpiar la tabla antes de actualizar
            DsArticulosActualizacion1.Tables(DsArticulosActualizacion1.dsdtArticulosActualizar.TableName.ToString).Clear()

            ' Crear un DataTable para almacenar los resultados
            Dim dtArticulos As New DataTable("dtArticulosActualizar")

            For Each codigo In codigoArticulos
                Dim dt As DataTable = mSQLSelect.GET_ArticulosAR("'" & codigo & "'")
                If dt.Rows.Count > 0 Then
                    DsArticulosActualizacion1.Tables(DsArticulosActualizacion1.dsdtArticulosActualizar.TableName.ToString).Merge(dt)
                Else
                    mMensajes.msg_Informacion("El Código " & codigo & " no fue encontrado en nuestra base de datos!")
                End If
            Next
        End If
#End Region
    End Sub

    Private Sub btnElSalvadorArticulos_Click(sender As Object, e As EventArgs) Handles btnElSalvadorArticulos.Click
        Try
            Dim dt As New DataTable("dtArticulosActualizar")
            dt = mSQLSelect.GET_ArticulosAR_ElSalvador()

            If dt.Rows.Count = Nothing Then
                slueCodigoArticulo.EditValue = String.Empty
                Exit Sub
            End If

            DsArticulosActualizacion1.Tables(DsArticulosActualizacion1.dsdtArticulosActualizar.TableName.ToString).Clear()
            DsArticulosActualizacion1.Tables(DsArticulosActualizacion1.dsdtArticulosActualizar.TableName.ToString).Merge(dt)
            grdArticulosActualizar.Focus()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub slueCodigoArticulo_EditValueChanged(sender As Object, e As EventArgs) Handles slueCodigoArticulo.EditValueChanged

    End Sub

    Private Sub btnCostaRicaArticulos_Click(sender As Object, e As EventArgs) Handles btnCostaRicaArticulos.Click
        Try
            Dim dt As New DataTable("dtArticulosActualizar")
            dt = mSQLSelect.GET_ArticulosAR_CostaRica()

            If dt.Rows.Count = Nothing Then
                slueCodigoArticulo.EditValue = String.Empty
                Exit Sub
            End If

            DsArticulosActualizacion1.Tables(DsArticulosActualizacion1.dsdtArticulosActualizar.TableName.ToString).Clear()
            DsArticulosActualizacion1.Tables(DsArticulosActualizacion1.dsdtArticulosActualizar.TableName.ToString).Merge(dt)
            grdArticulosActualizar.Focus()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    'Mod 06/02/2024
    Private Sub btnMexicoArticulos_Click(sender As Object, e As EventArgs) Handles btnMexicoArticulos.Click
        Try
            Dim dt As New DataTable("dtArticulosActualizar")
            dt = mSQLSelect.GET_ArticulosAR_Mexico()

            If dt.Rows.Count = Nothing Then
                slueCodigoArticulo.EditValue = String.Empty
                Exit Sub
            End If

            DsArticulosActualizacion1.Tables(DsArticulosActualizacion1.dsdtArticulosActualizar.TableName.ToString).Clear()
            DsArticulosActualizacion1.Tables(DsArticulosActualizacion1.dsdtArticulosActualizar.TableName.ToString).Merge(dt)
            grdArticulosActualizar.Focus()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class