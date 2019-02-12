﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using WSUnit06.Ecample3.Data;
using WSUnit06.Ecample3.Data.Model;

namespace WS.Unit06.Example3.Data.DAO
{
    public class StatisticsDAO : GenericDAO<Statistics>, IStatisticsDAO
    {
        public StatisticsDAO(DataContext context) : base(context)
        {
        }
    }
}
