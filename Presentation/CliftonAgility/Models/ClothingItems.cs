// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClothingItems.cs" company="">
//   
// </copyright>
// <summary>
//   The clothing items.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CliftonAgility.Models
{
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// The clothing items.
    /// </summary>
    public class ClothingItems : IEnumerable<ClothingItem>
    {
        /// <summary>
        /// The internal collection.
        /// </summary>
        private List<ClothingItem> internalCollection;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClothingItems"/> class.
        /// </summary>
        public ClothingItems()
        {
            this.CreateClothingItems();
        }

        /// <summary>
        /// The get enumerator.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerator"/>.
        /// </returns>
        public IEnumerator<ClothingItem> GetEnumerator()
        {
            return this.internalCollection.GetEnumerator();
        }

        /// <summary>
        /// The get enumerator.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerator"/>.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// The create clothing items.
        /// </summary>
        private void CreateClothingItems()
        {
            this.internalCollection = new List<ClothingItem>
                    {
                        new ClothingItem { Name = "T-Shirt", Price = 12, Description = "Standard grey short sleeve t-shirts with an embroidered Clifton Agility Club logo on the left breast." }, 
                        new ClothingItem { Name = "Polo Shirt", Price = 12, Description = "Blue short sleeve polo shirt with an embroidered Clifton Agility Club logo on the left breast." }, 
                        new ClothingItem { Name = "Body Warmer (Gilet) - Padded", Price = 26, Description = "A padded version of the body warmer in dark blue. Again with the club logo on the left breast." }, 
                        new ClothingItem { Name = "Sweatshirt", Price = 16, Description = "Blue long sleeved sweatshirt with the club logo on the left breast." }, 
                        new ClothingItem { Name = "Hoodies", Price = 22, Description = "Blue long sleeved hoodie with grey hood lining." }, 
                        new ClothingItem { Name = "Jacket", Price = 44, Description = "Long sleeved, fleece lined jacket with club logo on the left breast and an embroidered 'Clifton Agility Club' on the back." }
                    };
        }
    }
}