
namespace SystemDB.UseCases
{
    public interface IDeleteProductUseCase
    {
        Task ExecuteAsync(int productId);
    }
}