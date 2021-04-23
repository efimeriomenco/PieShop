using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Interfaces
{
    public interface IPieCategory
    {
        IEnumerable<PieCategory> AllPiesCategories { get; }
    }
}
