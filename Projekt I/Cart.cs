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
    public partial class Cart : Form
    {
        public static string index_ID_find_cw;


        public Cart()
        {
            index_ID_find_cw = MainWindow.index_ID_find_mw;
            InitializeComponent();
            refresh_cart();
        }
        private void button_return_cart_Click_1(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-MPTGS57\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                sqlConn.Open();
                SqlCommand cmd = sqlConn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from cart where Book_name='" + txt_delete_cart.Text + "'";
                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }

            //foreach (DataGridViewRow row in data_grid_table_cart.SelectedRows)
            //{
            //    data_grid_table_cart.Rows.RemoveAt(row.Index);
            //}
            refresh_cart();
        }

        private void data_grid_table_cart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow viewRow = data_grid_table_cart.Rows[e.RowIndex];
                txt_delete_cart.Text = viewRow.Cells[0].Value.ToString();
               

            }
        }
 

        private void button_delete_order_cart_Click(object sender, EventArgs e)
        {
            refresh_order();
        }

        private void button_delete_order_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-MPTGS57\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                if (txt_delete_order_cart.Text=="")
                {
                    MessageBox.Show("Podaj numer Zamówienia(Order_ID)");
                }
                sqlConn.Open();
                SqlCommand cmd = sqlConn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from cart where Order_ID='" + txt_delete_order_cart.Text + "'";
                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
            refresh_order();
        }

        private void button_refresh_cart_Click(object sender, EventArgs e)
        {
            refresh_cart();
        }
       
        private void refresh_cart()
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-MPTGS57\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {

                sqlConn.Open();
                string query = "select Book_name, sum(cast([Amount] as int)) as Ilosc,Price from Cart where Customer_ID='" + index_ID_find_cw + "'" + " group by Book_name,Price";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
                sqlCommand.CommandType = CommandType.Text;



                sqlCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdapt = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable("[dbo].[Cart]");
                dataAdapt.Fill(dt);
                data_grid_table_cart.DataSource = dt.DefaultView;


                sqlConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }

        }
        private void button_buy_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-MPTGS57\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {

                sqlConn.Open();
                string query = "select SUM((CAST(Price as decimal) * Amount)) as Rachunek from Cart where Customer_ID =" + index_ID_find_cw;
                SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
                sqlCommand.CommandType = CommandType.Text;

                

                sqlCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdapt = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable("[dbo].[Cart]");
                dataAdapt.Fill(dt);
                data_grid_table_cart.DataSource = dt.DefaultView;


                sqlConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }

           

        }
        private void refresh_order()
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-MPTGS57\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {

                sqlConn.Open();
                string query = "select Book_name, sum(cast([Amount] as int)) as Ilosc,Price,Order_ID from Cart where Customer_ID='" + index_ID_find_cw + "'" + " group by Book_name,Price,Order_ID";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
                sqlCommand.CommandType = CommandType.Text;



                sqlCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdapt = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable("[dbo].[Cart]");
                dataAdapt.Fill(dt);
                data_grid_table_cart.DataSource = dt.DefaultView;


                sqlConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }


    }
}
