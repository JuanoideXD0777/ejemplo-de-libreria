using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Libros> libros = librepo.ObtnerLibros();
            foreach (Libros libro in libros)
            {
                Console.WriteLine(libro.Titulo);
            }

            List<Categoria> categorias = catrepo.Obtcategoria();
            foreach (Categoria c in categorias)
            {
                Console.WriteLine($"Categorias: {c.Nombre}");
            }
        }
    }
}
