using SystemDB.CoreBusiness;

namespace SystemDB.UseCases
{
    public interface IPurchaseInventoryUseCase
    {
        Task ExecuteAsync(string poNumber, Inventory inventory, int quantity, string doneBy);
    }
}