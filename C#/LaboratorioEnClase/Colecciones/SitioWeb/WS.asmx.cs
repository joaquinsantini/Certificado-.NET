using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Entidades;
using Colecciones.BR;
using System.Data;

namespace SitioWeb
{
    /// <summary>
    /// Summary description for WS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WS : System.Web.Services.WebService
    {
        [WebMethod]
        public DataSet traerProductosPorCategoria(int cat)
        {
            AdmStock admSt = new AdmStock();
            DataSet ds = admSt.GetAllProducts2(cat);
            return ds;
        }
    }
}
