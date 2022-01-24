using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Vpop.Data;
using Vpop.Models;
using Vpop.ViewModels;

namespace Vpop.Controllers
{
    public class BowlsController : Controller
    {
        internal static Dictionary<string, string> CategoryChoices = new Dictionary<string, string>()
        {
            {"Salad Bowl", "Salad Bowl"},
            {"Vermicelli Bowl", "Vermicelli Bowl"},
            {"Rice Bowl", "Rice Bowl"}
        };

        internal static Dictionary<string, string> ProteinChoices = new Dictionary<string, string>()
        {
            {"Duck ", "Duck $15"},
            {"Combo ", "Combo $14"},
            {"Shrimp ", "Shrimp $12"},
            {"Steak ", "Steak $12"},
            {"Vegan Beef ", "Vegan Beef $12"},
            {"Fish ", "Fish $12"},
            {"Pork ", "Pork $11"},
            {"Chicken ", "Chicken $11"},
            {"Tofu ", "Tofu $11"},
            {"Veggie ", "Veggie $11"}
        };

        private OrderDbContext context;
        public BowlsController(OrderDbContext dbContext)
        {
            context = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            OrderBowlsViewModel orderBowlsViewModel = new OrderBowlsViewModel(CategoryChoices, ProteinChoices);
            return View(orderBowlsViewModel);

        }
        [HttpPost]
        public IActionResult Index(OrderBowlsViewModel orderBowlsViewModel)
        {
            orderBowlsViewModel.Custname = HttpContext.Session.GetString("CustName");
            orderBowlsViewModel.Price = double.Parse(orderBowlsViewModel.Item.Split('$')[1]);
            orderBowlsViewModel.Item = orderBowlsViewModel.Item.Split('$')[0];
            if (ModelState.IsValid)
            {
                Order newOrder = new Order
                {
                    Custname = orderBowlsViewModel.Custname,
                    Price = orderBowlsViewModel.Price,
                    Item = orderBowlsViewModel.Item,
                    Category = orderBowlsViewModel.Category,
                    CurrDate = orderBowlsViewModel.CurrDate
                };
                context.Orders.Add(newOrder);
                context.SaveChanges();
                return Redirect("/BanhMi/DisplayOrder");
            }
            OrderBowlsViewModel viewModel = new OrderBowlsViewModel(CategoryChoices, ProteinChoices);
            return View(viewModel);
        }
    }
}
