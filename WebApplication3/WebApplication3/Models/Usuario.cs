using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    
    
    
    public class Usuario
    {


        public Usuario(int id, string email, string nombre, string apellido, string edad)
        {
            this.id = id;
            Email = email;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public int id { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Edad { get; set; }

    }
}