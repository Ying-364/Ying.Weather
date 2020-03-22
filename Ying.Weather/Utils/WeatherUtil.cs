using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ying.Weather.Models;

namespace Ying.Weather.Utils
{
    public static class WeatherUtil
    {
        private static System.Net.Http.HttpClient _httpClient;

        public static async Task<WeaResModel> GetWeathers(string cityCode)
        {
            try
            {
                _httpClient ??= new System.Net.Http.HttpClient();
                var respose = await _httpClient.GetAsync($"{App.WeatherUrl}{cityCode}");
                if (respose.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var message = await respose.Content.ReadAsStringAsync();
                    var model = JsonConvert.DeserializeObject<WeaResModel>(message);
                    return model;
                }
                return default;
            }
            catch
            {
                return default;
            }
        }
    }
}
