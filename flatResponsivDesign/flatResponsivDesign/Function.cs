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
    public partial class Function : Form
    {
        double aValue, bValue, total;
        public Function()
        {
            InitializeComponent();
        }

        public static int z = 0;
        private void addBtn_Click(object sender, EventArgs e)
        {

            aValue = double.Parse(aValueTxt.Text);
            bValue = double.Parse(bValueTxt.Text);

            total = add(aValue, bValue);

            totalTxt.Text = total.ToString();
        }

        private void subtractBtn_Click(object sender, EventArgs e)
        {

            aValue = double.Parse(aValueTxt.Text);
            bValue = double.Parse(bValueTxt.Text);

            total = minus(aValue, bValue);

            totalTxt.Text = total.ToString();
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            aValue = double.Parse(aValueTxt.Text);
            bValue = double.Parse(bValueTxt.Text);

            total = times(aValue, bValue);

            totalTxt.Text = total.ToString();
        }
        private void divideBtn_Click(object sender, EventArgs e)
        {
            aValue = double.Parse(aValueTxt.Text);
            bValue = double.Parse(bValueTxt.Text);

            total = divideBy(aValue, bValue);

            totalTxt.Text = total.ToString();
        }

        private double add(double x, double y) 
        { 
            return x + y;
        }
        private double minus(double x, double y) 
        { 
            return x - y; 
        }



        private double times(double x, double y)
        {
            return x * y;
        }

      
        private double divideBy(double x, double y) 
        { 
            return x / y; 
        }
        private void FuncBtn_Click(object sender, EventArgs e)
        {
            
            totalTxt.Text = (++z).ToString();
        }
        private void NextBtn_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();
            testForm.Show();
        }

    }

}
