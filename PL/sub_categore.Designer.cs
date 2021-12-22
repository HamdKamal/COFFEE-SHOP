namespace COFFEE_SHOP
{
    partial class sub_categore
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sub_categore));
            this.GRID_SUB = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colالصنف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالفئة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالفئة1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.BT_EDITE = new DevExpress.XtraEditors.SimpleButton();
            this.BT_EXIT = new DevExpress.XtraEditors.SimpleButton();
            this.BT_BACK = new DevExpress.XtraEditors.SimpleButton();
            this.BT_SAVE = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.CO_ID = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_ID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_S_CAT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_SUB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_S_CAT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRID_SUB
            // 
            this.GRID_SUB.DataMember = "SUP_CATE";
            this.GRID_SUB.DataSource = this.sqlDataSource1;
            this.GRID_SUB.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GRID_SUB.Location = new System.Drawing.Point(5, 6);
            this.GRID_SUB.MainView = this.gridView1;
            this.GRID_SUB.Margin = new System.Windows.Forms.Padding(4);
            this.GRID_SUB.Name = "GRID_SUB";
            this.GRID_SUB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GRID_SUB.Size = new System.Drawing.Size(489, 368);
            this.GRID_SUB.TabIndex = 0;
            this.GRID_SUB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GRID_SUB.Click += new System.EventHandler(this.GRID_SUB_Click);
            this.GRID_SUB.DoubleClick += new System.EventHandler(this.GRID_SUB_DoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Coon-1";
            this.sqlDataSource1.Name = "sqlDataSource1";
            column1.Alias = "معرف الصرف";
            columnExpression1.ColumnName = "SUP_ID";
            table1.Name = "SUP_CATE";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            column2.Alias = "إسم الصرف";
            columnExpression2.ColumnName = "SUP_NAME";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            column3.Alias = "الفئة";
            columnExpression3.ColumnName = "CAT_ID";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Name = "SUP_CATE";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colالصنف,
            this.colالفئة,
            this.colالفئة1});
            this.gridView1.GridControl = this.GRID_SUB;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colالصنف
            // 
            this.colالصنف.FieldName = "معرف الصرف";
            this.colالصنف.Name = "colالصنف";
            this.colالصنف.Visible = true;
            this.colالصنف.VisibleIndex = 0;
            // 
            // colالفئة
            // 
            this.colالفئة.FieldName = "إسم الصرف";
            this.colالفئة.Name = "colالفئة";
            this.colالفئة.Visible = true;
            this.colالفئة.VisibleIndex = 1;
            // 
            // colالفئة1
            // 
            this.colالفئة1.FieldName = "الفئة";
            this.colالفئة1.Name = "colالفئة1";
            this.colالفئة1.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.BT_EDITE);
            this.panelControl3.Controls.Add(this.BT_EXIT);
            this.panelControl3.Controls.Add(this.BT_BACK);
            this.panelControl3.Controls.Add(this.BT_SAVE);
            this.panelControl3.Location = new System.Drawing.Point(10, 61);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(142, 380);
            this.panelControl3.TabIndex = 8;
            this.panelControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl3_Paint);
            // 
            // BT_EDITE
            // 
            this.BT_EDITE.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_EDITE.Appearance.Options.UseFont = true;
            this.BT_EDITE.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BT_EDITE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BT_EDITE.ImageOptions.Image")));
            this.BT_EDITE.Location = new System.Drawing.Point(16, 129);
            this.BT_EDITE.Margin = new System.Windows.Forms.Padding(4);
            this.BT_EDITE.Name = "BT_EDITE";
            this.BT_EDITE.Size = new System.Drawing.Size(110, 41);
            this.BT_EDITE.TabIndex = 4;
            this.BT_EDITE.Text = "تعديل";
            this.BT_EDITE.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // BT_EXIT
            // 
            this.BT_EXIT.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_EXIT.Appearance.Options.UseFont = true;
            this.BT_EXIT.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BT_EXIT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BT_EXIT.ImageOptions.Image")));
            this.BT_EXIT.Location = new System.Drawing.Point(16, 210);
            this.BT_EXIT.Margin = new System.Windows.Forms.Padding(4);
            this.BT_EXIT.Name = "BT_EXIT";
            this.BT_EXIT.Size = new System.Drawing.Size(110, 41);
            this.BT_EXIT.TabIndex = 3;
            this.BT_EXIT.Text = "جديد";
            this.BT_EXIT.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // BT_BACK
            // 
            this.BT_BACK.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_BACK.Appearance.Options.UseFont = true;
            this.BT_BACK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BT_BACK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BT_BACK.ImageOptions.Image")));
            this.BT_BACK.Location = new System.Drawing.Point(16, 292);
            this.BT_BACK.Margin = new System.Windows.Forms.Padding(4);
            this.BT_BACK.Name = "BT_BACK";
            this.BT_BACK.Size = new System.Drawing.Size(110, 41);
            this.BT_BACK.TabIndex = 1;
            this.BT_BACK.Text = "رجوع";
            this.BT_BACK.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // BT_SAVE
            // 
            this.BT_SAVE.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_SAVE.Appearance.Options.UseFont = true;
            this.BT_SAVE.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BT_SAVE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BT_SAVE.ImageOptions.Image")));
            this.BT_SAVE.Location = new System.Drawing.Point(16, 47);
            this.BT_SAVE.Margin = new System.Windows.Forms.Padding(4);
            this.BT_SAVE.Name = "BT_SAVE";
            this.BT_SAVE.Size = new System.Drawing.Size(110, 41);
            this.BT_SAVE.TabIndex = 0;
            this.BT_SAVE.Text = "حفظ";
            this.BT_SAVE.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.CO_ID);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.TXT_ID);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.TXT_S_CAT);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(10, 449);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(652, 81);
            this.panelControl2.TabIndex = 7;
            // 
            // CO_ID
            // 
            this.CO_ID.FormattingEnabled = true;
            this.CO_ID.Items.AddRange(new object[] {
            "مصروفات محل",
            "مصروفات عمالة"});
            this.CO_ID.Location = new System.Drawing.Point(17, 16);
            this.CO_ID.Name = "CO_ID";
            this.CO_ID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CO_ID.Size = new System.Drawing.Size(245, 27);
            this.CO_ID.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(550, 13);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(84, 19);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = ": معرف الصرف";
            // 
            // TXT_ID
            // 
            this.TXT_ID.Location = new System.Drawing.Point(425, 14);
            this.TXT_ID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.Properties.ReadOnly = true;
            this.TXT_ID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_ID.Size = new System.Drawing.Size(121, 20);
            this.TXT_ID.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(549, 54);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = ": إسم الصرف";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // TXT_S_CAT
            // 
            this.TXT_S_CAT.Location = new System.Drawing.Point(365, 55);
            this.TXT_S_CAT.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_S_CAT.Name = "TXT_S_CAT";
            this.TXT_S_CAT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_S_CAT.Size = new System.Drawing.Size(181, 20);
            this.TXT_S_CAT.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(264, 17);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = ": نوع الصرف";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.GRID_SUB);
            this.panelControl1.Location = new System.Drawing.Point(161, 61);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(501, 380);
            this.panelControl1.TabIndex = 6;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Location = new System.Drawing.Point(11, 12);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(651, 42);
            this.panelControl4.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(263, 6);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(146, 31);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "نافذة المصروفات";
            // 
            // sub_categore
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(673, 543);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sub_categore";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة قائمة الطعام";
            this.Load += new System.EventHandler(this.sub_categore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRID_SUB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_S_CAT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GRID_SUB;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton BT_EDITE;
        private DevExpress.XtraEditors.SimpleButton BT_EXIT;
        private DevExpress.XtraEditors.SimpleButton BT_BACK;
        private DevExpress.XtraEditors.SimpleButton BT_SAVE;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TXT_S_CAT;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TXT_ID;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.ComboBox CO_ID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colالصنف;
        private DevExpress.XtraGrid.Columns.GridColumn colالفئة;
        private DevExpress.XtraGrid.Columns.GridColumn colالفئة1;
    }
}