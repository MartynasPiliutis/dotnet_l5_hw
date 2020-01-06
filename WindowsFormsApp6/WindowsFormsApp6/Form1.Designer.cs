namespace WindowsFormsApp6
{
    partial class form_pazymiai
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
            this.lb_pazymys = new System.Windows.Forms.Label();
            this.tb_pazymys = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_remove = new System.Windows.Forms.Button();
            this.lbx_Pazymiai = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_pazymys
            // 
            this.lb_pazymys.AutoSize = true;
            this.lb_pazymys.Location = new System.Drawing.Point(30, 51);
            this.lb_pazymys.Name = "lb_pazymys";
            this.lb_pazymys.Size = new System.Drawing.Size(48, 13);
            this.lb_pazymys.TabIndex = 0;
            this.lb_pazymys.Text = "Pazymys";
            // 
            // tb_pazymys
            // 
            this.tb_pazymys.Location = new System.Drawing.Point(84, 48);
            this.tb_pazymys.Name = "tb_pazymys";
            this.tb_pazymys.Size = new System.Drawing.Size(136, 20);
            this.tb_pazymys.TabIndex = 1;
            this.tb_pazymys.TextChanged += new System.EventHandler(this.tb_pazymys_TextChanged);
            this.tb_pazymys.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pazymys_KeyPress);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(33, 91);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(187, 23);
            this.bt_add.TabIndex = 2;
            this.bt_add.Text = "Irasyti pazymi";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_remove
            // 
            this.bt_remove.Location = new System.Drawing.Point(33, 120);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.Size = new System.Drawing.Size(187, 23);
            this.bt_remove.TabIndex = 3;
            this.bt_remove.Text = "Pasalinti pazymi";
            this.bt_remove.UseVisualStyleBackColor = true;
            this.bt_remove.Click += new System.EventHandler(this.bt_remove_Click);
            // 
            // lbx_Pazymiai
            // 
            this.lbx_Pazymiai.FormattingEnabled = true;
            this.lbx_Pazymiai.Location = new System.Drawing.Point(240, 48);
            this.lbx_Pazymiai.Name = "lbx_Pazymiai";
            this.lbx_Pazymiai.Size = new System.Drawing.Size(120, 212);
            this.lbx_Pazymiai.TabIndex = 4;
            // 
            // form_pazymiai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 294);
            this.Controls.Add(this.lbx_Pazymiai);
            this.Controls.Add(this.bt_remove);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tb_pazymys);
            this.Controls.Add(this.lb_pazymys);
            this.Name = "form_pazymiai";
            this.Text = "Pazymiai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_pazymys;
        private System.Windows.Forms.TextBox tb_pazymys;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_remove;
        private System.Windows.Forms.ListBox lbx_Pazymiai;
    }
}

