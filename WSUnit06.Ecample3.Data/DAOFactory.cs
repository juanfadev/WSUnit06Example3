using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WS.Unit06.Example3.Data.DAO;
using WSUnit06.Ecample3.Data;

namespace WS.Unit06.Example3.Data
{
    public class DAOFactory : IDisposable
    {
        private DataContext _context;

        public DAOFactory()
        {
            _context = new DataContext();
        }

        public IStatisticsDAO StatisticsDAO
        {
            get { return new StatisticsDAO(_context); }
        }

        
        public void Dispose() { _context.Dispose(); }
    }
}