using Microsoft.EntityFrameworkCore;

namespace UserMicroService.Repository
{
    public class GenericRepository<T>:IGenericRepository<T>where T:class
    {
        private readonly ApplicationContext context;
        private DbSet<T> entities;

        public GenericRepository(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<T>();
           
        }

        public T GetById(long id)
        {
            return entities.Find(id);
        }
    }
}
