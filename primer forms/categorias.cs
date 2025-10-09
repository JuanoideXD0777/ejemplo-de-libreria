using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primer_forms
{
    public partial class categorias : Form
    {
        public categorias()
        {
            InitializeComponent();
        }

        private void categorias_Load(object sender, EventArgs e)
        {
            catrepo replib = new catrepo();
            GRID.DataSource = replib.Obtener_D();

            catrepo recat = new catrepo();
            Combo.DataSource = recat.Obtener_D();
            Combo.DisplayMember = "Nombre";
            Combo.ValueMember = "ID";

            catrepo idc = new catrepo();
            Combo_2.DataSource = idc.Obtener_D();
            Combo_2.DisplayMember = "ID";
            Combo_2.ValueMember = "ID";
        }

        private void Agregador_Click(object sender, EventArgs e)
        {
            string categoria = tb_nombre.Text;
            int idc = Convert.ToInt32(tb_id.Text);

            catrepo regato = new catrepo();
            regato.RegCat(idc,categoria);
            tb_nombre.Text = "";
            tb_id.Text = "";
            GRID.DataSource = regato.Obtener_D();

            catrepo relip = new catrepo();
            GRID.DataSource = relip.Obtener_D();
        }

        private void Buscador_Click(object sender, EventArgs e)
        {
            int IDCat = Convert.ToInt32(Combo_2.SelectedValue);
            string titulo = tb_srch.Text;
            catrepo replibros = new catrepo();
            GRID.DataSource = replibros.BuscaTegoria(titulo, IDCat);
        }
    }
}
