using SystemDB.CoreBusiness;

namespace SystemDB.UseCases
{
    public interface IEditInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}