namespace WindowsFormsApp3
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
            this.bt_input = new System.Windows.Forms.Button();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_input
            // 
            this.bt_input.Location = new System.Drawing.Point(12, 45);
            this.bt_input.Name = "bt_input";
            this.bt_input.Size = new System.Drawing.Size(178, 23);
            this.bt_input.TabIndex = 0;
            this.bt_input.Text = "Tikrinti";
            this.bt_input.UseVisualStyleBackColor = true;
            this.bt_input.Click += new System.EventHandler(this.bt_input_Click);
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(12, 12);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(178, 20);
            this.tb_input.TabIndex = 1;
            this.tb_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_input_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 88);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.bt_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_input;
        private System.Windows.Forms.TextBox tb_input;
    }
}

