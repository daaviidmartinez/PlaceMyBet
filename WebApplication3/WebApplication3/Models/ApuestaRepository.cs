using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class ApuestaRepository
    {

        private MySqlConnection Connect()
        {
            string connString = "Server=127.0.0.1;Port=3306;Database=bbdd_placemybet;Uid=root;password=;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }
        internal Apuesta Retrieve()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from apuesta";

            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            Apuesta a = null;
            if (res.Read())
            {
                Debug.WriteLine("Recuperado:" + res.GetInt32(0) + " " + res.GetDateTime(1) + " " + res.GetInt32(2) + " " + res.GetString(3) + " " + res.GetDouble(4) + " " + res.GetInt32(5));
                a = new Apuesta(res.GetInt32(0), res.GetDateTime(1), res.GetInt32(2), res.GetString(3), res.GetDouble(4), res.GetInt32(5));
            }

            con.Close();
            return a;
        }

        internal ApuestaDTO RetrieveDTO()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select fecha, Dinero_Apostado,Tipo_Apuesta, Cuota from Apuesta";

            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            ApuestaDTO a = null;

            if (res.Read())
            {
                Debug.WriteLine("Recuperado:  " + res.GetInt32(1) + " " + res.GetString(2) + " " + res.GetDouble(3) + " " + res.GetInt32(4));
                a = new ApuestaDTO(res.GetInt32(1), res.GetString(2), res.GetDouble(3), res.GetInt32(4));

            }

            con.Close();
            return a;
        }

        internal MercadoDTO RetrieveCuota(ApuestaDTO apuesta)
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();

            if (apuesta.tipo_Apuesta == "Over")
            {
                command.CommandText = "SELECT CuotaOver FROM mercado WHERE id = " + apuesta.Id_Mercado;
            }
            else if (apuesta.tipo_Apuesta == "Under")
            {
                command.CommandText = "SELECT CuotaUnder FROM mercado WHERE id = " + apuesta.Id_Mercado;
            }

            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();
                MercadoDTO m = null;
                if (res.Read())
                {
                    m = new MercadoDTO(res.GetDouble(0), res.GetDouble(1), res.GetDouble(2), res.GetDouble(3), res.GetDouble(4));
                }
                return m;
            }
            catch (MySqlException a)
            {
                Debug.WriteLine("Se ha producido un error");
                    return null;
            }
        }
    }
}