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
    public partial class DetailForm : Form
    {
        float grandTotal = 0;
        UC_Order newOrder;
        

        public DetailForm(UC_Order oldOrder)
        {
            InitializeComponent();
            this.newOrder = oldOrder;
        }

       

        private void DetailForm_Load(object sender, EventArgs e)
        {
            OrderNoTxt.Text = UC_Order.orderNumber;
        }

        private void AmountTxt_Click(object sender, EventArgs e)
        {
            AmountTxt.Text = (int.Parse(QuantityTxt.Text) * float.Parse(UnitPriceTxt.Text)).ToString();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            grandTotal += float.Parse(AmountTxt.Text);

            newOrder.dataGridView1.Rows.Add(ProNoTxt.Text, ProNameTxt.Text, QuantityTxt.Text, UnitPriceTxt.Text, AmountTxt.Text);

            ProNameTxt.Clear();
            ProNoTxt.Clear();
            QuantityTxt.Clear();
            UnitPriceTxt.Clear();
            AmountTxt.Clear();
            ProNameTxt.Focus();
        }
    }
}
