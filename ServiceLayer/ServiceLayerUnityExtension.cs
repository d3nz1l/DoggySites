// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceLayerUnityExtension.cs" company="">
//   
// </copyright>
// <summary>
//   The service layer unity extension.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ServiceLayer
{
    using Doggy.Persistence;

    using GenericRepository;

    using Microsoft.Practices.Unity;

    /// <summary>
    /// The service layer unity extension.
    /// </summary>
    public class ServiceLayerUnityExtension : UnityContainerExtension
    {
        /// <summary>
        /// The initialize.
        /// </summary>
        protected override void Initialize()
        {
            this.Container.RegisterType<IContext, DoggyContext>(new PerRequestLifetimeManager());

            this.Container.AddNewExtension<PersistenceUnityConfiguration>();
        }
    }
}
