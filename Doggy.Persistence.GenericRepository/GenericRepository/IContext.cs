// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IContext.cs" company="">
//   
// </copyright>
// <summary>
//   Represents a fakeable context for testing purposes
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GenericRepository
{
    using System;
    using System.Data.Entity;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents a fakeable context for testing purposes
    /// </summary>
    public interface IContext : IDisposable
    {
        /// <summary>
        /// Gets the <see cref="DbSet"/> for the entity type.
        /// </summary>
        /// <typeparam name="TEntity">The type of entity.</typeparam>
        /// <returns>The <see cref="DbSet"/> the given entity type.</returns>
        IDbSet<TEntity> EntitySet<TEntity>() where TEntity : class;

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <typeparam name="TEntity">
        /// The type of the entity.
        /// </typeparam>
        /// <param name="entity">
        /// The entity.
        /// </param>
        void MarkAsAdded<TEntity>(TEntity entity) where TEntity : class;

        /// <summary>
        /// Marks as modified.
        /// </summary>
        /// <typeparam name="TEntity">
        /// The type of the entity.
        /// </typeparam>
        /// <param name="entity">
        /// The entity.
        /// </param>
        void MarkAsModified<TEntity>(TEntity entity) where TEntity : class;

        /// <summary>
        /// Marks as deleted.
        /// </summary>
        /// <typeparam name="TEntity">
        /// The type of the entity.
        /// </typeparam>
        /// <param name="entity">
        /// The entity.
        /// </param>
        void MarkAsDeleted<TEntity>(TEntity entity) where TEntity : class;

        /// <summary>
        /// Saves all changes.
        /// </summary>
        /// <returns>The number of changes saved</returns>
        Task<int> SaveChangesAsync();
    }
}
