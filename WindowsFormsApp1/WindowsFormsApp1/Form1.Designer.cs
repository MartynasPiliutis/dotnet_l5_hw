namespace WindowsFormsApp1
{
    partial class Pasisveikinimas
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
            this.tb_output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_input
            // 
            this.bt_input.Location = new System.Drawing.Point(12, 12);
            this.bt_input.Name = "bt_input";
            this.bt_input.Size = new System.Drawing.Size(235, 23);
            this.bt_input.TabIndex = 0;
            this.bt_input.Text = "PRADETI";
            this.bt_input.UseVisualStyleBackColor = true;
            this.bt_input.Click += new System.EventHandler(this.bt_input_Click);
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(12, 41);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(235, 123);
            this.tb_output.TabIndex = 1;
            this.tb_output.TextChanged += new System.EventHandler(this.tb_output_TextChanged);
            // 
            // Pasisveikinimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 184);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.bt_input);
            this.Name = "Pasisveikinimas";
            this.Text = "Pasisveikinimas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_input;
        private System.Windows.Forms.TextBox tb_output;
    }
}

