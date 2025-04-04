using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Framework.Utility
{
    public static class DictionaryConverter
    {
        public static Dictionary<string, string> ToDictionary<T>(T obj)
        {
            var dict = new Dictionary<string, string>();
            var properties = typeof(T).GetProperties();

            foreach (var prop in properties)
            {
                var jsonProperty = prop.GetCustomAttribute<JsonPropertyNameAttribute>();
                string key = jsonProperty != null ? jsonProperty.Name : prop.Name;

                var value = prop.GetValue(obj);
                if (value != null)
                {
                    if (IsPropertyACollection(prop)) // Handle lists and arrays
                    {
                        var enumerable = value as IEnumerable;
                        if (enumerable != null)
                        {
                            var index = 0;
                            foreach (var item in enumerable)
                            {
                                dict[key + $"[{index}]"] = item.ToString();
                                index++;
                            }
                        }
                    }
                    else
                    {
                        dict[key] = value.ToString();
                    }
                }
            }

            return dict;
        }

        private static bool IsPropertyACollection(this PropertyInfo property)
        {
            return (!typeof(String).Equals(property.PropertyType) &&
                typeof(IEnumerable).IsAssignableFrom(property.PropertyType));
        }
    }
}
