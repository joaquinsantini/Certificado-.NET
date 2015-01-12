using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public abstract class DocumentoComercial
    {
        // Atributos
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIVA { get; set; }
        public string CondicionVenta { get; set; }
        public string Detalle { get; set; }
        public double Total { get; set; }

        // Constructor
        public DocumentoComercial()
        {
            // Constructor por defecto
        }
    }
}
