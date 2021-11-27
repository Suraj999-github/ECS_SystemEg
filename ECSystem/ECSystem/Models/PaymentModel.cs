using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECSystem.Models
{
    public class PaymentModel
    {
        public List<BuyingProduct> BuyingProducts { get; set; }
        public decimal TotalCost { get; set; }
    }
    public class BuyingProduct
    {
        public string Id { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string ShortDes { get; set; }
        public string Description { get; set; }
        public string AvaliableQuantity { get; set; }
        public string ProductId { get; set; }
        public string ProductCode { get; set; }
        public string Color { get; set; }
        public string ColorCode { get; set; }
    }   
}
