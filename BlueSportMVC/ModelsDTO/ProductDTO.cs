using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueSportMVC.ModelsDTO
{
    public class ProductDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string priceCurrent { get; set; }
        public string priceOld { get; set; }
        public string saleOff { get; set; }
        public string brandName { get; set; }
        public string imageName { get; set; }
        public string installment { get; set; }
        public string imageBrand { get; set; }
    }
}