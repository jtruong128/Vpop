using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vpop.ViewModels
{
    public class OrderBowlsViewModel
    {
        public string Custname { get; set; }
        public string Item { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string CurrDate { get; set; }
        public Dictionary<string, string> CategoryChoices { get; set; }
        public Dictionary<string, string> ProteinChoices { get; set; }
        public OrderBowlsViewModel(Dictionary<string, string> categoryChoices, Dictionary<string, string> proteinChoices)
        {
            CategoryChoices = categoryChoices;
            ProteinChoices = proteinChoices;
        }
        public OrderBowlsViewModel()
        {

        }
    }
}

