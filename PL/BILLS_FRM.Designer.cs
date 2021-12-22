namespace COFFEE_SHOP.FORMS
{
    partial class BILLS_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BILLS_FRM));
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
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.TXT_NOTE = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.combo_EMP = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LBL_EMP = new DevExpress.XtraEditors.LabelControl();
            this.TXT_ID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.DATE_PAY = new DevExpress.XtraEditors.DateEdit();
            this.TXT_MONEY = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.RD_WORKER = new System.Windows.Forms.RadioButton();
            this.combo_place = new System.Windows.Forms.ComboBox();
            this.combo_worker = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.RD_PLACE = new System.Windows.Forms.RadioButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.BT_DEL = new DevExpress.XtraEditors.SimpleButton();
            this.BT_BACK = new DevExpress.XtraEditors.SimpleButton();
            this.BT_EDITE = new DevExpress.XtraEditors.SimpleButton();
            this.BT_EXIT = new DevExpress.XtraEditors.SimpleButton();
            this.BT_SAVE = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl8 = new DevExpress.XtraEditors.PanelControl();
            this.GRID_EMP = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colمعرفالصرف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنوعالصرف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالمبلغ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالتاريخ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colملاحظة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإسمالموظف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl9 = new DevExpress.XtraEditors.PanelControl();
            this.GRID_PLACE = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colمعرفالصرف1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنوعالصرف1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالمبلغ1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالتاريخ1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colملاحظة1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_NOTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATE_PAY.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATE_PAY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_MONEY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).BeginInit();
            this.panelControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_EMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).BeginInit();
            this.panelControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_PLACE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Location = new System.Drawing.Point(8, 7);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1249, 42);
            this.panelControl4.TabIndex = 20;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(516, 5);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(153, 31);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "نافذة المصروفات ";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl6);
            this.panelControl2.Controls.Add(this.panelControl5);
            this.panelControl2.Controls.Add(this.panelControl1);
            this.panelControl2.Location = new System.Drawing.Point(8, 55);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1089, 241);
            this.panelControl2.TabIndex = 21;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.TXT_NOTE);
            this.panelControl6.Controls.Add(this.labelControl9);
            this.panelControl6.Location = new System.Drawing.Point(12, 129);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(513, 102);
            this.panelControl6.TabIndex = 29;
            // 
            // TXT_NOTE
            // 
            this.TXT_NOTE.Location = new System.Drawing.Point(19, 16);
            this.TXT_NOTE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_NOTE.Name = "TXT_NOTE";
            this.TXT_NOTE.Size = new System.Drawing.Size(427, 72);
            this.TXT_NOTE.TabIndex = 19;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(454, 17);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(44, 19);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "ملاحظة:";
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.combo_EMP);
            this.panelControl5.Controls.Add(this.labelControl1);
            this.panelControl5.Controls.Add(this.LBL_EMP);
            this.panelControl5.Controls.Add(this.TXT_ID);
            this.panelControl5.Controls.Add(this.labelControl7);
            this.panelControl5.Controls.Add(this.DATE_PAY);
            this.panelControl5.Controls.Add(this.TXT_MONEY);
            this.panelControl5.Controls.Add(this.labelControl8);
            this.panelControl5.Location = new System.Drawing.Point(531, 129);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(550, 102);
            this.panelControl5.TabIndex = 28;
            // 
            // combo_EMP
            // 
            this.combo_EMP.FormattingEnabled = true;
            this.combo_EMP.Location = new System.Drawing.Point(17, 25);
            this.combo_EMP.Name = "combo_EMP";
            this.combo_EMP.Size = new System.Drawing.Size(183, 21);
            this.combo_EMP.TabIndex = 26;
            this.combo_EMP.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(447, 26);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 19);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "معرف الصرف:";
            // 
            // LBL_EMP
            // 
            this.LBL_EMP.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_EMP.Appearance.Options.UseFont = true;
            this.LBL_EMP.Location = new System.Drawing.Point(205, 26);
            this.LBL_EMP.Margin = new System.Windows.Forms.Padding(4);
            this.LBL_EMP.Name = "LBL_EMP";
            this.LBL_EMP.Size = new System.Drawing.Size(71, 19);
            this.LBL_EMP.TabIndex = 27;
            this.LBL_EMP.Text = "إسم الموظف:";
            this.LBL_EMP.Visible = false;
            // 
            // TXT_ID
            // 
            this.TXT_ID.Location = new System.Drawing.Point(301, 27);
            this.TXT_ID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.Properties.ReadOnly = true;
            this.TXT_ID.Size = new System.Drawing.Size(143, 20);
            this.TXT_ID.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(447, 66);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 19);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "المبلغ:";
            // 
            // DATE_PAY
            // 
            this.DATE_PAY.EditValue = null;
            this.DATE_PAY.Location = new System.Drawing.Point(17, 68);
            this.DATE_PAY.Name = "DATE_PAY";
            this.DATE_PAY.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DATE_PAY.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DATE_PAY.Size = new System.Drawing.Size(183, 20);
            this.DATE_PAY.TabIndex = 21;
            // 
            // TXT_MONEY
            // 
            this.TXT_MONEY.Location = new System.Drawing.Point(301, 67);
            this.TXT_MONEY.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_MONEY.Name = "TXT_MONEY";
            this.TXT_MONEY.Size = new System.Drawing.Size(143, 20);
            this.TXT_MONEY.TabIndex = 13;
            this.TXT_MONEY.EditValueChanged += new System.EventHandler(this.S);
            this.TXT_MONEY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_MONEY_KeyPress);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(205, 68);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(76, 19);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "تاريخ الصرف:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.RD_WORKER);
            this.panelControl1.Controls.Add(this.combo_place);
            this.panelControl1.Controls.Add(this.combo_worker);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.RD_PLACE);
            this.panelControl1.Location = new System.Drawing.Point(12, 6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1069, 102);
            this.panelControl1.TabIndex = 26;
            // 
            // RD_WORKER
            // 
            this.RD_WORKER.AutoSize = true;
            this.RD_WORKER.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RD_WORKER.Location = new System.Drawing.Point(380, 62);
            this.RD_WORKER.Name = "RD_WORKER";
            this.RD_WORKER.Size = new System.Drawing.Size(119, 23);
            this.RD_WORKER.TabIndex = 25;
            this.RD_WORKER.TabStop = true;
            this.RD_WORKER.Text = "مصروفات العمالة";
            this.RD_WORKER.UseVisualStyleBackColor = true;
            this.RD_WORKER.CheckedChanged += new System.EventHandler(this.RD_WORKER_CheckedChanged);
            // 
            // combo_place
            // 
            this.combo_place.FormattingEnabled = true;
            this.combo_place.Location = new System.Drawing.Point(632, 62);
            this.combo_place.Name = "combo_place";
            this.combo_place.Size = new System.Drawing.Size(233, 21);
            this.combo_place.TabIndex = 17;
            this.combo_place.Visible = false;
            this.combo_place.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // combo_worker
            // 
            this.combo_worker.FormattingEnabled = true;
            this.combo_worker.Location = new System.Drawing.Point(141, 62);
            this.combo_worker.Name = "combo_worker";
            this.combo_worker.Size = new System.Drawing.Size(233, 21);
            this.combo_worker.TabIndex = 24;
            this.combo_worker.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(946, 22);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 19);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "نوع الصرف ...";
            // 
            // RD_PLACE
            // 
            this.RD_PLACE.AutoSize = true;
            this.RD_PLACE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RD_PLACE.Location = new System.Drawing.Point(871, 62);
            this.RD_PLACE.Name = "RD_PLACE";
            this.RD_PLACE.Size = new System.Drawing.Size(109, 23);
            this.RD_PLACE.TabIndex = 23;
            this.RD_PLACE.TabStop = true;
            this.RD_PLACE.Text = "مصروفات محل ";
            this.RD_PLACE.UseVisualStyleBackColor = true;
            this.RD_PLACE.CheckedChanged += new System.EventHandler(this.RD_PLACE_CheckedChanged);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.BT_DEL);
            this.panelControl3.Controls.Add(this.BT_BACK);
            this.panelControl3.Controls.Add(this.BT_EDITE);
            this.panelControl3.Controls.Add(this.BT_EXIT);
            this.panelControl3.Controls.Add(this.BT_SAVE);
            this.panelControl3.Location = new System.Drawing.Point(1104, 54);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(153, 242);
            this.panelControl3.TabIndex = 23;
            // 
            // BT_DEL
            // 
            this.BT_DEL.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_DEL.Appearance.Options.UseFont = true;
            this.BT_DEL.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BT_DEL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BT_DEL.ImageOptions.Image")));
            this.BT_DEL.Location = new System.Drawing.Point(22, 99);
            this.BT_DEL.Margin = new System.Windows.Forms.Padding(4);
            this.BT_DEL.Name = "BT_DEL";
            this.BT_DEL.Size = new System.Drawing.Size(111, 41);
            this.BT_DEL.TabIndex = 6;
            this.BT_DEL.Text = "حذف";
            this.BT_DEL.Click += new System.EventHandler(this.BT_DEL_Click);
            // 
            // BT_BACK
            // 
            this.BT_BACK.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_BACK.Appearance.Options.UseFont = true;
            this.BT_BACK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BT_BACK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BT_BACK.ImageOptions.Image")));
            this.BT_BACK.Location = new System.Drawing.Point(22, 191);
            this.BT_BACK.Margin = new System.Windows.Forms.Padding(4);
            this.BT_BACK.Name = "BT_BACK";
            this.BT_BACK.Size = new System.Drawing.Size(111, 41);
            this.BT_BACK.TabIndex = 5;
            this.BT_BACK.Text = "رجوع";
            this.BT_BACK.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // BT_EDITE
            // 
            this.BT_EDITE.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_EDITE.Appearance.Options.UseFont = true;
            this.BT_EDITE.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BT_EDITE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BT_EDITE.ImageOptions.Image")));
            this.BT_EDITE.Location = new System.Drawing.Point(22, 52);
            this.BT_EDITE.Margin = new System.Windows.Forms.Padding(4);
            this.BT_EDITE.Name = "BT_EDITE";
            this.BT_EDITE.Size = new System.Drawing.Size(111, 41);
            this.BT_EDITE.TabIndex = 4;
            this.BT_EDITE.Text = "تعديل";
            this.BT_EDITE.Click += new System.EventHandler(this.BT_EDITE_Click);
            // 
            // BT_EXIT
            // 
            this.BT_EXIT.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_EXIT.Appearance.Options.UseFont = true;
            this.BT_EXIT.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BT_EXIT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BT_EXIT.ImageOptions.Image")));
            this.BT_EXIT.Location = new System.Drawing.Point(22, 144);
            this.BT_EXIT.Margin = new System.Windows.Forms.Padding(4);
            this.BT_EXIT.Name = "BT_EXIT";
            this.BT_EXIT.Size = new System.Drawing.Size(111, 41);
            this.BT_EXIT.TabIndex = 3;
            this.BT_EXIT.Text = "جديد";
            this.BT_EXIT.Click += new System.EventHandler(this.BT_EXIT_Click);
            // 
            // BT_SAVE
            // 
            this.BT_SAVE.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_SAVE.Appearance.Options.UseFont = true;
            this.BT_SAVE.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BT_SAVE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BT_SAVE.ImageOptions.Image")));
            this.BT_SAVE.Location = new System.Drawing.Point(22, 7);
            this.BT_SAVE.Margin = new System.Windows.Forms.Padding(4);
            this.BT_SAVE.Name = "BT_SAVE";
            this.BT_SAVE.Size = new System.Drawing.Size(111, 41);
            this.BT_SAVE.TabIndex = 0;
            this.BT_SAVE.Text = "حفظ";
            this.BT_SAVE.Click += new System.EventHandler(this.BT_SAVE_Click);
            // 
            // panelControl7
            // 
            this.panelControl7.Controls.Add(this.labelControl4);
            this.panelControl7.Controls.Add(this.labelControl5);
            this.panelControl7.Location = new System.Drawing.Point(8, 303);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(1250, 32);
            this.panelControl7.TabIndex = 24;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(265, 4);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 22);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "فواتير العمالة";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(859, 6);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(85, 22);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "فواتير المــحل";
            // 
            // panelControl8
            // 
            this.panelControl8.Controls.Add(this.GRID_EMP);
            this.panelControl8.Location = new System.Drawing.Point(639, 341);
            this.panelControl8.Name = "panelControl8";
            this.panelControl8.Size = new System.Drawing.Size(618, 375);
            this.panelControl8.TabIndex = 25;
            // 
            // GRID_EMP
            // 
            this.GRID_EMP.DataMember = "BILLS";
            this.GRID_EMP.DataSource = this.sqlDataSource1;
            this.GRID_EMP.Location = new System.Drawing.Point(6, 7);
            this.GRID_EMP.MainView = this.gridView1;
            this.GRID_EMP.Name = "GRID_EMP";
            this.GRID_EMP.Size = new System.Drawing.Size(605, 361);
            this.GRID_EMP.TabIndex = 1;
            this.GRID_EMP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GRID_EMP.Click += new System.EventHandler(this.GRID_EMP_Click_1);
            this.GRID_EMP.DoubleClick += new System.EventHandler(this.GRID_EMP_CLICK);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Coon-1";
            this.sqlDataSource1.Name = "sqlDataSource1";
            column1.Alias = "معرف الصرف";
            columnExpression1.ColumnName = "BILL_ID";
            table1.Name = "BILLS";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            column2.Alias = "نوع الصرف";
            columnExpression2.ColumnName = "BILL_TYPE";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            column3.Alias = "المبلغ";
            columnExpression3.ColumnName = "BILL_PRICE";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            column4.Alias = "التاريخ";
            columnExpression4.ColumnName = "BILL_DATE";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            column5.Alias = "ملاحظة";
            columnExpression5.ColumnName = "NOTE";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            column6.Alias = "إسم الموظف";
            columnExpression6.ColumnName = "EMP_NAME";
            table2.Name = "EMPLOYEES";
            columnExpression6.Table = table2;
            column6.Expression = columnExpression6;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Name = "BILLS";
            relationColumnInfo1.NestedKeyColumn = "EMP_ID";
            relationColumnInfo1.ParentKeyColumn = "EMP_ID";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colمعرفالصرف,
            this.colنوعالصرف,
            this.colالمبلغ,
            this.colالتاريخ,
            this.colملاحظة,
            this.colإسمالموظف});
            this.gridView1.GridControl = this.GRID_EMP;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colمعرفالصرف
            // 
            this.colمعرفالصرف.FieldName = "معرف الصرف";
            this.colمعرفالصرف.Name = "colمعرفالصرف";
            this.colمعرفالصرف.Visible = true;
            this.colمعرفالصرف.VisibleIndex = 0;
            // 
            // colنوعالصرف
            // 
            this.colنوعالصرف.FieldName = "نوع الصرف";
            this.colنوعالصرف.Name = "colنوعالصرف";
            this.colنوعالصرف.Visible = true;
            this.colنوعالصرف.VisibleIndex = 1;
            // 
            // colالمبلغ
            // 
            this.colالمبلغ.FieldName = "المبلغ";
            this.colالمبلغ.Name = "colالمبلغ";
            this.colالمبلغ.Visible = true;
            this.colالمبلغ.VisibleIndex = 2;
            // 
            // colالتاريخ
            // 
            this.colالتاريخ.FieldName = "التاريخ";
            this.colالتاريخ.Name = "colالتاريخ";
            this.colالتاريخ.Visible = true;
            this.colالتاريخ.VisibleIndex = 3;
            // 
            // colملاحظة
            // 
            this.colملاحظة.FieldName = "ملاحظة";
            this.colملاحظة.Name = "colملاحظة";
            this.colملاحظة.Visible = true;
            this.colملاحظة.VisibleIndex = 4;
            // 
            // colإسمالموظف
            // 
            this.colإسمالموظف.FieldName = "إسم الموظف";
            this.colإسمالموظف.Name = "colإسمالموظف";
            this.colإسمالموظف.Visible = true;
            this.colإسمالموظف.VisibleIndex = 5;
            // 
            // panelControl9
            // 
            this.panelControl9.Controls.Add(this.GRID_PLACE);
            this.panelControl9.Location = new System.Drawing.Point(8, 341);
            this.panelControl9.Name = "panelControl9";
            this.panelControl9.Size = new System.Drawing.Size(625, 375);
            this.panelControl9.TabIndex = 26;
            // 
            // GRID_PLACE
            // 
            this.GRID_PLACE.DataMember = "BILLS_PLACE";
            this.GRID_PLACE.DataSource = this.sqlDataSource2;
            this.GRID_PLACE.Location = new System.Drawing.Point(8, 7);
            this.GRID_PLACE.MainView = this.gridView2;
            this.GRID_PLACE.Name = "GRID_PLACE";
            this.GRID_PLACE.Size = new System.Drawing.Size(612, 361);
            this.GRID_PLACE.TabIndex = 2;
            this.GRID_PLACE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.GRID_PLACE.Click += new System.EventHandler(this.GRID_PLACE_Click_1);
            this.GRID_PLACE.DoubleClick += new System.EventHandler(this.GRID_PLACE_Click);
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "Coon-1";
            this.sqlDataSource2.Name = "sqlDataSource2";
            column7.Alias = "معرف الصرف";
            columnExpression7.ColumnName = "BILL_ID";
            table3.Name = "BILLS_PLACE";
            columnExpression7.Table = table3;
            column7.Expression = columnExpression7;
            column8.Alias = "نوع الصرف";
            columnExpression8.ColumnName = "BILL_TYPE";
            columnExpression8.Table = table3;
            column8.Expression = columnExpression8;
            column9.Alias = "المبلغ";
            columnExpression9.ColumnName = "BILL_PRICE";
            columnExpression9.Table = table3;
            column9.Expression = columnExpression9;
            column10.Alias = "التاريخ";
            columnExpression10.ColumnName = "BILL_DATE";
            columnExpression10.Table = table3;
            column10.Expression = columnExpression10;
            column11.Alias = "ملاحظة";
            columnExpression11.ColumnName = "NOTE";
            columnExpression11.Table = table3;
            column11.Expression = columnExpression11;
            selectQuery2.Columns.Add(column7);
            selectQuery2.Columns.Add(column8);
            selectQuery2.Columns.Add(column9);
            selectQuery2.Columns.Add(column10);
            selectQuery2.Columns.Add(column11);
            selectQuery2.Name = "BILLS_PLACE";
            selectQuery2.Tables.Add(table3);
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colمعرفالصرف1,
            this.colنوعالصرف1,
            this.colالمبلغ1,
            this.colالتاريخ1,
            this.colملاحظة1});
            this.gridView2.GridControl = this.GRID_PLACE;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedRow = false;
            // 
            // colمعرفالصرف1
            // 
            this.colمعرفالصرف1.FieldName = "معرف الصرف";
            this.colمعرفالصرف1.Name = "colمعرفالصرف1";
            this.colمعرفالصرف1.Visible = true;
            this.colمعرفالصرف1.VisibleIndex = 0;
            // 
            // colنوعالصرف1
            // 
            this.colنوعالصرف1.FieldName = "نوع الصرف";
            this.colنوعالصرف1.Name = "colنوعالصرف1";
            this.colنوعالصرف1.Visible = true;
            this.colنوعالصرف1.VisibleIndex = 1;
            // 
            // colالمبلغ1
            // 
            this.colالمبلغ1.FieldName = "المبلغ";
            this.colالمبلغ1.Name = "colالمبلغ1";
            this.colالمبلغ1.Visible = true;
            this.colالمبلغ1.VisibleIndex = 2;
            // 
            // colالتاريخ1
            // 
            this.colالتاريخ1.FieldName = "التاريخ";
            this.colالتاريخ1.Name = "colالتاريخ1";
            this.colالتاريخ1.Visible = true;
            this.colالتاريخ1.VisibleIndex = 3;
            // 
            // colملاحظة1
            // 
            this.colملاحظة1.FieldName = "ملاحظة";
            this.colملاحظة1.Name = "colملاحظة1";
            this.colملاحظة1.Visible = true;
            this.colملاحظة1.VisibleIndex = 4;
            // 
            // BILLS_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 719);
            this.Controls.Add(this.panelControl9);
            this.Controls.Add(this.panelControl8);
            this.Controls.Add(this.panelControl7);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BILLS_FRM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BILLS_FRM";
            this.Load += new System.EventHandler(this.BILLS_FRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.panelControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_NOTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATE_PAY.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATE_PAY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_MONEY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            this.panelControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).EndInit();
            this.panelControl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRID_EMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).EndInit();
            this.panelControl9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRID_PLACE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton BT_DEL;
        private DevExpress.XtraEditors.SimpleButton BT_BACK;
        private DevExpress.XtraEditors.SimpleButton BT_EDITE;
        private DevExpress.XtraEditors.SimpleButton BT_EXIT;
        private DevExpress.XtraEditors.SimpleButton BT_SAVE;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public System.Windows.Forms.RadioButton RD_WORKER;
        public System.Windows.Forms.RadioButton RD_PLACE;
        public DevExpress.XtraEditors.DateEdit DATE_PAY;
        public DevExpress.XtraEditors.MemoEdit TXT_NOTE;
        public System.Windows.Forms.ComboBox combo_place;
        public DevExpress.XtraEditors.TextEdit TXT_MONEY;
        public DevExpress.XtraEditors.TextEdit TXT_ID;
        public System.Windows.Forms.ComboBox combo_worker;
        public System.Windows.Forms.ComboBox combo_EMP;
        public DevExpress.XtraEditors.LabelControl LBL_EMP;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl8;
        private DevExpress.XtraEditors.PanelControl panelControl9;
        private DevExpress.XtraGrid.GridControl GRID_EMP;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colمعرفالصرف;
        private DevExpress.XtraGrid.Columns.GridColumn colنوعالصرف;
        private DevExpress.XtraGrid.Columns.GridColumn colالمبلغ;
        private DevExpress.XtraGrid.Columns.GridColumn colالتاريخ;
        private DevExpress.XtraGrid.Columns.GridColumn colملاحظة;
        private DevExpress.XtraGrid.Columns.GridColumn colإسمالموظف;
        private DevExpress.XtraGrid.GridControl GRID_PLACE;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colمعرفالصرف1;
        private DevExpress.XtraGrid.Columns.GridColumn colنوعالصرف1;
        private DevExpress.XtraGrid.Columns.GridColumn colالمبلغ1;
        private DevExpress.XtraGrid.Columns.GridColumn colالتاريخ1;
        private DevExpress.XtraGrid.Columns.GridColumn colملاحظة1;
    }
}