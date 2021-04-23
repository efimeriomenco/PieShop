using PieShop.Interfaces;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Mocks
{
    public class MockPieCategory : IPieCategory
    {
        public IEnumerable<PieCategory> AllPiesCategories =>
            new List<PieCategory>
            {
                new PieCategory{pieCategoryId=0,pieCategoryName="Fruit pies" , pieCategoryDescription="Very delicious and good taste with freshest fruits."},
                new PieCategory{pieCategoryId=1,pieCategoryName="Cheese pies" , pieCategoryDescription="Cheesy all the way."},
                new PieCategory{pieCategoryId=2,pieCategoryName="Seasonal pies" , pieCategoryDescription="Get in the mood for seasonal pie."}

            };
    }
}
