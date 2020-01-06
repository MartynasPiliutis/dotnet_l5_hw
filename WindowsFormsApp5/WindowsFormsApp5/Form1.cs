using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class f_temp : Form
    {
        public f_temp()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lb_c_Click(object sender, EventArgs e)
        {

        }

        private void lb_k_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
 
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr !='-' && chr != '.')
            {
                e.Handled = true;
                MessageBox.Show("Negalima reiksme...");
            }
        }

        private void bt_convert_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Nepateikta reiksme...");
                return;
            }

            double celsius = Convert.ToDouble(textBox1.Text);
            double kelvin = Math.Round(celsius + 273.16, 2);
            double farenheit = Math.Round(celsius * 9 / 5 + 32, 2);
            double reaumur = Math.Round(celsius*0.8, 2);

            textBox2.Text = $"{farenheit}";
            textBox3.Text = $"{kelvin}";
            textBox4.Text = $"{reaumur}";
        }
    }
}
