using SystemDB.CoreBusiness;

namespace SystemDB.UseCases
{
    public interface IViewInventoryByIdUseCase
    {
        Task<Inventory?> ExecuteAsync(int inventoryId);
    }
}