using Frent_Project.Data.Repository.IRepository;
using FRENT_Project.Models;

namespace Frent_Project.Data.Repository
{
    public class PartnerRepository : Repository<Partner>, IPartnerRepository
    {
        private FrentDbContext _db;
        public PartnerRepository(FrentDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
