using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doggy.Persistence.Seeders
{
    using System.Data.Entity;

    using GenericRepository;

    /// <summary>
    /// A abstract implementation of a seeder class.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    internal abstract class BaseSeeder<TEntity> : ISeeder
        where TEntity : class
    {
        /// <summary>
        /// Seeds the entities.
        /// </summary>
        /// <param name="context">The context.</param>
        public void SeedEntities(IContext context)
        {
            var entities = this.CreateEntities();

            foreach (var entity in entities)
            {
                context.EntitySet<TEntity>().Add(entity);
            }

            Task.WaitAll(context.SaveChangesAsync());
        }

        /// <summary>
        /// Creates the entities.
        /// </summary>
        /// <returns></returns>
        protected abstract IEnumerable<TEntity> CreateEntities();
    }
}
