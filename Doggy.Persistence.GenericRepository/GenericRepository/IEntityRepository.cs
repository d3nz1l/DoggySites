// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEntityReposistory_TId.cs" company="">
//   
// </copyright>
// <summary>
//   The EntityReposistory interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GenericRepository
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    /// <summary>
    /// The EntityRepository interface.
    /// </summary>
    /// <typeparam name="TEntity">
    /// The entity type
    /// </typeparam>
    /// <typeparam name="TId">
    /// The entities identifier type
    /// </typeparam>
    public interface IEntityRepository<TEntity, TId> : IRepository<TEntity, TId>
        where TEntity : class
        where TId : IComparable
    {
        /// <summary>
        /// Gets the specified entity by its identifier.
        /// </summary>
        /// <param name="id">
        /// The identifier.
        /// </param>
        /// <param name="includeExpressions">
        /// The include expressions.
        /// </param>
        /// <returns>
        /// The requested entity
        /// </returns>
        Task<TEntity> GetByIdIncludingAsync(TId id, params Expression<Func<TEntity, object>>[] includeExpressions);

        /// <summary>
        /// The get all including.
        /// </summary>
        /// <param name="includeExpressions">
        /// The include expressions.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<TEntity>> GetAllIncludingAsync(params Expression<Func<TEntity, object>>[] includeExpressions);

        /// <summary>
        /// Gets the by where asynchronous.
        /// </summary>
        /// <param name="filterExpression">The filter expression.</param>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        Task<IEnumerable<TEntity>> GetByWhereAsync(Expression<Func<TEntity, bool>> filterExpression);

        /// <summary>
        /// Gets the by where including asynchronous.
        /// </summary>
        /// <param name="filterExpression">The filter expression.</param>
        /// <param name="includeExpressions">The include expressions.</param>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        Task<IEnumerable<TEntity>> GetByWhereIncludingAsync(Expression<Func<TEntity, bool>> filterExpression, params Expression<Func<TEntity, object>>[] includeExpressions);

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        Task AddAsync(TEntity entity);

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        Task AddAsync(IEnumerable<TEntity> entities);

        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        Task UpdateAsync(TEntity entity);

        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        Task UpdateAsync(IEnumerable<TEntity> entities);

        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        Task DeleteAsync(TEntity entity);

        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        Task DeleteAsync(IEnumerable<TEntity> entities);
    }
}
