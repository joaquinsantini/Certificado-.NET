using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Categorias
    {
        // ******************************************* Atributos *********************************************
        private int id;
        private string categoria;

        // ******************************************* Propiedades *******************************************
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Categoria
        {
            get
            {
                return categoria;
            }
            set
            {
                categoria = value;
            }
        }

    }
}
