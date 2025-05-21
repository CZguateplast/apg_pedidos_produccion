Public Class frmParametros_Empaque_Editar


    Private pCodigo As String
    Private pNombre As String
    Private pIdEmpaque As Integer
    Private pTipoTransaccion As String
    Private pProceso As Boolean

    Public Property ppProceso() As Boolean
        Get
            Return pProceso
        End Get
        Set(ByVal Value As Boolean)

            pProceso = Value
        End Set
    End Property

    Public Property ppTipoTrans() As String
        Get
            Return pTipoTransaccion
        End Get
        Set(ByVal Value As String)

            pTipoTransaccion = Value
        End Set
    End Property


    Public Property ppCodigo() As String
        Get
            Return pCodigo
        End Get
        Set(ByVal Value As String)

            pCodigo = Value
        End Set
    End Property

    Public Property ppNombre() As String
        Get
            Return pNombre
        End Get
        Set(ByVal Value As String)

            pNombre = Value
        End Set
    End Property

    Public Property ppIdEmpaque() As String
        Get
            Return pIdEmpaque
        End Get
        Set(ByVal Value As String)

            pIdEmpaque = Value
        End Set
    End Property


    Private Sub Clear_Control()
        Try
            pProceso = False
            txtCodigo.EditValue = String.Empty
            txtNombre.EditValue = String.Empty
            txtNumEmpaque.EditValue = String.Empty
            DsParametros_Empaque_Editar1.Tables(DsParametros_Empaque_Editar1.dsdtEmpaque.TableName.ToString).Clear()
            memoComentarios.EditValue = String.Empty
            spinPersonasXEquipo.EditValue = Nothing

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub



    Private Sub frmParametros_Empaque_Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueCodigo, GET_Catalogo_CC_Hijos(), "CodigoArticulo", "CodigoArticulo")
            mFunciones.FCN_FILL_SearchLookUpEdit(rslueUM, GET_Listado("Medidas"), "Id", "Id")



            Clear_Control()

            txtCodigo.EditValue = pCodigo
            txtNombre.EditValue = pNombre

            Dim dtCantidad As New DataTable()
            dtCantidad = mSQLSelect.GET_Empaques_Cantidad(pCodigo)

            If pIdEmpaque = Nothing Then
                If dtCantidad.Rows.Count = Nothing Then
                    'NO HAY LISTA DE EMPAQUES
                    txtNumEmpaque.EditValue = "1"
                Else
                    txtNumEmpaque.EditValue = (dtCantidad.Rows(0)(0) + 1)
                End If
            Else
                txtNumEmpaque.EditValue = pIdEmpaque
            End If

            Dim dt As New DataTable()
            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Empaque_Parametros_XNumEmpaque] '" + pCodigo + "','" + txtNumEmpaque.EditValue.ToString + "'")

            If dt.Rows.Count = Nothing Then
                Dim n As Integer = dt.Columns("Linea").AutoIncrement

                For i = 0 To 2
                    Dim R As DataRow = dt.NewRow
                    R("Linea") = i + 1
                    R("Id_Empaque") = txtNumEmpaque.EditValue
                    R("Id") = pCodigo
                    dt.Rows.Add(R)
                Next
            End If
            

            DsParametros_Empaque_Editar1.Tables(DsParametros_Empaque_Editar1.dsdtEmpaque.TableName.ToString).Clear() 'BORRAR DATASET
            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If
            DsParametros_Empaque_Editar1.Tables(DsParametros_Empaque_Editar1.dsdtEmpaque.TableName.ToString).Merge(dt) 'LLENAR DATASET

            memoComentarios.EditValue = dt.Rows(0)("Comentarios").ToString
            spinPersonasXEquipo.EditValue = dt.Rows(0)("PersonasEquipo").ToString

            
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            pProceso = False
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewEmpaque_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdviewEmpaque.CellValueChanged
        Try
            If e.Column.FieldName = "Codigo" Then
                Dim dt As New DataTable

                If IsDBNull(e.Value) Then
                    grdviewEmpaque.SetRowCellValue(e.RowHandle, "NombreCodigo", "")
                    grdviewEmpaque.SetRowCellValue(e.RowHandle, "UM", "")
                    grdviewEmpaque.SetRowCellValue(e.RowHandle, "Cantidad", "")
                    grdviewEmpaque.SetRowCellValue(e.RowHandle, "UEmpaque", "")
                    Exit Sub
                End If

                Dim Codigo As String = e.Value

                dt = mSQLSelect.GET_Articulo(FCN_AgregarComillas(Codigo))
                If Not dt.Rows.Count = Nothing Then
                    grdviewEmpaque.SetRowCellValue(e.RowHandle, "NombreCodigo", dt.Rows(0)("NombreArticulo").ToString)
                End If
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnGuardar.ItemClick
        Try
            grdviewEmpaque.CloseEditor()

            Dim pCodigo As String = String.Empty
            Dim pId_Empaque As Integer = Nothing
            Dim pCodigo1 As String = String.Empty
            Dim pUM1 As String = String.Empty
            Dim pCantidad1 As Integer = Nothing
            Dim pUEmpaque1 As Integer = Nothing
            Dim pCodigo2 As String = String.Empty
            Dim pUM2 As String = String.Empty
            Dim pCantidad2 As Integer = Nothing
            Dim pUEmpaque2 As Integer = Nothing
            Dim pCodigo3 As String = String.Empty
            Dim pUM3 As String = String.Empty
            Dim pCantidad3 As Integer = Nothing
            Dim pUEmpaque3 As Integer = Nothing
            Dim pPersonasEquipo As Integer = Nothing
            Dim pComentarios As String = String.Empty

            pCodigo = txtCodigo.EditValue.ToString
            pId_Empaque = txtNumEmpaque.EditValue

            If Not IsDBNull(grdviewEmpaque.GetRowCellValue(0, "Codigo")) Then : pCodigo1 = grdviewEmpaque.GetRowCellValue(0, "Codigo") : End If
            If Not IsDBNull(grdviewEmpaque.GetRowCellValue(0, "UM")) Then : pUM1 = grdviewEmpaque.GetRowCellValue(0, "UM") : End If
            If Not IsDBNull(grdviewEmpaque.GetRowCellValue(0, "Cantidad")) Then : pCantidad1 = grdviewEmpaque.GetRowCellValue(0, "Cantidad") : End If
            If Not IsDBNull(grdviewEmpaque.GetRowCellValue(0, "UEmpaque")) Then : pUEmpaque1 = grdviewEmpaque.GetRowCellValue(0, "UEmpaque") : End If

            If Not IsDBNull(grdviewEmpaque.GetRowCellValue(1, "Codigo")) Then : pCodigo2 = grdviewEmpaque.GetRowCellValue(1, "Codigo") : End If
            If Not IsDBNull(grdviewEmpaque.GetRowCellValue(1, "UM")) Then : pUM2 = grdviewEmpaque.GetRowCellValue(1, "UM") : End If
            If Not IsDBNull(grdviewEmpaque.GetRowCellValue(1, "Cantidad")) Then : pCantidad2 = grdviewEmpaque.GetRowCellValue(1, "Cantidad") : End If
            If Not IsDBNull(grdviewEmpaque.GetRowCellValue(1, "UEmpaque")) Then : pUEmpaque2 = grdviewEmpaque.GetRowCellValue(1, "UEmpaque") : End If

            If Not IsDBNull(grdviewEmpaque.GetRowCellValue(2, "Codigo")) Then : pCodigo3 = grdviewEmpaque.GetRowCellValue(2, "Codigo") : End If
            If Not IsDBNull(grdviewEmpaque.GetRowCellValue(2, "UM")) Then : pUM3 = grdviewEmpaque.GetRowCellValue(2, "UM") : End If
            If Not IsDBNull(grdviewEmpaque.GetRowCellValue(2, "Cantidad")) Then : pCantidad3 = grdviewEmpaque.GetRowCellValue(2, "Cantidad") : End If
            If Not IsDBNull(grdviewEmpaque.GetRowCellValue(2, "UEmpaque")) Then : pUEmpaque3 = grdviewEmpaque.GetRowCellValue(2, "UEmpaque") : End If
            If Not IsDBNull(spinPersonasXEquipo.EditValue) Then : pPersonasEquipo = spinPersonasXEquipo.EditValue : End If
            If Not IsDBNull(memoComentarios.EditValue.ToString) Then : pComentarios = memoComentarios.EditValue.ToString : End If

            'VALIDAR INSERT
            If ppTipoTrans = "Nuevo" Then
                mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Empaque_Parametros_INSERT] '" + pCodigo + "','" + pId_Empaque.ToString + "','" _
                                       + pCodigo1 + "','" + pUM1 + "','" + pCantidad1.ToString + "','" + pUEmpaque1.ToString + "','" _
                                       + pCodigo2 + "','" + pUM2 + "','" + pCantidad2.ToString + "','" + pUEmpaque2.ToString + "','" _
                                       + pCodigo3 + "','" + pUM3 + "','" + pCantidad3.ToString + "','" + pUEmpaque3.ToString + "','" _
                                       + pPersonasEquipo.ToString + "','" + pComentarios + "','1','" + My.Settings.log_Usuario.ToString + "'")
            ElseIf ppTipoTrans = "Actualizar" Then
                mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Empaque_Parametros_UPDATE] '" + pCodigo + "','" + pId_Empaque.ToString + "','" _
                                       + pCodigo1 + "','" + pUM1 + "','" + pCantidad1.ToString + "','" + pUEmpaque1.ToString + "','" _
                                       + pCodigo2 + "','" + pUM2 + "','" + pCantidad2.ToString + "','" + pUEmpaque2.ToString + "','" _
                                       + pCodigo3 + "','" + pUM3 + "','" + pCantidad3.ToString + "','" + pUEmpaque3.ToString + "','" _
                                       + pPersonasEquipo.ToString + "','" + pComentarios + "','1','" + My.Settings.log_Usuario.ToString + "'")
            Else
                mMensajes.msg_Informacion("No existe el tipo de Procedimiento a ejecutar")
            End If

            pProceso = True
            Me.Close()


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class