using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SSGeek.Web.DAL;
using SSGeek.Web.Models;

namespace SSGeek.Web.Controllers
{
    public class StoreController : Controller
    {
        private IProductDAO productDAO;

        public StoreController(IProductDAO productDAO)
        {
            this.productDAO = productDAO;
        }


        public IActionResult Index()
        {
            IList<Product> products = productDAO.GetProducts();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            Product product = productDAO.GetProduct(id);

            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}