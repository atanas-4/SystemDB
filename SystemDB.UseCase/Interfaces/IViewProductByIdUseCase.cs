using SystemDB.CoreBusiness;

namespace SystemDB.UseCases
{
    public interface IViewProductByIdUseCase
    {
        Task<Product> ExecuteAsync(int productId);
    }
}