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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tb_unm.Text.Trim();
            string password = tb_psw.Text.Trim();
            if (username =="" || password=="")
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            bibliotecario usuario = logrepo.Login2(username, password);
            if (usuario.ID >0)
            {
                Menu menu = new Menu(usuario);
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
