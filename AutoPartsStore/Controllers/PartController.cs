using AutoPartsStore.Models;
using AutoPartsStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Controllers
{
   public class PartController : Controller
   {
      private readonly IPartRepository _partRepository;
      private readonly ICategoryRepository _categoryRepository;

      public PartController(IPartRepository partRepository, ICategoryRepository categoryRepository)
      {
         _partRepository = partRepository;
         _categoryRepository = categoryRepository;
      }

      public IActionResult List()
      {
         //ViewBag.CurrentCategory = "Bestsellers";
         //return View(_partRepository.GetAllParts);

         var partListViewModel = new PartListViewModel();
         partListViewModel.Parts = _partRepository.GetAllParts;
         partListViewModel.CurrentCategory = "Bestsellers";
         return View(partListViewModel);
      }
   }
}
