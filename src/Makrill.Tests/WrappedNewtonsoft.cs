﻿using Newtonsoft.Json;

namespace Makrill.Tests
{
    public class WrappedNewtonsoft
    {
        public T Deserialize<T>(string val)
        {
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new ToStandardConverter());
            return JsonConvert.DeserializeObject<T>(val, settings);
        }

        public string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}