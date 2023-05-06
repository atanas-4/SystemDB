using SystemDB.CoreBusiness;

namespace SystemDB.UseCases
{
    public interface IProduceProductUseCase
    {
        Task ExecuteAsync(string productionNumber, Product product, int quantity, string doneBy);
    }
}