using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAppAssignment.Models;

namespace MVCAppAssignment.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var product = GetProductsDeatils();

            return View(product);
        }

        public  IEnumerable<Product> GetProductsDeatils()
        {
            return new List<Product>
            {
                new Product{Product_Id=101 ,Product_Name="Ac",Rate=45000},
                new Product{Product_Id=102 ,Product_Name="Mobile",Rate=38000},
                new Product{Product_Id=103 ,Product_Name="Bike",Rate=94000}
            };
        }

        public ActionResult Deatils(int id)
        {
            var product = GetProductsDeatils().SingleOrDefault(c => c.Product_Id == id);
            if (product == null)
                return HttpNotFound();
            return View(product);
        }

    }
}