// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MembersDog.cs" company="">
//   
// </copyright>
// <summary>
//   The members dog.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace CliftonAgility.Models.Membership
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using DoggySites.Presentation.Common.Enumerations;

    /// <summary>
    /// The members dog.
    /// </summary>
    public class MembersDog
    {
        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Gender")]
        public DogGender? Gender { get; set; }

        /// <summary>
        /// Gets or sets the name of the pet.
        /// </summary>
        /// <value>
        /// The name of the pet.
        /// </value>
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Pet Name")]
        public string PetName { get; set; }

        /// <summary>
        /// Gets or sets the name of the kennel club.
        /// </summary>
        /// <value>
        /// The name of the kennel club.
        /// </value>
        [DataType(DataType.Text)]
        [Display(Name = "Kennel Club Name")]
        public string KennelClubName { get; set; }

        /// <summary>
        /// Gets or sets the kennel club number.
        /// </summary>
        /// <value>
        /// The kennel club number.
        /// </value>
        [DataType(DataType.Text)]
        [Display(Name = "Kennel Club Registration Number (if known)")]
        public string KennelClubNumber { get; set; }

        /// <summary>
        /// Gets or sets the breed.
        /// </summary>
        /// <value>
        /// The breed.
        /// </value>
        [Required]
        [Display(Name = "Breed")]
        public DogBreeds? Breed { get; set; }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        /// <value>
        /// The date of birth.
        /// </value>
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="MembersDog"/> is delete.
        /// </summary>
        /// <value>
        ///   <c>true</c> if delete; otherwise, <c>false</c>.
        /// </value>
        public bool Delete { get; set; }
    }
}