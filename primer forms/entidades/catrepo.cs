using MySql.Data.MySqlClient;
using primer_forms.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_forms
{
    internal class catrepo: Irepositorio<Categoria>
    {
        private static List<Categoria> _lista = new List<Categoria>();
        public List<Categoria> Obtener_D()
        {
            _lista.Clear();
            Categoria CT = new Categoria
            {
                ID = 0,
                Nombre = "Todas"
            };
            _lista.Add(CT);
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3312;uid=root;pwd=;database=libros;");
            MySqlCommand comm = new MySqlCommand("SELECT * FROM categorias", conn);
            comm.CommandType = System.Data.CommandType.Text;
            try
            {
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Categoria Cat = new Categoria
                        {
                            ID = Convert.ToInt32(dr["idcat"].ToString()),
                            Nombre = dr["categoria"].ToString(),
                        };
                        _lista.Add(Cat);
                    }
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }

            return _lista;
        }
        public void RegCat(int idc, string categoria)
        {
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3312;uid=root;pwd=;database=libros;");
            MySqlCommand comm = new MySqlCommand($"INSERT INTO `categorias`(`idcat`, `categoria`) VALUES ('{idc}','{categoria}')", conn);
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
        public DataTable BuscaTegoria(string titulo, int IDCat)
        {
            /*string querry = "";
            if (IDCat > 0)
            {
                querry = $"and categoria={IDCat}";
            }*/
            DataTable dtlibros = new DataTable();
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3312;uid=root;pwd=;database=libros;");
            MySqlCommand comm = new MySqlCommand($"SELECT * FROM `categorias` WHERE categoria LIKE concat('%','{titulo}','%')" +
                $" and idcat=if({IDCat}>0,{IDCat}, idcat);", conn);
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
