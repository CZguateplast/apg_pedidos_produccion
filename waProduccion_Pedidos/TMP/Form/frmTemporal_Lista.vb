Public Class frmTemporal_Lista
    Private pTabla As New DataTable()
    Private pResultado As String


    Public Property ppTabla() As DataTable
        Get
            Return pTabla
        End Get
        Set(ByVal Value As DataTable)

            pTabla = Value
        End Set
    End Property
    Public Property ppResultado() As String
        Get
            Return pResultado
        End Get
        Set(ByVal Value As String)
            pResultado = Value
        End Set
    End Property

    Private Sub frmTemporal_Lista_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            Me.Controls.Clear()
            Me.InitializeComponent()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub frmTemporal_Lista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If ppTabla.Rows.Count = Nothing Then
                Exit Sub
            End If

            slueId.DataBindings.Clear()
            mFunciones.FCN_FILL_SearchLookUpEdit(slueId, pTabla, pTabla.Columns.Item(0).Caption.ToString, pTabla.Columns.Item(0).Caption.ToString)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnAceptar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAceptar.ItemClick
        Try
            If slueId.EditValue = Nothing Then
                mMensajes.msg_Informacion("Ingrese un Id Valido para continuar")
                Exit Sub
            End If

            pResultado = slueId.EditValue.ToString
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCancelar.ItemClick
        Try
            pResultado = Nothing
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub slueId_KeyDown(sender As Object, e As KeyEventArgs) Handles slueId.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                barbtnAceptar_ItemClick(Nothing, Nothing)
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class