using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Mercado
    {
        public Mercado(int id, double overUnder, double cuota_Over, double cuota_Under, double dinero_Over, double dinero_Under)
        {
            Id = id;
            OverUnder = overUnder;
            Cuota_Over = cuota_Over;
            Cuota_Under = cuota_Under;
            Dinero_Over = dinero_Over;
            Dinero_Under = dinero_Under;
        }

        public int Id { get; set; }
        public double OverUnder { get; set; }
        public double Cuota_Over { get; set; }
        public double Cuota_Under { get; set; }
        public double Dinero_Over { get; set; }
        public double Dinero_Under { get; set; }
    }

    public class MercadoDTO
    {
        public MercadoDTO(double overUnder, double cuota_Over, double cuota_Under, double dinero_Over, double dinero_Under)
        {
            OverUnder = overUnder;
            Cuota_Over = cuota_Over;
            Cuota_Under = cuota_Under;
            Dinero_Over = dinero_Over;
            Dinero_Under = dinero_Under;
        }

        public double OverUnder { get; set; }
        public double Cuota_Over { get; set; }
        public double Cuota_Under { get; set; }
        public double Dinero_Over { get; set; }
        public double Dinero_Under { get; set; }
    }
}