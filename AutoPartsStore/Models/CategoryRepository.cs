using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Models
{
   public class CategoryRepository : ICategoryRepository
   {
      public IEnumerable<Category> GetAllCategories => new List<Category> { 
         new Category{CategoryId=1, CategoryName="Brakes", CategoryDescription="Parts for the braking system of your vehicle"},
         new Category{CategoryId=2, CategoryName="Engine", CategoryDescription="Parts for the engine of your vehicle"},
         new Category{CategoryId=3, CategoryName="Suspension", CategoryDescription="Parts for the suspension of your vehicle"}
      };
   }
}
