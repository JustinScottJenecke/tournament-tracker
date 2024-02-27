using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntity
    {
        public List <MatchupEntryEntity> Entries { get; set; } = new List<MatchupEntryEntity> ();
        public TeamEntity Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}
