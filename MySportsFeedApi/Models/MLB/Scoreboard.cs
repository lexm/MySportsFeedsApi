using System.Collections.Generic;

namespace MySportsFeedsApi.Models.MLB
{
    public class Game
    {
        public string ID { get; set; }
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

    public class Inning
    {
        public string number { get; set; }
        public string awayScore { get; set; }
        public string homeScore { get; set; }
    }

    public class InningSummary
    {
        public List<Inning> inning { get; set; }
    }

    public class GameScore
    {
        public Game game { get; set; }
        public string isUnplayed { get; set; }
        public string isInProgress { get; set; }
        public string isCompleted { get; set; }
        public object playStatus { get; set; }
        public string awayScore { get; set; }
        public string homeScore { get; set; }
        public InningSummary inningSummary { get; set; }
    }

    public class Scores
    {
        public string lastUpdatedOn { get; set; }
        public List<GameScore> gameScore { get; set; }
    }

    public class ScoreBoard : IFeedRoot
    {
        public Scores scoreboard { get; set; }
    }
}