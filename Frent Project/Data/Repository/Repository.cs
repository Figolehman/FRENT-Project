using Frent_Project.Data.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Frent_Project.Data.Repository
{
    public class Repository<model> : IRepository<model> where model: class
    {
        private readonly FrentDbContext _db;
        internal DbSet<model> dbSet;
        public Repository(FrentDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<model>();
        }
        public void Add(model entity)
        {
            dbSet.Add(entity);
        }

        public IEnumerable<model> GetAll(Expression<Func<model, bool>>? filter = null, string? includeProp = null)
        {
            IQueryable<model> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProp != null)
            {
                foreach (var prop in includeProp.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(prop);
                }
            }
            return query.ToList();
        }

        public model GetFirstOrDefault(Expression<Func<model, bool>>? filter = null, string? includeProp = null, bool track = true)
        {
            IQueryable<model> query;
            if (track == true)
            {
                query = dbSet;
            }
            else
            {
                query = dbSet.AsNoTracking();
            }
            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProp != null)
            {
                foreach (var prop in includeProp.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(prop);
                }
            }
            return query.FirstOrDefault();
        }

        public void Remove(model entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<model> entity)
        {
            dbSet.RemoveRange(entity);
        }
    }
}
