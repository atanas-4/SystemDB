using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDB.CoreBusiness
{
    // Дефиниране на клас ProductInventory
    public class ProductInventory
    {
        // Дефиниране на свойство ProductId от тип int
        public int ProductId { get; set; }
        // Дефиниране на свойство Product от тип Product
        public Product? Product { get; set; }

        // Дефиниране на свойство InventoryId от тип int
        public int InventoryId { get; set; }

        // Дефиниране на свойство Inventory от тип Inventory
        public Inventory? Inventory { get; set; }

        // Дефиниране на свойство InventoryQuantity от тип int
        public int InventoryQuantity { get; set; }

    }
}
