using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vpop.ViewModels
{
    public class OrderBanhMiViewModel
    {
        public string Custname { get; set; }
        public string Item { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string CurrDate { get; set; }
        public Dictionary<string, string> Protein1Choices { get; set; }
        public Dictionary<string, string> Protein2Choices { get; set; }
        public OrderBanhMiViewModel(Dictionary<string, string> protein1Choices, Dictionary<string, string> protein2Choices)
        {
            Protein1Choices = protein1Choices;
            Protein2Choices = protein2Choices;
        }
        public OrderBanhMiViewModel()
        {

        }
    }
}
