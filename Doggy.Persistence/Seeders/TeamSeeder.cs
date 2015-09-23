// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamSeeder.cs" company="">
//   
// </copyright>
// <summary>
//   The team seeder.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Doggy.Persistence.Seeders
{
    using System;
    using System.Collections.Generic;

    using Doggy.Persistence.Entities.Flyball;

    /// <summary>
    /// The team seeder.
    /// </summary>
    internal class TeamSeeder : BaseSeeder<Team>
    {
        /// <summary>
        /// The create entities.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        protected override IEnumerable<Team> CreateEntities()
        {
            return new List<Team>
                       {
                           new Team { Id = "018", Name = "Bristol Ball-istics" },
                           new Team { Id = "018B", Name = "Bristol Ball-istic Missiles" },
                           new Team { Id = "018C", Name = "Bristol Ball-istic Scuds" },
                           new Team { Id = "018E", Name = "Bristol Ball-istic Extraset" },
                           new Team { Id = "018F", Name = "Bristol Ball-istic Rockets" },
                           new Team { Id = "018G", Name = "Bristol Ball-istic Bombshells" },
                           new Team { Id = "018H", Name = "Bristol Ball-istic Bombers" }
                       };
        }
    }
}
