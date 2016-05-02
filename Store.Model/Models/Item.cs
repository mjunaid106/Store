using System;
using Store.Model.Enums;

namespace Store.Model.Models
{
    public class Item
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime ExpiryDate { get; set; }

        public ItemCategory Category { get; set; }
    }
}
