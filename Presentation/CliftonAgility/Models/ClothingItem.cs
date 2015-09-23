// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClothingItem.cs" company="">
//   
// </copyright>
// <summary>
//   The clothing item.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace CliftonAgility.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The clothing item.
    /// </summary>
    public class ClothingItem
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        [UIHint("Currency")]
        public decimal Price { get; set; }
    }
}