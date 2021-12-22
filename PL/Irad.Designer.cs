namespace COFFEE_SHOP.PL
{
    partial class Irad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Irad));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.DATE_PRD = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_PRICE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_NAME = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_NOTE = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.BT_BACK = new DevExpress.XtraEditors.SimpleButton();
            this.BT_SAVE = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATE_PRD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATE_PRD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_PRICE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_NAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_NOTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.DATE_PRD);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.TXT_PRICE);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.TXT_NAME);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.TXT_NOTE);
            this.panelControl2.Location = new System.Drawing.Point(12, 60);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(681, 137);
            this.panelControl2.TabIndex = 20;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // DATE_PRD
            // 
            this.DATE_PRD.EditValue = null;
            this.DATE_PRD.Location = new System.Drawing.Point(357, 103);
            this.DATE_PRD.Name = "DATE_PRD";
            this.DATE_PRD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DATE_PRD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DATE_PRD.Size = new System.Drawing.Size(232, 20);
            this.DATE_PRD.TabIndex = 14;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(590, 100);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 19);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "التاريخ:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(287, 21);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 19);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "ملاحظة:";
            // 
            // TXT_PRICE
            // 
            this.TXT_PRICE.Location = new System.Drawing.Point(357, 59);
            this.TXT_PRICE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_PRICE.Name = "TXT_PRICE";
            this.TXT_PRICE.Properties.Mask.EditMask = "c";
            this.TXT_PRICE.Size = new System.Drawing.Size(232, 20);
            this.TXT_PRICE.TabIndex = 10;
            this.TXT_PRICE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_PRICE_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(591, 57);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 19);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "المبلغ:";
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Location = new System.Drawing.Point(357, 18);
            this.TXT_NAME.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.Size = new System.Drawing.Size(232, 20);
            this.TXT_NAME.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(591, 15);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 19);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "الإسم:";
            // 
            // TXT_NOTE
            // 
            this.TXT_NOTE.Location = new System.Drawing.Point(18, 20);
            this.TXT_NOTE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_NOTE.Name = "TXT_NOTE";
            this.TXT_NOTE.Size = new System.Drawing.Size(267, 99);
            this.TXT_NOTE.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(257, 5);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(160, 31);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "الإيرادات الخارجية";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Location = new System.Drawing.Point(12, 12);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(681, 42);
            this.panelControl4.TabIndex = 19;
            this.panelControl4.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl4_Paint);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.BT_BACK);
            this.panelControl3.Controls.Add(this.BT_SAVE);
            this.panelControl3.Location = new System.Drawing.Point(12, 217);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(681, 69);
            this.panelControl3.TabIndex = 21;
            // 
            // BT_BACK
            // 
            this.BT_BACK.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_BACK.Appearance.Options.UseFont = true;
            this.BT_BACK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BT_BACK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BT_BACK.ImageOptions.Image")));
            this.BT_BACK.Location = new System.Drawing.Point(162, 16);
            this.BT_BACK.Margin = new System.Windows.Forms.Padding(4);
            this.BT_BACK.Name = "BT_BACK";
            this.BT_BACK.Size = new System.Drawing.Size(144, 41);
            this.BT_BACK.TabIndex = 5;
            this.BT_BACK.Text = "رجوع";
            this.BT_BACK.Click += new System.EventHandler(this.BT_BACK_Click);
            // 
            // BT_SAVE
            // 
            this.BT_SAVE.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_SAVE.Appearance.Options.UseFont = true;
            this.BT_SAVE.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BT_SAVE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BT_SAVE.ImageOptions.Image")));
            this.BT_SAVE.Location = new System.Drawing.Point(365, 16);
            this.BT_SAVE.Margin = new System.Windows.Forms.Padding(4);
            this.BT_SAVE.Name = "BT_SAVE";
            this.BT_SAVE.Size = new System.Drawing.Size(144, 41);
            this.BT_SAVE.TabIndex = 0;
            this.BT_SAVE.Text = "حفظ";
            this.BT_SAVE.Click += new System.EventHandler(this.BT_SAVE_Click);
            // 
            // Irad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 304);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Irad";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Irad";
            this.Load += new System.EventHandler(this.Irad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATE_PRD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATE_PRD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_PRICE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_NAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_NOTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DateEdit DATE_PRD;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TXT_PRICE;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TXT_NAME;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit TXT_NOTE;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.PanelControl panelControl4;
        public DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton BT_BACK;
        private DevExpress.XtraEditors.SimpleButton BT_SAVE;
    }
}