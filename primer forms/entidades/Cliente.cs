using primer_forms.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_forms
{
    internal class Cliente : Usuarios            //gracias a los ":" cliente heredara los parametros de usuario como su primer subclase
    {
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Apellidos { get; set; }
    }
}
