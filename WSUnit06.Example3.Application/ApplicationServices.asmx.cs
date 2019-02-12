using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSUnit06.Example3.Application
{
    /// <summary>
    /// Descripción breve de ApplicationServices
    /// </summary>
    [WebService(Namespace = "http://ws.Unit06.example3/application")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ApplicationServices : System.Web.Services.WebService
    {

        [WebMethod]
        public string[] GetProducts()
        {
            //IkeaWSClient ikeaws = new IkeaWSClient();
            //return ikeaws.productList();
            return new string[]{"a", "b"};
        }
    }
}
