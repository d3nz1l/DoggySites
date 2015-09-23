// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GoogleMapsHelpers.cs" company="">
//   
// </copyright>
// <summary>
//   The google maps helpers.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DoggySites.Presentation.Common.HtmlHelpers
{
    using System.Globalization;
    using System.Web.Mvc;

    /// <summary>
    /// The google maps helpers.
    /// </summary>
    public static class GoogleMapsHelpers
    {
        /// <summary>
        /// The google map link.
        /// </summary>
        /// <param name="url">
        /// The url.
        /// </param>
        /// <param name="longitude">
        /// The longitude.
        /// </param>
        /// <param name="latitude">
        /// The latitude.
        /// </param>
        /// <param name="zoomLevel">
        /// The zoom level.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string GoogleMapLink(this UrlHelper url, decimal longitude, decimal latitude, int zoomLevel)
        {
            //const string urlTemplate = "http://maps.google.com/?ie=UTF8&hq=&ll={1},{0}&z={2}";
            const string urlTemplate = "http://maps.google.com/maps?&z={2}&q={1}+{0}&ll={1}+{0}";

            return string.Format(CultureInfo.InvariantCulture, urlTemplate, longitude, latitude, zoomLevel);
        }
    }
}