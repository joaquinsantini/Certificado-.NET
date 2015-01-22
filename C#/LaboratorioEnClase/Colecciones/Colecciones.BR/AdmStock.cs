using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Entidades;
using Datos;

namespace Colecciones.BR
{
    public class AdmStock
    {
        // ******************************************* Métodos *******************************************
        /// <summary>
        /// Retorna una lista con todos los productos.
        /// </summary>
        /// <returns></returns>
        public List<Producto> GetAllProducts(int cat)
        {
            // Instancia de SQL
            SQL osql = new SQL();

            // Devuelvo la lista de productos
            return osql.MostrarProductos(cat);
        }

        public DataSet GetAllProducts2(int cat)
        {
            // Instancia de SQL
            SQL osql = new SQL();

            // Devuelvo la lista de productos
            return osql.MostrarProductos2(cat);
        }

        /// <summary>
        /// Da de alta un producto en la base de productos.
        /// </summary>
        /// <param name="prod">
        /// Producto a dar de alta.
        /// </param>
        public void altaProducto(Producto prod)
        {
            // Asigno valor de precio de venta
            prod.PrecioVenta = prod.PrecioCompra * Configuracion.Margen;

            // Instancia de SQL
            SQL osql = new SQL();

            // Doy de alta el producto
            osql.AltaProducto(prod);
        }
    }
}
