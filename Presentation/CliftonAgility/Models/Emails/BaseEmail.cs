// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseEmail.cs" company="">
//   
// </copyright>
// <summary>
//   The base email.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace CliftonAgility.Models.Emails
{
    /// <summary>
    /// The base email.
    /// </summary>
    public class BaseEmail : Postal.Email
    {
        /// <summary>
        /// Gets or sets the to.
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Gets or sets the from.
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Gets or sets the reply to.
        /// </summary>
        public string ReplyTo { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        public string Subject { get; set; }
    }
}