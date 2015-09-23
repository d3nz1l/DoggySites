// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExperienceLevel.cs" company="">
//   
// </copyright>
// <summary>
//   The experience level.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CliftonAgility.Models.Membership
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The experience level.
    /// </summary>
    public enum ExperienceLevel
    {
        /// <summary>
        /// The starter.
        /// </summary>
        [Display(Name = "Starter - New to Agility/Never competed")]
        Starter, 

        /// <summary>
        /// The beginner.
        /// </summary>
        [Display(Name = "Beginner - Competed at Grades 1-2")]
        Beginner, 

        /// <summary>
        /// The novice.
        /// </summary>
        [Display(Name = "Novice - Competed at Grades 3-5")]
        Novice, 

        /// <summary>
        /// The senior.
        /// </summary>
        [Display(Name = "Senior - Competed at Grades 6-7")]
        Senior
    }
}