using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_I
{
    public partial class LoginScreen : Form
    {
        public static string username;
        public static string username_id_lw;
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-MPTGS57\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();
                string query = "SELECT COUNT(1) FROM [dbo].[Customers] WHERE First_name=@First_name AND Customer_ID=@Customer_ID AND Customer_password=@Customer_password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlConn);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@First_name", txt_username.Text);
                sqlCmd.Parameters.AddWithValue("@Customer_ID", txt_customer_id.Text);
                sqlCmd.Parameters.AddWithValue("@Customer_password", txt_password.Text);

                username = txt_username.Text;
                username_id_lw = txt_customer_id.Text;

                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {

                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login/Hasło/ID nie prawidłowe");
                    txt_username.Text = "";
                    txt_customer_id.Text = "";
                    txt_password.Text = "";

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void button_regi_Click(object sender, EventArgs e)
        {
            RegiScreen regiScreen = new RegiScreen();
            regiScreen.Show();
            this.Hide();
        }
    }
}
