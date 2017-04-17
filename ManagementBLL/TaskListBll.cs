using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementCore;
using ManagementModels.OtherModels;
using Models;
using SubSonic;

namespace ManagementBLL
{
    public class TaskListBll
    {

        private WebReturnJsonModel ReturnJson { get; }
        /// <summary>
        ///     默认构造函数
        /// </summary>
        public TaskListBll()
        {
            ReturnJson = new WebReturnJsonModel();
        }


        /// <summary>
        /// 根据用户ID获取任务列表
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public string GetTaskListByUserId(string userId)
        {
            try
            {
                ReturnJson.Success = "success";
                ReturnJson.JsonMsg = JsonHelper.GetJsonO(new DataHelperBll().GetDataByCoumObject<TBasisTaskList>(TBasisTaskList.Schema.TableName,
                    TBasisTaskList.AssignUserColumn.ColumnName, userId));
            }
            catch (Exception ex)
            {
                ReturnJson.Success = "error";
                ReturnJson.JsonMsg = ex.Message;
            }

            return JsonHelper.GetJsonO(ReturnJson);
        }


        /// <summary>
        /// 拖动排序
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public string UpdateMyTask(string[] taskList, string taskType, string uid)
        {
            try
            {
                if (taskList == null)
                    return "";


                var taskLists = new DataHelperBll().GetDataByCoumsObj<TBasisTaskList>(TBasisTaskList.Schema.TableName,
                    new Dictionary<string, TableSchema.TableColumn>()
                    {
                        {TBasisTaskList.TaskStateColumn.ColumnName, TBasisTaskList.TaskStateColumn},
                        {TBasisTaskList.AssignUserColumn.ColumnName, TBasisTaskList.AssignUserColumn}
                    },
                    new Dictionary<string, object>()
                    {
                        {TBasisTaskList.TaskStateColumn.ColumnName, taskType},
                        {TBasisTaskList.AssignUserColumn.ColumnName, uid}
                    }, "and");

                var taskListnew = taskList.ToList();

                if (taskList.Length < taskLists.Count || taskList.Length == taskLists.Count)
                    return "";

                foreach (var basisTaskList in taskLists)
                {
                    taskListnew.Remove(basisTaskList.Id.ToString());
                }

                var values = new Dictionary<string, object>() { { "TaskState", taskType } };

                var task =
                    new DataHelperBll().GetDataByCoumObject<TBasisTaskList>(TBasisTaskList.Schema.TableName,
                        TBasisTaskList.IdColumn.ColumnName, taskListnew.First()).First();

                values.Add("UpdateDataUsers", string.IsNullOrWhiteSpace(task.UpdateDataUsers) ? uid : $"{task.UpdateDataUsers},{uid}");

                if (taskType == "progress" && task.StartTime == null)
                    values.Add("StartTime", DateTime.Now);

                if (taskType == "over")
                {
                    if (task.TaskState == "list")
                    {
                        throw new Exception("还未开始的任务，不能直接完成");
                    }
                    values.Add("EndTime", DateTime.Now);
                }


                return new DataHelperBll().AddOrUpdateDataById(typeof(TBasisTaskList), taskListnew.First(), values);
            }
            catch (Exception ex)
            {
                ReturnJson.Success = "error";
                ReturnJson.JsonMsg = ex.Message;
            }

            return JsonHelper.GetJsonO(ReturnJson);
        }


        /// <summary>
        /// 增加任务清单
        /// </summary>
        /// <param name="taskContext"></param>
        /// <param name="uid">用户ID，初始作为创建人，指派人</param>
        /// <returns></returns>
        public string AddTask(string taskContext, string uid)
        {
            try
            {

                #region 重要字符不能为空

                Dictionary<string, string> dictionarys = new Dictionary<string, string>
            {
                {"任务清单", taskContext}
            };
                var iserr = DateHelper.NullOrWhiteSpace(dictionarys);
                if (iserr.Success == "error")
                {
                    return JsonHelper.GetJsonO(iserr);
                }

                #endregion


                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                dictionary.Add("TaskContext", taskContext);
                dictionary.Add("TaskType", "success-element");
                dictionary.Add("CreateUser", int.Parse(uid));
                dictionary.Add("CreateDate", DateTime.Now);
                dictionary.Add("TaskState", "list");
                dictionary.Add("AssignUser", int.Parse(uid));

                return new DataHelperBll().AddOrUpdateDataById(typeof(TBasisTaskList), "", dictionary);
            }
            catch (Exception ex)
            {
                ReturnJson.Success = "error";
                ReturnJson.JsonMsg = ex.Message;
                return JsonHelper.GetJsonO(ReturnJson);
            }
        }

    }
}
