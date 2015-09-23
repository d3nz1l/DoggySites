// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RaceSeedTime.cs" company="">
//   
// </copyright>
// <summary>
//   The race seed time.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Doggy.Persistence.Entities.Flyball
{
    using System;

    using GenericRepository;

    /// <summary>
    /// The race seed time.
    /// </summary>
    public class RaceSeedTime : IEntity<int>
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the team id.
        /// </summary>
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the venue.
        /// </summary>
        public string Venue { get; set; }

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        public decimal Time { get; set; }
    }
}
