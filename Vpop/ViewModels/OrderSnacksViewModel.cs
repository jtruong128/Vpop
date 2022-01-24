using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vpop.ViewModels
{
    public class OrderSnacksViewModel
    {
        public string Custname { get; set; }
        public string Item { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string CurrDate { get; set; }
        public Dictionary<string, string> Snacks1Choices { get; set; }
        public Dictionary<string, string> Snacks2Choices { get; set; }
        public OrderSnacksViewModel(Dictionary<string, string> snacks1Choices, Dictionary<string, string> snacks2Choices)
        {
            Snacks1Choices = snacks1Choices;
            Snacks2Choices = snacks2Choices;
        }
        public OrderSnacksViewModel()
        {

        }
    }
}