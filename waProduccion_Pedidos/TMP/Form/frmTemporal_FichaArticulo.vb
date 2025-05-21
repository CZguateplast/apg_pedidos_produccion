Imports System.IO
Public Class frmTemporal_FichaArticulo

    Private pCodigoArticulo As String

    Public Property ppCodigoArticulo() As String
        Get
            Return pCodigoArticulo
        End Get
        Set(ByVal Value As String)
            pCodigoArticulo = Value
        End Set
    End Property

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmTemporal_DetalleArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim pFile As String()
            Dim pExtension As String = String.Empty
            Dim pCodigo As String = pCodigoArticulo.Substring(3, 5).ToString

            pFile = Directory.GetFiles("\\192.168.1.245\Imagenes SAP\CATALOGO\ARTICULOS\", pCodigo + ".*")
            If Not pFile.Length = 0 Then
                picArticulo.Image = Image.FromFile(pFile.First.ToString)
            Else
                picArticulo.Image = Nothing
            End If



            'picArticulo.Image = Image.FromFile("\\192.168.1.245\Imagenes SAP\CATALOGO\ARTICULOS\" + pCodigoArticulo.Substring(3, 5).ToString + ".BMP")

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class