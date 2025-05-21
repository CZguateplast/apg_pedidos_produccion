
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.GridControl
Imports DevExpress.Xpo
Imports System.IO

Public Class frmMantenimientoArticulos

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnCargarImagen_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCargarImagen.ItemClick
        Try
            ofdImagen.FileName = ""
            ofdImagen.Title = "Abrir Archivo"
            ofdImagen.Filter = "Imagen JPG|*.jpg"

            If ofdImagen.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtImagenNombre.EditValue = ofdImagen.SafeFileName.ToString
                txtImagenRutaOrigen.EditValue = ofdImagen.FileName.ToString
                txtExtension.EditValue = Path.GetExtension(ofdImagen.FileName.ToString)
                picArticulo.Image = Image.FromFile(ofdImagen.FileName.ToString)
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnGrabarImagen_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnGrabarImagen.ItemClick
        Try
            If txtImagenRutaOrigen.EditValue.ToString = String.Empty Then
                mMensajes.msg_Informacion("Debe seleccionar una imagen para cargar. Intente de Nuevo")
            ElseIf txtImagenRutaDestino.EditValue.ToString = String.Empty Then
                mMensajes.msg_Informacion("No existe ruta de Destino." + Environment.NewLine + "Seleccione una carpeta de Destino!")
            Else
                My.Computer.FileSystem.CopyFile(txtImagenRutaOrigen.EditValue.ToString,
                                                txtImagenRutaDestino.EditValue.ToString + txtCodigoPadre.EditValue.ToString + txtExtension.EditValue.ToString,
                                                Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                                                Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                mMensajes.msg_Proceso_ok()
            End If



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmMantenimientoArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mFunciones.FCN_FILL_SearchLookUpEdit(slueColorAgregar, mSQLSelect.GET_Catalogo_Colores(), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueCodigoArticulo, mSQLSelect.GET_OITM_Hijos(), "CodigoArticulo", "CodigoArticulo")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueBodega, mSQLSelect.GET_Listado_Bodegas(), "Id", "Nombre")

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub slueColorAgregar_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles slueColorAgregar.EditValueChanging
        Try
            If e.NewValue = Nothing Then
                Exit Sub
            End If

            Dim dtColores As New DataTable()
            dtColores = mSQLSelect.GET_Catalogo_Colores(e.NewValue.ToString)

            If dtColores.Rows.Count = Nothing Then
                Exit Sub
            End If

            If MsgBox("Desea Agregar el Articulo en color < " + dtColores.Rows(0)("Id").ToString + " = " + dtColores.Rows(0)("Nombre").ToString + " > "" ?", vbYesNo, "Agregar") = MsgBoxResult.No Then
                Exit Sub
            End If

            Dim Row As DataRow
            Row = DsMantenimientoArticulos1.dsdtColores.NewRow()
            Row("Id") = dtColores.Rows(0)("Id").ToString
            Row("Nombre") = dtColores.Rows(0)("Nombre").ToString
            DsMantenimientoArticulos1.dsdtColores.Rows.Add(Row)

            e.Cancel = True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            e.Cancel = True
        End Try
    End Sub

    Private Sub txtCodigoPadre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCodigoPadre.Validating
        Try
            If txtCodigoPadre.EditValue = Nothing Then
                Alerta1.AutoFormDelay = 30000
                Alerta1.Show(Me, "Nueva Alerta", "Debe de ingresar un Codigo Padre para Continuar")
                Exit Sub
            End If

            Dim dtCodigoPadre As New DataTable()

            dtCodigoPadre = mSQLSelect.Validar_CodigoPadre(txtCodigoPadre.EditValue.ToString)

            If dtCodigoPadre.Rows.Count = Nothing Then
                'NO EXISTE EL CODIGO
                If MsgBox("El codigo < " + txtCodigoPadre.EditValue.ToString + " > no existe en la base de datos. " + Environment.NewLine + " Desea crear un nuevo codigo", _
                          MsgBoxStyle.YesNo, _
                          "Agregar") = MsgBoxResult.Yes Then
                    mMensajes.msg_Informacion("SI")
                    txtCodigoPadre.Enabled = False
                    Exit Sub
                Else
                    mMensajes.msg_Informacion("NO")
                End If

            Else
                'SI EXISTE EL CODIGO
                txtCodigoPadre.Enabled = False
                Dim dtColores As New DataTable()

                'FILL COLORES
                dtColores = GET_Colores(txtCodigoPadre.EditValue.ToString)
                If Not dtColores.Rows.Count = Nothing Then
                    DsMantenimientoArticulos1.Tables(DsMantenimientoArticulos1.dsdtColores.TableName.ToString).Clear()
                    DsMantenimientoArticulos1.Tables(DsMantenimientoArticulos1.dsdtColores.TableName.ToString).Merge(dtColores)
                End If
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            e.Cancel = True
        End Try
    End Sub

    Private Sub grdviewCodigosHijos_DoubleClick(sender As Object, e As EventArgs) Handles grdviewCodigosHijos.DoubleClick
        Try
            'Validacion Inicio  -----------------
            Dim pColor As String = mFunciones.FCN_GetCellValue(grdviewCodigosHijos, "Id")
            If pColor = Nothing Then
                Exit Sub
            End If

            Dim pCodigoHijo As String = "'" + txtCodigoPadre.EditValue + "-" + pColor + "-0'"
            'Validacion Fin ---------------------

            'Variables
            Dim dtOITM As New DataTable()
            Dim dtITT1 As New DataTable()

            'LISTA DE MATERIALES ----------------
            dtITT1 = mSQLSelect.GET_ListaMateriales(pCodigoHijo)

            If Not dtITT1.Rows.Count = Nothing Then
                DsMantenimientoArticulos1.Tables(DsMantenimientoArticulos1.dsdtListaMateriales.TableName.ToString).Clear()
                DsMantenimientoArticulos1.Tables(DsMantenimientoArticulos1.dsdtListaMateriales.TableName.ToString).Merge(dtITT1)
            Else
                DsMantenimientoArticulos1.Tables(DsMantenimientoArticulos1.dsdtListaMateriales.TableName.ToString).Clear()
            End If



            'ALMACEN CODIGO BARRAS --------------

            dtOITM = mSQLSelect.GETALL_OITM(pCodigoHijo)

            If dtOITM.Rows.Count = Nothing Then
                Exit Sub
            End If

            txtCodigoBarras.EditValue = dtOITM.Rows(0)("CodeBars").ToString
            txtUPC.EditValue = dtOITM.Rows(0)("U_Upc").ToString
            txtDUN14.EditValue = dtOITM.Rows(0)("U_Dun_14").ToString
            txtStockMaximo.EditValue = Convert.ToInt32(dtOITM.Rows(0)("MaxLevel"))
            txtStockMinimo.EditValue = Convert.ToInt32(dtOITM.Rows(0)("MinLevel"))
            txtLocalizacionDel.EditValue = dtOITM.Rows(0)("U_LocalizacionBodega").ToString

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub txtCodigoBarras_EditValueChanged(sender As Object, e As EventArgs) Handles txtCodigoBarras.EditValueChanged
        Try
            bccCodigoBarras.Text = txtCodigoBarras.EditValue
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub txtDUN14_EditValueChanged(sender As Object, e As EventArgs) Handles txtDUN14.EditValueChanged
        Try
            bccDUN14.Text = txtDUN14.EditValue
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewListaMaterialesHijos_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles grdviewListaMaterialesHijos.CellValueChanged
        Try
            If e.Column.FieldName = "CodigoArticulo" Then
                Dim dtOITM As New DataTable()

                dtOITM = mSQLSelect.GET_OITM("'" + e.Value + "'")

                If dtOITM.Rows.Count = Nothing Then
                    Exit Sub
                End If

                grdviewListaMaterialesHijos.SetRowCellValue(e.RowHandle, "NombreArticulo", dtOITM.Rows(0)("ItemName").ToString)
                grdviewListaMaterialesHijos.SetRowCellValue(e.RowHandle, "Bodega", dtOITM.Rows(0)("DfltWH").ToString)

            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub grdviewListaMaterialesHijos_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles grdviewListaMaterialesHijos.InitNewRow
        Try
            Dim pCodigoPadre As String = txtCodigoPadre.EditValue
            Dim pColor As String = mFunciones.FCN_GetCellValue(grdviewCodigosHijos, "Id")
            Dim pNumLinea As Integer = grdviewListaMaterialesHijos.RowCount + 1
            Dim view As GridView = CType(sender, GridView)

            view.SetRowCellValue(e.RowHandle, view.Columns("Padre"), pCodigoPadre + "-" + pColor + "-0")
            view.SetRowCellValue(e.RowHandle, view.Columns("NumLinea"), pNumLinea)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewListaMaterialesHijos_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles grdviewListaMaterialesHijos.CellValueChanging
        Try
            If e.Column.FieldName = "CodigoArticulo" Then
                Dim dtOITM As New DataTable()

                dtOITM = mSQLSelect.GET_OITM("'" + e.Value + "'")

                If dtOITM.Rows.Count = Nothing Then
                    Exit Sub
                End If

                grdviewListaMaterialesHijos.SetRowCellValue(e.RowHandle, "NombreArticulo", dtOITM.Rows(0)("ItemName").ToString)
                grdviewListaMaterialesHijos.SetRowCellValue(e.RowHandle, "Bodega", dtOITM.Rows(0)("DfltWH").ToString)

            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnAsignarDUN14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            txtDUN14.EditValue = mFunciones.FCN_DUN14(txtUPC.EditValue)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnAsignarCodigoBarras_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            If txtUPC.EditValue = Nothing Then
                mMensajes.msg_Error("Debe de haber un UPC asignado en la casilla")
                Exit Sub
            End If
            txtCodigoBarras.EditValue = mFunciones.FCN_CODIGOBARRAS(txtUPC.EditValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub barbtnAsignarUPC_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAsignarUPC.ItemClick
        Try
            'Variables
            Dim pUPCDisponible As String = mFunciones.FCN_UPC_Disponible()
            Dim pUPC As String = String.Empty
            Dim pCodigoBarras As String = String.Empty
            Dim pDUN14 As String = String.Empty

            'Validar
            If pUPCDisponible = String.Empty Then
                Exit Sub
            End If

            'ValidarExistencia de UPC
            If Not txtUPC.EditValue = Nothing And Len(txtUPC.EditValue) = 6 Then
                If MsgBox("Existe un UPC Asignado para este Articulo!" + Environment.NewLine + Environment.NewLine + "Desea corregir el <Codigo de Barras> y el < DUN14 > ?", MsgBoxStyle.YesNo, "?") = MsgBoxResult.No Then
                    If MsgBox("Desea sobrescribir el < UPC > actual, por un NUEVO codigo de UPC?", MsgBoxStyle.YesNo, "?") = MsgBoxResult.Yes Then
                        'GenerarUPC
                        pUPC = mFunciones.FCN_UPC(pUPCDisponible)
                        txtUPC.EditValue = pUPC

                        'GenerarBARRAS
                        pCodigoBarras = mFunciones.FCN_CODIGOBARRAS(pUPC)
                        txtCodigoBarras.EditValue = pCodigoBarras

                        'GenerarDUN14
                        pDUN14 = mFunciones.FCN_DUN14(pUPC)
                        txtDUN14.EditValue = pDUN14
                    Else
                        Exit Sub
                    End If
                Else
                    'GenerarBARRAS
                    pCodigoBarras = mFunciones.FCN_CODIGOBARRAS(txtUPC.EditValue.ToString)
                    txtCodigoBarras.EditValue = pCodigoBarras

                    'GenerarDUN14
                    pDUN14 = mFunciones.FCN_DUN14(txtUPC.EditValue.ToString)
                    txtDUN14.EditValue = pDUN14
                End If

                
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnListaMateriales_CopiarDe_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnListaMateriales_CopiarDe.ItemClick
        Try
            Dim pDT As New DataTable()
            Dim pCodigo As String = String.Empty

            pDT = mSQLSelect.GETALL_OITM_Basico()
            frmTemporal_Lista.ppTabla = pDT
            frmTemporal_Lista.lycId.Text = "CodigoArticulo"
            frmTemporal_Lista.ShowDialog()
            If frmTemporal_Lista.ppResultado = Nothing Then
                Exit Sub
            End If

            pCodigo = frmTemporal_Lista.ppResultado

            'Variables
            Dim dtOITM As New DataTable()
            Dim dtITT1 As New DataTable()

            'LISTA DE MATERIALES ----------------
            dtITT1 = mSQLSelect.GET_ListaMateriales("'" + pCodigo + "'")

            If Not dtITT1.Rows.Count = Nothing Then
                If MsgBox("Desea borrar la lista de materiales en pantalla?", MsgBoxStyle.YesNo, "Lista Materiales") = MsgBoxResult.Yes Then
                    DsMantenimientoArticulos1.Tables(DsMantenimientoArticulos1.dsdtListaMateriales.TableName.ToString).Clear()
                    DsMantenimientoArticulos1.Tables(DsMantenimientoArticulos1.dsdtListaMateriales.TableName.ToString).Merge(dtITT1)
                Else
                    DsMantenimientoArticulos1.Tables(DsMantenimientoArticulos1.dsdtListaMateriales.TableName.ToString).Merge(dtITT1)
                End If
            Else
                mMensajes.msg_Informacion("No existe Lista de Materiales para Cargar del Articulo <" + pCodigo + " >")
            End If



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnActualizarListaMateriales.ItemClick
        Dim pDT As New DataTable()
        Dim pCodigo As String = String.Empty

        pDT = mSQLSelect.GET_Listado_Moldes()
        frmTemporal_Lista.ppTabla = pDT
        frmTemporal_Lista.lycId.Text = "CodigoArticulo"
        frmTemporal_Lista.ShowDialog()
        If frmTemporal_Lista.ppResultado = Nothing Then
            Exit Sub
        End If

    End Sub

    Private Sub barbtnVentasEstadisticas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnVentasEstadisticas.ItemClick
        Try

            vpCodigoArticulo = "'" + txtCodigoPadre.EditValue + "-" + mFunciones.FCN_GetCellValue(grdviewCodigosHijos, "Id") + "-0'"
            frmTemporal_AnalisisVenta.ShowDialog()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub picArticulo_EditValueChanged(sender As Object, e As EventArgs) Handles picArticulo.EditValueChanged

    End Sub

    Private Sub XtraTabControl1_Click(sender As Object, e As EventArgs) Handles xtcMantenimientoPadre.Click

    End Sub

    Private Sub xtcMantenimientoPadre_SelectedPageChanging(sender As Object, e As DevExpress.XtraTab.TabPageChangingEventArgs) Handles xtcMantenimientoPadre.SelectedPageChanging
        Try
            If e.Page.Name = xtpVentas.Name Then
                mFunciones.FCN_FILL_SearchLookUpEdit(slueP_GrupoArticulos, mSQLSelect.GET_Catalogo_GrupoArticulos(), "Id", "Nombre")

            ElseIf e.Page.Name = xtpIngenieria.Name Then
                mFunciones.FCN_FILL_SearchLookUpEdit(slueMaterialEmpaqueEstandar, mSQLSelect.GET_Catalogo_CC_Hijos(), "CodigoArticulo", "CodigoArticulo")
                mFunciones.FCN_FILL_SearchLookUpEdit(slueMaterialEmpaqueMaster, mSQLSelect.GET_Catalogo_CC_Hijos(), "CodigoArticulo", "CodigoArticulo")
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub xtc_Hijos_Click(sender As Object, e As EventArgs) Handles xtc_Hijos.Click

    End Sub
End Class