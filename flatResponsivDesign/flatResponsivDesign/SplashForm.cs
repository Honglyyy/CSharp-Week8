using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flatResponsivDesign
{
    public partial class SplashForm : Form
    {
        int i = 0;
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            Timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = i++;
            if (i == 100)
            {
                Timer1.Stop();
                loginForm loginForm = new loginForm();
                loginForm.Show();
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
