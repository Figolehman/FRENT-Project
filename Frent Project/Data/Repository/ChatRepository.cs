using Frent_Project.Data.Repository.IRepository;
using FRENT_Project.Models;

namespace Frent_Project.Data.Repository
{
    public class ChatRepository : Repository<Chat>, IChatRepository
    {
        private FrentDbContext _db;
        public ChatRepository(FrentDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
