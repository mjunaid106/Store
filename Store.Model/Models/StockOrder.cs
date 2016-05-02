using System;

namespace Store.Model.Models
{
    public class StockOrder
    {
        public Item Item { get; set; }

        public int Quantity { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
