// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmailValidator.cs" company="">
//   
// </copyright>
// <summary>
//   The email validator.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DoggySites.Email
{
    using System.Linq;
    using System.Threading.Tasks;

    using ARSoft.Tools.Net;
    using ARSoft.Tools.Net.Dns;

    /// <summary>
    /// The email validator.
    /// </summary>
    public class EmailValidator : IEmailValidator
    {
        /// <summary>
        /// The is valid.
        /// </summary>
        /// <param name="emailAddress">
        /// The email address.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public bool IsValid(string emailAddress)
        {
            var emailParts = emailAddress.Split('@');

            if (emailParts.Length != 2)
            {
                return false;
            }

            var response = DnsClient.Default.Resolve(DomainName.Parse(emailParts.Last()), RecordType.Mx);

            var mailRecords = response.AnswerRecords.OfType<MxRecord>();

            return mailRecords.Any();
        }
    }
}
