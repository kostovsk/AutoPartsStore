using AutoPartsStore.Models;
using AutoPartsStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Controllers
{
   public class ShoppingCartController : Controller
   {
      private readonly IPartRepository _partRepository;
      private readonly ShoppingCart _shoppingCart;

      public ShoppingCartController(IPartRepository partRepository, ShoppingCart shoppingCart)
      {
         _partRepository = partRepository;
         _shoppingCart = shoppingCart;
      }

      public ViewResult Index()
      {
         _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

         var shoppingCartViewModel = new ShoppingCartViewModel
         {
            ShoppingCart = _shoppingCart,
            ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
         };

         return View(shoppingCartViewModel);
      }
   }
}
