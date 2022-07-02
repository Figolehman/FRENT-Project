using Frent_Project.Data.Repository.IRepository;
using FRENT_Project.Models;

namespace Frent_Project.Data.Repository
{
    public class TransactionDetailRepository : Repository<TransactionDetail>, ITransactionDetailRepository
    {
        private FrentDbContext _db;
        public TransactionDetailRepository(FrentDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
