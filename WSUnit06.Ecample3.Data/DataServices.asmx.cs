using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WS.Unit06.Example3.Data;
using WSUnit06.Ecample3.Data.Model;

namespace WSUnit06.Ecample3.Data
{
    /// <summary>
    /// Descripción breve de DataServices
    /// </summary>
    [WebService(Namespace = "http://ws.unit06.ecample3/data")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class DataServices : System.Web.Services.WebService
    {

        [WebMethod]
        public Statistics[] GetStatistcs()
        {
            using (var factory = new DAOFactory())
            {
                return factory.StatisticsDAO.All().ToArray();
            }
        }

        [WebMethod]
        public long GetProductStatisticss(String name)
        {
            using (var factory = new DAOFactory())
            {
                var statistics = factory.StatisticsDAO.All().FirstOrDefault(p => p.ProductName == name);
                return statistics != null ? statistics.Visits : 0L;
            }
        }

        [WebMethod]
        public void CreateProductStatistics(String name)
        {
            using (var factory = new DAOFactory())
            {
                factory.StatisticsDAO.Add(new Statistics() { ProductName = "MALM", Visits = 10 });
            }
        }
    }
}
