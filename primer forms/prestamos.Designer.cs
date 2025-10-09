namespace primer_forms
{
    partial class prestamos
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
            this.GRID = new System.Windows.Forms.DataGridView();
            this.combo = new System.Windows.Forms.ComboBox();
            this.combo_jr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_fecha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cheker = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GRID)).BeginInit();
            this.SuspendLayout();
            // 
            // GRID
            // 
            this.GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID.Location = new System.Drawing.Point(12, 244);
            this.GRID.Name = "GRID";
            this.GRID.RowHeadersWidth = 51;
            this.GRID.RowTemplate.Height = 24;
            this.GRID.Size = new System.Drawing.Size(565, 194);
            this.GRID.TabIndex = 0;
            this.GRID.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRID_CellClick);
            // 
            // combo
            // 
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(12, 198);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(121, 24);
            this.combo.TabIndex = 1;
            // 
            // combo_jr
            // 
            this.combo_jr.FormattingEnabled = true;
            this.combo_jr.Location = new System.Drawing.Point(150, 198);
            this.combo_jr.Name = "combo_jr";
            this.combo_jr.Size = new System.Drawing.Size(121, 24);
            this.combo_jr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // tb_fecha
            // 
            this.tb_fecha.Location = new System.Drawing.Point(302, 200);
            this.tb_fecha.Name = "tb_fecha";
            this.tb_fecha.Size = new System.Drawing.Size(100, 22);
            this.tb_fecha.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cheker
            // 
            this.cheker.AutoSize = true;
            this.cheker.Location = new System.Drawing.Point(528, 200);
            this.cheker.Name = "cheker";
            this.cheker.Size = new System.Drawing.Size(246, 20);
            this.cheker.TabIndex = 11;
            this.cheker.Text = "Mostrar solo prestamos sin devolver";
            this.cheker.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(667, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cheker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_jr);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.GRID);
            this.Name = "prestamos";
            this.Text = "prestamos";
            this.Load += new System.EventHandler(this.prestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GRID;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.ComboBox combo_jr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_fecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cheker;
        private System.Windows.Forms.Button button2;
    }
}