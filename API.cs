using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using CODBO4.Models;

namespace CODBO4
{
    public static class API
    {
        /// <summary>
        /// Get user data from http://bo4tracker.com, will return successful if stats are available
        /// </summary>
        /// <param name="username">Username of the user</param>
        /// <param name="platform">Platform the user is on</param>
        /// <returns>User data</returns>
        public static Validate ValidateUser(string username, Platform platform)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(Uri.EscapeUriString($"{Utilities.VALIDATE_URL}/{username}/{platform.GetDescription()}")).Result;

                if (response.StatusCode != HttpStatusCode.OK) throw new Exception($"Bad response {response.StatusCode}");

                var responseData = response.Content.ReadAsStringAsync().Result;

                if (Utilities.ValidResponse(responseData))
                    return JsonConvert.DeserializeObject<Validate>(responseData);

                dynamic data = JsonConvert.DeserializeObject(responseData);

                throw new Exception(data.data.message.ToString());
            }
        }

        /// <summary>
        /// Get user's profile stats for the specified mode
        /// </summary>
        /// <param name="username">Username of the user</param>
        /// <param name="platform">Platform the user is on</param>
        /// <param name="mode">Type of stats to fetch</param>
        /// <returns>Profile data</returns>
        public static object GetProfile(string username, Platform platform, Mode mode)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(Uri.EscapeUriString($"{Utilities.STATS_URL}/{username}/{platform.GetDescription()}?type={mode}")).Result;

                if (response.StatusCode != HttpStatusCode.OK) throw new Exception($"Bad response {response.StatusCode}");

                var responseData = response.Content.ReadAsStringAsync().Result;

                if (Utilities.ValidResponse(responseData))
                    if (mode == Mode.Multiplayer )
                        return JsonConvert.DeserializeObject<ProfileMultiplayer>(responseData);
                    else
                        return JsonConvert.DeserializeObject<ProfileBlackout>(responseData);

                dynamic data = JsonConvert.DeserializeObject(responseData);

                throw new Exception(data.data.message.ToString());
            }
        }

        /// <summary>
        /// Get user's profile stats for the specified mode
        /// </summary>
        /// <param name="username">Username of the user</param>
        /// <param name="userid">Id the user</param>
        /// <param name="platform">Platform the user is on</param>
        /// <param name="mode">Type of stats to fetch</param>
        /// <returns>Profile data</returns>
        public static object GetProfile(string username, long userid, Platform platform, Mode mode)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(Uri.EscapeUriString($"{Utilities.STATS_URL}/{username}/{platform.GetDescription()}?type={mode}?u={userid}")).Result;

                if (response.StatusCode != HttpStatusCode.OK) throw new Exception($"Bad response {response.StatusCode}");

                var responseData = response.Content.ReadAsStringAsync().Result;

                if (Utilities.ValidResponse(responseData))
                    if (mode == Mode.Multiplayer)
                        return JsonConvert.DeserializeObject<ProfileMultiplayer>(responseData);
                    else
                        return JsonConvert.DeserializeObject<ProfileBlackout>(responseData);

                dynamic data = JsonConvert.DeserializeObject(responseData);

                throw new Exception(data.data.message.ToString());
            }
        }

        /// <summary>
        /// Get user's last 20 matches for the specified mode
        /// </summary>
        /// <param name="rows">Number of rows to fetch</param>
        /// <returns>Recent matches data</returns>
        public static object GetUserMatches(string username, Platform platform, Mode mode)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync($"{Utilities.USER_MATCHES_URL}/{username}/{platform.GetDescription()}?type={mode}").Result;

                if (response.StatusCode != HttpStatusCode.OK) throw new Exception($"Bad response {response.StatusCode}");

                var responseData = response.Content.ReadAsStringAsync().Result;

                if (Utilities.ValidResponse(responseData))
                    return JsonConvert.DeserializeObject<RecentMatches>(responseData);

                if (Utilities.ValidResponse(responseData))
                    if (mode == Mode.Multiplayer)
                        return JsonConvert.DeserializeObject<MatchesMultiplayer>(responseData);
                    else
                        return JsonConvert.DeserializeObject<MatchesBlackout>(responseData);

                dynamic data = JsonConvert.DeserializeObject(responseData);

                throw new Exception(data.data.message.ToString());
            }
        }

        /// <summary>
        /// Get up to the last 100 recent matches played
        /// </summary>
        /// <param name="rows">Number of rows to fetch</param>
        /// <returns>Recent matches data</returns>
        public static RecentMatches GetRecentMatches(string rows)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync($"{Utilities.RECENT_MATCHES_URL}?rows={rows}").Result;

                if (response.StatusCode != HttpStatusCode.OK) throw new Exception($"Bad response {response.StatusCode}");

                var responseData = response.Content.ReadAsStringAsync().Result;

                if (Utilities.ValidResponse(responseData))
                    return JsonConvert.DeserializeObject<RecentMatches>(responseData);

                dynamic data = JsonConvert.DeserializeObject(responseData);

                throw new Exception(data.data.message.ToString());
            }
        }

        /// <summary>
        /// Get matches using match id
        /// </summary>
        /// <param name="matchId">Id of the match to fetch</param>
        /// <returns>Match data</returns>
        public static Match GetMatch(string matchId)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync($"{Utilities.MATCHES_URL}?id={matchId}").Result;

                if (response.StatusCode != HttpStatusCode.OK) throw new Exception($"Bad response {response.StatusCode}");

                var responseData = response.Content.ReadAsStringAsync().Result;

                if (Utilities.ValidResponse(responseData))
                    return JsonConvert.DeserializeObject<Match>(responseData);

                dynamic data = JsonConvert.DeserializeObject(responseData);

                throw new Exception(data.data.message.ToString());
            }
        }

        /// <summary>
        /// Get leaderboard data based on scope
        /// </summary>
        /// <param name="platform">Platform to get leaderboards for</param>
        /// <param name="scope">Type of scope to search for</param>
        /// <param name="rows">Number of rows to fetch (100 Max)</param>
        /// <returns>Leaderboard data</returns>
        public static Leaderboard GetLeaderboard(Platform platform, Scope scope, int rows)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync($"{Utilities.LEADERBOARDS_URL}/{platform.GetDescription()}/{scope.GetDescription()}?rows={rows}").Result;

                if (response.StatusCode != HttpStatusCode.OK) throw new Exception($"Bad response {response.StatusCode}");

                var responseData = response.Content.ReadAsStringAsync().Result;

                if (Utilities.ValidResponse(responseData))
                    return JsonConvert.DeserializeObject<Leaderboard>(responseData);

                dynamic data = JsonConvert.DeserializeObject(responseData);

                throw new Exception(data.data.message.ToString());
            }
        }

        /// <summary>
        /// Get username from their user id
        /// </summary>
        /// <param name="userid">User id's to fetch (500 Max)</param>
        /// <returns>Username data</returns>
        public static User GetUserById(long[] userid)
        {
            using (var client = new HttpClient())
            {
                string userids = "";

                foreach (var id in userid)
                    userids += $"?id={id}&";

                var response = client.GetAsync($"{Utilities.USERID_TO_USERNAME_URL}?{userids}").Result;

                if (response.StatusCode != HttpStatusCode.OK) throw new Exception($"Bad response {response.StatusCode}");

                var responseData = response.Content.ReadAsStringAsync().Result;

                if (Utilities.ValidResponse(responseData))
                    return JsonConvert.DeserializeObject<User>(responseData);

                dynamic data = JsonConvert.DeserializeObject(responseData);

                throw new Exception(data.data.message.ToString());
            }
        }
    }
}
