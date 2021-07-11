using AutoPartsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.ViewModels
{
   public class HomeViewModel
   {
      public IEnumerable<Part> PartsOnSale { get; set; }
   }
}
