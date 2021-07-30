using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueSportMVC.Models
{
    public class ListImageModel
    {
        public String ImageUrl { get; set; }
        public String ImageName { get; set; }

        public Boolean ActiveImage { get; set; }
    }
}