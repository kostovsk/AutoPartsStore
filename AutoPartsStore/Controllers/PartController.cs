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

      public ViewResult List(string category)
      {
         IEnumerable<Part> parts;
         string currentCategory;

         if (string.IsNullOrEmpty(category))
         {
            parts = _partRepository.GetAllParts.OrderBy(c => c.PartId);
            currentCategory = "All Candy";
         }
         else
         {
            parts = _partRepository.GetAllParts.Where(c => c.Category.CategoryName == category);

            currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
         }

         return View(new PartListViewModel
         {
            Parts = parts,
            CurrentCategory = currentCategory
         });
      }

      public IActionResult Details(int id)
      {
         var part = _partRepository.GetPartById(id);
         if (part == null)
            return NotFound();

         return View(part);
      }
   }
}
