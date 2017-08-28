using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MySportsFeeds
{
    public static class MySportsFeedsApi
    {
        private const string _BASE = @"https://api.mysportsfeeds.com/v1.1/pull/";
        
        /// <summary>
        /// MySportsFeeds Username
        /// </summary>
        public static string Username { private get; set; }

        /// <summary>
        /// MySportsFeeds Password
        /// </summary>
        public static string Password { private get; set; }

        /// <summary>
        /// Fetch a MySportsFeed as a string
        /// </summary>
        /// <param name="League">The League Abbreviation (nhl)</param>
        /// <param name="SeasonName">The season to use (2016-20017-regular)</param>
        /// <param name="feed">The feed to retrieve (cumulative_player_stats)</param>
        /// <param name="Params">Parameters, in the order they will be sent to the server</param>
        /// <param name="Force">Force a response, even if it has not changed.  Default is false</param>
        /// <param name="Format">The format to retrieve the results (json, xml, csv, xsd).  Default is json</param>
        /// <returns></returns>
        public static async Task<string> FetchFeedAsync(string League, string SeasonName, string feed, Dictionary<string, string> Params = null, bool Force = false, string Format = "json")
        {
            if (!VerifyFormat(Format))
            {
                throw new ArgumentException(nameof(Format), $"Invalid format: {Format}.  Must be json, xml, or csv.");
            }

            try
            {
                return await PullFromServer($@"{League}/{SeasonName}/{feed}", Format, BuildParams(Params, Force));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Fetch a MySportsFeed and return as type T
        /// </summary>
        /// <typeparam name="T">The type to return the results as</typeparam>
        /// <param name="League">The League Abbreviation (nhl)</param>
        /// <param name="SeasonName">The season to use (2016-20017-regular)</param>
        /// <param name="feed">The feed to retrieve (cumulative_player_stats)</param>
        /// <param name="Params">Parameters, in the order they will be sent to the server</param>
        /// <param name="Force">Force a response, even if it has not changed.  Default is false</param>
        /// <param name="Format">The format to retrieve the results (json, xml, csv, xsd).  Default is json</param>
        /// <returns></returns>
        public static async Task<T> FetchFeedAsync<T>(string League, string SeasonName, string feed, Dictionary<string, string> Params = null, bool Force = false, string Format = "json")
        {
            if (!VerifyFormat(Format, false))
            {
                throw new ArgumentException(nameof(Format), $"Invalid format: {Format}.  Must be json or xml");
            }
            try
            {
                return ConvertTo<T>(await PullFromServer($@"{League}/{SeasonName}/{feed}", Format, BuildParams(Params, Force)), Format);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private static T ConvertTo<T>(string input, string inputFormat)
        {
            if (inputFormat.Equals("json", StringComparison.OrdinalIgnoreCase))
            {
                return JsonConvert.DeserializeObject<T>(input);
            }
            if (inputFormat.Equals("xml", StringComparison.OrdinalIgnoreCase))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                StringReader reader = new StringReader(input);
                return (T)serializer.Deserialize(reader);
            }

            throw new ArgumentException(nameof(inputFormat), $"Invalid format: {inputFormat}.  Must be json or xml");
        }
        private static bool VerifyFormat(string format, bool allowCsv = true)
        {
            if (format.Equals("json", StringComparison.OrdinalIgnoreCase) ||
                format.Equals("xml", StringComparison.OrdinalIgnoreCase) ||
                (format.Equals("csv", StringComparison.OrdinalIgnoreCase) && allowCsv))
            {
                return true;
            }

            return false;
        }

        private static string BuildParams(Dictionary<string, string> optionalParams, bool force = false)
        {
            if (optionalParams == null)
                return string.Empty;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < optionalParams.Count; i++)
            {
                if (i != 0)
                {
                    sb.Append('&');
                }

                sb.Append($"{optionalParams.Keys.ElementAt(i)}={optionalParams.Values.ElementAt(i)}");
            }

            if (!(optionalParams.Keys.Contains("force", StringComparer.OrdinalIgnoreCase)))
            {
                sb.Append($"&force={force}");
            }

            return sb.ToString().Replace(' ', '-');
        }

        private static string GetCredentials()
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Username}:{Password}"));
        }
        
        private static async Task<string> PullFromServer(string feed, string format, string optionalParams)
        {
            if (string.IsNullOrEmpty(Username))
            {
                throw new ArgumentNullException("Username must be set");
            }

            if (string.IsNullOrEmpty(Password))
            {
                throw new ArgumentNullException("Password must be set");
            }

            WebResponse response;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri($"{_BASE}{feed}.{format}?{optionalParams}"));
            request.Headers.Add("Authorization", $"Basic {GetCredentials()}");

            using (response = await request.GetResponseAsync())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    return await reader.ReadToEndAsync();
                }
            }
        }
    }
}