using System;
using CODBO4.Models;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;

namespace CODBO4
{
	public static class BO4
	{
        /// <summary>
        /// Determine whether user exists in http://bo4tracker.com/ database
        /// </summary>
        /// <param name="username">Username of the user</param>
        /// <param name="platform">Platform the user is on</param>
        /// <returns>Profile data</returns>
        public static bool IsValidUser(string username, Platform platform)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync($"{Utilities.BO4_VALIDATE_URL}/{username}/{platform.GetDescription()}").Result;

                if (response.StatusCode != HttpStatusCode.OK) throw new Exception($"Bad response {response.StatusCode}");

                var responseData = response.Content.ReadAsStringAsync().Result;

                if (Utilities.ValidResponse(responseData))
                    return JsonConvert.DeserializeObject<Validate>(responseData).success;

                dynamic data = JsonConvert.DeserializeObject(responseData);

                throw new CODException(data.data.message.ToString());
            }
        }

        /// <summary>
        /// Get a user's Black Ops 4 profile and stats.
        /// </summary>
        /// <param name="username">Username of the user</param>
        /// <param name="platform">Platform the user is on</param>
        /// <returns>Profile data</returns>
        public static Profile GetProfile(string username, Platform platform)
		{
			using (var client = new HttpClient())
			{
                var response = client.GetAsync($"{Utilities.BO4_STATS_URL}/{username}/{platform.GetDescription()}").Result;

				if (response.StatusCode != HttpStatusCode.OK) throw new Exception($"Bad response {response.StatusCode}");

				var responseData = response.Content.ReadAsStringAsync().Result;

				if (Utilities.ValidResponse(responseData))
					return JsonConvert.DeserializeObject<Profile>(responseData);

				dynamic data = JsonConvert.DeserializeObject(responseData);

				throw new CODException(data.data.message.ToString());
			}
		}

        /// <summary>
        /// Get Black Ops 4 leaderboard data based on scope.
        /// </summary>
        /// <param name="platform">Platform to get leaderboards for</param>
        /// <param name="scope">Type of scope to search for</param>
        /// <param name="rows">Rows to fetch</param>
        /// <returns>Leaderboard data</returns>
        public static Leaderboards GetLeaderboards(Platform platform, Scope scope, int rows)
		{
			using (var client = new HttpClient())
			{
				var response = client.GetAsync($"{Utilities.BO4_LEADERBOARDS_URL}/{platform.GetDescription()}/{scope.GetDescription()}/{rows}/").Result;

				if (response.StatusCode != HttpStatusCode.OK) throw new Exception($"Bad response {response.StatusCode}");

				var responseData = response.Content.ReadAsStringAsync().Result;

				if (Utilities.ValidResponse(responseData))
					return JsonConvert.DeserializeObject<Leaderboards>(responseData);

				dynamic data = JsonConvert.DeserializeObject(responseData);

				throw new CODException(data.data.message.ToString());
			}
		}
	}
}