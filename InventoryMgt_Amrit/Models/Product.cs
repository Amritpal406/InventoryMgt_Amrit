using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryMgt_Amrit.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }

        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }

        public List<StockMaintain> StockMaintains { get; set; }
    }
}
