<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_MoldesDeCodigo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemporal_MoldesDeCodigo))
        Me.lycTemporal_MoldesdeCodigo = New DevExpress.XtraLayout.LayoutControl()
        Me.grdTemporal_MoldesDeCodigo = New DevExpress.XtraGrid.GridControl()
        Me.DsTemporal_MoldesDeCodigo1 = New waProduccion_Pedidos.dsTemporal_MoldesDeCodigo()
        Me.grdviewTemporal_MoldesDeCodigo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMolde = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barbtnCancelar = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnContinuar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.lycTemporal_MoldesdeCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycTemporal_MoldesdeCodigo.SuspendLayout()
        CType(Me.grdTemporal_MoldesDeCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTemporal_MoldesDeCodigo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewTemporal_MoldesDeCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycTemporal_MoldesdeCodigo
        '
        Me.lycTemporal_MoldesdeCodigo.Controls.Add(Me.grdTemporal_MoldesDeCodigo)
        Me.lycTemporal_MoldesdeCodigo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lycTemporal_MoldesdeCodigo.Location = New System.Drawing.Point(0, 0)
        Me.lycTemporal_MoldesdeCodigo.Name = "lycTemporal_MoldesdeCodigo"
        Me.lycTemporal_MoldesdeCodigo.Root = Me.LayoutControlGroup1
        Me.lycTemporal_MoldesdeCodigo.Size = New System.Drawing.Size(557, 291)
        Me.lycTemporal_MoldesdeCodigo.TabIndex = 0
        Me.lycTemporal_MoldesdeCodigo.Text = "LayoutControl1"
        '
        'grdTemporal_MoldesDeCodigo
        '
        Me.grdTemporal_MoldesDeCodigo.DataMember = "dsdtTemporal_MoldesDeCodigo"
        Me.grdTemporal_MoldesDeCodigo.DataSource = Me.DsTemporal_MoldesDeCodigo1
        Me.grdTemporal_MoldesDeCodigo.Location = New System.Drawing.Point(12, 12)
        Me.grdTemporal_MoldesDeCodigo.MainView = Me.grdviewTemporal_MoldesDeCodigo
        Me.grdTemporal_MoldesDeCodigo.MenuManager = Me.BarManager1
        Me.grdTemporal_MoldesDeCodigo.Name = "grdTemporal_MoldesDeCodigo"
        Me.grdTemporal_MoldesDeCodigo.Size = New System.Drawing.Size(533, 267)
        Me.grdTemporal_MoldesDeCodigo.TabIndex = 4
        Me.grdTemporal_MoldesDeCodigo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewTemporal_MoldesDeCodigo})
        '
        'DsTemporal_MoldesDeCodigo1
        '
        Me.DsTemporal_MoldesDeCodigo1.DataSetName = "dsTemporal_MoldesDeCodigo"
        Me.DsTemporal_MoldesDeCodigo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdviewTemporal_MoldesDeCodigo
        '
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.Empty.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.EvenRow.Options.UseBorderColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.EvenRow.Options.UseForeColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FilterPanel.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FilterPanel.Options.UseForeColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FixedLine.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupButton.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupButton.Options.UseBorderColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupPanel.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupPanel.Options.UseForeColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupRow.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupRow.Options.UseBorderColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.GroupRow.Options.UseForeColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.HorzLine.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.HorzLine.Options.UseBorderColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.OddRow.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.OddRow.Options.UseBorderColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.OddRow.Options.UseForeColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.Preview.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.Preview.Options.UseFont = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.Preview.Options.UseForeColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.Row.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.Row.Options.UseForeColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.RowSeparator.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.TopNewRow.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.VertLine.Options.UseBackColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Appearance.VertLine.Options.UseBorderColor = True
        Me.grdviewTemporal_MoldesDeCodigo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMolde, Me.colNombre, Me.colEstatus})
        Me.grdviewTemporal_MoldesDeCodigo.GridControl = Me.grdTemporal_MoldesDeCodigo
        Me.grdviewTemporal_MoldesDeCodigo.Name = "grdviewTemporal_MoldesDeCodigo"
        Me.grdviewTemporal_MoldesDeCodigo.OptionsSelection.MultiSelect = True
        Me.grdviewTemporal_MoldesDeCodigo.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdviewTemporal_MoldesDeCodigo.OptionsView.EnableAppearanceEvenRow = True
        Me.grdviewTemporal_MoldesDeCodigo.OptionsView.EnableAppearanceOddRow = True
        Me.grdviewTemporal_MoldesDeCodigo.OptionsView.ShowGroupPanel = False
        Me.grdviewTemporal_MoldesDeCodigo.PaintStyleName = "Flat"
        '
        'colMolde
        '
        Me.colMolde.AppearanceCell.Options.UseTextOptions = True
        Me.colMolde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMolde.AppearanceHeader.Options.UseTextOptions = True
        Me.colMolde.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMolde.FieldName = "Molde"
        Me.colMolde.Name = "colMolde"
        Me.colMolde.Visible = True
        Me.colMolde.VisibleIndex = 1
        Me.colMolde.Width = 56
        '
        'colNombre
        '
        Me.colNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 2
        Me.colNombre.Width = 314
        '
        'colEstatus
        '
        Me.colEstatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstatus.FieldName = "Estatus"
        Me.colEstatus.Name = "colEstatus"
        Me.colEstatus.Visible = True
        Me.colEstatus.VisibleIndex = 3
        Me.colEstatus.Width = 65
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnContinuar, Me.barbtnCancelar})
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnCancelar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnContinuar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barbtnCancelar
        '
        Me.barbtnCancelar.Caption = "Cancelar"
        Me.barbtnCancelar.Id = 1
        Me.barbtnCancelar.ImageOptions.Image = CType(resources.GetObject("barbtnCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnCancelar.Name = "barbtnCancelar"
        '
        'barbtnContinuar
        '
        Me.barbtnContinuar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barbtnContinuar.Caption = "Continuar"
        Me.barbtnContinuar.Enabled = False
        Me.barbtnContinuar.Id = 0
        Me.barbtnContinuar.ImageOptions.Image = CType(resources.GetObject("barbtnContinuar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnContinuar.Name = "barbtnContinuar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(557, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 291)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(557, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 291)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(557, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 291)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(557, 291)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdTemporal_MoldesDeCodigo
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(537, 271)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'frmTemporal_MoldesDeCodigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 334)
        Me.Controls.Add(Me.lycTemporal_MoldesdeCodigo)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTemporal_MoldesDeCodigo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Moldes"
        CType(Me.lycTemporal_MoldesdeCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycTemporal_MoldesdeCodigo.ResumeLayout(False)
        CType(Me.grdTemporal_MoldesDeCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTemporal_MoldesDeCodigo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewTemporal_MoldesDeCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lycTemporal_MoldesdeCodigo As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barbtnContinuar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grdTemporal_MoldesDeCodigo As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewTemporal_MoldesDeCodigo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DsTemporal_MoldesDeCodigo1 As waProduccion_Pedidos.dsTemporal_MoldesDeCodigo
    Friend WithEvents colMolde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstatus As DevExpress.XtraGrid.Columns.GridColumn
End Class
