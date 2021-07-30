using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueSportMVC.Models
{
    public class ProductModel
    {
        public String NameProduct { set; get; }
        public String NameBrand { set; get; }
        public String ImageUrl { set; get; }
        public String ImageName { set; get; }
        public String PriceCurrent { set; get; }
        public String PriceOld { set; get; }
        public String Percent { set; get; }
        public String Installment { set; get; }
        public List<ListImageModel> ListImage { get; set; }
    }
}