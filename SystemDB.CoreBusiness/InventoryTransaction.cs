using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDB.CoreBusiness
{
   // Дефиниране на клас InventoryTransaction
public class InventoryTransaction
    {
        // Дефиниране на свойство InventoryTransactionId от тип int
        public int InventoryTransactionId { get; set; }

        // Дефиниране на свойство InventoryId от тип int, което е задължително
        [Required]
        public int InventoryId { get; set; }

        // Дефиниране на свойство QuantityBefore от тип int, което е задължително
        [Required]
        public int QuantityBefore { get; set; }

        // Дефиниране на свойство ActivityType от тип InventoryTransactionType, което е задължително
        // Това е действието, което е извършено (закупуване или производство на продукт)
        [Required]
        public InventoryTransactionType ActivityType { get; set; }

        // Дефиниране на свойство QuantityAfter от тип int, което е задължително
        [Required]
        public int QuantityAfter { get; set; }

        // Дефиниране на свойство PONumber от тип string
        public string? PONumber { get; set; }

        // Дефиниране на свойство ProductionNumber от тип string
        public string? ProductionNumber { get; set; }

        // Дефиниране на свойство UnitPrice от тип double
        public double? UnitPrice { get; set; }

        // Дефиниране на свойство TransactionDate от тип DateTime, което е задължително
        [Required]
        public DateTime TransactionDate { get; set; }

        // Дефиниране на свойство DoneBy от тип string, което е задължително
        [Required]
        public string DoneBy { get; set; }

        // Навигационни свойства
        public Inventory Inventory { get; set; }

    }
}
