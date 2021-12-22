namespace COFFEE_SHOP.FORMS
{
    partial class ADD_USER
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
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADD_USER));
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.combo_TYPE = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_REPASS = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_PASS = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_FULLNAME = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_NAME = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_ID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.GRID_USER = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colمعرفالمستخدم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colاسمالمستخدم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنوعالمستخدم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالإسمالكامل = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colكلمةالمرور = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.BT_EDITE = new DevExpress.XtraEditors.SimpleButton();
            this.BT_EMPTY = new DevExpress.XtraEditors.SimpleButton();
            this.BT_DEL = new DevExpress.XtraEditors.SimpleButton();
            this.BT_SAVE = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_REPASS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_PASS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_FULLNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_NAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_USER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Location = new System.Drawing.Point(7, 7);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(700, 38);
            this.panelControl4.TabIndex = 18;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(250, 5);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(207, 31);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "نافذة إضافة المستخدمين";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.combo_TYPE);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.TXT_REPASS);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.TXT_PASS);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.TXT_FULLNAME);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.TXT_NAME);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.TXT_ID);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(7, 48);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(700, 157);
            this.panelControl2.TabIndex = 19;
            // 
            // combo_TYPE
            // 
            this.combo_TYPE.FormattingEnabled = true;
            this.combo_TYPE.Items.AddRange(new object[] {
            "ADMIN",
            "USER"});
            this.combo_TYPE.Location = new System.Drawing.Point(360, 128);
            this.combo_TYPE.Name = "combo_TYPE";
            this.combo_TYPE.Size = new System.Drawing.Size(232, 21);
            this.combo_TYPE.TabIndex = 17;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(595, 128);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 19);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "نوع المستخدم:";
            // 
            // TXT_REPASS
            // 
            this.TXT_REPASS.Location = new System.Drawing.Point(15, 94);
            this.TXT_REPASS.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_REPASS.Name = "TXT_REPASS";
            this.TXT_REPASS.Size = new System.Drawing.Size(232, 20);
            this.TXT_REPASS.TabIndex = 15;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(250, 93);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(96, 19);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "تأكيد كلمة المرور:";
            // 
            // TXT_PASS
            // 
            this.TXT_PASS.Location = new System.Drawing.Point(360, 91);
            this.TXT_PASS.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_PASS.Name = "TXT_PASS";
            this.TXT_PASS.Size = new System.Drawing.Size(232, 20);
            this.TXT_PASS.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(594, 90);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(69, 19);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "كلمة المرور:";
            // 
            // TXT_FULLNAME
            // 
            this.TXT_FULLNAME.Location = new System.Drawing.Point(15, 55);
            this.TXT_FULLNAME.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_FULLNAME.Name = "TXT_FULLNAME";
            this.TXT_FULLNAME.Size = new System.Drawing.Size(232, 20);
            this.TXT_FULLNAME.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(249, 54);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 19);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "الإسم الكامل:";
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Location = new System.Drawing.Point(360, 54);
            this.TXT_NAME.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.Size = new System.Drawing.Size(232, 20);
            this.TXT_NAME.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(594, 53);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 19);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "إسم المستخدم:";
            // 
            // TXT_ID
            // 
            this.TXT_ID.Location = new System.Drawing.Point(459, 16);
            this.TXT_ID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.Properties.ReadOnly = true;
            this.TXT_ID.Size = new System.Drawing.Size(133, 20);
            this.TXT_ID.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(594, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 19);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "معرف المستخدم:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.GRID_USER);
            this.panelControl1.Location = new System.Drawing.Point(7, 206);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(553, 408);
            this.panelControl1.TabIndex = 20;
            // 
            // GRID_USER
            // 
            this.GRID_USER.DataMember = "USERS";
            this.GRID_USER.DataSource = this.sqlDataSource1;
            this.GRID_USER.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GRID_USER.Location = new System.Drawing.Point(6, 8);
            this.GRID_USER.MainView = this.gridView1;
            this.GRID_USER.Margin = new System.Windows.Forms.Padding(4);
            this.GRID_USER.Name = "GRID_USER";
            this.GRID_USER.Size = new System.Drawing.Size(541, 391);
            this.GRID_USER.TabIndex = 0;
            this.GRID_USER.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GRID_USER.Click += new System.EventHandler(this.GRID_USER_Click);
            this.GRID_USER.DoubleClick += new System.EventHandler(this.GRID_USER_DoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Coon-1";
            this.sqlDataSource1.Name = "sqlDataSource1";
            column1.Alias = "معرف المستخدم";
            columnExpression1.ColumnName = "USER_ID";
            table1.Name = "USERS";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            column2.Alias = "إسم المستخدم";
            columnExpression2.ColumnName = "USER_NAME";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            column3.Alias = "نوع المستخدم";
            columnExpression3.ColumnName = "USER_TYPE";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            column4.Alias = "الإسم الكامل";
            columnExpression4.ColumnName = "USER_FULLNAME";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            column5.Alias = "كلمة المرور";
            columnExpression5.ColumnName = "USER_PASS";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Name = "USERS";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.gridView1.Appearance.Empty.Options.UseFont = true;
            this.gridView1.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FixedLine.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colمعرفالمستخدم,
            this.colاسمالمستخدم,
            this.colنوعالمستخدم,
            this.colالإسمالكامل,
            this.colكلمةالمرور});
            this.gridView1.GridControl = this.GRID_USER;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colمعرفالمستخدم
            // 
            this.colمعرفالمستخدم.FieldName = "معرف المستخدم";
            this.colمعرفالمستخدم.Name = "colمعرفالمستخدم";
            this.colمعرفالمستخدم.OptionsColumn.AllowEdit = false;
            this.colمعرفالمستخدم.OptionsColumn.AllowMove = false;
            this.colمعرفالمستخدم.OptionsColumn.FixedWidth = true;
            this.colمعرفالمستخدم.OptionsColumn.ReadOnly = true;
            this.colمعرفالمستخدم.Visible = true;
            this.colمعرفالمستخدم.VisibleIndex = 0;
            // 
            // colاسمالمستخدم
            // 
            this.colاسمالمستخدم.FieldName = "إسم المستخدم";
            this.colاسمالمستخدم.Name = "colاسمالمستخدم";
            this.colاسمالمستخدم.Visible = true;
            this.colاسمالمستخدم.VisibleIndex = 1;
            // 
            // colنوعالمستخدم
            // 
            this.colنوعالمستخدم.FieldName = "نوع المستخدم";
            this.colنوعالمستخدم.Name = "colنوعالمستخدم";
            this.colنوعالمستخدم.Visible = true;
            this.colنوعالمستخدم.VisibleIndex = 2;
            // 
            // colالإسمالكامل
            // 
            this.colالإسمالكامل.FieldName = "الإسم الكامل";
            this.colالإسمالكامل.Name = "colالإسمالكامل";
            this.colالإسمالكامل.Visible = true;
            this.colالإسمالكامل.VisibleIndex = 3;
            // 
            // colكلمةالمرور
            // 
            this.colكلمةالمرور.FieldName = "كلمة المرور";
            this.colكلمةالمرور.Name = "colكلمةالمرور";
            this.colكلمةالمرور.Visible = true;
            this.colكلمةالمرور.VisibleIndex = 4;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.simpleButton3);
            this.panelControl3.Controls.Add(this.BT_EDITE);
            this.panelControl3.Controls.Add(this.BT_EMPTY);
            this.panelControl3.Controls.Add(this.BT_DEL);
            this.panelControl3.Controls.Add(this.BT_SAVE);
            this.panelControl3.Location = new System.Drawing.Point(568, 206);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(138, 408);
            this.panelControl3.TabIndex = 21;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(14, 331);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(111, 41);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "رجوع";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // BT_EDITE
            // 
            this.BT_EDITE.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_EDITE.Appearance.Options.UseFont = true;
            this.BT_EDITE.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BT_EDITE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BT_EDITE.ImageOptions.Image")));
            this.BT_EDITE.Location = new System.Drawing.Point(14, 115);
            this.BT_EDITE.Margin = new System.Windows.Forms.Padding(4);
            this.BT_EDITE.Name = "BT_EDITE";
            this.BT_EDITE.Size = new System.Drawing.Size(111, 41);
            this.BT_EDITE.TabIndex = 4;
            this.BT_EDITE.Text = "تعديل";
            this.BT_EDITE.Click += new System.EventHandler(this.BT_EDITE_Click);
            // 
            // BT_EMPTY
            // 
            this.BT_EMPTY.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_EMPTY.Appearance.Options.UseFont = true;
            this.BT_EMPTY.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BT_EMPTY.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BT_EMPTY.ImageOptions.Image")));
            this.BT_EMPTY.Location = new System.Drawing.Point(14, 261);
            this.BT_EMPTY.Margin = new System.Windows.Forms.Padding(4);
            this.BT_EMPTY.Name = "BT_EMPTY";
            this.BT_EMPTY.Size = new System.Drawing.Size(111, 41);
            this.BT_EMPTY.TabIndex = 3;
            this.BT_EMPTY.Text = "جديد";
            this.BT_EMPTY.Click += new System.EventHandler(this.BT_EMPTY_Click);
            // 
            // BT_DEL
            // 
            this.BT_DEL.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_DEL.Appearance.Options.UseFont = true;
            this.BT_DEL.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BT_DEL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BT_DEL.ImageOptions.Image")));
            this.BT_DEL.Location = new System.Drawing.Point(14, 187);
            this.BT_DEL.Margin = new System.Windows.Forms.Padding(4);
            this.BT_DEL.Name = "BT_DEL";
            this.BT_DEL.Size = new System.Drawing.Size(111, 41);
            this.BT_DEL.TabIndex = 1;
            this.BT_DEL.Text = "حذف";
            this.BT_DEL.Click += new System.EventHandler(this.BT_DEL_Click);
            // 
            // BT_SAVE
            // 
            this.BT_SAVE.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_SAVE.Appearance.Options.UseFont = true;
            this.BT_SAVE.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BT_SAVE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BT_SAVE.ImageOptions.Image")));
            this.BT_SAVE.Location = new System.Drawing.Point(14, 42);
            this.BT_SAVE.Margin = new System.Windows.Forms.Padding(4);
            this.BT_SAVE.Name = "BT_SAVE";
            this.BT_SAVE.Size = new System.Drawing.Size(111, 41);
            this.BT_SAVE.TabIndex = 0;
            this.BT_SAVE.Text = "حفظ";
            this.BT_SAVE.Click += new System.EventHandler(this.BT_SAVE_Click);
            // 
            // ADD_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 622);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADD_USER";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD_USER";
            this.Load += new System.EventHandler(this.ADD_USER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_REPASS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_PASS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_FULLNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_NAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRID_USER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.ComboBox combo_TYPE;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TXT_REPASS;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TXT_PASS;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TXT_FULLNAME;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TXT_NAME;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TXT_ID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl GRID_USER;
        public DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton BT_EDITE;
        private DevExpress.XtraEditors.SimpleButton BT_EMPTY;
        private DevExpress.XtraEditors.SimpleButton BT_DEL;
        private DevExpress.XtraEditors.SimpleButton BT_SAVE;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colاسمالمستخدم;
        private DevExpress.XtraGrid.Columns.GridColumn colنوعالمستخدم;
        private DevExpress.XtraGrid.Columns.GridColumn colالإسمالكامل;
        private DevExpress.XtraGrid.Columns.GridColumn colكلمةالمرور;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.Columns.GridColumn colمعرفالمستخدم;
    }
}