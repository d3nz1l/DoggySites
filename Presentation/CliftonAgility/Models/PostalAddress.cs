// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PostalAddress.cs" company="">
//   
// </copyright>
// <summary>
//   The postal address.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace CliftonAgility.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;

    /// <summary>
    /// The postal address.
    /// </summary>
    public class PostalAddress
    {
        /// <summary>
        /// Gets or sets the house name number.
        /// </summary>
        public string HouseNameNumber { get; set; }

        /// <summary>
        /// Gets or sets the street name.
        /// </summary>
        public string StreetName { get; set; }

        /// <summary>
        /// Gets or sets the address line 2.
        /// </summary>
        [UIHint("StringEmptyCheck")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the address line 3.
        /// </summary>
        [UIHint("StringEmptyCheck")]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Gets or sets the address line 4.
        /// </summary>
        [UIHint("StringEmptyCheck")]
        public string AddressLine4 { get; set; }

        /// <summary>
        /// Gets or sets the postcode.
        /// </summary>
        [UIHint("StringEmptyCheck")]
        public string Postcode { get; set; }
    }
}