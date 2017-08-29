using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportsFeedsApi.Models.MLB
{
    public class GamesBack
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Gamelog
    {
        public Game game { get; set; }
        public Team team { get; set; }
        public Stats stats { get; set; }
    }

    public class Gamelogs
    {
        public string lastUpdatedOn { get; set; }
        public List<Gamelog> gamelogs { get; set; }
    }

    public class TeamGameLogs : IFeedRoot
    {
        public Gamelogs teamgamelogs { get; set; }
    }
}