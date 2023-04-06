using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Test1
{
    public partial class Drinks : Form
    {
        public Drinks()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Drinks_Load(object sender, EventArgs e)
        {

        }
        public int PD = 0;
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (comboBoxTea.SelectedItem != null)
            {
                PD += int.Parse(comboBoxTea.SelectedItem.ToString()) * int.Parse(PriceTea.Text);
            }
            if (comboBoxLatte.SelectedItem != null)
            {
                PD += int.Parse(comboBoxLatte.SelectedItem.ToString()) * int.Parse(PriceLatte.Text);
            }
            if (comboBoxCoffe.SelectedItem != null)
            {
                PD += int.Parse(comboBoxCoffe.SelectedItem.ToString()) * int.Parse(PriceCoffe.Text);
            }
            if (comboBoxAmricano.SelectedItem != null)
            {
                PD += int.Parse(comboBoxAmricano.SelectedItem.ToString()) * int.Parse(PriceAmricano.Text);
            }
            if (comboBoxEspresso.SelectedItem != null)
            {
                PD += int.Parse(comboBoxEspresso.SelectedItem.ToString()) * int.Parse(PriceEspresso.Text);
            }
            if (comboBoxColdLatte.SelectedItem != null)
            {
                PD += int.Parse(comboBoxColdLatte.SelectedItem.ToString()) * int.Parse(PriceColdLatte.Text);
            }
            if (comboBoxGlace.SelectedItem != null)
            {
                PD += int.Parse(comboBoxGlace.SelectedItem.ToString()) * int.Parse(PriceGlace.Text);
            }
            if (comboBoxMocha.SelectedItem != null)
            {
                PD += int.Parse(comboBoxMocha.SelectedItem.ToString()) * int.Parse(PriceMocha.Text);
            }
            if (comboBoxColdEspresso.SelectedItem != null)
            {
                PD += int.Parse(comboBoxColdEspresso.SelectedItem.ToString()) * int.Parse(PriceColdEspresso.Text);
            }
            if (comboBoxCotado.SelectedItem != null)
            {
                PD += int.Parse(comboBoxCotado.SelectedItem.ToString()) * int.Parse(PriceCotado.Text);
            }
            string DrinkPrice =  Convert.ToString(PD);
            Total_Price_Value.Text = DrinkPrice;

            comboBoxTea.SelectedItem = null;
            comboBoxTea.Text = "0";
            comboBoxCoffe.SelectedItem = null;
            comboBoxCoffe.Text = "0";
            comboBoxLatte.SelectedItem= null;
            comboBoxLatte.Text = "0";
            comboBoxAmricano.SelectedItem = null;
            comboBoxAmricano.Text = "0";
            comboBoxEspresso.SelectedItem = null;
            comboBoxEspresso.Text = "0";
            comboBoxColdLatte.SelectedItem = null;
            comboBoxColdLatte.Text = "0";
            comboBoxGlace.SelectedItem = null;
            comboBoxGlace.Text = "0";
            comboBoxMocha.SelectedItem = null;
            comboBoxMocha.Text = "0";
            comboBoxColdEspresso.SelectedItem = null;
            comboBoxColdEspresso.Text = "0";
            comboBoxCotado.SelectedItem = null;
            comboBoxCotado.Text = "0";
           
            Booking_form Booking = (Booking_form)Application.OpenForms["Booking_form"];
            this.Hide();
            Booking.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Booking_form Booking = (Booking_form)Application.OpenForms["Booking_form"];
            this.Hide();
            Booking.Show();
        }

        private void Total_Price_Value_Click(object sender, EventArgs e)
        {

        }
    }
}
