using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementModels.OtherModels
{
    public class WebReturnJsonModel
    {
        /// <summary>
        /// 返回状态error:异常，success:正常，warning:警告，info:信息
        /// </summary>
        public string Success { get; set; }

        /// <summary>
        /// 状态信息
        /// </summary>
        public string JsonMsg { get; set; }

    }
}
