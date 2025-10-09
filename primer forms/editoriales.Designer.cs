namespace primer_forms
{
    partial class editoriales
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
            this.tb_nm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_srch = new System.Windows.Forms.TextBox();
            this.Autor_7 = new System.Windows.Forms.Label();
            this.Combo = new System.Windows.Forms.ComboBox();
            this.Buscador = new System.Windows.Forms.Button();
            this.tb_libs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GRID = new System.Windows.Forms.DataGridView();
            this.Agregador = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GRID)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_nm
            // 
            this.tb_nm.Location = new System.Drawing.Point(130, 39);
            this.tb_nm.Name = "tb_nm";
            this.tb_nm.Size = new System.Drawing.Size(100, 22);
            this.tb_nm.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Nombre de la editorial";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 65;
            this.label7.Text = "Barra de busqueda";
            // 
            // tb_srch
            // 
            this.tb_srch.Location = new System.Drawing.Point(229, 218);
            this.tb_srch.Name = "tb_srch";
            this.tb_srch.Size = new System.Drawing.Size(243, 22);
            this.tb_srch.TabIndex = 64;
            // 
            // Autor_7
            // 
            this.Autor_7.AutoSize = true;
            this.Autor_7.Location = new System.Drawing.Point(31, 199);
            this.Autor_7.Name = "Autor_7";
            this.Autor_7.Size = new System.Drawing.Size(20, 16);
            this.Autor_7.TabIndex = 63;
            this.Autor_7.Text = "ID";
            // 
            // Combo
            // 
            this.Combo.FormattingEnabled = true;
            this.Combo.Location = new System.Drawing.Point(34, 218);
            this.Combo.Name = "Combo";
            this.Combo.Size = new System.Drawing.Size(141, 24);
            this.Combo.TabIndex = 62;
            // 
            // Buscador
            // 
            this.Buscador.Location = new System.Drawing.Point(616, 199);
            this.Buscador.Name = "Buscador";
            this.Buscador.Size = new System.Drawing.Size(122, 25);
            this.Buscador.TabIndex = 61;
            this.Buscador.Text = "Buscar";
            this.Buscador.UseVisualStyleBackColor = true;
            this.Buscador.Click += new System.EventHandler(this.Buscador_Click);
            // 
            // tb_libs
            // 
            this.tb_libs.Location = new System.Drawing.Point(261, 39);
            this.tb_libs.Name = "tb_libs";
            this.tb_libs.Size = new System.Drawing.Size(100, 22);
            this.tb_libs.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Libros publicados";
            // 
            // GRID
            // 
            this.GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID.Location = new System.Drawing.Point(34, 248);
            this.GRID.Name = "GRID";
            this.GRID.RowHeadersWidth = 51;
            this.GRID.RowTemplate.Height = 24;
            this.GRID.Size = new System.Drawing.Size(736, 193);
            this.GRID.TabIndex = 58;
            // 
            // Agregador
            // 
            this.Agregador.Location = new System.Drawing.Point(402, 30);
            this.Agregador.Name = "Agregador";
            this.Agregador.Size = new System.Drawing.Size(122, 41);
            this.Agregador.TabIndex = 57;
            this.Agregador.Text = "Agregar";
            this.Agregador.UseVisualStyleBackColor = true;
            this.Agregador.Click += new System.EventHandler(this.Agregador_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(3, 39);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 22);
            this.tb_id.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "ID";
            // 
            // editoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_srch);
            this.Controls.Add(this.Autor_7);
            this.Controls.Add(this.Combo);
            this.Controls.Add(this.Buscador);
            this.Controls.Add(this.tb_libs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GRID);
            this.Controls.Add(this.Agregador);
            this.Name = "editoriales";
            this.Text = "editoriales";
            this.Load += new System.EventHandler(this.editoriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_srch;
        private System.Windows.Forms.Label Autor_7;
        private System.Windows.Forms.ComboBox Combo;
        private System.Windows.Forms.Button Buscador;
        private System.Windows.Forms.TextBox tb_libs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GRID;
        private System.Windows.Forms.Button Agregador;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label2;
    }
}