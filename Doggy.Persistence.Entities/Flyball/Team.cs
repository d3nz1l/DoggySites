// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Team.cs" company="">
//   
// </copyright>
// <summary>
//   The team.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Doggy.Persistence.Entities.Flyball
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using GenericRepository;

    /// <summary>
    /// The team.
    /// </summary>
    public class Team : IEntity<string>
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the current seed time.
        /// </summary>
        public decimal CurrentSeedTime { get; set; }

        /// <summary>
        /// Gets the fastest ever time.
        /// </summary>
        public decimal FastestEverTime
        {
            get
            {
                return this.SeedTimes.Min(st => st.Time);
            }
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the last update.
        /// </summary>
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the seed times.
        /// </summary>
        public IEnumerable<RaceSeedTime> SeedTimes { get; set; }

        #endregion
    }
}
