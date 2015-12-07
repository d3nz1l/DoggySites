// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmailValidatorAttribute.cs" company="">
//   
// </copyright>
// <summary>
//   The email validator attribute.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DoggySites.Presentation.Common.Attributes
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    using DoggySites.Email;

    /// <summary>
    /// The email validator attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public sealed class EmailValidatorAttribute : DataTypeAttribute
    {
        /// <summary>
        /// The _regex.
        /// </summary>
        private static Regex regex = new Regex(@"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);

        /// <summary>
        /// The email validator.
        /// </summary>
        private readonly IEmailValidator emailValidator;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailValidatorAttribute" /> class.
        /// </summary>
        public EmailValidatorAttribute()
            : base(DataType.EmailAddress)
        {
            this.emailValidator = new EmailValidator();
        }

        /// <summary>
        /// The is valid.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public override bool IsValid(object value)
        {
            var email = value as string;

            if (string.IsNullOrEmpty(email))
            {
                // This merely checks valid email forms and not a required. 
                return true;
            }

            var hasMailExchange = this.emailValidator.IsValid(email);

            return regex.IsMatch(email) && hasMailExchange;
        }
    }
}
