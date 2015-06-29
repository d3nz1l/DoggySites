// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmailTemplate.cs" company="">
//   
// </copyright>
// <summary>
//   The EmailTemplate interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Email
{
    using System.Collections.Generic;

    /// <summary>
    /// The EmailTemplate interface.
    /// </summary>
    public interface IEmailTemplate
    {
        /// <summary>
        /// Gets or sets the senders address.
        /// </summary>
        string SendersAddress { get; }

        /// <summary>
        /// Gets or sets the reply to address.
        /// </summary>
        string ReplyToAddress { get; }

        /// <summary>
        /// Gets or sets the recipient address.
        /// </summary>
        IEnumerable<string> RecipientAddresses { get; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        string Subject { get; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        string Body { get; }
    }
}