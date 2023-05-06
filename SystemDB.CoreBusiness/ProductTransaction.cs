using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDB.CoreBusiness
{
    // Дефиниране на клас ProductTransaction
    public class ProductTransaction
    {
        // Дефиниране на свойство ProductTransactionId от тип int
        public int ProductTransactionId { get; set; }

        // Дефиниране на свойство ProductId от тип int, което е задължително
        [Required]
        public int ProductId { get; set; }

        // Дефиниране на свойство QuantityBefore от тип int, което е задължително
        [Required]
        public int QuantityBefore { get; set; }

        // Дефиниране на свойство ActivityType от тип ProductTransactionType, което е задължително
        // Това е действието, което е извършено (закупуване или производство на продукт)
        [Required]
        public ProductTransactionType ActivityType { get; set; }

        // Дефиниране на свойство QuantityAfter от тип int, което е задължително
        [Required]
        public int QuantityAfter { get; set; }

        // Дефиниране на свойство ProductionNumber от тип string
        public string? ProductionNumber { get; set; }

        // Дефиниране на свойство SalesOrderNumber от тип string
        public string? SalesOrderNumber { get; set; }

        // Дефиниране на свойство UnitPrice от тип double
        public double? UnitPrice { get; set; }

        // Дефиниране на свойство TransactionDate от тип DateTime, което е задължително
        [Required]
        public DateTime TransactionDate { get; set; }

        // Дефиниране на свойство DoneBy от тип string, което е задължително
        [Required]
        public string DoneBy { get; set; }

        // Навигационни свойства
        public Product Product { get; set; }

    }
}
