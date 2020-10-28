using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Evento
    {
        public Evento(int id, string equipo_Local, string equipo_Visitante, DateTime fecha, int goles)
        {
            this.id = id;
            Equipo_Local = equipo_Local;
            Equipo_Visitante = equipo_Visitante;
            Fecha = fecha;
            Goles = goles;
        }

        public int id { get; set; }
        public string Equipo_Local { get; set; }
        public string Equipo_Visitante { get; set; }
        public DateTime Fecha { get; set; }
        public int Goles { get; set; }
    }
}