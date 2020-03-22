using System;
using System.Collections.Generic;
using System.Text;

namespace Ying.Weather.Models
{
    /// <summary>
    /// 天气数据
    /// </summary>
    public class WeatherDatas
    {
        /// <summary>
        /// 湿度
        /// </summary>
        public string Shidu { get; set; }
        public double? Pm25 { get; set; }
        public double? Pm10 { get; set; }
        /// <summary>
        /// 质量
        /// </summary>
        public string Quality { get; set; }
        /// <summary>
        /// 温度
        /// </summary>
        public string Wendu { get; set; }
        public string Ganmao { get; set; }
        /// <summary>
        /// 预报
        /// </summary>
        public List<WeatherInfo> Forecast { get; set; }
        /// <summary>
        /// 昨天
        /// </summary>
        public WeatherInfo Yesterday { get; set; }
    }
}
