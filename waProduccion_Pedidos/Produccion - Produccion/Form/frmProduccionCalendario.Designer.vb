<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduccionCalendario
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduccionCalendario))
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.OpenScheduleItem1 = New DevExpress.XtraScheduler.UI.OpenScheduleItem()
        Me.SaveScheduleItem1 = New DevExpress.XtraScheduler.UI.SaveScheduleItem()
        Me.PrintPreviewItem1 = New DevExpress.XtraScheduler.UI.PrintPreviewItem()
        Me.PrintItem1 = New DevExpress.XtraScheduler.UI.PrintItem()
        Me.PrintPageSetupItem1 = New DevExpress.XtraScheduler.UI.PrintPageSetupItem()
        Me.NewAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewAppointmentItem()
        Me.NewRecurringAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem()
        Me.NavigateViewBackwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewBackwardItem()
        Me.NavigateViewForwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewForwardItem()
        Me.GotoTodayItem1 = New DevExpress.XtraScheduler.UI.GotoTodayItem()
        Me.ViewZoomInItem1 = New DevExpress.XtraScheduler.UI.ViewZoomInItem()
        Me.ViewZoomOutItem1 = New DevExpress.XtraScheduler.UI.ViewZoomOutItem()
        Me.SwitchToDayViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToDayViewItem()
        Me.SwitchToWorkWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem()
        Me.SwitchToWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWeekViewItem()
        Me.SwitchToFullWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem()
        Me.SwitchToMonthViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToMonthViewItem()
        Me.SwitchToTimelineViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem()
        Me.SwitchToGanttViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToGanttViewItem()
        Me.SwitchToAgendaViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem()
        Me.GroupByNoneItem1 = New DevExpress.XtraScheduler.UI.GroupByNoneItem()
        Me.GroupByDateItem1 = New DevExpress.XtraScheduler.UI.GroupByDateItem()
        Me.GroupByResourceItem1 = New DevExpress.XtraScheduler.UI.GroupByResourceItem()
        Me.SwitchTimeScalesItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesItem()
        Me.ChangeScaleWidthItem1 = New DevExpress.XtraScheduler.UI.ChangeScaleWidthItem()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.SwitchTimeScalesCaptionItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem()
        Me.SwitchCompressWeekendItem1 = New DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem()
        Me.SwitchShowWorkTimeOnlyItem1 = New DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem()
        Me.SwitchCellsAutoHeightItem1 = New DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem()
        Me.ChangeSnapToCellsUIItem1 = New DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem()
        Me.EditAppointmentQueryItem1 = New DevExpress.XtraScheduler.UI.EditAppointmentQueryItem()
        Me.EditOccurrenceUICommandItem1 = New DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem()
        Me.EditSeriesUICommandItem1 = New DevExpress.XtraScheduler.UI.EditSeriesUICommandItem()
        Me.DeleteAppointmentsItem1 = New DevExpress.XtraScheduler.UI.DeleteAppointmentsItem()
        Me.DeleteOccurrenceItem1 = New DevExpress.XtraScheduler.UI.DeleteOccurrenceItem()
        Me.DeleteSeriesItem1 = New DevExpress.XtraScheduler.UI.DeleteSeriesItem()
        Me.SplitAppointmentItem1 = New DevExpress.XtraScheduler.UI.SplitAppointmentItem()
        Me.ChangeAppointmentStatusItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem()
        Me.ChangeAppointmentLabelItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem()
        Me.ToggleRecurrenceItem1 = New DevExpress.XtraScheduler.UI.ToggleRecurrenceItem()
        Me.ChangeAppointmentReminderItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem()
        Me.RepositoryItemDuration1 = New DevExpress.XtraScheduler.UI.RepositoryItemDuration()
        Me.barbtnActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.barchkOcultarPanel = New DevExpress.XtraBars.BarCheckItem()
        Me.CalendarToolsRibbonPageCategory1 = New DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory()
        Me.scCalendario = New DevExpress.XtraScheduler.SchedulerControl()
        Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.AppointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APGProduccionDataSet = New waProduccion_Pedidos.APGProduccionDataSet()
        Me.ResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentRibbonPage1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPage()
        Me.ActionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup()
        Me.OptionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup()
        Me.FileRibbonPage1 = New DevExpress.XtraScheduler.UI.FileRibbonPage()
        Me.CommonRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.CommonRibbonPageGroup()
        Me.PrintRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.PrintRibbonPageGroup()
        Me.HomeRibbonPage1 = New DevExpress.XtraScheduler.UI.HomeRibbonPage()
        Me.AppointmentRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup()
        Me.NavigatorRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup()
        Me.ArrangeRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup()
        Me.GroupByRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup()
        Me.ViewRibbonPage1 = New DevExpress.XtraScheduler.UI.ViewRibbonPage()
        Me.ActiveViewRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup()
        Me.TimeScaleRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup()
        Me.LayoutRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.sccCalendario = New DevExpress.XtraEditors.SplitContainerControl()
        Me.xtcCalendario = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpFecha = New DevExpress.XtraTab.XtraTabPage()
        Me.dteNavegador = New DevExpress.XtraScheduler.DateNavigator()
        Me.xtpCodigo = New DevExpress.XtraTab.XtraTabPage()
        Me.grdCodigo = New DevExpress.XtraGrid.GridControl()
        Me.grdviewCodigo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEmergencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrioridad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaneado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPendiente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPreferencial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AppointmentsTableAdapter = New waProduccion_Pedidos.APGProduccionDataSetTableAdapters.AppointmentsTableAdapter()
        Me.ResourcesTableAdapter = New waProduccion_Pedidos.APGProduccionDataSetTableAdapters.ResourcesTableAdapter()
        Me.SchedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDuration1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scCalendario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APGProduccionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sccCalendario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sccCalendario.SuspendLayout()
        CType(Me.xtcCalendario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcCalendario.SuspendLayout()
        Me.xtpFecha.SuspendLayout()
        CType(Me.dteNavegador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNavegador.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpCodigo.SuspendLayout()
        CType(Me.grdCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.OpenScheduleItem1, Me.SaveScheduleItem1, Me.PrintPreviewItem1, Me.PrintItem1, Me.PrintPageSetupItem1, Me.NewAppointmentItem1, Me.NewRecurringAppointmentItem1, Me.NavigateViewBackwardItem1, Me.NavigateViewForwardItem1, Me.GotoTodayItem1, Me.ViewZoomInItem1, Me.ViewZoomOutItem1, Me.SwitchToDayViewItem1, Me.SwitchToWorkWeekViewItem1, Me.SwitchToWeekViewItem1, Me.SwitchToFullWeekViewItem1, Me.SwitchToMonthViewItem1, Me.SwitchToTimelineViewItem1, Me.SwitchToGanttViewItem1, Me.SwitchToAgendaViewItem1, Me.GroupByNoneItem1, Me.GroupByDateItem1, Me.GroupByResourceItem1, Me.SwitchTimeScalesItem1, Me.ChangeScaleWidthItem1, Me.SwitchTimeScalesCaptionItem1, Me.SwitchCompressWeekendItem1, Me.SwitchShowWorkTimeOnlyItem1, Me.SwitchCellsAutoHeightItem1, Me.ChangeSnapToCellsUIItem1, Me.EditAppointmentQueryItem1, Me.EditOccurrenceUICommandItem1, Me.EditSeriesUICommandItem1, Me.DeleteAppointmentsItem1, Me.DeleteOccurrenceItem1, Me.DeleteSeriesItem1, Me.SplitAppointmentItem1, Me.ChangeAppointmentStatusItem1, Me.ChangeAppointmentLabelItem1, Me.ToggleRecurrenceItem1, Me.ChangeAppointmentReminderItem1, Me.barbtnActualizar, Me.barchkOcultarPanel})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 44
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.CalendarToolsRibbonPageCategory1})
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.FileRibbonPage1, Me.HomeRibbonPage1, Me.ViewRibbonPage1})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit1, Me.RepositoryItemDuration1})
        Me.RibbonControl.Size = New System.Drawing.Size(1169, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'OpenScheduleItem1
        '
        Me.OpenScheduleItem1.Id = 1
        Me.OpenScheduleItem1.Name = "OpenScheduleItem1"
        '
        'SaveScheduleItem1
        '
        Me.SaveScheduleItem1.Id = 2
        Me.SaveScheduleItem1.Name = "SaveScheduleItem1"
        '
        'PrintPreviewItem1
        '
        Me.PrintPreviewItem1.Id = 3
        Me.PrintPreviewItem1.Name = "PrintPreviewItem1"
        '
        'PrintItem1
        '
        Me.PrintItem1.Id = 4
        Me.PrintItem1.Name = "PrintItem1"
        '
        'PrintPageSetupItem1
        '
        Me.PrintPageSetupItem1.Id = 5
        Me.PrintPageSetupItem1.Name = "PrintPageSetupItem1"
        '
        'NewAppointmentItem1
        '
        Me.NewAppointmentItem1.Id = 6
        Me.NewAppointmentItem1.Name = "NewAppointmentItem1"
        '
        'NewRecurringAppointmentItem1
        '
        Me.NewRecurringAppointmentItem1.Id = 7
        Me.NewRecurringAppointmentItem1.Name = "NewRecurringAppointmentItem1"
        '
        'NavigateViewBackwardItem1
        '
        Me.NavigateViewBackwardItem1.Id = 8
        Me.NavigateViewBackwardItem1.Name = "NavigateViewBackwardItem1"
        '
        'NavigateViewForwardItem1
        '
        Me.NavigateViewForwardItem1.Id = 9
        Me.NavigateViewForwardItem1.Name = "NavigateViewForwardItem1"
        '
        'GotoTodayItem1
        '
        Me.GotoTodayItem1.Id = 10
        Me.GotoTodayItem1.Name = "GotoTodayItem1"
        '
        'ViewZoomInItem1
        '
        Me.ViewZoomInItem1.Id = 11
        Me.ViewZoomInItem1.Name = "ViewZoomInItem1"
        '
        'ViewZoomOutItem1
        '
        Me.ViewZoomOutItem1.Id = 12
        Me.ViewZoomOutItem1.Name = "ViewZoomOutItem1"
        '
        'SwitchToDayViewItem1
        '
        Me.SwitchToDayViewItem1.Id = 13
        Me.SwitchToDayViewItem1.Name = "SwitchToDayViewItem1"
        '
        'SwitchToWorkWeekViewItem1
        '
        Me.SwitchToWorkWeekViewItem1.Id = 14
        Me.SwitchToWorkWeekViewItem1.Name = "SwitchToWorkWeekViewItem1"
        '
        'SwitchToWeekViewItem1
        '
        Me.SwitchToWeekViewItem1.Id = 15
        Me.SwitchToWeekViewItem1.Name = "SwitchToWeekViewItem1"
        '
        'SwitchToFullWeekViewItem1
        '
        Me.SwitchToFullWeekViewItem1.Id = 16
        Me.SwitchToFullWeekViewItem1.Name = "SwitchToFullWeekViewItem1"
        '
        'SwitchToMonthViewItem1
        '
        Me.SwitchToMonthViewItem1.Id = 17
        Me.SwitchToMonthViewItem1.Name = "SwitchToMonthViewItem1"
        '
        'SwitchToTimelineViewItem1
        '
        Me.SwitchToTimelineViewItem1.Id = 18
        Me.SwitchToTimelineViewItem1.Name = "SwitchToTimelineViewItem1"
        '
        'SwitchToGanttViewItem1
        '
        Me.SwitchToGanttViewItem1.Id = 19
        Me.SwitchToGanttViewItem1.Name = "SwitchToGanttViewItem1"
        '
        'SwitchToAgendaViewItem1
        '
        Me.SwitchToAgendaViewItem1.Id = 20
        Me.SwitchToAgendaViewItem1.Name = "SwitchToAgendaViewItem1"
        '
        'GroupByNoneItem1
        '
        Me.GroupByNoneItem1.Id = 21
        Me.GroupByNoneItem1.Name = "GroupByNoneItem1"
        '
        'GroupByDateItem1
        '
        Me.GroupByDateItem1.Id = 22
        Me.GroupByDateItem1.Name = "GroupByDateItem1"
        '
        'GroupByResourceItem1
        '
        Me.GroupByResourceItem1.Id = 23
        Me.GroupByResourceItem1.Name = "GroupByResourceItem1"
        '
        'SwitchTimeScalesItem1
        '
        Me.SwitchTimeScalesItem1.Id = 24
        Me.SwitchTimeScalesItem1.Name = "SwitchTimeScalesItem1"
        '
        'ChangeScaleWidthItem1
        '
        Me.ChangeScaleWidthItem1.Edit = Me.RepositoryItemSpinEdit1
        Me.ChangeScaleWidthItem1.Id = 25
        Me.ChangeScaleWidthItem1.Name = "ChangeScaleWidthItem1"
        Me.ChangeScaleWidthItem1.UseCommandCaption = True
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {200, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'SwitchTimeScalesCaptionItem1
        '
        Me.SwitchTimeScalesCaptionItem1.Id = 26
        Me.SwitchTimeScalesCaptionItem1.Name = "SwitchTimeScalesCaptionItem1"
        '
        'SwitchCompressWeekendItem1
        '
        Me.SwitchCompressWeekendItem1.Id = 27
        Me.SwitchCompressWeekendItem1.Name = "SwitchCompressWeekendItem1"
        '
        'SwitchShowWorkTimeOnlyItem1
        '
        Me.SwitchShowWorkTimeOnlyItem1.Id = 28
        Me.SwitchShowWorkTimeOnlyItem1.Name = "SwitchShowWorkTimeOnlyItem1"
        '
        'SwitchCellsAutoHeightItem1
        '
        Me.SwitchCellsAutoHeightItem1.Id = 29
        Me.SwitchCellsAutoHeightItem1.Name = "SwitchCellsAutoHeightItem1"
        '
        'ChangeSnapToCellsUIItem1
        '
        Me.ChangeSnapToCellsUIItem1.Id = 30
        Me.ChangeSnapToCellsUIItem1.Name = "ChangeSnapToCellsUIItem1"
        '
        'EditAppointmentQueryItem1
        '
        Me.EditAppointmentQueryItem1.Id = 31
        Me.EditAppointmentQueryItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.EditOccurrenceUICommandItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.EditSeriesUICommandItem1)})
        Me.EditAppointmentQueryItem1.Name = "EditAppointmentQueryItem1"
        Me.EditAppointmentQueryItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'EditOccurrenceUICommandItem1
        '
        Me.EditOccurrenceUICommandItem1.Id = 32
        Me.EditOccurrenceUICommandItem1.Name = "EditOccurrenceUICommandItem1"
        '
        'EditSeriesUICommandItem1
        '
        Me.EditSeriesUICommandItem1.Id = 33
        Me.EditSeriesUICommandItem1.Name = "EditSeriesUICommandItem1"
        '
        'DeleteAppointmentsItem1
        '
        Me.DeleteAppointmentsItem1.Id = 34
        Me.DeleteAppointmentsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.DeleteOccurrenceItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.DeleteSeriesItem1)})
        Me.DeleteAppointmentsItem1.Name = "DeleteAppointmentsItem1"
        Me.DeleteAppointmentsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'DeleteOccurrenceItem1
        '
        Me.DeleteOccurrenceItem1.Id = 35
        Me.DeleteOccurrenceItem1.Name = "DeleteOccurrenceItem1"
        '
        'DeleteSeriesItem1
        '
        Me.DeleteSeriesItem1.Id = 36
        Me.DeleteSeriesItem1.Name = "DeleteSeriesItem1"
        '
        'SplitAppointmentItem1
        '
        Me.SplitAppointmentItem1.Id = 37
        Me.SplitAppointmentItem1.Name = "SplitAppointmentItem1"
        '
        'ChangeAppointmentStatusItem1
        '
        Me.ChangeAppointmentStatusItem1.Id = 38
        Me.ChangeAppointmentStatusItem1.Name = "ChangeAppointmentStatusItem1"
        '
        'ChangeAppointmentLabelItem1
        '
        Me.ChangeAppointmentLabelItem1.Id = 39
        Me.ChangeAppointmentLabelItem1.Name = "ChangeAppointmentLabelItem1"
        '
        'ToggleRecurrenceItem1
        '
        Me.ToggleRecurrenceItem1.Id = 40
        Me.ToggleRecurrenceItem1.Name = "ToggleRecurrenceItem1"
        '
        'ChangeAppointmentReminderItem1
        '
        Me.ChangeAppointmentReminderItem1.Edit = Me.RepositoryItemDuration1
        Me.ChangeAppointmentReminderItem1.Id = 41
        Me.ChangeAppointmentReminderItem1.Name = "ChangeAppointmentReminderItem1"
        '
        'RepositoryItemDuration1
        '
        Me.RepositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemDuration1.AutoHeight = False
        Me.RepositoryItemDuration1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDuration1.DisabledStateText = Nothing
        Me.RepositoryItemDuration1.Name = "RepositoryItemDuration1"
        Me.RepositoryItemDuration1.NullValuePromptShowForEmptyValue = True
        Me.RepositoryItemDuration1.ShowEmptyItem = True
        Me.RepositoryItemDuration1.ValidateOnEnterKey = True
        '
        'barbtnActualizar
        '
        Me.barbtnActualizar.Caption = "Actualizar"
        Me.barbtnActualizar.Id = 42
        Me.barbtnActualizar.ImageOptions.Image = CType(resources.GetObject("barbtnActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.barbtnActualizar.ImageOptions.LargeImage = CType(resources.GetObject("barbtnActualizar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barbtnActualizar.Name = "barbtnActualizar"
        '
        'barchkOcultarPanel
        '
        Me.barchkOcultarPanel.Caption = "OcultarPanel"
        Me.barchkOcultarPanel.Id = 43
        Me.barchkOcultarPanel.ImageOptions.Image = CType(resources.GetObject("barchkOcultarPanel.ImageOptions.Image"), System.Drawing.Image)
        Me.barchkOcultarPanel.ImageOptions.LargeImage = CType(resources.GetObject("barchkOcultarPanel.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barchkOcultarPanel.Name = "barchkOcultarPanel"
        '
        'CalendarToolsRibbonPageCategory1
        '
        Me.CalendarToolsRibbonPageCategory1.Control = Me.scCalendario
        Me.CalendarToolsRibbonPageCategory1.Name = "CalendarToolsRibbonPageCategory1"
        Me.CalendarToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.AppointmentRibbonPage1})
        Me.CalendarToolsRibbonPageCategory1.Visible = False
        '
        'scCalendario
        '
        Me.scCalendario.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Gantt
        Me.scCalendario.DataStorage = Me.SchedulerStorage1
        Me.scCalendario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scCalendario.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
        Me.scCalendario.Location = New System.Drawing.Point(0, 0)
        Me.scCalendario.MenuManager = Me.RibbonControl
        Me.scCalendario.Name = "scCalendario"
        Me.scCalendario.Size = New System.Drawing.Size(969, 508)
        Me.scCalendario.Start = New Date(2018, 10, 18, 0, 0, 0, 0)
        Me.scCalendario.TabIndex = 0
        Me.scCalendario.Text = "SchedulerControl1"
        Me.scCalendario.Views.DayView.ResourcesPerPage = 10
        Me.scCalendario.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.scCalendario.Views.FullWeekView.Enabled = True
        Me.scCalendario.Views.FullWeekView.ResourcesPerPage = 10
        Me.scCalendario.Views.FullWeekView.TimeRulers.Add(TimeRuler2)
        Me.scCalendario.Views.GanttView.ResourcesPerPage = 10
        Me.scCalendario.Views.GanttView.WorkTime = New DevExpress.XtraScheduler.WorkTimeInterval(System.TimeSpan.Parse("00:00:00"), System.TimeSpan.Parse("23:59:59"))
        Me.scCalendario.Views.MonthView.ResourcesPerPage = 10
        Me.scCalendario.Views.TimelineView.ResourcesPerPage = 10
        Me.scCalendario.Views.WeekView.ResourcesPerPage = 10
        Me.scCalendario.Views.WorkWeekView.ResourcesPerPage = 10
        Me.scCalendario.Views.WorkWeekView.TimeRulers.Add(TimeRuler3)
        '
        'SchedulerStorage1
        '
        Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Planeado", "Planeado"))
        Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Completado", "Completado"))
        Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Pendiente", "Pendiente"))
        Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Codigo", "Codigo"))
        Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Estado", "Estado"))
        Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("HorasPendientes", "HorasPendientes"))
        Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("NombreCodigo", "NombreCodigo"))
        Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Prioridad", "Prioridad"))
        Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ProduccionXHora", "ProduccionXHora"))
        Me.SchedulerStorage1.Appointments.DataSource = Me.AppointmentsBindingSource
        Me.SchedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
        Me.SchedulerStorage1.Appointments.Mappings.Description = "Description"
        Me.SchedulerStorage1.Appointments.Mappings.End = "EndDate"
        Me.SchedulerStorage1.Appointments.Mappings.Label = "Label"
        Me.SchedulerStorage1.Appointments.Mappings.Location = "Location"
        Me.SchedulerStorage1.Appointments.Mappings.PercentComplete = "PorcentajeCompletado"
        Me.SchedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
        Me.SchedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
        Me.SchedulerStorage1.Appointments.Mappings.ResourceId = "ResourceID"
        Me.SchedulerStorage1.Appointments.Mappings.Start = "StartDate"
        Me.SchedulerStorage1.Appointments.Mappings.Status = "Status"
        Me.SchedulerStorage1.Appointments.Mappings.Subject = "Subject"
        Me.SchedulerStorage1.Appointments.Mappings.TimeZoneId = "TimeZoneId"
        Me.SchedulerStorage1.Appointments.Mappings.Type = "Type"
        Me.SchedulerStorage1.Resources.DataSource = Me.ResourcesBindingSource
        Me.SchedulerStorage1.Resources.Mappings.Caption = "ResourceName"
        Me.SchedulerStorage1.Resources.Mappings.Color = "Color"
        Me.SchedulerStorage1.Resources.Mappings.Id = "ResourceID"
        Me.SchedulerStorage1.Resources.Mappings.Image = "Image"
        '
        'AppointmentsBindingSource
        '
        Me.AppointmentsBindingSource.DataMember = "Appointments"
        Me.AppointmentsBindingSource.DataSource = Me.APGProduccionDataSet
        '
        'APGProduccionDataSet
        '
        Me.APGProduccionDataSet.DataSetName = "APGProduccionDataSet"
        Me.APGProduccionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ResourcesBindingSource
        '
        Me.ResourcesBindingSource.DataMember = "Resources"
        Me.ResourcesBindingSource.DataSource = Me.APGProduccionDataSet
        '
        'AppointmentRibbonPage1
        '
        Me.AppointmentRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ActionsRibbonPageGroup1, Me.OptionsRibbonPageGroup1})
        Me.AppointmentRibbonPage1.Name = "AppointmentRibbonPage1"
        Me.AppointmentRibbonPage1.Visible = False
        '
        'ActionsRibbonPageGroup1
        '
        Me.ActionsRibbonPageGroup1.ItemLinks.Add(Me.EditAppointmentQueryItem1)
        Me.ActionsRibbonPageGroup1.ItemLinks.Add(Me.DeleteAppointmentsItem1)
        Me.ActionsRibbonPageGroup1.ItemLinks.Add(Me.SplitAppointmentItem1)
        Me.ActionsRibbonPageGroup1.Name = "ActionsRibbonPageGroup1"
        '
        'OptionsRibbonPageGroup1
        '
        Me.OptionsRibbonPageGroup1.ItemLinks.Add(Me.ChangeAppointmentStatusItem1)
        Me.OptionsRibbonPageGroup1.ItemLinks.Add(Me.ChangeAppointmentLabelItem1)
        Me.OptionsRibbonPageGroup1.ItemLinks.Add(Me.ToggleRecurrenceItem1)
        Me.OptionsRibbonPageGroup1.ItemLinks.Add(Me.ChangeAppointmentReminderItem1)
        Me.OptionsRibbonPageGroup1.Name = "OptionsRibbonPageGroup1"
        '
        'FileRibbonPage1
        '
        Me.FileRibbonPage1.Appearance.BackColor = System.Drawing.Color.Red
        Me.FileRibbonPage1.Appearance.BackColor2 = System.Drawing.Color.Red
        Me.FileRibbonPage1.Appearance.BorderColor = System.Drawing.Color.Red
        Me.FileRibbonPage1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Italic
        Me.FileRibbonPage1.Appearance.Options.UseBackColor = True
        Me.FileRibbonPage1.Appearance.Options.UseBorderColor = True
        Me.FileRibbonPage1.Appearance.Options.UseFont = True
        Me.FileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.CommonRibbonPageGroup1, Me.PrintRibbonPageGroup1})
        Me.FileRibbonPage1.Name = "FileRibbonPage1"
        Me.FileRibbonPage1.Text = "Archivo"
        '
        'CommonRibbonPageGroup1
        '
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.OpenScheduleItem1)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SaveScheduleItem1)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.barbtnActualizar)
        Me.CommonRibbonPageGroup1.Name = "CommonRibbonPageGroup1"
        '
        'PrintRibbonPageGroup1
        '
        Me.PrintRibbonPageGroup1.ItemLinks.Add(Me.PrintPreviewItem1)
        Me.PrintRibbonPageGroup1.ItemLinks.Add(Me.PrintItem1)
        Me.PrintRibbonPageGroup1.ItemLinks.Add(Me.PrintPageSetupItem1)
        Me.PrintRibbonPageGroup1.Name = "PrintRibbonPageGroup1"
        '
        'HomeRibbonPage1
        '
        Me.HomeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.AppointmentRibbonPageGroup1, Me.NavigatorRibbonPageGroup1, Me.ArrangeRibbonPageGroup1, Me.GroupByRibbonPageGroup1})
        Me.HomeRibbonPage1.Name = "HomeRibbonPage1"
        '
        'AppointmentRibbonPageGroup1
        '
        Me.AppointmentRibbonPageGroup1.ItemLinks.Add(Me.NewAppointmentItem1)
        Me.AppointmentRibbonPageGroup1.ItemLinks.Add(Me.NewRecurringAppointmentItem1)
        Me.AppointmentRibbonPageGroup1.Name = "AppointmentRibbonPageGroup1"
        '
        'NavigatorRibbonPageGroup1
        '
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.NavigateViewBackwardItem1)
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.NavigateViewForwardItem1)
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.GotoTodayItem1)
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.ViewZoomInItem1)
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.ViewZoomOutItem1)
        Me.NavigatorRibbonPageGroup1.Name = "NavigatorRibbonPageGroup1"
        '
        'ArrangeRibbonPageGroup1
        '
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToDayViewItem1)
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToWorkWeekViewItem1)
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToWeekViewItem1)
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToFullWeekViewItem1)
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToMonthViewItem1)
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToTimelineViewItem1)
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToGanttViewItem1)
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToAgendaViewItem1)
        Me.ArrangeRibbonPageGroup1.Name = "ArrangeRibbonPageGroup1"
        '
        'GroupByRibbonPageGroup1
        '
        Me.GroupByRibbonPageGroup1.ItemLinks.Add(Me.GroupByNoneItem1)
        Me.GroupByRibbonPageGroup1.ItemLinks.Add(Me.GroupByDateItem1)
        Me.GroupByRibbonPageGroup1.ItemLinks.Add(Me.GroupByResourceItem1)
        Me.GroupByRibbonPageGroup1.Name = "GroupByRibbonPageGroup1"
        '
        'ViewRibbonPage1
        '
        Me.ViewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ActiveViewRibbonPageGroup1, Me.TimeScaleRibbonPageGroup1, Me.LayoutRibbonPageGroup1})
        Me.ViewRibbonPage1.Name = "ViewRibbonPage1"
        '
        'ActiveViewRibbonPageGroup1
        '
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToDayViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToWorkWeekViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToWeekViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToFullWeekViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToMonthViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToTimelineViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToGanttViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToAgendaViewItem1)
        Me.ActiveViewRibbonPageGroup1.Name = "ActiveViewRibbonPageGroup1"
        '
        'TimeScaleRibbonPageGroup1
        '
        Me.TimeScaleRibbonPageGroup1.ItemLinks.Add(Me.SwitchTimeScalesItem1)
        Me.TimeScaleRibbonPageGroup1.ItemLinks.Add(Me.ChangeScaleWidthItem1)
        Me.TimeScaleRibbonPageGroup1.ItemLinks.Add(Me.SwitchTimeScalesCaptionItem1)
        Me.TimeScaleRibbonPageGroup1.Name = "TimeScaleRibbonPageGroup1"
        '
        'LayoutRibbonPageGroup1
        '
        Me.LayoutRibbonPageGroup1.ItemLinks.Add(Me.SwitchCompressWeekendItem1)
        Me.LayoutRibbonPageGroup1.ItemLinks.Add(Me.SwitchShowWorkTimeOnlyItem1)
        Me.LayoutRibbonPageGroup1.ItemLinks.Add(Me.SwitchCellsAutoHeightItem1)
        Me.LayoutRibbonPageGroup1.ItemLinks.Add(Me.ChangeSnapToCellsUIItem1)
        Me.LayoutRibbonPageGroup1.ItemLinks.Add(Me.barchkOcultarPanel)
        Me.LayoutRibbonPageGroup1.Name = "LayoutRibbonPageGroup1"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 651)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1169, 31)
        '
        'sccCalendario
        '
        Me.sccCalendario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sccCalendario.Location = New System.Drawing.Point(0, 143)
        Me.sccCalendario.Name = "sccCalendario"
        Me.sccCalendario.Panel1.Controls.Add(Me.scCalendario)
        Me.sccCalendario.Panel1.Text = "Panel1"
        Me.sccCalendario.Panel2.Controls.Add(Me.xtcCalendario)
        Me.sccCalendario.Panel2.Text = "Panel2"
        Me.sccCalendario.Size = New System.Drawing.Size(1169, 508)
        Me.sccCalendario.SplitterPosition = 969
        Me.sccCalendario.TabIndex = 2
        Me.sccCalendario.Text = "SplitContainerControl1"
        '
        'xtcCalendario
        '
        Me.xtcCalendario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcCalendario.Location = New System.Drawing.Point(0, 0)
        Me.xtcCalendario.Name = "xtcCalendario"
        Me.xtcCalendario.SelectedTabPage = Me.xtpFecha
        Me.xtcCalendario.Size = New System.Drawing.Size(195, 508)
        Me.xtcCalendario.TabIndex = 1
        Me.xtcCalendario.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpFecha, Me.xtpCodigo})
        '
        'xtpFecha
        '
        Me.xtpFecha.Controls.Add(Me.dteNavegador)
        Me.xtpFecha.Name = "xtpFecha"
        Me.xtpFecha.Size = New System.Drawing.Size(189, 480)
        Me.xtpFecha.Text = "Fecha"
        '
        'dteNavegador
        '
        Me.dteNavegador.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.dteNavegador.CalendarAppearance.DayCellSpecial.Options.UseFont = True
        Me.dteNavegador.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNavegador.Cursor = System.Windows.Forms.Cursors.Default
        Me.dteNavegador.DateTime = New Date(2018, 10, 19, 0, 0, 0, 0)
        Me.dteNavegador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dteNavegador.EditValue = New Date(2018, 10, 19, 0, 0, 0, 0)
        Me.dteNavegador.FirstDayOfWeek = System.DayOfWeek.Sunday
        Me.dteNavegador.Location = New System.Drawing.Point(0, 0)
        Me.dteNavegador.Name = "dteNavegador"
        Me.dteNavegador.SchedulerControl = Me.scCalendario
        Me.dteNavegador.Size = New System.Drawing.Size(189, 480)
        Me.dteNavegador.TabIndex = 0
        '
        'xtpCodigo
        '
        Me.xtpCodigo.Controls.Add(Me.grdCodigo)
        Me.xtpCodigo.Name = "xtpCodigo"
        Me.xtpCodigo.Size = New System.Drawing.Size(189, 480)
        Me.xtpCodigo.Text = "Codigo"
        '
        'grdCodigo
        '
        Me.grdCodigo.DataMember = "dsdtOrdenesProduccion"
        Me.grdCodigo.DataSource = Me.APGProduccionDataSet
        Me.grdCodigo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCodigo.Location = New System.Drawing.Point(0, 0)
        Me.grdCodigo.MainView = Me.grdviewCodigo
        Me.grdCodigo.MenuManager = Me.RibbonControl
        Me.grdCodigo.Name = "grdCodigo"
        Me.grdCodigo.Size = New System.Drawing.Size(189, 480)
        Me.grdCodigo.TabIndex = 0
        Me.grdCodigo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdviewCodigo})
        '
        'grdviewCodigo
        '
        Me.grdviewCodigo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEmergencia, Me.colPrioridad, Me.colCodigoArticulo, Me.colNombreArticulo, Me.colPlaneado, Me.colCompletado, Me.colPendiente, Me.colPreferencial})
        Me.grdviewCodigo.GridControl = Me.grdCodigo
        Me.grdviewCodigo.GroupCount = 1
        Me.grdviewCodigo.Name = "grdviewCodigo"
        Me.grdviewCodigo.OptionsFind.AlwaysVisible = True
        Me.grdviewCodigo.OptionsSelection.MultiSelect = True
        Me.grdviewCodigo.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdviewCodigo.OptionsView.ColumnAutoWidth = False
        Me.grdviewCodigo.OptionsView.ShowFooter = True
        Me.grdviewCodigo.OptionsView.ShowGroupPanel = False
        Me.grdviewCodigo.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colEmergencia, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colEmergencia
        '
        Me.colEmergencia.FieldName = "Emergencia"
        Me.colEmergencia.Name = "colEmergencia"
        Me.colEmergencia.Visible = True
        Me.colEmergencia.VisibleIndex = 0
        '
        'colPrioridad
        '
        Me.colPrioridad.FieldName = "Prioridad"
        Me.colPrioridad.Name = "colPrioridad"
        Me.colPrioridad.Visible = True
        Me.colPrioridad.VisibleIndex = 1
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 2
        Me.colCodigoArticulo.Width = 106
        '
        'colNombreArticulo
        '
        Me.colNombreArticulo.FieldName = "NombreArticulo"
        Me.colNombreArticulo.Name = "colNombreArticulo"
        Me.colNombreArticulo.Visible = True
        Me.colNombreArticulo.VisibleIndex = 3
        Me.colNombreArticulo.Width = 225
        '
        'colPlaneado
        '
        Me.colPlaneado.FieldName = "Planeado"
        Me.colPlaneado.Name = "colPlaneado"
        Me.colPlaneado.Visible = True
        Me.colPlaneado.VisibleIndex = 4
        '
        'colCompletado
        '
        Me.colCompletado.FieldName = "Completado"
        Me.colCompletado.Name = "colCompletado"
        Me.colCompletado.Visible = True
        Me.colCompletado.VisibleIndex = 5
        '
        'colPendiente
        '
        Me.colPendiente.FieldName = "Pendiente"
        Me.colPendiente.Name = "colPendiente"
        Me.colPendiente.Visible = True
        Me.colPendiente.VisibleIndex = 6
        '
        'colPreferencial
        '
        Me.colPreferencial.FieldName = "Preferencial"
        Me.colPreferencial.Name = "colPreferencial"
        Me.colPreferencial.Visible = True
        Me.colPreferencial.VisibleIndex = 7
        '
        'AppointmentsTableAdapter
        '
        Me.AppointmentsTableAdapter.ClearBeforeFill = True
        '
        'ResourcesTableAdapter
        '
        Me.ResourcesTableAdapter.ClearBeforeFill = True
        '
        'SchedulerBarController1
        '
        Me.SchedulerBarController1.BarItems.Add(Me.OpenScheduleItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SaveScheduleItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.PrintPreviewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.PrintItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.PrintPageSetupItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NewAppointmentItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NewRecurringAppointmentItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NavigateViewBackwardItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NavigateViewForwardItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GotoTodayItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ViewZoomInItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ViewZoomOutItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToDayViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToWorkWeekViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToWeekViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToFullWeekViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToMonthViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToTimelineViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToGanttViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToAgendaViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GroupByNoneItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GroupByDateItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GroupByResourceItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchTimeScalesItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeScaleWidthItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchTimeScalesCaptionItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchCompressWeekendItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchShowWorkTimeOnlyItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchCellsAutoHeightItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeSnapToCellsUIItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.EditAppointmentQueryItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.EditOccurrenceUICommandItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.EditSeriesUICommandItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.DeleteAppointmentsItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.DeleteOccurrenceItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.DeleteSeriesItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SplitAppointmentItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeAppointmentStatusItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeAppointmentLabelItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ToggleRecurrenceItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeAppointmentReminderItem1)
        Me.SchedulerBarController1.Control = Me.scCalendario
        '
        'frmProduccionCalendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 682)
        Me.Controls.Add(Me.sccCalendario)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frmProduccionCalendario"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "frmProduccionCalendario"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDuration1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scCalendario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APGProduccionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sccCalendario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sccCalendario.ResumeLayout(False)
        CType(Me.xtcCalendario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcCalendario.ResumeLayout(False)
        Me.xtpFecha.ResumeLayout(False)
        CType(Me.dteNavegador.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNavegador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpCodigo.ResumeLayout(False)
        CType(Me.grdCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents sccCalendario As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents scCalendario As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents dteNavegador As DevExpress.XtraScheduler.DateNavigator
    Friend WithEvents APGProduccionDataSet As waProduccion_Pedidos.APGProduccionDataSet
    Friend WithEvents AppointmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AppointmentsTableAdapter As waProduccion_Pedidos.APGProduccionDataSetTableAdapters.AppointmentsTableAdapter
    Friend WithEvents ResourcesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResourcesTableAdapter As waProduccion_Pedidos.APGProduccionDataSetTableAdapters.ResourcesTableAdapter
    Friend WithEvents OpenScheduleItem1 As DevExpress.XtraScheduler.UI.OpenScheduleItem
    Friend WithEvents SaveScheduleItem1 As DevExpress.XtraScheduler.UI.SaveScheduleItem
    Friend WithEvents PrintPreviewItem1 As DevExpress.XtraScheduler.UI.PrintPreviewItem
    Friend WithEvents PrintItem1 As DevExpress.XtraScheduler.UI.PrintItem
    Friend WithEvents PrintPageSetupItem1 As DevExpress.XtraScheduler.UI.PrintPageSetupItem
    Friend WithEvents NewAppointmentItem1 As DevExpress.XtraScheduler.UI.NewAppointmentItem
    Friend WithEvents NewRecurringAppointmentItem1 As DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem
    Friend WithEvents NavigateViewBackwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewBackwardItem
    Friend WithEvents NavigateViewForwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewForwardItem
    Friend WithEvents GotoTodayItem1 As DevExpress.XtraScheduler.UI.GotoTodayItem
    Friend WithEvents ViewZoomInItem1 As DevExpress.XtraScheduler.UI.ViewZoomInItem
    Friend WithEvents ViewZoomOutItem1 As DevExpress.XtraScheduler.UI.ViewZoomOutItem
    Friend WithEvents SwitchToDayViewItem1 As DevExpress.XtraScheduler.UI.SwitchToDayViewItem
    Friend WithEvents SwitchToWorkWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem
    Friend WithEvents SwitchToWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWeekViewItem
    Friend WithEvents SwitchToFullWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem
    Friend WithEvents SwitchToMonthViewItem1 As DevExpress.XtraScheduler.UI.SwitchToMonthViewItem
    Friend WithEvents SwitchToTimelineViewItem1 As DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem
    Friend WithEvents SwitchToGanttViewItem1 As DevExpress.XtraScheduler.UI.SwitchToGanttViewItem
    Friend WithEvents SwitchToAgendaViewItem1 As DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem
    Friend WithEvents GroupByNoneItem1 As DevExpress.XtraScheduler.UI.GroupByNoneItem
    Friend WithEvents GroupByDateItem1 As DevExpress.XtraScheduler.UI.GroupByDateItem
    Friend WithEvents GroupByResourceItem1 As DevExpress.XtraScheduler.UI.GroupByResourceItem
    Friend WithEvents SwitchTimeScalesItem1 As DevExpress.XtraScheduler.UI.SwitchTimeScalesItem
    Friend WithEvents ChangeScaleWidthItem1 As DevExpress.XtraScheduler.UI.ChangeScaleWidthItem
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents SwitchTimeScalesCaptionItem1 As DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem
    Friend WithEvents SwitchCompressWeekendItem1 As DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem
    Friend WithEvents SwitchShowWorkTimeOnlyItem1 As DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem
    Friend WithEvents SwitchCellsAutoHeightItem1 As DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem
    Friend WithEvents ChangeSnapToCellsUIItem1 As DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem
    Friend WithEvents EditAppointmentQueryItem1 As DevExpress.XtraScheduler.UI.EditAppointmentQueryItem
    Friend WithEvents EditOccurrenceUICommandItem1 As DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem
    Friend WithEvents EditSeriesUICommandItem1 As DevExpress.XtraScheduler.UI.EditSeriesUICommandItem
    Friend WithEvents DeleteAppointmentsItem1 As DevExpress.XtraScheduler.UI.DeleteAppointmentsItem
    Friend WithEvents DeleteOccurrenceItem1 As DevExpress.XtraScheduler.UI.DeleteOccurrenceItem
    Friend WithEvents DeleteSeriesItem1 As DevExpress.XtraScheduler.UI.DeleteSeriesItem
    Friend WithEvents SplitAppointmentItem1 As DevExpress.XtraScheduler.UI.SplitAppointmentItem
    Friend WithEvents ChangeAppointmentStatusItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem
    Friend WithEvents ChangeAppointmentLabelItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem
    Friend WithEvents ToggleRecurrenceItem1 As DevExpress.XtraScheduler.UI.ToggleRecurrenceItem
    Friend WithEvents ChangeAppointmentReminderItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem
    Friend WithEvents RepositoryItemDuration1 As DevExpress.XtraScheduler.UI.RepositoryItemDuration
    Friend WithEvents CalendarToolsRibbonPageCategory1 As DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory
    Friend WithEvents AppointmentRibbonPage1 As DevExpress.XtraScheduler.UI.AppointmentRibbonPage
    Friend WithEvents ActionsRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup
    Friend WithEvents OptionsRibbonPageGroup1 As DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup
    Friend WithEvents FileRibbonPage1 As DevExpress.XtraScheduler.UI.FileRibbonPage
    Friend WithEvents CommonRibbonPageGroup1 As DevExpress.XtraScheduler.UI.CommonRibbonPageGroup
    Friend WithEvents PrintRibbonPageGroup1 As DevExpress.XtraScheduler.UI.PrintRibbonPageGroup
    Friend WithEvents HomeRibbonPage1 As DevExpress.XtraScheduler.UI.HomeRibbonPage
    Friend WithEvents AppointmentRibbonPageGroup1 As DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup
    Friend WithEvents NavigatorRibbonPageGroup1 As DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup
    Friend WithEvents ArrangeRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup
    Friend WithEvents GroupByRibbonPageGroup1 As DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup
    Friend WithEvents ViewRibbonPage1 As DevExpress.XtraScheduler.UI.ViewRibbonPage
    Friend WithEvents ActiveViewRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup
    Friend WithEvents TimeScaleRibbonPageGroup1 As DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup
    Friend WithEvents LayoutRibbonPageGroup1 As DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup
    Friend WithEvents SchedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController
    Friend WithEvents barbtnActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents xtcCalendario As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpCodigo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grdCodigo As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdviewCodigo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents xtpFecha As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents colEmergencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrioridad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaneado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreferencial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barchkOcultarPanel As DevExpress.XtraBars.BarCheckItem


End Class
