using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class Pie
    {
        public int pieId { get; set; }
        public string pieName { get; set; }
        public decimal piePrice { get; set; }
        public string pieImageUrl { get; set; }
        public string pieImageThumbnailUrl { get; set; }
        public int pieWeidth { get; set; }
        public bool pieIsFavourite { get; set; }
        public string pieShortDesc { get; set; }
        public string pieLongDesc { get; set; }
        public int pieCategoryId { get; set; }
        public PieCategory Category { get; set; }
    }
}
