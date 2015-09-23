// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebpageLoader.cs" company="">
//   
// </copyright>
// <summary>
//   The webpage loader.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Doggy.Persistence
{
    using HtmlAgilityPack;

    /// <summary>
    /// The webpage loader.
    /// </summary>
    public class WebpageLoader : IWebpageLoader
    {
        /// <summary>
        /// The load page.
        /// </summary>
        /// <param name="url">
        /// The url.
        /// </param>
        /// <returns>
        /// The <see cref="HtmlDocument"/>.
        /// </returns>
        public HtmlDocument LoadPage(string url)
        {
            var web = new HtmlWeb();

            return web.Load(url);
        }
    }
}
