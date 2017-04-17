using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ManagementCore
{
    public class CookieHelper
    {
        public static bool SaveCookie(string cookieName, string userJson, HttpResponseBase response)
        {
            try
            {
                //Cookie写入前加密
                string encrypkey = ConfigurationSettings.AppSettings["Encrypkey"];
                EncryptHelper encrypt = new EncryptHelper(encrypkey.Substring(0, 24));

                //写入Cookie
                HttpCookie cookie = new HttpCookie(cookieName);
                cookie.Value = encrypt.Encrypt(userJson);
                DateTime dt = DateTime.Now;
                TimeSpan ts = new TimeSpan(0, 10, 0, 0, 0);//过期时间为1分钟
                cookie.Expires = dt.Add(ts);//设置过期时间
                response.AppendCookie(cookie);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string ReadCookie(string cookieName, HttpRequestBase request)
        {
            try
            {
                //Cookie读取时解密
                string encrypkey = ConfigurationSettings.AppSettings["Encrypkey"];
                EncryptHelper encrypt = new EncryptHelper(encrypkey.Substring(0, 24));

                //写入Cookie
                return request.Cookies[cookieName] != null ? encrypt.Decrypt(request.Cookies[cookieName].Value) : "";
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        public static void DeleteCookie(string cookieName, HttpRequestBase request, HttpResponseBase response)
        {
            try
            {
                HttpCookie cok = request.Cookies[cookieName];
                if (cok != null)
                {
                    TimeSpan ts = new TimeSpan(-1, 0, 0, 0);
                    cok.Expires = DateTime.Now.Add(ts);//删除整个Cookie，只要把过期时间设置为现在
                    response.AppendCookie(cok);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}