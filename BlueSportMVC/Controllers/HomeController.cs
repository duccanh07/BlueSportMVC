using BlueSportMVC.Models;
using BlueSportMVC.ViewModels;
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

                lsVisit = GetVisits(),
            };
            return View("~/Views/Home/Index.cshtml", vm);
        }

        private List<BlueSportMVC.Models.BannerModel> GetBanners()
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
                    ImageUrl = "./images/banner.jpeg",
                    ImageTitle = "Thể thao nam"
                });
                data.Add(new Models.BannerModel()
                {
                    ImageUrl = "./images/banner.jpeg",
                    ImageTitle = "Thể thao nam"
                });
                data.Add(new Models.BannerModel()
                {
                    ImageUrl = "./images/banner.jpeg",
                    ImageTitle = "Thể thao nam"
                });
                return data;
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