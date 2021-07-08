using AutoPartsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.ViewModels
{
   public class PartListViewModel
   {
      public IEnumerable<Part> Parts { get; set; }
      public string CurrentCategory { get; set; }
   }
}
