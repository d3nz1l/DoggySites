// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamConfiguration.cs" company="">
//   
// </copyright>
// <summary>
//   The team configuration.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Doggy.Persistence.Configurations
{
    using System.Data.Entity.ModelConfiguration;

    using Doggy.Persistence.Entities.Flyball;

    /// <summary>
    /// The team configuration.
    /// </summary>
    internal class TeamConfiguration : EntityTypeConfiguration<Team>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamConfiguration"/> class.
        /// </summary>
        public TeamConfiguration()
        {
        }
    }
}
