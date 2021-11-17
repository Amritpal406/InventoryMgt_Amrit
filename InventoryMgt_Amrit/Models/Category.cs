using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryMgt_Amrit.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; }
        public List<StockMaintain> StockMaintains { get; set; }
    }
}
