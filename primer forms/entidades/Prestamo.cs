using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace primer_forms
{
    internal class Prestamo
    {
        public int ID {  get; set; }
        public int IDlibro { get; set; }
        public string libro { get; set; }
        public DateTime Fechaprestamo {  get; set; }
        public DateTime FechaDev {  get; set; }
        public int IDCliente { get; set; }
        public string cliente { get; set; }
        public int count { get; set; }

    }
}
