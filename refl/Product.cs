using System;
using System.Collections.Generic;
using System.Text;

namespace REFL
{
    internal class Product
    {
        public Product(double costPrice)
        {
            _costPrice = costPrice;
        }
        private double _costPrice;
        public double salePrice;

        public string Name;
        public string Category { get; set; }


    }
}
