using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PieShop.Controllers
{
    public class PieCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
