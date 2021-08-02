using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlueSportMVC.Models;

namespace BlueSportMVC.ModelsDTO
{
    public class StoreDTO
    {
        public string name { get; set; }
        public string address { get; set; }
        public string webAddress { get; set; }
    }
    public static class StoreDTOExt
    {
        public static StoreModel ToGetStore(this StoreDTO storeDto)
        {
            return new StoreModel()
            {
                name = storeDto.name,
                address = storeDto.GetAddress(),
            };
        }

        public static string GetAddress(this StoreDTO storeDto)
        {
            return string.IsNullOrEmpty(storeDto.webAddress) ? storeDto.address : storeDto.webAddress;
        }
    }
}