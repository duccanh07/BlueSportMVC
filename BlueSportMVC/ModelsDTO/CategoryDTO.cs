using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlueSportMVC.Models;
namespace BlueSportMVC.ModelsDTO
{
    public class CategoryDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public int parentid { get; set; }
    }

    public static class CategoryDTOExt
    {
        public static CategoryModel ToGetCategory(this CategoryDTO categoryDTO)
        {
            return new CategoryModel
            {
                CategoryID = categoryDTO.id,
                CategoryName = categoryDTO.name,
                Level = categoryDTO.level,
            };
        }
        
    }
}