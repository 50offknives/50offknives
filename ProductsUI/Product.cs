using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsUI
{
    public class Product
    {
        public string ModelNumber { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public float Size { get; set; }
        public string Type { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{ ModelNumber } - { Manufacturer } : { Type }";
            }
        }
    }
}
