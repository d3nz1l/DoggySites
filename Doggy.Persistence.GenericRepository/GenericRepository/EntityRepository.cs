// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The generic repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GenericRepository
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    using GenCol = System.Collections.Generic;

    /// <summary>
    /// The generic repository.
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TId">The type of the identifier.</typeparam>
    public class EntityRepository<TEntity, TId> : IEntityRepository<TEntity, TId>
        where TEntity : class, IEntity<TId>
        where TId : IComparable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityRepository{TEntity, TId}" /> class.
        /// </summary>
        /// <param name="entityContext">The entity context.</param>
        public EntityRepository(IContext entityContext)
        {
            this.Context = entityContext;
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        /// <value>
        /// The context.
        /// </value>
        protected IContext Context { get; private set; }

        /// <summary>
        /// Gets the default include expressions.
        /// </summary>
        /// <value>
        /// The default include expressions.
        /// </value>
        protected virtual Expression<Func<TEntity, object>>[] DefaultIncludeExpressions
        {
            get
            {
                return null;
            }
        }

        /// <summary>
        /// Gets all entities.
        /// </summary>
        /// <returns>All entities</returns>
        public async Task<GenCol.IEnumerable<TEntity>> GetAllAsync()
        {
            if (this.DefaultIncludeExpressions == null)
            {
                return await this.Context.EntitySet<TEntity>().ToListAsync();
            }

            return await this.GetAllIncludingAsync(this.DefaultIncludeExpressions);
        }

        /// <summary>
        /// The get all including.
        /// </summary>
        /// <param name="includeExpressions">
        /// The include expressions.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<GenCol.IEnumerable<TEntity>> GetAllIncludingAsync(params Expression<Func<TEntity, object>>[] includeExpressions)
        {
            var allEnities = this.Context.EntitySet<TEntity>();

            foreach (var include in includeExpressions)
            {
                allEnities.Include(include);
            }

            return await allEnities.ToListAsync();
        }

        /// <summary>
        /// Gets the specified entity by its identifier.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        public async Task<TEntity> GetByIdAsync(TId id)
        {
            if (this.DefaultIncludeExpressions == null)
            {
                return await this.Context.EntitySet<TEntity>().Where(e => e.Id.Equals(id)).FirstOrDefaultAsync();
            }

            return await this.GetByIdIncludingAsync(id, this.DefaultIncludeExpressions);
        }

        /// <summary>
        /// Gets the specified entity by its identifier.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="includeExpressions">The include expressions.</param>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        public async Task<TEntity> GetByIdIncludingAsync(TId id, params Expression<Func<TEntity, object>>[] includeExpressions)
        {
            var allEnities = this.Context.EntitySet<TEntity>();

            foreach (var include in includeExpressions)
            {
                allEnities.Include(include);
            }

            return await allEnities.FirstOrDefaultAsync();
        }

        /// <summary>
        /// Gets the by where asynchronous.
        /// </summary>
        /// <param name="filterExpression">The filter expression.</param>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        public async Task<GenCol.IEnumerable<TEntity>> GetByWhereAsync(Expression<Func<TEntity, bool>> filterExpression)
        {
            if (this.DefaultIncludeExpressions == null)
            {
                return await this.Context.EntitySet<TEntity>().Where(filterExpression).ToListAsync();
            }

            return await this.GetByWhereIncludingAsync(filterExpression, this.DefaultIncludeExpressions);
        }

        /// <summary>
        /// Gets the by where including asynchronous.
        /// </summary>
        /// <param name="filterExpression">The filter expression.</param>
        /// <param name="includeExpressions">The include expressions.</param>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        public async Task<GenCol.IEnumerable<TEntity>> GetByWhereIncludingAsync(Expression<Func<TEntity, bool>> filterExpression, params Expression<Func<TEntity, object>>[] includeExpressions)
        {
            var allEnities = this.Context.EntitySet<TEntity>();

            foreach (var include in includeExpressions)
            {
                allEnities.Include(include);
            }

            return await allEnities.Where(filterExpression).ToListAsync();
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        public async Task AddAsync(TEntity entity)
        {
            this.Context.MarkAsAdded(entity);
            await this.Context.SaveChangesAsync();
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        public async Task AddAsync(GenCol.IEnumerable<TEntity> entities)
        {
            await Task.WhenAll(entities.Select(this.AddAsync));
        }

        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        public async Task UpdateAsync(TEntity entity)
        {
            this.Context.MarkAsModified(entity);
            await this.Context.SaveChangesAsync();
        }

        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        public async Task UpdateAsync(GenCol.IEnumerable<TEntity> entities)
        {
            await Task.WhenAll(entities.Select(this.UpdateAsync));
        }

        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        public async Task DeleteAsync(TEntity entity)
        {
            this.Context.MarkAsDeleted(entity);
            await this.Context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns>
        /// The <see cref="Task" />.
        /// </returns>
        public async Task DeleteAsync(GenCol.IEnumerable<TEntity> entities)
        {
            await Task.WhenAll(entities.Select(this.DeleteAsync));
        }
    }
}
