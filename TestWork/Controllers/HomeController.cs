using Microsoft.AspNetCore.Mvc;
using MvcSql.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestWork.Classes;
using TestWork.Data.Models;

namespace TestWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductsRepository productsRepository;
        public HomeController(ProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }
        
        public IActionResult Index()
        {
            var model = productsRepository.GetProduct();
            return View(model);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
