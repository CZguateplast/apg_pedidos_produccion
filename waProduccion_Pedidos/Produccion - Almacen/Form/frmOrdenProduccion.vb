Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.GridControl
Public Class frmOrdenProduccion

#Region "Carga Inicial"
    Private Sub frmIngresoAnalisisCP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ValoresDefault()
        Sub_Seguridad_APG()

    End Sub
    Private Sub Sub_Seguridad_APG()
        Try
            mSeguridad.APG_Seguridad(Me, barbtnStock)
            mSeguridad.APG_Seguridad(Me, barbtnProduccion)
            mSeguridad.APG_Seguridad(Me, barbtnDeudaEnsamble)
            mSeguridad.APG_Seguridad(Me, barbtnSAP)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

#End Region
    Private Sub ValoresDefault()
        Try
            mSeguridad.APG_Seguridad(Me, barbtnStock)
            mSeguridad.APG_Seguridad(Me, barbtnDeudaEnsamble)
            mSeguridad.APG_Seguridad(Me, barbtnProduccion)
            mSeguridad.APG_Seguridad(Me, barbtnSAP)


            mFunciones.FCN_FILL_SearchLookUpEdit(slueCodigosProducidosPadres, GET_Listado_ArticuloCP2(), "CodigoArticulo", "CodigoArticulo")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueOrigen, mSQLSelect.GET_PROD_CatListados("Orden_Origen"), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueDestino, mSQLSelect.GET_Listado_Bodegas(), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueColores, mSQLSelect.GET_Catalogo_Colores(), "Id", "Id")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueGrupoCliente, mSQLSelect.GET_Listado_GrupoClientes(), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueCodigoCliente, mSQLSelect.GET_Catalogo_ClientesDisponibles(), "CodigoCliente", "CodigoCliente")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueNumOrdenVenta, mSQLSelect.GET_Listado_OrdenesVentaDisponibles(), "NumOrden", "NumOrden")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueNumCampana, mSQLSelect.GET_Listado_CampanaVigentes, "Id", "Id")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
