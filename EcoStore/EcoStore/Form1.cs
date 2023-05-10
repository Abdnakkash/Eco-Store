using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace EcoStore
{
    public partial class EcoStore : Form
    {


        public EcoStore()
        {
            InitializeComponent();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void LogInBt_Click(object sender, EventArgs e)
        {
            string con = "Data Source=ABDALHADI; Initial Catalog=EcoStore; Integrated Security = true;";
            SqlConnection sql = new SqlConnection(con);

            string user = UserName.Text;
            string pass = password.Text;


            string cmd = "SELECT * FROM Register WHERE UserName = '" + user + "' AND Password = '" + pass + "'";
            SqlCommand sqlCommand = new SqlCommand(cmd, sql);

            try
            {

                sql.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    user = reader["UserName"].ToString();
                    MessageBox.Show("Welcome Back " + user);

                    this.Hide();

                    Home home = new Home();
                    home.nameUser = user;
                    home.Show();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { sql.Close(); }

            string admin = "SELECT * FROM Admin WHERE Admin = '" + user + "' AND Password = '" + pass + "'";
            SqlCommand Admin = new SqlCommand(admin, sql);

            try
            {
                sql.Open();
                SqlDataReader reader1 = Admin.ExecuteReader();

                if (reader1.Read())
                {
                    user = reader1["Admin"].ToString();
                    MessageBox.Show("Welcome Back " + user);

                    this.Hide();

                    Admin admin1 = new Admin();
                    admin1.nameUser = user;
                    admin1.Show();

                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { sql.Close(); }

        }

        private void EcoStore_Load(object sender, EventArgs e)
        {

        }
    }
}