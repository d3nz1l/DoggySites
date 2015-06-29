// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuHelper.cs" company="">
//   
// </copyright>
// <summary>
//   The menu helper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DoggySites.Presentation.Common.HtmlHelpers
{
    using System.Web.Mvc;

    using DoggySites.Presentation.Common.Menu;

    /// <summary>
    /// The menu helper.
    /// </summary>
    public static class MenuHelper
    {
        /// <summary>
        /// The menu.
        /// </summary>
        /// <param name="html">
        /// The html.
        /// </param>
        /// <param name="pathToMenuXml">
        /// The path to menu xml.
        /// </param>
        /// <returns>
        /// The <see cref="MvcHtmlString"/>.
        /// </returns>
        public static MvcHtmlString Menu(this HtmlHelper html, string pathToMenuXml)
        {
            var builder = new MenuBuilder();

            var menu  = builder.BuildMenu<MenuRoot>(pathToMenuXml);

            return menu.ToHtml(html);
        }
    }
}