// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SeedTime.cs" company="">
//   
// </copyright>
// <summary>
//   The current seed time.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace BristolBallistics.Models.ViewModels.Home
{
    /// <summary>
    /// The current seed time.
    /// </summary>
    public class SeedTime
    {
        /// <summary>
        /// Gets or sets the team name.
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        /// Gets or sets the seed time.
        /// </summary>
        public decimal Time { get; set; }
    }
}