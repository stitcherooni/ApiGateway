using System.Transactions;

namespace BLL.Services
{
    public class BaseService
    {
        public TransactionScope GetTransactionScope(IsolationLevel isolationLevel)
        {
            return new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = isolationLevel }, TransactionScopeAsyncFlowOption.Enabled);
        }

        public TransactionScope GetTransactionScope()
        {
            return new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }, TransactionScopeAsyncFlowOption.Enabled);
        }
    }
}
