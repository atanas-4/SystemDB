using SystemDB.CoreBusiness;

namespace SystemDB.UseCases
{
    public interface IViewProductsByNameUseCase
    {
        Task<List<Product>> ExecuteAsync(string name = "");
    }
}