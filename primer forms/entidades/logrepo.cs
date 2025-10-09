using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace primer_forms.entidades
{
    internal class logrepo
    {
        public static bool Login(string username, string password)
        {
            bool _login = false;
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3312;uid=root;pwd=;database=libros;");
            MySqlCommand comm = new MySqlCommand($"SELECT * FROM `usuarios` WHERE `Nombre` LIKE concat(\"%\",\"{username}\",\"%\") AND `Contraseña` LIKE concat(\"%\",\"{password}\",\"%\");", conn);
            comm.CommandType = System.Data.CommandType.Text;
            try
            {
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        _login = true;
                    }
                }
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            return _login;
        }
        public static bibliotecario Login2(string username, string password)
        {
            bibliotecario usuario = new bibliotecario();
            usuario.ID = 0;
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3312;uid=root;pwd=;database=libros;");
            MySqlCommand comm = new MySqlCommand($"SELECT * FROM `usuarios` WHERE `Nombre`= concat(\"%\",\"{username}\",\"%\") AND `Contraseña` = concat(\"%\",\"{password}\",\"%\");", conn);
            comm.CommandType = System.Data.CommandType.Text;
            try
            {
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                       usuario.ID=Convert.ToInt32(dr["ID"].ToString());
                       usuario.Nombre  = dr["Nombre"].ToString();
                    }
                }
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            return usuario;
        }
    }
}
