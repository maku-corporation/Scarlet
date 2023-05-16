using Models.Squarespace;

namespace Interfaces.Squarespace.Endpoints
{
    public interface ISquarespaceTransactions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<TransactionItems> GetTransactions();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Transaction> GetTransactionById(string id);
    }
}
