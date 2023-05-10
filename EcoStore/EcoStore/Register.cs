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
    public partial class Register : Form
    {

        public Register()
        {
            InitializeComponent();


            ComboBox.Items.Add("USA");
            ComboBox.Items.Add("Canada");
            ComboBox.Items.Add("Lebanon");
            ComboBox.Items.Add("United Kingdom");
            ComboBox.Items.Add("Syria");


        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegisterBt_Click(object sender, EventArgs e)
        {
            string con = "Data Source=ABDALHADI; Initial Catalog=EcoStore; Integrated Security = true;";
            SqlConnection sql = new SqlConnection(con);

            string fn = FirstName.Text;
            string ln = LastName.Text;
            string User = UserName.Text;
            string Em = Email.Text;
            string pass = Password.Text;
            string nm = NumberPhone.Text;
            string dt = DateOfBirth.Text;
            string cu = ComboBox.Text;
            string ad = Address.Text;

            string cmd = "INSERT INTO Register(FirstName,LastName,UserName,Email,Password,MobilePhone,DateOfBirth,Country,Address)";
            cmd += "VALUES('" + fn + "','" + ln + "','" + User + "','" + Em + "','" + pass + "','" + nm + "','" + dt + "','" + cu + "','" + ad + "')";
            SqlCommand sqlCommand = new SqlCommand(cmd, sql);

            try
            {
                if (string.IsNullOrEmpty(fn) || string.IsNullOrEmpty(ln) || string.IsNullOrEmpty(User) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(nm) || string.IsNullOrEmpty(dt) || string.IsNullOrEmpty(cu) || string.IsNullOrEmpty(ad))
                {

                    MessageBox.Show("Please Enter All Field");
                }
                else
                {

                    sql.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Welcome To EcoStore :)");
                    this.Hide();
                    EcoStore ecoStore = new EcoStore();
                    ecoStore.Show();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { sql.Close(); }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            EcoStore ecoStore = new EcoStore();
            ecoStore.Show();
        }
    }
}
