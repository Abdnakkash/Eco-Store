using Microsoft.VisualBasic.ApplicationServices;
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

namespace EcoStore
{
    public partial class Admin : Form
    {
        public string nameUser { get; set; }
        public Admin()
        {
            InitializeComponent();

            listView1.View = View.Details;

            listView1.Columns.Add("ItemName", 100);
            listView1.Columns.Add("Quantity", 100);
            listView1.Columns.Add("Category", 100);


            AddQ.Maximum = 100;

            DataGridView dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;
            /*dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;*/
            dataGridView1.ReadOnly = true;

            Customers.Controls.Add(dataGridView1);

            dataGridView1.Columns.Add("1", " UserName ");
            dataGridView1.Columns.Add("2", " Address ");
            dataGridView1.Columns.Add("3", " Country ");
            dataGridView1.Columns.Add("4", " PhoneNumber ");
            dataGridView1.Columns.Add("5", " Fruit ");
            dataGridView1.Columns.Add("6", " Quantity ");
            dataGridView1.Columns.Add("7", " Veggi ");
            dataGridView1.Columns.Add("8", " Quantity ");
            dataGridView1.Columns.Add("9", " Snack ");
            dataGridView1.Columns.Add("10", " Quantity ");
            dataGridView1.Columns.Add("11", " Snack ");
            dataGridView1.Columns.Add("12", " Quantity ");
            dataGridView1.Columns.Add("13", " Price ");

            

            string con = "Data Source=ABDALHADI; Initial Catalog=EcoStore; Integrated Security = true;";
            SqlConnection sql = new SqlConnection(con);

            string cmd = "SELECT UserName, Address, Country, PhoneNumber, Fruit, QuantityF, Veggi, QuantityV, Snack, QuantityS, Snack2, QuantityS1, Price FROM Orders";
            SqlCommand sqlCommand = new SqlCommand(cmd, sql);

            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    dataGridView1.Rows.Add(row["UserName"].ToString(), row["Address"].ToString(), row["Country"].ToString(),
                        row["PhoneNumber"].ToString(), row["Fruit"].ToString(), row["QuantityF"].ToString(),
                        row["Veggi"].ToString(), row["QuantityV"].ToString(), row["Snack"].ToString(), row["QuantityS"].ToString(),
                        row["Snack2"].ToString(), row["QuantityS1"].ToString(), row["Price"].ToString());

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sql.Close(); }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            string con = "Data Source=ABDALHADI; Initial Catalog=EcoStore; Integrated Security = true;";
            SqlConnection sql = new SqlConnection(con);

            string cmd = "SELECT ItemName, Quantity, Category FROM GroceryItem";
            SqlCommand sqlCommand = new SqlCommand(cmd, sql);

            try
            {
                sql.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { reader.GetString(0), reader.GetInt32(1).ToString(), reader.GetString(2) });
                    listView1.Items.Add(item);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally { sql.Close(); }
        }

        private void BtLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("GoodBye :)");
            EcoStore form = new EcoStore();
            form.ShowDialog();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            string con = "Data Source=ABDALHADI; Initial Catalog=EcoStore; Integrated Security = true;";
            SqlConnection sql = new SqlConnection(con);

            string cmd = "INSERT INTO GroceryItem (ItemName,Quantity,Category)";
            cmd += "VALUES ('" + AddItem.Text + "','" + Convert.ToInt32(AddQ.Value) + "','" + AddCategory.Text + "')";
            SqlCommand sqlCommand = new SqlCommand(cmd, sql);

            try
            {

                sql.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Item Was Add");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { sql.Close(); }
        }

        private void EditBt_Click(object sender, EventArgs e)
        {
            string con = "Data Source=ABDALHADI; Initial Catalog=EcoStore; Integrated Security = true;";
            SqlConnection sql = new SqlConnection(con);

            string cmd = "UPDATE GroceryItem SET Quantity=@Quantity WHERE ItemName=@ItemName";
            SqlCommand sqlCommand = new SqlCommand(cmd, sql);

            string add = ItemName.Text;
            string newQuantity = ChangeQ.Text;

            sqlCommand.Parameters.AddWithValue("@Quantity", newQuantity);
            sqlCommand.Parameters.AddWithValue("@ItemName", add);

            try
            {
                sql.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Item quantity updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }

        }

        private void RemoveBt_Click(object sender, EventArgs e)
        {
            string con = "Data Source=ABDALHADI; Initial Catalog=EcoStore; Integrated Security = true;";
            SqlConnection sql = new SqlConnection(con);

            string cmd = "DELETE GroceryItem WHERE ItemName=@ItemName";
            SqlCommand sqlCommand = new SqlCommand(cmd, sql);

            string Remove1 = Remove.Text;

            sqlCommand.Parameters.AddWithValue("@ItemName", Remove1);
            try
            {
                sql.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show(Remove1 + " removed from the Grocery");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();


            string con = "Data Source=ABDALHADI; Initial Catalog=EcoStore; Integrated Security=true;";
            SqlConnection sql = new SqlConnection(con);
            string cmd = "SELECT ItemName, Quantity, Category FROM GroceryItem";
            SqlCommand sqlCommand = new SqlCommand(cmd, sql);

            try
            {
                sql.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ItemName"].ToString());
                    item.SubItems.Add(reader["Quantity"].ToString());
                    item.SubItems.Add(reader["Category"].ToString());
                    listView1.Items.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }
    }
}
