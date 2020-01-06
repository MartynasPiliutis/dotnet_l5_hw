using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_1sem_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Neteisinga reiksme...");
            }
        }

        private void tb_2sem_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Neteisinga reiksme...");
            }
        }

        private void tb_3sem_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Neteisinga reiksme...");
            }
        }

        private void bt_input_Click(object sender, EventArgs e)
        {
            if (tb_1sem.Text == "" || tb_2sem.Text == "" || tb_3sem.Text == "")
            {
                MessageBox.Show("Ne visu semestru pazymiai pateikti...");
                return;
            }

            int sem1 = Convert.ToInt32(tb_1sem.Text);
            int sem2 = Convert.ToInt32(tb_2sem.Text);
            int sem3 = Convert.ToInt32(tb_3sem.Text);

            if (sem1 < 1 || sem1 > 10)
            {
                MessageBox.Show("Neteisinga pirmojo semestro reiksme...");
                return;
            }

            if (sem2 < 1 || sem2 > 10)
            {
                MessageBox.Show("Neteisinga antrojo semestro reiksme...");
                return;
            }

            if (sem3 < 1 || sem3 > 10)
            {
                MessageBox.Show("Neteisinga treciojo semestro reiksme...");
                return;
            }

            tb_pazymiai.Text = $"I semestras: {sem1}";
            tb_pazymiai.AppendText($"\r\nII semestras: {sem2}");
            tb_pazymiai.AppendText($"\r\nIII semestras: {sem3}");

            double suma = sem1 + sem2 + sem3;
            tb_vidurkis.Text = $"{Math.Round(suma / 3, 2)}";
        }
    }
}
