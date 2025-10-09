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
    internal class presrepo : Irepositorio<Prestamo>
    {
        public static List<Prestamo> lis = new List<Prestamo>();
        public List<Prestamo> Obtener_D()
        {
            lis.Clear();
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3312;uid=root;pwd=;database=libros;");
            MySqlCommand comm = new MySqlCommand("SELECT * FROM prestamos", conn);
            comm.CommandType = System.Data.CommandType.Text;
            try
            {
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Prestamo cre = new Prestamo
                        {
                            ID = Convert.ToInt32(dr["ID"].ToString()),
                            cliente = dr["Cliente"].ToString(),
                            libro = dr["libro"].ToString(),
                            Fechaprestamo = Convert.ToDateTime(dr["Fecha del prestamo"].ToString()),
                            FechaDev = Convert.ToDateTime(dr["Fecha de devolucion"].ToString()) 
                        };
                        lis.Add(cre);
                    }
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }

            return lis;
        }
        public void Regs(Prestamo pres)
        {
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3312;uid=root;pwd=;database=libros;");
            MySqlCommand comm = new MySqlCommand($"INSERT INTO `prestamos`(`Cliente`, `libro`, `Fecha del prestamo`, `Fecha de devolucion`,) VALUES ('@cliente','@libro','@fechapres','@fechadev')", conn);
            comm.CommandType = System.Data.CommandType.Text;
            comm.Parameters.AddWithValue("@libro", pres.IDlibro);
            comm.Parameters.AddWithValue("@cliente", pres.IDCliente);
            comm.Parameters.AddWithValue("@fechapres", pres.Fechaprestamo);
            comm.Parameters.AddWithValue("@fechadev", pres.FechaDev);
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
        public void devolucion(int IDP)
        {
            DateTime theDate = DateTime.Now;
            string fecha = theDate.ToString("yyyy-MM-dd H:mm");
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3312;uid=root;pwd=;database=libros;");
            MySqlCommand comm = new MySqlCommand($"UPDATE `prestamos` SET `Fecha de devolucion`='{fecha}' WHERE ID = {IDP}", conn);
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
        public DataTable Busca(string titulo)
        {
            /*string querry = "";
            if (IDCat > 0)
            {
                querry = $"and categoria={IDCat}";
            }*/
            DataTable dtlibros = new DataTable();
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3312;uid=root;pwd=;database=libros;");
            MySqlCommand comm = new MySqlCommand($"SELECT * FROM `prestamos` WHERE ID LIKE concat('%','{titulo}','%');", conn);
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
        public DataTable filtrar()
        {
            DataTable dtl = new DataTable();
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3312;uid=root;pwd=;database=libros;");
            MySqlCommand comm = new MySqlCommand($"SELECT * FROM `prestamos` WHERE `Fecha de devolucion` LIKE concat ('%',\"****-**-** **:**\",'%');", conn);
            comm.CommandType = System.Data.CommandType.Text;
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(comm);
                da.Fill(dtl);
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            return dtl;
        }
    }
}
