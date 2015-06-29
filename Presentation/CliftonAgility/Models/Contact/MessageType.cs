// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MessageType.cs" company="">
//   
// </copyright>
// <summary>
//   The message type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CliftonAgility.Models.Contact
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The message type.
    /// </summary>
    public enum MessageType
    {
        /// <summary>
        /// The information.
        /// </summary>
        [Display(Name = "Request Information")]
        Information, 

        /// <summary>
        /// The membership.
        /// </summary>
        [Display(Name = "Membership Enquiry")]
        Membership, 

        /// <summary>
        /// The comment.
        /// </summary>
        [Display(Name = "Send us a comment")]
        Comment, 

        /// <summary>
        /// The other.
        /// </summary>
        [Display(Name = "Any Other Question")]
        Other
    }
}