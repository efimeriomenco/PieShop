
using PieShop.Interfaces;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Mocks
{
    public class MockPieRepository : IPieRepository
    {
        private readonly IPieCategory _pieCategory = new MockPieCategory();
        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie {pieId=1,pieName="Strawberry pie",piePrice=15.9M,pieShortDesc="Tastes Good",pieLongDesc="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",pieWeidth=200, Category=_pieCategory.AllPiesCategories.ToList()[1],pieImageUrl ="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", pieIsFavourite= true, pieImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"},
                new Pie {pieId=2,pieName="Cheesecake pie",piePrice=16.3M,pieShortDesc="Tastes Good",pieLongDesc="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",pieWeidth=150, Category=_pieCategory.AllPiesCategories.ToList()[0] , pieImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", pieIsFavourite= false, pieImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg"},
                new Pie {pieId=3,pieName="Rhurbarb pie",piePrice=14.6M,pieShortDesc="Tastes Good",pieLongDesc="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",pieWeidth=170,Category=_pieCategory.AllPiesCategories.ToList()[2],pieImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", pieIsFavourite = true, pieImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg"},
                new Pie {pieId=4,pieName="Pumpkin pie",piePrice=11.0M,pieShortDesc="Tastes Good",pieLongDesc="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",pieWeidth=120,Category=_pieCategory.AllPiesCategories.ToList()[0],pieImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", pieIsFavourite = true, pieImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg"},
               

            };

        public IEnumerable<Pie> pieIsFavourite { get; }

        public Pie GetPieById(int pId)
        {
            return AllPies.FirstOrDefault(p => p.pieId == pId);
        }
    }
}
