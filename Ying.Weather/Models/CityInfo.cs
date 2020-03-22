using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace Ying.Weather.Models
{
    /// <summary>
    /// 城市信息
    /// </summary>
    public class CityInfo
    {
        public int? Id { get; set; }
        public int? Pid { get; set; }
        [JsonIgnore]
        public CityInfo Parent { get; set; }
        [JsonIgnore]
        public List<CityInfo> Childs { get; set; }
        /// <summary>
        /// 城市名称
        /// </summary>
        public string City_name { get; set; }
        /// <summary>
        /// 城市编码
        /// </summary>
        public string City_code { get; set; }
        /// <summary>
        /// 区域编码
        /// </summary>
        public string Area_code { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? Ctime { get; set; }
    }
}

