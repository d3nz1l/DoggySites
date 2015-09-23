// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnityContainerConfiguration.cs" company="">
//   
// </copyright>
// <summary>
//   The unity container configuration.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Doggy.Persistence
{
    using Doggy.Persistence.Entities.Flyball;
    using Doggy.Persistence.Repositories;

    using GenericRepository;

    using Microsoft.Practices.Unity;


    using Bfa = Doggy.Persistence.Entities.Bfa;

    /// <summary>
    /// The unity container configuration.
    /// </summary>
    public class PersistenceUnityConfiguration : UnityContainerExtension
    {
        /// <summary>
        /// The initialize.
        /// </summary>
        protected override void Initialize()
        {
            this.Container.RegisterType<IRepository<Bfa.Team, string>, BfaTeamRepository>();
            this.Container.RegisterType<IWebpageLoader, WebpageLoader>();
            this.Container.RegisterType<IEntityRepository<Team, string>, TeamRepository>();
        }
    }
}
