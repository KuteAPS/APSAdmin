using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementCore;
using ManagementDAL;
using ManagementModels.OtherModels;
using Models;
using SubSonic;

namespace ManagementBLL
{
    public class WebPageBll
    {

        WebReturnJsonModel jsonModel = new WebReturnJsonModel();

        /// <summary>
        /// 获取全部页面信息
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public List<TBasisWebPage> GetAllWebPages(out string json)
        {
            try
            {
                var oList = new DataHelperBll().GetDataByTable<TBasisWebPage>(TBasisWebPage.Schema.TableName);

                jsonModel.Success = "success";
                jsonModel.JsonMsg = JsonHelper.GetJsonO(oList);
                json = JsonHelper.GetJsonO(jsonModel);
                return oList.Count > 0 ? new List<TBasisWebPage>() : oList;
            }
            catch (Exception ex)
            {
                jsonModel.Success = "error";
                jsonModel.JsonMsg = ex.Message;
                throw;
            }
        }

        /// <summary>
        /// 检测用户是否已对页面申请过权限，或用户已拥有此页面权限
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="pageId"></param>
        /// <returns></returns>
        public WebReturnJsonModel CheckNeedPermissions(string userId, string pageId)
        {
            try
            {

                jsonModel.Success = "success";
                jsonModel.JsonMsg = "可以申请此页面权限";

                var user = new DataHelperBll().GetDataByCoumObject<TBasisUser>(TBasisUser.Schema.TableName, TBasisUser.IdColumn.ColumnName, userId).FirstOrDefault();
                if (user != null && !string.IsNullOrWhiteSpace(user.HavingPage))
                {
                    var havingPage = user.HavingPage.Split(',');
                    foreach (var s in havingPage)
                    {
                        if (s == pageId)
                        {
                            jsonModel.Success = "warning";
                            jsonModel.JsonMsg = "已有该页面权限，无需再次申请,请关闭选项卡后重新打开";
                        }
                    }
                }

                var needPage = new DataHelperBll().GetDataByCoumsObj<TBasisNeedPermission>(TBasisNeedPermission.Schema.TableName, new Dictionary<string, TableSchema.TableColumn>() { { TBasisNeedPermission.UserIDColumn.ColumnName, TBasisNeedPermission.UserIDColumn }, { TBasisNeedPermission.PageIDColumn.ColumnName, TBasisNeedPermission.PageIDColumn } }, new Dictionary<string, object>() { { TBasisNeedPermission.UserIDColumn.ColumnName, userId }, { TBasisNeedPermission.PageIDColumn.ColumnName, pageId } }, "and");
                if (needPage.Count > 0)
                {
                    jsonModel.Success = "warning";
                    jsonModel.JsonMsg = "已申请过页面权限，无需再次申请，等待管理审核即可";
                }

            }
            catch (Exception ex)
            {
                jsonModel.Success = "error";
                jsonModel.JsonMsg = ex.Message;
            }

            return jsonModel;
        }
    }
}
