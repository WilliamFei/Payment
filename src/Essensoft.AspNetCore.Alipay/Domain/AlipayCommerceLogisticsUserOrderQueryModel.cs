using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsUserOrderQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceLogisticsUserOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 扩展参数 , json 格式。  可选还是必选取决于biz_type参数 .   对于 CABINET_FACE_TAKE 自提柜刷脸开柜业务需要传字段 cabinet_no ( 柜子编号 ) .
        /// </summary>
        [JsonProperty("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 物流体系里合作商户的编码
        /// </summary>
        [JsonProperty("merchant_code")]
        public string MerchantCode { get; set; }

        /// <summary>
        /// 当前支持支付宝登录号
        /// </summary>
        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 目前只支持登录号,后续可扩展
        /// </summary>
        [JsonProperty("target_id_type")]
        public string TargetIdType { get; set; }
    }
}