#Region "Grid Horizontal"
    Private Sub slueCodigosProducidosPadres_EditValueChanged(sender As Object, e As EventArgs) Handles slueCodigosProducidosPadres.EditValueChanged
        Try
            If slueCodigosProducidosPadres.EditValue = String.Empty Then
                DsIngresoAnalisisCP1.Tables("dsdtIngresoAnalisisCP").Clear()
            Else
                Dim dt As New DataTable()

                dt = GET_AnalisisCP(slueCodigosProducidosPadres.EditValue)

                DsIngresoAnalisisCP1.Tables("dsdtIngresoAnalisisCP").Clear()
                DsIngresoAnalisisCP1.Tables("dsdtIngresoAnalisisCP").Merge(dt)
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub grdviewArticulos_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdviewArticulos.CellValueChanged
        Try
            'Validate(True)

            If e.Column.FieldName = "CodigoCliente" Then

                Dim dt As New DataTable
                Dim CodigoCliente As String = grdviewArticulos.GetRowCellValue(e.RowHandle, "CodigoCliente")
                dt = mSQLSelect.GET_Listado_ClientesDisponibles(CodigoCliente)
                If dt.Rows.Count = Nothing Then
                    grdviewArticulos.SetRowCellValue(grdviewArticulos.FocusedRowHandle, "NombreCliente", "")
                Else
                    grdviewArticulos.SetRowCellValue(grdviewArticulos.FocusedRowHandle, "NombreCliente", dt.Rows(0)("NombreCliente").ToString)
                End If
            ElseIf e.Column.FieldName = "NumOrden" Then
                Dim dt As New DataTable
                Dim NumeroOrden As String = grdviewArticulos.GetRowCellValue(e.RowHandle, "NumOrden")
                dt = mSQLSelect.GET_Listado_OrdenesVentaDisponibles(NumeroOrden)
                If dt.Rows.Count = Nothing Then
                    grdviewArticulos.SetRowCellValue(grdviewArticulos.FocusedRowHandle, "NombreCliente", "")
                    grdviewArticulos.SetRowCellValue(grdviewArticulos.FocusedRowHandle, "CodigoCliente", "")
                Else
                    grdviewArticulos.SetRowCellValue(grdviewArticulos.FocusedRowHandle, "NombreCliente", dt.Rows(0)("NombreCliente").ToString)
                    grdviewArticulos.SetRowCellValue(grdviewArticulos.FocusedRowHandle, "CodigoCliente", dt.Rows(0)("CodigoCliente").ToString)
                End If
            ElseIf e.Column.FieldName = "NumCampana" Then
                Dim dt As New DataTable
                Dim NumeroCampana As String = grdviewArticulos.GetRowCellValue(e.RowHandle, "NumCampana")
                dt = mSQLSelect.GET_Listado_CampanaVigentes(NumeroCampana)
                If dt.Rows.Count = Nothing Then
                    grdviewArticulos.SetRowCellValue(grdviewArticulos.FocusedRowHandle, "NombreCampana", "")
                Else
                    grdviewArticulos.SetRowCellValue(grdviewArticulos.FocusedRowHandle, "NombreCampana", dt.Rows(0)("NombreCampana").ToString)
                End If

            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub grdCodigoProducidosHijos_DoubleClick(sender As Object, e As EventArgs) Handles grdCodigoProducidosHijos.DoubleClick
        Try
            Dim pCodigoArticulo As String = FCN_XTRAGRID_GetFilasSeleccionadas(grdviewCodigosProducidosHijos, "CodigoArticulo")

            If Not mFunciones.FCN_ValidarDisponiblidad_CP(pCodigoArticulo, Me.Name.ToString) Then
                Exit Sub
            End If


            If Not txtCodigoArticulo.EditValue = String.Empty Then
                If mMensajes.msg_ActualizarConDatosSinGuardar() Then
                    DsIngresoAnalisisCP1.Tables("dsdtIngresoOrdenes").Clear()
                Else
                    Exit Sub
                End If
            End If
            'Agregar los Campos para las ordenes de Fabricacion



            txtCodigoArticulo.EditValue = FCN_XTRAGRID_GetFilasSeleccionadasSinApostrofes(grdviewCodigosProducidosHijos, "CodigoArticulo")
            txtNombreArticulo.EditValue = FCN_XTRAGRID_GetFilasSeleccionadasSinApostrofes(grdviewCodigosProducidosHijos, "NombreArticulo")
            txtDeLinea.EditValue = FCN_XTRAGRID_GetFilasSeleccionadasSinApostrofes(grdviewCodigosProducidosHijos, "DeLinea")

            'limpiar el dataSet del grid
            DsIngresoAnalisisCP1.Tables("dsdtIngresoOrdenes").Clear()

            'enabled
            barbtnSAP.Enabled = True
            mmeComentarios.Enabled = True
            grdIngresoOrdenes.Enabled = True
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub GenerarOrden_Encabezado()
        Try
            Dim pArrayList As New ArrayList
            pArrayList.Add(txtCodigoArticulo.EditValue) '0
            pArrayList.Add("0") '1
            pArrayList.Add("0") '2
            pArrayList.Add("0") '3
            pArrayList.Add("0") '4
            pArrayList.Add("0") '5
            pArrayList.Add("0") '6
            pArrayList.Add("0") '7
            pArrayList.Add("0") '8
            pArrayList.Add("0") '9
            pArrayList.Add(mmeComentarios.Text) '10
            INSERT_Ordenes_Encabezado(pArrayList)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub Set_InformacionDB()
        Try
            GenerarOrden_Encabezado()

            Dim dt As New DataTable("dtOrdenesAR")
            Dim Row As DataRow
            Dim IdTrans As Integer = 0

            dt = mSQLSelect.GET_PROD_Ordenes_Encabezado() 'Crear la Tabla
            IdTrans = mSQLSelect.GET_PROD_IdTransaccion()

            For i = 0 To grdviewArticulos.RowCount - 1
                If Not grdviewArticulos.GetRowCellValue(i, "Cantidad").ToString = String.Empty Then ''Or grdviewArticulos.GetRowCellValue(i, "CantidadEnsamble").ToString > 1 Then

                    Row = dt.NewRow()
                    Row("Id") = IdTrans
                    Row("Id_nivel1") = i
                    Row("Id_nivel2") = -1
                    Row("Tipo") = "PE"
                    Row("CodigoArticulo") = txtCodigoArticulo.EditValue
                    Row("Unidades") = grdviewArticulos.GetRowCellValue(i, "Cantidad").ToString
                    Row("Origen") = grdviewArticulos.GetRowCellValue(i, "Origen").ToString
                    Row("Destino") = grdviewArticulos.GetRowCellValue(i, "Destino").ToString
                    Row("Color") = grdviewArticulos.GetRowCellValue(i, "Color").ToString
                    Row("GrupoCliente") = grdviewArticulos.GetRowCellValue(i, "GrupoCliente")
                    Row("CodigoCliente") = grdviewArticulos.GetRowCellValue(i, "CodigoCliente").ToString
                    Row("NumeroOrden") = grdviewArticulos.GetRowCellValue(i, "NumOrden")
                    Row("NumeroCampana") = grdviewArticulos.GetRowCellValue(i, "NumCampana")
                    If Not grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString = String.Empty Then : Row("Entrega") = grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString : End If
                    Row("Comentario_Nivel1") = grdviewArticulos.GetRowCellValue(i, "Comentarios").ToString
                    Row("Bit_UsuarioCreacion") = My.Settings.log_Usuario.ToString
                    dt.Rows.Add(Row)
                    mMensajes.msg_Informacion("Orden Fabricacion Por: " + txtCodigoArticulo.EditValue.ToString + " / " + grdviewArticulos.GetRowCellValue(i, "Cantidad").ToString)
                End If
            Next

            If Not dt.Rows.Count = Nothing Then
                INSERT_Ordenes_Detalle(dt)
            End If

            grdviewArticulos.CollapseAllDetails()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub grdviewArticulos_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles grdviewArticulos.InitNewRow
        Dim view As GridView = CType(sender, GridView)
        Dim value As String = "0"

        value = grdviewArticulos.RowCount

        view.SetRowCellValue(e.RowHandle, view.Columns("Origen"), 0)
        view.SetRowCellValue(e.RowHandle, view.Columns("Destino"), "PI")

    End Sub
