namespace primer_forms
{
    partial class Libros
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.tb_fecha = new System.Windows.Forms.TextBox();
            this.tb_paginas = new System.Windows.Forms.TextBox();
            this.tb_autor = new System.Windows.Forms.TextBox();
            this.tb_categoria = new System.Windows.Forms.TextBox();
            this.tb_editorial = new System.Windows.Forms.TextBox();
            this.tb_srch = new System.Windows.Forms.TextBox();
            this.Buscador = new System.Windows.Forms.Button();
            this.Combo = new System.Windows.Forms.ComboBox();
            this.CB_1 = new System.Windows.Forms.ComboBox();
            this.Autor_7 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_cid = new System.Windows.Forms.TextBox();
            this.tb_i = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 193);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Paginas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Categorias";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Editorial";
            // 
            // tb_titulo
            // 
            this.tb_titulo.Location = new System.Drawing.Point(12, 63);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(100, 22);
            this.tb_titulo.TabIndex = 8;
            // 
            // tb_fecha
            // 
            this.tb_fecha.Location = new System.Drawing.Point(147, 63);
            this.tb_fecha.Name = "tb_fecha";
            this.tb_fecha.Size = new System.Drawing.Size(100, 22);
            this.tb_fecha.TabIndex = 9;
            // 
            // tb_paginas
            // 
            this.tb_paginas.Location = new System.Drawing.Point(279, 63);
            this.tb_paginas.Name = "tb_paginas";
            this.tb_paginas.Size = new System.Drawing.Size(100, 22);
            this.tb_paginas.TabIndex = 10;
            // 
            // tb_autor
            // 
            this.tb_autor.Location = new System.Drawing.Point(397, 63);
            this.tb_autor.Name = "tb_autor";
            this.tb_autor.Size = new System.Drawing.Size(100, 22);
            this.tb_autor.TabIndex = 11;
            // 
            // tb_categoria
            // 
            this.tb_categoria.Location = new System.Drawing.Point(513, 63);
            this.tb_categoria.Name = "tb_categoria";
            this.tb_categoria.Size = new System.Drawing.Size(100, 22);
            this.tb_categoria.TabIndex = 12;
            // 
            // tb_editorial
            // 
            this.tb_editorial.Location = new System.Drawing.Point(629, 63);
            this.tb_editorial.Name = "tb_editorial";
            this.tb_editorial.Size = new System.Drawing.Size(100, 22);
            this.tb_editorial.TabIndex = 13;
            // 
            // tb_srch
            // 
            this.tb_srch.Location = new System.Drawing.Point(22, 206);
            this.tb_srch.Name = "tb_srch";
            this.tb_srch.Size = new System.Drawing.Size(243, 22);
            this.tb_srch.TabIndex = 14;
            // 
            // Buscador
            // 
            this.Buscador.Location = new System.Drawing.Point(290, 206);
            this.Buscador.Name = "Buscador";
            this.Buscador.Size = new System.Drawing.Size(122, 22);
            this.Buscador.TabIndex = 15;
            this.Buscador.Text = "Buscar";
            this.Buscador.UseVisualStyleBackColor = true;
            this.Buscador.Click += new System.EventHandler(this.Buscador_Click);
            // 
            // Combo
            // 
            this.Combo.FormattingEnabled = true;
            this.Combo.Location = new System.Drawing.Point(564, 204);
            this.Combo.Name = "Combo";
            this.Combo.Size = new System.Drawing.Size(186, 24);
            this.Combo.TabIndex = 16;
            // 
            // CB_1
            // 
            this.CB_1.FormattingEnabled = true;
            this.CB_1.Location = new System.Drawing.Point(22, 283);
            this.CB_1.Name = "CB_1";
            this.CB_1.Size = new System.Drawing.Size(141, 24);
            this.CB_1.TabIndex = 17;
            // 
            // Autor_7
            // 
            this.Autor_7.AutoSize = true;
            this.Autor_7.Location = new System.Drawing.Point(19, 264);
            this.Autor_7.Name = "Autor_7";
            this.Autor_7.Size = new System.Drawing.Size(38, 16);
            this.Autor_7.TabIndex = 18;
            this.Autor_7.Text = "Autor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Titulo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(562, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Categoria";
            // 
            // tb_cid
            // 
            this.tb_cid.Location = new System.Drawing.Point(706, 141);
            this.tb_cid.Name = "tb_cid";
            this.tb_cid.Size = new System.Drawing.Size(100, 22);
            this.tb_cid.TabIndex = 24;
            // 
            // tb_i
            // 
            this.tb_i.Location = new System.Drawing.Point(590, 141);
            this.tb_i.Name = "tb_i";
            this.tb_i.Size = new System.Drawing.Size(100, 22);
            this.tb_i.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(728, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "ID categoria";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(606, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "ID";
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 518);
            this.Controls.Add(this.tb_cid);
            this.Controls.Add(this.tb_i);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Autor_7);
            this.Controls.Add(this.CB_1);
            this.Controls.Add(this.Combo);
            this.Controls.Add(this.Buscador);
            this.Controls.Add(this.tb_srch);
            this.Controls.Add(this.tb_editorial);
            this.Controls.Add(this.tb_categoria);
            this.Controls.Add(this.tb_autor);
            this.Controls.Add(this.tb_paginas);
            this.Controls.Add(this.tb_fecha);
            this.Controls.Add(this.tb_titulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Libros";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.TextBox tb_fecha;
        private System.Windows.Forms.TextBox tb_paginas;
        private System.Windows.Forms.TextBox tb_autor;
        private System.Windows.Forms.TextBox tb_categoria;
        private System.Windows.Forms.TextBox tb_editorial;
        private System.Windows.Forms.TextBox tb_srch;
        private System.Windows.Forms.Button Buscador;
        private System.Windows.Forms.ComboBox Combo;
        private System.Windows.Forms.ComboBox CB_1;
        private System.Windows.Forms.Label Autor_7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_cid;
        private System.Windows.Forms.TextBox tb_i;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}