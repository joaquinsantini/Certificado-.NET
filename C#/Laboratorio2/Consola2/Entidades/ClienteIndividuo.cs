using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ClienteIndividuo : Persona
    {
        // Atributos
        public string CUIT { get; set; }

        // Constructor
        public ClienteIndividuo(string nom, string ape, string dir_email, string tel, string dir, string num_cuit)
        {
            Nombre = nom;
            Apellido = ape;
            Email = dir_email;
            Telefono = tel;
            Direccion = dir;
            CUIT = num_cuit;
        }
    }
}
