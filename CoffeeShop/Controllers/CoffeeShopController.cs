using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Data;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class CoffeeShopController : Controller
    {
        [HttpPost]
        public IActionResult ProductList(UserInfo userInfo)
        {
            Product product = new Product();
            List < Product > productList = new List<Product>();

            ProductsContext productsContext = new ProductsContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ProductsContext>());
            var productThing = productsContext.Products.ToList<Product>();

            ViewBag.Name = userInfo.UserName;

            return View("CoffeeList", productThing);
        }

        public IActionResult Login()
        {
            
            return View();
        }
        
        public IActionResult Welcome()
        {
            
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        
    }
}