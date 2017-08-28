using MySportsFeedsApi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MySportsFeedsApi.MySportsFeedsApi.Username = "aidenkael";
            MySportsFeedsApi.MySportsFeedsApi.Password = "zmp48v";

            Console.WriteLine(MySportsFeedsApi.MySportsFeedsApi.FetchFeedAsync("mlb", "2016-regular", "division_team_standings", null).Result);
            Console.ReadLine();
        }
    }
}
