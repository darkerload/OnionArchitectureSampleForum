using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApoForum.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IDbContext context;
        private IDbSet<T> entities;
        public Repository(IDbContext context)
        {
            this.context = context;
        }

        public void Delete(T entity)
        {
            if (entity != null)
            {
                CurrentEntites.Remove(entity);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Entity is Null !");
            }
        }

        public IQueryable<T> GetBy(Expression<Func<T, bool>> predicate)
        {
            return CurrentEntites.Where(predicate);
        }

        public void Insert(T entity)
        {
            if (entity != null)
            {
                CurrentEntites.Add(entity);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Entity is Null !");
            }
        }

        public void Update(T entity)
        {
            if (entity != null)
            {
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Entity is Null !");
            }
        }

        public IQueryable<T> GetAll()
        {
            return CurrentEntites.AsQueryable<T>();
        }

        private IDbSet<T> CurrentEntites
        {
            get
            {
                if (entities == null)
                {
                    entities = context.Set<T>();
                }
                return entities;
            }
        }
    }
}
