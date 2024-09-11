using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System;
using System.Collections.Generic;

namespace PassingData.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            string userName = "muhammet marangoz";
            return View(userName as Object);
        }
        public IActionResult UrunGoster()
        {
            Product product = new Product();
            product.ProductName = "Televizyon";
            product.UnitPrice = 5;
            return View(product);
        }
        public IActionResult GetProductList ()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){ProductName="Bilgisayar",CategoryName="Elektronik",UnitPrice=7},
                new Product(){ProductName="Telefon",CategoryName="Elektronik",UnitPrice=5},
                new Product(){ProductName="Buz Dolabı",CategoryName="Beyaz Esya",UnitPrice=7},
                new Product(){ProductName="Koltuk",CategoryName="Ev Esyası",UnitPrice=7},
            };
            return View(products);
        }
    }
}
