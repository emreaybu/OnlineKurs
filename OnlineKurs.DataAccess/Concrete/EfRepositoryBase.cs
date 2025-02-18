using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OnlineKurs.DataAccess.Abstract;
using OnlineKurs.Entities.Abstract;
using OnlineKurs.Entities.Concrete;

namespace OnlineKurs.DataAccess.Concrete
{
    public class EfRepositoryBase<Tentity,Tcontext> : IEntityRepository<Tentity> where  Tentity: class , IEntity,new()
     where Tcontext : DbContext,new()
    {
        

        public List<Tentity> GetAll(Expression<Func<Tentity, bool>> filter = null)
        {
            using (Tcontext context = new Tcontext())
            {
                    return filter == null ? 
                    context.Set<Tentity>().ToList() : 
                    context.Set<Tentity>().Where(filter).ToList();
            }
        }

        public void Add(Tentity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }

        }

        public void Update(Tentity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                var updatededEntity = context.Entry(entity);
                updatededEntity.State = EntityState.Modified;
                context.SaveChanges();

            }

        }

        public void Delete(Tentity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }

        }
    }
}
