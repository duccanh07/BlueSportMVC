using BlueSportMVC.Models;
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

                lsVisit = GetVisits(),

                lsCommitment = GetCommitments()
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

            foreach (var item in dataDto)
            {
                data.Add(new Models.BannerModel()
                {
                    ImageUrl = item.pathImg,
                    ImageTitle = item.altImg,
                });
            }
            #endregion

            #region Data
            return data;
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
            var data = new List<Models.ProductModel>();
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


            return data;
        }

        private List<BlueSportMVC.Models.ProductModel> GetProductsMale()
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
            return data;
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
        private List<BlueSportMVC.Models.VisitModel> GetVisits()
        {
            var data = new List<Models.VisitModel>();
            data.Add(new Models.VisitModel()
            {
                NameVisit = "Bluesport hàng xanh",
                Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            });
            data.Add(new Models.VisitModel()
            {
                NameVisit = "Bluesport Quận 1",
                Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            });
            data.Add(new Models.VisitModel()
            {
                NameVisit = "Bluesport Quận 2",
                Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            });
            data.Add(new Models.VisitModel()
            {
                NameVisit = "Bluesport Quận 3",
                Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            });
            data.Add(new Models.VisitModel()
            {
                NameVisit = "Bluesport Quận 4",
                Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            });
            data.Add(new Models.VisitModel()
            {
                NameVisit = "Bluesport Quận 5",
                Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            });
            data.Add(new Models.VisitModel()
            {
                NameVisit = "Bluesport Quận 6",
                Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh, TP.Hồ Chí Minh",
            });

            return data;
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

            //var data = new List<BlueSportMVC.Models.BannerModel>();


            #region Get Data DTO => API
            //var client = new RestClient("http://172.16.2.198:2060/apibanner/getbannerbysite?siteID=2&categoryID=0&placeID=1535");
            //client.Timeout = -1;
            //var request = new RestRequest(Method.GET);
            //IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);
            //var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ModelsDTO.BannerDTO>>(response.Content);
            #endregion

            #region Mapping Data DTO => Model 

            //foreach (var item in dataDto)
            //{
            //    data.Add(new Models.BannerModel()
            //    {
            //        ImageUrl = item.DmxContent,
            //        Name = item.Description,
            //        //idxyz = item.BannerID
            //    });
            //}

            #endregion

            #region Data
            //return data;
            #endregion


            var data = new List<Models.BannerModel>();
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
            return data;
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