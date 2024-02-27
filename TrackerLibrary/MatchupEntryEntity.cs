using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryEntity
    {
        /// <summary>
        ///     represents one team in the matchup
        /// </summary>
        public TeamEntity TeamCompeting { get; set; }

        /// <summary>
        ///     represwents the score for this particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        ///     represents the matchup that this team came from as the winner
        /// </summary>
        public MatchupEntity ParentMatchup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialScore"></param>
        public MatchupEntryEntity(double initialScore)
        {
            
        }
    }
}
