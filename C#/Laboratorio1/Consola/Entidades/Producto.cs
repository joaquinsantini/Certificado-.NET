using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Producto
    {
        // Atributos
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
        
        // Atributos de sólo lectura
        public double PrecioBruto
        {
            get
            {
                return PrecioCosto + Margen * PrecioCosto;
            }
        }
        public double PrecioVenta
        {
            get
            {
                return PrecioBruto + IVA * PrecioBruto;
            }
        }

        // Constructor
        public Producto(string nom, string desc, double precio_costo, double marg, double porc_iva, string prov, string cat, string subcat)
        {
            Nombre = nom;
            Descripcion = desc;
            PrecioCosto = precio_costo;
            Margen = marg;
            IVA = porc_iva;
            Proveedor = prov;
            Categoria = cat;
            SubCategoria = subcat;
        }
    }
}
