// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TournamentResult.cs" company="">
//   
// </copyright>
// <summary>
//   The tournament result.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Doggy.Persistence.Entities.Bfa
{
    using System;

    /// <summary>
    /// The tournament result.
    /// </summary>
    public class TournamentResult
    {
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the venue.
        /// </summary>
        public string Venue { get; set; }

        /// <summary>
        /// Gets or sets the fastest time.
        /// </summary>
        public decimal FastestTime { get; set; }
    }
}
