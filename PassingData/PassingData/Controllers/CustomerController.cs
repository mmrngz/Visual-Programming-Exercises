using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using PassingData.Models.ViewModel;
using System;
using System.Collections.Generic;

namespace PassingData.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> customers=new List<Customer>() 
        {
            new Customer(){FirstName="Muhammet",LastName="Marangoz"},
            new Customer(){FirstName="Ada",LastName="Ceylan"},
            new Customer(){FirstName="Bahadır",LastName="Aygul"},

        };
        public IActionResult UseViewModel()
        {
            Product product = new Product();
            product.ProductName = "Monitor";
            product.UnitPrice = 1;
            product.CategoryName = "Elektronik";

            string date = DateTime.Now.ToString();

            CustomerAndProductVM customerAndProductVM=new CustomerAndProductVM();
            customerAndProductVM.product = product;
            customerAndProductVM.date = date;
            customerAndProductVM.customers = customers;

            return View(customerAndProductVM);
        }
        public IActionResult UseTuple()
        {
            
            Product product = new Product();
            product.ProductName = "Telefon";
            product.UnitPrice = 4;
            product.CategoryName = "Elektronik";

            string date = DateTime.Now.ToString();

            (List<Customer>,Product,string) customerAndProduct =(customers, product, date);
            return View(customerAndProduct);


        }
    }
}
