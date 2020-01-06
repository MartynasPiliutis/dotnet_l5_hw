namespace WindowsFormsApp2
{
    partial class f1_10kartu
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
            this.bt_trypk = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_trypk
            // 
            this.bt_trypk.Location = new System.Drawing.Point(12, 9);
            this.bt_trypk.Name = "bt_trypk";
            this.bt_trypk.Size = new System.Drawing.Size(220, 23);
            this.bt_trypk.TabIndex = 0;
            this.bt_trypk.Text = "TRYPK";
            this.bt_trypk.UseVisualStyleBackColor = true;
            this.bt_trypk.Click += new System.EventHandler(this.bt_trypk_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 307);
            this.textBox1.TabIndex = 1;
            // 
            // f1_10kartu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 373);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_trypk);
            this.Name = "f1_10kartu";
            this.Text = "Desimt kartu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_trypk;
        private System.Windows.Forms.TextBox textBox1;
    }
}

