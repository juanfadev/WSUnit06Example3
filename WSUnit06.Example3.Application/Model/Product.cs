using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSUnit06.Example3.Application.Model
{
    public class Product
    {
        public String Name { get; set; }
        public double ProductPrice { get; set; }
        public double ShippingPrice { get; set; }
        public double FinalPrice => ProductPrice * 1.20;
    }
}