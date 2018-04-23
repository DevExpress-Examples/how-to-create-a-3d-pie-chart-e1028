Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace _DPieChart
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create an empty chart.
			Dim PieChart3D As New ChartControl()

			' Create a pie series.
			Dim series1 As New Series("Pie Series 1", ViewType.Pie3D)

			' Populate the series with points.
			series1.Points.Add(New SeriesPoint("Russia", 17.0752))
			series1.Points.Add(New SeriesPoint("Canada", 9.98467))
			series1.Points.Add(New SeriesPoint("USA", 9.63142))
			series1.Points.Add(New SeriesPoint("China", 9.59696))
			series1.Points.Add(New SeriesPoint("Brazil", 8.511965))
			series1.Points.Add(New SeriesPoint("Australia", 7.68685))
			series1.Points.Add(New SeriesPoint("India", 3.28759))
			series1.Points.Add(New SeriesPoint("Others", 81.2))

			' Add the series to the chart.
			PieChart3D.Series.Add(series1)

			' Adjust the value numeric options of the series.
			series1.Label.TextPattern = "{VP:p0}"

			' Adjust the view-type-specific options of the series.
			CType(series1.View, Pie3DSeriesView).Depth = 30
			CType(series1.View, Pie3DSeriesView).ExplodedPoints.Add(series1.Points(0))
			CType(series1.View, Pie3DSeriesView).ExplodedDistancePercentage = 30

			' Access the diagram's options.
			CType(PieChart3D.Diagram, SimpleDiagram3D).RotationType = RotationType.UseAngles
			CType(PieChart3D.Diagram, SimpleDiagram3D).RotationAngleX = -35

			' Add a title to the chart and hide the legend.
			Dim chartTitle1 As New ChartTitle()
			chartTitle1.Text = "3D Pie Chart"
			PieChart3D.Titles.Add(chartTitle1)
			PieChart3D.Legend.Visible = False

			' Add the chart to the form.
			PieChart3D.Dock = DockStyle.Fill
			Me.Controls.Add(PieChart3D)
		End Sub

	End Class
End Namespace