using Google.Protobuf.Collections;
using MySql.Data;
using MySql.Data.MySqlClient;
using primer_forms.interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_forms
{
    internal class clirepo : Irepositorio<Autor> //asi se implementa una interfaz
    {
       public static List<Cliente> Lista = new List<Cliente>();
        
        
       public List<Cliente> ObtCli()
       {
            Lista.Clear();
            Cliente aut = new Cliente
            {
                ID = 0,
                Nombre = "Todos",
                Apellidos = "Todos"
            };
            Lista.Add(aut);
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3312;uid=root;pwd=;database=libros;");
            MySqlCommand comm = new MySqlCommand("SELECT * FROM clientes", conn);
            comm.CommandType = System.Data.CommandType.Text;
            try
            {
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cliente cre = new Cliente
                        {
                            ID = Convert.ToInt32(dr["id"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Apellidos = dr["Apellido"].ToString(),
                        };
                        Lista.Add(cre);
                    }
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }

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



        private static List<Autor> _lta = new List<Autor>();
        public List<Autor> Obtener_D()
        {
            _lta.Clear();
            Autor aut = new Autor
            {
                ID = 0,
                Nombre = "Todos"
            };
            _lta.Add(aut);
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3312;uid=root;pwd=;database=libros;");
            MySqlCommand comm = new MySqlCommand("SELECT * FROM libros", conn);
            comm.CommandType = System.Data.CommandType.Text;
            try
            {
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Autor cre = new Autor
                        {
                            ID = Convert.ToInt32(dr["autor"].ToString()),
                            Nombre = dr["autor"].ToString(),
                        };
                        _lta.Add(cre);
                    }
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }

            return _lta;
        }
        public void RegAut(int autor, string nombre)
        {
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3312;uid=root;pwd=;database=libros;");
            MySqlCommand comm = new MySqlCommand($"INSERT INTO `autores`(`autor`, `Nombre autor`) VALUES ('{autor}','{nombre}')", conn);
            comm.CommandType = System.Data.CommandType.Text;
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
        }
        public DataTable Buscautor(string nombre, int autor)
        {
            /*string querry = "";
            if (IDCat > 0)
            {
                querry = $"and categoria={IDCat}";
            }*/
            DataTable dtlibros = new DataTable();
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3312;uid=root;pwd=;database=libros;");
            MySqlCommand comm = new MySqlCommand($"SELECT * FROM `autores` WHERE `Nombre autor` LIKE concat('%','{nombre}','%')" +
                $" and autor=if({autor}>0,{autor}, autor);", conn);
            comm.CommandType = System.Data.CommandType.Text;
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(comm);
                da.Fill(dtlibros);
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            return dtlibros;
        }
    }
}
