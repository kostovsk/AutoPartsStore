using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Models
{
   public class ShoppingCart
   {
      private readonly AppDbContext _appDbContext;
      public string ShoppingCartId { get; set; }
      public List<ShoppingCartItem> ShoppingCartItems { get; set; }

      public ShoppingCart(AppDbContext appDbContext)
      {
         _appDbContext = appDbContext;
      }

      public static ShoppingCart GetCart(IServiceProvider services)
      {
         ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

         var context = services.GetService<AppDbContext>();
         string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
         session.SetString("CartId", cartId);

         return new ShoppingCart(context) { ShoppingCartId = cartId };
      }

      public void AddToCart(Part part, int amount)
      {
         var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(s => s.Part.PartId == part.PartId && s.ShoppingCartId == ShoppingCartId);

         if (shoppingCartItem == null)
         {
            shoppingCartItem = new ShoppingCartItem
            {
               ShoppingCartId = ShoppingCartId,
               Part = part,
               Amount = amount
            };

            _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
         }
         else
         {
            shoppingCartItem.Amount++;
         }

         _appDbContext.SaveChanges();
      }
   }
}
