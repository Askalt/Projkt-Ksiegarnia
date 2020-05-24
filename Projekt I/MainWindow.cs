using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_I
{
    public partial class MainWindow : Form
    {
        public static string username_id_mw;
        public static string author_name_f;

        public static string order_id_gen;
        public static int index_ID;
        public static string index_ID_find_mw;

        Cart Koszyk = new Cart();


        public MainWindow()
        {
            
            InitializeComponent();
            username_name.Text = LoginScreen.username;
            txt_username_id_mw.Text = LoginScreen.username_id_lw;
            index_ID_find_mw = txt_username_id_mw.Text;

            SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-MPTGS57\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                sqlConn.Open();
                author_name_f = txt_name_authora_find.Text;
                string query = "select Author_name as Author,Title_name as Title,Published_year as Published,Retail_price as Price from [dbo].[STOCK]";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
                sqlCommand.CommandType = CommandType.Text;


                sqlCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdapt = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable("[dbo].[STOCK]");
                dataAdapt.Fill(dt);
                data_grid_table.DataSource = dt;

                sqlConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }

            id_generic();
        }
        private void username_name_TextChanged(object sender, EventArgs e)
        {
            username_name.Text = LoginScreen.username.ToUpper();
        }

        private void txt_username_id_mw_TextChanged(object sender, EventArgs e)
        {
            txt_username_id_mw.Text = LoginScreen.username_id_lw;
        }

        private void button_load_book_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-MPTGS57\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                sqlConn.Open();
                author_name_f = txt_name_authora_find.Text;
                string query = "select Author_name as Author,Title_name as Title,Published_year as Published,Retail_price as Price from [dbo].[STOCK]";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
                sqlCommand.CommandType = CommandType.Text;


                sqlCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdapt = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable("[dbo].[STOCK]");
                dataAdapt.Fill(dt);
                data_grid_table.DataSource = dt;

                sqlConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void find_book_button_Click(object sender, EventArgs e)
        {
            if (txt_name_authora_find.Text == "")
            {
                MessageBox.Show("Author name is empty");
            }
            else
            {
                SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-MPTGS57\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                try
                {
                    sqlConn.Open();
                    author_name_f = txt_name_authora_find.Text;
                    string query = "select Author_name as Author,Title_name as Title,Published_year as Published,Retail_price as Price from [dbo].[STOCK] where Author_name=@Author_name";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
                    sqlCommand.CommandType = CommandType.Text;

                    sqlCommand.Parameters.AddWithValue("@Author_name", txt_name_authora_find.Text);


                    sqlCommand.ExecuteNonQuery();

                    SqlDataAdapter dataAdapt = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable("[dbo].[STOCK]");
                    dataAdapt.Fill(dt);
                    data_grid_table.DataSource = dt;

                    sqlConn.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

            }
        }

        private void button_sort_desc_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-MPTGS57\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                sqlConn.Open();

                string query = "select Author_name as Author,Title_name as Title,Published_year as Published,Retail_price as Price from [dbo].[STOCK] order by Price desc";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
                sqlCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdapt = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable("[dbo].[STOCK]");
                dataAdapt.Fill(dt);
                data_grid_table.DataSource = dt;

                sqlConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void button_sord_asc_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-MPTGS57\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                sqlConn.Open();

                string query = "select Author_name as Author,Title_name as Title,Published_year as Published,Retail_price as Price from [dbo].[STOCK] order by Price";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
                sqlCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdapt = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable("[dbo].[STOCK]");
                dataAdapt.Fill(dt);
                data_grid_table.DataSource = dt;

                sqlConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void book_store_customer_want_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }

     

        private void data_grid_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                DataGridViewRow viewRow = data_grid_table.Rows[e.RowIndex];
                txt_author_shop.Text = viewRow.Cells[0].Value.ToString();
                txt_title_shop.Text = viewRow.Cells[1].Value.ToString();
                txt_price_shop.Text = viewRow.Cells[3].Value.ToString();
                id_generic();
            }
        }

        private void button_shop_add_Click(object sender, EventArgs e)
        {
            
            string connectionString = @"Data Source=DESKTOP-MPTGS57\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                username_id_mw = LoginScreen.username_id_lw;
                sqlConn.Open();


                    if (txt_numer_book.Text == "" || txt_numer_book.Text == "0")
                    {
                        MessageBox.Show("Prosze podać ilość!");
                    }
                    else
                    {

                        SqlCommand sqlCmd = new SqlCommand("CartBookAdd", sqlConn);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@Order_ID", txt_order_generic.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Customer_ID", txt_username_id_mw.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Book_name", txt_title_shop.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Price", txt_price_shop.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Amount", txt_numer_book.Text.Trim());
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Dodano do koszyka!");

                    }
                id_generic();
            }




            //    int iloscwierszywkoszyku = Koszyk.data_grid_table_cart.Rows.Count;
            //    if (Koszyk.data_grid_table_cart.Rows.Count>0)
            //    {
            //        for (int i = 0; i < data_grid_table.SelectedRows.Count; i++)
            //        {

            //            bool found = false;
            //            for (int k = 0; k < Koszyk.data_grid_table_cart.Rows.Count; k++)
            //            {
            //                if (Koszyk.data_grid_table_cart==null||Koszyk.data_grid_table_cart.Rows.Count==0) // zrobisz tutaj sql z nie powtaraniem sie elementów w tabeli a sumowaniem ich ilosci i dobranocki :3
            //                {
            //                    LoginScreen loginScreen = new LoginScreen();
            //                    loginScreen.Show();
            //                    this.Hide();
            //                    found = true;
            //                }
            //                else if (Koszyk.data_grid_table_cart.Rows[k].Cells[2].Value!=null)
            //                {
            //                    LoginScreen loginScreen = new LoginScreen();
            //                    loginScreen.Show();
            //                    this.Hide();
            //                    found = true;
            //                }
            //if (data_grid_table.Rows[i].Cells[1].Value.ToString() == Koszyk.data_grid_table_cart.Rows[k].Cells[2].Value.ToString())
            //{
            //    LoginScreen loginScreen = new LoginScreen();
            //    loginScreen.Show();
            //    this.Hide();
            //    found = true;

            //}
            //else
            //{
            //    Cart cart = new Cart();
            //    cart.Show();
            //    this.Hide();
            //    found = true;
            //}



        }

        private void logout_button_mw_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();

        }
        private void add_book(int b)
        {
            string connectionString = @"Data Source=DESKTOP-MPTGS57\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                username_id_mw = LoginScreen.username_id_lw;
                sqlConn.Open();

                if (txt_numer_book.Text == "" || txt_numer_book.Text == "0")
                {
                    MessageBox.Show("Prosze podać ilość!");
                }
                else
                {

                    SqlCommand sqlCmd = new SqlCommand("CartBookAdd", sqlConn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Order_ID", txt_order_generic.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Customer_ID", txt_username_id_mw.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Book_name", txt_title_shop.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Price", txt_price_shop.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Amount", txt_numer_book.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Dodano do koszyka!");

                }
            }
        }

        private void id_generic()
        {
            string connectionString = @"Data Source=DESKTOP-MPTGS57\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection sqlConn2 = new SqlConnection(connectionString))
            {
                var query = "SELECT MAX ([Order_ID]) FROM [dbo].[Cart] where Customer_ID='" + @index_ID_find_mw + "'";
                SqlCommand sqlCmd = new SqlCommand(query, sqlConn2);
                sqlConn2.Open();
                order_id_gen = sqlCmd.ExecuteScalar().ToString();
                if (order_id_gen == "")
                {
                    Random rnd = new Random();
                    index_ID = rnd.Next();
                    txt_order_generic.Text = MainWindow.index_ID.ToString();
                }
                else
                {
                    Random rnd = new Random();
                    index_ID = rnd.Next();
                    txt_order_generic.Text = MainWindow.index_ID.ToString();

                }
                sqlConn2.Close();
            }
        }
    }
}
