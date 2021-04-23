using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PieShop.Interfaces;
using PieShop.Models;

namespace PieShop.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly IPieCategory _pieCategory;

        public CategoryMenu(IPieCategory pieCategory)
        {
            _pieCategory = pieCategory;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _pieCategory.AllPiesCategories.OrderBy(c => c.pieCategoryName);
            return View(categories);
        }
    }
}
