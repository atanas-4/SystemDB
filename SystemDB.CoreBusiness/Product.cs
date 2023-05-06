using SystemDB.CoreBusiness.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDB.CoreBusiness
{
    // Дефиниране на клас Product
    public class Product
    {
        // Дефиниране на свойство ProductId от тип int
        public int ProductId { get; set; }

        // Дефиниране на свойство ProductName от тип string, което е задължително
        [Required(ErrorMessage = "Името на продукта е задължително")]
        public string ProductName { get; set; } = string.Empty;

        // Дефиниране на свойство Quantity от тип int, което трябва да е по-голямо или равно на 0
        [Range(0, int.MaxValue, ErrorMessage = "Количеството трябва да е по-голямо или равно на {0}")]
        public int Quantity { get; set; }

        // Дефиниране на свойство Price от тип double, което трябва да е по-голямо или равно на 0 и да е по-голямо от цените на инвентарите
        [Range(0, double.MaxValue, ErrorMessage = "Цената трябва да е по-голяма или равна на {0}")]
        [Product_EnsurePriceIsGreaterThanInventoriesPrice(ErrorMessage = "Цената на продукта трябва да е по-голяма от цените на инвентарите")]
        public double Price { get; set; }

        // Дефиниране на свойство IsActive от тип bool, което по подразбиране е true
        public bool IsActive { get; set; } = true;

        // Дефиниране на свойство ProductInventories от тип List<ProductInventory>
        public List<ProductInventory>? ProductInventories { get; set; }

        // Метод, който връща общата стойност на инвентара за този продукт
        public double TotalInventoryCost()
        {
            return this.ProductInventories.Sum(x => x.Inventory?.Price * x.InventoryQuantity ?? 0);
        }

        // Метод, който валидира цената на продукта в сравнение с цените на инвентарите му
        public bool ValidatePricing()
        {
            // Не валидираме обекта на продукта, когато инвентарите на продукта не са заредени
            if (ProductInventories == null || ProductInventories.Count <= 0) return true;

            // Връщаме false, ако общата стойност на инвентара за този продукт е по-голяма от цената на продукта
            if (this.TotalInventoryCost() > Price) return false;

            return true;
        }

    }
}
