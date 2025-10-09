namespace primer_forms
{
    partial class autores
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
            this.Autor_7 = new System.Windows.Forms.Label();
            this.Combo_2 = new System.Windows.Forms.ComboBox();
            this.Buscador = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GRID = new System.Windows.Forms.DataGridView();
            this.Agregador = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_srch = new System.Windows.Forms.TextBox();
            this.tb_nm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GRID)).BeginInit();
            this.SuspendLayout();
            // 
            // Autor_7
            // 
            this.Autor_7.AutoSize = true;
            this.Autor_7.Location = new System.Drawing.Point(35, 199);
            this.Autor_7.Name = "Autor_7";
            this.Autor_7.Size = new System.Drawing.Size(20, 16);
            this.Autor_7.TabIndex = 51;
            this.Autor_7.Text = "ID";
            // 
            // Combo_2
            // 
            this.Combo_2.FormattingEnabled = true;
            this.Combo_2.Location = new System.Drawing.Point(38, 218);
            this.Combo_2.Name = "Combo_2";
            this.Combo_2.Size = new System.Drawing.Size(141, 24);
            this.Combo_2.TabIndex = 50;
            // 
            // Buscador
            // 
            this.Buscador.Location = new System.Drawing.Point(620, 199);
            this.Buscador.Name = "Buscador";
            this.Buscador.Size = new System.Drawing.Size(122, 25);
            this.Buscador.TabIndex = 48;
            this.Buscador.Text = "Buscar";
            this.Buscador.UseVisualStyleBackColor = true;
            this.Buscador.Click += new System.EventHandler(this.Buscador_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(192, 29);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 22);
            this.tb_id.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "ID";
            // 
            // GRID
            // 
            this.GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID.Location = new System.Drawing.Point(38, 248);
            this.GRID.Name = "GRID";
            this.GRID.RowHeadersWidth = 51;
            this.GRID.RowTemplate.Height = 24;
            this.GRID.Size = new System.Drawing.Size(736, 193);
            this.GRID.TabIndex = 44;
            // 
            // Agregador
            // 
            this.Agregador.Location = new System.Drawing.Point(322, 10);
            this.Agregador.Name = "Agregador";
            this.Agregador.Size = new System.Drawing.Size(122, 41);
            this.Agregador.TabIndex = 42;
            this.Agregador.Text = "Agregar";
            this.Agregador.UseVisualStyleBackColor = true;
            this.Agregador.Click += new System.EventHandler(this.Agregador_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Barra de busqueda";
            // 
            // tb_srch
            // 
            this.tb_srch.Location = new System.Drawing.Point(233, 218);
            this.tb_srch.Name = "tb_srch";
            this.tb_srch.Size = new System.Drawing.Size(243, 22);
            this.tb_srch.TabIndex = 53;
            // 
            // tb_nm
            // 
            this.tb_nm.Location = new System.Drawing.Point(79, 29);
            this.tb_nm.Name = "tb_nm";
            this.tb_nm.Size = new System.Drawing.Size(100, 22);
            this.tb_nm.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Nombre del autor";
            // 
            // autores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_nm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_srch);
            this.Controls.Add(this.Autor_7);
            this.Controls.Add(this.Combo_2);
            this.Controls.Add(this.Buscador);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GRID);
            this.Controls.Add(this.Agregador);
            this.Name = "autores";
            this.Text = "autores";
            this.Load += new System.EventHandler(this.autores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Autor_7;
        private System.Windows.Forms.ComboBox Combo_2;
        private System.Windows.Forms.Button Buscador;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GRID;
        private System.Windows.Forms.Button Agregador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_srch;
        private System.Windows.Forms.TextBox tb_nm;
        private System.Windows.Forms.Label label1;
    }
}