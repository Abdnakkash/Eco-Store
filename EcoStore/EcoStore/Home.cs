using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EcoStore
{
    public partial class Home : Form
    {
        private Image img;
        private Image SnackImg;

        public string nameUser { get; set; }
        public string NameFruit { get; set; }
        public string PriceFruit { get; set; }
        public string nameVeggi { get; set; }
        public string PriceVeggi { get; set; }
        public string nameSnack { get; set; }
        public string PriceSnack { get; set; }


        public Home()
        {
            InitializeComponent();

        }

        private void Home_Load(object sender, EventArgs e)
        {
            NameU.Text = nameUser;
            label6.Text = label6.Text + "$";
            label7.Text = label7.Text + "$";
            label8.Text = label8.Text + "$";
            label12.Text = label12.Text + "$";
            label13.Text = label13.Text + "$";
            label14.Text = label14.Text + "$";
            label16.Text = label16.Text + "$";


            img = TomtoBox.Image;
            img = LettceBox.Image;
            img = PotatoBox.Image;

            SnackImg = SnickersBox.Image;
            SnackImg = MilkaBox.Image;
            SnackImg = TwixBox.Image;
            SnackImg = KinderBox.Image;
            SnackImg = MarsBox.Image;
            SnackImg = KitKatBox.Image;


        }


        private void LogOutBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            EcoStore ecoStore = new EcoStore();
            ecoStore.Show();
        }

        private void AddBt_Click(object sender, EventArgs e)
        {

            if (BananaB.Checked && TomatoB.Checked && SnickersB.Checked && MilkaB.Checked)
            {

                Image originalImage = BananaBox.Image;
                Image resizedImage = originalImage.GetThumbnailImage(106, 95, null, IntPtr.Zero);
                NameFruit = label3.Text;
                PriceFruit = label6.Text;

                Image originalImage1 = img;
                Image resizedImage1 = originalImage1.GetThumbnailImage(106, 95, null, IntPtr.Zero);
                nameVeggi = label9.Text;
                PriceVeggi = label12.Text;


                Image snack = SnickersBox.Image;
                Image snack1 = MilkaBox.Image;

                Cart cart = new Cart();
                cart.FruitImg = BananaBox.Image;
                cart.VeggiImg = TomtoBox.Image;

                cart.SnackImg1 = SnickersBox.Image;
                cart.SnackImg = MilkaBox.Image;

                cart.nameVeggi = nameVeggi;
                cart.PriceVeggi = PriceVeggi;

                cart.nameSnack1 = "Snickers";
                cart.nameSnack = "Milka";

                cart.PriceSnack = label16.Text;

                cart.nameFruit = NameFruit;
                cart.PriceFruit = PriceFruit;

                MessageBox.Show("Your Item Was Added to the cart");
                BananaB.Checked = false;
                TomatoB.Checked = false;
                SnickersB.Checked = false;
                MilkaB.Checked = false;
                this.Hide();
                cart.Show();

            }
            else if (StrawberryB.Checked && LettceB.Checked && KitKatB.Checked && TwixB.Checked)
            {

                Image originalImage = StrawberryBox.Image;
                Image resizedImage = originalImage.GetThumbnailImage(106, 95, null, IntPtr.Zero);
                NameFruit = label4.Text;
                PriceFruit = label7.Text;

                Image originalImage1 = img;
                Image resizedImage1 = originalImage1.GetThumbnailImage(106, 95, null, IntPtr.Zero);
                nameVeggi = label10.Text;
                PriceVeggi = label13.Text;


                Image snack = KitKatBox.Image;
                Image snack1 = TwixBox.Image;

                Cart cart = new Cart();
                cart.FruitImg = StrawberryBox.Image;
                cart.VeggiImg = LettceBox.Image;

                cart.SnackImg1 = KitKatBox.Image;
                cart.SnackImg = TwixBox.Image;

                cart.nameVeggi = nameVeggi;
                cart.PriceVeggi = PriceVeggi;

                cart.nameSnack1 = "KitKat";
                cart.nameSnack = "Twix";

                cart.PriceSnack = label16.Text;

                cart.nameFruit = NameFruit;
                cart.PriceFruit = PriceFruit;

                MessageBox.Show("Your Item Was Added to the cart");
                StrawberryB.Checked = false;
                LettceB.Checked = false;
                TwixB.Checked = false;
                KitKatB.Checked = false;
                this.Hide();
                cart.Show();

            }
            else if (AvocadoB.Checked && PotatoB.Checked && KinderB.Checked && MarsB.Checked)
            {

                Image originalImage = AvocadoBox.Image;
                Image resizedImage = originalImage.GetThumbnailImage(106, 95, null, IntPtr.Zero);
                NameFruit = label5.Text;
                PriceFruit = label8.Text;

                Image originalImage1 = img;
                Image resizedImage1 = originalImage1.GetThumbnailImage(106, 95, null, IntPtr.Zero);
                nameVeggi = label11.Text;
                PriceVeggi = label14.Text;


                Image snack = KinderBox.Image;
                Image snack1 = MarsBox.Image;

                Cart cart = new Cart();
                cart.FruitImg = AvocadoBox.Image;
                cart.VeggiImg = PotatoBox.Image;

                cart.SnackImg1 = KinderBox.Image;
                cart.SnackImg = MarsBox.Image;

                cart.nameVeggi = nameVeggi;
                cart.PriceVeggi = PriceVeggi;

                cart.nameSnack1 = "Kinder";
                cart.nameSnack = "Mars";

                cart.PriceSnack = label16.Text;

                cart.nameFruit = NameFruit;
                cart.PriceFruit = PriceFruit;

                MessageBox.Show("Your Item Was Added to the cart");
                AvocadoB.Checked = false;
                PotatoB.Checked = false;
                KinderB.Checked = false;
                MarsB.Checked = false;
                this.Hide();
                cart.Show();

            } else
            {
                MessageBox.Show("Your Cart Is Empty");
            }
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

    }
}
    
