

using Frent_Project.Data.Repository.IRepository;

namespace Frent_Project.DataAccess.Repository.Irepository
{
    public interface IUnitOfWork
    {
        IChatRepository Chat { get; }
        IPartnerRepository Partner { get; }
        ITransactionDetailRepository TransactionDetail { get; }
        ITransactionHeaderRepository TransactionHeader { get; }
        IUserRepository User { get; }
        void Save();
    }
}
