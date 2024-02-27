using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryEntity
    {
        public TeamEntity TeamCompeting { get; set; }
        public double Score { get; set; }
        public MatchupEntity ParentMatchup { get; set; }
    }
}
