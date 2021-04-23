using Microsoft.AspNetCore.Mvc;
using PieShop.Interfaces;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PieShop.ViewModels;

namespace PieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly IPieCategory _pieCategory;
        public PieController(IPieRepository pieRepository, IPieCategory pieCategory)
        {
            _pieRepository = pieRepository;
            _pieCategory = pieCategory;
        }
        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;
            return View(piesListViewModel);
        }
        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
            {
                return NotFound();
            }

            return View(pie);
        }

    }
}
