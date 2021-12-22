namespace COFFEE_SHOP.REP
{
    partial class XtraReport2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Group group1 = new DevExpress.DataAccess.Sql.Group();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReport2));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrChart1 = new DevExpress.XtraReports.UI.XRChart();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.XrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.XrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.XrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.BDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.XrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.FDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.XrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrChart1});
            this.Detail.HeightF = 359.375F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrChart1
            // 
            this.xrChart1.BorderColor = System.Drawing.Color.Black;
            this.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart1.Diagram = xyDiagram1;
            this.xrChart1.Legend.Name = "Default Legend";
            this.xrChart1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrChart1.Name = "xrChart1";
            series1.ArgumentDataMember = "ORDERS_DETAILS.ORD_NAME";
            series1.Name = "الطلبات";
            series1.ValueDataMembersSerializable = "ORDERS_DETAILS.Sum_QUN";
            this.xrChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.xrChart1.SizeF = new System.Drawing.SizeF(969F, 357.2917F);
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_Coffee_Shop_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "ORD_NAME";
            table1.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"285\" />";
            table1.Name = "ORDERS";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            column2.Alias = "Sum_QUN";
            columnExpression2.Aggregate = DevExpress.DataAccess.Sql.AggregationType.Sum;
            columnExpression2.ColumnName = "QUN";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"145\" />";
            table2.Name = "ORDERS_DETAILS";
            columnExpression2.Table = table2;
            column2.Expression = columnExpression2;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.FilterString = "[RECIPT.RPS_TIME] Between(?BDate, ?FDate)";
            selectQuery1.GroupFilterString = "";
            columnExpression3.ColumnName = "ORD_NAME";
            columnExpression3.Table = table1;
            group1.Expression = columnExpression3;
            selectQuery1.Groups.Add(group1);
            selectQuery1.Name = "ORDERS_DETAILS";
            queryParameter1.Name = "BDate";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.BDate]", typeof(System.DateTime));
            queryParameter2.Name = "FDate";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.FDate]", typeof(System.DateTime));
            selectQuery1.Parameters.Add(queryParameter1);
            selectQuery1.Parameters.Add(queryParameter2);
            relationColumnInfo1.NestedKeyColumn = "RPS_ID";
            relationColumnInfo1.ParentKeyColumn = "RPS_ID";
            join1.KeyColumns.Add(relationColumnInfo1);
            table3.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"165\" />";
            table3.Name = "RECIPT";
            join1.Nested = table3;
            join1.Parent = table2;
            relationColumnInfo2.NestedKeyColumn = "ORD_ID";
            relationColumnInfo2.ParentKeyColumn = "ORD_ID";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table1;
            join2.Parent = table2;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Relations.Add(join2);
            selectQuery1.Tables.Add(table2);
            selectQuery1.Tables.Add(table3);
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.XrLabel13,
            this.XrPictureBox2,
            this.XrLabel23,
            this.XrLabel24,
            this.XrLabel25,
            this.XrLabel26,
            this.XrLabel27,
            this.xrLabel8});
            this.reportHeaderBand1.HeightF = 183.3125F;
            this.reportHeaderBand1.Name = "reportHeaderBand1";
            // 
            // XrLabel13
            // 
            this.XrLabel13.Font = new System.Drawing.Font("Simplified Arabic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XrLabel13.ForeColor = System.Drawing.Color.Black;
            this.XrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(395.0833F, 77.6042F);
            this.XrLabel13.Name = "XrLabel13";
            this.XrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel13.SizeF = new System.Drawing.SizeF(171.5666F, 42.99998F);
            this.XrLabel13.StyleName = "Title";
            this.XrLabel13.StylePriority.UseFont = false;
            this.XrLabel13.StylePriority.UseForeColor = false;
            this.XrLabel13.StylePriority.UseTextAlignment = false;
            this.XrLabel13.Text = "معدل المبيعات";
            this.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // XrPictureBox2
            // 
            this.XrPictureBox2.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox2.ImageSource"));
            this.XrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.XrPictureBox2.Name = "XrPictureBox2";
            this.XrPictureBox2.SizeF = new System.Drawing.SizeF(117.4001F, 110.375F);
            this.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // XrLabel23
            // 
            this.XrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(627.5833F, 139.6875F);
            this.XrLabel23.Name = "XrLabel23";
            this.XrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel23.SizeF = new System.Drawing.SizeF(17.25F, 42.99996F);
            this.XrLabel23.StyleName = "Title";
            this.XrLabel23.StylePriority.UseTextAlignment = false;
            this.XrLabel23.Text = ")";
            this.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // XrLabel24
            // 
            this.XrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(321.5832F, 139.6875F);
            this.XrLabel24.Name = "XrLabel24";
            this.XrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel24.SizeF = new System.Drawing.SizeF(17.25F, 42.99996F);
            this.XrLabel24.StyleName = "Title";
            this.XrLabel24.StylePriority.UseTextAlignment = false;
            this.XrLabel24.Text = "(";
            this.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // XrLabel25
            // 
            this.XrLabel25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?BDate")});
            this.XrLabel25.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(490.333F, 139.6875F);
            this.XrLabel25.Name = "XrLabel25";
            this.XrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel25.SizeF = new System.Drawing.SizeF(137.2502F, 42.99996F);
            this.XrLabel25.StyleName = "Title";
            this.XrLabel25.StylePriority.UseFont = false;
            this.XrLabel25.StylePriority.UseTextAlignment = false;
            this.XrLabel25.Text = "XrLabel25";
            this.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.XrLabel25.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // BDate
            // 
            this.BDate.Description = "بداية الفترة :";
            this.BDate.Name = "BDate";
            this.BDate.Type = typeof(System.DateTime);
            // 
            // XrLabel26
            // 
            this.XrLabel26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?FDate")});
            this.XrLabel26.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(338.8333F, 139.6875F);
            this.XrLabel26.Name = "XrLabel26";
            this.XrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel26.SizeF = new System.Drawing.SizeF(132F, 42.99996F);
            this.XrLabel26.StyleName = "Title";
            this.XrLabel26.StylePriority.UseFont = false;
            this.XrLabel26.StylePriority.UseTextAlignment = false;
            this.XrLabel26.Text = "XrLabel25";
            this.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.XrLabel26.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // FDate
            // 
            this.FDate.Description = "نهاية الفترة :";
            this.FDate.Name = "FDate";
            this.FDate.Type = typeof(System.DateTime);
            // 
            // XrLabel27
            // 
            this.XrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(470.8333F, 139.6875F);
            this.XrLabel27.Name = "XrLabel27";
            this.XrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel27.SizeF = new System.Drawing.SizeF(17.25F, 42.99996F);
            this.XrLabel27.StyleName = "Title";
            this.XrLabel27.StylePriority.UseTextAlignment = false;
            this.XrLabel27.Text = "/";
            this.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Simplified Arabic", 22F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.ForeColor = System.Drawing.Color.Black;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(352.7594F, 31.4792F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(242.7287F, 46.125F);
            this.xrLabel8.StyleName = "Title";
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "ديوانية السيف";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.Weight = 1D;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Title.Name = "Title";
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new System.Drawing.Font("Tahoma", 8F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // XtraReport2
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.reportHeaderBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataSource = this.sqlDataSource1;
            this.Landscape = true;
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.BDate,
            this.FDate});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "20.2";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRChart xrChart1;
        private DevExpress.XtraReports.Parameters.Parameter BDate;
        private DevExpress.XtraReports.Parameters.Parameter FDate;
        private DevExpress.XtraReports.UI.XRLabel XrLabel13;
        private DevExpress.XtraReports.UI.XRPictureBox XrPictureBox2;
        private DevExpress.XtraReports.UI.XRLabel XrLabel23;
        private DevExpress.XtraReports.UI.XRLabel XrLabel24;
        private DevExpress.XtraReports.UI.XRLabel XrLabel25;
        private DevExpress.XtraReports.UI.XRLabel XrLabel26;
        private DevExpress.XtraReports.UI.XRLabel XrLabel27;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
    }
}
