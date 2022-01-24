using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        public IActionResult Index(OrderSnacksViewModel orderSnacksViewModel)
        {
            orderSnacksViewModel.Custname = HttpContext.Session.GetString("CustName");
            orderSnacksViewModel.Price = double.Parse(orderSnacksViewModel.Item.Split('$')[1]);
            orderSnacksViewModel.Item = orderSnacksViewModel.Item.Split('$')[0];
            if (ModelState.IsValid)
            {
                Order newOrder = new Order
                {
                    Custname = orderSnacksViewModel.Custname,
                    Price = orderSnacksViewModel.Price,
                    Item = orderSnacksViewModel.Item,
                    Category = orderSnacksViewModel.Category,
                    CurrDate = orderSnacksViewModel.CurrDate
                };
                context.Orders.Add(newOrder);
                context.SaveChanges();
                return Redirect("/BanhMi/DisplayOrder");
            }
            OrderSnacksViewModel viewModel = new OrderSnacksViewModel(Snacks1Choices, Snacks2Choices);
            return View(viewModel);
        }

    }

}
