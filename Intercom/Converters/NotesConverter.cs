using Intercom.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Intercom.Converters
{
    public class NotesConverter : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                var obj = JObject.Load(reader);
                var result = GetList<Note>(obj, "notes");

                return result;
            }
            catch (Exception ex)
            {
                throw new JsonReaderException("", ex);
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var s = JsonConvert.SerializeObject(value,
                Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });

            writer.WriteRawValue(s);
        }

        public override bool CanRead => true;

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Company);
        }

        private List<T> GetList<T>(JObject obj, string key)
            where T : class
        {
            var value = obj.GetValue(key);
            var result = (JsonConvert.DeserializeObject(value.ToString(), typeof(T[])) as T[]).ToList();
            return result;
        }
    }
}
