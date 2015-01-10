using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversiones
{
    class Program
    {
        static void Main(string[] args)
        {

            string v1 = "1000";
            string v2 = v1 + "888";

            Console.WriteLine(v2);

            Int32 Vn1 = Convert.ToInt32( v1);
            Int32 Vn2 = Vn1 + 888;
            Console.WriteLine(Vn2);


            Motor oMtr = new Motor();
            oMtr.Cv = 400;

            object obj = new object();
            obj = 321;
            obj = "lkjl";
            obj = oMtr;

            Motor oMtunBox = (Motor)obj;

            Console.WriteLine(oMtunBox.Cv);

            Console.ReadLine();

        }
    }
}
