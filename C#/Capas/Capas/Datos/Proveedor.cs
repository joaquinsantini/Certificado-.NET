using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
   public  class Proveedor
    {
        #region privadas

        private int codigo;
        private string razonSoCIAL;
        private int deuda;
        #endregion

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }


        public string RazonSoCIAL
        {
            get { return razonSoCIAL; }
            set { razonSoCIAL = value; }
        }


        public int Deuda
        {
            get { return deuda; }
            set { deuda = value; }
        }
    }
}
