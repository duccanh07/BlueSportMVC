using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlueSportMVC.Models;

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

    public static class ProductDTOExt
    {
        public static ProductModel ToGetProduct(this ProductDTO productDto)
        {
            return new ProductModel
            {
                NameProduct = productDto.name,
                ImageUrl = productDto.image,
                PriceCurrent = productDto.priceCurrent,
                PriceOld = productDto.priceOld,
                Installment = productDto.installment,
                NameBrand = productDto.brandName,
                ImageName = productDto.imageName,
                Percent = productDto.saleOff
            };
        }
    }


}