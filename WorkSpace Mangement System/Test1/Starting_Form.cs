using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Starting_Form : Form
    {
        public Starting_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Booking_form Booking = new Booking_form();
            Form1 MainForm = new Form1();
            this.Hide();
            Booking.Show();
            Booking.Hide();
            MainForm.Show();
        }

        private void Starting_Form_Load(object sender, EventArgs e)
        {
           
        }
    }
}
