using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal static class catrepo
    {
        private static List<Categoria> _lista = new List<Categoria>();
        public static List<Categoria> Obtcategoria()
        {
            CargarCategoria();
            return _lista;
        }
        public static void CargarCategoria()
        {
            Categoria Cat = new Categoria
            {
                ID = 1,
                Nombre = "accion"
            };
            _lista.Add(Cat);
            Categoria Cato = new Categoria
            {
                ID = 1,
                Nombre = "drama"
            };
            _lista.Add(Cato);
            Categoria Cati = new Categoria
            {
                ID = 1,
                Nombre = "comedia"
            };
            _lista.Add(Cati);
            Categoria Catei = new Categoria
            {
                ID = 1,
                Nombre = "documental"
            };
            _lista.Add(Catei);
        }

    }
}
