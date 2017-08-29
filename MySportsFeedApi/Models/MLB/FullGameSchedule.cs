using System.Collections.Generic;

namespace MySportsFeedsApi.Models.MLB
{
    public class AwayTeam
    {
        public string ID { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }

    public class HomeTeam
    {
        public string ID { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }

    public class GameEntry
    {
        public string id { get; set; }
        public string scheduleStatus { get; set; }
        public object originalDate { get; set; }
        public object originalTime { get; set; }
        public object delayedOrPostponedReason { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public AwayTeam awayTeam { get; set; }
        public HomeTeam homeTeam { get; set; }
        public string location { get; set; }
    }

    public class GameSchedule
    {
        public string lastUpdatedOn { get; set; }
        public List<GameEntry> gameentry { get; set; }
    }

    public class FullGameSchedule : IFeedRoot
    {
        public GameSchedule fullgameschedule { get; set; }
    }
}