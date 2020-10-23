using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class MercadoRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Server=127.0.0.1;Port=3306;Database=bbdd_placemybet;Uid=root;password=;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }
        internal Mercado Retrieve()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from mercado";

            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            Mercado m = null;
            if (res.Read())
            {
                Debug.WriteLine("Recuperado:" + res.GetDouble(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetDouble(4));
                m = new Mercado(res.GetInt32(0), res.GetDouble(1), res.GetDouble(2), res.GetDouble(3), res.GetDouble(4), res.GetDouble(5));
            }

            con.Close();
            return m;
        }
        internal MercadoDTO RetrieveMercado(ApuestaDTO apuesta)
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();

            con.Open();


            if (apuesta.tipo_Apuesta == "Over")
            {
                command.CommandText = "UPDATE Mercado Set DineroOver = DineroOver + " + apuesta.dinero_Apostado + " WHERE ID= " + apuesta.Id_Mercado ;
            }
            else if (apuesta.tipo_Apuesta == "Under")
            {
                command.CommandText = "UPDATE Mercado Set DineroUnder = DineroUnder + " + apuesta.dinero_Apostado + " WHERE ID= " + apuesta.Id_Mercado;

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
                Debug.WriteLine("Se ha producido un error de conexión");
                return null;
            }
        }
        internal void Calculos(ApuestaDTO Apuesta, Mercado Dinero)
        {

            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            double probabilidadOver = Dinero.Dinero_Over / (Dinero.Dinero_Over + Dinero.Dinero_Under);
            double cuotaOver = 0;
            double over = 0.95;
            if (probabilidadOver != 0)
            {
                cuotaOver = 1 / probabilidadOver * 0.95;
                over = Math.Round((double)Convert.ToDouble(cuotaOver), 2);
            }

            double probabilidadUnder = Dinero.Dinero_Under / (Dinero.Dinero_Over + Dinero.Dinero_Under);
            double cuotaUnder = 0;
            double under = 0.95;
            if (probabilidadUnder != 0)
            {
                cuotaUnder = 1 / probabilidadUnder * 0.95;
                under = Math.Round((double)Convert.ToDouble(cuotaUnder), 2);
            }




            Debug.WriteLine("under: " + cuotaUnder + "dineroOver: " + Dinero.Dinero_Over + "dineroUnder: " + Dinero.Dinero_Under + "probabilidad: " + probabilidadUnder);
            Debug.WriteLine("under: " + under);
            con.Open();

            command.CommandText = "UPDATE Mercado SET CuotaUnder=" + under.ToString(CultureInfo.CreateSpecificCulture("us-US")) + ", CuotaOver =" + over.ToString(CultureInfo.CreateSpecificCulture("us-US")) + " WHERE ID= " + Dinero.Id + ";";
            Debug.WriteLine("Comando: " + command.CommandText);

            command.ExecuteNonQuery();


        }

    }
}