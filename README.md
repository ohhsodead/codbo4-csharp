# codbo4-csharp
An (under development) C# library for accessing the Call of Duty: Black Ops 4 API.
* Get profile information - prestige, level, xp, and more...
* Get recent matches and stats - map, time, win/loss, ekia, kills, deaths, ekia ratio, and more...
* Get leaderboard information - kills, deaths, time played, and more...
* Not licensed by or affiliated with Activision or Call of Duty

## Usage
You can use this API for free, forever and without any (rate) limits. 

Platforms: PS4, Xbox One, Steam and Battle.net
Scopes: Kills, Deaths, Ekia, Wins, Losses, Games Played, Time Played

### Validate User
__Note:__ You don't need to validate user before requesting their profile stats, although they must exist on the http://bo4tracker.com/ database.

```csharp
using CODBO4;

var validUser = await Task.Run(() => API.IsValidUser("Consisttt", Platform.PS4));

if (validUser.success) {
	// Do something...
}
else {
	// User's stats aren't being tracked
}
```

### Profile Stats
__Tip:__ For a much faster response, add the *Id* of the user (optional). You can get this from validating the user.

```csharp
var profileData = await Task.Run(() => API.GetProfile("Consisttt", Platform.PS4, 323487));

// Do something...
Console.WriteLine(profileData.user.username);
Console.WriteLine(profileData.user.stats.prestige);
Console.WriteLine(profileData.user.stats.level);
```

### Leaderboard Data
Scopes: Kills, Deaths, Ekia, Wins, Losses, Games Played and Time Played
**Currently only allows for requesting up to the first 100 rows of players per platform.**

```csharp
var leaderboardData = await Task.Run(() => API.GetLeaderboard(Platform.PS4, Scope.Kills, 50));

// Do something...
foreach (var user in leaderboardData.entries) {
	Console.WriteLine(user.username);
	Console.WriteLine(user.kills);
}
```

# License
This project is licensed under the GNU General Public License