using SystemDB.CoreBusiness;

namespace SystemDB.UseCases
{
    public interface IValidateEnoughInventoriesForProducingUseCase
    {
        Task<bool> ExecuteAsync(Product product, int quantity);
    }
}