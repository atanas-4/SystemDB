using SystemDB.CoreBusiness;

namespace SystemDB.UseCases
{
    public interface IAddInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}