using AutoPartsStore.Models;
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

      public ViewResult List()
      {
         return View(_partRepository.GetAllParts);
      }
   }
}
