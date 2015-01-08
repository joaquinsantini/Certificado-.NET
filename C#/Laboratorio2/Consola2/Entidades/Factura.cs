using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Factura : DocumentoComercial
    {
        // Atributos
        public string Tipo { get; set; }

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
