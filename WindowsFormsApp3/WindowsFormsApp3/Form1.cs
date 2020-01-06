using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Prasau ivesti skaiciu...");
            }
        }

        private void bt_input_Click(object sender, EventArgs e)
        {
            double skaicius = Convert.ToDouble(tb_input.Text);
            
            if (skaicius % 2 == 0)
            {
                MessageBox.Show($"Skaicius {skaicius} yra lyginis");
            }
            else
                MessageBox.Show($"Skaicius {skaicius} yra nelyginis");
        }
    }
}
