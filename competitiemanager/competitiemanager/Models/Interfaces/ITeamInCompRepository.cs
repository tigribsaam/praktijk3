using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Interfaces
{
    interface ITeamInCompRepository
    {
        IEnumerable<Team> AllTeams { get; }

        Team GetTeamById(int TeamId);

        //add parameters
        void AddTeam();
    }
}
