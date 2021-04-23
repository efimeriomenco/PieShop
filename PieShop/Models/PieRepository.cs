using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PieShop.Interfaces;

namespace PieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get { return _appDbContext.Pies.Include(c => c.Category); }
        }

        public IEnumerable<Pie> pieIsFavourite
        {
            get
            {
                return _appDbContext.Pies.Include(c => c.Category).Where(p => p.pieIsFavourite);
            }
        } 
        public Pie GetPieById(int pieId)
        {
            
            {
                return _appDbContext.Pies.FirstOrDefault(p => p.pieId == pieId);
            }
        }
    }
}
