using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Models
{
   public class PartRepository : IPartRepository
   {
      private readonly AppDbContext _appDbContext;

      public PartRepository(AppDbContext appDbContext)
      {
         _appDbContext = appDbContext;
      }

      public IEnumerable<Part> GetAllParts
      {
         get
         {
            return _appDbContext.Parts.Include(c => c.Category);
         }
      }

      public IEnumerable<Part> GetPartsOnSale {
         get
         {
            return _appDbContext.Parts.Include(c => c.Category).Where(p => p.IsOnSale);
         }
      }

      public Part GetPartById(int partId)
      {
         return _appDbContext.Parts.FirstOrDefault(p => p.PartId == partId);
      }
   }
}
