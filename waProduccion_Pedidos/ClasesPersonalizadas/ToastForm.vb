Public Class ToastForm
    Inherits Form

    Private mensaje As String
    Private mainForm As Form

    Public Sub New(mensaje As String, mainForm As Form)
        InitializeComponent()
        Me.mensaje = mensaje
        Me.mainForm = mainForm
    End Sub

    Private Sub ToastForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.85 ' Transparencia: Un número más pequeño es igual a más transparencia
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Size = New Size(300, 150)
        Me.ShowInTaskbar = False
        Me.TopMost = True

        ' Posicionar en el centro del formulario principal
        Me.StartPosition = FormStartPosition.Manual
        Dim mainFormCenterX As Integer = mainForm.Location.X + (mainForm.Width - Me.Width) / 2
        Dim mainFormCenterY As Integer = mainForm.Location.Y + (mainForm.Height - Me.Height) / 2
        Me.Location = New Point(mainFormCenterX, mainFormCenterY)

        ' Configurar el Label para que se centre en el formulario
        lblMensaje.Text = mensaje
        lblMensaje.TextAlign = ContentAlignment.MiddleCenter
        lblMensaje.Dock = DockStyle.Fill

        ' Ocultar el formulario después de 3 segundos
        Dim timer As New Timer With {.Interval = 3000}
        AddHandler timer.Tick, Sub()
                                   Me.Close()
                               End Sub
        timer.Start()
    End Sub
End Class
