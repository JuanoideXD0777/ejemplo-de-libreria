using primer_forms.entidades;
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
    public partial class editoriales : Form
    {
        public editoriales()
        {
            InitializeComponent();
        }

        private void editoriales_Load(object sender, EventArgs e)
        {
            editorialDB replib = new editorialDB();
            GRID.DataSource = replib.Obtener_D();

            editorialDB edb = new editorialDB();
            Combo.DataSource = edb.Obtener_D();
            Combo.DisplayMember = "Nombre";
            Combo.ValueMember = "ID";
        }

        private void Agregador_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tb_id.Text);
            string ne = tb_nm.Text;
            int nl = Convert.ToInt32(tb_libs.Text);

            editorialDB rechapos = new editorialDB();
            rechapos.RegEd(id, ne, nl);
            tb_nm.Text = "";
            tb_id.Text = "";
            tb_libs.Text = "";
            GRID.DataSource = rechapos.Obtener_D();

            editorialDB relip = new editorialDB();
            GRID.DataSource = relip.Obtener_D();
        }

        private void Buscador_Click(object sender, EventArgs e)
        {
            string titulo = tb_srch.Text;
            editorialDB replibros = new editorialDB();
            GRID.DataSource = replibros.BuscaEdit(titulo);
        }
    }
}
