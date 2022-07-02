using Frent_Project.Data.Repository.IRepository;
using FRENT_Project.Models;

namespace Frent_Project.Data.Repository
{
    public class TransactionHeaderRepository : Repository<TransactionHeader>, ITransactionHeaderRepository
    {
        private FrentDbContext _db;
        public TransactionHeaderRepository(FrentDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
