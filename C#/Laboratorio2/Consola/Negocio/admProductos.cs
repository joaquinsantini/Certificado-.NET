using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Entidades;

namespace Negocio
{
    public class admProductos
    {
        // Atributos
        private List<Producto> productos = new List<Producto>();

        // Métodos
        public List<Producto> Listar()
        {
            return productos;
        }

        public List<Producto> Listar(string categoria)
        {
            List<Producto> productosCategoria = new List<Producto>();

            foreach (Producto prod in productos)
            {
                if (prod.Categoria == categoria)
                {
                    productosCategoria.Add(prod);
                }
            }

            return productosCategoria;
        }

        public List<Producto> Listar(string categoria, string subCategoria)
        {
            List<Producto> productosCategoria = new List<Producto>();

            foreach (Producto prod in productos)
            {
                if (prod.Categoria == categoria && prod.SubCategoria == subCategoria)
                {
                    productosCategoria.Add(prod);
                }
            }

            return productosCategoria;
        }

        public Producto ListarDetalle(string nombre)
        {
            Producto producto;

            producto = productos.Find(x => x.Nombre == nombre);
            
            return producto;
        }
    }
}
