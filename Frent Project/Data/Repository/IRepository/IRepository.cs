using System.Linq.Expressions;

namespace Frent_Project.Data.Repository.IRepository
{
    public interface IRepository<model> where model : class
    {
        model GetFirstOrDefault(Expression<Func<model, bool>> filter, string? includeProp = null, bool track = true);
        IEnumerable<model> GetAll(Expression<Func<model, bool>>? filter = null, string? includeProp = null);
        void Add(model entity);
        void Remove(model entity);
        void RemoveRange(IEnumerable<model> entity);
    }
}
