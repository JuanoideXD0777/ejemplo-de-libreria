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
    public partial class Menu : Form
    {
        bibliotecario usuario = new bibliotecario();
        public Menu(bibliotecario bx)
        {
            InitializeComponent();
            usuario = bx;
            label0.Text = usuario.Nombre;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void libmenu_Click(object sender, EventArgs e)
        {
            Libros formulario1 = new Libros();
            formulario1.StartPosition = FormStartPosition.CenterScreen;
            formulario1.Show();
        }

        private void catmenu_Click(object sender, EventArgs e)
        {
            categorias formulario2 = new categorias();
            formulario2.StartPosition = FormStartPosition.CenterScreen;
            formulario2.Show();
        }

        private void autmenu_Click(object sender, EventArgs e)
        {
            autores formulario3 = new autores();
            formulario3.StartPosition = FormStartPosition.CenterScreen;
            formulario3.Show();
        }

        private void presmenu_Click(object sender, EventArgs e)
        {
            prestamos formulario4 = new prestamos();
            formulario4.StartPosition = FormStartPosition.CenterScreen;
            formulario4.Show();
        }

        private void edmenu_Click(object sender, EventArgs e)
        {
            editoriales formulario4 = new editoriales();
            formulario4.StartPosition = FormStartPosition.CenterScreen;
            formulario4.Show();
        }
    }
}
