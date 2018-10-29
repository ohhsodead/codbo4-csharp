# BO4 Tracker Wrapper
An (under development) C# library for using the Call of Duty: Black Ops 4 API.

## Usage
You can use this API for free, forever and without any (rate) limits. 

Platform: PS4, Xbox One, Steam and Battle.net

### Validate User
__Note:__ You don't have to validate user before requesting their stats, although they must exist on the http://bo4tracker.com/ database.

```csharp
using CODBO4;

var validUser = await Task.Run(() => API.IsValidUser("Consisttt", PS4));

if (validUser) {
	// Do something...
}
else {
	// User's stats are NOT being tracked
}
```

### Profile Stats
Scope: Kills, Deaths, Ekia, Wins, Losses, Games Played and Time Played
```csharp
var statsData = await Task.Run(() => API.GetProfile("Consisttt", PS4));

// Do something with statsData...
console.log(response);
```

### Leaderboard Data

# Disclaimer
Call of Duty is a registered trademark of Activision. Activision owns everything Call of Duty related.
