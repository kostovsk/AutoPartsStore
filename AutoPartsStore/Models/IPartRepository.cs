using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Models
{
   public interface IPartRepository
   {
      IEnumerable<Part> GetAllParts { get; }
      IEnumerable<Part> GetPartsOnSale { get; }
      Part GetPartById(int partId);
   }
}
