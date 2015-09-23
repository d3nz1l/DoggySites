// --------------------------------------------------------------------------------------------------------------------
// <copyright file="YearTimes.cs" company="">
//   
// </copyright>
// <summary>
//   The year times.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace BristolBallistics.Models.ViewModels.Home
{
    using System.Collections.Generic;

    /// <summary>
    /// The year times.
    /// </summary>
    public class YearTimes
    {
        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the seed times.
        /// </summary>
        public IEnumerable<SeedTime> SeedTimes { get; set; }
    }
}