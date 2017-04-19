using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManagementBLL;
using ManagementCore;
using Models;

namespace ManagementAdmin.Controllers
{
    public class AttendanceController : ManagementController
    {
        #region 出勤列表
        public ActionResult ResourceList()
        {
            return View();
        }

        //获取出勤列表 
        public string GetResourceList(int limit, int offset, string sort, string order)
        {
            return new AttendanceBll().GetAttendanceList(ThisUser.GroupName, limit, offset, sort, order);
        }

        //删除数据
        public string DelResourceList(string id)
        {
            try
            {
                var obj = (List<VResourcesAll>)JsonHelper.ReturnObject(id, typeof(List<VResourcesAll>));
                return new DataHelperBll().DelData<TBasisResource>(TBasisResource.ResourcesCodeColumn, obj.ConvertAll(x => x.ResourcesCode));
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //获取修改人员基本信息
        public ActionResult UpdateResource(string id)
        {
            ViewBag.Resource = new DataHelperBll().GetDataByCoumObject<TBasisResource>(TBasisResource.Schema.TableName, TBasisResource.ResourcesCodeColumn.ColumnName, id).FirstOrDefault() ?? new TBasisResource();
            ViewBag.Attendance = new DataHelperBll().GetDataByCoumObject<TAttendance>(TAttendance.Schema.TableName, TAttendance.ResourceColumn.ColumnName, id).FirstOrDefault() ?? new TAttendance();
            return View();
        }


        //获取时间范围
        public string FlagStatus()
        {
            return JsonHelper.GetJsonO(new DataHelperBll().GetDataByTable<TAttendanceMode>(TAttendanceMode.Schema.TableName));
        }

        //获取工作时间


        #endregion
    }
}