using BlueSportMVC.Models;
using BlueSportMVC.ModelsDTO;
using BlueSportMVC.ViewModels;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlueSportMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var vm = new vmHome
            {
                lsBanner = GetBanners(),

                lsProductAll = GetProductsAll(),

                lsProductMale = GetProductsMale(),

                lsProductFemale = GetProductsFemale(),

                lsProductChildren = GetProductsChildren(),

                lsProductBicycle = GetProductsBicycle(),

                lsProductSport = GetProductsSport(),

                lsBrand = GetBrands(),

                lsBannerFooter = GetBannersFooter(),

                lsStore = GetStores(),

                lsCommitment = GetCommitments(),

                lsCategory = GetCategories(),
                
            };
            return View("~/Views/Home/Index.cshtml", vm);
        }

        private List<BlueSportMVC.Models.BannerModel> GetBanners()
        {
            // to do call api 

            var data = new List<BlueSportMVC.Models.BannerModel>();


            #region Get Data DTO => API
            var client = new RestClient("https://virtserver.swaggerhub.com/duccanh07/BlueSport-MWG/1.0.0/banner");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ModelsDTO.BannerDTO>>(response.Content);
            #endregion

            #region Mapping Data DTO => Model 
            List<BannerModel> bannerModel = new List<BannerModel>();
            foreach (var item in dataDto)
            {
                bannerModel.Add(item.ToGetBanner());
            }
            #endregion

            #region Data
            return bannerModel;
            #endregion


            //var data = new List<Models.BannerModel>();
            //    data.Add(new Models.BannerModel()
            //    {
            //        ImageUrl = "./images/banner.jpeg",
            //        ImageTitle = "Thể thao nam"
            //    });
            //    data.Add(new Models.BannerModel()
            //    {
            //        ImageUrl = "./images/banner.jpeg",
            //        ImageTitle = "Thể thao nam"
            //    });
            //    data.Add(new Models.BannerModel()
            //    {
            //        ImageUrl = "./images/banner.jpeg",
            //        ImageTitle = "Thể thao nam"
            //    });
            //    return data;
        }

        private List<BlueSportMVC.Models.ProductModel> GetProductsAll()
        {
            // to do call api 

            var data = new List<BlueSportMVC.Models.ProductModel>();


            #region Get Data DTO => API
            var client = new RestClient("https://virtserver.swaggerhub.com/duccanh07/BlueSport-MWG/1.0.0/product");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ModelsDTO.ProductDTO>>(response.Content);
            #endregion

            #region Mapping Data DTO => Model 
            List<ProductModel> productModels = new List<ProductModel>();
            foreach (var item in dataDto)
            {
                productModels.Add(item.ToGetProduct());
            }
            #endregion

            #region Data
            return productModels;
            #endregion

            /*var data = new List<Models.ProductModel>();
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand ="ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName= "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent= "6.964.000",
                PriceOld= "8.205.000",
                Percent= "20",
                Installment= "Góp 0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "Góp 0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "Góp 0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "Góp 0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true
                               
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });
            return data;*/
        }

        private List<BlueSportMVC.Models.ProductModel> GetProductsMale()
        {
            // to do call api 

            var data = new List<BlueSportMVC.Models.ProductModel>();


            #region Get Data DTO => API
            var client = new RestClient("https://virtserver.swaggerhub.com/duccanh07/BlueSport-MWG/1.0.0/product");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ModelsDTO.ProductDTO>>(response.Content);
            #endregion

            #region Mapping Data DTO => Model 
            List<ProductModel> productModels = new List<ProductModel>();
            foreach (var item in dataDto)
            {
                productModels.Add(item.ToGetProduct());
            }
            #endregion

            #region Data
            return productModels;
            #endregion

            /*var data = new List<Models.ProductModel>();
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "Góp 0",
               
            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "Góp 0",
               
            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "Góp 0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "Góp 0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });

            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "Góp 0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "Góp 0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });
            return data;*/
        }

        private List<BlueSportMVC.Models.ProductModel> GetProductsFemale()
        {
            var data = new List<Models.ProductModel>();
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });

            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });

            return data;
        }
        private List<BlueSportMVC.Models.ProductModel> GetProductsChildren()
        {
            var data = new List<Models.ProductModel>();
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });

            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });

            return data;
        }
        private List<BlueSportMVC.Models.ProductModel> GetProductsBicycle()
        {
            var data = new List<Models.ProductModel>();
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });

            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });

            return data;
        }
        private List<BlueSportMVC.Models.ProductModel> GetProductsSport()
        {
            var data = new List<Models.ProductModel>();
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "Góp 0",

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });

            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img02.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }

            });
            data.Add(new Models.ProductModel()
            {
                NameProduct = "Adizero Takumi Sen 7 Tokyo",
                NameBrand = "ADIDAS",
                ImageUrl = "./images/img01.png",
                ImageName = "ADIDAS Adizero Takumi Sen 7 Tokyo",
                PriceCurrent = "6.964.000",
                PriceOld = "8.205.000",
                Percent = "20",
                Installment = "0",
                ListImage = new List<ListImageModel>()
                        {
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = true

                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color02.png",
                                ImageName = "test",
                                ActiveImage = false
                            },
                            new ListImageModel
                            {
                                ImageUrl = "./images/img-color03.png",
                                ImageName = "test",
                                ActiveImage = false
                            }
                        }
            });

            return data;
        }
        private List<BlueSportMVC.Models.ListBrandModel> GetBrands()
        {
            var data = new List<Models.ListBrandModel>();
            data.Add(new Models.ListBrandModel()
            {
                BrandModel = new List<BrandModel>()
                        {
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu01.png",
                                ImageName = "thuong hieu",
                                width = 68,
                                height = 38
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu02.png",
                                ImageName = "thuong hieu",
                                width = 62,
                                height = 37
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu03.png",
                                ImageName = "thuong hieu",
                                width = 76,
                                height = 28
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu04.png",
                                ImageName = "thuong hieu",
                                width = 58,
                                height = 29
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu05.png",
                                ImageName = "thuong hieu",
                                width = 65,
                                height = 18
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu06.png",
                                ImageName = "thuong hieu",
                                width = 66,
                                height = 44
                            },
                        }
            });
            data.Add(new Models.ListBrandModel()
            {
                BrandModel = new List<BrandModel>()
                        {
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu02.png",
                                ImageName = "thuong hieu",
                                width = 68,
                                height = 38
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu03.png",
                                ImageName = "thuong hieu",
                                width = 62,
                                height = 37
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu01.png",
                                ImageName = "thuong hieu",
                                width = 76,
                                height = 28
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu06.png",
                                ImageName = "thuong hieu",
                                width = 58,
                                height = 29
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu05.png",
                                ImageName = "thuong hieu",
                                width = 65,
                                height = 18
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu04.png",
                                ImageName = "thuong hieu",
                                width = 66,
                                height = 44
                            },
                        }
            });
            data.Add(new Models.ListBrandModel()
            {
                BrandModel = new List<BrandModel>()
                        {
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu01.png",
                                ImageName = "thuong hieu",
                                width = 68,
                                height = 38
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu05.png",
                                ImageName = "thuong hieu",
                                width = 62,
                                height = 37
                            },
                            new BrandModel
                            {
                                ImageUrl = "./images/img_thuonghieu04.png",
                                ImageName = "thuong hieu",
                                width = 76,
                                height = 28
                            },
                         
                        }
            });

            return data;
        }
        private List<BlueSportMVC.Models.StoreModel> GetStores()
        {
            // to do call api 

            var data = new List<BlueSportMVC.Models.StoreModel>();


            #region Get Data DTO => API
            var client = new RestClient("https://virtserver.swaggerhub.com/duccanh07/BlueSport-MWG/1.0.0/store");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ModelsDTO.StoreDTO>>(response.Content);
            #endregion

            #region Mapping Data DTO => Model 


            List<StoreModel> storeModels = new List<StoreModel>();
            foreach (var item in dataDto)
            {
                storeModels.Add(item.ToGetStore());
            }
            #endregion

            #region Data
            return storeModels;
            #endregion

            //var data = new List<Models.VisitModel>();
            //data.Add(new Models.VisitModel()
            //{
            //    NameVisit = "Bluesport hàng xanh",
            //    Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            //});
            //data.Add(new Models.VisitModel()
            //{
            //    NameVisit = "Bluesport Quận 1",
            //    Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            //});
            //data.Add(new Models.VisitModel()
            //{
            //    NameVisit = "Bluesport Quận 2",
            //    Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            //});
            //data.Add(new Models.VisitModel()
            //{
            //    NameVisit = "Bluesport Quận 3",
            //    Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            //});
            //data.Add(new Models.VisitModel()
            //{
            //    NameVisit = "Bluesport Quận 4",
            //    Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            //});
            //data.Add(new Models.VisitModel()
            //{
            //    NameVisit = "Bluesport Quận 5",
            //    Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            //});
            //data.Add(new Models.VisitModel()
            //{
            //    NameVisit = "Bluesport Quận 6",
            //    Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            //});

            //return data;
        }
        private List<BlueSportMVC.Models.CommitmentModel> GetCommitments()
        {
            var data = new List<Models.CommitmentModel>();
            data.Add(new Models.CommitmentModel()
            {
                Icon = "icon-chinhhang",
                Title = "Chính hãng 100%",
                Detail = "Hơn 100 thương hiệu nổi tiếng"
            });
            data.Add(new Models.CommitmentModel()
            {
                Icon = "icon-mpgiaohang",
                Title = "Miễn phí giao hàng",
                Detail = "Cho đơn hàng trên 500.000đ"
            });
            data.Add(new Models.CommitmentModel()
            {
                Icon = "icon-doi1",
                Title = "1 đổi 1 trong vòng 1 năm",
                Detail = "Tại 200 cửa hàng trên toàn quốc",
                PathText = "Xem chi tiết",
                PathUrl = "#"
            });
            data.Add(new Models.CommitmentModel()
            {
                TextIcon = "0%",
                Title = "Trả góp 0%",
                Detail = "Qua thẻ hoặc duyệt hồ sơ với mọi sản phẩm trên 1.5 triệu",
            });
            return data;
        }

        private List<BlueSportMVC.Models.BannerModel> GetBannersFooter()
        {
            // to do call api 

            var data = new List<BlueSportMVC.Models.BannerModel>();


            #region Get Data DTO => API
            var client = new RestClient("https://virtserver.swaggerhub.com/duccanh07/BlueSport-MWG/1.0.0/bannerfooter");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ModelsDTO.BannerDTO>>(response.Content);
            #endregion

            #region Mapping Data DTO => Model 

            List<BannerModel> bannerFooter = new List<BannerModel>();
            foreach (var item in dataDto)
            {
                bannerFooter.Add(item.ToGetBanner());
            }
            #endregion

            #region Data
            return bannerFooter;
            #endregion


            /* var data = new List<Models.BannerModel>();
             data.Add(new Models.BannerModel()
             {
                 ImageUrl = "./images/img_trademark.jpeg",
                 ImageTitle = "Không gian trẻ trung, hiện đại tư vấn chuyên nghiệp, tận tình",
                 Title = "Không gian trẻ trung, hiện đại tư vấn chuyên nghiệp, tận tình"
             });
             data.Add(new Models.BannerModel()
             {
                 ImageUrl = "./images/img_trademark.jpeg",
                 ImageTitle = "Không gian trẻ trung, hiện đại tư vấn chuyên nghiệp, tận tình",
                 Title = "Không gian trẻ trung, hiện đại tư vấn chuyên nghiệp, tận tình"
             });
             data.Add(new Models.BannerModel()
             {
                 ImageUrl = "./images/img_trademark.jpeg",
                 ImageTitle = "Không gian trẻ trung, hiện đại tư vấn chuyên nghiệp, tận tình",
                 Title = "Không gian trẻ trung, hiện đại tư vấn chuyên nghiệp, tận tình"
             });
             return data; */
         }

        private List<BlueSportMVC.Models.CategoryModel> GetCategories()
        {
            var data = new List<BlueSportMVC.Models.CategoryModel>();

            #region Get Data DTO => API
            var client = new RestClient("https://virtserver.swaggerhub.com/duccanh07/BlueSport-MWG/1.0.0/category");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ModelsDTO.CategoryDTO>>(response.Content);
            #endregion

            #region Mapping Data DTO => Model 

            List<CategoryModel> categoryModels = new List<CategoryModel>();

            var parentCate = dataDto.Where(q => q.level == 0).ToList();
            var subCate = dataDto.Where(q => q.level == 1).ToList();
            var lastCate = dataDto.Where(q => q.level == 2).ToList();

                foreach (var item in parentCate)
                {   
                    //list category lever 0
                    var listParent = item.ToGetCategory();
                    listParent.subCate = new List<CategoryModel>();
                
                    //List category lever 1
                    var listSub = subCate.Where(s => s.parentid == listParent.CategoryID).ToList();
                    foreach (var sub in listSub)
                    {
                        var itemSub = sub.ToGetCategory();
                        itemSub.subCate = new List<CategoryModel>();
                        //List category lever 2
                        var listLast = lastCate.Where(a => a.parentid == sub.id).ToList();
                        foreach (var last in listLast)
                        {
                            itemSub.subCate.Add(last.ToGetCategory());
                        }
                        listParent.subCate.Add(itemSub);
                    }
                    categoryModels.Add(listParent);
                }

            #endregion
            
            #region Data
                return categoryModels;
            #endregion

                /* var data = new List<CategoryModel>();

                 var parentCate = dataTest.Where(p => p.Level == 0).ToList();
                 var subCate = dataTest.Where(p => p.Level == 1).ToList();
                 var lastCate = dataTest.Where(p => p.Level == 2).ToList();

                 foreach (var item in parentCate)
                 {
                     var itemParent = new CategoryModel()
                     {
                         CategoryID = item.CategoryID,
                         CaretegoryName = item.CaretegoryName,
                         Level =item.Level,
                         subCate = new List<SubCategoryModel>(),
                     };
                     var SubCate = subCate.Where(b => b.ParendId == item.CategoryID).ToList();
                     foreach(var sub in SubCate)
                     {
                         var itemSub = new SubCategoryModel()
                         {
                             CategoryID = sub.CategoryID,
                             CategoryName = sub.CaretegoryName,
                             Level = sub.Level,
                             lastCate = new List<LastCategoryModel>()
                         };
                         var LastCate = lastCate.Where(c => c.ParendId == sub.CategoryID).ToList();
                         foreach(var last in LastCate)
                         {
                             itemSub.lastCate.Add(new LastCategoryModel()
                             {
                                 CategoryID = last.CategoryID,
                                 CategoryName = last.CaretegoryName,
                                 Level =last.Level,
                             });
                         }
                         itemParent.subCate.Add(itemSub);
                     }
                     data.Add(itemParent);
                 }

                 return data;*/
                /*data.Add(new Models.CategoryModel()
                {
                    CategoryID = 1,
                    CaretegoryName = "Nam",
                    Level = 0,
                    subCate = new List<SubCategoryModel>()
                    {
                        new SubCategoryModel()
                        {
                            CategoryID = 1,
                            CategoryName = "Giày dép",
                            lastCate = new List<LastCategoryModel>()
                            {
                                new LastCategoryModel()
                                {
                                    CategoryID = 1,
                                    CategoryName = "Xem tất cả giày dép"
                                },
                                new LastCategoryModel()
                                {
                                    CategoryID = 1,
                                    CategoryName = "Adidas"
                                }
                            }
                        },
                        new SubCategoryModel()
                        {
                            CategoryID = 2,
                            CategoryName = "Phụ kiện"
                        },
                        new SubCategoryModel()
                        {
                            CategoryID = 3,
                            CategoryName = "Áo - quần",
                            lastCate = new List<LastCategoryModel>()
                            {
                                new LastCategoryModel()
                                {
                                    CategoryID = 1,
                                    CategoryName = "Xem tất cả giày dép"
                                },
                                new LastCategoryModel()
                                {
                                    CategoryID = 1,
                                    CategoryName = "Adidas"
                                }
                            }
                        }
                    },
                });
                data.Add(new Models.CategoryModel()
                {
                    CategoryID = 2,
                    CaretegoryName = "Nữ",
                    subCate = new List<SubCategoryModel>()
                    {
                        new SubCategoryModel()
                        {
                            CategoryID = 1,
                            CategoryName = "Giày dép",
                            lastCate = new List<LastCategoryModel>()
                            {
                                new LastCategoryModel()
                                {
                                    CategoryID = 1,
                                    CategoryName = "Adidas"
                                },
                                new LastCategoryModel()
                                {
                                    CategoryID = 2,
                                    CategoryName = "Puma"
                                },
                            }
                        },
                        new SubCategoryModel()
                        {
                            CategoryID = 2,
                            CategoryName = "Giày dép",
                            lastCate = new List<LastCategoryModel>()
                                {
                                    new LastCategoryModel()
                                    {
                                        CategoryID = 1,
                                        CategoryName = "Adidas"
                                    },
                                    new LastCategoryModel()
                                    {
                                        CategoryID = 2,
                                        CategoryName = "Puma"
                                    },
                                }
                        },
                        new SubCategoryModel()
                        {
                            CategoryID = 3,
                            CategoryName = "Giày dép"
                        }
                    },
                });
                data.Add(new Models.CategoryModel()
                {
                    CategoryID = 3,
                    CaretegoryName = "Trẻ em",
                    subCate = new List<SubCategoryModel>()
                    {
                        new SubCategoryModel()
                        {
                            CategoryID = 1,
                            CategoryName = "Giày dép"
                        },
                        new SubCategoryModel()
                        {
                            CategoryID = 2,
                            CategoryName = "Giày dép"
                        },
                           new SubCategoryModel()
                        {
                            CategoryID = 3,
                            CategoryName = "Giày dép"
                        }
                    },
                });
                data.Add(new Models.CategoryModel()
                {
                    CategoryID = 4,
                    CaretegoryName = "Thương hiệu",
                    subCate = new List<SubCategoryModel>()
                    {
                        new SubCategoryModel()
                        {
                            CategoryID = 1,
                            CategoryName = "Giày dép"
                        },
                        new SubCategoryModel()
                        {
                            CategoryID = 2,
                            CategoryName = "Áo - quần"
                        },
                        new SubCategoryModel()
                        {
                            CategoryID = 3,
                            CategoryName = "Phụ kiện"
                        }
                    },
                });
                data.Add(new Models.CategoryModel()
                {
                    CategoryID = 5,
                    CaretegoryName = "Môn thể thao",
                    subCate = new List<SubCategoryModel>()
                    {
                        new SubCategoryModel()
                        {
                            CategoryID = 1,
                            CategoryName = "Giày dép",
                            lastCate = new List<LastCategoryModel>()
                            {
                                new LastCategoryModel()
                                {
                                    CategoryID = 1,
                                    CategoryName = "Test1"
                                },
                                new LastCategoryModel()
                                {
                                    CategoryID = 1,
                                    CategoryName = "Test1"
                                },
                            }

                        },
                        new SubCategoryModel()
                        {
                            CategoryID = 2,
                            CategoryName = "Giày dép"
                        },
                        new SubCategoryModel()
                        {
                            CategoryID = 3,
                            CategoryName = "Giày dép",
                            lastCate = new List<LastCategoryModel>()
                            {
                                new LastCategoryModel()
                                {
                                    CategoryID = 1,
                                    CategoryName = "Adidas"
                                },
                                new LastCategoryModel()
                                {
                                    CategoryID = 1,
                                    CategoryName = "Puma"
                                },
                            }
                        }
                    },
                });
                data.Add(new Models.CategoryModel()
                {
                    CategoryID = 6,
                    CaretegoryName = "Phụ kiện thể thao",
                });
                return data;*/
            
        }
       public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}