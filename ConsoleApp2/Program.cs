using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
                Console.WriteLine($"{libro.ID}-{libro.Titulo}");
            }

            List<Categoria> categorias = catrepo.Obtcategoria();
            foreach (Categoria c in categorias)
            {
                Console.WriteLine($"Categorias: {c.Nombre}");
            }
            List<Cliente> clientes = clirepo.ObtCli();
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"{cliente.ID}-{cliente.Nombre}");
            }

            List<Prestamo> prestamos = new List<Prestamo>();
            Prestamo prestamo = new Prestamo();
            Libros libs = null;
            Cliente CliActual = null;
            int opcion = 0;
            do
            {
                Console.WriteLine("que desea realizar");
                Console.WriteLine("1 - prestamo");
                Console.WriteLine("2 - devolucion");
                Console.WriteLine("3 - ver prestamos");
                Console.WriteLine("0 - salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("Ingresar datos del prestamo");
                    while (libs == null)
                    {
                        Console.WriteLine("Indique el libro");
                        int idlib = Convert.ToInt32(Console.ReadLine());
                        libs = librepo.IDsrch(idlib);
                        if (libs == null)
                        {
                            Console.WriteLine("¡¡¡El libro no existe!!!");
                        }
                        else
                        {
                            prestamo.libro = libs;
                        }
                    }
                    while (CliActual == null)
                    {
                        Console.WriteLine("Indique el cliente");
                        int IdCli = Convert.ToInt32(Console.ReadLine());
                        CliActual = clirepo.IDsrch(IdCli);
                        if (CliActual == null)
                        {
                            Console.WriteLine("¡¡¡El cliente no existe!!!");
                        }
                        else
                        {
                            prestamo.cliente = CliActual;
                        }
                    }
                    prestamo.Fechaprestamo = DateTime.Now;
                    prestamos.Add(prestamo);
                }
                else if (opcion == 2)
                {

                }
                else if (opcion == 3)
                {
                    foreach (Prestamo p in prestamos)
                    {
                        Console.WriteLine($"{p.ID}-{p.libro.Titulo}-{p.cliente.Nombre}");
                    }
                }
            }
            while (opcion > 0);
        }
    }
}
