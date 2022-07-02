using FRENT_Project.Models;

namespace Frent_Project.Data.Repository.IRepository
{
    public interface IUserRepository : IRepository<User>
    {
        void Update(User obj);
    }
}
