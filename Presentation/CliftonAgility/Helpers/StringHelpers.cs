// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StringHelpers.cs" company="">
//   
// </copyright>
// <summary>
//   The string helpers.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace CliftonAgility.Helpers
{
    using System.Text;

    /// <summary>
    /// The string helpers.
    /// </summary>
    public static class StringHelpers
    {
        /// <summary>
        /// The to title from camel.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string ToTitleFromCamel(this string value)
        {
            var title = new StringBuilder();

            foreach (var letter in value.ToCharArray())
            {
                if (char.IsUpper(letter) && title.Length > 0)
                {
                    title.Append(" ");
                }

                title.Append(letter);
            }

            return title.ToString();
        }
    }
}