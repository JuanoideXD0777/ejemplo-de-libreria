namespace primer_forms
{
    partial class Menu
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
            this.libmenu = new System.Windows.Forms.Button();
            this.catmenu = new System.Windows.Forms.Button();
            this.autmenu = new System.Windows.Forms.Button();
            this.edmenu = new System.Windows.Forms.Button();
            this.presmenu = new System.Windows.Forms.Button();
            this.label0 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // libmenu
            // 
            this.libmenu.Location = new System.Drawing.Point(25, 36);
            this.libmenu.Name = "libmenu";
            this.libmenu.Size = new System.Drawing.Size(81, 65);
            this.libmenu.TabIndex = 0;
            this.libmenu.Text = "Libros";
            this.libmenu.UseVisualStyleBackColor = true;
            this.libmenu.Click += new System.EventHandler(this.libmenu_Click);
            // 
            // catmenu
            // 
            this.catmenu.Location = new System.Drawing.Point(112, 38);
            this.catmenu.Name = "catmenu";
            this.catmenu.Size = new System.Drawing.Size(110, 34);
            this.catmenu.TabIndex = 0;
            this.catmenu.Text = "Categorias";
            this.catmenu.UseVisualStyleBackColor = true;
            this.catmenu.Click += new System.EventHandler(this.catmenu_Click);
            // 
            // autmenu
            // 
            this.autmenu.Location = new System.Drawing.Point(112, 78);
            this.autmenu.Name = "autmenu";
            this.autmenu.Size = new System.Drawing.Size(86, 30);
            this.autmenu.TabIndex = 0;
            this.autmenu.Text = "Autores";
            this.autmenu.UseVisualStyleBackColor = true;
            this.autmenu.Click += new System.EventHandler(this.autmenu_Click);
            // 
            // edmenu
            // 
            this.edmenu.Location = new System.Drawing.Point(141, 118);
            this.edmenu.Name = "edmenu";
            this.edmenu.Size = new System.Drawing.Size(86, 30);
            this.edmenu.TabIndex = 1;
            this.edmenu.Text = "Editoriales";
            this.edmenu.UseVisualStyleBackColor = true;
            this.edmenu.Click += new System.EventHandler(this.edmenu_Click);
            // 
            // presmenu
            // 
            this.presmenu.Location = new System.Drawing.Point(25, 114);
            this.presmenu.Name = "presmenu";
            this.presmenu.Size = new System.Drawing.Size(110, 34);
            this.presmenu.TabIndex = 2;
            this.presmenu.Text = "Prestamos";
            this.presmenu.UseVisualStyleBackColor = true;
            this.presmenu.Click += new System.EventHandler(this.presmenu_Click);
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(617, 422);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(19, 16);
            this.label0.TabIndex = 3;
            this.label0.Text = "....";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.edmenu);
            this.Controls.Add(this.presmenu);
            this.Controls.Add(this.autmenu);
            this.Controls.Add(this.catmenu);
            this.Controls.Add(this.libmenu);
            this.Name = "Menu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button libmenu;
        private System.Windows.Forms.Button catmenu;
        private System.Windows.Forms.Button autmenu;
        private System.Windows.Forms.Button edmenu;
        private System.Windows.Forms.Button presmenu;
        private System.Windows.Forms.Label label0;
    }
}