using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace h
{
    internal class Prodduct
    { 
        public Prodduct(double costprice)
        {
            _costPrice = costprice;
        }
        private double _costPrice;
        public string Name;
        public string Category { get; set; }



    }
}
