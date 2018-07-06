using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoForum.Data
{
    public interface IDbContext
    {

        int SaveChanges();

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
