using System.Collections.Generic;

namespace MySportsFeedsApi.Models.MLB
{
    public class Conference
    {
        public string name { get; set; }
        public List<TeamStandingsEntry> teamentry { get; set; }
    }

    public class ConferenceTeamStandings
    {
        public string lastUpdatedOn { get; set; }
        public List<Conference> conference { get; set; }
    }

    public class PlayoffTeamStandings : IFeedRoot
    {
        public ConferenceTeamStandings playoffteamstandings { get; set; }
    }
}