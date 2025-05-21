Partial Class ToastForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents lblMensaje As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(0, 0)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(300, 150)
        Me.lblMensaje.TabIndex = 0
        Me.lblMensaje.Text = "Label1"
        '
        'ToastForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 150)
        Me.Controls.Add(Me.lblMensaje)
        Me.Name = "ToastForm"
        Me.Text = "ToastForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
