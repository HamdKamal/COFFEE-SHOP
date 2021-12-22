namespace COFFEE_SHOP
{
    partial class Categures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categures));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.bt_back = new DevExpress.XtraEditors.SimpleButton();
            this.bt_edite = new DevExpress.XtraEditors.SimpleButton();
            this.bt_exit = new DevExpress.XtraEditors.SimpleButton();
            this.bt_del = new DevExpress.XtraEditors.SimpleButton();
            this.bt_save = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.bt_name = new DevExpress.XtraEditors.TextEdit();
            this.CO_ID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.GRID_CATE = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colمعرفالفئة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإسمالفئة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CO_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_CATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(202, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = ":إسم الفئة";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.bt_back);
            this.panelControl3.Controls.Add(this.bt_edite);
            this.panelControl3.Controls.Add(this.bt_exit);
            this.panelControl3.Controls.Add(this.bt_del);
            this.panelControl3.Controls.Add(this.bt_save);
            this.panelControl3.Location = new System.Drawing.Point(9, 59);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(148, 463);
            this.panelControl3.TabIndex = 12;
            // 
            // bt_back
            // 
            this.bt_back.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back.Appearance.Options.UseFont = true;
            this.bt_back.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.bt_back.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_back.ImageOptions.Image")));
            this.bt_back.Location = new System.Drawing.Point(26, 382);
            this.bt_back.Margin = new System.Windows.Forms.Padding(4);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(99, 41);
            this.bt_back.TabIndex = 5;
            this.bt_back.Text = "رجوع";
            this.bt_back.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // bt_edite
            // 
            this.bt_edite.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edite.Appearance.Options.UseFont = true;
            this.bt_edite.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.bt_edite.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_edite.ImageOptions.Image")));
            this.bt_edite.Location = new System.Drawing.Point(26, 139);
            this.bt_edite.Margin = new System.Windows.Forms.Padding(4);
            this.bt_edite.Name = "bt_edite";
            this.bt_edite.Size = new System.Drawing.Size(99, 41);
            this.bt_edite.TabIndex = 4;
            this.bt_edite.Text = "تعديل";
            this.bt_edite.Click += new System.EventHandler(this.bt_edite_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.Appearance.Options.UseFont = true;
            this.bt_exit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.bt_exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_exit.ImageOptions.Image")));
            this.bt_exit.Location = new System.Drawing.Point(26, 303);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(4);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(99, 41);
            this.bt_exit.TabIndex = 3;
            this.bt_exit.Text = "جديد";
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_del
            // 
            this.bt_del.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_del.Appearance.Options.UseFont = true;
            this.bt_del.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.bt_del.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_del.ImageOptions.Image")));
            this.bt_del.Location = new System.Drawing.Point(26, 221);
            this.bt_del.Margin = new System.Windows.Forms.Padding(4);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(99, 41);
            this.bt_del.TabIndex = 1;
            this.bt_del.Text = "حذف";
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
            // 
            // bt_save
            // 
            this.bt_save.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.Appearance.Options.UseFont = true;
            this.bt_save.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.bt_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_save.ImageOptions.Image")));
            this.bt_save.Location = new System.Drawing.Point(26, 57);
            this.bt_save.Margin = new System.Windows.Forms.Padding(4);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(99, 41);
            this.bt_save.TabIndex = 0;
            this.bt_save.Text = "حفظ";
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.bt_name);
            this.panelControl2.Controls.Add(this.CO_ID);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(165, 479);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(501, 45);
            this.panelControl2.TabIndex = 11;
            // 
            // bt_name
            // 
            this.bt_name.Location = new System.Drawing.Point(6, 13);
            this.bt_name.Name = "bt_name";
            this.bt_name.Size = new System.Drawing.Size(193, 20);
            this.bt_name.TabIndex = 7;
            // 
            // CO_ID
            // 
            this.CO_ID.Location = new System.Drawing.Point(288, 12);
            this.CO_ID.Margin = new System.Windows.Forms.Padding(4);
            this.CO_ID.Name = "CO_ID";
            this.CO_ID.Properties.ReadOnly = true;
            this.CO_ID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CO_ID.Size = new System.Drawing.Size(139, 20);
            this.CO_ID.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(428, 11);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 19);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = ":معرف الفئة";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.GRID_CATE);
            this.panelControl1.Location = new System.Drawing.Point(165, 59);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(501, 412);
            this.panelControl1.TabIndex = 10;
            // 
            // GRID_CATE
            // 
            this.GRID_CATE.DataMember = "CATEGEORIES";
            this.GRID_CATE.DataSource = this.sqlDataSource1;
            this.GRID_CATE.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GRID_CATE.Location = new System.Drawing.Point(6, 8);
            this.GRID_CATE.MainView = this.gridView1;
            this.GRID_CATE.Margin = new System.Windows.Forms.Padding(4);
            this.GRID_CATE.Name = "GRID_CATE";
            this.GRID_CATE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GRID_CATE.Size = new System.Drawing.Size(489, 397);
            this.GRID_CATE.TabIndex = 1;
            this.GRID_CATE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GRID_CATE.Click += new System.EventHandler(this.GRID_CATE_Click);
            this.GRID_CATE.DoubleClick += new System.EventHandler(this.GRID_CATE_DoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Coon-1";
            this.sqlDataSource1.Name = "sqlDataSource1";
            column1.Alias = "معرف الفئة";
            columnExpression1.ColumnName = "CAT_ID";
            table1.Name = "CATEGEORIES";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            column2.Alias = "إسم الفئة";
            columnExpression2.ColumnName = "CAT_NAME";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Name = "CATEGEORIES";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colمعرفالفئة,
            this.colإسمالفئة});
            this.gridView1.GridControl = this.GRID_CATE;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colمعرفالفئة
            // 
            this.colمعرفالفئة.FieldName = "معرف الفئة";
            this.colمعرفالفئة.Name = "colمعرفالفئة";
            this.colمعرفالفئة.Visible = true;
            this.colمعرفالفئة.VisibleIndex = 0;
            // 
            // colإسمالفئة
            // 
            this.colإسمالفئة.FieldName = "إسم الفئة";
            this.colإسمالفئة.Name = "colإسمالفئة";
            this.colإسمالفئة.Visible = true;
            this.colإسمالفئة.VisibleIndex = 1;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Location = new System.Drawing.Point(10, 10);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(656, 42);
            this.panelControl4.TabIndex = 13;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(246, 6);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(181, 31);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "قائمة الفئات الرئيسية";
            // 
            // Categures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 531);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categures";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة التصانيف";
            this.Load += new System.EventHandler(this.Categures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CO_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRID_CATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton bt_back;
        private DevExpress.XtraEditors.SimpleButton bt_edite;
        private DevExpress.XtraEditors.SimpleButton bt_exit;
        private DevExpress.XtraEditors.SimpleButton bt_del;
        private DevExpress.XtraEditors.SimpleButton bt_save;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl GRID_CATE;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colمعرفالفئة;
        private DevExpress.XtraGrid.Columns.GridColumn colإسمالفئة;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.TextEdit CO_ID;
        public DevExpress.XtraEditors.TextEdit bt_name;
    }
}