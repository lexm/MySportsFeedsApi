using System.Collections.Generic;

namespace MySportsFeedsApi.Models.MLB
{
    public class ExternalMapping
    {
        public string Source { get; set; }
        public string ID { get; set; }
    }

    public class ActivePlayer
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
        public string officialImageSrc { get; set; }
        public ExternalMapping externalMapping { get; set; }
    }

    public class Playerentry
    {
        public ActivePlayer player { get; set; }
        public Team team { get; set; }
    }

    public class ActivePlayerList
    {
        public string lastUpdatedOn { get; set; }
        public List<Playerentry> playerentry { get; set; }
    }

    public class ActivePlayers : IFeedRoot
    {
        public ActivePlayerList activeplayers { get; set; }
    }
}