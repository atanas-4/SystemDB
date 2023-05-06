using SystemDB.CoreBusiness;

namespace SystemDB.UseCases
{
    public interface IViewInventoriesByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}