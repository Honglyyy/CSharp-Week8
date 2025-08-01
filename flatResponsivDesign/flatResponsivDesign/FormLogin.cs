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
    public partial class loginForm : Form
    {
        SqlConnection connection;
        public static string publicUserName;
        public static string username;
        public loginForm()
        {
            InitializeComponent();
        }
        

        private void loginBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            string username, password;
            username = usernameTxt.Text;
            password = passwordTxt.Text;

            SqlCommand cmd = new SqlCommand($"Select * from Users where UserName = '{username}' and Pwd = '{password}';",connection);
            SqlDataReader dataReader = null;

            dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows) 
            {
                publicUserName = username;
                MessageBox.Show("Sucessfull");
                connection.Close();
                Main_Form main_Form = new Main_Form();
                main_Form.Show();
                this.Close();
            
            }
            else
            {
                MessageBox.Show("Failure");
                connection.Close();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "Data Source=Hongly\\SQLEXPRESS;Initial Catalog=C#_Backend;Integrated Security=True;";

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                InfoLbl.Text = "Connected to the database successfully!";
            }
            catch (SqlException ex)
            {
                InfoLbl.Text = ex.Message;
            }
            connection.Close();

        }
    }
}
//Login Btn wthout backend
//string password, confirmPassword;
//username = usernameTxt.Text;
//password = passwordTxt.Text;
//confirmPassword = confirmPasswordTxt.Text;

//if (username == "Hongly")
//{
//    if (password == "123")
//    {
//        if(confirmPassword == password)
//        {
//            Main_Form main_Form = new Main_Form();
//            main_Form.Show();


//        }
//        else
//        {
//            MessageBox.Show("Confirm password must be the same as password");
//        }
//    }
//    else
//    {
//        MessageBox.Show("Invalid password");
//    }
//}
//else
//{
//    MessageBox.Show("Invalid!!");
//}
