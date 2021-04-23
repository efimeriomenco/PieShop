using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class PieCategory
    {
        public int pieCategoryId { get; set; }
        public string pieCategoryName { get; set; }
        public string pieCategoryDescription { get; set; }

        public List<Pie> Pies { get; set; }

    }
}
