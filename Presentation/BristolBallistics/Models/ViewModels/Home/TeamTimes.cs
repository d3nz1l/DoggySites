// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamTimes.cs" company="">
//   
// </copyright>
// <summary>
//   The team times.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace BristolBallistics.Models.ViewModels.Home
{
    using System.Collections.Generic;

    /// <summary>
    /// The team times.
    /// </summary>
    public class TeamTimes
    {
        /// <summary>
        /// Gets or sets the current seed times.
        /// </summary>
        public IEnumerable<SeedTime> CurrentSeedTimes { get; set; }

        /// <summary>
        /// Gets or sets the year times.
        /// </summary>
        public IEnumerable<YearTimes> YearTimes { get; set;  }  
    }
}