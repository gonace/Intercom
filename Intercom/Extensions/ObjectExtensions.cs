using Intercom.Attributes;
using System;
using System.Linq;
using System.Text;

namespace Intercom.Extensions
{
    public static class ObjectExtensions
    {
        public static string ToQueryString(this object obj)
        {
            var queryStringBuilder = new StringBuilder("");
            var type = obj.GetType();

            var props = type
                .GetProperties()
                .Where(p => Attribute.IsDefined(p, typeof(QueryStringPropertyAttribute)))
                .ToList();

            foreach (var prop in props)
            {
                var name = prop.Name;
                var value = prop.GetValue(obj, null);
                var attribute = (QueryStringPropertyAttribute)Attribute.GetCustomAttribute(prop, typeof(QueryStringPropertyAttribute));

                if (value != null)
                {
                    if (!queryStringBuilder.ToString().Contains("?"))
                        queryStringBuilder.Append("?");

                    name = attribute?.PropertyName ?? name.ToLower();

                    // Check's if this is the last property, if so, don't add an '&'
                    queryStringBuilder.Append(props.IndexOf(prop) != (props.Count - 1) ?
                        $"{Uri.EscapeDataString(name)}={Uri.EscapeDataString(value.ToString())}&" :
                        $"{Uri.EscapeDataString(name)}={Uri.EscapeDataString(value.ToString())}");
                }
            }

            return queryStringBuilder.ToString();
        }
    }
}
