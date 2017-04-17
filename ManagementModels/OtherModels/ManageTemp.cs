using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementModels.OtherModels
{
    public class ManageTemp
    {
        /// <summary>
        /// 处理权限信息的消息模板
        /// </summary>
        /// <param name="userName">请求人姓名</param>
        /// <param name="needTime">请求日期</param>
        /// <param name="pageName">请求页面名</param>
        /// <param name="result">处理结果</param>
        /// <param name="tel">反馈电话</param>
        /// <returns></returns>
        public static string PermissionsMsg(string userName, string needTime, string pageName, string result, string tel)
        { 
            return $@"<p>
	                {userName}你好：</p>
                <p>
	                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 你在{needTime}申请的有关于<span style='color:#E53333;'>{pageName}</span>的权限请求信息已被管理员受理，受理结果为<span style='color:#E53333;'>{result}</span>，如有疑问请致电相关管理人员：<span style='color:#009900;'>{tel}</span>。
                </p >
                <p style = 'text-align:center;' >
                     受理日期：{ DateTime.Now}<br/>
                           <span style = 'color:#999999;' >消息由系统自动发出 </span>
                   </p > ";
        }
    }
}
