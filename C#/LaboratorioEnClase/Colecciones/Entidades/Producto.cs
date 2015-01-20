using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Producto
    {
        // ******************************************* Propiedades *******************************************
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }
    }
}
