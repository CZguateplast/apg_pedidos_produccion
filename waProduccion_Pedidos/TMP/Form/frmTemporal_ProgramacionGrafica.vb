Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports DevExpress.Utils

Public Class frmTemporal_ProgramacionGrafica

    Dim ganttChart As New ChartControl()

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmTemporal_ProgramacionGrafica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            'ARTICULOS PROGRAMADOS
            Dim dtOrdenesProgramadas As New DataTable()
            dtOrdenesProgramadas = GET_PlanificacionProduccion_Programada()

            For I = 0 To dtOrdenesProgramadas.Rows.Count - 1
                dtOrdenesProgramadas.Rows(I)("HorasPendiente") = mFunciones.FCN_ProduccionHoras(dtOrdenesProgramadas.Rows(I)("CodigoArticulo"), dtOrdenesProgramadas.Rows(I)("Pendiente"))
                dtOrdenesProgramadas.Rows(I)("ProduccionHora") = mSQLSelect.GET_MoldesProduccionParametros(dtOrdenesProgramadas.Rows(I)("CodigoArticulo").ToString).Rows(0)("ArticulosHora")
            Next

            Dim pColumn As New DataColumn
            pColumn = New DataColumn("FechaInicial", Type.GetType("System.DateTime"))
            dtOrdenesProgramadas.Columns.Add(pColumn)
            pColumn = New DataColumn("FechaFinal", Type.GetType("System.DateTime"))
            dtOrdenesProgramadas.Columns.Add(pColumn)




            'PROGRAMAR HORAS INICIO

            Dim pMaquinaAnterior As String = String.Empty
            Dim pMaquinaActual As String = String.Empty
            Dim pFechaActual As New DateTime
            Dim pFechaInicial As New DateTime
            Dim pFechaFinal As New DateTime

            pFechaActual = DateTime.Now()

            For I = 0 To dtOrdenesProgramadas.Rows.Count - 1
                If I = 0 Then
                    pFechaInicial = pFechaActual
                    pFechaFinal = pFechaInicial.AddHours(dtOrdenesProgramadas.Rows(I)("HorasPendiente"))
                    dtOrdenesProgramadas.Rows(I)("FechaInicial") = pFechaInicial
                    dtOrdenesProgramadas.Rows(I)("FechaFinal") = pFechaFinal
                Else
                    pMaquinaAnterior = dtOrdenesProgramadas.Rows(I - 1)("Preferencial")
                    pMaquinaActual = dtOrdenesProgramadas.Rows(I)("Preferencial")

                    If pMaquinaActual = pMaquinaAnterior Then
                        pFechaInicial = pFechaFinal.AddHours(12)
                        pFechaFinal = pFechaInicial.AddHours(dtOrdenesProgramadas.Rows(I)("HorasPendiente"))
                        dtOrdenesProgramadas.Rows(I)("FechaInicial") = pFechaInicial
                        dtOrdenesProgramadas.Rows(I)("FechaFinal") = pFechaFinal

                    Else
                        pFechaInicial = pFechaActual
                        pFechaFinal = pFechaInicial.AddHours(dtOrdenesProgramadas.Rows(I)("HorasPendiente"))
                        dtOrdenesProgramadas.Rows(I)("FechaInicial") = pFechaInicial
                        dtOrdenesProgramadas.Rows(I)("FechaFinal") = pFechaFinal
                    End If


                End If

            Next

            DsTemporal_ProgramacionGrafica1.Tables(DsTemporal_ProgramacionGrafica1.dsdtOrdenesProgramadas.TableName.ToString).Clear()
            If Not dtOrdenesProgramadas.Rows.Count = Nothing Then
                DsTemporal_ProgramacionGrafica1.Tables(DsTemporal_ProgramacionGrafica1.dsdtOrdenesProgramadas.TableName.ToString).Merge(dtOrdenesProgramadas)
            End If
  
            ' Create a new chart.
            'Dim ganttChart As New ChartControl()

            Dim series1 As New Series("Planificacion de Maquinas", ViewType.SideBySideGantt)

            series1.ValueScaleType = ScaleType.DateTime


            Dim pFechaInicial1 As DateTime
            Dim pFechaFinal1 As DateTime

            For I = 0 To dtOrdenesProgramadas.Rows.Count - 1
                pFechaInicial1 = dtOrdenesProgramadas.Rows(I)("FechaInicial")
                pFechaFinal1 = dtOrdenesProgramadas.Rows(I)("FechaFinal")
                series1.Points.Add(New SeriesPoint(dtOrdenesProgramadas.Rows(I)("Preferencial").ToString, New DateTime() {New DateTime(pFechaInicial1.Date.Ticks), New DateTime(pFechaFinal1.Date.Ticks)}))
            Next





            

            ' Create two Gantt series.
            'Dim series1 As New Series("Estimation", ViewType.SideBySideGantt)
            'Dim series2 As New Series("Implementation", ViewType.Gantt)

            ' Specify the date-time value scale type,
            ' because it is qualitative by default.
            'series1.ValueScaleType = ScaleType.DateTime
            'series2.ValueScaleType = ScaleType.DateTime

            '' Add points to them.
            'series1.Points.Add(New SeriesPoint("Task 1", New Date() {New Date(2006, 8, 16), New Date(2006, 8, 31)}))
            'series1.Points.Add(New SeriesPoint("Task 1", New Date() {New Date(2006, 9, 1), New Date(2006, 9, 15)}))

            'series1.Points.Add(New SeriesPoint("Task 2", New Date() { _
            '    New Date(2006, 8, 31), _
            '    New Date(2006, 9, 15) _
            '}))
            'series1.Points.Add(New SeriesPoint("Task 3", New Date() { _
            '    New Date(2006, 9, 15), _
            '    New Date(2006, 9, 30) _
            '}))
            'series1.Points.Add(New SeriesPoint("Task 4", New Date() { _
            '    New Date(2006, 9, 30), _
            '    New Date(2006, 10, 15) _
            '}))

            'series2.Points.Add(New SeriesPoint("Task 1", New Date() { _
            '   New Date(2006, 9, 1), _
            '    New Date(2006, 9, 10) _
            '}))
            'series2.Points.Add(New SeriesPoint("Task 2", New Date() { _
            '    New Date(2006, 9, 5), _
            '    New Date(2006, 9, 22) _
            '}))
            'series2.Points.Add(New SeriesPoint("Task 3", New Date() { _
            '    New Date(2006, 9, 22), _
            '    New Date(2006, 10, 10) _
            '}))
            'series2.Points.Add(New SeriesPoint("Task 4", New Date() { _
            '    New Date(2006, 10, 10), _
            '    New Date(2006, 10, 23) _
            '}))

            ' Add both series to the chart.
            ganttChart.Series.AddRange(New Series() {series1})
            'ganttChart.Series.AddRange(New Series() {series1, series2})

            ' Access the view-type-specific options of the second series.
            'Dim myView2 As SideBySideGanttSeriesView = CType(series2.View, SideBySideGanttSeriesView)

            'myView2.MaxValueMarkerVisibility = DefaultBoolean.True
            'myView2.MaxValueMarker.Kind = MarkerKind.Star
            'myView2.MaxValueMarker.StarPointCount = 5
            'myView2.MaxValueMarker.Size = 10

            'myView2.MinValueMarkerVisibility = DefaultBoolean.True
            'myView2.MinValueMarker.Kind = MarkerKind.Circle
            'myView2.MinValueMarker.Size = 10

            'myView2.BarWidth = 0.5

            ' Customize the chart (if necessary).
            Dim myDiagram As GanttDiagram = CType(ganttChart.Diagram, GanttDiagram)

            myDiagram.AxisX.Title.Visibility = DefaultBoolean.True
            myDiagram.AxisX.Title.Text = "Maquinas"
            myDiagram.AxisX.ScaleBreaks.GenerateName()

            myDiagram.AxisY.Interlaced = True
            'myDiagram.AxisY.DateTimeScaleOptions.GridSpacing = 1
            'myDiagram.AxisY.DateTimeScaleOptions.AutoGrid = True
            'myDiagram.AxisY.Label.Angle = 
            myDiagram.AxisY.Label.EnableAntialiasing = DefaultBoolean.True
            myDiagram.AxisY.Label.TextPattern = "{V:MMM dd}"
            myDiagram.AxisY.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Week 'SET tiempo de Scala

            ' Customize the legend (if necessary).
            ganttChart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Right
            ganttChart.Legend.AlignmentVertical = LegendAlignmentVertical.TopOutside
            ganttChart.Legend.Direction = LegendDirection.LeftToRight

            'pFechaActual = pFechaActual.AddDays(15)

            ' Add a constant line.
            Dim deadline As New ConstantLine("8 Dias", New Date(pFechaActual.AddDays(8).Date.Ticks))
            deadline.ShowInLegend = True
            deadline.Title.Alignment = ConstantLineTitleAlignment.Far
            deadline.Color = Color.Red
            myDiagram.AxisY.ConstantLines.Add(deadline)

            ' Add a constant line.
            Dim deadline2 As New ConstantLine("15 Dias", New Date(pFechaActual.AddDays(15).Date.Ticks))
            deadline2.ShowInLegend = True
            deadline2.Title.Alignment = ConstantLineTitleAlignment.Far
            deadline2.Color = Color.Orange
            myDiagram.AxisY.ConstantLines.Add(deadline2)

            ' Add a constant line.
            Dim deadline3 As New ConstantLine("22 Dias", New Date(pFechaActual.AddDays(22).Date.Ticks))
            deadline3.ShowInLegend = True
            deadline3.Title.Alignment = ConstantLineTitleAlignment.Far
            deadline3.Color = Color.Green
            myDiagram.AxisY.ConstantLines.Add(deadline3)

            ' Add a constant line.
            Dim deadline4 As New ConstantLine("30 Dias", New Date(pFechaActual.AddDays(30).Date.Ticks))
            deadline4.ShowInLegend = True
            deadline4.Title.Alignment = ConstantLineTitleAlignment.Far
            deadline4.Color = Color.Blue
            myDiagram.AxisY.ConstantLines.Add(deadline4)



            ' Add a title to the chart (if necessary).
            ganttChart.Titles.Add(New ChartTitle())
            ganttChart.Titles(0).Text = "Programacion de Maquinas"

            ' Add the chart to the form.
            ganttChart.Dock = DockStyle.Fill
            Me.Controls.Add(ganttChart)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnVistaPrevia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnVistaPrevia.ItemClick
        Try
            ganttChart.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Stretch
            ganttChart.ShowRibbonPrintPreview()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class