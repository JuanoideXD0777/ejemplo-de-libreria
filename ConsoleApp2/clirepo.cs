using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class clirepo
    {
       public static List<Cliente> Lista = new List<Cliente>();
       public static List<Cliente> ObtCli()
       {
            LlenarCliente();
            return Lista; 
       }
        private static void LlenarCliente()
        {
            Cliente cliente = new Cliente
            {
                ID = 1,
                Nombre = "Uvuvuevuvue",
                Email = "nsmsm@hotmail.com",
                Telefono = "1215253"
            };
            Lista.Add(cliente);
            Cliente cliente2 = new Cliente
            {
                ID = 2,
                Nombre = "jorge",
                Email = "banamex@outlook.com",
                Telefono = "624433313"
            };
            Lista.Add(cliente2);
            Cliente cliente3 = new Cliente
            {
                ID = 3,
                Nombre = "ErickDBZ",
                Email = "perico@gmail.com",
                Telefono = "4085382407"
            };
            Lista.Add(cliente3);
        }
        public static Cliente IDsrch(int IdCli)
        {
            LlenarCliente();
            return Lista.Find(Cl => Cl.ID == IdCli);
        }
    }
}
