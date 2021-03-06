using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeAppMergePayModel Data Structure.
    /// </summary>
    public class AlipayTradeAppMergePayModel : AlipayObject
    {
        /// <summary>
        /// 如果预创建成功，支付宝返回该预下单号，后续商户使用该预下单号请求支付宝支付接口
        /// </summary>
        [JsonProperty("pre_order_no")]
        public string PreOrderNo { get; set; }
    }
}
