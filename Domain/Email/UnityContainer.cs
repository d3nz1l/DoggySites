﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnityContainer.cs" company="">
//   
// </copyright>
// <summary>
//   The unity.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Email
{
    using System;

    using Microsoft.Practices.Unity;

    /// <summary>
    /// The unity.
    /// </summary>
    internal static class Unity
    {
        /// <summary>
        /// The singleton container.
        /// </summary>
        private static readonly Lazy<IUnityContainer> singletonContainer = new Lazy<IUnityContainer>(() =>
            {
                var container = new UnityContainer();
                RegisterTypes(container);
                return container;
            });

        /// <summary>
        ///     Gets the configured Unity container.
        /// </summary>
        /// <value>
        ///     The <see cref="IUnityContainer" />.
        /// </value>
        public static IUnityContainer ConfiguredContainer
        {
            get
            {
                return singletonContainer.Value;
            }
        }

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">
        /// The unity container to configure.
        /// </param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or API controllers (unless you want to 
        ///     change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
        }
    }
}
