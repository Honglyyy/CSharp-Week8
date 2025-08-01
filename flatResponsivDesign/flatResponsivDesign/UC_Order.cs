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
    public partial class UC_Order : UserControl
    {
        public static string orderNumber;
        public UC_Order()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            orderNumber = OrdNoTxt.Text;

            DetailForm detailForm = new DetailForm(this);
            detailForm.Show();
        }
    }
}
