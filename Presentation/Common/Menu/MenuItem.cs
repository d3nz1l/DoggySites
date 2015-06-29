// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuItem.cs" company="">
//   
// </copyright>
// <summary>
//   The menu item.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DoggySites.Presentation.Common.Menu
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Web.Mvc;
    using System.Web.Routing;
    using System.Web.UI;

    /// <summary>
    /// The menu item.
    /// </summary>
    public class MenuItem
    {
        /// <summary>
        /// Gets or sets the children.
        /// </summary>
        public List<MenuItem> Children { get; set; }

        /// <summary>
        /// Gets a value indicating whether has children.
        /// </summary>
        public bool HasChildren 
        { 
            get
            {
                return this.Children != null && this.Children.Any();
            } 
        }

        /// <summary>
        /// Gets or sets the class.
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// Gets or sets the display text.
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets the controller.
        /// </summary>
        public string Controller { get; set; }

        /// <summary>
        /// Gets or sets the page element.
        /// </summary>
        public string PageElement { get; set; }

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
            var tag = new TagBuilder("li");

            tag.AddCssClass(this.Class);

            if (this.IsActive(html.ViewContext.RouteData))
            {
                tag.AddCssClass("active");
            }
            
            if (this.HasChildren)
            {
                tag.AddCssClass("dropdown");
            }

            var link = this.GetLink(html);

            var childMenu = this.GetChildMenu(html);

            tag.InnerHtml = string.Format(
                CultureInfo.InvariantCulture, 
                "{0}{1}", 
                link, 
                childMenu);

            return MvcHtmlString.Create(tag.ToString(TagRenderMode.Normal));
        }

        /// <summary>
        /// The is active.
        /// </summary>
        /// <param name="currentRouteData">
        /// The current route data.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool IsActive(RouteData currentRouteData)
        {
            if (!string.IsNullOrEmpty(this.PageElement))
            {
                return false;
            }

            bool isThisActive = false;

            var action = currentRouteData.Values["action"];
            var controller = currentRouteData.Values["controller"];

            isThisActive = action.ToString().Equals(this.Action, StringComparison.OrdinalIgnoreCase)
                   && controller.ToString().Equals(this.Controller, StringComparison.OrdinalIgnoreCase);

            var isChildActive = this.Children.Any(c => c.IsActive(currentRouteData));

            return isThisActive | isChildActive;
        }

        /// <summary>
        /// The get link.
        /// </summary>
        /// <param name="html">
        /// The html.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        private string GetLink(HtmlHelper html)
        {
            var tag = new TagBuilder("a");

            var pageElement = string.IsNullOrEmpty(this.PageElement)
                                  ? string.Empty
                                  : string.Format(CultureInfo.InvariantCulture, "#{0}", this.PageElement);

            if (string.IsNullOrEmpty(this.Action))
            {
                tag.Attributes.Add("href", pageElement);
            }
            else
            {
                var url = new UrlHelper(html.ViewContext.RequestContext, html.RouteCollection);
                tag.Attributes.Add("href", string.Format(CultureInfo.InvariantCulture, "{0}{1}", url.Action(this.Action, this.Controller), pageElement));
            }

            var dropdownCaret = string.Empty;

            if (this.HasChildren)
            {
                tag.AddCssClass("dropdown-toggle");
                tag.Attributes.Add("data-toggle", "dropdown");

                var caretTag = new TagBuilder("b");
                caretTag.AddCssClass("caret");

                dropdownCaret = caretTag.ToString();
            }

            tag.InnerHtml = string.Format(CultureInfo.InvariantCulture, "{0} {1}", this.DisplayText, dropdownCaret);

            return tag.ToString(TagRenderMode.Normal);
        }

        /// <summary>
        /// The get child menu.
        /// </summary>
        /// <param name="html">
        /// The html.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        private string GetChildMenu(HtmlHelper html)
        {
            if (!this.HasChildren)
            {
                return string.Empty;
            }

            var tag = new TagBuilder("ul");
            tag.AddCssClass("dropdown-menu");
            
            var children = new StringBuilder();
            foreach (var child in this.Children)
            {
                children.Append(child.ToHtml(html));
            }

            tag.InnerHtml = children.ToString();

            return tag.ToString(TagRenderMode.Normal);
        }
    }
}
