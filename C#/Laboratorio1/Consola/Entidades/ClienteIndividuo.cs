using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ClienteIndividuo
    {
        // Atributos
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CUIT { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        // Constructor
        public ClienteIndividuo(string nom, string ape, string num_cuit, string dir_email, string tel, string dir)
        {
            Nombre = nom;
            Apellido = ape;
            CUIT = num_cuit;
            Email = dir_email;
            Telefono = tel;
            Direccion = dir;
        }
    }
}
