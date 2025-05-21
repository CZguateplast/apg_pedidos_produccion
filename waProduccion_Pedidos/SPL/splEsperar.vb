'Public Class splEsperar
'    Sub New()
'        InitializeComponent()
'        Me.progressPanel1.AutoHeight = True
'        Application.DoEvents()
'    End Sub

'    Public Overrides Sub SetCaption(ByVal caption As String)
'        MyBase.SetCaption(caption)
'        Me.progressPanel1.Caption = caption
'    End Sub

'    Public Overrides Sub SetDescription(ByVal description As String)
'        MyBase.SetDescription(description)
'        Me.progressPanel1.Description = description
'    End Sub

'    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
'        MyBase.ProcessCommand(cmd, arg)
'    End Sub

'    Public Enum WaitFormCommand
'        SomeCommandId
'    End Enum

'    Private Sub tableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles tableLayoutPanel1.Paint

'    End Sub
'End Class

'Test
Public Class splEsperar
    Inherits DevExpress.XtraWaitForm.WaitForm

    Sub New()
        InitializeComponent()
        Me.progressPanel1.AutoHeight = True
        ' Application.DoEvents()  <- Generalmente se recomienda evitar su uso en el constructor
    End Sub

    Public Overrides Sub SetCaption(ByVal caption As String)
        MyBase.SetCaption(caption)
        Me.progressPanel1.Caption = caption
    End Sub

    Public Overrides Sub SetDescription(ByVal description As String)
        MyBase.SetDescription(description)
        Me.progressPanel1.Description = description
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
        ' Implementa el manejo de comandos adicionales aquí si es necesario
    End Sub

    Public Enum WaitFormCommand
        SomeCommandId
        ' Añade otros comandos si es necesario
    End Enum

    ' Elimina este método si no es necesario
    Private Sub tableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles tableLayoutPanel1.Paint
        ' Implementa código de pintura personalizado aquí si es necesario
    End Sub
End Class


