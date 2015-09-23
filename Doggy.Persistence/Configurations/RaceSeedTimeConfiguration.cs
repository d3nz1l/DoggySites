// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RaceSeedTimeConfiguration.cs" company="">
//   
// </copyright>
// <summary>
//   The race seed time configuration.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Doggy.Persistence.Configurations
{
    using System.Data.Entity.ModelConfiguration;

    using Doggy.Persistence.Entities.Flyball;

    /// <summary>
    /// The race seed time configuration.
    /// </summary>
    internal class RaceSeedTimeConfiguration : EntityTypeConfiguration<RaceSeedTime>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RaceSeedTimeConfiguration"/> class.
        /// </summary>
        public RaceSeedTimeConfiguration()
        {
            this.HasRequired(rsd => rsd.TeamId).WithMany().HasForeignKey(rsd => rsd.TeamId);
        }
    }
}
