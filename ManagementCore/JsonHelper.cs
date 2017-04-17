using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ManagementCore
{
    /// <summary>
    /// 返回结果类。
    /// </summary>
    public class JsonHelper
    {
        private string m_retCode = "1";

        /// <summary>
        /// 返回编码。
        /// 0：成功。
        /// 1：失败。
        /// </summary>
        public string RetCode
        {
            get { return m_retCode; }
            set { m_retCode = value; }
        }

        private string m_retMessage;

        /// <summary>
        /// 返回 Message 。
        /// </summary>
        public string RetMessage
        {
            get
            {
                return m_retMessage;
            }
            set { m_retMessage = value; }
        }

        /// <summary>
        /// 返回 结果 对象 。
        /// </summary>
        public Object RetObj
        {
            get;
            set;
        }

        /// <summary>
        /// 返回 结果 List 。
        /// 注意使用时，需要实例化。
        /// </summary>
        public IList<Object> RetList
        {
            get;
            set;
        }

        /// <summary>
        /// 返回 键/值 对。
        /// 注意使用时，需要实例化。
        /// </summary>
        public Dictionary<string, object> RetDic
        {
            get;
            set;
        }

        /// <summary>
        /// 返回 Json 数据。
        /// </summary>
        /// <returns>返回 Json 数据。</returns>
        public string GetJson()
        {
            // var jSetting = new JsonSerializerSettings();

            // 默认 包括 Null 的数据。
            // jSetting.DefaultValueHandling = DefaultValueHandling.Include;
            //string s = JsonConvert.SerializeObject(br, Newtonsoft.Json.Formatting.Indented, jSetting);
            // 格式化：缩进排印的
            string s = JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
            return s;
        }

        public static string GetJsonO(Object o)
        {
            string s = JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);
            return s;
        }
        /// <summary>
        /// 返回 Json 数据。
        /// </summary>
        /// <param name="retMessage">成功消息。</param>
        /// <returns>返回 Json 数据。</returns>
        public string GetOKJson(string msg)
        {
            // var jSetting = new JsonSerializerSettings();
            this.RetMessage = msg;
            string s = JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
            return s;
        }

        /// <summary>
        ///  返回一个对象
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static object ReturnObject(string json, Type T)
        {
            return JsonConvert.DeserializeObject(json, T);
        }



    }
}
