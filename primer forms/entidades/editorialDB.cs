using MySql.Data.MySqlClient;
using primer_forms.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_forms.entidades
{
    internal class editorialDB : Irepositorio<Editorial>
    {
        private static List<Editorial> DB = new List<Editorial>();

        public List<Editorial> Obtener_D()
        {
            Editorial ed = new Editorial
            {
                ID = 0,
                Nombre = "Todas",
                LibNum = 0,
            };
            DB.Add(ed);
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3312;uid=root;pwd=;database=libros;");
            MySqlCommand comm = new MySqlCommand("SELECT * FROM `editoriales`", conn);
            comm.CommandType = System.Data.CommandType.Text;
            try
            {
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Editorial eit = new Editorial
                        {
                            ID = Convert.ToInt32(dr["id editorial"].ToString()),
                            Nombre = dr["Nombre editorial"].ToString(),
                            LibNum = Convert.ToInt32(dr["Numero de libros"])
                        };
                        DB.Add(eit);
                    }
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }

            return DB;
        }
        public void RegEd(int id, string ne, int nl)
        {
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3312;uid=root;pwd=;database=libros;");
            MySqlCommand comm = new MySqlCommand($"INSERT INTO `editoriales`(`Id editorial`, `Nombre editorial`, `Numero de libros`) VALUES ('{id}','{ne}','{nl}')", conn);
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
        public DataTable BuscaEdit(string titulo)
        {
            /*string querry = "";
            if (IDCat > 0)
            {
                querry = $"and categoria={IDCat}";
            }*/
            DataTable dtlibros = new DataTable();
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3312;uid=root;pwd=;database=libros;");
            MySqlCommand comm = new MySqlCommand($"SELECT * FROM `editoriales` WHERE `Nombre editorial` LIKE concat('%','{titulo}','%');", conn);
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
