using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal static class librepo
    {
        private static List<Libros> lista = new List<Libros>();
        public static List<Libros> ObtnerLibros()
        {
            Llenarlibros();
            return lista;
        }
        private static void Llenarlibros()
        {
            Libros lib = new Libros
            {
                ID = 1,
                Titulo = "ZZ",
                autor = new Autor
                {
                    ID = 1,
                    Nombre = "paco"
                },
                Categoria = new Categoria
                {
                    ID = 1,
                    Nombre = "Accion"
                },
                Paginas = 450
            };
            lista.Add(lib);

            Libros lib1 = new Libros
            {
                ID = 2,
                Titulo = "Metpo",
                autor = new Autor
                {
                    ID = 2,
                    Nombre = "josenovich"
                },
                Categoria = new Categoria
                {
                    ID = 1,
                    Nombre = "Accion"
                },
                Paginas = 302
            };
            lista.Add(lib1);
            Libros lib2 = new Libros
            {
                ID = 3,
                Titulo = "Padre ball",
                autor = new Autor
                {
                    ID = 3,
                    Nombre = "Akira tortillama"
                },
                Categoria = new Categoria
                {
                    ID = 1,
                    Nombre = "Accion"
                },
                Paginas = 777
            };
            lista.Add(lib2);
        }
    }
}
