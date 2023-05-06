using System.ComponentModel.DataAnnotations;

namespace SystemDB.CoreBusiness
{
    // Дефиниране на клас Inventory
    public class Inventory
    {
        // Дефиниране на свойство InventoryId от тип int
        public int InventoryId { get; set; }

        // Дефиниране на свойство InventoryName от тип string, което е задължително
        [Required(ErrorMessage = "Името на инвентара е задължително")]
        public string? InventoryName { get; set; }

        // Дефиниране на свойство Quantity от тип int, което трябва да е по-голямо или равно на 0
        [Range(0, int.MaxValue, ErrorMessage = "Количеството трябва да е по-голямо или равно на {0}")]
        public int Quantity { get; set; }

        // Дефиниране на свойство Price от тип double, което трябва да е по-голямо или равно на 0
        [Range(0, double.MaxValue, ErrorMessage = "Цената трябва да е по-голяма или равна на {0}")]
        public double Price { get; set; }

        // Дефиниране на свойство ProductInventories от тип List<ProductInventory>
        public List<ProductInventory>? ProductInventories { get; set; }

    }
}
