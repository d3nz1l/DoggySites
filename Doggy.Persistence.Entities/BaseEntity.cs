// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseEntity.cs" company="Brightside Group plc.">
//   Copyright (c) 2009-2014, Brightside Group plc. All rights reserved.
// </copyright>
// <summary>
//   The base entity.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Doggy.Persistence.Entities
{
    /// <summary>
    /// The base entity.
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }
    }
}
