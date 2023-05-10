using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EcoStore
{
    public partial class Cart : Form
    {
        public Image FruitImg { get; set; }
        public Image VeggiImg { get; set; }
        public Image SnackImg1 { get; set; }
        public Image SnackImg { get; set; }
        public string nameVeggi { get; set; }
        public string PriceVeggi { get; set; }
        public string nameSnack { get; set; }
        public string nameSnack1 { get; set; }
        public string PriceSnack { get; set; }
        public string nameFruit { get; set; }
        public string PriceFruit { get; set; }

        //public double Delivery { get; set; }
        public double price { get; set; }


        public Cart()
        {
            InitializeComponent();


        }

        private void Cart_Load(object sender, EventArgs e)
        {
            /*Pass Values to ComboBox1*/
            CountryC.Items.Add("USA");
            CountryC.Items.Add("Canada");
            CountryC.Items.Add("Lebanon");
            CountryC.Items.Add("United Kingdom");
            CountryC.Items.Add("Syria");


            if (FruitImg != null)
            {
                pictureBox1.Image = FruitImg;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }

            if (VeggiImg != null)
            {

                pictureBox2.Image = VeggiImg;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            }

            if (SnackImg != null)
            {

                pictureBox3.Image = SnackImg;
                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;


            }

            if (SnackImg1 != null)
            {

                pictureBox4.Image = SnackImg1;
                pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            }

                if (nameFruit != null)
                {
                    label2.Text = nameFruit;

                }

                if (nameSnack != null)
                {
                    label4.Text = nameSnack;


                }

                if (nameSnack1 != null)
                {

                    label5.Text = nameSnack1;

                }

                if (PriceSnack != null)
                {
                    textBox3.Text = PriceSnack;
                    textBox4.Text = PriceSnack;

                }

                if (PriceFruit != null)
                {
                    textBox1.Text = PriceFruit;

                }

                if (nameVeggi != null)
                {
                    label3.Text = nameVeggi;

                }

                if (PriceVeggi != null)
                {
                    textBox2.Text = PriceVeggi;

                }


                numericUpDown1.Value = 1;
                numericUpDown1.Maximum = 10;

                numericUpDown2.Value = 1;
                numericUpDown2.Maximum = 10;

                numericUpDown3.Value = 1;
                numericUpDown3.Maximum = 10;

                numericUpDown4.Value = 1;
                numericUpDown4.Maximum = 10;

                double Delivery = 0.50;
                DeliveryBox.Text = Delivery.ToString();
         
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double quantity = (double)numericUpDown1.Value;

            double FruitPrice = double.Parse(PriceFruit.Replace("$", ""));

            double price = quantity * FruitPrice;

            textBox1.Text = price.ToString("0.00") + "$";
            CalculateSum();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double quantity = (double)numericUpDown2.Value;

            double VeggiPrice = double.Parse(PriceVeggi.Replace("$", ""));

            double price = quantity * VeggiPrice;

            textBox2.Text = price.ToString("0.00") + "$";
            CalculateSum();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double quantity = (double)numericUpDown3.Value;

            double SnackPrice = double.Parse(PriceSnack.Replace("$", ""));

            double price = quantity * SnackPrice;

            textBox3.Text = price.ToString("0.00") + "$";
            CalculateSum();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double quantity = (double)numericUpDown4.Value;

            double SnackPrice = double.Parse(PriceSnack.Replace("$", ""));

            double price = quantity * SnackPrice;

            textBox4.Text = price.ToString("0.00") + "$";
            CalculateSum();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (CountryC.SelectedIndex == 0)
            {

                /*double Delivery = 0.50;

                DeliveryBox.Text = Delivery.ToString();*/


            }
            else if (CountryC.SelectedIndex == 1)
            {
               /* double Delivery = 0.80;

                DeliveryBox.Text = Delivery.ToString();*/

            }
            else if (CountryC.SelectedIndex == 2)
            {

                /*double Delivery = 0.55;

                DeliveryBox.Text = Delivery.ToString();*/

            }
            else if (CountryC.SelectedIndex == 3)
            {

                /*double Delivery = 0.65;

                DeliveryBox.Text = Delivery.ToString();*/

            }
            else if (CountryC.SelectedIndex == 4)
            {

                /*double Delivery = 0.75;

                DeliveryBox.Text = Delivery.ToString() *//*+ "$"*//*;*/

            }
            else if (CountryC.SelectedIndex == 5)
            {

                /*double Delivery = 0.85;

                DeliveryBox.Text = Delivery.ToString() *//*+ "$"*//*;*/

            }
            /*CalculateSum();*/

        }

        private void PriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateSum()
        {
            double value1 = double.Parse(textBox1.Text.Replace("$", ""));
            double value2 = double.Parse(textBox2.Text.Replace("$", ""));
            double value3 = double.Parse(textBox3.Text.Replace("$", ""));
            double value4 = double.Parse(textBox4.Text.Replace("$", ""));

            double sum = value1 + value2 + value3 + value4;
            sum = Math.Round(sum, 2);
            ;
            PriceBox.Text = sum.ToString() + "$";

            double Vat = sum * 1.11;
            Vat = Math.Round(Vat, 2);
            VatBox.Text = Vat.ToString() + "$";

            double d = 0.50; 
            double total = Vat + d;
            total = Math.Round(total, 2);
            TotalBox.Text = total.ToString() + "$";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string con = "Data Source=ABDALHADI; Initial Catalog=EcoStore; Integrated Security = true;";
            SqlConnection sql = new SqlConnection(con);

            string User = UserText.Text;
            string ph = PhoneNumberText.Text;
            string ad = AddressText.Text;
            string Price = TotalBox.Text;
            string cn = CountryC.Text;

            int quantity1 = (int)numericUpDown1.Value;
            int quantity2 = (int)numericUpDown2.Value;
            int quantity3 = (int)numericUpDown3.Value;
            int quantity4 = (int)numericUpDown4.Value;

            string cmd = "INSERT INTO Orders(UserName,PhoneNumber,Price,Address,Country,Fruit,QuantityF,Veggi,QuantityV,Snack,QuantityS,Snack2,QuantityS1)";
            cmd += "VALUES('" + User + "','" + ph + "','" + Price + "','" + ad + "','" + cn + "','" + label2.Text + "','" + quantity1 +
             "','" + label3.Text + "','" + quantity2 + "','" + label4.Text + "','" + quantity3 + "','" + label5.Text + "','" + quantity4 + "')";

            SqlCommand sqlCommand = new SqlCommand(cmd, sql);

            try
            {

                if (string.IsNullOrEmpty(User) || string.IsNullOrEmpty(ph) || string.IsNullOrEmpty(cn))
                {

                    MessageBox.Show("Please Enter All Field");
                }
                else
                {

                    sql.Open();
                    sqlCommand.ExecuteNonQuery();
                    
                    
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Please Enter Your UserName" + ex.Message);
            }
        
            string Quantity = "SELECT Quantity FROM GroceryItem Where ItemName = @nameFruit";
            string Quantity1 = "SELECT Quantity FROM GroceryItem Where ItemName = @nameVeggi";
            string Quantity2 = "SELECT Quantity FROM GroceryItem Where ItemName = @nameSnack";
            string Quantity3 = "SELECT Quantity FROM GroceryItem Where ItemName = @nameSnack1";

            string update1 = "UPDATE GroceryItem SET Quantity = @quantity1 WHERE ItemName = @nameFruit";
            string update2 = "UPDATE GroceryItem SET Quantity = @quantity2 WHERE ItemName = @nameVeggi";
            string update3 = "UPDATE GroceryItem SET Quantity = @quantity3 WHERE ItemName = @nameSnack";
            string update4 = "UPDATE GroceryItem SET Quantity = @quantity4 WHERE ItemName = @nameSnack1";
            
            SqlCommand command = new SqlCommand(Quantity, sql);
            SqlCommand command2 = new SqlCommand(Quantity1, sql);
            SqlCommand command3 = new SqlCommand(Quantity2, sql);
            SqlCommand command4 = new SqlCommand(Quantity3, sql);
            
            SqlCommand updateCommand = new SqlCommand(update1, sql);
            SqlCommand Update1 = new SqlCommand(update2, sql);
            SqlCommand Update2 = new SqlCommand(update3, sql);
            SqlCommand Update3 = new SqlCommand(update4, sql);

            try {
                command.Parameters.AddWithValue("@nameFruit", nameFruit);
                int currentQuantity1 = (int)command.ExecuteScalar();

                command2.Parameters.AddWithValue("@nameVeggi", nameVeggi);
                int currentQuantity2 = (int)command2.ExecuteScalar();

                command3.Parameters.AddWithValue("@nameSnack", nameSnack);
                int currentQuantity3 = (int)command.ExecuteScalar();

                command4.Parameters.AddWithValue("@nameSnack1", nameSnack1);
                int currentQuantity4 = (int)command4.ExecuteScalar();

                if (currentQuantity1 < quantity1)
                { 

                    updateCommand.Parameters.AddWithValue("nameFruit", nameFruit);
                    updateCommand.Parameters.AddWithValue("@quantity1", currentQuantity1 - quantity1);

                    command.ExecuteNonQuery();
                    updateCommand.ExecuteNonQuery();

                    MessageBox.Show($"{nameFruit} is out of stock.");
                    return;
                }

                if (currentQuantity2 < quantity2)
                {
                    Update1.Parameters.AddWithValue("nameVeggi", nameVeggi);
                    Update1.Parameters.AddWithValue("@quantity2", currentQuantity2 - quantity2);

                    command2.ExecuteNonQuery();
                    Update1.ExecuteNonQuery();

                    MessageBox.Show($"{nameVeggi} is out of stock.");
                    return;
                }

                if (currentQuantity3 < quantity3)
                {
                    Update2.Parameters.AddWithValue("nameSnack", nameSnack);
                    Update2.Parameters.AddWithValue("@quantity3", currentQuantity3 - quantity3);
                    command3.ExecuteNonQuery();
                    Update2.ExecuteNonQuery();

                    MessageBox.Show($"{nameSnack} is out of stock.");
                    return;
                }
                if (currentQuantity4 < quantity4)
                {
                    Update3.Parameters.AddWithValue("nameSnack1", nameSnack1);
                    Update3.Parameters.AddWithValue("@quantity4", currentQuantity4 - quantity4);
                    command4.ExecuteNonQuery();
                    Update3.ExecuteNonQuery();

                    MessageBox.Show($"{nameSnack1} is out of stock.");
                    return;
                }

                   

                MessageBox.Show("Your Order In The Way");
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sql.Close(); }
        }
    }
}

