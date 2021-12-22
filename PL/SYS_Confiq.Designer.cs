namespace COFFEE_SHOP.PL
{
    partial class SYS_Confiq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SYS_Confiq));
            this.RB_WIN = new System.Windows.Forms.RadioButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BT_SAVE = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_SERVER = new DevExpress.XtraEditors.TextEdit();
            this.TXT_BASE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_SERVER.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_BASE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // RB_WIN
            // 
            this.RB_WIN.AutoSize = true;
            this.RB_WIN.Checked = true;
            this.RB_WIN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_WIN.Location = new System.Drawing.Point(143, 177);
            this.RB_WIN.Name = "RB_WIN";
            this.RB_WIN.Size = new System.Drawing.Size(195, 23);
            this.RB_WIN.TabIndex = 17;
            this.RB_WIN.TabStop = true;
            this.RB_WIN.Text = "Windows Authentiocation";
            this.RB_WIN.UseVisualStyleBackColor = true;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(44, 177);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(93, 22);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "طريقة الولوج :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(50, 133);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 22);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "قاعدة البيانات:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(57, 98);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 22);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "أسم السيرفر:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // BT_SAVE
            // 
            this.BT_SAVE.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BT_SAVE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BT_SAVE.ImageOptions.Image")));
            this.BT_SAVE.Location = new System.Drawing.Point(159, 233);
            this.BT_SAVE.Name = "BT_SAVE";
            this.BT_SAVE.Size = new System.Drawing.Size(104, 32);
            this.BT_SAVE.TabIndex = 16;
            this.BT_SAVE.Text = "حفظ";
            this.BT_SAVE.Click += new System.EventHandler(this.BT_SAVE_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Location = new System.Drawing.Point(8, 7);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(378, 42);
            this.panelControl4.TabIndex = 20;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(19, 4);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(340, 31);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "SYSTEM CONFIQERTION ";
            // 
            // TXT_SERVER
            // 
            this.TXT_SERVER.Location = new System.Drawing.Point(143, 100);
            this.TXT_SERVER.Name = "TXT_SERVER";
            this.TXT_SERVER.Size = new System.Drawing.Size(224, 20);
            this.TXT_SERVER.TabIndex = 21;
            // 
            // TXT_BASE
            // 
            this.TXT_BASE.EditValue = "Coffee_Shop";
            this.TXT_BASE.Location = new System.Drawing.Point(143, 136);
            this.TXT_BASE.Name = "TXT_BASE";
            this.TXT_BASE.Properties.ReadOnly = true;
            this.TXT_BASE.Size = new System.Drawing.Size(224, 20);
            this.TXT_BASE.TabIndex = 22;
            // 
            // SYS_Confiq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 289);
            this.Controls.Add(this.TXT_BASE);
            this.Controls.Add(this.TXT_SERVER);
            this.Controls.Add(this.BT_SAVE);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.RB_WIN);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SYS_Confiq";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYS_Confiq";
            this.Load += new System.EventHandler(this.SYS_Confiq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_SERVER.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_BASE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BT_SAVE;
        public DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TXT_SERVER;
        private DevExpress.XtraEditors.TextEdit TXT_BASE;
        public System.Windows.Forms.RadioButton RB_WIN;
    }
}