using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Entidades;

namespace Negocio
{
    public class admCompras
    {
        // Atributos
        private List<Producto> productos = new List<Producto>();

        // Métodos
        public void Agregar(Producto item, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                productos.Add(item);
            }
        }

        public void Modificar(int cantidad)
        {
            // Comportamiento para modificar producto por cantidad.
        }

        public void Eliminar(string nombre)
        {
            productos.RemoveAll(x => x.Nombre == nombre);
             
        }

        public void Confirmar(Vendedor vendedor)
        {
            // Comportamiento para confirmar compra por vendedor.
        }

        public void Cancelar()
        {
            // Comportamiento para cancelar compra.
        }
    }
}