#End Region
#Region "Botones"
    
    Private Sub barbtnStock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnStock.ItemClick
        Try
            Try
                If slueCodigosProducidosPadres.EditValue = Nothing Then
                    Exit Sub
                End If
                If grdviewCodigosProducidosHijos.RowCount = Nothing Then
                    Exit Sub
                End If

                frmTemporal_Stock.ppCodigoArticulo = "'" + mFunciones.FCN_XTRAGRID_GetFilasSeleccionadasSinApostrofes(grdviewCodigosProducidosHijos, "CodigoArticulo") + "'"
                frmTemporal_Stock.ShowDialog()
            Catch ex As Exception
                mMensajes.msg_Error(ex.Message.ToString)
            End Try

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub
    Private Sub barbtnProduccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnProduccion.ItemClick
        Try
            Try
                If slueCodigosProducidosPadres.EditValue = Nothing Then
                    Exit Sub
                End If
                If grdviewCodigosProducidosHijos.RowCount = Nothing Then
                    Exit Sub
                End If


                frmTemporal_Produccion.ppCodigoArticulo = FCN_XTRAGRID_GetFilasSeleccionadas(grdviewCodigosProducidosHijos, "CodigoArticulo")
                frmTemporal_Produccion.ShowDialog()
            Catch ex As Exception
                mMensajes.msg_Error(ex.Message.ToString)
            End Try

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub
    
#End Region
#Region "Controles"
    Private Sub txtDeLinea_EditValueChanged(sender As Object, e As EventArgs) Handles txtDeLinea.EditValueChanged
        If txtDeLinea.EditValue = "SI" Then
            txtDeLinea.BackColor = Color.Green
            txtDeLinea.ForeColor = Color.White
        Else
            txtDeLinea.BackColor = Color.Red
            txtDeLinea.ForeColor = Color.White
        End If
    End Sub
#End Region
#Region "Carga Final"
    Private Sub frmIngresoAnalisisCP_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            mSQLDelete.SET_ValidarDisponibilidad_Eliminar("ProduccionPedidos", Me.Name.ToString)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
