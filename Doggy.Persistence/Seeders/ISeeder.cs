// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISeeder.cs" company="">
//   
// </copyright>
// <summary>
//   The Seeder interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Doggy.Persistence.Seeders
{
    using GenericRepository;

    /// <summary>
    /// The Seeder interface.
    /// </summary>
    internal interface ISeeder
    {
        /// <summary>
        /// Seeds the entities.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        void SeedEntities(IContext context);
    }
}