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
    public partial class MainWindow : Form
    {
        public static string username_id_mw;
        public static string author_name_f;

        public static string order_id_gen;
        public static int index_ID;
        public MainWindow()
        {
            InitializeComponent();
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
    }
}
