namespace primer_forms
{
    partial class categorias
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
            this.label8 = new System.Windows.Forms.Label();
            this.Autor_7 = new System.Windows.Forms.Label();
            this.Combo_2 = new System.Windows.Forms.ComboBox();
            this.Combo = new System.Windows.Forms.ComboBox();
            this.Buscador = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GRID = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Agregador = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_srch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GRID)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(595, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Categoria";
            // 
            // Autor_7
            // 
            this.Autor_7.AutoSize = true;
            this.Autor_7.Location = new System.Drawing.Point(634, 220);
            this.Autor_7.Name = "Autor_7";
            this.Autor_7.Size = new System.Drawing.Size(99, 16);
            this.Autor_7.TabIndex = 39;
            this.Autor_7.Text = "ID de categoria";
            // 
            // Combo_2
            // 
            this.Combo_2.FormattingEnabled = true;
            this.Combo_2.Location = new System.Drawing.Point(637, 239);
            this.Combo_2.Name = "Combo_2";
            this.Combo_2.Size = new System.Drawing.Size(141, 24);
            this.Combo_2.TabIndex = 38;
            // 
            // Combo
            // 
            this.Combo.FormattingEnabled = true;
            this.Combo.Location = new System.Drawing.Point(597, 174);
            this.Combo.Name = "Combo";
            this.Combo.Size = new System.Drawing.Size(186, 24);
            this.Combo.TabIndex = 37;
            // 
            // Buscador
            // 
            this.Buscador.Location = new System.Drawing.Point(299, 214);
            this.Buscador.Name = "Buscador";
            this.Buscador.Size = new System.Drawing.Size(122, 22);
            this.Buscador.TabIndex = 36;
            this.Buscador.Text = "Buscar";
            this.Buscador.UseVisualStyleBackColor = true;
            this.Buscador.Click += new System.EventHandler(this.Buscador_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(191, 50);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 22);
            this.tb_id.TabIndex = 33;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(25, 50);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(100, 22);
            this.tb_nombre.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "ID";
            // 
            // GRID
            // 
            this.GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID.Location = new System.Drawing.Point(37, 269);
            this.GRID.Name = "GRID";
            this.GRID.RowHeadersWidth = 51;
            this.GRID.RowTemplate.Height = 24;
            this.GRID.Size = new System.Drawing.Size(736, 193);
            this.GRID.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre";
            // 
            // Agregador
            // 
            this.Agregador.Location = new System.Drawing.Point(321, 31);
            this.Agregador.Name = "Agregador";
            this.Agregador.Size = new System.Drawing.Size(122, 41);
            this.Agregador.TabIndex = 21;
            this.Agregador.Text = "Agregar";
            this.Agregador.UseVisualStyleBackColor = true;
            this.Agregador.Click += new System.EventHandler(this.Agregador_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Barra de busqueda";
            // 
            // tb_srch
            // 
            this.tb_srch.Location = new System.Drawing.Point(37, 214);
            this.tb_srch.Name = "tb_srch";
            this.tb_srch.Size = new System.Drawing.Size(243, 22);
            this.tb_srch.TabIndex = 42;
            // 
            // categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_srch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Autor_7);
            this.Controls.Add(this.Combo_2);
            this.Controls.Add(this.Combo);
            this.Controls.Add(this.Buscador);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GRID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Agregador);
            this.Name = "categorias";
            this.Text = "categorias";
            this.Load += new System.EventHandler(this.categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Autor_7;
        private System.Windows.Forms.ComboBox Combo_2;
        private System.Windows.Forms.ComboBox Combo;
        private System.Windows.Forms.Button Buscador;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GRID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Agregador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_srch;
    }
}