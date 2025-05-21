Public Class frmListaPreciosCostosActualizar

    Private Sub frmListaPreciosCostosActualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Sub_Seguridad()
            Sub_CodigosPadres()
            Sub_CodigosPadresOtros()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub Sub_CodigosPadresOtros()
        Try
            mFunciones.FCN_FILL_SearchLookUpEdit(slueCodigoPadre, mSQLSelect.GET_Catalogo_AR_CP_CC_Padres(), "CodigoArticulo", "CodigoArticulo")



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Seguridad()
        Try
            mSeguridad.APG_Seguridad(Me, barbtnActualizarArticulo)
            mSeguridad.APG_Seguridad(Me, barbtnActualizarComponente)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub Sub_CodigosPadres()
        Try
            Dim dt As New DataTable("dtCodigosPadres")
            dt = mSQLSelect.GET_ListaPreciosActualizar_CodigosPadres()

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtCodigosPadres.TableName.ToString).Clear()
            DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtCodigosPadres.TableName.ToString).Merge(dt)


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub Sub_CodigosHijos()
        Try

            Dim pCodigoPadre As String = String.Empty

            'validacion Inicio--------------------------
            If grdviewCodigosPadre.RowCount = Nothing Then
                Exit Sub
            End If
            If grdviewCodigosPadre.FocusedRowHandle < 0 Then
                DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtCodigosHijos.TableName.ToString).Clear()
                Exit Sub
            End If
            'Validacion Final---------------------------

            pCodigoPadre = mFunciones.FCN_GetCellValue(grdviewCodigosPadre, "CodigoPadre", grdviewCodigosPadre.FocusedRowHandle)

            If pCodigoPadre = Nothing Then
                Exit Sub
            End If

            Dim dt As New DataTable("dtCodigosHijos")
            dt = mSQLSelect.GET_ListaPreciosActualizar_CodigosHijos(pCodigoPadre)

            If dt.Rows.Count = Nothing Then
                DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtCodigosHijos.TableName.ToString).Clear()
                DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtListaMateriales.TableName.ToString).Clear()
                Exit Sub
            End If


            DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtCodigosHijos.TableName.ToString).Clear()
            DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtCodigosHijos.TableName.ToString).Merge(dt)

            If Not grdviewCodigosHijos.RowCount = Nothing Then
                grdviewCodigosHijos.UnselectRow(0)
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub Sub_ListaMateriales()
        Try

            Dim pCodigoHijo As String = String.Empty

            'validacion Inicio--------------------------
            If grdviewCodigosHijos.RowCount = Nothing Then
                Exit Sub
            End If
            If grdviewCodigosHijos.FocusedRowHandle < 0 Then
                DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtListaMaterialesCP.TableName.ToString).Clear()
                DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtListaMateriales.TableName.ToString).Clear()

                Exit Sub
            End If
            'Validacion Final---------------------------

            pCodigoHijo = mFunciones.FCN_GetCellValue(grdviewCodigosHijos, "CodigoArticulo", grdviewCodigosHijos.FocusedRowHandle)

            If pCodigoHijo = Nothing Then
                Exit Sub
            End If

            Dim dt As New DataTable("dtCodigosHijos")
            dt = mSQLSelect.GET_ListaPreciosActualizar_ListaMateriales(pCodigoHijo)

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtListaMaterialesCP.TableName.ToString).Clear()
            DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtListaMateriales.TableName.ToString).Clear()
            DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtListaMateriales.TableName.ToString).Merge(dt)


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_ListaMaterialesCP()
        Try

            Dim pCodigoHijo As String = String.Empty

            'validacion Inicio--------------------------
            If grdviewListaMateriales.RowCount = Nothing Then
                Exit Sub
            End If
            If grdviewListaMateriales.FocusedRowHandle < 0 Then
                DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtListaMaterialesCP.TableName.ToString).Clear()
                Exit Sub
            End If
            'Validacion Final---------------------------

            'ValidarBotonActualizar
            Dim pCodigoComponente As String = mFunciones.FCN_GetCellValue(grdviewListaMateriales, "Componente", grdviewListaMateriales.FocusedRowHandle)
            Dim pCantidad As String = mFunciones.FCN_GetCellValue(grdviewListaMateriales, "Cantidad", grdviewListaMateriales.FocusedRowHandle)


            If pCodigoComponente.Substring(0, 2) = "CP" And pCantidad = "1.000000" Then
                mSeguridad.APG_Seguridad(Me, barbtnActualizarComponente)
            Else
                barbtnActualizarComponente.Enabled = False
            End If
            'final

            If pCodigoComponente.Substring(0, 2) = "CP" Or pCodigoComponente.Substring(0, 2) = "AR" Then
                barbtnAgregarGrupoRastreo.Enabled = True
            Else
                barbtnAgregarGrupoRastreo.Enabled = False
            End If


            pCodigoHijo = mFunciones.FCN_GetCellValue(grdviewListaMateriales, "Componente", grdviewListaMateriales.FocusedRowHandle)

            If pCodigoHijo = Nothing Then
                Exit Sub
            End If

            Dim dt As New DataTable("dtCodigosHijosCP")
            dt = mSQLSelect.GET_ListaPreciosActualizar_ListaMateriales(pCodigoHijo)

            If dt.Rows.Count = Nothing Then
                DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtListaMaterialesCP.TableName.ToString).Clear()
                Exit Sub
            End If

            DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtListaMaterialesCP.TableName.ToString).Clear()
            DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtListaMaterialesCP.TableName.ToString).Merge(dt)


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub



    Private Sub grdviewCodigosPadre_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdviewCodigosPadre.FocusedRowChanged
        Try
            Sub_CodigosHijos()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewCodigosHijos_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdviewCodigosHijos.FocusedRowChanged
        Try
            Sub_ListaMateriales()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub grdviewListaMateriales_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdviewListaMateriales.FocusedRowChanged
        Try
            Sub_ListaMaterialesCP()


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnActualizarArticulo.ItemClick
        Try
            Dim pRow As Integer = Nothing
            pRow = grdviewCodigosHijos.FocusedRowHandle()

            If grdviewCodigosHijos.RowCount = Nothing Then
                Exit Sub
            End If

            Dim pArticulos As Integer = grdviewCodigosHijos.SelectedRowsCount()

            If MsgBox("Desea actualizar los Costos de " + pArticulos.ToString + " Articulos?", MsgBoxStyle.YesNo, "Actualizar Lista Precios") = MsgBoxResult.No Then
                Exit Sub
            End If

            Dim dt As New DataTable("dtArticulosActualizar")
            dt = DsListaPreciosCostosActualizar1.dsdtCodigosHijos

            For i = 0 To grdviewCodigosHijos.RowCount - 1
                If grdviewCodigosHijos.IsRowSelected(i) = True Then
                    For j = 0 To dt.Rows.Count - 1
                        If dt.Rows(j)("CodigoArticulo").ToString = mFunciones.FCN_GetCellValue(grdviewCodigosHijos, "CodigoArticulo", i) Then
                            dt.Rows(j)("Actualizar") = "SI"
                        End If
                    Next
                Else
                End If
            Next

            If Not ssmEsperar.IsSplashFormVisible Then
                ssmEsperar.ShowWaitForm()
            End If


            SAP_DIAPI_ActualizarListaPrecios_Costos(dt, ssmEsperar)

            For I = 0 To dt.Rows.Count - 1
                If dt.Rows(I)("Actualizar").ToString = "SI" Then
                    'ACTUALIZACION DE LISTA DE MATERIALES EN BASE DE DATOS ---------------------------------
                    ssmEsperar.SetWaitFormDescription("Actualizando Lista Materiales...") ' SPLASH ------------
                    mDIAPI.SAP_DIAPI_ListaMateriales_Actualizar(dt(I)("CodigoArticulo").ToString)
                    'FINALIZA ACTUALIZACION DE LISTA DE MATERIALES
                End If
            Next

            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If


            'PROCEDIMIENTO ESPERAR
            'If SAP_DIAPI_ActualizarListaPrecios_Costos(dt, ssmEsperar) = True Then

            '    mMensajes.msg_Informacion("Se a completado exitosamente la actualización de Costos!")
            'End If

            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If

            Sub_CodigosHijos()
            grdviewCodigosHijos.SelectRow(pRow)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            
        End Try
    End Sub

    Private Sub barbtnActualizar2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnActualizarComponente.ItemClick
        Try
            If grdviewListaMaterialesCP.RowCount = Nothing Then
                Exit Sub
            End If

            Dim pArticulos As Integer = grdviewListaMateriales.SelectedRowsCount()

            Dim pCodigoArticulo As String = mFunciones.FCN_GetCellValue(grdviewListaMateriales, "Componente", grdviewListaMateriales.FocusedRowHandle)
            Dim pPrecioCosto As String = mFunciones.FCN_GetCellValue(grdviewListaMateriales, "CostoTotal", grdviewListaMateriales.FocusedRowHandle)

            If MsgBox("Desea actualizar el Componente [ " + pCodigoArticulo.ToString + " ] por un Costo de [" + pPrecioCosto + "]?", MsgBoxStyle.YesNo, "Actualizar Lista Precios") = MsgBoxResult.No Then
                Exit Sub
            End If

            If Not ssmEsperar.IsSplashFormVisible Then
                ssmEsperar.ShowWaitForm()
            End If


            If SAP_DIAPI_ActualizarListaPrecios_Costos(pCodigoArticulo, pPrecioCosto, ssmEsperar) = True Then
                If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
                mMensajes.msg_Informacion("Se a completado exitosamente la actualización de Costos!")
            End If

            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
            Sub_CodigosHijos()
        End Try
    End Sub

    Private Sub slueCodigoPadre_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles slueCodigoPadre.EditValueChanging
        Try

            If e.NewValue = Nothing Then
                e.Cancel = True
                Exit Sub
            End If

            Dim dt As New DataTable("dtCodigosPadres")
            dt = mSQLSelect.GET_ListaPreciosActualizar_CodigosPadres("'" + e.NewValue.ToString + "'")

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            If MsgBox("Desea AGREGAR el codigo " + e.NewValue.ToString + " A la lista?", MsgBoxStyle.YesNo, "Agregar") = MsgBoxResult.Yes Then
                DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtCodigosPadres.TableName.ToString).Merge(dt)
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            e.Cancel = True
        End Try
    End Sub

    Private Sub grdviewListaMateriales_DoubleClick(sender As Object, e As EventArgs) Handles grdviewListaMateriales.DoubleClick
        Try

            Dim pCodigoArticulo As String = String.Empty
            pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewListaMateriales, "Componente").Substring(0, 8)
            If pCodigoArticulo = String.Empty Then
                Exit Sub
            End If

            Dim dt As New DataTable("dtCodigosPadres")
            dt = mSQLSelect.GET_ListaPreciosActualizar_CodigosPadres("'" + pCodigoArticulo + "'")

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            If MsgBox("Desea AGREGAR el codigo " + pCodigoArticulo + " A la lista?", MsgBoxStyle.YesNo, "Agregar") = MsgBoxResult.Yes Then
                DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtCodigosPadres.TableName.ToString).Merge(dt)
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnAbrirExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAbrirExcel.ItemClick
        Try

            Dim pRuta As String = String.Empty


            ofdAbrir.FileName = Nothing
            ofdAbrir.Title = "Abrir Archivo"
            ofdAbrir.Filter = "Archivos Excel | *.xlsx; *.xls"
            If ofdAbrir.ShowDialog() = Windows.Forms.DialogResult.OK Then
                pRuta = ofdAbrir.FileName.ToString
            Else
                Exit Sub
            End If

            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            Dim dt As New DataTable()
            MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0; Data Source='" + pRuta + "'; Extended Properties=Excel 12.0 xml;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Plantilla$]", MyConnection)
            MyCommand.Fill(dt)
            MyConnection.Close()

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            If Not grdviewListaMateriales.RowCount = Nothing Then
            End If

            For i = 0 To dt.Rows.Count - 1
                dt.Rows(i)("NombrePadre") = mSQLSelect.GET_Articulo("'" + dt.Rows(i)("CodigoPadre").ToString + "'").Rows(0)("NombreArticulo").ToString
            Next


            '    If MsgBox("Desea borrar los Articulos que actualmente estan en la Lista?", MsgBoxStyle.YesNo, "Eliminar") = MsgBoxResult.Yes Then
            '        DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtCodigosPadres.TableName.ToString).Clear()
            '    End If
            'End If




            DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtCodigosPadres.TableName.ToString).Merge(dt)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub barbtnDescargarPlantilla_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDescargarPlantilla.ItemClick
        Try

            If sfdSave.ShowDialog() = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.CopyFile(Application.StartupPath.ToString + "\Plntll\Plantilla_ListaCostos_Borrar.xlsx",
                                                sfdSave.FileName + ".xlsx",
                                                Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                                                Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

                mMensajes.msg_Informacion("Archivo Descargado en ." + Environment.NewLine + sfdSave.FileName + ".xlsx")
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub grdCodigosHijos_Click(sender As Object, e As EventArgs) Handles grdCodigosHijos.Click

    End Sub

    Private Sub barbtnAgregarGrupoRastreo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAgregarGrupoRastreo.ItemClick
        Try

            If grdviewListaMateriales.RowCount = Nothing Then : Exit Sub : End If

            Dim pCodigo As String = String.Empty
            pCodigo = grdviewListaMateriales.GetRowCellValue(grdviewListaMateriales.FocusedRowHandle, "Componente")

            If pCodigo = String.Empty Then : Exit Sub : End If
            pCodigo = pCodigo.ToString.Substring(0, 8)



            Dim dt As New DataTable("dtCodigosPadres")
            dt = mSQLSelect.GET_ListaPreciosActualizar_CodigosPadres("'" + pCodigo + "'")

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            If MsgBox("Desea AGREGAR el codigo " + pCodigo + " A la lista?", MsgBoxStyle.YesNo, "Agregar") = MsgBoxResult.Yes Then
                DsListaPreciosCostosActualizar1.Tables(DsListaPreciosCostosActualizar1.dsdtCodigosPadres.TableName.ToString).Merge(dt)
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class