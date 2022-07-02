using FRENT_Project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Frent_Project.Data
{
    public class FrentDbContext :IdentityDbContext
    {
        public FrentDbContext(DbContextOptions<FrentDbContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Chat> Chat { get; set; }
        public DbSet<Partner> Partner { get; set; }
        public DbSet<TransactionDetail> TransactionDetail { get; set; }
        public DbSet<TransactionHeader> TransactionHeader { get; set; }

    }
}
