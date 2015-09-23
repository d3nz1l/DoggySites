// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DoggyDropCreateInitialiser.cs" company="">
//   
// </copyright>
// <summary>
//   The doggy initialiser.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Doggy.Persistence
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Reflection;

    using Doggy.Persistence.Seeders;

    using Microsoft.Practices.ObjectBuilder2;

    /// <summary>
    /// The doggy initialiser.
    /// </summary>
    public class DoggyDropCreateInitialiser : DropCreateDatabaseIfModelChanges<DoggyContext>
    {
        /// <summary>
        /// The seed.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        protected override void Seed(DoggyContext context)
        {
            var seeders =
                Assembly.GetAssembly(typeof(BaseSeeder<>))
                    .GetTypes()
                    .Where(t => t.Namespace == "Doggy.Persistence.Seeders" && !t.IsAbstract)
                    .Select(Activator.CreateInstance);

            seeders.OfType<ISeeder>().ForEach(s => s.SeedEntities(context));

            base.Seed(context);
        }
    }
}
