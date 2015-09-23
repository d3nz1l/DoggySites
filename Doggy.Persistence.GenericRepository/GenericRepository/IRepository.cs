// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The Repository interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GenericRepository
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// The Repository interface.
    /// </summary>
    /// <typeparam name="TEntity">
    /// The entity type
    /// </typeparam>
    /// <typeparam name="TId">
    /// The type used for the entities Id property.
    /// </typeparam>
    public interface IRepository<TEntity, TId>
        where TEntity : class
        where TId : IComparable
    {
        /// <summary>
        /// Gets all entities.
        /// </summary>
        /// <returns>
        /// A <see cref="IEnumerable{TEntity}"/> containing all available entities.
        /// </returns>
        Task<IEnumerable<TEntity>> GetAllAsync();

        /// <summary>
        /// Gets the specified entity by its identifier.
        /// </summary>
        /// <param name="id">
        /// The identifier.
        /// </param>
        /// <returns>
        /// The requested entity
        /// </returns>
        Task<TEntity> GetByIdAsync(TId id);
    }
}
