using Frent_Project.Data.Repository.IRepository;
using FRENT_Project.Models;

namespace Frent_Project.Data.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private FrentDbContext _db;
        public UserRepository(FrentDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(User obj)
        {
            _db.User.Update(obj);
        }
    }
}
