namespace WindowsFormsApp5
{
    partial class f_temp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_c = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.bt_convert = new System.Windows.Forms.Button();
            this.lb_f = new System.Windows.Forms.Label();
            this.lb_k = new System.Windows.Forms.Label();
            this.lb_r = new System.Windows.Forms.Label();
            this.lb_note = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_c
            // 
            this.lb_c.AutoSize = true;
            this.lb_c.Location = new System.Drawing.Point(114, 28);
            this.lb_c.Name = "lb_c";
            this.lb_c.Size = new System.Drawing.Size(18, 13);
            this.lb_c.TabIndex = 0;
            this.lb_c.Text = "*C";
            this.lb_c.Click += new System.EventHandler(this.lb_c_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Location = new System.Drawing.Point(8, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(8, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(8, 132);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bt_convert
            // 
            this.bt_convert.Location = new System.Drawing.Point(8, 51);
            this.bt_convert.Name = "bt_convert";
            this.bt_convert.Size = new System.Drawing.Size(100, 23);
            this.bt_convert.TabIndex = 5;
            this.bt_convert.Text = "Konvertuoti";
            this.bt_convert.UseVisualStyleBackColor = true;
            this.bt_convert.Click += new System.EventHandler(this.bt_convert_Click);
            // 
            // lb_f
            // 
            this.lb_f.AutoSize = true;
            this.lb_f.Location = new System.Drawing.Point(114, 83);
            this.lb_f.Name = "lb_f";
            this.lb_f.Size = new System.Drawing.Size(13, 13);
            this.lb_f.TabIndex = 6;
            this.lb_f.Text = "F";
            // 
            // lb_k
            // 
            this.lb_k.AutoSize = true;
            this.lb_k.Location = new System.Drawing.Point(114, 109);
            this.lb_k.Name = "lb_k";
            this.lb_k.Size = new System.Drawing.Size(14, 13);
            this.lb_k.TabIndex = 7;
            this.lb_k.Text = "K";
            this.lb_k.Click += new System.EventHandler(this.lb_k_Click);
            // 
            // lb_r
            // 
            this.lb_r.AutoSize = true;
            this.lb_r.Location = new System.Drawing.Point(114, 135);
            this.lb_r.Name = "lb_r";
            this.lb_r.Size = new System.Drawing.Size(15, 13);
            this.lb_r.TabIndex = 8;
            this.lb_r.Text = "R";
            // 
            // lb_note
            // 
            this.lb_note.AutoSize = true;
            this.lb_note.Location = new System.Drawing.Point(5, 9);
            this.lb_note.Name = "lb_note";
            this.lb_note.Size = new System.Drawing.Size(106, 13);
            this.lb_note.TabIndex = 9;
            this.lb_note.Text = "Iveskite temperatura:";
            this.lb_note.Click += new System.EventHandler(this.label5_Click);
            // 
            // f_temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 175);
            this.Controls.Add(this.lb_note);
            this.Controls.Add(this.lb_r);
            this.Controls.Add(this.lb_k);
            this.Controls.Add(this.lb_f);
            this.Controls.Add(this.bt_convert);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_c);
            this.Name = "f_temp";
            this.Text = "Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_c;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button bt_convert;
        private System.Windows.Forms.Label lb_f;
        private System.Windows.Forms.Label lb_k;
        private System.Windows.Forms.Label lb_r;
        private System.Windows.Forms.Label lb_note;
    }
}

