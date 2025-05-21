Imports DevExpress.XtraScheduler.UI
Partial Class OutlookAppointmentForm
    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OutlookAppointmentForm))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.backstageViewControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewControl()
        Me.bvPrint = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.dvInfo = New DevExpress.XtraPrinting.Preview.DocumentViewer()
        Me.bvtPrint = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.bvbSave = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
        Me.bvbSaveAs = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
        Me.bvbClose = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
        Me.btnSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.barLabel = New DevExpress.XtraBars.BarEditItem()
        Me.riAppointmentLabel = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel()
        Me.barStatus = New DevExpress.XtraBars.BarEditItem()
        Me.riAppointmentStatus = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentStatus()
        Me.barReminder = New DevExpress.XtraBars.BarEditItem()
        Me.riDuration = New DevExpress.XtraScheduler.UI.RepositoryItemDuration()
        Me.btnRecurrence = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNext = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrevious = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTimeZones = New DevExpress.XtraBars.BarButtonItem()
        Me.rpAppointment = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgActions = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgOptions = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.riAppointmentResource = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentResource()
        Me.lblStartTime = New DevExpress.XtraEditors.LabelControl()
        Me.edtStartDate = New DevExpress.XtraEditors.DateEdit()
        Me.tbLocation = New DevExpress.XtraEditors.TextEdit()
        Me.edtStartTime = New DevExpress.XtraScheduler.UI.SchedulerTimeEdit()
        Me.lblEndTime = New DevExpress.XtraEditors.LabelControl()
        Me.edtEndDate = New DevExpress.XtraEditors.DateEdit()
        Me.edtEndTime = New DevExpress.XtraScheduler.UI.SchedulerTimeEdit()
        Me.lblLocation = New DevExpress.XtraEditors.LabelControl()
        Me.panel1 = New DevExpress.XtraEditors.PanelControl()
        Me.edtTimeZone = New DevExpress.XtraScheduler.UI.TimeZoneEdit()
        Me.lblResource = New DevExpress.XtraEditors.LabelControl()
        Me.edtResource = New DevExpress.XtraScheduler.UI.AppointmentResourceEdit()
        Me.edtResources = New DevExpress.XtraScheduler.UI.AppointmentResourcesEdit()
        Me.chkAllDay = New DevExpress.XtraEditors.CheckEdit()
        Me.tbSubject = New DevExpress.XtraEditors.TextEdit()
        Me.progressPanel = New System.Windows.Forms.Panel()
        Me.tbProgress = New DevExpress.XtraEditors.TrackBarControl()
        Me.lblPercentCompleteValue = New DevExpress.XtraEditors.LabelControl()
        Me.lblPercentComplete = New DevExpress.XtraEditors.LabelControl()
        Me.lblSubject = New DevExpress.XtraEditors.LabelControl()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.tbDescription = New DevExpress.XtraEditors.MemoEdit()
        Me.panelDescription = New System.Windows.Forms.Panel()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.spinHorasPendientes = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.spinProduccionHora = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrioridad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.slueEstado = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.spinPendiente = New DevExpress.XtraEditors.SpinEdit()
        Me.spinCompletado = New DevExpress.XtraEditors.SpinEdit()
        Me.spinPlaneado = New DevExpress.XtraEditors.SpinEdit()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.DefaultBarAndDockingController = New DevExpress.XtraBars.DefaultBarAndDockingController(Me.components)
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backstageViewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.backstageViewControl1.SuspendLayout()
        Me.bvPrint.SuspendLayout()
        CType(Me.riAppointmentLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riAppointmentStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riAppointmentResource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.edtTimeZone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.progressPanel.SuspendLayout()
        CType(Me.tbProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.spinHorasPendientes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinProduccionHora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrioridad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPendiente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinCompletado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinPlaneado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel3.SuspendLayout()
        CType(Me.DefaultBarAndDockingController.Controller, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ApplicationButtonDropDownControl = Me.backstageViewControl1
        Me.ribbonControl1.AutoSizeItems = True
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.btnSaveAndClose, Me.btnDelete, Me.barLabel, Me.barStatus, Me.barReminder, Me.btnRecurrence, Me.btnSave, Me.btnNext, Me.btnPrevious, Me.btnTimeZones})
        resources.ApplyResources(Me.ribbonControl1, "ribbonControl1")
        Me.ribbonControl1.MaxItemId = 2
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpAppointment})
        Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.btnSave)
        Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.btnPrevious)
        Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.btnNext)
        Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.btnDelete)
        Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riAppointmentLabel, Me.riAppointmentResource, Me.riAppointmentStatus, Me.riDuration})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        '
        'backstageViewControl1
        '
        resources.ApplyResources(Me.backstageViewControl1, "backstageViewControl1")
        Me.backstageViewControl1.Controls.Add(Me.bvPrint)
        Me.backstageViewControl1.Items.Add(Me.bvtPrint)
        Me.backstageViewControl1.Items.Add(Me.bvbSave)
        Me.backstageViewControl1.Items.Add(Me.bvbSaveAs)
        Me.backstageViewControl1.Items.Add(Me.bvbClose)
        Me.backstageViewControl1.Name = "backstageViewControl1"
        Me.backstageViewControl1.OwnerControl = Me.ribbonControl1
        Me.backstageViewControl1.SelectedTab = Me.bvtPrint
        Me.backstageViewControl1.SelectedTabIndex = 0
        Me.backstageViewControl1.Style = DevExpress.XtraBars.Ribbon.BackstageViewStyle.Office2013
        '
        'bvPrint
        '
        resources.ApplyResources(Me.bvPrint, "bvPrint")
        Me.bvPrint.Controls.Add(Me.btnPrint)
        Me.bvPrint.Controls.Add(Me.dvInfo)
        Me.bvPrint.Name = "bvPrint"
        '
        'btnPrint
        '
        resources.ApplyResources(Me.btnPrint, "btnPrint")
        Me.btnPrint.ImageOptions.Image = CType(resources.GetObject("btnPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrint.Name = "btnPrint"
        '
        'dvInfo
        '
        resources.ApplyResources(Me.dvInfo, "dvInfo")
        Me.dvInfo.AutoZoom = True
        Me.dvInfo.Name = "dvInfo"
        '
        'bvtPrint
        '
        resources.ApplyResources(Me.bvtPrint, "bvtPrint")
        Me.bvtPrint.ContentControl = Me.bvPrint
        Me.bvtPrint.Name = "bvtPrint"
        Me.bvtPrint.Selected = True
        '
        'bvbSave
        '
        resources.ApplyResources(Me.bvbSave, "bvbSave")
        Me.bvbSave.Name = "bvbSave"
        '
        'bvbSaveAs
        '
        resources.ApplyResources(Me.bvbSaveAs, "bvbSaveAs")
        Me.bvbSaveAs.Name = "bvbSaveAs"
        '
        'bvbClose
        '
        resources.ApplyResources(Me.bvbClose, "bvbClose")
        Me.bvbClose.Name = "bvbClose"
        '
        'btnSaveAndClose
        '
        resources.ApplyResources(Me.btnSaveAndClose, "btnSaveAndClose")
        Me.btnSaveAndClose.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.btnSaveAndClose.Id = 3
        Me.btnSaveAndClose.ImageOptions.Image = CType(resources.GetObject("btnSaveAndClose.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSaveAndClose.ImageOptions.LargeImage = CType(resources.GetObject("btnSaveAndClose.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSaveAndClose.Name = "btnSaveAndClose"
        '
        'btnDelete
        '
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.btnDelete.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.btnDelete.Id = 4
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.LargeImage = CType(resources.GetObject("btnDelete.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDelete.Name = "btnDelete"
        '
        'barLabel
        '
        resources.ApplyResources(Me.barLabel, "barLabel")
        Me.barLabel.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.barLabel.Edit = Me.riAppointmentLabel
        Me.barLabel.Id = 8
        Me.barLabel.Name = "barLabel"
        '
        'riAppointmentLabel
        '
        resources.ApplyResources(Me.riAppointmentLabel, "riAppointmentLabel")
        Me.riAppointmentLabel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("riAppointmentLabel.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.riAppointmentLabel.Name = "riAppointmentLabel"
        '
        'barStatus
        '
        resources.ApplyResources(Me.barStatus, "barStatus")
        Me.barStatus.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.barStatus.Edit = Me.riAppointmentStatus
        Me.barStatus.Id = 11
        Me.barStatus.Name = "barStatus"
        '
        'riAppointmentStatus
        '
        resources.ApplyResources(Me.riAppointmentStatus, "riAppointmentStatus")
        Me.riAppointmentStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("riAppointmentStatus.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.riAppointmentStatus.Name = "riAppointmentStatus"
        '
        'barReminder
        '
        resources.ApplyResources(Me.barReminder, "barReminder")
        Me.barReminder.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.barReminder.Edit = Me.riDuration
        Me.barReminder.Id = 12
        Me.barReminder.Name = "barReminder"
        '
        'riDuration
        '
        resources.ApplyResources(Me.riDuration, "riDuration")
        Me.riDuration.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("riDuration.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.riDuration.DisabledStateText = Nothing
        Me.riDuration.Name = "riDuration"
        Me.riDuration.ShowEmptyItem = True
        '
        'btnRecurrence
        '
        Me.btnRecurrence.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        resources.ApplyResources(Me.btnRecurrence, "btnRecurrence")
        Me.btnRecurrence.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.btnRecurrence.Id = 17
        Me.btnRecurrence.ImageOptions.Image = CType(resources.GetObject("btnRecurrence.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRecurrence.ImageOptions.LargeImage = CType(resources.GetObject("btnRecurrence.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnRecurrence.Name = "btnRecurrence"
        '
        'btnSave
        '
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.btnSave.Id = 1
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        '
        'btnNext
        '
        resources.ApplyResources(Me.btnNext, "btnNext")
        Me.btnNext.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.btnNext.Id = 3
        Me.btnNext.ImageOptions.Image = CType(resources.GetObject("btnNext.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNext.ImageOptions.LargeImage = CType(resources.GetObject("btnNext.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnNext.Name = "btnNext"
        '
        'btnPrevious
        '
        resources.ApplyResources(Me.btnPrevious, "btnPrevious")
        Me.btnPrevious.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.btnPrevious.Id = 4
        Me.btnPrevious.ImageOptions.Image = CType(resources.GetObject("btnPrevious.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrevious.ImageOptions.LargeImage = CType(resources.GetObject("btnPrevious.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrevious.Name = "btnPrevious"
        '
        'btnTimeZones
        '
        Me.btnTimeZones.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        resources.ApplyResources(Me.btnTimeZones, "btnTimeZones")
        Me.btnTimeZones.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.btnTimeZones.Id = 1
        Me.btnTimeZones.ImageOptions.Image = CType(resources.GetObject("btnTimeZones.ImageOptions.Image"), System.Drawing.Image)
        Me.btnTimeZones.ImageOptions.LargeImage = CType(resources.GetObject("btnTimeZones.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnTimeZones.Name = "btnTimeZones"
        Me.btnTimeZones.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'rpAppointment
        '
        Me.rpAppointment.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgActions, Me.rpgOptions})
        Me.rpAppointment.Name = "rpAppointment"
        resources.ApplyResources(Me.rpAppointment, "rpAppointment")
        '
        'rpgActions
        '
        Me.rpgActions.ItemLinks.Add(Me.btnSaveAndClose)
        Me.rpgActions.ItemLinks.Add(Me.btnDelete)
        Me.rpgActions.Name = "rpgActions"
        Me.rpgActions.ShowCaptionButton = False
        resources.ApplyResources(Me.rpgActions, "rpgActions")
        '
        'rpgOptions
        '
        Me.rpgOptions.AllowTextClipping = False
        Me.rpgOptions.ItemLinks.Add(Me.barLabel)
        Me.rpgOptions.ItemLinks.Add(Me.barStatus)
        Me.rpgOptions.ItemLinks.Add(Me.barReminder)
        Me.rpgOptions.ItemLinks.Add(Me.btnRecurrence, "C")
        Me.rpgOptions.ItemLinks.Add(Me.btnTimeZones)
        Me.rpgOptions.Name = "rpgOptions"
        Me.rpgOptions.ShowCaptionButton = False
        resources.ApplyResources(Me.rpgOptions, "rpgOptions")
        '
        'riAppointmentResource
        '
        resources.ApplyResources(Me.riAppointmentResource, "riAppointmentResource")
        Me.riAppointmentResource.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("riAppointmentResource.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.riAppointmentResource.Name = "riAppointmentResource"
        '
        'lblStartTime
        '
        resources.ApplyResources(Me.lblStartTime, "lblStartTime")
        Me.lblStartTime.Name = "lblStartTime"
        '
        'edtStartDate
        '
        resources.ApplyResources(Me.edtStartDate, "edtStartDate")
        Me.edtStartDate.Name = "edtStartDate"
        Me.edtStartDate.Properties.AccessibleName = resources.GetString("edtStartDate.Properties.AccessibleName")
        Me.edtStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("edtStartDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.edtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.edtStartDate.Properties.MaxValue = New Date(4000, 1, 1, 0, 0, 0, 0)
        '
        'tbLocation
        '
        resources.ApplyResources(Me.tbLocation, "tbLocation")
        Me.tbLocation.Name = "tbLocation"
        Me.tbLocation.Properties.AccessibleName = resources.GetString("tbLocation.Properties.AccessibleName")
        '
        'edtStartTime
        '
        resources.ApplyResources(Me.edtStartTime, "edtStartTime")
        Me.edtStartTime.Name = "edtStartTime"
        Me.edtStartTime.Properties.AccessibleName = resources.GetString("edtStartTime.Properties.AccessibleName")
        Me.edtStartTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'lblEndTime
        '
        resources.ApplyResources(Me.lblEndTime, "lblEndTime")
        Me.lblEndTime.Name = "lblEndTime"
        '
        'edtEndDate
        '
        resources.ApplyResources(Me.edtEndDate, "edtEndDate")
        Me.edtEndDate.Name = "edtEndDate"
        Me.edtEndDate.Properties.AccessibleName = resources.GetString("edtEndDate.Properties.AccessibleName")
        Me.edtEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("edtEndDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.edtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.edtEndDate.Properties.MaxValue = New Date(4000, 1, 1, 0, 0, 0, 0)
        '
        'edtEndTime
        '
        resources.ApplyResources(Me.edtEndTime, "edtEndTime")
        Me.edtEndTime.Name = "edtEndTime"
        Me.edtEndTime.Properties.AccessibleName = resources.GetString("edtEndTime.Properties.AccessibleName")
        Me.edtEndTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'lblLocation
        '
        resources.ApplyResources(Me.lblLocation, "lblLocation")
        Me.lblLocation.Name = "lblLocation"
        '
        'panel1
        '
        resources.ApplyResources(Me.panel1, "panel1")
        Me.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panel1.Controls.Add(Me.edtTimeZone)
        Me.panel1.Controls.Add(Me.lblResource)
        Me.panel1.Controls.Add(Me.edtResource)
        Me.panel1.Controls.Add(Me.edtResources)
        Me.panel1.Controls.Add(Me.chkAllDay)
        Me.panel1.Name = "panel1"
        '
        'edtTimeZone
        '
        resources.ApplyResources(Me.edtTimeZone, "edtTimeZone")
        Me.edtTimeZone.MenuManager = Me.ribbonControl1
        Me.edtTimeZone.Name = "edtTimeZone"
        Me.edtTimeZone.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("edtTimeZone.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        '
        'lblResource
        '
        resources.ApplyResources(Me.lblResource, "lblResource")
        Me.lblResource.Name = "lblResource"
        '
        'edtResource
        '
        resources.ApplyResources(Me.edtResource, "edtResource")
        Me.edtResource.Name = "edtResource"
        Me.edtResource.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
        Me.edtResource.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("edtResource.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        '
        'edtResources
        '
        resources.ApplyResources(Me.edtResources, "edtResources")
        Me.edtResources.Name = "edtResources"
        Me.edtResources.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("edtResources.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        '
        '
        '
        Me.edtResources.ResourcesCheckedListBoxControl.Location = CType(resources.GetObject("edtResources.ResourcesCheckedListBoxControl.Location"), System.Drawing.Point)
        Me.edtResources.ResourcesCheckedListBoxControl.Name = ""
        Me.edtResources.ResourcesCheckedListBoxControl.TabIndex = CType(resources.GetObject("edtResources.ResourcesCheckedListBoxControl.TabIndex"), Integer)
        '
        'chkAllDay
        '
        resources.ApplyResources(Me.chkAllDay, "chkAllDay")
        Me.chkAllDay.Name = "chkAllDay"
        Me.chkAllDay.Properties.AccessibleName = resources.GetString("chkAllDay.Properties.AccessibleName")
        Me.chkAllDay.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
        Me.chkAllDay.Properties.AutoWidth = True
        Me.chkAllDay.Properties.Caption = resources.GetString("chkAllDay.Properties.Caption")
        '
        'tbSubject
        '
        resources.ApplyResources(Me.tbSubject, "tbSubject")
        Me.tbSubject.Name = "tbSubject"
        Me.tbSubject.Properties.AccessibleName = resources.GetString("tbSubject.Properties.AccessibleName")
        '
        'progressPanel
        '
        Me.progressPanel.Controls.Add(Me.tbProgress)
        Me.progressPanel.Controls.Add(Me.lblPercentCompleteValue)
        Me.progressPanel.Controls.Add(Me.lblPercentComplete)
        resources.ApplyResources(Me.progressPanel, "progressPanel")
        Me.progressPanel.Name = "progressPanel"
        Me.progressPanel.TabStop = True
        '
        'tbProgress
        '
        resources.ApplyResources(Me.tbProgress, "tbProgress")
        Me.tbProgress.Name = "tbProgress"
        Me.tbProgress.Properties.AutoSize = False
        Me.tbProgress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.tbProgress.Properties.Maximum = 100
        Me.tbProgress.Properties.ShowValueToolTip = True
        Me.tbProgress.Properties.TickFrequency = 10
        '
        'lblPercentCompleteValue
        '
        resources.ApplyResources(Me.lblPercentCompleteValue, "lblPercentCompleteValue")
        Me.lblPercentCompleteValue.Appearance.BackColor = CType(resources.GetObject("lblPercentCompleteValue.Appearance.BackColor"), System.Drawing.Color)
        Me.lblPercentCompleteValue.Appearance.Options.UseBackColor = True
        Me.lblPercentCompleteValue.Name = "lblPercentCompleteValue"
        '
        'lblPercentComplete
        '
        resources.ApplyResources(Me.lblPercentComplete, "lblPercentComplete")
        Me.lblPercentComplete.Appearance.BackColor = CType(resources.GetObject("lblPercentComplete.Appearance.BackColor"), System.Drawing.Color)
        Me.lblPercentComplete.Appearance.Options.UseBackColor = True
        Me.lblPercentComplete.Name = "lblPercentComplete"
        '
        'lblSubject
        '
        resources.ApplyResources(Me.lblSubject, "lblSubject")
        Me.lblSubject.Name = "lblSubject"
        '
        'panelMain
        '
        resources.ApplyResources(Me.panelMain, "panelMain")
        Me.panelMain.Name = "panelMain"
        '
        'tbDescription
        '
        resources.ApplyResources(Me.tbDescription, "tbDescription")
        Me.tbDescription.Name = "tbDescription"
        Me.tbDescription.Properties.AccessibleName = resources.GetString("tbDescription.Properties.AccessibleName")
        Me.tbDescription.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Client
        '
        'panelDescription
        '
        resources.ApplyResources(Me.panelDescription, "panelDescription")
        Me.panelDescription.Name = "panelDescription"
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.LabelControl10)
        Me.panel2.Controls.Add(Me.spinHorasPendientes)
        Me.panel2.Controls.Add(Me.LabelControl9)
        Me.panel2.Controls.Add(Me.spinProduccionHora)
        Me.panel2.Controls.Add(Me.LabelControl8)
        Me.panel2.Controls.Add(Me.txtNombre)
        Me.panel2.Controls.Add(Me.LabelControl7)
        Me.panel2.Controls.Add(Me.txtPrioridad)
        Me.panel2.Controls.Add(Me.LabelControl6)
        Me.panel2.Controls.Add(Me.slueEstado)
        Me.panel2.Controls.Add(Me.LabelControl4)
        Me.panel2.Controls.Add(Me.txtCodigo)
        Me.panel2.Controls.Add(Me.LabelControl3)
        Me.panel2.Controls.Add(Me.LabelControl2)
        Me.panel2.Controls.Add(Me.LabelControl1)
        Me.panel2.Controls.Add(Me.spinPendiente)
        Me.panel2.Controls.Add(Me.spinCompletado)
        Me.panel2.Controls.Add(Me.spinPlaneado)
        Me.panel2.Controls.Add(Me.lblSubject)
        Me.panel2.Controls.Add(Me.panel1)
        Me.panel2.Controls.Add(Me.tbSubject)
        Me.panel2.Controls.Add(Me.edtEndTime)
        Me.panel2.Controls.Add(Me.lblLocation)
        Me.panel2.Controls.Add(Me.edtEndDate)
        Me.panel2.Controls.Add(Me.tbLocation)
        Me.panel2.Controls.Add(Me.lblEndTime)
        Me.panel2.Controls.Add(Me.lblStartTime)
        Me.panel2.Controls.Add(Me.edtStartTime)
        Me.panel2.Controls.Add(Me.edtStartDate)
        resources.ApplyResources(Me.panel2, "panel2")
        Me.panel2.Name = "panel2"
        '
        'LabelControl10
        '
        resources.ApplyResources(Me.LabelControl10, "LabelControl10")
        Me.LabelControl10.Name = "LabelControl10"
        '
        'spinHorasPendientes
        '
        resources.ApplyResources(Me.spinHorasPendientes, "spinHorasPendientes")
        Me.spinHorasPendientes.MenuManager = Me.ribbonControl1
        Me.spinHorasPendientes.Name = "spinHorasPendientes"
        Me.spinHorasPendientes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("spinHorasPendientes.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.spinHorasPendientes.Properties.DisplayFormat.FormatString = "n0"
        Me.spinHorasPendientes.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinHorasPendientes.Properties.EditFormat.FormatString = "n0"
        Me.spinHorasPendientes.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinHorasPendientes.Properties.Mask.EditMask = resources.GetString("spinHorasPendientes.Properties.Mask.EditMask")
        Me.spinHorasPendientes.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("spinHorasPendientes.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        '
        'LabelControl9
        '
        resources.ApplyResources(Me.LabelControl9, "LabelControl9")
        Me.LabelControl9.Name = "LabelControl9"
        '
        'spinProduccionHora
        '
        resources.ApplyResources(Me.spinProduccionHora, "spinProduccionHora")
        Me.spinProduccionHora.MenuManager = Me.ribbonControl1
        Me.spinProduccionHora.Name = "spinProduccionHora"
        Me.spinProduccionHora.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("spinProduccionHora.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.spinProduccionHora.Properties.DisplayFormat.FormatString = "n0"
        Me.spinProduccionHora.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinProduccionHora.Properties.EditFormat.FormatString = "n0"
        Me.spinProduccionHora.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinProduccionHora.Properties.Mask.EditMask = resources.GetString("spinProduccionHora.Properties.Mask.EditMask")
        Me.spinProduccionHora.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("spinProduccionHora.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        '
        'LabelControl8
        '
        resources.ApplyResources(Me.LabelControl8, "LabelControl8")
        Me.LabelControl8.Name = "LabelControl8"
        '
        'txtNombre
        '
        resources.ApplyResources(Me.txtNombre, "txtNombre")
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.AccessibleName = resources.GetString("txtNombre.Properties.AccessibleName")
        '
        'LabelControl7
        '
        resources.ApplyResources(Me.LabelControl7, "LabelControl7")
        Me.LabelControl7.Name = "LabelControl7"
        '
        'txtPrioridad
        '
        resources.ApplyResources(Me.txtPrioridad, "txtPrioridad")
        Me.txtPrioridad.MenuManager = Me.ribbonControl1
        Me.txtPrioridad.Name = "txtPrioridad"
        '
        'LabelControl6
        '
        resources.ApplyResources(Me.LabelControl6, "LabelControl6")
        Me.LabelControl6.Name = "LabelControl6"
        '
        'slueEstado
        '
        resources.ApplyResources(Me.slueEstado, "slueEstado")
        Me.slueEstado.MenuManager = Me.ribbonControl1
        Me.slueEstado.Name = "slueEstado"
        Me.slueEstado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("slueEstado.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.slueEstado.Properties.NullText = resources.GetString("slueEstado.Properties.NullText")
        Me.slueEstado.Properties.View = Me.SearchLookUpEdit1View
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'LabelControl4
        '
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Name = "LabelControl4"
        '
        'txtCodigo
        '
        resources.ApplyResources(Me.txtCodigo, "txtCodigo")
        Me.txtCodigo.MenuManager = Me.ribbonControl1
        Me.txtCodigo.Name = "txtCodigo"
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        '
        'spinPendiente
        '
        resources.ApplyResources(Me.spinPendiente, "spinPendiente")
        Me.spinPendiente.MenuManager = Me.ribbonControl1
        Me.spinPendiente.Name = "spinPendiente"
        Me.spinPendiente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("spinPendiente.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.spinPendiente.Properties.DisplayFormat.FormatString = "n0"
        Me.spinPendiente.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinPendiente.Properties.EditFormat.FormatString = "n0"
        Me.spinPendiente.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinPendiente.Properties.Mask.EditMask = resources.GetString("spinPendiente.Properties.Mask.EditMask")
        Me.spinPendiente.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("spinPendiente.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        '
        'spinCompletado
        '
        resources.ApplyResources(Me.spinCompletado, "spinCompletado")
        Me.spinCompletado.MenuManager = Me.ribbonControl1
        Me.spinCompletado.Name = "spinCompletado"
        Me.spinCompletado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("spinCompletado.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.spinCompletado.Properties.DisplayFormat.FormatString = "n0"
        Me.spinCompletado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinCompletado.Properties.EditFormat.FormatString = "n0"
        Me.spinCompletado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinCompletado.Properties.Mask.EditMask = resources.GetString("spinCompletado.Properties.Mask.EditMask")
        Me.spinCompletado.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("spinCompletado.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        '
        'spinPlaneado
        '
        resources.ApplyResources(Me.spinPlaneado, "spinPlaneado")
        Me.spinPlaneado.MenuManager = Me.ribbonControl1
        Me.spinPlaneado.Name = "spinPlaneado"
        Me.spinPlaneado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("spinPlaneado.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.spinPlaneado.Properties.DisplayFormat.FormatString = "n0"
        Me.spinPlaneado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinPlaneado.Properties.EditFormat.FormatString = "n0"
        Me.spinPlaneado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinPlaneado.Properties.Mask.EditMask = resources.GetString("spinPlaneado.Properties.Mask.EditMask")
        Me.spinPlaneado.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("spinPlaneado.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.LabelControl5)
        Me.panel3.Controls.Add(Me.backstageViewControl1)
        Me.panel3.Controls.Add(Me.tbDescription)
        resources.ApplyResources(Me.panel3, "panel3")
        Me.panel3.Name = "panel3"
        '
        'LabelControl5
        '
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Appearance.BackColor = CType(resources.GetObject("LabelControl5.Appearance.BackColor"), System.Drawing.Color)
        Me.LabelControl5.Appearance.Options.UseBackColor = True
        Me.LabelControl5.Name = "LabelControl5"
        '
        'DefaultBarAndDockingController
        '
        Me.DefaultBarAndDockingController.Controller.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
        Me.DefaultBarAndDockingController.Controller.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
        '
        'OutlookAppointmentForm
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.progressPanel)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Name = "OutlookAppointmentForm"
        Me.Ribbon = Me.ribbonControl1
        Me.ShowInTaskbar = False
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backstageViewControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.backstageViewControl1.ResumeLayout(False)
        Me.bvPrint.ResumeLayout(False)
        CType(Me.riAppointmentLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riAppointmentStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riAppointmentResource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.edtTimeZone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.progressPanel.ResumeLayout(False)
        Me.progressPanel.PerformLayout()
        CType(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProgress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.spinHorasPendientes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinProduccionHora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrioridad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPendiente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinCompletado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinPlaneado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        CType(Me.DefaultBarAndDockingController.Controller, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Private components As System.ComponentModel.IContainer = Nothing
    Friend WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rpAppointment As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgActions As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgOptions As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnSaveAndClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barLabel As DevExpress.XtraBars.BarEditItem
    Friend WithEvents riAppointmentLabel As RepositoryItemAppointmentLabel
    Friend WithEvents riAppointmentResource As RepositoryItemAppointmentResource
    Friend WithEvents barStatus As DevExpress.XtraBars.BarEditItem
    Friend WithEvents riAppointmentStatus As RepositoryItemAppointmentStatus
    Friend WithEvents barReminder As DevExpress.XtraBars.BarEditItem
    Friend WithEvents riDuration As RepositoryItemDuration
    Friend WithEvents btnRecurrence As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblStartTime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents edtStartDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tbLocation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents edtStartTime As SchedulerTimeEdit
    Friend WithEvents lblEndTime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents edtEndDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents edtEndTime As SchedulerTimeEdit
    Friend WithEvents lblLocation As DevExpress.XtraEditors.LabelControl
    Friend WithEvents panel1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblResource As DevExpress.XtraEditors.LabelControl
    Friend WithEvents edtResource As AppointmentResourceEdit
    Friend WithEvents edtResources As AppointmentResourcesEdit
    Friend WithEvents chkAllDay As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents tbSubject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents progressPanel As System.Windows.Forms.Panel
    Friend WithEvents tbProgress As DevExpress.XtraEditors.TrackBarControl
    Friend WithEvents lblPercentCompleteValue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPercentComplete As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSubject As DevExpress.XtraEditors.LabelControl
    Friend WithEvents panelMain As System.Windows.Forms.Panel
    Friend WithEvents tbDescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents panelDescription As System.Windows.Forms.Panel
    Friend WithEvents panel2 As System.Windows.Forms.Panel
    Friend WithEvents panel3 As System.Windows.Forms.Panel
    Friend WithEvents backstageViewControl1 As DevExpress.XtraBars.Ribbon.BackstageViewControl
    Friend WithEvents bvbSave As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
    Friend WithEvents bvbSaveAs As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
    Friend WithEvents bvbClose As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNext As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrevious As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTimeZones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents edtTimeZone As TimeZoneEdit
    Friend WithEvents bvPrint As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents bvtPrint As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents dvInfo As DevExpress.XtraPrinting.Preview.DocumentViewer
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DefaultBarAndDockingController As DevExpress.XtraBars.DefaultBarAndDockingController
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spinPendiente As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinCompletado As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spinPlaneado As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrioridad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents slueEstado As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spinHorasPendientes As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spinProduccionHora As DevExpress.XtraEditors.SpinEdit

End Class
