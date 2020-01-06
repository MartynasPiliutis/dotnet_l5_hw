namespace WindowsFormsApp4
{
    partial class Form1
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
            this.lb_1sem = new System.Windows.Forms.Label();
            this.lb_2sem = new System.Windows.Forms.Label();
            this.lb_3sem = new System.Windows.Forms.Label();
            this.lb_pazymiai = new System.Windows.Forms.Label();
            this.lb_vidurkis = new System.Windows.Forms.Label();
            this.tb_1sem = new System.Windows.Forms.TextBox();
            this.tb_2sem = new System.Windows.Forms.TextBox();
            this.tb_3sem = new System.Windows.Forms.TextBox();
            this.tb_pazymiai = new System.Windows.Forms.TextBox();
            this.tb_vidurkis = new System.Windows.Forms.TextBox();
            this.bt_input = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_1sem
            // 
            this.lb_1sem.AutoSize = true;
            this.lb_1sem.Location = new System.Drawing.Point(8, 70);
            this.lb_1sem.Name = "lb_1sem";
            this.lb_1sem.Size = new System.Drawing.Size(88, 13);
            this.lb_1sem.TabIndex = 0;
            this.lb_1sem.Text = "Pirmas semestras";
            // 
            // lb_2sem
            // 
            this.lb_2sem.AutoSize = true;
            this.lb_2sem.Location = new System.Drawing.Point(8, 96);
            this.lb_2sem.Name = "lb_2sem";
            this.lb_2sem.Size = new System.Drawing.Size(87, 13);
            this.lb_2sem.TabIndex = 1;
            this.lb_2sem.Text = "Antras semestras";
            // 
            // lb_3sem
            // 
            this.lb_3sem.AutoSize = true;
            this.lb_3sem.Location = new System.Drawing.Point(8, 122);
            this.lb_3sem.Name = "lb_3sem";
            this.lb_3sem.Size = new System.Drawing.Size(92, 13);
            this.lb_3sem.TabIndex = 2;
            this.lb_3sem.Text = "Trecias semestras";
            // 
            // lb_pazymiai
            // 
            this.lb_pazymiai.AutoSize = true;
            this.lb_pazymiai.Location = new System.Drawing.Point(8, 204);
            this.lb_pazymiai.Name = "lb_pazymiai";
            this.lb_pazymiai.Size = new System.Drawing.Size(94, 13);
            this.lb_pazymiai.TabIndex = 3;
            this.lb_pazymiai.Text = "Semestru pazymiai";
            // 
            // lb_vidurkis
            // 
            this.lb_vidurkis.AutoSize = true;
            this.lb_vidurkis.Location = new System.Drawing.Point(132, 204);
            this.lb_vidurkis.Name = "lb_vidurkis";
            this.lb_vidurkis.Size = new System.Drawing.Size(90, 13);
            this.lb_vidurkis.TabIndex = 4;
            this.lb_vidurkis.Text = "Semestru vidurkis";
            // 
            // tb_1sem
            // 
            this.tb_1sem.Location = new System.Drawing.Point(135, 63);
            this.tb_1sem.Name = "tb_1sem";
            this.tb_1sem.Size = new System.Drawing.Size(100, 20);
            this.tb_1sem.TabIndex = 5;
            this.tb_1sem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_1sem_KeyPress);
            // 
            // tb_2sem
            // 
            this.tb_2sem.Location = new System.Drawing.Point(135, 89);
            this.tb_2sem.Name = "tb_2sem";
            this.tb_2sem.Size = new System.Drawing.Size(100, 20);
            this.tb_2sem.TabIndex = 6;
            this.tb_2sem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_2sem_KeyPress);
            // 
            // tb_3sem
            // 
            this.tb_3sem.Location = new System.Drawing.Point(135, 115);
            this.tb_3sem.Name = "tb_3sem";
            this.tb_3sem.Size = new System.Drawing.Size(100, 20);
            this.tb_3sem.TabIndex = 7;
            this.tb_3sem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_3sem_KeyPress);
            // 
            // tb_pazymiai
            // 
            this.tb_pazymiai.Location = new System.Drawing.Point(11, 229);
            this.tb_pazymiai.Multiline = true;
            this.tb_pazymiai.Name = "tb_pazymiai";
            this.tb_pazymiai.Size = new System.Drawing.Size(100, 78);
            this.tb_pazymiai.TabIndex = 8;
            // 
            // tb_vidurkis
            // 
            this.tb_vidurkis.Location = new System.Drawing.Point(135, 229);
            this.tb_vidurkis.Name = "tb_vidurkis";
            this.tb_vidurkis.Size = new System.Drawing.Size(100, 20);
            this.tb_vidurkis.TabIndex = 9;
            // 
            // bt_input
            // 
            this.bt_input.Location = new System.Drawing.Point(86, 168);
            this.bt_input.Name = "bt_input";
            this.bt_input.Size = new System.Drawing.Size(75, 23);
            this.bt_input.TabIndex = 10;
            this.bt_input.Text = "Suvesti";
            this.bt_input.UseVisualStyleBackColor = true;
            this.bt_input.Click += new System.EventHandler(this.bt_input_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 376);
            this.Controls.Add(this.bt_input);
            this.Controls.Add(this.tb_vidurkis);
            this.Controls.Add(this.tb_pazymiai);
            this.Controls.Add(this.tb_3sem);
            this.Controls.Add(this.tb_2sem);
            this.Controls.Add(this.tb_1sem);
            this.Controls.Add(this.lb_vidurkis);
            this.Controls.Add(this.lb_pazymiai);
            this.Controls.Add(this.lb_3sem);
            this.Controls.Add(this.lb_2sem);
            this.Controls.Add(this.lb_1sem);
            this.Name = "Form1";
            this.Text = "Vidurkio skaiciuokle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_1sem;
        private System.Windows.Forms.Label lb_2sem;
        private System.Windows.Forms.Label lb_3sem;
        private System.Windows.Forms.Label lb_pazymiai;
        private System.Windows.Forms.Label lb_vidurkis;
        private System.Windows.Forms.TextBox tb_1sem;
        private System.Windows.Forms.TextBox tb_2sem;
        private System.Windows.Forms.TextBox tb_3sem;
        private System.Windows.Forms.TextBox tb_pazymiai;
        private System.Windows.Forms.TextBox tb_vidurkis;
        private System.Windows.Forms.Button bt_input;
    }
}

