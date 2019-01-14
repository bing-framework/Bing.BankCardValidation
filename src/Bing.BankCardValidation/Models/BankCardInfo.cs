using Bing.BankCardValidation.Core;
using Newtonsoft.Json;

namespace Bing.BankCardValidation.Models
{
    /// <summary>
    /// 银行卡信息
    /// </summary>
    public class BankCardInfo
    {
        /// <summary>
        /// 是否验证通过
        /// </summary>
        public bool Validated { get; set; }

        /// <summary>
        /// 银行代码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        public string Name => GetBankName();

        /// <summary>
        /// 银行Logo
        /// </summary>
        public string Logo { get; set; }

        /// <summary>
        /// 银行卡类型
        /// </summary>
        public string CardType { get; set; }

        /// <summary>
        /// 银行卡类型名称
        /// </summary>
        public string CardTypeName => GetCardTypeName();

        /// <summary>
        /// 银行卡卡号
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 获取 银行名称
        /// </summary>
        /// <returns></returns>
        private string GetBankName()
        {
            if (Const.BankInfo.ContainsKey(this.Code))
            {
                return Const.BankInfo[Code];
            }

            return string.Empty;
        }

        /// <summary>
        /// 获取 银行卡类型名称
        /// </summary>
        /// <returns></returns>
        private string GetCardTypeName()
        {
            if (Const.CardType.ContainsKey(this.CardType))
            {
                return Const.CardType[CardType];
            }

            return string.Empty;
        }

        /// <summary>
        /// 转换成Json输出
        /// </summary>
        /// <returns></returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
