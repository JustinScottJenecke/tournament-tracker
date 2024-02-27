using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamEntity
    {
        public List<PersonEntity> TeamMembers { get; set; } = new List<PersonEntity>();
        public string TeamName { get; set; }
    }
}
