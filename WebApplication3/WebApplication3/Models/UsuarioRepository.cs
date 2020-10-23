using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class UsuarioRepository
    {       private MySqlConnection Connect()
        {
            string connString = "Server=127.0.0.1;Port=3306;Database=bbdd_placemybet;Uid=root;password=;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }

        internal Usuario Retrieve()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from usuario";

            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            Usuario u = null;
            if (res.Read())
            {
               Debug.WriteLine("Recuperado:" + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetString(3) + " " + res.GetString(4));
                u = new Usuario(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetString(3), res.GetString(4));

            }

            con.Close();
            return u;
        }
    }
}