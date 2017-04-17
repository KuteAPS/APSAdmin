using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementCore;
using ManagementModels.OtherModels;
using Models;

namespace ManagementBLL
{
    public class ManageBoxBll
    {

        static WebReturnJsonModel jsonModel = new WebReturnJsonModel();


        /// <summary>
        /// 根据用户ID获取该用户的未读消息数量
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns></returns>
        public static string GetManageCount(string userId)
        {
            try
            {
                var manageList =
                    new DataHelperBll().GetDataByCoumObject<VManageListNoRead>(VManageListNoRead.Schema.TableName,
                        VManageListNoRead.Columns.RecipientUserID, userId);


                return manageList.Count.ToString();
            }
            catch (Exception ex)
            {
                return "0";
            }
        }
    }
}
