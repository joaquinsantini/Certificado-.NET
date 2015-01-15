using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Colecciones.BR
{
    public class AdmStock
    {
        // ******************************************* Métodos *******************************************
        /// <summary>
        /// Retorna una lista con todos los productos.
        /// </summary>
        /// <returns></returns>
        public List<Producto> GetAllProducts()
        {
            // Lista a devolver
            return Colecciones.Productos;
        }

        /// <summary>
        /// Da de alta un producto en la base de productos.
        /// </summary>
        /// <param name="prod">
        /// Producto a dar de alta.
        /// </param>
        public static void altaProducto(Producto prod)
        {
            prod.PrecioVenta = prod.PrecioCompra * Configuracion.Margen;
            Colecciones.Productos.Add(prod);
        }
    }
}
