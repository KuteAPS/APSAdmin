using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using ManagementCore;
using ManagementModels;
using ManagementModels.OtherModels;
using Models;

namespace ManagementBLL
{
    public class AttendanceBll
    {

        private WebReturnJsonModel ReturnJson { get; }
        public AttendanceBll()
        {
            ReturnJson = new WebReturnJsonModel();
        }


        public string GetAttendanceList(string userGroupName, int limit, int offset, string sort, string order)
        {
            try
            {
                string filter = "";

                switch (userGroupName)
                {
                    case "CAD衬衣":
                        filter = "CYCAD";
                        break;
                    case "CAD西服":
                        filter = "XFCAD";
                        break;
                    case "裁剪西服":
                        filter = "CJXF";
                        break;
                    case "裁剪衬衣":
                        filter = "CJCY";
                        break;
                    case "缝制西服":
                        filter = "FZXF";
                        break;
                    case "缝制衬衣":
                        filter = "FZCY";
                        break;
                }
                var attendanceList = new DataHelperBll().GetDataByPage<VResourcesAll>(offset / limit + 1, limit,
                    VResourcesAll.Schema.TableName, sort, order, VResourcesAll.Columns.ResourcesCode, filter);
                return JsonHelper.GetJsonO(attendanceList);

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
