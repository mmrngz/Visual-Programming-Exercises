using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products=new List<Product>() 
        { 
            new Product(){Id= 1,ProductName="Kitap",CategoryName="Kırtasiye"},
            new Product(){Id= 2,ProductName="Televizyon",CategoryName = "Elektronik"},
            new Product(){Id= 3,ProductName="Buzdolabi",CategoryName = "Ev Eşyası"  },
            new Product(){Id= 4,ProductName="Kalem",CategoryName = "Kırtasiye"},
        }; 

        public IActionResult GetAllProducts()
        {
            
            return View(products);
        }
        public IActionResult GetProductsById(int id)
        {
            Product product = products.Find(x => x.Id == id);
            if (product == null)
            {
                ViewBag.Error = "Verdiğiniz id Sistemde Bulunmamaktadir...";
            }
            return View(product);
        }
		public IActionResult GetProductsByCategoryName(string CategoryName)
		{
			Product product = products.Find(x => x.CategoryName == CategoryName);
			if (product == null)
			{
				ViewBag.Error = "Verdiğiniz Category Sistemde Bulunmamaktadir...";
			}
			return View(product);
		}
	}
}
