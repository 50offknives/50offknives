using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsUI
{
    public class Price
    {
        public string ModelNumber { get; set; }
        public DateTime ChangeDate { get; set; }
        public float List { get; set; }
        public float Promotion { get; set; }
        public float Cost { get; set; }
        public float Retail { get; set; }
        public float eBaySold { get; set; }
        public float eBayList { get; set; }
        public float eBayPromotion { get; set; }
        public float eBay_ecop { get; set; }
        public float BaseCalc { get; set; }

        public string FullPriceInfo
        {
            get
            {
                return $"List Price: { List } - - Cost: { Cost }";
            }
        }
    }
}
