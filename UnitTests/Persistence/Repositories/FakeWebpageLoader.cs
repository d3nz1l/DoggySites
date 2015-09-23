// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FakeWebpageLoader.cs" company="">
//   
// </copyright>
// <summary>
//   The fake webpage loader.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace UnitTests.Persistence.Repositories
{
    using Doggy.Persistence;

    using HtmlAgilityPack;

    /// <summary>
    /// The fake webpage loader.
    /// </summary>
    internal class FakeWebpageLoader : IWebpageLoader
    {
        /// <summary>
        /// The page source.
        /// </summary>
        private readonly string pageSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="FakeWebpageLoader"/> class.
        /// </summary>
        /// <param name="pageSource">
        /// The page source.
        /// </param>
        public FakeWebpageLoader(string pageSource)
        {
            this.pageSource = pageSource;
        }

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
            var doc = new HtmlDocument();
            doc.LoadHtml(this.pageSource);

            return doc;
        }
    }
}
