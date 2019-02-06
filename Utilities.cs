using System;
using System.ComponentModel;
using System.Reflection;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace CODBO4
{
    internal static class Utilities
    {
        internal const string ValidateUrl = "https://cod-api.theapinetwork.com/api/validate/bo4/";
        internal const string StatsUrl = "https://cod-api.theapinetwork.com/api/stats/bo4/";
        internal const string LeaderBoardsUrl = "https://cod-api.theapinetwork.com/api/leaderboard/bo4/";
        internal const string UserMatchesUrl = "https://cod-api.theapinetwork.com/api/matches/bo4/";
        internal const string RecentMatchesUrl = "https://cod-api.theapinetwork.com/api/matches/recent";
        internal const string MatchesUrl = "https://cod-api.theapinetwork.com/api/matches/get";
        internal const string UseridToUsernameUrl = "https://cod-api.theapinetwork.com/api/users/ids";

        internal static bool IsValidResponse(string data)
        {
            const string validator = @"{
              'type': 'object',
              'required': true,
              'properties': {
                'status': {
                    'type': 'string',
                    'required': true
                },
                'data': {
                  'type': 'object',
                  'required': true,
                  'properties': {
                    'type': {
                        'type': 'string',
                        'required': true
                    },
                    'message': {
                        'type': 'string',
                        'required': true
                    }
                  }
                }
              }
            }";

            //Hack: Just pull in the new library at some point!
#pragma warning disable 0618
            var schema = JsonSchema.Parse(validator);
            var obj = JObject.Parse(data);

            var ret = obj.IsValid(schema);

            return !obj.IsValid(schema);
#pragma warning restore 0618
        }

        internal static string GetDescription(this Enum value)
        {
            Type type = value.GetType();
            var name = Enum.GetName(type, value);
            if (name == null) return null;
            FieldInfo field = type.GetField(name);
            return field == null
                ? null
                : !(Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attr)
                    ? null
                    : attr.Description;
        }
    }
}
