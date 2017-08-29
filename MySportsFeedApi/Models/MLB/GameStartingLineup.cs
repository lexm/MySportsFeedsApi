using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportsFeedsApi.Models.MLB
{
    public class Starter
    {
        public string position { get; set; }
        public Player player { get; set; }
    }

    public class Expected
    {
        public List<Starter> starter { get; set; }
    }

    public class Starter2
    {
        public string position { get; set; }
        public Player2 player { get; set; }
    }

    public class Actual
    {
        public List<Starter2> starter { get; set; }
    }

    public class TeamLineup
    {
        public Team team { get; set; }
        public Expected expected { get; set; }
        public Actual actual { get; set; }
    }

    public class StartingLineup
    {
        public string lastUpdatedOn { get; set; }
        public Game game { get; set; }
        public List<TeamLineup> teamLineup { get; set; }
    }

    public class GameStartingLineup : IFeedRoot
    {
        public StartingLineup gamestartinglineup { get; set; }
    }
}
