using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Vpop.Data;
using Vpop.Models;
using Vpop.ViewModels;

namespace Vpop.Controllers
{
    public class BanhMiController : Controller
    {
        internal static Dictionary<string, string> Protein1Choices = new Dictionary<string, string>()
        {
            {"Combo ", "Combo $10"},
            {"Steak ", "Steak $9"},
            {"Shrimp ", "Shrimp $9"},
            {"Fish ", "Fish $9"},
            {"Vegan Beef ", "Vegan Beef $9"}
        };

        internal static Dictionary<string, string> Protein2Choices = new Dictionary<string, string>()
        {
            {"Cold Cut ", "Cold Cut $8"},
            {"Pork ", "Pork $8"},
            {"Chicken ", "Chicken $8"},
            {"Tofu ", "Tofu $8"},
            {"Veggie ", "Veggie $8"}
        };
        private OrderDbContext context;
        public BanhMiController(OrderDbContext dbcontext)
        {
            context = dbcontext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            OrderBanhMiViewModel orderBanhMiViewModel = new OrderBanhMiViewModel(Protein1Choices, Protein2Choices);
            return View(orderBanhMiViewModel);
        }
        [HttpPost]
        public IActionResult Index(OrderBanhMiViewModel orderBanhMiViewModel)
        {
            orderBanhMiViewModel.Custname = HttpContext.Session.GetString("CustName");
            orderBanhMiViewModel.Price = double.Parse(orderBanhMiViewModel.Item.Split('$')[1]);
            orderBanhMiViewModel.Item = orderBanhMiViewModel.Item.Split('$')[0];
            if (ModelState.IsValid)
            {
                Order newOrder = new Order
                {
                    Custname = orderBanhMiViewModel.Custname,
                    Item = orderBanhMiViewModel.Item,
                    Price = orderBanhMiViewModel.Price,
                    Category = orderBanhMiViewModel.Category,
                    CurrDate = orderBanhMiViewModel.CurrDate
                };
                context.Orders.Add(newOrder);
                context.SaveChanges();
                return Redirect("/BanhMi/DisplayOrder");
            }
            OrderBanhMiViewModel viewModel = new OrderBanhMiViewModel(Protein1Choices, Protein2Choices);
            return View(viewModel);
        }

        public IActionResult DisplayOrder()
        {
            int orderdId = context.Orders.Max(p => p.Id);
            ViewBag.order = context.Orders.Find(orderdId);
            return View();
        }

    }

}