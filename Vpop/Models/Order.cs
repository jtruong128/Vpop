using System;

namespace Vpop.Models
{
    public class Order
    {
        public string Custname { get; set; }
        public string Item { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public int Id { get; set; }
        public string CurrDate { get; set; }
        public Order()
        {
        }
        public Order(string custname, string item, string category, string currDate)
        {
            Custname = custname;
            Item = item;
            Category = category;
            CurrDate = currDate;
        }
        public override string ToString()
        {
            return Custname;
        }
    }
}
