using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;

            string location, method, reason;
            int ordId, cusId, empId;
            DateTime dates;

            loginForm.connection.Open();
            ordId = int.Parse(OrdNoTxt.Text);
            dates = dateTimePicker1.Value;
            cusId = int.Parse(CusIdTxt.Text);
            empId = int.Parse(EmpIdTxt.Text);
            location = LocationTxt.Text;
            method = MethodTxt.Text;
            reason = ReasonTxt.Text;
            string sqlStr = $@"
    INSERT INTO orders 
    VALUES ({ordId}, CONVERT(varchar, '{dates}', 123), {cusId}, {empId}, '{location}', '{method}', '{reason}');
";

            cmd = new SqlCommand(sqlStr, loginForm.connection);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data is inserted");
                loginForm.connection.Close();
                InsertDetails();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertDetails()
        {
            SqlCommand cmd;

           
            int ordId, proId, qty;
            double unitPrice;
            

            loginForm.connection.Open();

            foreach (DataGridViewRow row in dataGridView1.Rows) {
                ordId = int.Parse(OrdNoTxt.Text);
                proId = int.Parse(row.Cells[0].Value.ToString());
                qty = int.Parse(row.Cells[2].Value.ToString());
                unitPrice = double.Parse(row.Cells[3].Value.ToString());
            string sqlStr = $@"
    INSERT INTO DETAILS 
    VALUES ({ordId}, {proId}, {qty} , {unitPrice});
";
            cmd = new SqlCommand(sqlStr, loginForm.connection);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data is inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

            }
            loginForm.connection.Close();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;


            int ordId;
            

            loginForm.connection.Open();
            ordId = int.Parse(OrdNoTxt.Text);
            string sqlStr = $@"DELETE FROM ORDERS WHERE ORDID = {ordId};";
            cmd = new SqlCommand(sqlStr, loginForm.connection);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data is deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            
            loginForm.connection.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader reader;

            int ordId;


            loginForm.connection.Open();
            ordId = int.Parse(OrdNoTxt.Text);
            string sqlStr = $@"SELECT * FROM ORDERS WHERE ORDID = {ordId};";
            cmd = new SqlCommand(sqlStr, loginForm.connection);
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data is deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            loginForm.connection.Close();
        }
    }
}
