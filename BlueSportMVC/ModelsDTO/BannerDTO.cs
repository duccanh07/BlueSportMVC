using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlueSportMVC.Models;

namespace BlueSportMVC.ModelsDTO
{
    public class BannerDTO
    {
        public string pathImg { get; set; }
        public string altImg { get; set; }
        public string description { get; set; }
    }

    public static class BannerDTOExt
    {
        public static BannerModel ToGetBanner(this BannerDTO bannerDto)
        {
            return new BannerModel()
            {
                ImageUrl = bannerDto.pathImg,
                ImageTitle = bannerDto.altImg,
                Title = bannerDto.description
            };
        }
    }
}