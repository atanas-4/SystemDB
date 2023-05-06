using SystemDB.CoreBusiness;

namespace SystemDB.UseCases
{
    public interface IAddProductUseCase
    {
        Task ExecuteAsync(Product product);
    }
}