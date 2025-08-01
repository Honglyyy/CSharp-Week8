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
    public partial class Main_Form : Form
    {
        bool empClick, reportClick;
        public Main_Form()
        {
            InitializeComponent();
        }


        private void Main_Form_Load(object sender, EventArgs e)
        {
            LblWelcome.Text += loginForm.publicUserName;

            loadedForm1.BringToFront();
            pnlLeft1.Height = 0;
            pnlLeft2.Height = 0;

            empClick = false;
            reportClick = false;
           

        }

       

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            if (empClick == true)
            {
                loadedForm1.BringToFront();
                pnlLeft1.Height = 0;
                empClick = false;
            }
            else
            {
                pnlLeft1.Height = 100;
                empClick = true;
            }
        }

     

        private void reportBtn_Click(object sender, EventArgs e)
        {
            if (reportClick == true)
            {
                loadedForm1.BringToFront();
                pnlLeft2.Height = 0;
                reportClick = false;
            }
            else
            {
                pnlLeft2.Height = 150;
                reportClick = true;
            }
        }

        private void fullTimeBtn_Click(object sender, EventArgs e)
        {
            uC_FullTime1.BringToFront();
        }


        private void partTimeBtn_Click(object sender, EventArgs e)
        {
            uC_PartTime1.BringToFront();
        }

      
        private void dailyBtn_Click(object sender, EventArgs e)
        {
            uC_Daily1.BringToFront();
        }


        private void weeklyBtn_Click(object sender, EventArgs e)
        {
            uC_Weekly1.BringToFront();
        }

        private void monthlyBtn_Click(object sender, EventArgs e)
        {
            uC_Monthly1.BringToFront();

        }
        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to log out?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                loginForm loginForm = new loginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }

}


