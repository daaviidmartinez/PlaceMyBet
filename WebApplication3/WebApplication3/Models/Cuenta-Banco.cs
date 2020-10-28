using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Cuenta_Banco
    {
        public Cuenta_Banco(int tarjeta_Credito, string nombre_Banco, int saldo_Actual)
        {
            this.Tarjeta_Credito = tarjeta_Credito;
            this.Nombre_Banco = nombre_Banco;
            this.Saldo_Actual = saldo_Actual;
        }

        public int Tarjeta_Credito { get; set; }
        public String Nombre_Banco { get; set; }
        public int Saldo_Actual { get; set; }
    }
}