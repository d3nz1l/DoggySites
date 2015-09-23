// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BfaTeamRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The BFA team repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Doggy.Persistence.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
    using System.Globalization;
    using System.Linq;
    using System.Threading.Tasks;

    using Doggy.Persistence.Entities.Bfa;
    using Doggy.Persistence.Helpers;

    using GenericRepository;

    using HtmlAgilityPack;

    /// <summary>
    /// The BFA team repository.
    /// </summary>
    public class BfaTeamRepository : WebsiteRepository<Team, string>
    {
        /// <summary>
        /// The team URL template
        /// </summary>
        private const string TeamUrlTemplate = "http://www.flyball.org.uk/database/teams.php?teamtrn={0}";

        /// <summary>
        /// The team entity repository.
        /// </summary>
        private readonly IEntityRepository<Team, string> teamEntityRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="BfaTeamRepository"/> class.
        /// </summary>
        /// <param name="teamEntityRepository">
        /// The team Entity Repository.
        /// </param>
        /// <param name="webpageLoader">
        /// The webpage loader.
        /// </param>
        public BfaTeamRepository(IWebpageLoader webpageLoader) 
            : base(webpageLoader)
        {
            // this.teamEntityRepository = teamEntityRepository;
        }

        /// <summary>
        /// The get all asynchronous.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// Currently not implemented
        /// </exception>
        public override Task<IEnumerable<Team>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The get by id asynchronous.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public override async Task<Team> GetByIdAsync(string id)
        {
            var teamUrl = string.Format(CultureInfo.InvariantCulture, TeamUrlTemplate, id);

            var webPage = await this.LoadWebpage(teamUrl);

            var team = new Team
                           {
                               Id = id, 
                               CurrentSeedTime = this.GetCurrentSeedtime(webPage), 
                               RacingHistory = this.GetResultHistory(webPage)
                           };

            return team;
        }

        /// <summary>
        /// The get result history.
        /// </summary>
        /// <param name="webPage">
        /// The web page.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable{TournamentResult}"/>.
        /// </returns>
        private IEnumerable<TournamentResult> GetResultHistory(HtmlDocument webPage)
        {
            var table = webPage.DocumentNode.SelectSingleNode("//table/tr[td = 'Fastest Time']").ParentNode;

            var rows = table.SelectNodes("tr");

            var results = new List<TournamentResult>(rows.Count - 1);

            // Ignore first row, its the header
            for (int i = 1; i < rows.Count; i++)
            {
                var elements = rows[i].SelectNodes("td");

                var dateValue = elements[0].InnerText;
                var venue = elements[1].InnerText;
                var fastestTimeValue = elements[2].InnerText;

                var date = DateHelper.Parse(dateValue);
                var fastestTime = decimal.Parse(fastestTimeValue);

                var result = new TournamentResult
                                 {
                                     Date = date,
                                     Venue = venue,
                                     FastestTime = fastestTime
                                 };

                results.Add(result);
            }

            return results;
        }

        /// <summary>
        /// The get current seed time.
        /// </summary>
        /// <param name="webPage">
        /// The web page.
        /// </param>
        /// <returns>
        /// The <see cref="decimal"/>.
        /// </returns>
        private decimal GetCurrentSeedtime(HtmlDocument webPage)
        {
            try
            {
                var tdElements = webPage.DocumentNode.SelectNodes("//td");

                var tdElement = tdElements.FirstOrDefault(td => td.InnerText.StartsWith("Current Seed Time"));

                if (tdElement == null)
                {
                    return 0M;
                }

                var seedTimeValue = tdElement.LastChild.InnerText;

                return decimal.Parse(seedTimeValue);
            }
            catch (Exception)
            {
                return 0M;
            }
        }
    }
}
