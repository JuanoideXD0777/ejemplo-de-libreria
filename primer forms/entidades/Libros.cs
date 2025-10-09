using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_forms
{
    internal class libro
    {
        public int ID { get; set; }
        public string Titulo { get; set; }    
        public DateTime Fecha { get; set; }
        public int Paginas { get; set; }
        public libro Categoria { get; set; }
        public Autor autor { get; set; }
        public Editorial editorial { get; set; }
    }
}
