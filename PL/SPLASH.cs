using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using COFFEE_SHOP.FORMS;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace COFFEE_SHOP.PL
{
    public partial class SPLASH : SplashScreen
    {
        public SPLASH()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
           
            Timer1.Stop();
            this.Hide();
            LOGIN F = new LOGIN();
            F.Show();
        }

        private void SPLASH_Load(object sender, EventArgs e)
        {
            Timer1.Start();
        }
    }
}