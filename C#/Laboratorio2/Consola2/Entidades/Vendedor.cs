using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Vendedor : Persona
    {
        // Atributos
        public string DNI { get; set; }

        // Constructor
        public Vendedor(string nom, string ape, string num_dni, string dir_email, string tel, string dir)
        {
            Nombre = nom;
            Apellido = ape;
            DNI = num_dni;
            Email = dir_email;
            Telefono = tel;
            Direccion = dir;
        }
    }
}
