using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Factura
    {
        // Atributos
        public string Tipo { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIVA { get; set; }
        public string CondicionVenta { get; set; }
        public string Detalle { get; set; }
        public double Total { get; set; }

        // Constructor
        public Factura(string tip, string num, DateTime fech, string cli, string dir, string coniva, string convta, string det, double tot)
        {
            Tipo = tip;
            Numero = num;
            Fecha = fech;
            Cliente = cli;
            Direccion = dir;
            CondicionIVA = coniva;
            CondicionVenta = convta;
            Detalle = det;
            Total = tot;
        }
    }
}
