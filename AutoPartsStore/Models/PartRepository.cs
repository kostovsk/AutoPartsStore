using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Models
{
   public class PartRepository : IPartRepository
   {
      private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
      public IEnumerable<Part> GetAllParts => new List<Part> { 
         new Part {PartId=1, Name="POWER STOP JBR962EVC", Price=18.00M, Description="Power Stop's Evolution Coated rotors are direct bolt-on replacements for your daily driven vehicle. These rotors are fully coated, including inside the vanes, using Genuine GEOMET Coating for long lasting protection against rust and corrosion. The aluminum silver color of the coating looks great with today's open alloy wheels. To ensure a trouble-free installation, these rotors are OE weight and vane configuration to guarantee they fit your vehicle.", Category=_categoryRepository.GetAllCategories.ToList()[0], ImageUrl="https://www.rockauto.com/info/568/JBR962EVC__ra_p.jpg", IsInStock=true,IsOnSale=false,ImageThumbnailUrl="https://www.rockauto.com/info/568/JBR962EVC__ra_p.jpg"},
         new Part {PartId=2, Name="MELLING 31035S Timing Chain Set", Price=124.89M, Description="Melling is a leader in engineering design, development, prototype, testing and assembly of fluid delivery products and related items for the automotive OEM industry as well as the aftermarket industry. In addition to being a leading manufacturer of aftermarket oil pumps, they also offer camshafts, timing components, valve train, cylinder sleeves, expansion plugs, and tools for the engine building industry.", Category=_categoryRepository.GetAllCategories.ToList()[1], ImageUrl="https://www.rockauto.com/info/583/3-1035S-1-KIT__ra_p.jpg", IsInStock=true,IsOnSale=false,ImageThumbnailUrl="https://www.rockauto.com/info/583/3-1035S-1-KIT__ra_p.jpg"},
         new Part {PartId=3, Name="KYB SR4241 Strut", Price=121.79M, Description="Includes a KYB Excel-G strut. Excel-G struts use OE quality components to restore the vehicle's original designed performance. KYB tests each spring design and does not consolidate applications, to make sure that every Strut-Plus restores vehicle ride height to within the manufacturer's specifications. Damping valves are assembled by hand to restore the handling and stability to what the vehicle manufacturer intended. This is critical to make sure electronic safety systems, like Electronic Stability Control and Automated Braking, work as designed. The strongest and thickest strut bodies and brackets in the industry minimize flex, to keep the alignment correct and you in control. OE or better strut mounts prevent squeaking and rattling. Each part is tested for durability, and each design is fit checked and ride tested, for ease of installation and performance.", Category=_categoryRepository.GetAllCategories.ToList()[2], ImageUrl="https://www.rockauto.com/info/63/SR4241__ra_p.jpg", IsInStock=true,IsOnSale=true,ImageThumbnailUrl="https://www.rockauto.com/info/63/SR4241__ra_p.jpg"}
      };

      public IEnumerable<Part> GetPartsOnSale => throw new NotImplementedException();

      public Part GetPartById(int partId)
      {
         return GetAllParts.FirstOrDefault(p => p.PartId == partId);
      }
   }
}
