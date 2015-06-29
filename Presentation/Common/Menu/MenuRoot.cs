// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuRoot.cs" company="">
//   
// </copyright>
// <summary>
//   The menu root.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DoggySites.Presentation.Common.Menu
{
    using System.Collections.Generic;
    using System.Text;
    using System.Web.Mvc;

    /// <summary>
    /// The menu root.
    /// </summary>
    public class MenuRoot
    {
        /// <summary>
        /// Gets or sets the children.
        /// </summary>
        public List<MenuItem> Children { get; set; }

        /// <summary>
        /// Gets or sets the class.
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The to html.
        /// </summary>
        /// <param name="html">
        /// The html.
        /// </param>
        /// <returns>
        /// The <see cref="MvcHtmlString"/>.
        /// </returns>
        public MvcHtmlString ToHtml(HtmlHelper html)
        {
            var tag = new TagBuilder("ul");
            tag.Attributes.Add("id", this.Id);
            tag.AddCssClass(this.Class);

            var children = new StringBuilder();
            foreach (var child in this.Children)
            {
                children.AppendLine(child.ToHtml(html).ToHtmlString());
            }

            tag.InnerHtml = children.ToString();

            return MvcHtmlString.Create(tag.ToString(TagRenderMode.Normal));
        }
    }
}
