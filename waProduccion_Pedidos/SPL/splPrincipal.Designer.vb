<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(splPrincipal))
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lbcVersion = New DevExpress.XtraEditors.LabelControl()
        Me.temsplPrincipal = New System.Windows.Forms.Timer(Me.components)
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(30, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Copyright XP"
        Me.LabelControl2.UseWaitCursor = True
        '
        'lbcVersion
        '
        Me.lbcVersion.Location = New System.Drawing.Point(267, 12)
        Me.lbcVersion.Name = "lbcVersion"
        Me.lbcVersion.Size = New System.Drawing.Size(86, 13)
        Me.lbcVersion.TabIndex = 3
        Me.lbcVersion.Text = "Versión: {2016.5}"
        Me.lbcVersion.UseWaitCursor = True
        '
        'temsplPrincipal
        '
        Me.temsplPrincipal.Interval = 1000
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.InitialImage = CType(resources.GetObject("PictureEdit1.Properties.InitialImage"), System.Drawing.Image)
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Properties.ZoomAccelerationFactor = 1.0R
        Me.PictureEdit1.Size = New System.Drawing.Size(400, 413)
        Me.PictureEdit1.TabIndex = 4
        Me.PictureEdit1.UseWaitCursor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.waProduccion_Pedidos.My.Resources.Resources.Logo_guateplast_Original
        Me.PictureBox1.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(372, 262)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'splPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(397, 411)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbcVersion)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "splPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "splPrincipal"
        Me.TopMost = True
        Me.UseWaitCursor = True
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbcVersion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents temsplPrincipal As System.Windows.Forms.Timer
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
