using System;
using System.Collections.Generic;
using System.Text;

namespace Ying.Weather.Models
{
    /// <summary>
    /// 城市信息
    /// </summary>
    public class WeaCityInfo
    {
        /// <summary>
        /// 城市名称
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 城市Key
        /// </summary>
        public string Citykey { get; set; }
        /// <summary>
        /// 父级城市
        /// </summary>
        public string Parent { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public string UpdateTime { get; set; }
    }
}
