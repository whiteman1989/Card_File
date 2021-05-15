using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Card_File.DAL.Interfaces
{

    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Gtet list of item in repositoty
        /// </summary>
        /// <returns>IEnumerable collection of items in repository</returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Get item by id
        /// </summary>
        /// <param name="id">The unique item Id</param>
        /// <returns>A T object for the id specified</returns>
        Task<T> Get(int id);

        /// <summary>
        /// Get T objects that satisfy the conditions of the predicate
        /// </summary>
        /// <param name="predicate">Predicate used to filter objects</param>
        /// <returns>IEnumerable collection of items in repository</returns>
        IQueryable<T> Find(Expression<Func<T, Boolean>> predicate);

        /// <summary>
        /// Create new item in repository
        /// </summary>
        /// <param name="item">T object for added to repository</param>
        Task Create(T item);

        /// <summary>
        /// Update object in repository
        /// </summary>
        /// <param name="item">T object for update object in repository with same id</param>
        void Update(T item);

        /// <summary>
        /// Delete object from repository by id
        /// </summary>
        /// <param name="id">The unique item Id</param>
        /// <returns></returns>
        Task Delete(int id);
    }
}
