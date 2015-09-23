// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEntity.cs" company="Brightside Group PLC">
//   Copyright (c) 2009-2012, Brightside Group plc. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace GenericRepository
{
    /// <summary>
    /// Represents an entities basic properties
    /// </summary>
    /// <typeparam name="T">The identifier type</typeparam>
    public interface IEntity<T>
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        T Id { get; set; }
    }
}
