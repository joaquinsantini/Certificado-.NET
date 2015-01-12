using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Empresa
    {
        // Atributos
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public string Contacto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        // Constructor
        public Empresa(string nom, string num_cuit, string cont, string dir_email, string tel, string dir)
        {
            Nombre = nom;
            CUIT = num_cuit;
            Contacto = cont;
            Email = dir_email;
            Telefono = tel;
            Direccion = dir;
        }
    }
}
