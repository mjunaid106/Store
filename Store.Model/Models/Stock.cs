using System;

namespace Store.Model.Models
{
    public class Stock
    {
        public StockOrder StockOrder { get; set; }

        public DateTime StockReceivedOn { get; set; }

        public int Remaining { get; set; }
    }
}
