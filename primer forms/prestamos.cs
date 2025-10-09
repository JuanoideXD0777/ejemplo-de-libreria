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
    public partial class prestamos : Form
    {
        public prestamos()
        {
            InitializeComponent();
        }

        private void prestamos_Load(object sender, EventArgs e)
        {
            librepo replipidos = new librepo();
            combo.DataSource = replipidos.Obtener_D();
            combo.DisplayMember = "titulo";
            combo.ValueMember = "ID";

            clirepo repcli = new clirepo();
            combo_jr.DataSource = repcli.ObtCli();
            combo_jr.DisplayMember = "Nombre";
            combo_jr.ValueMember = "id";

            presrepo pres = new presrepo();
            GRID.DataSource = pres.Obtener_D();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prestamo pres = new Prestamo
            {
                IDCliente = Convert.ToInt32(combo_jr.SelectedValue),
                IDlibro = Convert.ToInt32(combo.SelectedValue),
                Fechaprestamo = DateTime.Now,
                FechaDev = Convert.ToDateTime("****-**-** **:**")
            };
            presrepo regP = new presrepo();
            regP.Regs(pres);
            GRID.DataSource = regP.Obtener_D();
        }

        private void GRID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            DialogResult Sn = MessageBox.Show("¿Desea realizar la devolucion del libro?","Devolver libro",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Sn == DialogResult.Yes)
            {

                int IDP = Convert.ToInt32(GRID.Rows[rowindex].Cells["ID"].Value.ToString());
                presrepo rp = new presrepo();
                rp.devolucion(IDP);

            }
            else if (Sn == DialogResult.No)
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string titulo = tb_fecha.Text;
            presrepo replibros = new presrepo();
            GRID.DataSource = replibros.Busca(titulo);
            if (cheker.Checked==true)
            {
                presrepo chk = new presrepo();
                GRID.DataSource = chk.filtrar();
            }
        }
    }
}
