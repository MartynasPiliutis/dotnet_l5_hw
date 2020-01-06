using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class form_pazymiai : Form
    {
        public form_pazymiai()
        {
            InitializeComponent();
        }

        private void tb_pazymys_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_pazymys_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Negalima reiksme...");
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            int balas = Convert.ToInt32(tb_pazymys.Text);
            if (balas < 1 || balas > 10)
            {
                MessageBox.Show("Neteisingai ivestas pazymys...");
                return;
            }

            lbx_Pazymiai.Items.Add($"{balas}");
        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            if (lbx_Pazymiai.SelectedItem == null)
            {
                MessageBox.Show("Nepazymeta reiksme...");
                return;
            }

            lbx_Pazymiai.Items.Remove(lbx_Pazymiai.Items[lbx_Pazymiai.SelectedIndex]);
        }
    }
}
