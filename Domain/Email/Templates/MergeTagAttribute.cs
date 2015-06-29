// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MergeTagAttribute.cs" company="">
//   
// </copyright>
// <summary>
//   The merge tag attribute.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Email.Templates
{
    using System;

    /// <summary>
    /// The merge tag attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    internal class MergeTagAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MergeTagAttribute"/> class.
        /// </summary>
        /// <param name="tagName">
        /// The tag name.
        /// </param>
        public MergeTagAttribute(string tagName)
        {
            this.TagName = tagName;
        }

        /// <summary>
        /// Gets or sets the tag name.
        /// </summary>
        public string TagName { get; set; }
    }
}
