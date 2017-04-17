using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ManagementModels.OtherModels;

namespace ManagementCore
{
    public class DateHelper
    {
        /// <summary>
        /// 唯一订单号生成
        /// </summary>
        /// <returns></returns>
        public static string GenerateOrderNumber()
        {
            string strDateTimeNumber = DateTime.Now.ToString("yyyyMMddHHmmssms");
            string strRandomResult = NextRandom(100000, 1).ToString();
            return strDateTimeNumber + strRandomResult;
        }

        //唯一ID生成
        public static string NextRandom(int numSeeds, int length)
        {
            Guid guid = new Guid();
            guid = Guid.NewGuid();
            return guid.ToString().Substring(0, guid.ToString().IndexOf('-'));
        }

        /// <summary>
        /// 判断字符串是否为空
        /// </summary>
        /// <param name="deObjects">key为提示文本，values 要判断的字符</param>
        /// <returns></returns>
        public static WebReturnJsonModel NullOrWhiteSpace(Dictionary<string, string> deObjects)
        {
            WebReturnJsonModel returnJson = new WebReturnJsonModel();

            foreach (var deObject in deObjects)
            {
                if (string.IsNullOrWhiteSpace(deObject.Value))
                {
                    returnJson.Success = "error";
                    returnJson.JsonMsg = $"{deObject.Key}不能为空";
                    return returnJson;
                }
            }

            returnJson.Success = "success";
            return returnJson;
        }

        /// <summary>
        /// 判断字符串是否符合规则
        /// </summary>
        /// <param name="val">匹配值</param>
        /// <param name="type">匹配类型 电话：tel,邮箱：mail，ip地址：ip，字母：Aa，大写字母：A，小写字母：a</param>
        /// <returns></returns>
        public static WebReturnJsonModel IsFormat(string val, string type)
        {
            WebReturnJsonModel returnJson = new WebReturnJsonModel();
            try
            {
                string pattern = string.Empty;
                bool f = false;
                switch (type.ToLower())
                {
                    case "tel":
                        pattern = @"^(13|15|18|14|17)[0-9]{9}$";
                        break;
                    case "mail":
                        pattern = @"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
                        break;
                    case "ip":
                        pattern = @"^(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])$";
                        break;
                    case "Aa":
                        pattern = @"^[A-Za-z]+$";
                        break;
                    case "A":
                        pattern = @"^[A-Z]+$";
                        break;
                    case "a":
                        pattern = @"^[a-z]+$";
                        break;
                    default:
                        throw new FormatException("Type参数无效");
                }

                if (Regex.IsMatch(val, pattern))
                {
                    returnJson.Success = "success";
                    returnJson.JsonMsg = "完全匹配，无异常";
                }
                else
                {
                    returnJson.Success = "error";
                    returnJson.JsonMsg = $"{val}不符合规范";
                }

            }
            catch (Exception ex)
            {
                returnJson.Success = "error";
                returnJson.JsonMsg = ex.Message;
            }

            return returnJson;
        }
    }
}
