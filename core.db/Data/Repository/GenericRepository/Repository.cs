using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Data.Repository.GenericRepository;
using Microsoft.Data.SqlClient;

using RepoDb;
namespace Data.Repository.GenericRepository;
public class Repository<TEntity> : BaseRepository<TEntity, SqlConnection>,IRepository<TEntity> where TEntity : class
{
    // TrustServerCertificate=True;
        public Repository():base(@"Data Source=.\MSSQL2014;initial catalog=TMSDB;User ID=sa;password=@dm1n123;encrypt=true;trustServerCertificate=true;")
        {

        }
        
        public void Add(TEntity entity)
        {
            Insert(entity);
        }
        public int Update(TEntity entity)
        {
            return Update(entity);
        }
        public void AddRange(IEnumerable<TEntity> entities)
        {
            
        }

        public TEntity Get(long id)
        {

            return Query(id).FirstOrDefault();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return QueryAll();
        }

        public void Remove(TEntity entity)
        {
            
        }
        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            
        }

        public IEnumerable<TEntity> Search(params Expression<Func<TEntity, object>>[] includeExpressions)
        {
            // IQueryable<TEntity> set = Context.Set<TEntity>();
            // foreach (var includeExpression in includeExpressions)
            // {
            //     set = set.Include(includeExpression);
            // }
            // return set.ToList();
            return null;
        }

        public IList<TEntity> ConditionalSearch(Expression<Func<TEntity, bool>> predicate, params string[] navigationProperties)
        {
            // List<TEntity> list;
            // {
            //     var query = Context.Set<TEntity>().AsQueryable();

            //     foreach (string navigationProperty in navigationProperties)
            //         query = query.Include(navigationProperty);//got to reaffect it.

            //     list = query.Where(predicate).ToList<TEntity>();
            // }
            // return list;
            return null;
        }
}
