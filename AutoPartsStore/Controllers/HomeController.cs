using AutoPartsStore.Models;
using AutoPartsStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Controllers
{
   public class HomeController : Controller
   {
      private readonly IPartRepository _partRepository;

      public HomeController(IPartRepository partRepository)
      {
         _partRepository = partRepository;
      }

      public IActionResult Index()
      {
         var homeViewModel = new HomeViewModel
         {
            PartsOnSale = _partRepository.GetPartsOnSale
         };

         return View(homeViewModel);
      }
   }
}
