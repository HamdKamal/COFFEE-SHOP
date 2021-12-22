namespace COFFEE_SHOP.FORMS
{
    partial class EMPLOYEE_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMPLOYEE_FRM));
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
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.BT_DEL = new DevExpress.XtraEditors.SimpleButton();
            this.BT_BACK = new DevExpress.XtraEditors.SimpleButton();
            this.BT_EDIT = new DevExpress.XtraEditors.SimpleButton();
            this.BT_EXIT = new DevExpress.XtraEditors.SimpleButton();
            this.BT_SAVE = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.TXT_SALARY = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.PIC_EMP = new DevExpress.XtraEditors.PictureEdit();
            this.DATE_EMP = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_NOTE = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_STAY = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_PHONE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_NAME = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_ID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.GR_EMP = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colمعرفالموظف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإسمالموظف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colرقمالإقامة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colرقمالهاتف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالمرتب = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالتاريخ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colملاحظة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colصورةالموظف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_SALARY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_EMP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATE_EMP.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATE_EMP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_NOTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_STAY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_PHONE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_NAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GR_EMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Location = new System.Drawing.Point(9, 10);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1306, 42);
            this.panelControl4.TabIndex = 20;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(531, 6);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(192, 31);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "نافذة إضافة الموظفين ";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.BT_DEL);
            this.panelControl3.Controls.Add(this.BT_BACK);
            this.panelControl3.Controls.Add(this.BT_EDIT);
            this.panelControl3.Controls.Add(this.BT_EXIT);
            this.panelControl3.Controls.Add(this.BT_SAVE);
            this.panelControl3.Location = new System.Drawing.Point(9, 385);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(621, 79);
            this.panelControl3.TabIndex = 23;
            // 
            // BT_DEL
            // 
            this.BT_DEL.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_DEL.Appearance.Options.UseFont = true;
            this.BT_DEL.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BT_DEL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BT_DEL.ImageOptions.Image")));
            this.BT_DEL.Location = new System.Drawing.Point(255, 20);
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
            this.BT_BACK.Location = new System.Drawing.Point(17, 20);
            this.BT_BACK.Margin = new System.Windows.Forms.Padding(4);
            this.BT_BACK.Name = "BT_BACK";
            this.BT_BACK.Size = new System.Drawing.Size(111, 41);
            this.BT_BACK.TabIndex = 5;
            this.BT_BACK.Text = "رجوع";
            this.BT_BACK.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // BT_EDIT
            // 
            this.BT_EDIT.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_EDIT.Appearance.Options.UseFont = true;
            this.BT_EDIT.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BT_EDIT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BT_EDIT.ImageOptions.Image")));
            this.BT_EDIT.Location = new System.Drawing.Point(374, 19);
            this.BT_EDIT.Margin = new System.Windows.Forms.Padding(4);
            this.BT_EDIT.Name = "BT_EDIT";
            this.BT_EDIT.Size = new System.Drawing.Size(111, 41);
            this.BT_EDIT.TabIndex = 4;
            this.BT_EDIT.Text = "تعديل";
            this.BT_EDIT.Click += new System.EventHandler(this.BT_EDIT_Click);
            // 
            // BT_EXIT
            // 
            this.BT_EXIT.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_EXIT.Appearance.Options.UseFont = true;
            this.BT_EXIT.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BT_EXIT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BT_EXIT.ImageOptions.Image")));
            this.BT_EXIT.Location = new System.Drawing.Point(136, 20);
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
            this.BT_SAVE.Location = new System.Drawing.Point(493, 18);
            this.BT_SAVE.Margin = new System.Windows.Forms.Padding(4);
            this.BT_SAVE.Name = "BT_SAVE";
            this.BT_SAVE.Size = new System.Drawing.Size(111, 41);
            this.BT_SAVE.TabIndex = 0;
            this.BT_SAVE.Text = "حفظ";
            this.BT_SAVE.Click += new System.EventHandler(this.BT_SAVE_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.TXT_SALARY);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.PIC_EMP);
            this.panelControl2.Controls.Add(this.DATE_EMP);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.TXT_NOTE);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.TXT_STAY);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.TXT_PHONE);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.TXT_NAME);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.TXT_ID);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(9, 58);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(621, 317);
            this.panelControl2.TabIndex = 24;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // TXT_SALARY
            // 
            this.TXT_SALARY.Location = new System.Drawing.Point(289, 166);
            this.TXT_SALARY.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SALARY.Name = "TXT_SALARY";
            this.TXT_SALARY.Properties.Mask.EditMask = "c0";
            this.TXT_SALARY.Size = new System.Drawing.Size(217, 20);
            this.TXT_SALARY.TabIndex = 24;
            this.TXT_SALARY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_SALARY_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(509, 165);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 19);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "المرتب:";
            // 
            // PIC_EMP
            // 
            this.PIC_EMP.Cursor = System.Windows.Forms.Cursors.Default;
            this.PIC_EMP.Location = new System.Drawing.Point(66, 19);
            this.PIC_EMP.Name = "PIC_EMP";
            this.PIC_EMP.Properties.InitialImage = ((System.Drawing.Image)(resources.GetObject("PIC_EMP.Properties.InitialImage")));
            this.PIC_EMP.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PIC_EMP.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.PIC_EMP.Properties.ZoomAccelerationFactor = 1D;
            this.PIC_EMP.Size = new System.Drawing.Size(148, 165);
            this.PIC_EMP.TabIndex = 22;
            this.PIC_EMP.DoubleClick += new System.EventHandler(this.PIC_EMP_DoubleClick);
            // 
            // DATE_EMP
            // 
            this.DATE_EMP.EditValue = null;
            this.DATE_EMP.Location = new System.Drawing.Point(291, 204);
            this.DATE_EMP.Name = "DATE_EMP";
            this.DATE_EMP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DATE_EMP.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DATE_EMP.Size = new System.Drawing.Size(216, 20);
            this.DATE_EMP.TabIndex = 21;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(507, 204);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(107, 19);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "تاريخ إنتهاء الإقامة:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(510, 241);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(44, 19);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "ملاحظة:";
            // 
            // TXT_NOTE
            // 
            this.TXT_NOTE.Location = new System.Drawing.Point(66, 242);
            this.TXT_NOTE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_NOTE.Name = "TXT_NOTE";
            this.TXT_NOTE.Size = new System.Drawing.Size(441, 59);
            this.TXT_NOTE.TabIndex = 19;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(528, 205);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(0, 19);
            this.labelControl6.TabIndex = 14;
            // 
            // TXT_STAY
            // 
            this.TXT_STAY.Location = new System.Drawing.Point(289, 92);
            this.TXT_STAY.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_STAY.Name = "TXT_STAY";
            this.TXT_STAY.Size = new System.Drawing.Size(217, 20);
            this.TXT_STAY.TabIndex = 13;
            this.TXT_STAY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_STAY_KeyPress);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(509, 91);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 19);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "رقم الإقامة:";
            // 
            // TXT_PHONE
            // 
            this.TXT_PHONE.Location = new System.Drawing.Point(289, 131);
            this.TXT_PHONE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_PHONE.Name = "TXT_PHONE";
            this.TXT_PHONE.Size = new System.Drawing.Size(217, 20);
            this.TXT_PHONE.TabIndex = 10;
            this.TXT_PHONE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_PHONE_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(509, 130);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 19);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "رقم الهاتف:";
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Location = new System.Drawing.Point(291, 55);
            this.TXT_NAME.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.Size = new System.Drawing.Size(215, 20);
            this.TXT_NAME.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(509, 53);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 19);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "إسم الموظف:";
            // 
            // TXT_ID
            // 
            this.TXT_ID.Location = new System.Drawing.Point(374, 19);
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
            this.labelControl1.Location = new System.Drawing.Point(509, 19);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 19);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "معرف الموظف:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.GR_EMP);
            this.panelControl1.Location = new System.Drawing.Point(637, 57);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(678, 407);
            this.panelControl1.TabIndex = 25;
            // 
            // GR_EMP
            // 
            this.GR_EMP.DataMember = "EMPLOYEES";
            this.GR_EMP.DataSource = this.sqlDataSource1;
            this.GR_EMP.Location = new System.Drawing.Point(5, 5);
            this.GR_EMP.MainView = this.gridView1;
            this.GR_EMP.Name = "GR_EMP";
            this.GR_EMP.Size = new System.Drawing.Size(668, 396);
            this.GR_EMP.TabIndex = 9;
            this.GR_EMP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GR_EMP.Click += new System.EventHandler(this.GR_EMP_Click);
            this.GR_EMP.DoubleClick += new System.EventHandler(this.GR_EMP_DoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Coon-1";
            this.sqlDataSource1.Name = "sqlDataSource1";
            column1.Alias = "معرف الموظف";
            columnExpression1.ColumnName = "EMP_ID";
            table1.Name = "EMPLOYEES";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            column2.Alias = "إسم الموظف";
            columnExpression2.ColumnName = "EMP_NAME";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            column3.Alias = "رقم الإقامة";
            columnExpression3.ColumnName = "EMP_STATUS";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            column4.Alias = "رقم الهاتف";
            columnExpression4.ColumnName = "EMP_PHONE";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            column5.Alias = "المرتب";
            columnExpression5.ColumnName = "EMP_SALARY";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            column6.Alias = "التاريخ";
            columnExpression6.ColumnName = "JOB_DATE";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            column7.Alias = "ملاحظة";
            columnExpression7.ColumnName = "NOTE";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            column8.Alias = "صورة الموظف";
            columnExpression8.ColumnName = "EMP_PIC";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Name = "EMPLOYEES";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colمعرفالموظف,
            this.colإسمالموظف,
            this.colرقمالإقامة,
            this.colرقمالهاتف,
            this.colالمرتب,
            this.colالتاريخ,
            this.colملاحظة,
            this.colصورةالموظف});
            this.gridView1.GridControl = this.GR_EMP;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colمعرفالموظف
            // 
            this.colمعرفالموظف.FieldName = "معرف الموظف";
            this.colمعرفالموظف.Name = "colمعرفالموظف";
            this.colمعرفالموظف.Visible = true;
            this.colمعرفالموظف.VisibleIndex = 0;
            // 
            // colإسمالموظف
            // 
            this.colإسمالموظف.FieldName = "إسم الموظف";
            this.colإسمالموظف.Name = "colإسمالموظف";
            this.colإسمالموظف.Visible = true;
            this.colإسمالموظف.VisibleIndex = 1;
            // 
            // colرقمالإقامة
            // 
            this.colرقمالإقامة.FieldName = "رقم الإقامة";
            this.colرقمالإقامة.Name = "colرقمالإقامة";
            this.colرقمالإقامة.Visible = true;
            this.colرقمالإقامة.VisibleIndex = 2;
            // 
            // colرقمالهاتف
            // 
            this.colرقمالهاتف.FieldName = "رقم الهاتف";
            this.colرقمالهاتف.Name = "colرقمالهاتف";
            this.colرقمالهاتف.Visible = true;
            this.colرقمالهاتف.VisibleIndex = 3;
            // 
            // colالمرتب
            // 
            this.colالمرتب.FieldName = "المرتب";
            this.colالمرتب.Name = "colالمرتب";
            this.colالمرتب.Visible = true;
            this.colالمرتب.VisibleIndex = 4;
            // 
            // colالتاريخ
            // 
            this.colالتاريخ.Caption = "تاريخ إنتهاء الإقامة";
            this.colالتاريخ.FieldName = "التاريخ";
            this.colالتاريخ.Name = "colالتاريخ";
            this.colالتاريخ.Visible = true;
            this.colالتاريخ.VisibleIndex = 5;
            // 
            // colملاحظة
            // 
            this.colملاحظة.FieldName = "ملاحظة";
            this.colملاحظة.Name = "colملاحظة";
            this.colملاحظة.Visible = true;
            this.colملاحظة.VisibleIndex = 6;
            // 
            // colصورةالموظف
            // 
            this.colصورةالموظف.FieldName = "صورة الموظف";
            this.colصورةالموظف.Name = "colصورةالموظف";
            this.colصورةالموظف.Visible = true;
            this.colصورةالموظف.VisibleIndex = 7;
            // 
            // panelControl5
            // 
            this.panelControl5.Location = new System.Drawing.Point(8, 501);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(1306, 42);
            this.panelControl5.TabIndex = 26;
            // 
            // EMPLOYEE_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 550);
            this.Controls.Add(this.panelControl5);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EMPLOYEE_FRM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPLOYEE_FRM";
            this.Load += new System.EventHandler(this.EMPLOYEE_FRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_SALARY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_EMP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATE_EMP.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATE_EMP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_NOTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_STAY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_PHONE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_NAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GR_EMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton BT_DEL;
        private DevExpress.XtraEditors.SimpleButton BT_BACK;
        private DevExpress.XtraEditors.SimpleButton BT_EDIT;
        private DevExpress.XtraEditors.SimpleButton BT_EXIT;
        private DevExpress.XtraEditors.SimpleButton BT_SAVE;
        public DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.PictureEdit PIC_EMP;
        public DevExpress.XtraEditors.DateEdit DATE_EMP;
        public DevExpress.XtraEditors.MemoEdit TXT_NOTE;
        public DevExpress.XtraEditors.TextEdit TXT_STAY;
        public DevExpress.XtraEditors.TextEdit TXT_PHONE;
        public DevExpress.XtraEditors.TextEdit TXT_NAME;
        public DevExpress.XtraEditors.TextEdit TXT_ID;
        public DevExpress.XtraEditors.TextEdit TXT_SALARY;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraGrid.GridControl GR_EMP;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colمعرفالموظف;
        private DevExpress.XtraGrid.Columns.GridColumn colإسمالموظف;
        private DevExpress.XtraGrid.Columns.GridColumn colرقمالإقامة;
        private DevExpress.XtraGrid.Columns.GridColumn colرقمالهاتف;
        private DevExpress.XtraGrid.Columns.GridColumn colالمرتب;
        private DevExpress.XtraGrid.Columns.GridColumn colالتاريخ;
        private DevExpress.XtraGrid.Columns.GridColumn colملاحظة;
        private DevExpress.XtraGrid.Columns.GridColumn colصورةالموظف;
        public DevExpress.XtraEditors.PanelControl panelControl5;
    }
}