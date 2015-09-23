// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Location.cs" company="">
//   
// </copyright>
// <summary>
//   The location.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CliftonAgility.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The location.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        public decimal Longitude { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        public decimal Latitude { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        [UIHint("BlockAddress")]
        public PostalAddress Address { get; set; }
    }
}