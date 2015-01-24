using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Data;

namespace Colecciones.BR
{
    public class AdmCotizaciones
    {
        // ******************************************* Métodos ***********************************************
        public static void AltaCotizaciones(string especie, DateTime fecha, decimal cotizacion)
        {
            // Instancia de SQL
            SQL osql = new SQL();

            // Alta de cotización
            osql.AltaCotizaciones(especie, fecha, cotizacion);
        }

        public static DataSet Analisis()
        {
            // Instancia de SQL
            SQL osql = new SQL();

            // Ejecuto método
            return osql.Analisis();
        }
    }
}
