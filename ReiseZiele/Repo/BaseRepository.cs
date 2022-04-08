using Reiseziele;
using ReiseZiele.Model;

namespace ReiseZiele.Repo
{
    public class BaseRepository<T> where T : BaseEntity
    {
        private readonly DataContext context;

        public BaseRepository(DataContext context)
        {
            this.context = context;            
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            var result = context.Set<T>().Find(id);
            return result;
        }

        public T Create(T entity)
        {
            var entityEntry = context.Set<T>().Add(entity);
            context.SaveChanges();
            return entityEntry.Entity;
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public T Update(T entity)
        {
            var result = context.Set<T>().Update(entity);
            context.SaveChanges();
            return result.Entity;
        }
    }
}
