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
    public partial class autores : Form
    {
        public autores()
        {
            InitializeComponent();
        }

        private void autores_Load(object sender, EventArgs e)
        {
            clirepo replib = new clirepo();
            GRID.DataSource = replib.Obtener_D();

            clirepo autr = new clirepo();
            Combo_2.DataSource = autr.Obtener_D();
            Combo_2.DisplayMember = "Nombre";
            Combo_2.ValueMember = "ID";
        }

        private void Agregador_Click(object sender, EventArgs e)
        {
            string nombre = tb_nm.Text;
            int autor = Convert.ToInt32(tb_id.Text);

            clirepo regato = new clirepo();
            regato.RegAut(autor, nombre);
            tb_nm.Text = "";
            tb_id.Text = "";
            GRID.DataSource = regato.Obtener_D();

            clirepo relip = new clirepo();
            GRID.DataSource = relip.Obtener_D();
        }

        private void Buscador_Click(object sender, EventArgs e)
        {
            int IDCat = Convert.ToInt32(Combo_2.SelectedValue);
            string titulo = tb_srch.Text;
            clirepo replibros = new clirepo();
            GRID.DataSource = replibros.Buscautor(titulo, IDCat);
        }
    }
}
