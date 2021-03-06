using BlueSportMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueSportMVC.ViewModels
{
    public class vmHome
    {

        public List<BannerModel> lsBanner { get; internal set; }
        public List<StoreModel> lsStore { get; set; }
        public List<ProductModel> lsProductAll { get; set; }
        public List<ProductModel> lsProductMale { get; set; }
        public List<ProductModel> lsProductFemale { get; set; }
        public List<ProductModel> lsProductChildren { get; set; }
        public List<ProductModel> lsProductBicycle { get; set; }
        public List<ProductModel> lsProductSport { get; set; }
        public List<ListBrandModel> lsBrand { get; internal set; }
        public List<BannerModel> lsBannerFooter { get; internal set; }
        public List<CommitmentModel> lsCommitment { get; set; }
        public List<CategoryModel> lsCategory { get; set; }
    }


}