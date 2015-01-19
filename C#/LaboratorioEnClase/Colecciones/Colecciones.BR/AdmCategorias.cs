using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;

namespace Colecciones.BR
{
    public class AdmCategorias
    {
        // ******************************************* Métodos ***********************************************
        public void AltaCategoria(Entidades.Categorias categoria)
        {
            // Instancia de clase SQL.
            SQL osql = new SQL();

            // Ejecuto el método de alta de categoría.
            osql.AltaCategoria(categoria);
        }
    }
}
