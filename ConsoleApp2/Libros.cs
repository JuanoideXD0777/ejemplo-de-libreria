using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Libros
    {
        public int ID { get; set; }
        public string Nombre { get; set; }    
        public DateTime Fecha { get; set; }
        public int Paginas { get; set; }
        public Categoria Categoria { get; set; }
        public Autor autor { get; set; }
        public Editorial editorial { get; set; }
    }
}
