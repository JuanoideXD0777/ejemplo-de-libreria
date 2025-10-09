namespace primer_forms
{
    partial class login
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_unm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_psw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // tb_unm
            // 
            this.tb_unm.Location = new System.Drawing.Point(59, 145);
            this.tb_unm.Name = "tb_unm";
            this.tb_unm.Size = new System.Drawing.Size(243, 22);
            this.tb_unm.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // tb_psw
            // 
            this.tb_psw.Location = new System.Drawing.Point(337, 190);
            this.tb_psw.Name = "tb_psw";
            this.tb_psw.PasswordChar = '_';
            this.tb_psw.Size = new System.Drawing.Size(243, 22);
            this.tb_psw.TabIndex = 54;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_psw);
            this.Controls.Add(this.tb_unm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_unm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_psw;
    }
}