Public Class frmTemporal_ListaMateriales

    Private mCodigo As String

    Public Property mmCodigo As String
        Get
            mmCodigo = mCodigo
        End Get
        Set(value As String)
            mCodigo = value
        End Set
    End Property

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmTemporal_ListaMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        mFunciones.FCN_FILL_SearchLookUpEdit(slueListaPrecios, GET_Catalogo_ListaPrecios(), "Id", "Nombre")
        mFunciones.FCN_FILL_SearchLookUpEdit(rslueListaPrecios, GET_Catalogo_ListaPrecios(), "Id", "Nombre")

        If mCodigo = Nothing Then
            Me.Close()
        End If

        Dim dtEncabezado As New DataTable()
        Dim dtDetalle As New DataTable()

        dtEncabezado = mSQLSelect.GET_ListaMateriales_Encabezado(mCodigo)
        If dtEncabezado.Rows.Count = Nothing Then
            Me.Close()
        End If

        dtDetalle = mSQLSelect.GET_ListaMateriales_Detalle(mCodigo)
        If dtDetalle.Rows.Count = Nothing Then
            Me.Close()
        End If

        txtCodigo.EditValue = dtEncabezado.Rows(0)("Codigo")
        txtNombre.EditValue = dtEncabezado.Rows(0)("Nombre")
        spinCantidad.EditValue = dtEncabezado.Rows(0)("cantidad")
        txtAlmacen.EditValue = dtEncabezado.Rows(0)("Almacen")
        slueListaPrecios.EditValue = dtEncabezado.Rows(0)("ListaPrecios")

        DsTemporal_ListaMateriales1.Tables(DsTemporal_ListaMateriales1.dsdtListaMateriales_Detalle.TableName.ToString).Clear()
        DsTemporal_ListaMateriales1.Tables(DsTemporal_ListaMateriales1.dsdtListaMateriales_Detalle.TableName.ToString).Merge(dtDetalle)

    End Sub
End Class