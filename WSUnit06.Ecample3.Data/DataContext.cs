using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WSUnit06.Ecample3.Data.Model;

namespace WSUnit06.Ecample3.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Statistics> Statistics { get; set; }

        public DataContext() : base()
        {
            Database.SetInitializer(new DataInitializer());
        }
    }

    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            base.Seed(context);
            context.Statistics.Add(new Statistics() {ProductName = "MALM", Visits = 10});
            context.Statistics.Add(new Statistics() { ProductName = "BEKANT", Visits = 5 });
            context.SaveChanges();
        }
    }
}