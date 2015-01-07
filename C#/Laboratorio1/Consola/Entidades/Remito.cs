using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Remito
    {
        // Atributos
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIVA { get; set; }
        public string CondicionVenta { get; set; }
        public string Detalle { get; set; }
        public DateTime FechaEntrega { get; set; }
        public double Total { get; set; }

        // Constructor
        public Remito(string num, DateTime fech, string cli, string dir, string coniva, string convta, string det, DateTime fechent, double tot)
        {
            Numero = num;
            Fecha = fech;
            Cliente = cli;
            Direccion = dir;
            CondicionIVA = coniva;
            CondicionVenta = convta;
            Detalle = det;
            FechaEntrega = fechent;
            Total = tot;
        }
    }
}
