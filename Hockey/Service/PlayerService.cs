using System;
using System.Linq;
using System.Threading.Tasks;
using Hockey.Data;

namespace Hockey.Service
{
    public class PlayerService
    {
        private static Player[] Players = new[]
        {
            new Player { Id = 1, Name = "John Testington", Rank = 1, Age = 19.25m, Projection = "Elite", TeamId = 1 },
            new Player { Id = 1, Name = "Jack Busto", Rank = 1, Age = 21.65m, Projection = "Depth", TeamId = 1 }
        };

        public Task<Player> GetPlayerAsync(int playerId)
        {
            return Task.FromResult(Players.First(x => x.Id == playerId));
        }

        public Task<Player[]> GetPlayersByNameAsync(string playerName)
        {
            if(!string.IsNullOrEmpty(playerName))
            {
                return Task.FromResult(Players.Where(x => x.Name.ToLower().Contains(playerName.ToLower())).ToArray());
            }
            
            return Task.FromResult(new Player[0]);
        }
    }
}