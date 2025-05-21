Public Class frmTemporal_MoldesDeCodigo

    Private pContinuar As New Boolean
    Private pCodigo As String
    Private pResultado As String

    Public Property ppContinuar() As Boolean
        Get

            Return pContinuar
        End Get
        Set(ByVal Value As Boolean)
            pContinuar = False
            pContinuar = Value
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
    Public Property ppResultado() As String
        Get
            Return pResultado
        End Get
        Set(ByVal Value As String)
            pResultado = String.Empty
            pResultado = Value
        End Set
    End Property

    Private Sub frmTemporal_MoldesDeCodigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DsTemporal_MoldesDeCodigo1.Tables(DsTemporal_MoldesDeCodigo1.dsdtTemporal_MoldesDeCodigo.TableName.ToString).Clear()
            DsTemporal_MoldesDeCodigo1.Tables(DsTemporal_MoldesDeCodigo1.dsdtTemporal_MoldesDeCodigo.TableName.ToString).Merge(GET_MoldesPorCodigo(pCodigo))
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewTemporal_MoldesDeCodigo_Click(sender As Object, e As EventArgs) Handles grdviewTemporal_MoldesDeCodigo.Click
        'Try
        '    If grdviewTemporal_MoldesDeCodigo.SelectedRowsCount() = Nothing Then
        '        barbtnContinuar.Enabled = False
        '    Else
        '        barbtnContinuar.Enabled = True
        '    End If
        'Catch ex As Exception
        '    mMensajes.msg_Error(ex.Message.ToString)
        'End Try

    End Sub

    Private Sub barbtnCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCancelar.ItemClick
        Try
            If MsgBox("Desea cancelar el procedimiento?", MsgBoxStyle.YesNo, "Cancelar...") = MsgBoxResult.Yes Then
                pContinuar = False
                Me.Close()
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    
    Private Sub barbtnContinuar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnContinuar.ItemClick
        Try
            fcn_barbtnContinuar()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub fcn_barbtnContinuar()
        Try
            If grdviewTemporal_MoldesDeCodigo.SelectedRowsCount() = Nothing Then
                Exit Sub
            End If

            pResultado = mFunciones.FCN_GetColumn(grdviewTemporal_MoldesDeCodigo, "Molde")
            pContinuar = True
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    


    Private Sub grdviewTemporal_MoldesDeCodigo_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdviewTemporal_MoldesDeCodigo.CellValueChanged
        'Try
        '    If grdviewTemporal_MoldesDeCodigo.SelectedRowsCount() = Nothing Then
        '        barbtnContinuar.Enabled = False
        '    Else
        '        barbtnContinuar.Enabled = True
        '    End If
        'Catch ex As Exception
        '    mMensajes.msg_Error(ex.Message.ToString)
        'End Try
    End Sub

    Private Sub grdviewTemporal_MoldesDeCodigo_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grdviewTemporal_MoldesDeCodigo.SelectionChanged
        Try
            If grdviewTemporal_MoldesDeCodigo.SelectedRowsCount() = Nothing Then
                barbtnContinuar.Enabled = False
            Else
                barbtnContinuar.Enabled = True
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewTemporal_MoldesDeCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles grdviewTemporal_MoldesDeCodigo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                fcn_barbtnContinuar()
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class