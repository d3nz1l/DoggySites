// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DoggyContext.cs" company="Brightside Group plc.">
//   Copyright (c) 2009-2014, Brightside Group plc. All rights reserved.
// </copyright>
// <summary>
//   The doggy context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Doggy.Persistence
{
    using System.Data.Entity;

    /// <summary>
    /// The doggy context.
    /// </summary>
    public class DoggyContext : DbContext
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="DoggyContext"/> class.
        /// </summary>
        public DoggyContext() : base("EntityConnection")
        {
        }
    }
}
