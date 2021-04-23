using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PieShop.Interfaces;

namespace PieShop.Models
{
    public class PieCategoryRepository : IPieCategory
    {
        private readonly AppDbContext _appDbContext;

        public PieCategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<PieCategory> AllPiesCategories => _appDbContext.PiesCategories;
    }
}
