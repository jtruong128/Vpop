using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Vpop.Data;
using Vpop.Models;

namespace Vpop.Controllers
{
    public class ReviewController : Controller
    {
        private OrderDbContext context;
        public ReviewController(OrderDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            string custname = HttpContext.Session.GetString("CustName");
            List<Order> orders = context.Orders
                .Where(p => p.Custname == custname)
                .ToList();
            ViewBag.orderCust = orders;
            if (orders.Count > 0)
            {
                ViewBag.custName = orders[0].Custname;
                ViewBag.date = orders[0].CurrDate;
                
            }
            return View();
        }

        public IActionResult ButtonCheck(int [] cancelIds, int editId, string cmd)
        {
            if(cmd == "Cancel")
            {
                foreach (int orderId in cancelIds)
                {
                    Order theOrder = context.Orders.Find(orderId);
                    context.Orders.Remove(theOrder);
                }
                context.SaveChanges();
                return Redirect("/Review/Index");
            }
            else if (cmd == "Update")
            {
                ViewBag.orderEdit = context.Orders.Find(editId);

                if (ViewBag.orderEdit != null)
                {

                    if (ViewBag.orderEdit.Category == "Banh Mi")
                    {
                        ViewBag.protein1 = BanhMiController.Protein1Choices;
                        ViewBag.protein2 = BanhMiController.Protein2Choices;
                    }
                    else if (ViewBag.orderEdit.Category == "Snacks")
                    {
                        ViewBag.snacks1 = SnacksController.Snacks1Choices;
                        ViewBag.snacks2 = SnacksController.Snacks2Choices;
                    }
                    else
                    {
                        ViewBag.categories = BowlsController.CategoryChoices;
                        ViewBag.proteins = BowlsController.ProteinChoices;
                    }
                    return View("Edit");
                }
                else
                {
                    return Redirect("/Review/Index");
                }
               

            }
            else
            {
                string custname = HttpContext.Session.GetString("CustName");
                List<Order> custOrderList = context.Orders
                    .Where(p => p.Custname == custname)
                    .ToList();
                double total = context.Orders
                                 .Where(p => p.Custname == custname)
                                 .Sum(p => p.Price);

                ViewBag.orderCust = custOrderList;
                if (custOrderList.Count > 0)
                {
                    ViewBag.custName = custOrderList[0].Custname;
                    ViewBag.date = custOrderList[0].CurrDate;
                    ViewBag.total = total;
                }
                return View("Checkout");
            }

        }
        public IActionResult Save(int id, string custname, string category, string item, string currDate)
        {
            double priceTemp = double.Parse(item.Split('$')[1]);
            string itemTemp = item.Split('$')[0];

            Order theOrder = context.Orders.Find(id);
            //   theOrder.Custname = custname;
            theOrder.Category = category;
            theOrder.Item = itemTemp;
            theOrder.Price = priceTemp;
            theOrder.CurrDate = currDate;

            context.Update(theOrder);
            context.SaveChanges();
            ViewBag.orderEdited = theOrder;
            return View();
        }

    }
}
