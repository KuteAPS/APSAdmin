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
    public class TaskListController : ManagementController
    {

        #region 个人任务列表页

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 获取当前用户的任务列表
        /// </summary>
        /// <returns></returns>
        public string GetTaskListByUserId()
        {
            return new TaskListBll().GetTaskListByUserId(ThisUser.Id.ToString());
        }

        /// <summary>
        /// 拖动排序
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public string UpdateMyTask(string[] taskList, string taskType)
        {
            return new TaskListBll().UpdateMyTask(taskList, taskType, ThisUser.Id.ToString());
        }

        /// <summary>
        /// 添加任务列表
        /// </summary>
        /// <param name="taskContext">任务清单</param>
        /// <returns></returns>
        public string AddTask(string taskContext)
        {
            return new TaskListBll().AddTask(taskContext, ThisUser.Id.ToString());
        }

        /// <summary>
        /// 根据ID删除任务信息
        /// </summary>
        /// <param name="id">任务ID</param>
        /// <returns></returns>
        public string DekTask(string id)
        {
            return JsonHelper.GetJsonO(new DataHelperBll().DelData<TBasisTaskList>(TBasisTaskList.IdColumn, id));
        }

        #endregion

    }
}