using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementModels;
using Models;
using SubSonic;

namespace ManagementDAL
{
    public class TBasisUserDAL
    {
        /// <summary>
        /// 登录获取用户信息
        /// </summary>
        /// <param name="uAccount">账号</param>
        /// <param name="uPwd">密码</param>
        /// <returns></returns>
        public List<VUser> GetUsers(string uAccount, string uPwd)
        {
            try
            {
                SqlQuery query = new Select().From<VUser>()
                    .Where(VUser.Columns.Account).IsEqualTo(uAccount)
                    .And(VUser.Columns.UserPwd).IsEqualTo(uPwd);
                return query.ExecuteTypedList<VUser>();
            }
            catch (Exception)
            {
                throw;
            }
        }

 

    }
}
