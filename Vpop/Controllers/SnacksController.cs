using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Vpop.Data;
using Vpop.Models;
using Vpop.ViewModels;

namespace Vpop.Controllers
{
    public class SnacksController : Controller
    {
        internal static Dictionary<string, string> Snacks1Choices = new Dictionary<string, string>()
        {
            {"Snow Crab Rangoons (3) ", "Snow Crab Rangoons (3) $5"},
            {"Snow Crab Rangoons (6) ", "Snow Crab Rangoons (6) $10"},
            {"Krab Rangoons(3) ", "Krab Rangoons(3) $2.8"},
            {"Krab Rangoons(6) ", "Krab Rangoons(6) $5"}
        };
        internal static Dictionary<string, string> Snacks2Choices = new Dictionary<string, string>()
        {
            {"Fried Shrimp Rolls ", "Fried Shrimp Rolls $5"},
            {"Vegan Cheese Rolls ", "Vegan Cheese Rolls $4"},
            {"Veggie Egg Rolls ", "Veggie Egg Rolls $3.5"},
            {"Vietnamese Egg Rolls ", "Vietnamese Egg Rolls $3.5"}

        };

        private OrderDbContext context;
        public SnacksController(OrderDbContext dbContext)
        {
            context = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            OrderSnacksViewModel orderSnacksViewModel = new OrderSnacksViewModel(Snacks1Choices, Snacks2Choices);
            return View(orderSnacksViewModel);
        }

        [HttpPost]
        public IActionResult Index(OrderSnacksViewModel orderSnacksViewModel, string[] items)
        {
            orderSnacksViewModel.Custname = HttpContext.Session.GetString("CustName");
            if (ModelState.IsValid)
            {
                foreach (string item in items)
                {
                    orderSnacksViewModel.Price = double.Parse(item.Split('$')[1]);

                    Order newOrder = new Order
                    {
                        Custname = orderSnacksViewModel.Custname,
                        Item = item.Split('$')[0],
                        Price = orderSnacksViewModel.Price,
                        Category = orderSnacksViewModel.Category,
                        CurrDate = orderSnacksViewModel.CurrDate
                    };
                    context.Orders.Add(newOrder);
                }
                context.SaveChanges();
                HttpContext.Session.SetString("CurrDate", orderSnacksViewModel.CurrDate);
                return RedirectToAction("DisplayOrder", new { newItems = items });
            }
            OrderSnacksViewModel viewModel = new OrderSnacksViewModel(Snacks1Choices, Snacks2Choices);
            return View(viewModel);
        }
        public IActionResult DisplayOrder(string[] newItems)
        {
            List<Order> orders = new List<Order>();
            string custname = HttpContext.Session.GetString("CustName");
           string currdate = HttpContext.Session.GetString("CurrDate");
            
            
            foreach (string item in newItems)
            {
                string myitem = item.Split('$')[0];
                 Order order = context.Orders
                .Where(p => p.Custname == custname)
                .Where(p => p.Item == myitem)
                .Where(p => p.CurrDate == currdate)
                .ToList()
                .OrderByDescending(p => p.Id).FirstOrDefault();

                orders.Add(order);
            }
            
            ViewBag.orders = orders;
            return View();
        }
    }

}