#End Region

    Private Sub barbtnSAP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSAP.ItemClick
        Try
            If grdviewArticulos.RowCount = Nothing Then
                Exit Sub
            End If

            txtCodigoArticulo.Focus()
            Set_InformacionDB()

            Dim dtSAPResultados As New DataTable("dtSAPResultados")
            Dim Row As DataRow

            Dim dtID_E As New DataTable("dtID_E")
            Dim dtID_P As New DataTable("dtID_P")

            dtSAPResultados = mSQLSelect.CrearTabla_OrdenesSubidas()

            'COMIENZA ORDENES DE PRODUCCION ************************************************************************************************************
            dtID_P = mSQLSelect.GET_OrdenesProduccion_ASubir() 'Recorre los numero de ID pendientes de Subir

            If Not dtID_P.Rows.Count = Nothing Then

                For i = 0 To dtID_P.Rows.Count - 1
                    Dim dtPEcount As New DataTable("dtEEcount")
                    dtPEcount = mSQLSelect.GET_PE(dtID_P.Rows(i)("Id").ToString) '0 Recorre los encabezados que hacen falta subir

                    For j = 0 To dtPEcount.Rows.Count - 1 'Hace el Recorrido de los numeros de encabezados pendientes

                        Dim dtPDcount As New DataTable("dtPDcount")
                        dtPDcount = mSQLSelect.GET_PD(dtID_P.Rows(i)("Id").ToString, dtPEcount.Rows(j)("Id_Nivel1").ToString)

                        For k = 0 To dtPDcount.Rows.Count - 1
                            Dim dtPE As New DataTable("dtPE")
                            Dim dtPD As New DataTable("dtPD")

                            dtPE = mSQLSelect.GET_PE(dtID_P.Rows(i)("Id").ToString, dtPEcount.Rows(j)("Id_Nivel1").ToString, dtPDcount.Rows(k)("Id_Nivel2").ToString)
                            dtPD = mSQLSelect.GET_PDetalle(dtPE.Rows(0)("CodigoArticulo").ToString, dtPE.Rows(0)("Unidades").ToString)

                            Dim DocNum As String
                            DocNum = SAP_DIAPI_OrdenesProduccion(dtPE, dtPD)

                            mSQLUpdate.UPDATE_PRODUCCION_NoSap_Y_Status(DocNum, dtID_P.Rows(i)("Id"), dtPEcount.Rows(j)("Id_Nivel1"), dtPDcount.Rows(k)("Id_Nivel2").ToString) 'Actualiza el numero de Orden SAP
                            'Agregar Resultados de SAP
                            Row = dtSAPResultados.NewRow()
                            Row("Tipo") = "PRODUCCION"
                            Row("NumeroSAP") = DocNum
                            Row("CodigoArticulo") = dtPE.Rows(0)("CodigoArticulo").ToString
                            Row("Unidades") = dtPE.Rows(0)("Unidades").ToString
                            Row("Origen") = dtPE.Rows(0)("Origen").ToString
                            Row("Destino") = dtPE.Rows(0)("Destino").ToString
                            dtSAPResultados.Rows.Add(Row)
                        Next
                    Next
                Next
            End If


            If Not dtSAPResultados.Rows.Count = Nothing Then
                vpTabla1 = dtSAPResultados
                frmResultadoOrdenesIngresadas.ShowDialog()

                txtCodigoArticulo.EditValue = String.Empty
                txtNombreArticulo.EditValue = String.Empty
                txtDeLinea.EditValue = String.Empty
                mmeComentarios.EditValue = String.Empty
                DsIngresoAnalisisCP1.Tables("dsdtIngresoOrdenes").Clear()
                slueCodigosProducidosPadres.Focus()
                barbtnSAP.Enabled = False
                mmeComentarios.Enabled = False
                grdIngresoOrdenes.Enabled = False
            End If



        Catch ex As Exception

            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnDeudaEnsamble_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaEnsamble.ItemClick
        Try
            Try
                If slueCodigosProducidosPadres.EditValue = Nothing Then
                    Exit Sub
                End If
                If grdviewCodigosProducidosHijos.RowCount = Nothing Then
                    Exit Sub
                End If

                vpOrigenes = "'0','1'"
                vpCodigoArticulo = FCN_XTRAGRID_GetFilasSeleccionadas(grdviewCodigosProducidosHijos, "CodigoArticulo")
                frmTemporal_DeudaEnsamble.ShowDialog()
            Catch ex As Exception
                mMensajes.msg_Error(ex.Message.ToString)
            End Try
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class