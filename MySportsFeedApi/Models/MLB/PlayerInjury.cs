using System.Collections.Generic;

namespace MySportsFeedsApi.Models.MLB
{
    public class InjuredPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string BirthDate { get; set; }
        public string Age { get; set; }
        public string BirthCity { get; set; }
        public string BirthCountry { get; set; }
        public string IsRookie { get; set; }
    }

    public class PlayerInjuryEntry
    {
        public InjuredPlayer player { get; set; }
        public Team team { get; set; }
        public string injury { get; set; }
    }

    public class PlayerInjuriesList
    {
        public string lastUpdatedOn { get; set; }
        public List<PlayerInjuryEntry> playerentry { get; set; }
    }

    public class PlayerInjuries : IFeedRoot
    {
        public PlayerInjuriesList playerinjuries { get; set; }
    }
}