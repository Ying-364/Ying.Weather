using System;
using System.Collections.Generic;
using System.Text;

namespace Ying.Weather.Models
{
    public class WeaResModel
    {
        /// <summary>
        /// 消息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime? Time { get; set; }
        /// <summary>
        /// 城市信息
        /// </summary>
        public WeaCityInfo CityInfo { get; set; }
        /// <summary>
        /// 天气信息
        /// </summary>
        public WeatherDatas Data { get; set; }
    }
}
