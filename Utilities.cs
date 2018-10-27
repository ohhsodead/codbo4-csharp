using System;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Reflection;

namespace CODBO4
{
	internal static class Utilities
	{
        internal const string BO4_VALIDATE_URL          = "https://bo4tracker.com/api/validate/bo4/";
        internal const string BO4_STATS_URL             = "https://bo4tracker.com/api/stats/bo4/";        
        internal const string BO4_LEADERBOARDS_URL      = "https://bo4tracker.com/api/leaderboard/bo4/";


        internal static bool ValidResponse(string data)
		{
			string validator = @"{
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
			string name = Enum.GetName(type, value);
			if (name != null)
			{
				FieldInfo field = type.GetField(name);
				if (field != null)
				{
                    if (Attribute.GetCustomAttribute(field,
                             typeof(DescriptionAttribute)) is DescriptionAttribute attr)
                    {
                        return attr.Description;
                    }
                }
			}
			return null;
		}

	}
}