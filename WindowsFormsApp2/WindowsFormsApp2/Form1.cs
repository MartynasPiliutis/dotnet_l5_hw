﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class f1_10kartu : Form
    {
        public f1_10kartu()
        {
            InitializeComponent();
        }

        private void bt_trypk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                textBox1.Text += $"Sveiki. As esu Martynas \r\n";
            }
        }
    }
}
