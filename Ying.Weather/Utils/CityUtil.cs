using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Ying.Weather.Models;

namespace Ying.Weather.Utils
{
    public static class CityUtil
    {
        public static IEnumerable<CityInfo> GetCityInfos()
        {
            try
            {
                using StreamReader reader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"city.json"),Encoding.Default);
                StringBuilder builder = new StringBuilder();
                while(reader.EndOfStream == false)
                {
                    builder.AppendLine(reader.ReadLine());
                }
                var json = builder.ToString();
                var list = JsonConvert.DeserializeObject<List<CityInfo>>(json);
                return list;
            }
            catch
            {
                return default;
            }
        }
    }
}
