namespace DoggySites.Email
{
    using System.Threading.Tasks;

    public interface IEmailValidator
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
        bool IsValid(string emailAddress);
    }
}