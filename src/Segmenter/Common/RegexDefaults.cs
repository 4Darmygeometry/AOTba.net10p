using System;

namespace JiebaNet.Segmenter.Common
{
    /// <summary>
    /// 正则表达式全局默认配置
    /// 提供统一的正则超时时间，防止ReDoS攻击
    /// </summary>
    internal static class RegexDefaults
    {
        /// <summary>
        /// 全局正则匹配超时时间（毫秒）
        /// 超过此时间的正则匹配将抛出RegexMatchTimeoutException
        /// </summary>
        public static readonly TimeSpan MatchTimeout = TimeSpan.FromMilliseconds(1000);
    }
}
