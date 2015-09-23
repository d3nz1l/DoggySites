// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DoggyContext.cs" company="">
//   
// </copyright>
// <summary>
//   The doggy context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Doggy.Persistence
{
    using System.Data.Entity;

    using Doggy.Persistence.Configurations;
    using Doggy.Persistence.Entities.Bfa;

    using GenericRepository;

    /// <summary>
    /// The doggy context.
    /// </summary>
    public class DoggyContext : EntityContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoggyContext"/> class. 
        /// </summary>
        public DoggyContext()
            : base("DefaultConnection")
        {
        }

        /// <summary>
        /// Gets or sets the teams.
        /// </summary>
        /// <value>
        /// The teams.
        /// </value>
        public IDbSet<Team> Teams { get; set; }

        /// <summary>
        /// The on model creating.
        /// </summary>
        /// <param name="modelBuilder">
        /// The model builder.
        /// </param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TeamConfiguration());
            modelBuilder.Configurations.Add(new RaceSeedTimeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
