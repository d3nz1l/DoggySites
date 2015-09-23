// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The team repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Doggy.Persistence.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    using Doggy.Persistence.Entities.Flyball;

    using GenericRepository;

    /// <summary>
    /// The team repository.
    /// </summary>
    public class TeamRepository : EntityRepository<Team, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRepository"/> class.
        /// </summary>
        /// <param name="entityContext">The entity context.</param>
        public TeamRepository(IContext entityContext) : base(entityContext)
        {
        }


    }
}
