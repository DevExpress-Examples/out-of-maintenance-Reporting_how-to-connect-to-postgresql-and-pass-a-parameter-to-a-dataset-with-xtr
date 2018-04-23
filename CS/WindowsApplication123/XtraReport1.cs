using System;
using System.Text;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
// ...

namespace WindowsApplication123 {
	class XtraReport1 : XtraReport {
		private DevExpress.XtraReports.Parameters.Parameter parameter1;
		private DataSet1 dataSet11;
		private WindowsApplication123.DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
		private XRLabel xrLabel2;
		private XRLabel xrLabel1;

		private DetailBand Detail;

		public XtraReport1() {
			InitializeComponent();
		}

		private void InitializeComponent() {
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.parameter1 = new DevExpress.XtraReports.Parameters.Parameter();
			this.dataSet11 = new WindowsApplication123.DataSet1();
			this.dataTable1TableAdapter = new WindowsApplication123.DataSet1TableAdapters.DataTable1TableAdapter();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrLabel1});
			this.Detail.Height = 42;
			this.Detail.Name = "Detail";
			// 
			// parameter1
			// 
			this.parameter1.Name = "parameter1";
			this.parameter1.ParameterType = DevExpress.XtraReports.Parameters.ParameterType.Int32;
			this.parameter1.Value = 0;
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataTable1TableAdapter
			// 
			this.dataTable1TableAdapter.ClearBeforeFill = true;
			// 
			// xrLabel1
			// 
			this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "DataTable1.id", "")});
			this.xrLabel1.Location = new System.Drawing.Point(50, 8);
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel1.Size = new System.Drawing.Size(100, 25);
			this.xrLabel1.Text = "xrLabel1";
			// 
			// xrLabel2
			// 
			this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "DataTable1.name", "")});
			this.xrLabel2.Location = new System.Drawing.Point(175, 8);
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel2.Size = new System.Drawing.Size(100, 25);
			this.xrLabel2.Text = "xrLabel2";
			// 
			// XtraReport1
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
			this.DataAdapter = this.dataTable1TableAdapter;
			this.DataMember = "DataTable1";
			this.DataSource = this.dataSet11;
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.parameter1});
			this.Version = "9.1";
			this.ParametersRequestSubmit += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.XtraReport1_ParametersRequestSubmit);
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		private void XtraReport1_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e) {
			this.dataTable1TableAdapter.Fill(this.dataSet11.DataTable1, (int)this.parameter1.Value);
		}
	}
}
