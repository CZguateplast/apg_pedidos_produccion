<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargaMasivaDatosProduccion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCantProcesada = New System.Windows.Forms.Label()
        Me.PBCargaMasiva = New System.Windows.Forms.ProgressBar()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnDescargarF = New System.Windows.Forms.Button()
        Me.lblMolde = New System.Windows.Forms.Label()
        Me.lblMateriales = New System.Windows.Forms.Label()
        Me.lblParametros = New System.Windows.Forms.Label()
        Me.LblCantErrores = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Terminos = New System.Windows.Forms.Label()
        Me.BtnProcesar = New System.Windows.Forms.Button()
        Me.CbAceptar = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGVListado = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TbxRutaDelArchivo = New System.Windows.Forms.TextBox()
        Me.btnSubirArchivo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblCantProcesada)
        Me.GroupBox1.Controls.Add(Me.PBCargaMasiva)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1240, 653)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Carga de Parametros"
        '
        'lblCantProcesada
        '
        Me.lblCantProcesada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCantProcesada.AutoSize = True
        Me.lblCantProcesada.Location = New System.Drawing.Point(475, 564)
        Me.lblCantProcesada.Name = "lblCantProcesada"
        Me.lblCantProcesada.Size = New System.Drawing.Size(16, 16)
        Me.lblCantProcesada.TabIndex = 4
        Me.lblCantProcesada.Text = "0"
        '
        'PBCargaMasiva
        '
        Me.PBCargaMasiva.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBCargaMasiva.Location = New System.Drawing.Point(20, 591)
        Me.PBCargaMasiva.Name = "PBCargaMasiva"
        Me.PBCargaMasiva.Size = New System.Drawing.Size(983, 41)
        Me.PBCargaMasiva.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.BtnDescargarF)
        Me.GroupBox4.Controls.Add(Me.lblMolde)
        Me.GroupBox4.Controls.Add(Me.lblMateriales)
        Me.GroupBox4.Controls.Add(Me.lblParametros)
        Me.GroupBox4.Controls.Add(Me.LblCantErrores)
        Me.GroupBox4.Controls.Add(Me.BtnCancelar)
        Me.GroupBox4.Controls.Add(Me.Terminos)
        Me.GroupBox4.Controls.Add(Me.BtnProcesar)
        Me.GroupBox4.Controls.Add(Me.CbAceptar)
        Me.GroupBox4.Location = New System.Drawing.Point(1035, 29)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(184, 603)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Acciones"
        '
        'BtnDescargarF
        '
        Me.BtnDescargarF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDescargarF.BackColor = System.Drawing.Color.Coral
        Me.BtnDescargarF.Location = New System.Drawing.Point(16, 544)
        Me.BtnDescargarF.Name = "BtnDescargarF"
        Me.BtnDescargarF.Size = New System.Drawing.Size(150, 40)
        Me.BtnDescargarF.TabIndex = 8
        Me.BtnDescargarF.Text = "Descargar Formulario"
        Me.BtnDescargarF.UseVisualStyleBackColor = False
        '
        'lblMolde
        '
        Me.lblMolde.AutoSize = True
        Me.lblMolde.Location = New System.Drawing.Point(74, 370)
        Me.lblMolde.Name = "lblMolde"
        Me.lblMolde.Size = New System.Drawing.Size(16, 16)
        Me.lblMolde.TabIndex = 7
        Me.lblMolde.Text = "0"
        '
        'lblMateriales
        '
        Me.lblMateriales.AutoSize = True
        Me.lblMateriales.Location = New System.Drawing.Point(74, 329)
        Me.lblMateriales.Name = "lblMateriales"
        Me.lblMateriales.Size = New System.Drawing.Size(16, 16)
        Me.lblMateriales.TabIndex = 6
        Me.lblMateriales.Text = "0"
        '
        'lblParametros
        '
        Me.lblParametros.AutoSize = True
        Me.lblParametros.Location = New System.Drawing.Point(74, 296)
        Me.lblParametros.Name = "lblParametros"
        Me.lblParametros.Size = New System.Drawing.Size(16, 16)
        Me.lblParametros.TabIndex = 5
        Me.lblParametros.Text = "0"
        '
        'LblCantErrores
        '
        Me.LblCantErrores.AutoSize = True
        Me.LblCantErrores.Location = New System.Drawing.Point(28, 263)
        Me.LblCantErrores.Name = "LblCantErrores"
        Me.LblCantErrores.Size = New System.Drawing.Size(120, 16)
        Me.LblCantErrores.TabIndex = 4
        Me.LblCantErrores.Text = "Cant. de Errores"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.LightCoral
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(16, 195)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(150, 40)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'Terminos
        '
        Me.Terminos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Terminos.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Terminos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Terminos.Location = New System.Drawing.Point(6, 36)
        Me.Terminos.Name = "Terminos"
        Me.Terminos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Terminos.Size = New System.Drawing.Size(172, 50)
        Me.Terminos.TabIndex = 2
        Me.Terminos.Text = "¿Aprueba la actualización de parámetros?"
        Me.Terminos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnProcesar
        '
        Me.BtnProcesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnProcesar.BackColor = System.Drawing.Color.LightGreen
        Me.BtnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProcesar.Location = New System.Drawing.Point(16, 144)
        Me.BtnProcesar.Name = "BtnProcesar"
        Me.BtnProcesar.Size = New System.Drawing.Size(150, 40)
        Me.BtnProcesar.TabIndex = 1
        Me.BtnProcesar.Text = "Cargar Parametros"
        Me.BtnProcesar.UseVisualStyleBackColor = False
        '
        'CbAceptar
        '
        Me.CbAceptar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbAceptar.AutoSize = True
        Me.CbAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbAceptar.Location = New System.Drawing.Point(43, 103)
        Me.CbAceptar.Name = "CbAceptar"
        Me.CbAceptar.Size = New System.Drawing.Size(81, 20)
        Me.CbAceptar.TabIndex = 0
        Me.CbAceptar.Text = "Aceptar"
        Me.CbAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CbAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.DGVListado)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 173)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(983, 378)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos"
        '
        'DGVListado
        '
        Me.DGVListado.AllowUserToAddRows = False
        Me.DGVListado.AllowUserToDeleteRows = False
        Me.DGVListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListado.Location = New System.Drawing.Point(6, 19)
        Me.DGVListado.Name = "DGVListado"
        Me.DGVListado.Size = New System.Drawing.Size(971, 353)
        Me.DGVListado.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TbxRutaDelArchivo)
        Me.GroupBox2.Controls.Add(Me.btnSubirArchivo)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(983, 120)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cargar Archivo"
        '
        'TbxRutaDelArchivo
        '
        Me.TbxRutaDelArchivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbxRutaDelArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxRutaDelArchivo.Location = New System.Drawing.Point(23, 45)
        Me.TbxRutaDelArchivo.Multiline = True
        Me.TbxRutaDelArchivo.Name = "TbxRutaDelArchivo"
        Me.TbxRutaDelArchivo.Size = New System.Drawing.Size(830, 34)
        Me.TbxRutaDelArchivo.TabIndex = 1
        '
        'btnSubirArchivo
        '
        Me.btnSubirArchivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubirArchivo.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSubirArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubirArchivo.Location = New System.Drawing.Point(874, 45)
        Me.btnSubirArchivo.Name = "btnSubirArchivo"
        Me.btnSubirArchivo.Size = New System.Drawing.Size(89, 34)
        Me.btnSubirArchivo.TabIndex = 0
        Me.btnSubirArchivo.Text = " Archivo"
        Me.btnSubirArchivo.UseVisualStyleBackColor = False
        '
        'FrmCargaMasivaDatosProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmCargaMasivaDatosProduccion"
        Me.Text = "FrmCargaMasivaDatosProduccion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PBCargaMasiva As ProgressBar
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblCantProcesada As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Terminos As Label
    Friend WithEvents BtnProcesar As Button
    Friend WithEvents CbAceptar As CheckBox
    Friend WithEvents DGVListado As DataGridView
    Friend WithEvents TbxRutaDelArchivo As TextBox
    Friend WithEvents btnSubirArchivo As Button
    Friend WithEvents lblMolde As Label
    Friend WithEvents lblMateriales As Label
    Friend WithEvents lblParametros As Label
    Friend WithEvents LblCantErrores As Label
    Friend WithEvents BtnDescargarF As Button
End Class
