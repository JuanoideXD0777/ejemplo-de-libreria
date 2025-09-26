using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Prestamo
    {
        public int ID {  get; set; }
        public Libros libro { get; set; }
        public DateTime Fechaprestamo {  get; set; }
        public DateTime FechaDev {  get; set; }
        public Cliente cliente { get; set; }
        public int count { get; set; }

    }
}
