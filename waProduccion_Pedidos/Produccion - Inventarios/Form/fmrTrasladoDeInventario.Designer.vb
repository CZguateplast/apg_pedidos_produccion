<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmrTrasladoDeInventario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GBAcciones = New System.Windows.Forms.GroupBox()
        Me.btnSAP = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnTransAnteriores = New System.Windows.Forms.Button()
        Me.btnAnalizar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkSeleccionarTodo = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUnselect = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblPrioridad = New System.Windows.Forms.Label()
        Me.lblDisponibles = New System.Windows.Forms.Label()
        Me.lstSelectedWarehouses = New System.Windows.Forms.ListBox()
        Me.lstAvailableWarehouses = New System.Windows.Forms.ListBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.codigoproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.almacen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comprometido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existenciaruteo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sacarruteo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existenciapi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sacarpi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pendiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkVerNegativos = New DevExpress.XtraEditors.CheckEdit()
        Me.cboListaPrecios = New System.Windows.Forms.ComboBox()
        Me.cboBodegaDestino = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.GBAcciones.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.chkVerNegativos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.GBAcciones)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1439, 640)
        Me.Panel1.TabIndex = 0
        '
        'GBAcciones
        '
        Me.GBAcciones.Controls.Add(Me.btnSAP)
        Me.GBAcciones.Controls.Add(Me.btnExcel)
        Me.GBAcciones.Controls.Add(Me.btnTransAnteriores)
        Me.GBAcciones.Controls.Add(Me.btnAnalizar)
        Me.GBAcciones.Controls.Add(Me.Label4)
        Me.GBAcciones.Controls.Add(Me.chkSeleccionarTodo)
        Me.GBAcciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBAcciones.Location = New System.Drawing.Point(822, 10)
        Me.GBAcciones.Name = "GBAcciones"
        Me.GBAcciones.Size = New System.Drawing.Size(605, 151)
        Me.GBAcciones.TabIndex = 4
        Me.GBAcciones.TabStop = False
        Me.GBAcciones.Text = "Acciones"
        '
        'btnSAP
        '
        Me.btnSAP.Image = Global.waProduccion_Pedidos.My.Resources.Resources.SAP_32x32
        Me.btnSAP.Location = New System.Drawing.Point(458, 100)
        Me.btnSAP.Name = "btnSAP"
        Me.btnSAP.Size = New System.Drawing.Size(45, 45)
        Me.btnSAP.TabIndex = 15
        Me.btnSAP.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Image = Global.waProduccion_Pedidos.My.Resources.Resources.exporttoxls_32x32
        Me.btnExcel.Location = New System.Drawing.Point(378, 100)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(45, 45)
        Me.btnExcel.TabIndex = 14
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnTransAnteriores
        '
        Me.btnTransAnteriores.Location = New System.Drawing.Point(125, 50)
        Me.btnTransAnteriores.Name = "btnTransAnteriores"
        Me.btnTransAnteriores.Size = New System.Drawing.Size(100, 55)
        Me.btnTransAnteriores.TabIndex = 13
        Me.btnTransAnteriores.Text = "Ver Transferencias Anteriores"
        Me.btnTransAnteriores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTransAnteriores.UseVisualStyleBackColor = True
        '
        'btnAnalizar
        '
        Me.btnAnalizar.Location = New System.Drawing.Point(22, 50)
        Me.btnAnalizar.Name = "btnAnalizar"
        Me.btnAnalizar.Size = New System.Drawing.Size(100, 55)
        Me.btnAnalizar.TabIndex = 12
        Me.btnAnalizar.Text = "Analizar"
        Me.btnAnalizar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(489, 37)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Recuerde que debe existir tasa de cambio del dia en SAP ya que es requerido para " &
    "el correcto traslado de Stock."
        '
        'chkSeleccionarTodo
        '
        Me.chkSeleccionarTodo.AutoSize = True
        Me.chkSeleccionarTodo.Location = New System.Drawing.Point(19, 122)
        Me.chkSeleccionarTodo.Name = "chkSeleccionarTodo"
        Me.chkSeleccionarTodo.Size = New System.Drawing.Size(170, 17)
        Me.chkSeleccionarTodo.TabIndex = 0
        Me.chkSeleccionarTodo.Text = "Marcar/Desmarcar Todos"
        Me.chkSeleccionarTodo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUnselect)
        Me.GroupBox2.Controls.Add(Me.btnSelect)
        Me.GroupBox2.Controls.Add(Me.lblPrioridad)
        Me.GroupBox2.Controls.Add(Me.lblDisponibles)
        Me.GroupBox2.Controls.Add(Me.lstSelectedWarehouses)
        Me.GroupBox2.Controls.Add(Me.lstAvailableWarehouses)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(329, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(435, 151)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bodega de Origen"
        '
        'btnUnselect
        '
        Me.btnUnselect.Image = Global.waProduccion_Pedidos.My.Resources.Resources.arrow_left_black
        Me.btnUnselect.Location = New System.Drawing.Point(206, 82)
        Me.btnUnselect.Name = "btnUnselect"
        Me.btnUnselect.Size = New System.Drawing.Size(29, 23)
        Me.btnUnselect.TabIndex = 5
        Me.btnUnselect.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Image = Global.waProduccion_Pedidos.My.Resources.Resources.arrow_right_black
        Me.btnSelect.Location = New System.Drawing.Point(206, 52)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(29, 23)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'lblPrioridad
        '
        Me.lblPrioridad.AutoSize = True
        Me.lblPrioridad.Location = New System.Drawing.Point(303, 23)
        Me.lblPrioridad.Name = "lblPrioridad"
        Me.lblPrioridad.Size = New System.Drawing.Size(57, 13)
        Me.lblPrioridad.TabIndex = 3
        Me.lblPrioridad.Text = "Prioridad"
        '
        'lblDisponibles
        '
        Me.lblDisponibles.AutoSize = True
        Me.lblDisponibles.Location = New System.Drawing.Point(59, 23)
        Me.lblDisponibles.Name = "lblDisponibles"
        Me.lblDisponibles.Size = New System.Drawing.Size(72, 13)
        Me.lblDisponibles.TabIndex = 2
        Me.lblDisponibles.Text = "Disponibles"
        '
        'lstSelectedWarehouses
        '
        Me.lstSelectedWarehouses.FormattingEnabled = True
        Me.lstSelectedWarehouses.Location = New System.Drawing.Point(249, 39)
        Me.lstSelectedWarehouses.Name = "lstSelectedWarehouses"
        Me.lstSelectedWarehouses.Size = New System.Drawing.Size(166, 95)
        Me.lstSelectedWarehouses.TabIndex = 1
        '
        'lstAvailableWarehouses
        '
        Me.lstAvailableWarehouses.FormattingEnabled = True
        Me.lstAvailableWarehouses.Location = New System.Drawing.Point(19, 38)
        Me.lstAvailableWarehouses.Name = "lstAvailableWarehouses"
        Me.lstAvailableWarehouses.Size = New System.Drawing.Size(166, 95)
        Me.lstAvailableWarehouses.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigoproducto, Me.descripcion, Me.existencia, Me.cantidad, Me.almacen, Me.status, Me.fecha_pedido, Me.comprometido, Me.existenciaruteo2, Me.sacarruteo2, Me.existenciapi, Me.sacarpi, Me.pendiente})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(0, 180)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(1439, 448)
        Me.DataGridView1.TabIndex = 1
        '
        'codigoproducto
        '
        Me.codigoproducto.DataPropertyName = "codigoproducto"
        Me.codigoproducto.HeaderText = "Producto #"
        Me.codigoproducto.Name = "codigoproducto"
        Me.codigoproducto.Width = 78
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Width = 88
        '
        'existencia
        '
        Me.existencia.DataPropertyName = "existencia"
        Me.existencia.HeaderText = "Existencia"
        Me.existencia.Name = "existencia"
        Me.existencia.Width = 80
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "comprometido"
        Me.cantidad.HeaderText = "Comprometido"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Width = 99
        '
        'almacen
        '
        Me.almacen.DataPropertyName = "solicitado"
        Me.almacen.HeaderText = "Solicitado"
        Me.almacen.Name = "almacen"
        Me.almacen.Width = 78
        '
        'status
        '
        Me.status.DataPropertyName = "requerido"
        Me.status.HeaderText = "Requerido"
        Me.status.Name = "status"
        Me.status.Width = 81
        '
        'fecha_pedido
        '
        Me.fecha_pedido.DataPropertyName = "existenciapt"
        Me.fecha_pedido.HeaderText = "Existencia PT"
        Me.fecha_pedido.Name = "fecha_pedido"
        Me.fecha_pedido.Width = 89
        '
        'comprometido
        '
        Me.comprometido.DataPropertyName = "transferirpt"
        Me.comprometido.HeaderText = "Transferir de PT"
        Me.comprometido.Name = "comprometido"
        Me.comprometido.Width = 87
        '
        'existenciaruteo2
        '
        Me.existenciaruteo2.DataPropertyName = "existenciaruteo2"
        Me.existenciaruteo2.HeaderText = "Existencia Ruteo 2"
        Me.existenciaruteo2.Name = "existenciaruteo2"
        Me.existenciaruteo2.Width = 111
        '
        'sacarruteo2
        '
        Me.sacarruteo2.DataPropertyName = "transferirruteo2"
        Me.sacarruteo2.HeaderText = "Sacar de Ruteo 2"
        Me.sacarruteo2.Name = "sacarruteo2"
        Me.sacarruteo2.Width = 106
        '
        'existenciapi
        '
        Me.existenciapi.DataPropertyName = "existenciapi"
        Me.existenciapi.HeaderText = "Existencia PI"
        Me.existenciapi.Name = "existenciapi"
        Me.existenciapi.Width = 86
        '
        'sacarpi
        '
        Me.sacarpi.DataPropertyName = "transferirpi"
        Me.sacarpi.HeaderText = "Sacar de PI"
        Me.sacarpi.Name = "sacarpi"
        Me.sacarpi.Width = 72
        '
        'pendiente
        '
        Me.pendiente.DataPropertyName = "pendiente"
        Me.pendiente.HeaderText = "Pendiente"
        Me.pendiente.Name = "pendiente"
        Me.pendiente.Width = 80
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkVerNegativos)
        Me.GroupBox1.Controls.Add(Me.cboListaPrecios)
        Me.GroupBox1.Controls.Add(Me.cboBodegaDestino)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 158)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bodega de Destino"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Lista de Precios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Bodega Destino"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ver solo Negativos?"
        '
        'chkVerNegativos
        '
        Me.chkVerNegativos.Location = New System.Drawing.Point(24, 125)
        Me.chkVerNegativos.Name = "chkVerNegativos"
        Me.chkVerNegativos.Properties.Caption = "CheckEdit1"
        Me.chkVerNegativos.Size = New System.Drawing.Size(16, 20)
        Me.chkVerNegativos.TabIndex = 2
        '
        'cboListaPrecios
        '
        Me.cboListaPrecios.FormattingEnabled = True
        Me.cboListaPrecios.Items.AddRange(New Object() {"_Costos"})
        Me.cboListaPrecios.Location = New System.Drawing.Point(24, 88)
        Me.cboListaPrecios.Name = "cboListaPrecios"
        Me.cboListaPrecios.Size = New System.Drawing.Size(224, 21)
        Me.cboListaPrecios.TabIndex = 1
        '
        'cboBodegaDestino
        '
        Me.cboBodegaDestino.FormattingEnabled = True
        Me.cboBodegaDestino.Location = New System.Drawing.Point(25, 45)
        Me.cboBodegaDestino.Name = "cboBodegaDestino"
        Me.cboBodegaDestino.Size = New System.Drawing.Size(224, 21)
        Me.cboBodegaDestino.TabIndex = 0
        '
        'fmrTrasladoDeInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1439, 640)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "fmrTrasladoDeInventario"
        Me.Text = "fmrTrasladoDeInventario"
        Me.Panel1.ResumeLayout(False)
        Me.GBAcciones.ResumeLayout(False)
        Me.GBAcciones.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.chkVerNegativos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkVerNegativos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboListaPrecios As ComboBox
    Friend WithEvents cboBodegaDestino As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblPrioridad As Label
    Friend WithEvents lblDisponibles As Label
    Friend WithEvents lstSelectedWarehouses As ListBox
    Friend WithEvents lstAvailableWarehouses As ListBox
    Friend WithEvents GBAcciones As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkSeleccionarTodo As CheckBox
    Friend WithEvents btnSAP As Button
    Friend WithEvents btnExcel As Button
    Friend WithEvents btnTransAnteriores As Button
    Friend WithEvents btnAnalizar As Button
    Friend WithEvents codigoproducto As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents existencia As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents almacen As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents fecha_pedido As DataGridViewTextBoxColumn
    Friend WithEvents comprometido As DataGridViewTextBoxColumn
    Friend WithEvents existenciaruteo2 As DataGridViewTextBoxColumn
    Friend WithEvents sacarruteo2 As DataGridViewTextBoxColumn
    Friend WithEvents existenciapi As DataGridViewTextBoxColumn
    Friend WithEvents sacarpi As DataGridViewTextBoxColumn
    Friend WithEvents pendiente As DataGridViewTextBoxColumn
    Friend WithEvents btnUnselect As Button
    Friend WithEvents btnSelect As Button
End Class
