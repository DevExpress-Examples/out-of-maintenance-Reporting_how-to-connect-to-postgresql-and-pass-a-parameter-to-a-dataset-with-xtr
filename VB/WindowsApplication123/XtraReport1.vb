Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.Collections.Generic
Imports DevExpress.XtraReports.UI
' ...

Namespace WindowsApplication123
	Friend Class XtraReport1
		Inherits XtraReport
		Private parameter1 As DevExpress.XtraReports.Parameters.Parameter
		Private dataSet11 As DataSet1
		Private dataTable1TableAdapter As WindowsApplication123.DataSet1TableAdapters.DataTable1TableAdapter
		Private xrLabel2 As XRLabel
		Private xrLabel1 As XRLabel

		Private Detail As DetailBand

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.parameter1 = New DevExpress.XtraReports.Parameters.Parameter()
			Me.dataSet11 = New WindowsApplication123.DataSet1()
			Me.dataTable1TableAdapter = New WindowsApplication123.DataSet1TableAdapters.DataTable1TableAdapter()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel1})
			Me.Detail.Height = 42
			Me.Detail.Name = "Detail"
			' 
			' parameter1
			' 
			Me.parameter1.Name = "parameter1"
			Me.parameter1.ParameterType = DevExpress.XtraReports.Parameters.ParameterType.Int32
			Me.parameter1.Value = 0
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' dataTable1TableAdapter
			' 
			Me.dataTable1TableAdapter.ClearBeforeFill = True
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataTable1.id", "")})
			Me.xrLabel1.Location = New System.Drawing.Point(50, 8)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel1.Size = New System.Drawing.Size(100, 25)
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataTable1.name", "")})
			Me.xrLabel2.Location = New System.Drawing.Point(175, 8)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel2.Size = New System.Drawing.Size(100, 25)
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail})
			Me.DataAdapter = Me.dataTable1TableAdapter
			Me.DataMember = "DataTable1"
			Me.DataSource = Me.dataSet11
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.parameter1})
			Me.Version = "9.1"
'			Me.ParametersRequestSubmit += New System.EventHandler(Of DevExpress.XtraReports.Parameters.ParametersRequestEventArgs)(Me.XtraReport1_ParametersRequestSubmit);
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		Private Sub XtraReport1_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles MyBase.ParametersRequestSubmit
			Me.dataTable1TableAdapter.Fill(Me.dataSet11.DataTable1, CInt(Fix(Me.parameter1.Value)))
		End Sub
	End Class
End Namespace
