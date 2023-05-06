using SystemDB.CoreBusiness;

namespace SystemDB.UseCases
{
    public interface ISellProductUseCase
    {
        Task ExecuteAsync(string salesOrderNumber, Product product, int quantity, string doneBy);
    }
}