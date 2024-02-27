using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentEntity
    {
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamEntity> EnteredTeams { get; set; } = new List<TeamEntity>();
        public List<PrizeEntity> Prizes { get; set; } = new List<PrizeEntity>();
        public List<MatchupEntity> Rounds { get; set; } = new List<MatchupEntity>();
    }
}
