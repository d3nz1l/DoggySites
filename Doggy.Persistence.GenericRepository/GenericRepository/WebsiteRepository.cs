// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebsiteRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The website repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GenericRepository
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Doggy.Persistence;

    using HtmlAgilityPack;

    /// <summary>
    /// The website repository.
    /// </summary>
    /// <typeparam name="TEntity">
    /// The entity type
    /// </typeparam>
    /// <typeparam name="TId">
    /// The entities identifier type
    /// </typeparam>
    public abstract class WebsiteRepository<TEntity, TId> : IRepository<TEntity, TId>
        where TEntity : class
        where TId : IComparable
    {
        /// <summary>
        /// The page loader.
        /// </summary>
        private readonly IWebpageLoader pageLoader;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteRepository{TEntity,TId}"/> class.
        /// </summary>
        /// <param name="pageLoader">
        /// The page loader.
        /// </param>
        protected WebsiteRepository(IWebpageLoader pageLoader)
        {
            this.pageLoader = pageLoader;
        }

        /// <summary>
        /// The get all asynchronous.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public abstract Task<IEnumerable<TEntity>> GetAllAsync();

        /// <summary>
        /// The get by id asynchronous.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public abstract Task<TEntity> GetByIdAsync(TId id);

        /// <summary>
        /// The load web page.
        /// </summary>
        /// <param name="url">
        /// The URL.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        protected async Task<HtmlDocument> LoadWebpage(string url)
        {
            return await Task.Run(() => this.pageLoader.LoadPage(url)).ConfigureAwait(false);
        }
    }
}
