using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportsStore;
using SportsStore.AppService;
using SportStore.Models;

namespace SportStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Jacket()
        {
            return View(GetData(1));
        }

        public IActionResult Shirt()
        {
            return View(GetData(3));
        }
        public IActionResult Pant()
        {
            return View(GetData(2));
        }
        public IActionResult Underwear()
        {
            return View(GetData(4));
        }
        public IActionResult Short()
        {s
            return View(GetData(5));
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
        private ICollection<AppService> GetData(int category)
        {
            using (var db = new ProductDbContext())
            {
                var ProductForView = new List<AppService>();
                foreach (var item in db.products.ToList())
                {
                    var Product = new AppService();
                    if (item.CategoryId == category)
                    {
                        var location = db.productPictures.Where(a => a.ProductPictureId == item.ProductId).Select(p => p.PictureLocation).FirstOrDefault();
                        if (item.Name != null || location != null)
                        {
                            Product.Name = item.Name;
                            Product.Prices = item.Price;
                            Product.Location = location;
                            ProductForView.Add(Product);
                        }
                    }
                }
                return ProductForView;
            }
        }
    }
}
