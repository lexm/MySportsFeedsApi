using System.Collections.Generic;

namespace MySportsFeedsApi.Models.MLB
{
    public class Division
    {
        public string name { get; set; }
        public List<TeamStandingsEntry> teamentry { get; set; }
    }

    public class Divisions
    {
        public string lastUpdatedOn { get; set; }
        public List<Division> division { get; set; }
    }

    public class DivisionTeamStandings : IFeedRoot
    {
        public Divisions divisionteamstandings { get; set; }
    }
}