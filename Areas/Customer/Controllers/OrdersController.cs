using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onlineshop.Data;
using Onlineshop.Models;
using Onlineshop.Utility;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Onlineshop.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class OrdersController : Controller
    {
        private ApplicationDbContext _db;

        public OrdersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            return View(_db.Orders.ToList());
        }

        //Get Checkout action method
        //[Authorize]
        public IActionResult Checkout()
        {
            return View();
        }

        //POST  Checkout action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(Orders anOrder)
        {
            List<Products> products = HttpContext.Session.Get<List<Products>>("products");
            if (products != null)
            {
                foreach (var product in products)
                {
                    OrderDetails orderDetails = new OrderDetails();
                    orderDetails.PorductId  = product.Id;
                    anOrder.OrderDetails.Add(orderDetails);
                }
            }

            anOrder.OrderNo = GetOrderNo();
            _db.Orders.Add(anOrder);
            await _db.SaveChangesAsync();
            HttpContext.Session.Set("products", new List<Products>());
            return View();
        }



        public string GetOrderNo()
        {
            int rowCount = _db.Orders.ToList().Count() + 1;
            return rowCount.ToString("000");
        }

    }
}
