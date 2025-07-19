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
    public partial class UC_SalaryNotes : UserControl
    {
        double hour, rate, total;

        public UC_SalaryNotes()
        {
            InitializeComponent();
        }

        private void totalBtn_Click(object sender, EventArgs e)
        {
            hour = double.Parse(totalHourTxt.Text);
            rate = double.Parse(hourlyRateTxt.Text);

            total = hour * rate;

            totalAmountTxt.Text = total.ToString("C2");
        }
        private void countBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int S10=0, S20=0, S50 = 0, S100 = 0;
            int RR10000=0 , RR5000, RR2000 = 0 , RR1000 = 0, RR500 = 0, RR100 = 0;
            //**Solution 1**
            int R10000 = 0, R5000 = 0, R2000=0, R1000=0, R500=0, R100 = 0;
            double remainding = total;
            double riel = total * 4000;

            S100 = (int)(remainding / 100);
            remainding -= S100 * 100;

            S50 = (int)(remainding) / 50;
            remainding -= S50 * 50;

            S20 = (int)(remainding) / 20;
            remainding -= S20 * 20;

            S10 = (int)(remainding) / 10;
            remainding -= S10 * 10;

            //S5 = (int)(remainding) / 5;
            //remainding -= S5 * 5;

            //S1 = (int)(remainding / 1);
            //remainding -= S1 * 1;

            int remindingDol = (int)remainding;
            int rielRemainding = (int)(remainding * 4000);

            RR10000 = rielRemainding / 10000;
            rielRemainding -= RR10000 * 10000;

            RR5000 = rielRemainding / 5000;
            rielRemainding -= RR5000 * 5000;

            RR2000 = rielRemainding / 2000 ;
            rielRemainding -= RR2000 * 2000 ;

            RR1000 = rielRemainding / 1000;
            rielRemainding -= RR1000 * 1000;

            RR500 = rielRemainding / 500;
            rielRemainding -= RR500 * 500;


            RR100 = rielRemainding / 100;
            rielRemainding -= RR100 * 100;


            R10000 = (int)(riel / 10000);
            riel -= R10000 * 10000;

            R5000 = (int)(riel / 5000);
            riel -= R5000 * 5000;

            R2000 = (int)(riel / 2000);
            riel -= R2000 * 2000;

            R1000 = (int)(riel / 1000);
            riel -= R1000 * 1000;

            R500 = (int)(riel / 500);
            riel -= R500 * 500;

            R100 = (int)(riel / 100);
            riel -= R100 * 100;


            listBox1.Items.Add("Dollars");
            listBox1.Items.Add($"100$ : {S100}");
            listBox1.Items.Add($"50$ : {S50}");
            listBox1.Items.Add($"20$ : {S20}");
            listBox1.Items.Add($"10$ : {S10}");
            //listBox1.Items.Add($"5$ : {S5}");
            //listBox1.Items.Add($"1$ : {S1}");
            listBox1.Items.Add($"Reminding Dollars : {remindingDol}");
            listBox1.Items.Add("RR10000: " + RR10000);
            listBox1.Items.Add("RR5000: " + RR5000);
            listBox1.Items.Add("RR2000: " + RR2000);
            listBox1.Items.Add("RR1000: " + RR1000);
            listBox1.Items.Add("RR500: " + RR500);
            listBox1.Items.Add("RR100: " + RR100);
            listBox1.Items.Add("-------------------------------");
            listBox1.Items.Add("Riels" + riel);
            listBox1.Items.Add("R10000: "+ R10000);
            listBox1.Items.Add("R5000: "+ R5000);
            listBox1.Items.Add("R2000: "+ R2000);
            listBox1.Items.Add("R1000: "+ R1000);
            listBox1.Items.Add("R500: "+ R500);
            listBox1.Items.Add("R100: " + R100);


        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            employeeNameTxt.Clear();
            hourlyRateTxt.Clear();
            invoiceNoTxt.Clear();
            sexTxt.Clear();
            totalAmountTxt.Clear();
            totalHourTxt.Clear();


            listBox1.Items.Clear();
            listBox1.Items.Clear();
            listBox1.Items.Clear();
            listBox1.Items.Clear();
            listBox1.Items.Clear();
            listBox1.Items.Clear();
            listBox1.Items.Clear();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            loadedForm loadedForm = new loadedForm();
            loadedForm.Show();
        }
    }
}
