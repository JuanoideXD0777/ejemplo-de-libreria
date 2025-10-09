using MySql.Data.MySqlClient;
using primer_forms.config;
using primer_forms.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_forms
{
    internal class librepo: Irepositorio <libro>
    {
        private List<libro> lista = new List<libro>();

        public List<libro> Obtener_D()
        {
            MySqlConnection conn = new MySqlConnection(settings.constr);
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
                        libro libro = new libro
                        {
                            ID = Convert.ToInt32(dr["i"].ToString()),
                            Titulo = dr["titulo"].ToString(),
                            //Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                        };
                        lista.Add (libro);
                    }
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            
            return lista;
        }
        public void RegLb(int id, string titulo, string fecha, string paginas, int autor, string categoria, int cid, int editorial)
        {
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3312;uid=root;pwd=;database=libros;");
            MySqlCommand comm = new MySqlCommand($"INSERT INTO `libros`(`i`, `titulo`, `fecha`, `paginas`, `categoria`, `idcat`, `autor`, `editorial`) VALUES ('{id}','{titulo}','{fecha}','{paginas}','{categoria}','{cid}','{autor}','{editorial}')", conn);
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
        public DataTable BuscaTitulo(string titulo, int IDCat, int i)
        {
            /*string querry = "";
            if (IDCat > 0)
            {
                querry = $"and categoria={IDCat}";
            }*/
            DataTable dtlibros = new DataTable();
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3312;uid=root;pwd=;database=libros;");
            MySqlCommand comm = new MySqlCommand($"SELECT * FROM `libros` WHERE titulo LIKE concat('%','{titulo}','%')" +
                $" and idcat=if({IDCat}>0,{IDCat}, idcat) and autor=if({i}>0,{i}, autor);", conn);
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
