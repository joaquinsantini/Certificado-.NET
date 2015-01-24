using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;
using System.Data;

namespace Colecciones.BR
{
    public class AdmCategorias
    {
        // ******************************************* Métodos ***********************************************
        /// <summary>
        /// Da de alta una categoría.
        /// </summary>
        /// <param name="categoria">
        /// Objeto Categoría inicializada.
        /// </param>
        public void AltaCategoria(Entidades.Categorias categoria)
        {
            // Instancia de clase SQL
            SQL osql = new SQL();

            // Ejecuto el método de alta de categoría
            osql.AltaCategoria(categoria);
        }

        public List<Entidades.Categorias> ConsultarCategorias()
        {
            // Instancia de clase SQL
            SQL osql = new SQL();

            // Devuelvo la lista de categorías
            return osql.MostrarCategorias();
        }
    }
}
