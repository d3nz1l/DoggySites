// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IWebpageLoader.cs" company="">
//   
// </copyright>
// <summary>
//   The WebpageLoader interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Doggy.Persistence
{
    using HtmlAgilityPack;

    /// <summary>
    /// The WebpageLoader interface.
    /// </summary>
    public interface IWebpageLoader
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
        HtmlDocument LoadPage(string url);
    }
}
