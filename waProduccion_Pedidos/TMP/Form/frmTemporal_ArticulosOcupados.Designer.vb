<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_ArticulosOcupados
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.grdTemporal_ArticulosOcupados = New DevExpress.XtraGrid.GridControl()
        Me.DsTemporal_ArticulosOcupados1 = New waProduccion_Pedidos.dsTemporal_ArticulosOcupados()
        Me.grdviewTemporal_ArticulosOcupados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.colPrograma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVentana = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.grdTemporal_ArticulosOcupados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTemporal_ArticulosOcupados1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewTemporal_ArticulosOcupados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.grdTemporal_ArticulosOcupados)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(694, 321)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'grdTemporal_ArticulosOcupados
        '
        Me.grdTemporal_ArticulosOcupados.DataMember = "dsdtTemporal_ArticulosOcupados"
        Me.grdTemporal_ArticulosOcupados.DataSource = Me.DsTemporal_ArticulosOcupados1
        Me.grdTemporal_ArticulosOcupados.Location = New System.Drawing.Point(12, 12)
        Me.grdTemporal_ArticulosOcupados.MainView = Me.grdviewTemporal_ArticulosOcupados
        Me.grdTemporal_ArticulosOcupados.Name = "grdTemporal_ArticulosOcupados"
        Me.grdTemporal_ArticulosOcupados.Size = New System.Drawing.Size(670, 297)
        Me.grdTemporal_ArticulosOcupados.TabIndex = 4
        Me.grdTemporal_ArticulosOcupados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewTemporal_ArticulosOcupados})
        '
        'DsTemporal_ArticulosOcupados1
        '
        Me.DsTemporal_ArticulosOcupados1.DataSetName = "dsTemporal_ArticulosOcupados"
        Me.DsTemporal_ArticulosOcupados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewTemporal_ArticulosOcupados
        '
        Me.grdviewTemporal_ArticulosOcupados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrograma, Me.colVentana, Me.colCodigoArticulo, Me.colUsuario, Me.GridColumn1})
        Me.grdviewTemporal_ArticulosOcupados.GridControl = Me.grdTemporal_ArticulosOcupados
        Me.grdviewTemporal_ArticulosOcupados.Name = "grdviewTemporal_ArticulosOcupados"
        Me.grdviewTemporal_ArticulosOcupados.OptionsView.ColumnAutoWidth = False
        Me.grdviewTemporal_ArticulosOcupados.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(694, 321)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdTemporal_ArticulosOcupados
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(674, 301)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'colPrograma
        '
        Me.colPrograma.AppearanceCell.Options.UseTextOptions = True
        Me.colPrograma.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrograma.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPrograma.AppearanceHeader.Options.UseFont = True
        Me.colPrograma.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrograma.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrograma.FieldName = "Programa"
        Me.colPrograma.Name = "colPrograma"
        Me.colPrograma.Visible = True
        Me.colPrograma.VisibleIndex = 0
        Me.colPrograma.Width = 175
        '
        'colVentana
        '
        Me.colVentana.AppearanceCell.Options.UseTextOptions = True
        Me.colVentana.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVentana.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVentana.AppearanceHeader.Options.UseFont = True
        Me.colVentana.AppearanceHeader.Options.UseTextOptions = True
        Me.colVentana.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVentana.FieldName = "Ventana"
        Me.colVentana.Name = "colVentana"
        Me.colVentana.Visible = True
        Me.colVentana.VisibleIndex = 1
        Me.colVentana.Width = 125
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoArticulo.AppearanceHeader.Options.UseFont = True
        Me.colCodigoArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 2
        Me.colCodigoArticulo.Width = 125
        '
        'colUsuario
        '
        Me.colUsuario.AppearanceCell.Options.UseTextOptions = True
        Me.colUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUsuario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUsuario.AppearanceHeader.Options.UseFont = True
        Me.colUsuario.AppearanceHeader.Options.UseTextOptions = True
        Me.colUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUsuario.FieldName = "Usuario"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.Visible = True
        Me.colUsuario.VisibleIndex = 3
        Me.colUsuario.Width = 125
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.FieldName = "Fecha/Hora"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        Me.GridColumn1.Width = 110
        '
        'frmTemporal_ArticulosOcupados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 321)
        Me.Controls.Add(Me.LayoutControl1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(710, 359)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(710, 359)
        Me.Name = "frmTemporal_ArticulosOcupados"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Codigos Ocupados por Otro Usuario"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.grdTemporal_ArticulosOcupados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTemporal_ArticulosOcupados1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewTemporal_ArticulosOcupados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents grdTemporal_ArticulosOcupados As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewTemporal_ArticulosOcupados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsTemporal_ArticulosOcupados1 As waProduccion_Pedidos.dsTemporal_ArticulosOcupados
    Friend WithEvents colPrograma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVentana As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
