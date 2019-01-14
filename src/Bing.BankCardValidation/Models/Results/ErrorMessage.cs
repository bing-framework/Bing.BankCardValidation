﻿using Newtonsoft.Json;

namespace Bing.BankCardValidation.Models.Results
{
    /// <summary>
    /// 错误消息
    /// </summary>
    public class ErrorMessage
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("errorCodes")]
        public string ErrorCodes { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
