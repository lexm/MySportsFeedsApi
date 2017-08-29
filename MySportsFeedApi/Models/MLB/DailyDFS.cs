using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportsFeedsApi.Models.MLB
{
    public class DfsRow
    {
        public Player player { get; set; }
        public Team team { get; set; }
        public Game game { get; set; }
        public string salary { get; set; }
        public string fantasyPoints { get; set; }
    }

    public class DfsEntry
    {
        public string dfsType { get; set; }
        public List<DfsRow> dfsRows { get; set; }
    }

    public class Entry
    {
        public string lastUpdatedOn { get; set; }
        public List<DfsEntry> dfsEntries { get; set; }
    }

    public class DailyDFS : IFeedRoot
    {
        public Entry dailydfs { get; set; }
    }
}
