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
    public partial class RegiScreen : Form
    {
        public static string customer_id;
        public static int index_ID;
        public RegiScreen()
        {
            InitializeComponent();
        }
        string connectinString = @"Data Source=DESKTOP-MPTGS57\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void id_generation_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-MPTGS57\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            var query = "SELECT MAX ([Customer_ID]) FROM [dbo].[Customers]";
            SqlCommand sqlCmd = new SqlCommand(query, sqlConn);
            sqlConn.Open();
            customer_id = sqlCmd.ExecuteScalar().ToString();
            index_ID = Int32.Parse(customer_id);
            index_ID++;
            txt_re_id.Text = RegiScreen.index_ID.ToString();

            sqlConn.Close();
        }

        private void re_button_Click(object sender, EventArgs e)
        {
            if (txt_re_password.Text == "" || txt_re_first_name.Text == "" || txt_re_last_name.Text == "" || txt_re_customer_street.Text == "" || txt_re_customer_city.Text == "")
                MessageBox.Show("Something is empty");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectinString))
                {

                    // string query = "INSERT INTO [dbo].[Customers](Customer_ID,First_name,Last_name,Customer_City,Customer_Street,Customer_PCode,Customer_email,Customer_phone,Customer_password) VALUES(@Customer_ID,@First_name,@Last_name,@Customer_City,@Customer_Street,@Customer_PCode,@Customer_email,@Customer_phone,@Customer_password)";
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("AddUsers", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Customer_ID", txt_re_id.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@First_name", txt_re_first_name.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Last_name", txt_re_last_name.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Customer_City", txt_re_customer_city.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Customer_Street", txt_re_customer_street.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Customer_PCode", txt_re_customer_pc.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Customer_email", txt_re_email.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Customer_phone", txt_re_phone.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Customer_password", txt_re_password.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saccessful!");
                    Clear();
                    sqlCon.Close();
                }
            }


        }
        void Clear()
        {
            txt_re_first_name.Text = txt_re_last_name.Text = txt_re_customer_city.Text = txt_re_customer_street.Text = txt_re_customer_pc.Text = txt_re_email.Text = txt_re_phone.Text = txt_re_password.Text = "";
        }

        private void re_login_button_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
    }
    
}
