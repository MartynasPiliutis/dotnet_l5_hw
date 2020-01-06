using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Pasisveikinimas : Form
    {
        public Pasisveikinimas()
        {
            InitializeComponent();
        }

        private void tb_output_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_input_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            tb_output.Text = $"Sveiki. As esu Martynas!";
            tb_output.AppendText ($"\r\nSiandien yra {data}");
            
        }
    }
}
