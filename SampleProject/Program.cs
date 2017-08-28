using MySportsFeeds;

using System;

namespace MySportsFeedsAPIExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MySportsFeedsApi.Username = "YOURUSERNAME";
            MySportsFeedsApi.Password = "YOURPASSWORD";

            Console.WriteLine(MySportsFeedsApi.FetchFeedAsync("mlb", "2016-regular", "division_team_standings").Result);
            Console.ReadLine();
        }
    }
}