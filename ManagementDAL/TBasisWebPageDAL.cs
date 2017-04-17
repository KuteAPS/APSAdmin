using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using SubSonic;

namespace ManagementDAL
{
    public class TBasisWebPageDAL
    {
        /// <summary>
        /// 根据页面URL获取信息
        /// </summary>
        /// <param name="url">页面URL</param>
        /// <returns></returns>
        public TBasisWebPage GetTBasisWebPage(string url)
        {
            try
            {
                return new Select().From<TBasisWebPage>()
                    .Where(TBasisWebPage.PageUrlColumn).IsEqualTo(url).ExecuteTypedList<TBasisWebPage>().FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

       
    }
}
