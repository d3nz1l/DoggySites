// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Team.cs" company="">
//   
// </copyright>
// <summary>
//   The team.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Doggy.Persistence.Entities.Bfa
{
    using System.Collections.Generic;

    using GenericRepository;

    /// <summary>
    /// The team.
    /// </summary>
    public class Team : IEntity<string>
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the current seed time.
        /// </summary>
        public decimal CurrentSeedTime { get; set; }

        /// <summary>
        /// Gets or sets the racing history.
        /// </summary>
        public IEnumerable<TournamentResult> RacingHistory { get; set; }
    }
}
