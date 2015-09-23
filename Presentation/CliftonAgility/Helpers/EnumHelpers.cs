// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnumHelpers.cs" company="">
//   
// </copyright>
// <summary>
//   The enum helpers.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace CliftonAgility.Helpers
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Web.Mvc;

    /// <summary>
    /// The enum helpers.
    /// </summary>
    public static class EnumHelpers
    {
        /// <summary>
        /// The display for enum.
        /// </summary>
        /// <param name="html">
        /// The html.
        /// </param>
        /// <param name="expression">
        /// The expression.
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        /// <typeparam name="TEnum">
        /// </typeparam>
        /// <returns>
        /// The <see cref="MvcHtmlString"/>.
        /// </returns>
        public static MvcHtmlString DisplayForEnum<T, TEnum>(this HtmlHelper<T> html, Expression<Func<T, TEnum>> expression)
        {
            var memberExpression = expression.Body as MemberExpression;

            if (memberExpression == null)
            {
                return MvcHtmlString.Empty;
            }

            var metadata = ModelMetadata.FromLambdaExpression(expression, html.ViewData);

            var type = metadata.ModelType;

            if (type.IsGenericType)
            {
                type = type.GenericTypeArguments.First();
            }

            return GetDisplayName(type, metadata.Model.ToString());
        }

        /// <summary>
        /// The to display string.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="MvcHtmlString"/>.
        /// </returns>
        public static MvcHtmlString ToDisplayString(this Enum value)
        {
            return GetDisplayName(value.GetType(), value.ToString());
        }

        /// <summary>
        /// The get display name.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="MvcHtmlString"/>.
        /// </returns>
        private static MvcHtmlString GetDisplayName(Type type, string value)
        {
            var display = (DisplayAttribute)type.GetField(value).GetCustomAttributes(typeof(DisplayAttribute)).FirstOrDefault();

            if (display == null || string.IsNullOrEmpty(display.Name))
            {
                return new MvcHtmlString(value);
            }

            return new MvcHtmlString(display.Name);
        }
    }
}