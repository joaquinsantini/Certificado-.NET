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
            List<Producto> productos = new List<Producto>();
            
            // Instancias
            Producto producto1 = new Producto();
            Producto producto2 = new Producto();
            Producto producto3 = new Producto();

            // Asignaciones a instancias
            /* producto1 */
            producto1.Codigo = 10;
            producto1.Descripcion = "Manzana";
            producto1.PrecioCompra = 3;
            producto1.PrecioVenta = 5;

            /* producto2 */
            producto2.Codigo = 20;
            producto2.Descripcion = "Pera";
            producto2.PrecioCompra = 5;
            producto2.PrecioVenta = 12;

            /* producto3 */
            producto3.Codigo = 30;
            producto3.Descripcion = "Ananá";
            producto3.PrecioCompra = 23;
            producto3.PrecioVenta = 38;

            // Inserto elementos en la lista
            productos.Add(producto1);
            productos.Add(producto2);
            productos.Add(producto3);

            return productos;
        }
    }
}
