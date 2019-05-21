using System.Linq;
using System.Collections.Generic;

namespace Hockey.Data
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}