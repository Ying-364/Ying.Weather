﻿using System;
using System.Collections.Generic;
using System.Text;

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
        /// 最低温度
        /// </summary>
        public string Low { get; set; }
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
        /// 注意
        /// </summary>
        public string Notice { get; set; }
    }
}