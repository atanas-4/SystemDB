using SystemDB.CoreBusiness;

namespace SystemDB.UseCases
{
    public interface IEditProductUseCase
    {
        Task ExecuteAsync(Product product);
    }
}