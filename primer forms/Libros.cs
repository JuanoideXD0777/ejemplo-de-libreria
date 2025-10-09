using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primer_forms
{
    public partial class Libros : Form
    {
        public Libros()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            librepo replib = new librepo();
            dataGridView1.DataSource = replib.Obtener_D();

            catrepo recat = new catrepo();
            Combo.DataSource = recat.Obtener_D();
            Combo.DisplayMember = "Nombre";
            Combo.ValueMember = "ID";

            clirepo autr = new clirepo();
            CB_1.DataSource = autr.Obtener_D();
            CB_1.DisplayMember = "Nombre";
            CB_1.ValueMember = "ID";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tb_i.Text);
            string titulo = tb_titulo.Text;
            string fecha = tb_fecha.Text;
            string paginas = tb_paginas.Text;
            int autor = Convert.ToInt32(tb_autor.Text);
            string categoria = tb_categoria.Text;
            int cid = Convert.ToInt32(tb_cid.Text);
            int editorial = Convert.ToInt32(tb_editorial.Text);

            librepo replibs = new librepo();
            replibs.RegLb(id, titulo, fecha, paginas, autor, categoria,cid, editorial);
            tb_i.Text = "";
            tb_titulo.Text = "";
            tb_fecha.Text = "";
            tb_paginas.Text = "";
            tb_autor.Text = "";
            tb_categoria.Text = "";
            tb_cid.Text = "";
            tb_editorial.Text = "";
            dataGridView1.DataSource = replibs.Obtener_D();

            librepo relip = new librepo();
            dataGridView1.DataSource = relip.Obtener_D();
        }

        private void Buscador_Click(object sender, EventArgs e)
        {
            int IDCat = Convert.ToInt32(Combo.SelectedValue);
            string titulo = tb_srch.Text;
            int i = Convert.ToInt32(CB_1.SelectedValue);
            librepo replibros = new librepo();
            dataGridView1.DataSource = replibros.BuscaTitulo(titulo, IDCat, i);
        }
    }
}
