Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.GridControl
Imports DevExpress.Xpo
Imports DevExpress.XtraSplashScreen

Public Class frmOrdenEnsambleProduccion
    Private pCodigosArticulos As String
    Private pCodigosArticuloOrigen As String
    Private pTipo As String

    Public Property ppTipo() As String
        Get
            Return pTipo
        End Get
        Set(ByVal Value As String)
            pTipo = Value
        End Set
    End Property


    Public Property ppCodigosArticulos() As String
        Get
            Return pCodigosArticulos
        End Get
        Set(ByVal Value As String)
            pCodigosArticulos = Value
        End Set
    End Property

    Public Property ppCodigosArticuloOrigen() As String
        Get
            Return pCodigosArticuloOrigen
        End Get
        Set(ByVal Value As String)
            pCodigosArticuloOrigen = Value
        End Set
    End Property



    Private Sub frmOrdenEnsambleProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mSeguridad.APG_Seguridad(Me, barbtnSAP)
            mSeguridad.APG_Seguridad(Me, barbtn)
            mSeguridad.APG_Seguridad(Me, barbtnEnsamble)
            mSeguridad.APG_Seguridad(Me, barbtnProduccion)
            mSeguridad.APG_Seguridad(Me, barbtnDeudaRol)
            mSeguridad.APG_Seguridad(Me, barbtnDeudaCampana)
            mSeguridad.APG_Seguridad(Me, barbtnDeudaProyeccion)
            mSeguridad.APG_Seguridad(Me, barbtnAnalisisVenta)
            mSeguridad.APG_Seguridad(Me, barbtnComponente)

            splitOrdenesEnsamble.SplitterPosition = lycOrdenEnsambleProduccion.Height * 0.2
            splitResultado.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1

            '----Llenar los listados en los controles ----'
            '---------------------------------------------'
            Sub_Fill_Controles()


            Dim pIdNivel1 As Integer = GET_OrdenesProduccion_Temporal().Rows.Count

            If pIdNivel1 = 0 Then
                '----Eliminar Transacciones Pendientes----'
                DELETE_PROD_Ordenes_Detalle_Temporal()
            Else
                If MsgBox("Existen ORDENES pendientes de subir a SAP. " + Environment.NewLine + "desea vizualizarlos?", MsgBoxStyle.YesNo, "Ordenes pendientes") = MsgBoxResult.Yes Then
                    txtIdNivel1.EditValue = pIdNivel1
                    Fill_Grid_ResultadoOrdenesPendientesSubirSAP()
                    chkArticulosSugeridos.Checked = False
                    chkResultadoOrdenes.Checked = True
                    splitResultado.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
                    splitOrdenesEnsamble.SplitterPosition = lycOrdenEnsambleProduccion.Height * 0.5

                Else
                    '----Eliminar Transacciones Pendientes----'
                    DELETE_PROD_Ordenes_Detalle_Temporal()
                End If
            End If




            'Llenar Grid de Articulos------------------'
            '------------------------------------------'
            Dim dtHijos As New DataTable("dtHijos")
            dtHijos = mSQLSelect.GET_AnalisisNecesidades(pCodigosArticulos)
            If dtHijos.Rows.Count = Nothing Then
                mMensajes.msg_Informacion("No existen articulos para mostrar")
                Me.Close()
            End If
            DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtCodigosArticulos.TableName.ToString).Clear()

            'Quitar restricciones
            '' Deshabilitar restricciones antes del Merge
            'DsOrdenEnsambleProduccion1.EnforceConstraints = False

            '' Realizar el Merge
            'DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtCodigosArticulos.TableName.ToString).Merge(dtHijos)

            '' Habilitar restricciones nuevamente
            'DsOrdenEnsambleProduccion1.EnforceConstraints = True


            Try
                ' Deshabilitar restricciones antes del Merge
                DsOrdenEnsambleProduccion1.EnforceConstraints = False

                ' Realizar el Merge
                DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtCodigosArticulos.TableName.ToString).Merge(dtHijos)

                ' Verificar si hay errores en las filas después del Merge
                Dim errores As DataRow() = DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtCodigosArticulos.TableName.ToString).GetErrors()

                If errores.Length > 0 Then
                    MessageBox.Show("Se encontraron las siguientes filas con errores:")
                    For Each fila As DataRow In errores
                        MessageBox.Show($"Error en fila {DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtCodigosArticulos.TableName.ToString).Rows.IndexOf(fila)}")
                        For Each columna As DataColumn In fila.Table.Columns
                            If fila.HasErrors Then
                                MessageBox.Show($"Columna: {columna.ColumnName}, Error: {fila.RowError}")
                            End If
                        Next
                    Next
                    ' Aquí podrías manejar los errores, como eliminarlos o corregirlos.
                    Throw New ConstraintException("Se detectaron errores de restricciones en el DataTable. Revisa las filas problemáticas.")
                End If

                ' Si no hay errores, habilitar las restricciones
                'DsOrdenEnsambleProduccion1.EnforceConstraints = True

            Catch ex As ConstraintException
                ' Manejo del error de restricciones
                MessageBox.Show("Error al habilitar restricciones: " & ex.Message)
                mMensajes.msg_Error("Error de restricción: " & ex.Message)
            End Try



            'DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtCodigosArticulos.TableName.ToString).Merge(dtHijos)


            DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtArticulos.TableName.ToString).Clear()
            DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtComponentesProducidos.TableName.ToString).Clear()

            'Llenar Grid Hijos

            'dtHijos = mSQLSelect.GET_Listado_CodigoArticulos_Hijos(vpCodigoArticulo.Substring(1, 8))
            'If Not dtHijos.Rows.Count = Nothing Then
            '    DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtHijos.TableName.ToString).Clear()
            '    DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtHijos.TableName.ToString).Merge(dtHijos)
            'End If


            If Not grdviewHijos.RowCount = Nothing Then
                grdviewHijos.FocusedRowHandle = grdviewHijos.LocateByValue("CodigoArticulo", pCodigosArticuloOrigen)
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Fill_Controles()
        Try

            mFunciones.FCN_FILL_SearchLookUpEdit(rslueOrigen, mSQLSelect.GET_PROD_CatListados("Orden_Origen"), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueOrigen1, mSQLSelect.GET_PROD_CatListados("Orden_Origen"), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueOrigen2, mSQLSelect.GET_PROD_CatListados("Orden_Origen"), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueOrigenAR, mSQLSelect.GET_PROD_CatListados("Orden_Origen"), "Id", "Nombre")

            mFunciones.FCN_FILL_SearchLookUpEdit(rslueDestino, mSQLSelect.GET_Listado_Bodegas(), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueDestinoAR, mSQLSelect.GET_Listado_Bodegas(), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueCodigoCP, mSQLSelect.GET_ListaMaterialesARCPCC(), "CodigoArticulo", "CodigoArticulo")
            mFunciones.FCN_FILL_SearchLookUpEdit(rsluePrioridadAR, mSQLSelect.GET_PROD_CatListados("Tipo_Prioridad"), "Id", "Nombre")

            mFunciones.FCN_FILL_SearchLookUpEdit(rslueColores, mSQLSelect.GET_Catalogo_Colores(), "Id", "Id")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueGrupoCliente, mSQLSelect.GET_Listado_GrupoClientes(), "Id", "Nombre")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueCodigoCliente, mSQLSelect.GET_Catalogo_ClientesDisponibles(), "CodigoCliente", "CodigoCliente")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueNumOrdenVenta, mSQLSelect.GET_Listado_OrdenesVentaDisponibles(), "NumOrden", "NumOrden")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueNumCampana, mSQLSelect.GET_Listado_CampanaVigentes, "Id", "Id")
            mFunciones.FCN_FILL_SearchLookUpEdit(rsluePrioridadCP, mSQLSelect.GET_PROD_CatListados("Tipo_Prioridad"), "Id", "Nombre")

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub


    Private Sub grdviewHijos_DoubleClick(sender As Object, e As EventArgs) Handles grdviewHijos.DoubleClick
        Try
            Try
                'limpiar controles
                DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtArticulos.TableName.ToString).Clear()
                DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtComponentesProducidos.TableName.ToString).Clear()

                Dim pCodigoArticulo As String = String.Empty
                Dim dtArticulos_MasArticulosEnListaMateriales As New DataTable("dtArticulosABuscar")
                Dim dtArticulos As New DataTable("dtArticulos")
                Dim pArticulos As String = String.Empty

                pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewHijos, "CodigoArticulo", grdviewHijos.FocusedRowHandle)
                dtArticulos_MasArticulosEnListaMateriales = mSQLSelect.GET_Listado_CodigoArticulos_MasArticulosEnListaMateriales(pCodigoArticulo)

                If dtArticulos_MasArticulosEnListaMateriales.Rows.Count = Nothing Then
                    Exit Sub
                End If

                For i = 0 To dtArticulos_MasArticulosEnListaMateriales.Rows.Count - 1
                    If i = 0 Then
                        pArticulos = "'" + dtArticulos_MasArticulosEnListaMateriales.Rows(i)("CodigoArticulo").ToString + "'"
                    Else
                        pArticulos = pArticulos + ",'" + dtArticulos_MasArticulosEnListaMateriales.Rows(i)("CodigoArticulo").ToString + "'"
                    End If
                Next

                dtArticulos = mSQLSelect.GET_AnalisisArticulos_XFiltro(pArticulos)

                If dtArticulos.Rows.Count = Nothing Then : Exit Sub : End If

                DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtArticulos.TableName.ToString).Clear()
                DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtArticulos.TableName.ToString).Merge(dtArticulos)

                'Valores Default de Codigos de Articulo
                For i = 0 To DsOrdenEnsambleProduccion1.dsdtArticulos.Rows.Count - 1
                    DsOrdenEnsambleProduccion1.dsdtArticulos.Rows(i)("Origen") = "0"
                    DsOrdenEnsambleProduccion1.dsdtArticulos.Rows(i)("Destino") = "PT"
                    DsOrdenEnsambleProduccion1.dsdtArticulos.Rows(i)("Prioridad") = "5"
                Next

                'chkArticulosSugeridos.Checked = False

            Catch ex As Exception
                mMensajes.msg_Error(ex.Message.ToString)
            End Try
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub grdviewArticulos_DoubleClick(sender As Object, e As EventArgs) Handles grdviewArticulos.DoubleClick
        Try
            Fill_ComponentesProducidos()
            'Fill_DatosGenerales()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    'Private Sub Fill_DatosGenerales()
    '    Try
    '        Dim dt As New DataTable("dtDatos")
    '        Dim pCodigoArticulo As String = "'" + mFunciones.FCN_GetCellValue(grdviewArticulos, "CodigoArticulo", grdviewArticulos.FocusedRowHandle) + "'"
    '        dt = mSQLSelect.GET_AnalisisArticulos_XFiltro(pCodigoArticulo)
    '        If Not dt.Rows.Count = Nothing Then
    '            txtCodigoArticulo.EditValue = dt.Rows(0)("CodigoArticulo").ToString
    '            txtNombreArticulo.EditValue = dt.Rows(0)("NombreArticulo").ToString
    '            txtDeLinea.EditValue = dt.Rows(0)("DeLinea").ToString
    '            txtStock.EditValue = dt.Rows(0)("Stock").ToString
    '            txtEnsamble.EditValue = dt.Rows(0)("Ensamble").ToString
    '            txtProduccion.Text = dt.Rows(0)("Produccion").ToString
    '            'Calculo de Ingresos
    '            txtTotalPositivo.EditValue = Val(txtStock.Text) + Val(txtEnsamble.Text) + Val(txtProduccion.Text)

    '            txtDeudaRol.EditValue = dt.Rows(0)("DeudaRol").ToString
    '            txtDeudaCampana.EditValue = dt.Rows(0)("DeudaCampana").ToString
    '            txtDeudaProyeccion.EditValue = dt.Rows(0)("DeudaProyeccion").ToString

    '            'Calculo de Egresos y Disponible
    '            txtTotalNegativo.EditValue = Val(txtDeudaRol.Text) + Val(txtDeudaCampana.Text) + Val(txtDeudaProyeccion.Text)

    '            If Val(txtDeudaProyeccion.Text) > Val(txtDeudaCampana.Text) Then
    '                txtTotalNegativo.EditValue = Val(txtDeudaRol.Text) + (Val(txtDeudaProyeccion.Text)) '- Val(txtDeudaCampana.Text))
    '            Else
    '                txtTotalNegativo.EditValue = Val(txtDeudaRol.Text) + Val(txtDeudaCampana.Text)
    '            End If

    '            txtDisponible.EditValue = Val(txtTotalPositivo.Text) - Val(txtTotalNegativo.Text)

    '            txtStockMin.EditValue = dt.Rows(0)("StockMinimo").ToString
    '            txtStockMax.EditValue = dt.Rows(0)("StockMaximo").ToString

    '            If txtStockMax.EditValue > 0 Then
    '                If txtStockMax.EditValue > txtDisponible.EditValue Then
    '                    txtSugerido.EditValue = Val(txtStockMax.Text) - Val(txtDisponible.Text)
    '                End If
    '            Else
    '                txtSugerido.EditValue = String.Empty
    '            End If

    '        End If




    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message.ToString)
    '    End Try


    'End Sub

    Private Function Fill_ComponentesProducidos() As Boolean
        Try

            If Not DsOrdenEnsambleProduccion1.dsdtComponentesProducidos.Rows.Count = Nothing Then
                If MsgBox("Desea sustituir los Componentes Actuales?", MsgBoxStyle.YesNo, "Sustituir") = MsgBoxResult.No Then
                    Return False
                End If
            End If

            Dim dtComponentesProducidos As New DataTable("dtComponentesProducidos")
            Dim pCodigoArticulo As String = String.Empty
            pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewArticulos, "CodigoArticulo", grdviewArticulos.FocusedRowHandle)

            If pCodigoArticulo = String.Empty Then : Return False : End If


            'dtComponentesProducidos = mSQLSelect.GET_ListaMaterialesCP_XArticulo("'" + pCodigoArticulo + "'") CAMBIO 2018 01 31

            'SELECCION PARA AGREGAR DE LA LISTA DE MATERIALES SOLO <CP> O AMBOS <CP,CC>
            'If chkCC.CheckState = CheckState.Checked Then

            'Else
            '    dtComponentesProducidos = mSQLSelect.GET_ListaMaterialesAnalisisARCP("'" + pCodigoArticulo + "'")
            'End If

            dtComponentesProducidos = mSQLSelect.GET_ListaMaterialesAnalisisARCPCCMO("'" + pCodigoArticulo + "'")

            Dim pCantidadEnsamble As String = String.Empty
            pCantidadEnsamble = mFunciones.FCN_GetCellValue(grdviewArticulos, "CantidadEnsamble")

            If dtComponentesProducidos.Rows.Count = Nothing Then : Return False : End If

            DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtComponentesProducidos.TableName.ToString).Clear()
            DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtComponentesProducidos.TableName.ToString).Merge(dtComponentesProducidos)

            For i = 0 To DsOrdenEnsambleProduccion1.dsdtComponentesProducidos.Rows.Count - 1
                DsOrdenEnsambleProduccion1.dsdtComponentesProducidos.Rows(i)("OrigenAR") = "PI"
                DsOrdenEnsambleProduccion1.dsdtComponentesProducidos.Rows(i)("DestinoCP") = "PI"
                DsOrdenEnsambleProduccion1.dsdtComponentesProducidos.Rows(i)("Producir") = DsOrdenEnsambleProduccion1.dsdtComponentesProducidos.Rows(i)("Cantidad") * Val(pCantidadEnsamble)
                DsOrdenEnsambleProduccion1.dsdtComponentesProducidos.Rows(i)("Prioridad") = mFunciones.FCN_GetCellValue(grdviewArticulos, "Prioridad")
            Next

            Return True
        Catch ex As Exception
            Return False
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Function


    Private Sub barbtnEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEliminar.ItemClick
        Try

            If grdviewComponentesProducidos.IsFocusedView() Then
                If (MessageBox.Show("Desea eliminar el Componente Seleccionado?", "Eliminar",
              MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
                'Dim view As GridView = CType(sender, GridView)
                Dim view As GridView = grdviewComponentesProducidos
                view.DeleteRow(view.FocusedRowHandle)

            ElseIf grdviewEnsambles.IsFocusedView() Then

                If MsgBox("Desea Eliminar el Ensamble junto con sus Producciones seleccionadas?", MsgBoxStyle.YesNo, "Eliminar") = MsgBoxResult.Yes Then
                    Dim Id As String = mFunciones.FCN_GetCellValue(grdviewEnsambles, "Id_Nivel1")
                    DELETE_PROD_Ordenes_Detalle_Temporal(Id)
                End If

                'FINNALLY
                Dim dtEnsambleEncabezado As New DataTable("dtEnsambleEncabezado")
                Dim dtEnsambleDetalle As New DataTable("dtEnsambleDetalle")
                Dim dtProduccionEncabezado As New DataTable("dtProduccionEncabezado")

                dtEnsambleEncabezado = mSQLSelect.GET_Fill_EnsambleProduccion_PendienteSubir("EE")
                DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtEnsambleEncabezado.TableName.ToString).Clear()
                DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtEnsambleEncabezado.TableName.ToString).Merge(dtEnsambleEncabezado)

                dtEnsambleDetalle = mSQLSelect.GET_Fill_EnsambleProduccion_PendienteSubir("ED")
                DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtEnsambleDetalle.TableName.ToString).Clear()
                DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtEnsambleDetalle.TableName.ToString).Merge(dtEnsambleDetalle)

                dtProduccionEncabezado = mSQLSelect.GET_Fill_EnsambleProduccion_PendienteSubir("PE")
                DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtProduccionEncabezado.TableName.ToString).Clear()
                DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtProduccionEncabezado.TableName.ToString).Merge(dtProduccionEncabezado)

            End If







        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)

        End Try


    End Sub



    Private Sub grdviewComponentesProducidos_CellValueChanged(sender As Object, e As CellValueChangedEventArgs)


    End Sub


    Private Sub barbtnAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAgregar.ItemClick
        Try
            'Verificar que existan articulos seleccionados para agregar a la cola de SAP.
            If grdviewArticulos.RowCount = Nothing Then
                mMensajes.msg_Error("Seleccione un Articulo para continuar.")
                Exit Sub
            End If

            'COMPONENTES PRODUCIDOS*****************************
            'Verificar que exista una cantidad mayor a 0 y que tenga una prioridad existente. COMPONENTES PRODUCIDOS
            For i = 0 To grdviewComponentesProducidos.RowCount - 1
                If mFunciones.FCN_GetCellValue(grdviewComponentesProducidos, "Prioridad", i) = Nothing Then
                    mMensajes.msg_Informacion("Existen Codigos que necesita establecer: " + Environment.NewLine +
                                              "PRIORIDAD")
                    Exit Sub
                ElseIf Not Val(mFunciones.FCN_GetCellValue(grdviewComponentesProducidos, "Cantidad", i)) > 0 Then
                    mMensajes.msg_Informacion("Existen Codigos que necesita establecer: " + Environment.NewLine +
                                              "CANTIDAD BASE")
                    Exit Sub
                ElseIf Not Val(mFunciones.FCN_GetCellValue(grdviewComponentesProducidos, "Producir", i)) > 0 Then
                    If MsgBox("El codigo " + mFunciones.FCN_GetCellValue(grdviewComponentesProducidos, "CodigoCP", i).ToString _
                                              + " tiene Cero en Cantidad a Producir. " + Environment.NewLine + " Desea continuar.", vbYesNo, "Cantidad Cero") = MsgBoxResult.No Then
                        Exit Sub
                    End If

                End If


            Next

            'ARTICULOS******************************************

            'Verifica que tenga prioridad de Ensamble
            Dim pPrioridad As String = String.Empty
            pPrioridad = mFunciones.FCN_GetCellValue(grdviewArticulos, "Prioridad")
            If pPrioridad = String.Empty Or pPrioridad = Nothing Then
                mMensajes.msg_Error("Debe de ingresar una Prioridad para este Ensamble")
                Exit Sub
            End If
            'Verifica que tenga cantidad de Ensamble
            Dim pCantidad As String = mFunciones.FCN_GetCellValue(grdviewArticulos, "CantidadEnsamble")
            If pCantidad = String.Empty Or pCantidad = Nothing Then
                mMensajes.msg_Error("Ingresar cantidad para ENSAMBLE")
                Exit Sub
            End If
            'Verifica que tenega detalle el Articulo para poder hacer la orden de Ensamble
            If grdviewComponentesProducidos.RowCount = Nothing Then
                mMensajes.msg_Error("Para poder agregar un ensamble se necesita como minimo [ 1 ] componente para ensamble!")
                Exit Sub
            End If

            'Preparar el Ambiente
            grdviewArticulos.CloseEditor()
            grdviewComponentesProducidos.CloseEditor()
            Dim dtEncabezado As New DataTable("dtEncabezado")
            Dim dtDetalle As New DataTable("dtDetalle")
            Dim dtProducciones As New DataTable("dtProducciones")
            Dim Row As DataRow
            dtEncabezado = mSQLSelect.GET_PROD_OrdenesEnsambleProduccion_Detalle_Temporal_TOP0()
            dtDetalle = mSQLSelect.GET_PROD_OrdenesEnsambleProduccion_Detalle_Temporal_TOP0()
            dtProducciones = mSQLSelect.GET_PROD_OrdenesEnsambleProduccion_Detalle_Temporal_TOP0()

            'Encabezado Ensamble
            Row = dtEncabezado.NewRow()
            Row("Id") = "1"
            Row("Id_Nivel1") = txtIdNivel1.EditValue
            Row("Id_Nivel2") = "-1"
            Row("Tipo") = "EE"
            Row("NumeroSAP") = "N"
            Row("Prioridad") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "Prioridad")
            Row("CodigoArticulo") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "CodigoArticulo")
            Row("Unidades") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "CantidadEnsamble")
            Row("Origen") = mFunciones.FCN_GetCellValue(grdviewArticulos, "Origen").ToString
            'Row("Origen") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "Origen")
            Row("Destino") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "Destino")
            Row("Entrega") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "FechaEntrega")
            Row("Comentario_Nivel1") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "Comentarios")
            Row("NumeroCampana") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "NumCampana")
            Row("Color") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "Color")
            Row("GrupoCliente") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "GrupoCliente")
            Row("CodigoCliente") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "CodigoCliente")
            Row("NumeroOrden") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "NumOrden")
            Row("SAP") = "False"
            Row("Estatus") = "False"
            Row("Bit_UsuarioCreacion") = My.Settings.log_Usuario.ToString
            dtEncabezado.Rows.Add(Row)

            'Detalle Ensamble

            For i = 0 To grdviewComponentesProducidos.RowCount - 1

                'Encabezado Ensamble
                Row = dtDetalle.NewRow()
                Row("Id") = "0"
                Row("Id_Nivel1") = txtIdNivel1.EditValue
                Row("Id_Nivel2") = grdviewComponentesProducidos.FocusedRowHandle

                If chkCC.Checked = True Then
                    Row("Tipo") = "ED"
                Else
                    If grdviewComponentesProducidos.GetRowCellValue(i, "CodigoCP").ToString.Substring(0, 2) = "CP" _
                        Or grdviewComponentesProducidos.GetRowCellValue(i, "CodigoCP").ToString.Substring(0, 2) = "AR" _
                        Or grdviewComponentesProducidos.GetRowCellValue(i, "CodigoCP").ToString.Substring(0, 2) = "MO" Then
                        Row("Tipo") = "ED"
                    Else
                        Row("Tipo") = "EA"
                    End If
                End If



                Row("NumeroSAP") = "N"
                Row("CodigoArticulo") = grdviewComponentesProducidos.GetRowCellValue(i, "CodigoCP")
                Row("Unidades") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "CantidadEnsamble") * grdviewComponentesProducidos.GetRowCellValue(i, "Cantidad")
                Row("Origen") = grdviewComponentesProducidos.GetRowCellValue(i, "OrigenAR")
                Row("Destino") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "Destino") ' ????????
                Row("Comentario_Nivel1") = grdviewComponentesProducidos.GetRowCellValue(i, "Comentario")


                Row("Entrega") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "FechaEntrega")
                Row("NumeroCampana") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "NumCampana")
                Row("Color") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "Color")
                Row("GrupoCliente") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "GrupoCliente")
                Row("CodigoCliente") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "CodigoCliente")
                Row("NumeroOrden") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "NumOrden")
                Row("SAP") = "False"
                Row("Estatus") = "False"
                Row("Bit_UsuarioCreacion") = My.Settings.log_Usuario.ToString
                dtDetalle.Rows.Add(Row)



            Next

            'For i = 0 To grdviewComponentesProducidos.RowCount - 1
            '    'Encabezado Ensamble
            '    Row = dtDetalle.NewRow()
            '    Row("Id") = "0"
            '    Row("Id_Nivel1") = txtIdNivel1.EditValue
            '    Row("Id_Nivel2") = grdviewComponentesProducidos.FocusedRowHandle
            '    Row("Tipo") = "ED"
            '    Row("NumeroSAP") = "N"
            '    Row("CodigoArticulo") = grdviewComponentesProducidos.GetRowCellValue(i, "CodigoCP")
            '    Row("Unidades") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "CantidadEnsamble") * grdviewComponentesProducidos.GetRowCellValue(i, "Cantidad")
            '    Row("Origen") = grdviewComponentesProducidos.GetRowCellValue(i, "OrigenAR")
            '    Row("Destino") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "Destino") ' ????????
            '    Row("Comentario_Nivel1") = grdviewComponentesProducidos.GetRowCellValue(i, "Comentario")


            '    Row("Entrega") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "FechaEntrega")
            '    Row("NumeroCampana") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "NumCampana")
            '    Row("Color") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "Color")
            '    Row("GrupoCliente") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "GrupoCliente")
            '    Row("CodigoCliente") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "CodigoCliente")
            '    Row("NumeroOrden") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "NumOrden")
            '    Row("SAP") = "False"
            '    Row("Estatus") = "False"
            '    Row("Bit_UsuarioCreacion") = My.Settings.log_Usuario.ToString
            '    dtDetalle.Rows.Add(Row)
            'Next



            'Encabezado PRODUCCION
            For i = 0 To grdviewComponentesProducidos.RowCount - 1
                If grdviewComponentesProducidos.GetRowCellValue(i, "CodigoCP").ToString.Substring(0, 2).ToString = "CP" And grdviewComponentesProducidos.GetRowCellValue(i, "Producir") > 0 Then
                    Row = dtProducciones.NewRow()
                    Row("Id") = "0"
                    Row("Id_Nivel1") = txtIdNivel1.EditValue
                    Row("Id_Nivel2") = grdviewComponentesProducidos.FocusedRowHandle
                    Row("Tipo") = "PE"
                    Row("NumeroSAP") = "N"
                    Row("Prioridad") = grdviewComponentesProducidos.GetRowCellValue(i, "Prioridad")
                    Row("CodigoArticulo") = grdviewComponentesProducidos.GetRowCellValue(i, "CodigoCP")
                    Row("Unidades") = grdviewComponentesProducidos.GetRowCellValue(i, "Producir")
                    Row("Origen") = "0"
                    'Row("Origen") = grdviewComponentesProducidos.GetRowCellValue(i, "OrigenAR")
                    Row("Destino") = grdviewComponentesProducidos.GetRowCellValue(i, "DestinoCP")
                    Row("Comentario_Nivel1") = grdviewComponentesProducidos.GetRowCellValue(i, "Comentario")

                    Row("Entrega") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "FechaEntrega")
                    Row("NumeroCampana") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "NumCampana")
                    Row("Color") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "Color")
                    Row("GrupoCliente") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "GrupoCliente")
                    Row("CodigoCliente") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "CodigoCliente")
                    Row("NumeroOrden") = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "NumOrden")
                    Row("SAP") = "False"
                    Row("Estatus") = "False"
                    Row("Bit_UsuarioCreacion") = My.Settings.log_Usuario.ToString
                    dtProducciones.Rows.Add(Row)
                End If
            Next

            If mSQLInsert.INSERT_Ordenes_Detalle_Temporal(dtEncabezado) Then
                If mSQLInsert.INSERT_Ordenes_Detalle_Temporal(dtDetalle) Then
                    If mSQLInsert.INSERT_Ordenes_Detalle_Temporal(dtProducciones) Then
                        txtIdNivel1.Text = Val(txtIdNivel1.Text) + 1 'Aumentar el Contador
                    End If
                End If
            End If

            If MsgBox("Se a grabado con exito. Desea cambiar de Articulo?", MsgBoxStyle.YesNo, "Info.") = MsgBoxResult.Yes Then
                DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtArticulos.TableName.ToString).Clear()
                DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtComponentesProducidos.TableName.ToString).Clear()
            End If






        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            Fill_Grid_ResultadoOrdenesPendientesSubirSAP()
        End Try
    End Sub

    Private Sub Fill_Grid_ResultadoOrdenesPendientesSubirSAP()
        Try
            Dim dtEnsambleEncabezado As New DataTable("dtEnsambleEncabezado")
            Dim dtEnsambleDetalle As New DataTable("dtEnsambleDetalle")
            Dim dtProduccionEncabezado As New DataTable("dtProduccionEncabezado")

            dtEnsambleEncabezado = mSQLSelect.GET_Fill_EnsambleProduccion_PendienteSubir("EE")
            DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtEnsambleEncabezado.TableName.ToString).Clear()
            DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtEnsambleEncabezado.TableName.ToString).Merge(dtEnsambleEncabezado)

            dtEnsambleDetalle = mSQLSelect.GET_Fill_EnsambleProduccion_PendienteSubir("ED")
            DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtEnsambleDetalle.TableName.ToString).Clear()
            DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtEnsambleDetalle.TableName.ToString).Merge(dtEnsambleDetalle)

            dtProduccionEncabezado = mSQLSelect.GET_Fill_EnsambleProduccion_PendienteSubir("PE")
            DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtProduccionEncabezado.TableName.ToString).Clear()
            DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtProduccionEncabezado.TableName.ToString).Merge(dtProduccionEncabezado)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub grdviewArticulos_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles grdviewArticulos.CellValueChanged
        Try
            'Validate(True)

            If e.Column.FieldName = "CantidadEnsamble" Then
                'VERIFICA SI EL CAMPO ES NUMERICO
                If IsNumeric(grdviewArticulos.GetRowCellValue(e.RowHandle, "CantidadEnsamble")) And grdviewArticulos.GetRowCellValue(e.RowHandle, "CantidadEnsamble") > 0 Then
                    Fill_ComponentesProducidos()
                End If


                'If grdviewArticulos.IsMasterRowEmpty(e.RowHandle) Then 'VERIFICA SI NO TIENE DETALLE ASIGNADO
                '    'grdviewArticulos_CellValueChanged(sender, e)
                '    'grdviewArticulos.SetRowCellValue(e.RowHandle, "CantidadEnsamble", 1200)
                '    grdviewArticulos.UpdateCurrentRow()
                '    'mMensajes.msg_Informacion("Grabe primero la linea para poder ver el detalle")
                'Else
                '    grdviewArticulos.ExpandMasterRow(e.RowHandle, 0)

                '    Dim pCantidad As String = 0

                '    If IsNumeric(grdviewArticulos.GetRowCellValue(e.RowHandle, "CantidadEnsamble")) Then 'VERIFICA SI EL CAMPO ES NUMERICO

                '        pCantidad = grdviewArticulos.GetRowCellValue(e.RowHandle, "CantidadEnsamble")

                '        If Not grdviewArticulos.GetDetailView(e.RowHandle, 0).RowCount Then

                '            For i = 0 To grdviewArticulos.GetDetailView(e.RowHandle, 0).RowCount - 1
                '                Dim Unidades As Decimal = 0
                '                Unidades = grdviewArticulos.GetDetailView(e.RowHandle, 0).GetRow(i)("Cantidad")
                '                grdviewArticulos.GetDetailView(grdviewArticulos.FocusedRowHandle, 0).GetRow(i)("Producir") = Convert.ToDecimal(pCantidad * Unidades)
                '            Next
                '        Else
                '            mMensajes.msg_Informacion("Grabe primero la linea para poder ver el detalle")
                '            grdviewArticulos.SetRowCellValue(e.RowHandle, "CantidadEnsamble", Nothing)
                '        End If
                '    End If

                'End If

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

    Private Sub grdviewArticulos_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles grdviewArticulos.FocusedRowChanged
        Try
            DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtComponentesProducidos.TableName.ToString).Clear()

            If Not grdviewArticulos.RowCount = Nothing Then
                'Fill_DatosGenerales()
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewComponentesProducidos_InitNewRow_1(sender As Object, e As InitNewRowEventArgs) Handles grdviewComponentesProducidos.InitNewRow
        Try
            Dim view As GridView = CType(sender, GridView)

            'view.Columns("OrigenAR").ColumnEdit = rslueOrigen
            view.SetRowCellValue(e.RowHandle, view.Columns("OrigenAR"), "PI")
            view.SetRowCellValue(e.RowHandle, view.Columns("DestinoCP"), "PI")
            'grdviewCP.Columns("Cantidad").OptionsColumn.AllowEdit = True
            'grdviewCP.Columns("Cantidad").OptionsColumn.AllowFocus = True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewComponentesProducidos_CellValueChanged_1(sender As Object, e As CellValueChangedEventArgs) Handles grdviewComponentesProducidos.CellValueChanged
        Try
            If e.Column.FieldName = "CodigoCP" Then
                Dim dt As New DataTable
                Dim CodigoCP As String = e.Value
                vpCodigoArticulo2 = CodigoCP 'dar valor a variable

                'VALIDACION DE CODIGOS DISPONIBLES
                If Not mFunciones.FCN_ValidarDisponiblidad_CP("'" + CodigoCP + "'", Me.Name.ToString) Then
                    grdviewComponentesProducidos.SetRowCellValue(e.RowHandle, "NombreCP", DBNull.Value)
                    Exit Sub
                End If
                'FIN DE VALIDACION DE CODIGOS DISPONIBLES

                dt = mSQLSelect.GET_ArticuloCP(CodigoCP)
                If Not dt.Rows.Count = Nothing Then

                    Dim NombreCP As String = dt.Rows(0)("NombreCP").ToString
                    grdviewComponentesProducidos.SetRowCellValue(e.RowHandle, "NombreCP", dt.Rows(0)("NombreCP").ToString)
                    'If grdviewComponentesProducidos.GetRowCellValue(grdviewComponentesProducidos.FocusedRowHandle, "U/M").ToString = String.Empty Then
                    grdviewComponentesProducidos.SetRowCellValue(e.RowHandle, "U/M", "UND")
                    'End If
                    grdviewComponentesProducidos.SetRowCellValue(e.RowHandle, "Stock", dt.Rows(0)("Stock"))
                    grdviewComponentesProducidos.SetRowCellValue(e.RowHandle, "Almacen", dt.Rows(0)("Almacen").ToString)
                    grdviewComponentesProducidos.SetRowCellValue(e.RowHandle, "Metasa", dt.Rows(0)("Metasa").ToString)
                    grdviewComponentesProducidos.SetRowCellValue(e.RowHandle, "Pradera", dt.Rows(0)("Pradera").ToString)
                    'If grdviewComponentesProducidos.GetRowCellValue(grdviewComponentesProducidos.FocusedRowHandle, "Cantidad").ToString = Nothing Then
                    'grdviewComponentesProducidos.SetRowCellValue(e.RowHandle, "Cantidad", "1.000000") ------ ELIMINADO EL 2019 12
                    'End If
                    grdviewComponentesProducidos.SetRowCellValue(e.RowHandle, "Produccion", dt.Rows(0)("Produccion").ToString)
                    grdviewComponentesProducidos.SetRowCellValue(e.RowHandle, "Comprometido", dt.Rows(0)("Comprometido").ToString)

                    'grdviewComponentesProducidos.SetRowCellValue(e.RowHandle, "Producir", "0")
                    grdviewComponentesProducidos.SetRowCellValue(e.RowHandle, "DestinoCP", "PI")

                End If

            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub



    Private Sub barbtnSAP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSAP.ItemClick
        Try
            Sub_barbtnSAP()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_barbtnSAP()
        Try
            Dim IdTrans As String = String.Empty
            Dim pSAP As String = String.Empty
            Dim dtAnalisisXArticulo As New DataTable("dtAnalisisArticulo")
            Dim dtEnsamblesCantidad As New DataTable("dtEnsambleEncabezado")
            Dim dtProduccionesCantidad As New DataTable("dtEnsambleEncabezado")

            Dim dtEnsambleEncabezado As New DataTable("dtEnsambleEncabezado")
            Dim dtEnsambleDetalle As New DataTable("dtEnsambleDetalle")
            Dim dtEnsambleDetalleCompleto As New DataTable()
            Dim dtProduccionEncabezado As New DataTable("dtProduccionEncabezado")
            Dim dtProduccionDetalle As New DataTable("dtProduccionDetalle")

            Dim dtSAPResultados As New DataTable("dtSAPResultados")
            Dim Row As DataRow

            'Validar que este Instanciado
            If ssmEsperar Is Nothing Then
                ssmEsperar = New SplashScreenManager(Me, GetType(splEsperar), True, True)
            End If
            If Not ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.ShowWaitForm() : End If


            dtSAPResultados = mSQLSelect.CrearTabla_OrdenesSubidas()
            'Ensambles
            ssmEsperar.SetWaitFormDescription("Buscando Ensambles y Producciones")
            dtEnsamblesCantidad = mSQLSelect.GET_Fill_EnsambleProduccion_PendienteSubir("EE")

            'For i = 0 To dtEnsamblesCantidad.Rows.Count - 1
            For i = 1 To txtIdNivel1.EditValue - 1
                dtEnsambleEncabezado = mSQLSelect.GET_Fill_EnsambleProduccion_PendienteSubir("EE", i)
                dtEnsambleDetalle = mSQLSelect.GET_Fill_EnsambleProduccion_PendienteSubir("ED", i)
                dtEnsambleDetalleCompleto = mSQLSelect.GET_Fill_EnsambleProduccion_PendienteSubirCompleto(i)

                If Not dtEnsambleEncabezado.Rows.Count = Nothing Then
                    ssmEsperar.SetWaitFormCaption("Subiendo Ensamble")
                    ssmEsperar.SetWaitFormDescription(dtEnsambleEncabezado.Rows(0)("CodigoArticulo").ToString)
                    pSAP = String.Empty
                    pSAP = mDIAPI.SAP_DIAPI_OrdenesEnsamble1(dtEnsambleEncabezado, dtEnsambleDetalle) 'Insertar SAP Ensambles

                    If Not pSAP = String.Empty Then
                        dtAnalisisXArticulo = mSQLSelect.GET_AnalisisArticulos_XFiltro("'" + dtEnsambleEncabezado.Rows(0)("CodigoArticulo").ToString + "'")
                        IdTrans = INSERT_Ordenes_Encabezado(dtEnsambleEncabezado, dtAnalisisXArticulo)
                        If Not IdTrans = String.Empty Then
                            mSQLInsert.INSERT_Ordenes_Detalle(dtEnsambleEncabezado, IdTrans, pSAP)
                            mSQLInsert.INSERT_Ordenes_Detalle(dtEnsambleDetalleCompleto, IdTrans, pSAP)
                            'Agregar Resultados de SAP

                            ssmEsperar.SetWaitFormCaption("Agregando Resultados")
                            ssmEsperar.SetWaitFormDescription(dtEnsambleEncabezado.Rows(0)("CodigoArticulo").ToString)

                            Row = dtSAPResultados.NewRow()
                            Row("Tipo") = "ENSAMBLE"
                            Row("NumeroSAP") = pSAP
                            Row("CodigoArticulo") = dtEnsambleEncabezado.Rows(0)("CodigoArticulo").ToString
                            Row("Unidades") = dtEnsambleEncabezado.Rows(0)("Unidades").ToString
                            Row("Origen") = dtEnsambleEncabezado.Rows(0)("Origen").ToString
                            Row("Destino") = dtEnsambleEncabezado.Rows(0)("Destino").ToString
                            dtSAPResultados.Rows.Add(Row)
                        End If
                    End If
                End If


                '*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* ORDENES DE PRODUCCION *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
                dtProduccionEncabezado = mSQLSelect.GET_Fill_EnsambleProduccion_PendienteSubir("PE", i)

                For j = 0 To dtProduccionEncabezado.Rows.Count - 1
                    dtProduccionDetalle = mSQLSelect.GET_PDetalle(dtProduccionEncabezado.Rows(j)("CodigoArticulo").ToString, dtProduccionEncabezado.Rows(j)("Unidades").ToString)

                    ssmEsperar.SetWaitFormCaption("Subiendo Produccion")
                    ssmEsperar.SetWaitFormDescription(dtProduccionEncabezado.Rows(j)("CodigoArticulo").ToString)

                    pSAP = String.Empty
                    pSAP = mDIAPI.SAP_DIAPI_OrdenesProduccion1(dtProduccionEncabezado, dtProduccionDetalle, j) 'Insertar SAP Producciones

                    If Not pSAP = String.Empty Then
                        'dtAnalisisXArticulo = mSQLSelect.GET_AnalisisArticulos_XFiltro("'" + dtEnsambleEncabezado.Rows(0)("CodigoArticulo").ToString + "'")
                        'IdTrans = INSERT_Ordenes_Encabezado(dtEnsambleEncabezado, dtAnalisisXArticulo)
                        If Not IdTrans = String.Empty Then
                            ssmEsperar.SetWaitFormCaption("Agregando Resultados")
                            ssmEsperar.SetWaitFormDescription(dtProduccionEncabezado.Rows(j)("CodigoArticulo").ToString)

                            mSQLInsert.INSERT_Ordenes_Detalle(dtProduccionEncabezado, j, IdTrans, pSAP)
                            'Agregar Resultados de SAP
                            Row = dtSAPResultados.NewRow()
                            Row("Tipo") = "PRODUCCION"
                            Row("NumeroSAP") = pSAP
                            Row("CodigoArticulo") = dtProduccionEncabezado.Rows(j)("CodigoArticulo").ToString
                            Row("Unidades") = dtProduccionEncabezado.Rows(j)("Unidades").ToString
                            Row("Origen") = "0"
                            Row("Destino") = dtProduccionEncabezado.Rows(j)("Destino").ToString
                            dtSAPResultados.Rows.Add(Row)
                        End If
                    End If
                Next

                DELETE_PROD_Ordenes_Detalle_Temporal(i)


            Next

            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If

            vpTabla1 = dtSAPResultados
            frmResultadoOrdenesIngresadas.ShowDialog(Me)

            'Reset DS
            DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtEnsambleEncabezado.TableName.ToString).Clear()
            DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtEnsambleDetalle.TableName.ToString).Clear()
            DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtProduccionEncabezado.TableName.ToString).Clear()
            txtIdNivel1.EditValue = 1

        Catch ex As Exception
            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
        End Try

    End Sub

    Private Sub barbtnStock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnStock.ItemClick
        Try
            Try
                Dim pCodigoArticulo As String = String.Empty
                pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewHijos, "CodigoArticulo")
                If pCodigoArticulo = String.Empty Then
                    mMensajes.msg_Informacion("Debe seleccionar un codigo de articulo valido!")
                    Exit Sub
                End If
                frmTemporal_Stock.ppCodigoArticulo = "'" + pCodigoArticulo + "'"
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
                Dim pCodigoArticulo As String = String.Empty

                pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewHijos, "CodigoArticulo")
                If pCodigoArticulo = String.Empty Then
                    mMensajes.msg_Informacion("Debe seleccionar un codigo de articulo valido!")
                    Exit Sub
                End If

                frmTemporal_Ensamble.ppOrigenesBodegas = "'1','2','3','4'"
                frmTemporal_Ensamble.ppCodigoArticulo = "'" + pCodigoArticulo + "'"
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

            Dim pCodigoArticulo As String = String.Empty
            pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewHijos, "CodigoArticulo")
            If pCodigoArticulo = String.Empty Then
                mMensajes.msg_Informacion("Debe seleccionar un codigo de articulo valido!")
                Exit Sub
            End If
            frmTemporal_Produccion.ppCodigoArticulo = "'" + pCodigoArticulo + "'"
            frmTemporal_Produccion.ShowDialog(Me)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnDeudaRol_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaRol.ItemClick
        Try

            Dim pCodigoArticulo As String = String.Empty
            pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewHijos, "CodigoArticulo")
            If pCodigoArticulo = String.Empty Then
                mMensajes.msg_Informacion("Debe seleccionar un codigo de articulo valido!")
                Exit Sub
            End If
            frmTemporal_DeudaRol.ppCodigoArticulo = "'" + pCodigoArticulo + "'"
            frmTemporal_DeudaRol.ShowDialog()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnDeudaCampana_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaCampana.ItemClick
        Try

            Dim pCodigoArticulo As String = String.Empty
            pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewHijos, "CodigoArticulo")
            If pCodigoArticulo = String.Empty Then
                mMensajes.msg_Informacion("Debe seleccionar un codigo de articulo valido!")
                Exit Sub
            End If
            frmTemporal_DeudaCampana.ppCodigoArticulo = "'" + pCodigoArticulo + "'"
            frmTemporal_DeudaCampana.ShowDialog()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnDeudaProyeccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDeudaProyeccion.ItemClick
        Try
            Dim pCodigoArticulo As String = String.Empty
            pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewHijos, "CodigoArticulo")
            If pCodigoArticulo = String.Empty Then
                mMensajes.msg_Informacion("Debe seleccionar un codigo de articulo valido!")
                Exit Sub
            End If
            frmTemporal_DeudaProyeccion.ppCodigoArticulo = "'" + pCodigoArticulo + "'"
            frmTemporal_DeudaProyeccion.ShowDialog()


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnAnalisisVenta_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAnalisisVenta.ItemClick
        Try
            Dim pCodigoArticulo As String = String.Empty
            pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewHijos, "CodigoArticulo")
            If pCodigoArticulo = String.Empty Then
                mMensajes.msg_Informacion("Debe seleccionar un codigo de articulo valido!")
                Exit Sub
            End If
            frmTemporal_AnalisisVenta.ppCodigoArticulo = pCodigoArticulo
            frmTemporal_AnalisisVenta.ShowDialog(Me)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnComponente_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnComponente.ItemClick
        Try
            frmOrdenProduccion.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub



    Private Sub barbtnOcultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            splitOrdenesEnsamble.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
            splitResultado.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnResultadoOrdenes_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub barbtnArticulosSugeridos_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Try


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub chkArticulosSugeridos_CheckedChanged(sender As Object, e As EventArgs) Handles chkArticulosSugeridos.CheckedChanged
        'Dim img As Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png")
        Try
            FCN_ChkArticulosSugeridos()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub FCN_ChkArticulosSugeridos()
        Try
            If chkArticulosSugeridos.Checked = True Then
                'Mostrar 2 paneles
                splitOrdenesEnsamble.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
                chkArticulosSugeridos.Text = "Ocultar Articulos Sugeridos"
                'chkArticulosSugeridos.Checked = False
                'Mostrar Panel 1
                If chkResultadoOrdenes.Checked Then
                    splitResultado.SplitterPosition = lycOrdenEnsambleProduccion.Height * 0.8
                    splitOrdenesEnsamble.SplitterPosition = lycOrdenEnsambleProduccion.Height * 0.2

                Else
                    splitOrdenesEnsamble.SplitterPosition = lycOrdenEnsambleProduccion.Height * 0.2
                    splitResultado.SplitterPosition = lycOrdenEnsambleProduccion.Height * 0.8
                End If
            Else
                splitOrdenesEnsamble.SplitterPosition = lycOrdenEnsambleProduccion.Height * 0.2
                splitResultado.SplitterPosition = lycOrdenEnsambleProduccion.Height * 0.8
                splitOrdenesEnsamble.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
                chkArticulosSugeridos.Text = "Mostrar Articulos Sugeridos"
                'chkArticulosSugeridos.Checked = True
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub


    Private Sub chkResultadoOrdenes_CheckedChanged(sender As Object, e As EventArgs) Handles chkResultadoOrdenes.CheckedChanged
        Try
            If chkResultadoOrdenes.Checked = True Then
                If chkArticulosSugeridos.Checked Then
                    splitResultado.SplitterPosition = lycOrdenEnsambleProduccion.Height * 0.8
                    splitOrdenesEnsamble.SplitterPosition = lycOrdenEnsambleProduccion.Height * 0.2
                Else
                    splitResultado.SplitterPosition = lycOrdenEnsambleProduccion.Height * 0.8
                    splitOrdenesEnsamble.SplitterPosition = lycOrdenEnsambleProduccion.Height * 0.2
                End If
                splitResultado.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
                chkResultadoOrdenes.Text = "Ocultar Resultado Ordenes"
            Else
                splitOrdenesEnsamble.SplitterPosition = lycOrdenEnsambleProduccion.Height * 0.2
                splitResultado.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                chkResultadoOrdenes.Text = "Mostrar Resultado Ordenes"
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnDuplicar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDuplicar.ItemClick
        Try

            If grdviewHijos.RowCount = Nothing Then
                Exit Sub
            End If

            Dim pCodigoArticulo As String = String.Empty

            pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewHijos, "CodigoArticulo")
            If pCodigoArticulo = String.Empty Then
                mMensajes.msg_Informacion("Debe seleccionar un codigo de articulo valido!")
                Exit Sub
            End If



            Dim pResultado As String = String.Empty
            frmTemporal_Lista.ppTabla = GET_OrdenesEnsambleProduccion_Duplicar(pCodigoArticulo)
            frmTemporal_Lista.ShowDialog()
            If frmTemporal_Lista.ppResultado = Nothing Then
                Exit Sub
            Else
                pResultado = frmTemporal_Lista.ppResultado
            End If

            DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtArticulos.TableName.ToString).Clear()
            DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtArticulos.TableName.ToString).Merge(GET_OrdenesEnsamble_Duplicar(pResultado))


            Dim dtProducciones As New DataTable()
            dtProducciones = GET_OrdenesProduccion_Duplicar(pResultado)

            'HACER UN QRY CON LOS ARTICULOS Y CODIGOS QUE NO ESTAN EN LA COPIA PERO QUE ACTUALMENTE SI ESTAN EN RECETA ORIGINAL
            Dim dtProduccionesPendientes As New DataTable()
            dtProduccionesPendientes = GET_OrdenesProduccion_Duplicar(pResultado, dtProducciones.Rows(0)("CodigoArticulo"))

            If Not dtProduccionesPendientes.Rows.Count = Nothing Then
                dtProducciones.Merge(dtProduccionesPendientes)
            End If

            DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtComponentesProducidos.TableName.ToString).Clear()
            DsOrdenEnsambleProduccion1.Tables(DsOrdenEnsambleProduccion1.dsdtComponentesProducidos.TableName.ToString).Merge(dtProducciones)

            For i = 0 To grdviewComponentesProducidos.RowCount - 1
                grdviewComponentesProducidos.SetRowCellValue(i, "CodigoCP", dtProducciones.Rows(i)("CodigoCP"))
            Next

            If Not dtProduccionesPendientes.Rows.Count = Nothing Then
                MsgBox("Se agregaron < " + dtProduccionesPendientes.Rows.Count.ToString + " > Codigos de la Receta Original." + Environment.NewLine + " Revise antes de de grabar la Orden.")
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub frmOrdenEnsambleProduccion_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            If Not grdviewHijos.RowCount = Nothing Then
                grdviewHijos.FocusedRowHandle = grdviewHijos.LocateByValue("CodigoArticulo", pCodigosArticuloOrigen)
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnNuevo.ItemClick
        Try
            Select Case pTipo
                Case "Ensamble"
                    Me.Close()
                    frmMenu.fcn_vtnEnsamble()
                Case "AnalisisEnsamble"
                    Me.Close()
                    frmMenu.fcn_vtnAnalisisEnsamble()
            End Select


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnActualizarControles_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnActualizarControles.ItemClick
        Try
            '----Llenar los listados en los controles ----'
            '---------------------------------------------'
            Sub_Fill_Controles()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub barbtListaMateriales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtListaMateriales.ItemClick
        Try
            Dim pCodigo As String = String.Empty

            If grdviewHijos.IsFocusedView() Then
                pCodigo = grdviewHijos.GetRowCellValue(grdviewHijos.FocusedRowHandle, "CodigoArticulo")
            ElseIf grdviewArticulos.IsFocusedView() Then
                pCodigo = grdviewArticulos.GetRowCellValue(grdviewArticulos.FocusedRowHandle, "CodigoArticulo")
            ElseIf grdviewComponentesProducidos.IsFocusedView() Then
                pCodigo = grdviewComponentesProducidos.GetRowCellValue(grdviewComponentesProducidos.FocusedRowHandle, "CodigoCP")
            ElseIf grdviewEnsambles.IsFocusedView() Then
                pCodigo = grdviewEnsambles.GetRowCellValue(grdviewEnsambles.FocusedRowHandle, "CodigoArticulo")
            ElseIf grdviewProducciones.IsFocusedView() Then
                pCodigo = grdviewProducciones.GetRowCellValue(grdviewProducciones.FocusedRowHandle, "CodigoArticulo")
            End If


            If pCodigo = String.Empty Then : Exit Sub : End If

            frmTemporal_ListaMateriales.mmCodigo = pCodigo
            frmTemporal_ListaMateriales.ShowDialog()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class