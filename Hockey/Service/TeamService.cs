using System;
using System.Linq;
using System.Threading.Tasks;
using Hockey.Data;

namespace Hockey.Service
{
    public class TeamService
    {
        private static Team[] Teams = new[]
        {
            new Team { Id = 1, Name = "Team Venture", Rank = 1 },
            new Team { Id = 2, Name = "Fighting Mongooses", Rank = 2 }
        };

        public Task<Team> GetTeamAsync(int teamId)
        {
            return Task.FromResult(Teams.First(x => x.Id == teamId));
        }

        public Task<Team[]> GetTeamsAsync()
        {
            return Task.FromResult(Teams);
        }
    }
}