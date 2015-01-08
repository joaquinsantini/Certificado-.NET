using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Remito : DocumentoComercial
    {
        // Atributos
        public DateTime FechaEntrega { get; set; }

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
