using SystemDB.CoreBusiness;

namespace SystemDB.UseCases.Reports
{
    public interface ISearchInventoryTransactionsUseCase
    {
        Task<IEnumerable<InventoryTransaction>> ExecuteAsync(string inventoryName, DateTime? dateFrom, DateTime? dateTo, InventoryTransactionType? transactionType);
    }
}