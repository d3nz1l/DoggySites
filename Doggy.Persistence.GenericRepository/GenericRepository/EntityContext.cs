// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityContext.cs" company="">
//   
// </copyright>
// <summary>
//   The entity context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GenericRepository
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    /// <summary>
    /// The entity context.
    /// </summary>
    public class EntityContext : DbContext, IContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityContext"/> class.
        /// </summary>
        /// <param name="connectionStringName">Name of the connection string.</param>
        public EntityContext(string connectionStringName)
            : base(connectionStringName)
        {
        }

        /// <summary>
        /// The entity set.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <returns>
        /// The <see cref="IDbSet" />.
        /// </returns>
        public IDbSet<TEntity> EntitySet<TEntity>() where TEntity : class
        {
            return this.Set<TEntity>();
        }

        /// <summary>
        /// The mark as added.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entity">The entity.</param>
        public void MarkAsAdded<TEntity>(TEntity entity) where TEntity : class
        {
            var entry = this.GetEntityEntry(entity);
            entry.State = EntityState.Added;
        }

        /// <summary>
        /// The mark as modified.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entity">The entity.</param>
        public void MarkAsModified<TEntity>(TEntity entity) where TEntity : class
        {
            var entry = this.GetEntityEntry(entity);
            entry.State = EntityState.Modified;
        }

        /// <summary>
        /// The mark as deleted.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entity">The entity.</param>
        public void MarkAsDeleted<TEntity>(TEntity entity) where TEntity : class
        {
            var entry = this.GetEntityEntry(entity);
            entry.State = EntityState.Deleted;
        }

        /// <summary>
        /// Gets the entity entry.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entity">The entity.</param>
        /// <returns>The <see cref="DbEntityEntry"/> for the given entity</returns>
        private DbEntityEntry GetEntityEntry<TEntity>(TEntity entity) where TEntity : class
        {
            var entry = this.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                this.Set<TEntity>().Attach(entity);
            }

            return entry;
        }
}
}
