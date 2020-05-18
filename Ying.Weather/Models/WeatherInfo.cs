using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace Ying.Weather.Models
{
    /// <summary>
    /// 天气信息
    /// </summary>
    public class WeatherInfo
    {
        /// <summary>
        /// 日期
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// 最高温度
        /// </summary>
        public string High { get; set; }
        /// <summary>
        /// 最高温度
        /// </summary>
        [JsonIgnore]
        public double HighNum => Convert.ToDouble(High?.Split(' ').Last().Replace("℃", string.Empty));
        /// <summary>
        /// 最低温度
        /// </summary>
        public string Low { get; set; }
        /// <summary>
        /// 最低温度
        /// </summary>
        [JsonIgnore]
        public double LowNum => Convert.ToDouble(Low?.Split(' ').Last().Replace("℃", string.Empty));
        /// <summary>
        /// 年月日
        /// </summary>
        public string Ymd { get; set; }
        /// <summary>
        /// 周几
        /// </summary>
        public string Week { get; set; }
        /// <summary>
        /// 日出
        /// </summary>
        public string Sunrise { get; set; }
        /// <summary>
        /// 日落
        /// </summary>
        public string Sunset { get; set; }
        /// <summary>
        /// 空气指数
        /// </summary>
        public string Aqi { get; set; }
        /// <summary>
        /// 风向
        /// </summary>
        public string Fx { get; set; }
        /// <summary>
        /// 风级
        /// </summary>
        public string Fl { get; set; }
        /// <summary>
        /// 天气
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 天气
        /// </summary>
        [JsonIgnore]
        public PackIconKind PackIconKind => Type switch
        {
            string s when s.Contains("晴") => PackIconKind.WeatherSunny,
            string s when s.Contains("阴") => PackIconKind.WeatherCloudy,
            string s when s.Contains("云") => PackIconKind.WeatherPartlyCloudy,
            string s when s.Contains("雨") => PackIconKind.WeatherRainy,
            string s when s.Contains("雪") => PackIconKind.WeatherSnowy,
            string s when s.Contains("风") => PackIconKind.WeatherWindy,
            string s when s.Contains("雷") => PackIconKind.WeatherStorm,
            _ => PackIconKind.CrosshairsUnknown,
        };
        /// <summary>
        /// 注意
        /// </summary>
        public string Notice { get; set; }

    }
}
