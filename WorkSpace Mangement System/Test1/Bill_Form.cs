using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test1
{
    public partial class Bill_Form : Form
    {
        public Bill_Form()
        {
            InitializeComponent();
        }

        private void Bill_Form_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }
      
        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void Drinks_Price_Click(object sender, EventArgs e)
        {

        }

        private void Total_Price_Value_Click(object sender, EventArgs e)
        {
            String Time_Price= Time.Text;
            String Drink_Price = Drinks_Price.Text;
            int Total_price = (Convert.ToInt32(Time_Price)) + (Convert.ToInt32(Drink_Price));
            Total_Price_Value.Text = Convert.ToString(Total_price);
        }

        private void check_out_Click(object sender, EventArgs e)
        {
            Form1 Mainform = (Form1)Application.OpenForms["Form1"];
            
            this.Hide();
            Mainform.Show();
        }
    }
}
