

using Frent_Project.Data;
using Frent_Project.Data.Repository;
using Frent_Project.Data.Repository.IRepository;
using Frent_Project.DataAccess.Repository.Irepository;
using FRENT_Project.Models;

namespace Frent_Project.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private FrentDbContext _db;
        public UnitOfWork(FrentDbContext db) 
        {
            _db = db;
            Chat = new ChatRepository(_db);
            Partner = new PartnerRepository(_db);
            TransactionDetail = new TransactionDetailRepository(_db);
            TransactionHeader = new TransactionHeaderRepository(_db);
            User = new UserRepository(_db);
        }
        public IChatRepository Chat { get; private set; }
        public IPartnerRepository Partner { get; private set; } 
        public ITransactionDetailRepository TransactionDetail { get; private set; }
        public ITransactionHeaderRepository TransactionHeader { get; private set; } 
        public IUserRepository User { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
