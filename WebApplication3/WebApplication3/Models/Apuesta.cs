using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Apuesta
    {
        public Apuesta(int id, DateTime fecha, int dinero_Apostado, string tipo_Apuesta, double cuota, int id_Mercado)
        {
            this.id = id;
            this.fecha = fecha;
            this.dinero_Apostado = dinero_Apostado;
            this.tipo_Apuesta = tipo_Apuesta;
            this.cuota = cuota;
            Id_Mercado = id_Mercado;
        }

        public int id { get; set; }
        public DateTime fecha { get; set; }
        public int dinero_Apostado { get; set; }
        public string tipo_Apuesta { get; set; }
        public double cuota { get; set; }
        public int Id_Mercado { get; set; }
    }
    public class ApuestaDTO
    {
        public ApuestaDTO(int dinero_Apostado, string tipo_Apuesta, double cuota, int id_Mercado)
        {
            this.dinero_Apostado = dinero_Apostado;
            this.tipo_Apuesta = tipo_Apuesta;
            this.cuota = cuota;
            Id_Mercado = id_Mercado;
        }

        public int dinero_Apostado { get; set; }
        public string tipo_Apuesta { get; set; }
        public double cuota { get; set; }
        public int Id_Mercado { get; set; }
    }
}