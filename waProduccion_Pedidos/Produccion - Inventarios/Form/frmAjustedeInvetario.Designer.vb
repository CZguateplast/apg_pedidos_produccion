<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjustedeInvetario
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
        Me.pnlControles = New System.Windows.Forms.Panel()
        Me.pbar = New System.Windows.Forms.ProgressBar()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.txbArchivo = New System.Windows.Forms.TextBox()
        Me.dtpFechaAct = New System.Windows.Forms.DateTimePicker()
        Me.DGVDatos = New System.Windows.Forms.DataGridView()
        Me.lblActPbar = New System.Windows.Forms.Label()
        Me.lblProcesando = New System.Windows.Forms.Label()
        Me.lblDatos = New System.Windows.Forms.Label()
        Me.lblCargar = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlControles.SuspendLayout()
        CType(Me.DGVDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlControles
        '
        Me.pnlControles.Controls.Add(Me.pbar)
        Me.pnlControles.Controls.Add(Me.btnProcesar)
        Me.pnlControles.Controls.Add(Me.btnSeleccionar)
        Me.pnlControles.Controls.Add(Me.txbArchivo)
        Me.pnlControles.Controls.Add(Me.dtpFechaAct)
        Me.pnlControles.Controls.Add(Me.DGVDatos)
        Me.pnlControles.Controls.Add(Me.lblActPbar)
        Me.pnlControles.Controls.Add(Me.lblProcesando)
        Me.pnlControles.Controls.Add(Me.lblDatos)
        Me.pnlControles.Controls.Add(Me.lblCargar)
        Me.pnlControles.Controls.Add(Me.lblFecha)
        Me.pnlControles.Controls.Add(Me.lblTitulo)
        Me.pnlControles.Location = New System.Drawing.Point(12, 12)
        Me.pnlControles.Name = "pnlControles"
        Me.pnlControles.Size = New System.Drawing.Size(1270, 641)
        Me.pnlControles.TabIndex = 0
        '
        'pbar
        '
        Me.pbar.Location = New System.Drawing.Point(180, 587)
        Me.pbar.Name = "pbar"
        Me.pbar.Size = New System.Drawing.Size(877, 25)
        Me.pbar.TabIndex = 23
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.Location = New System.Drawing.Point(1082, 581)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(153, 31)
        Me.btnProcesar.TabIndex = 22
        Me.btnProcesar.Text = "Actualizar"
        Me.btnProcesar.UseVisualStyleBackColor = False
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.LightGreen
        Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.Location = New System.Drawing.Point(1082, 146)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(153, 29)
        Me.btnSeleccionar.TabIndex = 21
        Me.btnSeleccionar.Text = "Seleccionar Archivo"
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'txbArchivo
        '
        Me.txbArchivo.Location = New System.Drawing.Point(180, 156)
        Me.txbArchivo.Name = "txbArchivo"
        Me.txbArchivo.Size = New System.Drawing.Size(867, 20)
        Me.txbArchivo.TabIndex = 20
        '
        'dtpFechaAct
        '
        Me.dtpFechaAct.Location = New System.Drawing.Point(180, 89)
        Me.dtpFechaAct.Name = "dtpFechaAct"
        Me.dtpFechaAct.Size = New System.Drawing.Size(211, 20)
        Me.dtpFechaAct.TabIndex = 19
        '
        'DGVDatos
        '
        Me.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDatos.Location = New System.Drawing.Point(180, 204)
        Me.DGVDatos.Name = "DGVDatos"
        Me.DGVDatos.Size = New System.Drawing.Size(1056, 335)
        Me.DGVDatos.TabIndex = 18
        '
        'lblActPbar
        '
        Me.lblActPbar.AutoSize = True
        Me.lblActPbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActPbar.Location = New System.Drawing.Point(573, 562)
        Me.lblActPbar.Name = "lblActPbar"
        Me.lblActPbar.Size = New System.Drawing.Size(0, 13)
        Me.lblActPbar.TabIndex = 17
        '
        'lblProcesando
        '
        Me.lblProcesando.AutoSize = True
        Me.lblProcesando.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcesando.Location = New System.Drawing.Point(35, 599)
        Me.lblProcesando.Name = "lblProcesando"
        Me.lblProcesando.Size = New System.Drawing.Size(78, 13)
        Me.lblProcesando.TabIndex = 16
        Me.lblProcesando.Text = "Procesando:"
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatos.Location = New System.Drawing.Point(35, 287)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(115, 13)
        Me.lblDatos.TabIndex = 15
        Me.lblDatos.Text = "Datos a Actualizar:"
        '
        'lblCargar
        '
        Me.lblCargar.AutoSize = True
        Me.lblCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargar.Location = New System.Drawing.Point(35, 156)
        Me.lblCargar.Name = "lblCargar"
        Me.lblCargar.Size = New System.Drawing.Size(106, 13)
        Me.lblCargar.TabIndex = 14
        Me.lblCargar.Text = "Archivo a Cargar:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(35, 96)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(117, 13)
        Me.lblFecha.TabIndex = 13
        Me.lblFecha.Text = "Fecha a Actualizar:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(302, 30)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(614, 26)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "Actualizacion de Fechas del Ultimo Conteo de Inventario"
        '
        'frmAjustedeInvetario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 665)
        Me.Controls.Add(Me.pnlControles)
        Me.Name = "frmAjustedeInvetario"
        Me.Text = "Ajuste de Invetario"
        Me.pnlControles.ResumeLayout(False)
        Me.pnlControles.PerformLayout()
        CType(Me.DGVDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlControles As Panel
    Friend WithEvents pbar As ProgressBar
    Friend WithEvents btnProcesar As Button
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents txbArchivo As TextBox
    Friend WithEvents dtpFechaAct As DateTimePicker
    Friend WithEvents DGVDatos As DataGridView
    Friend WithEvents lblActPbar As Label
    Friend WithEvents lblProcesando As Label
    Friend WithEvents lblDatos As Label
    Friend WithEvents lblCargar As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblTitulo As Label
End Class
