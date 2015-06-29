// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmailAccount.cs" company="">
//   
// </copyright>
// <summary>
//   The EmailAccount interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Email
{
    /// <summary>
    /// The EmailAccount interface.
    /// </summary>
    public interface IEmailAccount
    {
        /// <summary>
        /// Gets the smtp address.
        /// </summary>
        string SmtpAddress { get; }

        /// <summary>
        /// Gets the username.
        /// </summary>
        string Username { get; }

        /// <summary>
        /// Gets the password.
        /// </summary>
        string Password { get; }
    }
}