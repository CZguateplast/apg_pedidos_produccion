Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.GridControl
Imports DevExpress.Xpo


Public Class frmOrdenEnsamble

    Private Sub frmIngresoOrden_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            mSQLDelete.SET_ValidarDisponibilidad_Eliminar("ProduccionPedidos", Me.Name.ToString)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub Sub_Seguridad_APG()
        Try
            mSeguridad.APG_Seguridad(Me, barbtnStock)
            mSeguridad.APG_Seguridad(Me, barbtnEnsamble)
            mSeguridad.APG_Seguridad(Me, barbtnProduccion)
            mSeguridad.APG_Seguridad(Me, barbtnDeudaRol)
            mSeguridad.APG_Seguridad(Me, barbtnDeudaCampana)
            mSeguridad.APG_Seguridad(Me, barbtnDeudaProyeccion)
            mSeguridad.APG_Seguridad(Me, barbtnAnalsisVenta)
            mSeguridad.APG_Seguridad(Me, barbtnSAP)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmIngresoOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable
            dt = mSQLSelect.GET_AnalisisArticulos_XFiltro(vpCodigoArticulo)

            If Not dt.Rows.Count = Nothing Then
                txtCodigoArticulo.EditValue = dt.Rows(0)("CodigoArticulo").ToString
                txtNombreArticulo.EditValue = dt.Rows(0)("NombreArticulo").ToString
                txtDeLinea.EditValue = dt.Rows(0)("DeLinea").ToString
                txtStock.EditValue = dt.Rows(0)("Stock").ToString
                txtEnsamble.EditValue = dt.Rows(0)("Ensamble").ToString
                txtProduccion.EditValue = dt.Rows(0)("Produccion").ToString
                'Calculo de Ingresos
                txtTotalIngresos.EditValue = Val(txtStock.Text) + Val(txtEnsamble.Text) + Val(txtProduccion.Text)

                txtDeudaRol.EditValue = dt.Rows(0)("DeudaRol").ToString
                txtDeudaCampana.EditValue = dt.Rows(0)("DeudaCampana").ToString
                txtDeudaProyeccion.EditValue = dt.Rows(0)("DeudaProyeccion").ToString

                'Calculo de Egresos y Disponible
                txtTotalEgresos.EditValue = Val(txtDeudaRol.Text) + Val(txtDeudaCampana.Text) + Val(txtDeudaProyeccion.Text)

                If Val(txtDeudaProyeccion.Text) > Val(txtDeudaCampana.Text) Then
                    txtTotalEgresos.EditValue = Val(txtDeudaRol.Text) + (Val(txtDeudaProyeccion.Text)) '- Val(txtDeudaCampana.Text))
                Else
                    txtTotalEgresos.EditValue = Val(txtDeudaRol.Text) + Val(txtDeudaCampana.Text)
                End If

                txtDisponible.EditValue = Val(txtTotalIngresos.Text) - Val(txtTotalEgresos.Text)

                txtMinimo.EditValue = dt.Rows(0)("StockMinimo").ToString
                txtMaximo.EditValue = dt.Rows(0)("StockMaximo").ToString

                If txtMaximo.EditValue > 0 Then
                    If txtMaximo.EditValue > txtDisponible.EditValue Then
                        txtSugerido.EditValue = Val(txtMaximo.Text) - Val(txtDisponible.Text)
                    End If
                Else
                    txtSugerido.EditValue = String.Empty
                End If

                'Calculo de Sugerido

                'AR      *******************************************************************************************************************
                Dim dtListaMaterialesMaster As New DataTable("dtListaMaterialesMaster")
                dtListaMaterialesMaster = mSQLSelect.GET_ListaMaterialesAR_XArticulo(vpCodigoArticulo)

                '----------------------------------------
                'OBTIENE DATOS A GRABAR DEL ENCABEZADO DE LA ORDEN TRABAJADA ORDR
                Dim rowMaster As DataRow 'Aloja la Linea Completa antes de darsela al DataTable
                Dim dtMaster As New DataTable("Master") 'DataTable para Alojar la Data
                Dim columnsMaster As New DataColumn 'Creacion de Columnas


                'CREACION DE TABLA ENCABEZADO XP 
                columnsMaster = New DataColumn("Id", Type.GetType("System.Int32"))
                dtMaster.Columns.Add(columnsMaster)
                columnsMaster = New DataColumn("Origen", Type.GetType("System.String"))
                dtMaster.Columns.Add(columnsMaster)
                columnsMaster = New DataColumn("Destino", Type.GetType("System.String"))
                dtMaster.Columns.Add(columnsMaster)

                For i = 1 To 25
                    rowMaster = dtMaster.NewRow() 'Agrega Row Nueva al DataTable
                    'Agrega Valores al Datatable
                    rowMaster("Id") = i
                    rowMaster("Origen") = "0"
                    rowMaster("Destino") = "PT"
                    dtMaster.Rows.Add(rowMaster) 'Agrega la Columna en Memoria Al DataTable en Memoria
                Next
                DsIngresoOrden1.Tables("dsdtIngresoOrdenes").Clear() 'Borrar DataSet
                DsIngresoOrden1.Tables("dsdtIngresoOrdenes").Merge(dtMaster) 'Llenar DSDT con Qry


                'CP     *******************************************************************************************************************
                Dim dtListaMaterialesCP As New DataTable("dtListaMaterialesCP")
                dtListaMaterialesCP = mSQLSelect.GET_ListaMaterialesCP_XArticulo(vpCodigoArticulo)

                Dim rowCP As DataRow 'Aloja la Linea Completa antes de darsela al DataTable
                Dim dtCP As New DataTable("CP") 'DataTable para Alojar la Data
                Dim columnsCP As New DataColumn 'Creacion de Columnas
                'CREACION DE TABLA ENCABEZADO XP 
                columnsCP = New DataColumn("Id", Type.GetType("System.Int32"))
                dtCP.Columns.Add(columnsCP)
                columnsCP = New DataColumn("CodigoCP", Type.GetType("System.String"))
                dtCP.Columns.Add(columnsCP)
                columnsCP = New DataColumn("NombreCP", Type.GetType("System.String"))
                dtCP.Columns.Add(columnsCP)
                columnsCP = New DataColumn("Stock", Type.GetType("System.Int32"))
                dtCP.Columns.Add(columnsCP)
                columnsCP = New DataColumn("U/M", Type.GetType("System.String"))
                dtCP.Columns.Add(columnsCP)
                columnsCP = New DataColumn("Cantidad", Type.GetType("System.Decimal"))
                dtCP.Columns.Add(columnsCP)
                columnsCP = New DataColumn("Almacen", Type.GetType("System.Decimal"))
                dtCP.Columns.Add(columnsCP)
                columnsCP = New DataColumn("Metasa", Type.GetType("System.Decimal"))
                dtCP.Columns.Add(columnsCP)
                columnsCP = New DataColumn("Pradera", Type.GetType("System.Decimal"))
                dtCP.Columns.Add(columnsCP)

                columnsCP = New DataColumn("Produccion", Type.GetType("System.String"))
                dtCP.Columns.Add(columnsCP)
                columnsCP = New DataColumn("Comprometido", Type.GetType("System.String"))
                dtCP.Columns.Add(columnsCP)


                columnsCP = New DataColumn("Producir", Type.GetType("System.Decimal"))
                dtCP.Columns.Add(columnsCP)
                columnsCP = New DataColumn("DestinoCP", Type.GetType("System.String"))
                dtCP.Columns.Add(columnsCP)
                columnsCP = New DataColumn("OrigenAR", Type.GetType("System.String"))
                dtCP.Columns.Add(columnsCP)

                For i = 1 To 25
                    For j = 0 To dtListaMaterialesCP.Rows.Count - 1
                        rowCP = dtCP.NewRow() 'Agrega Row Nueva al DataTable
                        'Agrega Valores al Datatable
                        rowCP("Id") = i
                        rowCP("OrigenAR") = "PI"
                        rowCP("CodigoCP") = dtListaMaterialesCP.Rows(j)("CodigoCP").ToString
                        rowCP("NombreCP") = dtListaMaterialesCP.Rows(j)("NombreCP").ToString
                        rowCP("Stock") = dtListaMaterialesCP.Rows(j)("Stock").ToString
                        rowCP("U/M") = dtListaMaterialesCP.Rows(j)("U/M").ToString
                        rowCP("Cantidad") = dtListaMaterialesCP.Rows(j)("Cantidad").ToString
                        rowCP("Almacen") = dtListaMaterialesCP.Rows(j)("Almacen").ToString
                        rowCP("Metasa") = dtListaMaterialesCP.Rows(j)("Metasa").ToString
                        rowCP("Pradera") = dtListaMaterialesCP.Rows(j)("Pradera").ToString

                        rowCP("Produccion") = dtListaMaterialesCP.Rows(j)("Produccion").ToString
                        rowCP("Comprometido") = dtListaMaterialesCP.Rows(j)("Comprometido").ToString

                        rowCP("Producir") = dtListaMaterialesCP.Rows(j)("Producir").ToString
                        rowCP("DestinoCP") = "PI"


                        dtCP.Rows.Add(rowCP) 'Agrega la Columna en Memoria Al DataTable en Memoria
                    Next
                Next


                DsIngresoOrden1.Tables("dsdtCP").Clear() 'Borrar DataSet
                DsIngresoOrden1.Tables("dsdtCP").Merge(dtCP) 'Llenar DSDT con Qry

                '-------------------------------------------------------------
                'Llenar CP 2


                Dim rowCP2 As DataRow 'Aloja la Linea Completa antes de darsela al DataTable
                Dim dtCP2 As New DataTable("CP") 'DataTable para Alojar la Data
                Dim columnsCP2 As New DataColumn 'Creacion de Columnas
                'CREACION DE TABLA ENCABEZADO XP 
                columnsCP2 = New DataColumn("Id", Type.GetType("System.Int32"))
                dtCP2.Columns.Add(columnsCP2)
                columnsCP2 = New DataColumn("CodigoArticulo", Type.GetType("System.String"))
                dtCP2.Columns.Add(columnsCP2)
                columnsCP2 = New DataColumn("CodigoCP", Type.GetType("System.String"))
                dtCP2.Columns.Add(columnsCP2)
                columnsCP2 = New DataColumn("NombreCP", Type.GetType("System.String"))
                dtCP2.Columns.Add(columnsCP2)
                columnsCP2 = New DataColumn("Stock", Type.GetType("System.Int32"))
                dtCP2.Columns.Add(columnsCP2)
                columnsCP2 = New DataColumn("U/M", Type.GetType("System.String"))
                dtCP2.Columns.Add(columnsCP2)
                columnsCP2 = New DataColumn("Cantidad", Type.GetType("System.Decimal"))
                dtCP2.Columns.Add(columnsCP2)
                columnsCP2 = New DataColumn("Almacen", Type.GetType("System.Decimal"))
                dtCP2.Columns.Add(columnsCP2)
                columnsCP2 = New DataColumn("Metasa", Type.GetType("System.Decimal"))
                dtCP2.Columns.Add(columnsCP2)
                columnsCP2 = New DataColumn("Pradera", Type.GetType("System.Decimal"))
                dtCP2.Columns.Add(columnsCP2)

                columnsCP2 = New DataColumn("Produccion", Type.GetType("System.String"))
                dtCP2.Columns.Add(columnsCP2)
                columnsCP2 = New DataColumn("Comprometido", Type.GetType("System.String"))
                dtCP2.Columns.Add(columnsCP2)


                columnsCP2 = New DataColumn("Producir", Type.GetType("System.Decimal"))
                dtCP2.Columns.Add(columnsCP2)
                columnsCP2 = New DataColumn("DestinoCP", Type.GetType("System.String"))
                dtCP2.Columns.Add(columnsCP2)
                columnsCP2 = New DataColumn("OrigenAR", Type.GetType("System.String"))
                dtCP2.Columns.Add(columnsCP2)


                Dim dtListaMaterialesCP2 As New DataTable("dtListaMaterialesCP2")


                For k = 0 To dtListaMaterialesCP.Rows.Count - 1
                    dtListaMaterialesCP2 = mSQLSelect.GET_ListaMaterialesCP_XArticulo("'" + dtListaMaterialesCP.Rows(k)("CodigoCP").ToString + "'")
                    For i = 1 To 25
                        For j = 0 To dtListaMaterialesCP2.Rows.Count - 1
                            rowCP2 = dtCP2.NewRow() 'Agrega Row Nueva al DataTable
                            'Agrega Valores al Datatable
                            rowCP2("Id") = i
                            rowCP2("OrigenAR") = "PI"
                            rowCP2("CodigoArticulo") = dtListaMaterialesCP2.Rows(j)("CodigoArticulo").ToString
                            rowCP2("CodigoCP") = dtListaMaterialesCP2.Rows(j)("CodigoCP").ToString
                            rowCP2("NombreCP") = dtListaMaterialesCP2.Rows(j)("NombreCP").ToString
                            rowCP2("Stock") = dtListaMaterialesCP2.Rows(j)("Stock").ToString
                            rowCP2("U/M") = dtListaMaterialesCP2.Rows(j)("U/M").ToString
                            rowCP2("Cantidad") = dtListaMaterialesCP2.Rows(j)("Cantidad").ToString
                            rowCP2("Almacen") = dtListaMaterialesCP2.Rows(j)("Almacen").ToString
                            rowCP2("Metasa") = dtListaMaterialesCP2.Rows(j)("Metasa").ToString
                            rowCP2("Pradera") = dtListaMaterialesCP2.Rows(j)("Pradera").ToString
                            rowCP2("Produccion") = dtListaMaterialesCP2.Rows(j)("Produccion").ToString
                            rowCP2("Comprometido") = dtListaMaterialesCP2.Rows(j)("Comprometido").ToString
                            rowCP2("Producir") = dtListaMaterialesCP2.Rows(j)("Producir").ToString
                            rowCP2("DestinoCP") = "PI"


                            dtCP2.Rows.Add(rowCP2) 'Agrega la Columna en Memoria Al DataTable en Memoria
                        Next
                    Next

                Next

                DsIngresoOrden1.Tables("dsdtCP2").Clear() 'Borrar DataSet
                DsIngresoOrden1.Tables("dsdtCP2").Merge(dtCP2) 'Llenar DSDT con Qry

                Dim dtListaMaterialesCC As New DataTable("dtListaMaterialesMaster")
                dtListaMaterialesCC = mSQLSelect.GET_ListaMaterialesCC_XArticulo(vpCodigoArticulo)

                '-------------------------------------------------------------
                Dim rowCC As DataRow 'Aloja la Linea Completa antes de darsela al DataTable
                Dim dtCC As New DataTable("CC") 'DataTable para Alojar la Data
                Dim columnsCC As New DataColumn 'Creacion de Columnas
                'CREACION DE TABLA ENCABEZADO XP 
                columnsCC = New DataColumn("Id", Type.GetType("System.Int32"))
                dtCC.Columns.Add(columnsCC)
                columnsCC = New DataColumn("CodigoCC", Type.GetType("System.String"))
                dtCC.Columns.Add(columnsCC)
                columnsCC = New DataColumn("NombreCC", Type.GetType("System.String"))
                dtCC.Columns.Add(columnsCC)
                columnsCC = New DataColumn("Stock", Type.GetType("System.Int32"))
                dtCC.Columns.Add(columnsCC)
                columnsCC = New DataColumn("U/M", Type.GetType("System.String"))
                dtCC.Columns.Add(columnsCC)
                columnsCC = New DataColumn("Cantidad", Type.GetType("System.Decimal"))
                dtCC.Columns.Add(columnsCC)
                columnsCC = New DataColumn("Almacen", Type.GetType("System.Decimal"))
                dtCC.Columns.Add(columnsCC)
                columnsCC = New DataColumn("Metasa", Type.GetType("System.Decimal"))
                dtCC.Columns.Add(columnsCC)
                columnsCC = New DataColumn("Pradera", Type.GetType("System.Decimal"))
                dtCC.Columns.Add(columnsCC)
                columnsCC = New DataColumn("Producir", Type.GetType("System.Decimal"))
                dtCC.Columns.Add(columnsCC)

                For i = 1 To 25
                    For j = 0 To dtListaMaterialesCC.Rows.Count - 1
                        rowCC = dtCC.NewRow() 'Agrega Row Nueva al DataTable
                        'Agrega Valores al Datatable
                        rowCC("Id") = i
                        rowCC("CodigoCC") = dtListaMaterialesCC.Rows(j)("CodigoCC").ToString
                        rowCC("NombreCC") = dtListaMaterialesCC.Rows(j)("NombreCC").ToString
                        rowCC("Stock") = dtListaMaterialesCC.Rows(j)("Stock").ToString
                        rowCC("U/M") = dtListaMaterialesCC.Rows(j)("U/M").ToString
                        rowCC("Cantidad") = dtListaMaterialesCC.Rows(j)("Cantidad").ToString
                        rowCC("Almacen") = dtListaMaterialesCC.Rows(j)("Almacen").ToString
                        rowCC("Metasa") = dtListaMaterialesCC.Rows(j)("Metasa").ToString
                        rowCC("Pradera") = dtListaMaterialesCC.Rows(j)("Pradera").ToString
                        rowCC("Producir") = dtListaMaterialesCC.Rows(j)("Producir").ToString

                        dtCC.Rows.Add(rowCC) 'Agrega la Columna en Memoria Al DataTable en Memoria
                    Next
                Next
                '-------------------------------------------------------------

                DsIngresoOrden1.Tables("dsdtCC").Clear() 'Borrar DataSet
                DsIngresoOrden1.Tables("dsdtCC").Merge(dtCC) 'Llenar DSDT con Qry

            Else
                mMensajes.msg_Informacion("Este articulo no tiene Stock")
                Me.Close()
            End If

            ValoresDefault()
            Sub_Seguridad_APG()

        Catch ex As Exception
            Me.Close()
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub ValoresDefault()
        Try

            mFunciones.FCN_FILL_SearchLookUpEdit(rslueOrigen, mSQLSelect.GET_PROD_CatListados("Orden_Origen"), "Id", "Nombre")
            mFunciones.FCN_FILL_ComboBox(cbbOrigenAR, mSQLSelect.GET_PROD_CatListados("Orden_Origen"), "Id", "Nombre")

            mFunciones.FCN_FILL_SearchLookUpEdit(rslueDestino, mSQLSelect.GET_Listado_Bodegas(), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueColores, mSQLSelect.GET_Catalogo_Colores(), "Id", "Id")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueGrupoCliente, mSQLSelect.GET_Listado_GrupoClientes(), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueCodigoCliente, mSQLSelect.GET_Catalogo_ClientesDisponibles(), "CodigoCliente", "CodigoCliente")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueNumOrdenVenta, mSQLSelect.GET_Listado_OrdenesVentaDisponibles(), "NumOrden", "NumOrden")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueNumCampana, mSQLSelect.GET_Listado_CampanaVigentes, "Id", "Id")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueCodigoCP, mSQLSelect.GET_ListaMaterialesARCP, "CodigoArticulo", "CodigoArticulo")
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try


    End Sub

    Private Sub barbtnStock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnStock.ItemClick
        Try
            Try
                frmTemporal_Stock.ppCodigoArticulo = "'" + txtCodigoArticulo.EditValue + "'"
                frmTemporal_Stock.ShowDialog()
            Catch ex As Exception
                mMensajes.msg_Error(ex.Message.ToString)
            End Try

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnEnsamble_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEnsamble.ItemClick
        Try
            Try
                frmTemporal_Ensamble.ppOrigenesBodegas = "'1','2','3','4'"
                frmTemporal_Ensamble.ppCodigoArticulo = "'" + txtCodigoArticulo.EditValue + "'"

                frmTemporal_Ensamble.ShowDialog()
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
                frmTemporal_Produccion.ppCodigoArticulo = "'" + txtCodigoArticulo.EditValue + "'"
                frmTemporal_Produccion.ShowDialog()
            Catch ex As Exception
                mMensajes.msg_Error(ex.Message.ToString)
            End Try

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnDeudaRol_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaRol.ItemClick
        Try
            Try
                frmTemporal_DeudaRol.ppCodigoArticulo = "'" + txtCodigoArticulo.EditValue + "'"
                frmTemporal_DeudaRol.ShowDialog()
            Catch ex As Exception
                mMensajes.msg_Error(ex.Message.ToString)
            End Try

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnDeudaCampana_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaCampana.ItemClick
        Try
            Try
                frmTemporal_DeudaCampana.ppCodigoArticulo = "'" + txtCodigoArticulo.EditValue + "'"
                frmTemporal_DeudaCampana.ShowDialog()
            Catch ex As Exception
                mMensajes.msg_Error(ex.Message.ToString)
            End Try

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnDeudaProyeccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaProyeccion.ItemClick
        Try
            Try
                frmTemporal_DeudaProyeccion.ppCodigoArticulo = "'" + txtCodigoArticulo.EditValue + "'"
                frmTemporal_DeudaProyeccion.ShowDialog()
            Catch ex As Exception
                mMensajes.msg_Error(ex.Message.ToString)
            End Try

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub


    Private Sub grdviewArticulos_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles grdviewArticulos.InitNewRow
        Dim view As GridView = CType(sender, GridView)
        Dim value As String = "0"

        value = grdviewArticulos.RowCount

        view.SetRowCellValue(e.RowHandle, view.Columns("Id"), value)
        view.SetRowCellValue(e.RowHandle, view.Columns("Destino"), 5)


        'If grdviewArticulos.IsValidRowHandle(e.RowHandle) Then

        'End If


    End Sub




    'Private Sub grdviewArticulos_MasterRowExpanded(sender As Object, e As CustomMasterRowEventArgs) Handles grdviewArticulos.MasterRowExpanded
    '    vpValorProducir = mFunciones.FCN_XTRAGRID_GetRowCellValue_Integer(grdviewArticulos, "CantidadProduccion")

    '    For i = 0 To grdviewCP.RowCount - 1
    '        grdviewCP.SetRowCellValue(i, "Sugerido", grdviewCP.GetRowCellValue(i, "Cantidad") * vpValorProducir)
    '    Next
    'End Sub

    Private Sub grdviewCP_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles grdviewCP.InitNewRow
        Try
            Dim view As GridView = CType(sender, GridView)

            'view.Columns("OrigenAR").ColumnEdit = rslueOrigen
            view.SetRowCellValue(e.RowHandle, view.Columns("OrigenAR"), "PI")
            view.SetRowCellValue(e.RowHandle, view.Columns("DestinoCP"), "PI")
            grdviewCP.Columns("Cantidad").OptionsColumn.AllowEdit = True
            grdviewCP.Columns("Cantidad").OptionsColumn.AllowFocus = True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub grdviewCP_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdviewCP.CellValueChanged

        Try
            If e.Column.FieldName = "CodigoCP" Then
                Dim dt As New DataTable
                Dim CodigoCP As String = e.Value
                vpCodigoArticulo2 = CodigoCP 'dar valor a variable

                'VALIDACION DE CODIGOS DISPONIBLES
                If Not mFunciones.FCN_ValidarDisponiblidad_CP("'" + CodigoCP + "'", Me.Name.ToString) Then
                    grdviewArticulos.GetDetailView(grdviewArticulos.FocusedRowHandle, 0).GetRow(e.RowHandle)("CodigoCP") = DBNull.Value
                    Exit Sub
                End If
                'FIN DE VALIDACION DE CODIGOS DISPONIBLES

                dt = mSQLSelect.GET_ArticuloCP(CodigoCP)
                If Not dt.Rows.Count = Nothing Then

                    Dim NombreCP As String = dt.Rows(0)("NombreCP").ToString
                    grdviewArticulos.GetDetailView(grdviewArticulos.FocusedRowHandle, 0).GetRow(e.RowHandle)("NombreCP") = dt.Rows(0)("NombreCP").ToString
                    If grdviewArticulos.GetDetailView(grdviewArticulos.FocusedRowHandle, 0).GetRow(e.RowHandle)("U/M").ToString = String.Empty Then
                        grdviewArticulos.GetDetailView(grdviewArticulos.FocusedRowHandle, 0).GetRow(e.RowHandle)("U/M") = "UND"
                    End If
                    grdviewArticulos.GetDetailView(grdviewArticulos.FocusedRowHandle, 0).GetRow(e.RowHandle)("Almacen") = dt.Rows(0)("Almacen").ToString
                    grdviewArticulos.GetDetailView(grdviewArticulos.FocusedRowHandle, 0).GetRow(e.RowHandle)("Metasa") = dt.Rows(0)("Metasa").ToString
                    grdviewArticulos.GetDetailView(grdviewArticulos.FocusedRowHandle, 0).GetRow(e.RowHandle)("Pradera") = dt.Rows(0)("Pradera").ToString
                    If grdviewArticulos.GetDetailView(grdviewArticulos.FocusedRowHandle, 0).GetRow(e.RowHandle)("Cantidad").ToString = String.Empty Then
                        grdviewArticulos.GetDetailView(grdviewArticulos.FocusedRowHandle, 0).GetRow(e.RowHandle)("Cantidad") = "1.000000"
                    End If
                    grdviewArticulos.GetDetailView(grdviewArticulos.FocusedRowHandle, 0).GetRow(e.RowHandle)("Produccion") = dt.Rows(0)("Produccion").ToString
                    grdviewArticulos.GetDetailView(grdviewArticulos.FocusedRowHandle, 0).GetRow(e.RowHandle)("Comprometido") = dt.Rows(0)("Comprometido").ToString


                    grdviewArticulos.GetDetailView(grdviewArticulos.FocusedRowHandle, 0).GetRow(e.RowHandle)("Producir") = "0"
                    grdviewArticulos.GetDetailView(grdviewArticulos.FocusedRowHandle, 0).GetRow(e.RowHandle)("DestinoCP") = "PI"

                End If

            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try




    End Sub

    Private Sub grdviewArticulos_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles grdviewArticulos.CellValueChanged
        Try
            'Validate(True)

            If e.Column.FieldName = "CantidadEnsamble" Then
                If grdviewArticulos.IsMasterRowEmpty(e.RowHandle) Then 'VERIFICA SI NO TIENE DETALLE ASIGNADO
                    'grdviewArticulos_CellValueChanged(sender, e)
                    'grdviewArticulos.SetRowCellValue(e.RowHandle, "CantidadEnsamble", 1200)
                    grdviewArticulos.UpdateCurrentRow()
                    'mMensajes.msg_Informacion("Grabe primero la linea para poder ver el detalle")
                Else
                    grdviewArticulos.ExpandMasterRow(e.RowHandle, 0)

                    Dim pCantidad As String = 0

                    If IsNumeric(grdviewArticulos.GetRowCellValue(e.RowHandle, "CantidadEnsamble")) Then 'VERIFICA SI EL CAMPO ES NUMERICO

                        pCantidad = grdviewArticulos.GetRowCellValue(e.RowHandle, "CantidadEnsamble")

                        If Not grdviewArticulos.GetDetailView(e.RowHandle, 0).RowCount Then

                            For i = 0 To grdviewArticulos.GetDetailView(e.RowHandle, 0).RowCount - 1
                                Dim Unidades As Decimal = 0
                                Unidades = grdviewArticulos.GetDetailView(e.RowHandle, 0).GetRow(i)("Cantidad")
                                grdviewArticulos.GetDetailView(grdviewArticulos.FocusedRowHandle, 0).GetRow(i)("Producir") = Convert.ToDecimal(pCantidad * Unidades)
                            Next
                        Else
                            mMensajes.msg_Informacion("Grabe primero la linea para poder ver el detalle")
                            grdviewArticulos.SetRowCellValue(e.RowHandle, "CantidadEnsamble", Nothing)
                        End If
                    End If

                End If

            ElseIf e.Column.FieldName = "CodigoCliente" Then

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


    Private Sub Set_InformacionDB()
        Try
            GenerarOrden_Encabezado()

            Dim dt As New DataTable("dtOrdenesAR")
            Dim Row As DataRow
            Dim RowCP As DataRow
            Dim IdTrans As Integer = 0
            Dim dtCP2 As DataTable = DsIngresoOrden1.Tables("dsdtCP2") 'Datatable para 3 nivel de Ordenes de produccion
            Dim Idtransaccion As Integer = 1


            dt = mSQLSelect.GET_PROD_Ordenes_Encabezado() 'Crear la Tabla
            IdTrans = mSQLSelect.GET_PROD_IdTransaccion()


            'PASO 1 --------------PASO 1 --------------- PASO 1 ---------------- PASO 1
            'For i para hacer ----------ENSAMBLE -----------------------------------------------------------------------
            For i = 0 To grdviewArticulos.RowCount - 1

                ' si la columna cantidad no es vacia entonces sigue >>>>>
                If Not grdviewArticulos.GetRowCellValue(i, "CantidadEnsamble").ToString = String.Empty Then ''Or grdviewArticulos.GetRowCellValue(i, "CantidadEnsamble").ToString > 1 Then


                    'Generar -------- ENCABEZADO
                    Row = dt.NewRow()
                    Row("Id") = IdTrans
                    'Row("Id_nivel1") = i
                    Row("Id_nivel1") = Idtransaccion
                    Row("Id_nivel2") = -1
                    Row("Tipo") = "EE"
                    Row("CodigoArticulo") = txtCodigoArticulo.EditValue
                    Row("Unidades") = grdviewArticulos.GetRowCellValue(i, "CantidadEnsamble").ToString
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

                    'mMensajes.msg_Informacion("Orden Ensamble Por: " + txtCodigoArticulo.EditValue.ToString + " / " + grdviewArticulos.GetRowCellValue(i, "CantidadEnsamble").ToString)

                    'Generar --------- DETALLE
                    grdviewArticulos.SetMasterRowExpandedEx(i, 0, True)
                    For j = 0 To grdviewArticulos.GetDetailView(i, 0).RowCount - 1
                        RowCP = dt.NewRow()
                        RowCP("Id") = IdTrans
                        'RowCP("Id_nivel1") = i
                        RowCP("Id_nivel1") = Idtransaccion
                        RowCP("Id_nivel2") = j
                        RowCP("Tipo") = "ED"
                        RowCP("CodigoArticulo") = grdviewArticulos.GetDetailView(i, 0).GetRow(j)("CodigoCP")
                        RowCP("Unidades") = grdviewArticulos.GetRowCellValue(i, "CantidadEnsamble") * grdviewArticulos.GetDetailView(i, 0).GetRow(j)("Cantidad")
                        'RowCP("Origen") = grdviewArticulos.GetRowCellValue(i, "Origen").ToString
                        RowCP("Origen") = grdviewArticulos.GetDetailView(i, 0).GetRow(j)("OrigenAR")
                        'RowCP("Destino") = grdviewArticulos.GetRowCellValue(i, "Destino").ToString
                        'RowCP("Destino") = grdviewArticulos.GetDetailView(i, 0).GetRow(j)("OrigenAR")
                        RowCP("Color") = grdviewArticulos.GetRowCellValue(i, "Color").ToString
                        RowCP("GrupoCliente") = grdviewArticulos.GetRowCellValue(i, "GrupoCliente")
                        RowCP("CodigoCliente") = grdviewArticulos.GetRowCellValue(i, "CodigoCliente").ToString
                        RowCP("NumeroOrden") = grdviewArticulos.GetRowCellValue(i, "NumOrden")
                        RowCP("NumeroCampana") = grdviewArticulos.GetRowCellValue(i, "NumCampana")
                        If Not grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString = String.Empty Then : RowCP("Entrega") = grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString : End If
                        'RowCP("Comentario_Nivel1") = grdviewArticulos.GetRowCellValue(i, "Comentarios").ToString
                        RowCP("Comentario_Nivel1") = grdviewArticulos.GetDetailView(i, 0).GetRow(j)("Comentarios")
                        'RowCP("Comentario_Nivel2") = grdviewArticulos.GetDetailView(i, 0).GetRow(j)("Comentarios")
                        RowCP("Bit_UsuarioCreacion") = My.Settings.log_Usuario.ToString
                        dt.Rows.Add(RowCP)
                        'mMensajes.msg_Informacion("Orden ENSAMBLE Detalle Por: " + grdviewArticulos.GetDetailView(i, 0).GetRow(j)("CodigoCP").ToString + " / " + (grdviewArticulos.GetRowCellValue(i, "CantidadEnsamble") * grdviewArticulos.GetDetailView(i, 0).GetRow(j)("Cantidad")).ToString)
                    Next

                    Idtransaccion = Idtransaccion + 1 'SUMA 1 AL CONTADOR
                End If

            Next

            'PASO 2 --------------PASO 2 --------------- PASO 2 ---------------- PASO 2 --------------------------------------------------------------
            'Recorre grdview Principal para buscar Detalle en GRID CP PARA HACER PRODUCCION
            'Recorre Grdview Principal para recorrer 2 gridview CP
            For i = 0 To grdviewArticulos.RowCount - 1
                grdviewArticulos.SetMasterRowExpandedEx(i, 0, True)
                For j = 0 To grdviewArticulos.GetDetailView(i, 0).RowCount - 1  ' RECORRE EL FOR J PARA EL GRDVIEW CP

                    If grdviewArticulos.GetDetailView(i, 0).GetRow(j)("Producir") > 0 Then
                        If grdviewArticulos.GetDetailView(i, 0).GetRow(j)("CodigoCP").ToString.Substring(0, 2) = "CP" Then

                            Row = dt.NewRow()
                            Row("Id") = IdTrans
                            'Row("Id_nivel1") = i
                            Row("Id_nivel1") = Idtransaccion
                            Row("Id_nivel2") = j
                            Row("Tipo") = "PE"
                            Row("CodigoArticulo") = grdviewArticulos.GetDetailView(i, 0).GetRow(j)("CodigoCP")
                            Row("Unidades") = grdviewArticulos.GetDetailView(i, 0).GetRow(j)("Producir")
                            Row("Origen") = "0"
                            Row("Destino") = grdviewArticulos.GetDetailView(i, 0).GetRow(j)("DestinoCP")
                            Row("Color") = grdviewArticulos.GetRowCellValue(i, "Color").ToString
                            Row("GrupoCliente") = grdviewArticulos.GetRowCellValue(i, "GrupoCliente")
                            Row("CodigoCliente") = grdviewArticulos.GetRowCellValue(i, "CodigoCliente").ToString
                            Row("NumeroOrden") = grdviewArticulos.GetRowCellValue(i, "NumOrden")
                            Row("NumeroCampana") = grdviewArticulos.GetRowCellValue(i, "NumCampana")
                            If Not grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString = String.Empty Then
                                Dim FechaEntrega As String
                                FechaEntrega = grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(6, 4)
                                FechaEntrega += "-" + grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(3, 2)
                                FechaEntrega += "-" + grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(0, 2)
                                Row("Entrega") = FechaEntrega
                                'Row("Entrega") = Convert.ToDateTime(grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(0, 10)).Date
                            End If
                            Row("Comentario_Nivel1") = grdviewArticulos.GetDetailView(i, 0).GetRow(j)("Comentarios").ToString
                            'Row("Comentario_Nivel1") = grdviewArticulos.GetRowCellValue(i, "Comentarios").ToString
                            'Row("Comentario_Nivel2") = grdviewArticulos.GetDetailView(i, 0).GetRow(j)("Comentarios").ToString
                            Row("Bit_UsuarioCreacion") = My.Settings.log_Usuario.ToString
                            dt.Rows.Add(Row)
                            'mMensajes.msg_Informacion("Orden FABRICACION Encabezado Por: " + grdviewArticulos.GetDetailView(i, 0).GetRow(j)("CodigoCP").ToString + " / " + grdviewArticulos.GetDetailView(i, 0).GetRow(j)("Producir").ToString)

                            Idtransaccion = Idtransaccion + 1 'SUMA 1 AL CONTADOR


                            'seccion agregada para prueba

                            'Comienza a Recorrer el Datatable 
                            For k = 0 To dtCP2.Rows.Count - 1
                                'If dtCP2.Rows(k)("Id").ToString = j + 1 And dtCP2.Rows(k)("Producir") > 0 And dtCP2.Rows(k)("").ToString.Substring(1, 2) = "CP" Then
                                If dtCP2.Rows(k)("Id").ToString = i + 1 And dtCP2.Rows(k)("CodigoArticulo").ToString = grdviewArticulos.GetDetailView(i, 0).GetRow(j)("CodigoCP").ToString And dtCP2.Rows(k)("Producir") > 0 Then
                                    Row = dt.NewRow()
                                    Row("Id") = IdTrans
                                    'Row("Id_nivel1") = i
                                    Row("Id_nivel1") = Idtransaccion
                                    Row("Id_nivel2") = j
                                    Row("Tipo") = "PE"
                                    Row("CodigoArticulo") = dtCP2.Rows(k)("CodigoCP").ToString
                                    Row("Unidades") = CInt(dtCP2.Rows(k)("Producir") * dtCP2.Rows(k)("Cantidad"))
                                    Row("Origen") = "0"
                                    Row("Destino") = dtCP2.Rows(k)("DestinoCP").ToString
                                    Row("Color") = grdviewArticulos.GetRowCellValue(i, "Color").ToString
                                    Row("GrupoCliente") = grdviewArticulos.GetRowCellValue(i, "GrupoCliente")
                                    Row("CodigoCliente") = grdviewArticulos.GetRowCellValue(i, "CodigoCliente").ToString
                                    Row("NumeroOrden") = grdviewArticulos.GetRowCellValue(i, "NumOrden")
                                    Row("NumeroCampana") = grdviewArticulos.GetRowCellValue(i, "NumCampana")
                                    If Not grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString = String.Empty Then
                                        Dim FechaEntrega As String
                                        FechaEntrega = grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(6, 4)
                                        FechaEntrega += "-" + grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(3, 2)
                                        FechaEntrega += "-" + grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(0, 2)
                                        Row("Entrega") = FechaEntrega
                                        'Row("Entrega") = Convert.ToDateTime(grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(0, 10)).Date
                                    End If
                                    Row("Comentario_Nivel1") = dtCP2.Rows(k)("Comentarios").ToString
                                    'Row("Comentario_Nivel1") = grdviewArticulos.GetRowCellValue(i, "Comentarios").ToString
                                    'Row("Comentario_Nivel2") = dtCP2.Rows(k)("Comentarios").ToString
                                    Row("Bit_UsuarioCreacion") = My.Settings.log_Usuario.ToString
                                    dt.Rows.Add(Row)
                                End If
                            Next

                            Idtransaccion = Idtransaccion + 1 'SUMA 1 AL CONTADOR


                            'finaliza la seccion agregada





                        ElseIf grdviewArticulos.GetDetailView(i, 0).GetRow(j)("CodigoCP").ToString.Substring(0, 2) = "AR" Then
                            'If grdviewArticulos.GetDetailView(i, 0).GetRow(j)("Producir") > 0 Then
                            Row = dt.NewRow()
                            Row("Id") = IdTrans
                            'Row("Id_nivel1") = i
                            Row("Id_nivel1") = Idtransaccion
                            Row("Id_nivel2") = j
                            Row("Tipo") = "EE"
                            Row("CodigoArticulo") = grdviewArticulos.GetDetailView(i, 0).GetRow(j)("CodigoCP")
                            Row("Unidades") = grdviewArticulos.GetDetailView(i, 0).GetRow(j)("Producir")
                            Row("Origen") = grdviewArticulos.GetRowCellValue(i, "Origen").ToString
                            Row("Destino") = grdviewArticulos.GetDetailView(i, 0).GetRow(j)("DestinoCP")
                            'RowCP("Destino") = grdviewArticulos.GetDetailView(i, 0).GetRow(j)("OrigenAR")
                            Row("Color") = grdviewArticulos.GetRowCellValue(i, "Color").ToString
                            Row("GrupoCliente") = grdviewArticulos.GetRowCellValue(i, "GrupoCliente")
                            Row("CodigoCliente") = grdviewArticulos.GetRowCellValue(i, "CodigoCliente").ToString
                            Row("NumeroOrden") = grdviewArticulos.GetRowCellValue(i, "NumOrden")
                            Row("NumeroCampana") = grdviewArticulos.GetRowCellValue(i, "NumCampana")
                            If Not grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString = String.Empty Then
                                Dim FechaEntrega As String
                                FechaEntrega = grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(6, 4)
                                FechaEntrega += "-" + grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(3, 2)
                                FechaEntrega += "-" + grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(0, 2)
                                Row("Entrega") = FechaEntrega
                                'Row("Entrega") = Convert.ToDateTime(grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(0, 10)).Date
                            End If
                            Row("Comentario_Nivel1") = grdviewArticulos.GetDetailView(i, 0).GetRow(j)("Comentarios").ToString
                            'Row("Comentario_Nivel1") = grdviewArticulos.GetRowCellValue(i, "Comentarios").ToString
                            'Row("Comentario_Nivel2") = grdviewArticulos.GetDetailView(i, 0).GetRow(j)("Comentarios").ToString
                            Row("Bit_UsuarioCreacion") = My.Settings.log_Usuario.ToString
                            dt.Rows.Add(Row)
                            'mMensajes.msg_Informacion("Orden FABRICACION Encabezado Por: " + grdviewArticulos.GetDetailView(i, 0).GetRow(j)("CodigoCP").ToString + " / " + grdviewArticulos.GetDetailView(i, 0).GetRow(j)("Producir").ToString)


                            'Comienza a Recorrer el Datatable 
                            For k = 0 To dtCP2.Rows.Count - 1
                                'If dtCP2.Rows(k)("Id").ToString = j + 1 And dtCP2.Rows(k)("Producir") > 0 And dtCP2.Rows(k)("").ToString.Substring(1, 2) = "CP" Then
                                If dtCP2.Rows(k)("Id").ToString = i + 1 And dtCP2.Rows(k)("CodigoArticulo").ToString = grdviewArticulos.GetDetailView(i, 0).GetRow(j)("CodigoCP").ToString And dtCP2.Rows(k)("Producir") > 0 Then
                                    Row = dt.NewRow()
                                    Row("Id") = IdTrans
                                    'Row("Id_nivel1") = i
                                    Row("Id_nivel1") = Idtransaccion
                                    Row("Id_nivel2") = j
                                    Row("Tipo") = "ED"
                                    Row("CodigoArticulo") = dtCP2.Rows(k)("CodigoCP").ToString
                                    Row("Unidades") = CInt(grdviewArticulos.GetDetailView(i, 0).GetRow(j)("Producir") * dtCP2.Rows(k)("Cantidad"))
                                    Row("Origen") = dtCP2.Rows(k)("OrigenAR").ToString
                                    'Row("Destino") = dtCP2.Rows(k)("DestinoCP").ToString
                                    Row("Color") = grdviewArticulos.GetRowCellValue(i, "Color").ToString
                                    Row("GrupoCliente") = grdviewArticulos.GetRowCellValue(i, "GrupoCliente")
                                    Row("CodigoCliente") = grdviewArticulos.GetRowCellValue(i, "CodigoCliente").ToString
                                    Row("NumeroOrden") = grdviewArticulos.GetRowCellValue(i, "NumOrden")
                                    Row("NumeroCampana") = grdviewArticulos.GetRowCellValue(i, "NumCampana")
                                    If Not grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString = String.Empty Then
                                        Dim FechaEntrega As String
                                        FechaEntrega = grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(6, 4)
                                        FechaEntrega += "-" + grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(3, 2)
                                        FechaEntrega += "-" + grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(0, 2)
                                        Row("Entrega") = FechaEntrega
                                        'Row("Entrega") = Convert.ToDateTime(grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(0, 10)).Date
                                    End If
                                    Row("Comentario_Nivel1") = dtCP2.Rows(k)("Comentarios").ToString
                                    'Row("Comentario_Nivel1") = grdviewArticulos.GetRowCellValue(i, "Comentarios").ToString
                                    'Row("Comentario_Nivel2") = dtCP2.Rows(k)("Comentarios").ToString
                                    Row("Bit_UsuarioCreacion") = My.Settings.log_Usuario.ToString
                                    dt.Rows.Add(Row)
                                End If
                            Next

                            Idtransaccion = Idtransaccion + 1 'SUMA 1 AL CONTADOR

                            'HACER RECORRIDO PARA HACER ORDENES DE PRODUCCION DE LA TABLA
                            For k = 0 To dtCP2.Rows.Count - 1
                                'If dtCP2.Rows(k)("Id").ToString = j + 1 And dtCP2.Rows(k)("Producir") > 0 And dtCP2.Rows(k)("").ToString.Substring(1, 2) = "CP" Then
                                If dtCP2.Rows(k)("Id").ToString = i + 1 And dtCP2.Rows(k)("Producir") > 0 Then
                                    Row = dt.NewRow()
                                    Row("Id") = IdTrans
                                    'Row("Id_nivel1") = i
                                    Row("Id_nivel1") = Idtransaccion
                                    Row("Id_nivel2") = j
                                    Row("Tipo") = "PE"
                                    Row("CodigoArticulo") = dtCP2.Rows(k)("CodigoCP").ToString
                                    Row("Unidades") = dtCP2.Rows(k)("Producir").ToString
                                    Row("Origen") = "0"
                                    Row("Destino") = dtCP2.Rows(k)("DestinoCP").ToString
                                    Row("Color") = grdviewArticulos.GetRowCellValue(i, "Color").ToString
                                    Row("GrupoCliente") = grdviewArticulos.GetRowCellValue(i, "GrupoCliente")
                                    Row("CodigoCliente") = grdviewArticulos.GetRowCellValue(i, "CodigoCliente").ToString
                                    Row("NumeroOrden") = grdviewArticulos.GetRowCellValue(i, "NumOrden")
                                    Row("NumeroCampana") = grdviewArticulos.GetRowCellValue(i, "NumCampana")
                                    If Not grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString = String.Empty Then
                                        Dim FechaEntrega As String
                                        FechaEntrega = grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(6, 4)
                                        FechaEntrega += "-" + grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(3, 2)
                                        FechaEntrega += "-" + grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(0, 2)
                                        Row("Entrega") = FechaEntrega
                                        'Row("Entrega") = Convert.ToDateTime(grdviewArticulos.GetRowCellValue(i, "FechaEntrega").ToString.Substring(0, 10)).Date
                                    End If
                                    Row("Comentario_Nivel1") = dtCP2.Rows(k)("Comentarios").ToString
                                    'Row("Comentario_Nivel1") = grdviewArticulos.GetRowCellValue(i, "Comentarios").ToString
                                    'Row("Comentario_Nivel2") = dtCP2.Rows(k)("Comentarios").ToString
                                    Row("Bit_UsuarioCreacion") = My.Settings.log_Usuario.ToString
                                    dt.Rows.Add(Row)

                                    Idtransaccion = Idtransaccion + 1 'SUMA 1 AL CONTADOR
                                End If
                            Next

                        End If
                    Else


                    End If
                Next
            Next




            If Not dt.Rows.Count = Nothing Then
                INSERT_Ordenes_Detalle(dt)
            End If

            grdviewArticulos.CollapseAllDetails()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub GenerarOrden_Encabezado()
        Try
            Dim pArrayList As New ArrayList
            pArrayList.Add(txtCodigoArticulo.Text) '0
            pArrayList.Add(txtStock.Text) '1
            pArrayList.Add(txtEnsamble.Text) '2
            pArrayList.Add(txtProduccion.Text) '3
            pArrayList.Add(txtDeudaRol.Text) '4
            pArrayList.Add(txtDeudaCampana.Text) '5
            pArrayList.Add(txtDeudaProyeccion.Text) '6
            pArrayList.Add(txtMinimo.Text) '7
            pArrayList.Add(txtMaximo.Text) '8
            pArrayList.Add(txtSugerido.Text) '9
            pArrayList.Add(mmeComentarios.Text) '10
            INSERT_Ordenes_Encabezado(pArrayList)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    



    Private Function SAP_DIAPI_OrdenesEnsamble(ByVal dtEncabezado As DataTable, ByVal dtDetalle As DataTable) As String
        'Public Function SAP_DIAPI_OrdenesEnsamble() As Boolean
        Try
            Try
                ConectarDIAPIGT()

                If Not (oCompanyGT.Connected) Then
                    Throw New Exception("Debe conectarse a sap!")
                End If

                oCompanyGT.StartTransaction() 'Inicia la Transaccion

                'crear un objeto tipo producto
                ' Dim oPedido As SAPbobsCOM.Documents
                Dim oPedido As SAPbobsCOM.ProductionOrders

                'instanciar la variable
                oPedido = oCompanyGT.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders)

                oPedido.DueDate = DateTime.Now
                oPedido.ItemNo = dtEncabezado.Rows(0)("CodigoArticulo").ToString
                oPedido.PlannedQuantity = dtEncabezado.Rows(0)("Unidades").ToString
                oPedido.Warehouse = dtEncabezado.Rows(0)("Destino").ToString
                oPedido.Remarks = dtEncabezado.Rows(0)("Comentario_Nivel1").ToString
                oPedido.UserFields.Fields.Item("U_Tipo").Value = dtEncabezado.Rows(0)("Origen").ToString


                For i = 0 To dtDetalle.Rows.Count - 1
                    If Not i = 0 Then
                        oPedido.Lines.Add()
                    End If

                    oPedido.Lines.ItemNo = dtDetalle.Rows(i)("CodigoArticulo").ToString
                    oPedido.Lines.PlannedQuantity = dtDetalle.Rows(i)("Unidades").ToString
                    oPedido.Lines.Warehouse = dtDetalle.Rows(i)("Origen").ToString

                Next

                Dim oResultado As Integer

                oResultado = oPedido.Add()
                If (oResultado = 0) Then
                    Dim mDocEntry As String = String.Empty
                    Dim mDocNum As String = String.Empty

                    oCompanyGT.GetNewObjectCode(mDocEntry)
                    oPedido.GetByKey(mDocEntry)
                    mDocNum = oPedido.DocumentNumber
                    oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)



                    'MsgBox("Su orden se ha grabado exitosamente. NUMERO ORDEN ENSAMBLE SAP = < " + mDocNum + " >.", MsgBoxStyle.OkOnly, "SAP DIAPI")

                    Return mDocNum
                Else
                    MsgBox(oCompanyGT.GetLastErrorDescription())
                    oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                End If


            Catch ex As Exception
                oCompanyGT.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                MsgBox(ex.Message)
                Return Nothing
            End Try
            Return Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            DesconectarDIAPIGT()
        End Try

    End Function




    Private Sub barbtnAnalsisVenta_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAnalsisVenta.ItemClick
        Try
            Try
                vpCodigoArticulo = "'" + txtCodigoArticulo.EditValue + "'"
                frmTemporal_AnalisisVenta.ShowDialog()
            Catch ex As Exception
                mMensajes.msg_Error(ex.Message.ToString)
            End Try

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub grdviewCP_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles grdviewCP.ValidateRow
        Try
            'If e.Column.FieldName = "OrigenAR" Then
            '    Dim gv As GridView = sender
            '    'Dim FieldName As String = gv.GetDetailView(e.RowHandle, 0).GetRow(e.RowHandle)("CodigoCP").ToString.Substring(0, 2)
            '    Dim Focus1 As Integer = grdviewArticulos.FocusedRowHandle
            '    Dim grdviewCPS As GridView = grdviewArticulos.GetDetailView(Focus1, 0)
            '    'Dim Focus2 As Integer = grdviewCPS.FocusedRowHandle
            '    Dim Focus2 As Integer = e.RowHandle
            '    'Dim Focus2 As Integer = grdviewArticulos.GetDetailView(grdviewArticulos.FocusedRowHandle(), 0).
            '    If Focus2 > -1 Then
            '        Dim Columna As String = grdviewArticulos.GetDetailView(Focus1, 0).GetRow(Focus2)("CodigoCP").ToString.Substring(0, 2)
            '        If grdIngresoOrdenes.FocusedView.Name = "grdviewCP" Then
            '            If Not Columna = String.Empty Then
            '                Select Case (Columna)
            '                    Case "AR"
            '                        'e.RepositoryItem
            '                        e.RepositoryItem = rslueOrigen
            '                    Case "CP"
            '                        'grdviewCP.Columns("OrigenAR").ColumnEdit = rslueDestino
            '                        e.RepositoryItem = rslueDestino
            '                End Select
            '            End If
            '        End If
            '    End If
            'End If

            e.Valid = True
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub grdIngresoOrdenes_ProcessGridKey(sender As Object, e As KeyEventArgs) Handles grdIngresoOrdenes.ProcessGridKey
    '    If e.KeyData = keys.Control + Keys.Delete Then
    '        If mMensajes.msg_Eliminar() Then


    '            grdviewCP.DeleteRow(grdviewCP.FocusedRowHandle)

    '            'grdviewCP.DeleteRow(grdviewCP.GetVisibleDetailView(grdviewArticulos.GetRowHandle))

    '            e.Handled = True
    '        End If
    '    End If

    'End Sub

    Private Sub grdviewCP_KeyDown(sender As Object, e As KeyEventArgs) Handles grdviewCP.KeyDown
        If (e.KeyCode = Keys.Delete And e.Modifiers = Keys.Control) Then
            If (MessageBox.Show("Desea eliminar la fila seleccionada?", "Confirmacion", _
              MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            Dim view As GridView = CType(sender, GridView)
            view.DeleteRow(view.FocusedRowHandle)
        End If

    End Sub

    Private Sub grdviewCP_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles grdviewCP.RowUpdated

        Try
            grdviewCP.Columns("Cantidad").OptionsColumn.AllowEdit = False
            grdviewCP.Columns("Cantidad").OptionsColumn.AllowFocus = False

            '---------------------------------------------
            'Dim FieldName As String

            'FieldName = vpCodigoArticulo2.ToString.Substring(0, 2)

            'Select Case (FieldName)
            '    Case "AR"
            '        grdviewCP.Columns("OrigenAR").ColumnEdit = rslueOrigen
            '    Case "CP"
            '        grdviewCP.Columns("OrigenAR").ColumnEdit = rslueDestino
            'End Select


            '--------------------------------------------





            Dim vAgregar As Boolean = False
            If Not IsNothing(vpCodigoArticulo2) Then
                If vpCodigoArticulo2.ToString.Substring(0, 2) = "AR" Then

                    For i = 0 To DsIngresoOrden1.Tables("dsdtCP2").Rows.Count - 1
                        If DsIngresoOrden1.Tables("dsdtCP2").Rows(i)("CodigoArticulo").ToString() = vpCodigoArticulo2 Then
                            vAgregar = False
                            Exit Sub
                        End If
                    Next


                    Dim dtListaMaterialesCP As New DataTable("dtListaMaterialesCP")
                    dtListaMaterialesCP = mSQLSelect.GET_ListaMaterialesCP_XArticulo("'" + vpCodigoArticulo2 + "'")

                    Dim rowCP As DataRow 'Aloja la Linea Completa antes de darsela al DataTable
                    Dim dtCP As New DataTable("CP") 'DataTable para Alojar la Data
                    Dim columnsCP As New DataColumn 'Creacion de Columnas
                    'CREACION DE TABLA ENCABEZADO XP 
                    columnsCP = New DataColumn("Id", Type.GetType("System.Int32"))
                    dtCP.Columns.Add(columnsCP)
                    columnsCP = New DataColumn("CodigoArticulo", Type.GetType("System.String"))
                    dtCP.Columns.Add(columnsCP)
                    columnsCP = New DataColumn("CodigoCP", Type.GetType("System.String"))
                    dtCP.Columns.Add(columnsCP)
                    columnsCP = New DataColumn("NombreCP", Type.GetType("System.String"))
                    dtCP.Columns.Add(columnsCP)
                    columnsCP = New DataColumn("Stock", Type.GetType("System.Int32"))
                    dtCP.Columns.Add(columnsCP)
                    columnsCP = New DataColumn("U/M", Type.GetType("System.String"))
                    dtCP.Columns.Add(columnsCP)
                    columnsCP = New DataColumn("Cantidad", Type.GetType("System.Decimal"))
                    dtCP.Columns.Add(columnsCP)
                    columnsCP = New DataColumn("Almacen", Type.GetType("System.Decimal"))
                    dtCP.Columns.Add(columnsCP)
                    columnsCP = New DataColumn("Metasa", Type.GetType("System.Decimal"))
                    dtCP.Columns.Add(columnsCP)
                    columnsCP = New DataColumn("Pradera", Type.GetType("System.Decimal"))
                    dtCP.Columns.Add(columnsCP)

                    columnsCP = New DataColumn("Produccion", Type.GetType("System.String"))
                    dtCP.Columns.Add(columnsCP)
                    columnsCP = New DataColumn("Comprometido", Type.GetType("System.String"))
                    dtCP.Columns.Add(columnsCP)


                    columnsCP = New DataColumn("Producir", Type.GetType("System.Decimal"))
                    dtCP.Columns.Add(columnsCP)
                    columnsCP = New DataColumn("DestinoCP", Type.GetType("System.String"))
                    dtCP.Columns.Add(columnsCP)
                    columnsCP = New DataColumn("OrigenAR", Type.GetType("System.String"))
                    dtCP.Columns.Add(columnsCP)

                    For i = 1 To 25
                        For j = 0 To dtListaMaterialesCP.Rows.Count - 1
                            rowCP = dtCP.NewRow() 'Agrega Row Nueva al DataTable
                            'Agrega Valores al Datatable
                            rowCP("Id") = i
                            rowCP("OrigenAR") = "PI"
                            rowCP("CodigoArticulo") = dtListaMaterialesCP.Rows(j)("CodigoArticulo").ToString
                            rowCP("CodigoCP") = dtListaMaterialesCP.Rows(j)("CodigoCP").ToString
                            rowCP("NombreCP") = dtListaMaterialesCP.Rows(j)("NombreCP").ToString
                            rowCP("Stock") = dtListaMaterialesCP.Rows(j)("Stock").ToString
                            rowCP("U/M") = dtListaMaterialesCP.Rows(j)("U/M").ToString
                            rowCP("Cantidad") = dtListaMaterialesCP.Rows(j)("Cantidad").ToString
                            rowCP("Almacen") = dtListaMaterialesCP.Rows(j)("Almacen").ToString
                            rowCP("Metasa") = dtListaMaterialesCP.Rows(j)("Metasa").ToString
                            rowCP("Pradera") = dtListaMaterialesCP.Rows(j)("Pradera").ToString
                            rowCP("Produccion") = dtListaMaterialesCP.Rows(j)("Produccion").ToString
                            rowCP("Comprometido") = dtListaMaterialesCP.Rows(j)("Comprometido").ToString
                            rowCP("Producir") = dtListaMaterialesCP.Rows(j)("Producir").ToString
                            rowCP("DestinoCP") = "PI"


                            dtCP.Rows.Add(rowCP) 'Agrega la Columna en Memoria Al DataTable en Memoria
                        Next
                    Next

                    'DsIngresoOrden1.Tables("dsdtCP2").Clear() 'Borrar DataSet
                    DsIngresoOrden1.Tables("dsdtCP2").Merge(dtCP) 'Llenar DSDT con Qry

                End If
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub grdviewArticulos_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles grdviewArticulos.FocusedRowChanged
        Try


            If grdviewArticulos.GetMasterRowExpanded(e.FocusedRowHandle) Then
                grdviewArticulos.CollapseAllDetails()
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub grdviewCP2_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles grdviewCP2.CellValueChanged
        Try

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnSAP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSAP.ItemClick
        Try

            txtCodigoArticulo.Focus()

            If Not mMensajes.msg_Grabar() Then
                Exit Sub
            End If
            If Not ssmEsperar.IsSplashFormVisible Then : ssmEsperar.ShowWaitForm() : End If
            Set_InformacionDB()

            Dim dtSAPResultados As New DataTable("dtSAPResultados")
            Dim Row As DataRow

            Dim dtID_E As New DataTable("dtID_E")
            Dim dtID_P As New DataTable("dtID_P")

            dtSAPResultados = mSQLSelect.CrearTabla_OrdenesSubidas()

            dtID_E = mSQLSelect.GET_OrdenesEnsamble_ASubir() 'GET Numero Ordenes pendientes de Subir

            If Not dtID_E.Rows.Count = Nothing Then 'Recorre los numero de ID pendientes de Subir

                For i = 0 To dtID_E.Rows.Count - 1
                    Dim dtEEcount As New DataTable("dtEEcount")
                    dtEEcount = mSQLSelect.GET_EE(dtID_E.Rows(i)("Id").ToString) 'Recorre los encabezados que hacen falta subir

                    For j = 0 To dtEEcount.Rows.Count - 1
                        Dim dtEE As New DataTable("dtEE")
                        Dim dtED As New DataTable("dtED")
                        dtEE = mSQLSelect.GET_EE(dtID_E.Rows(i)("Id"), dtEEcount.Rows(j)("Id_Nivel1"))
                        dtED = mSQLSelect.GET_ED(dtID_E.Rows(i)("Id"), dtEEcount.Rows(j)("Id_Nivel1"))

                        Dim DocNum As String
                        DocNum = SAP_DIAPI_OrdenesEnsamble(dtEE, dtED) 'Sube a SAP las Ordenes de Ensamble
                        If Not DocNum = String.Empty Then
                            mSQLUpdate.UPDATE_ENSAMBLE_NoSap_Y_Status(DocNum, dtID_E.Rows(i)("Id"), dtEEcount.Rows(j)("Id_Nivel1")) 'Actualiza el numero de Orden SAP
                        End If

                        'Agregar Resultados de SAP
                        Row = dtSAPResultados.NewRow()
                        Row("Tipo") = "ENSAMBLE"
                        Row("NumeroSAP") = DocNum
                        Row("CodigoArticulo") = dtEE.Rows(0)("CodigoArticulo").ToString
                        Row("Unidades") = dtEE.Rows(0)("Unidades").ToString
                        Row("Origen") = dtEE.Rows(0)("Origen").ToString
                        Row("Destino") = dtEE.Rows(0)("Destino").ToString
                        dtSAPResultados.Rows.Add(Row)
                    Next
                Next
            End If

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
                If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
                vpTabla1 = dtSAPResultados
                frmResultadoOrdenesIngresadas.ShowDialog()
                Me.Close()
            End If




        Catch ex As Exception
            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class