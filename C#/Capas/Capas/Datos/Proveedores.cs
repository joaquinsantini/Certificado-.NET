using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace Datos
{
    public  class Proveedores
    {

        public ArrayList TraerTodos()
        {
            Proveedor opr1 = new Proveedor();
            opr1.Codigo = 111;
            opr1.Deuda = 100;
            opr1.RazonSoCIAL = "Casa TIA";
          
            Proveedor opr2 = new Proveedor();
            opr2.Codigo = 1;
            opr2.Deuda = 10;
            opr2.RazonSoCIAL = "DISCO";
           
            Proveedor opr3 = new Proveedor();
            opr3.Codigo = 111;
            opr3.Deuda = 100;
            opr3.RazonSoCIAL = "CARREFOUR";

            ArrayList oARL = new ArrayList();           
            oARL.Add(opr1);
            oARL.Add(opr2);
            oARL.Add(opr3);


            return oARL;
        }

    }
}
