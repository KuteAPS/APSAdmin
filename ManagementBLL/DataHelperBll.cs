using System;
using System.Collections.Generic;
using System.Linq;
using ManagementCore;
using ManagementDAL;
using ManagementModels;
using ManagementModels.OtherModels;
using Models;
using SubSonic;

namespace ManagementBLL
{
    public class DataHelperBll
    {
        /// <summary>
        ///     默认构造函数
        /// </summary>
        public DataHelperBll()
        {
            ReturnJson = new WebReturnJsonModel();
        }

        private WebReturnJsonModel ReturnJson { get; }

        /// <summary>
        ///     查询某表的数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tableName">查询表名</param>
        /// <returns>List集合</returns>
        public List<T> GetDataByTable<T>(string tableName) where T : class, new()
        {
            try
            {
                return new DataHelper().GetDataByTable<T>(tableName);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///     查询某表的数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tableName">查询表名</param>
        /// <returns>序列化WebReturnJsonModel</returns>
        public string GetDataByTableJson<T>(string tableName) where T : class, new()
        {
            try
            {
                var obj = new DataHelper().GetDataByTable<T>(tableName);
                ReturnJson.Success = obj.Count > 0 ? "success" : "warning";

                ReturnJson.JsonMsg = JsonHelper.GetJsonO(obj);
            }
            catch (Exception ex)
            {
                ReturnJson.Success = "error";

                ReturnJson.JsonMsg = ex.Message;
            }

            return JsonHelper.GetJsonO(ReturnJson);
        }

        /// <summary>
        ///     分页获取数据BootstrapTable
        /// </summary>
        /// <param name="currentPage">当前页</param>
        /// <param name="pageSize">页面条数</param>
        /// <param name="tableName">查询表名</param>
        /// <returns></returns>
        public BootstrapTableOnPageModel GetDataByPage<T>(int currentPage, int pageSize, string tableName, string sort, string order, string cloum = "", string val = "")
            where T : class, new()
        {
            try
            {
                return new DataHelper().GetPagedModel<T>(currentPage, pageSize, tableName, sort,order, cloum,val);
            }
            catch (Exception)
            {
                throw;
            }
        }
        


        /// <summary>
        ///     分页获取数据 JqGrid
        /// </summary>
        /// <param name="currentPage">当前页</param>
        /// <param name="pageSize">页面条数</param>
        /// <param name="tableName">查询表名</param>
        /// <returns></returns>
        public JqGridOnPageModel GetDataByPageJqGrid<T>(int currentPage, int pageSize, string tableName)
            where T : class, new()
        {
            try
            {
                return new DataHelper().GetJqGridOnPageModel<T>(currentPage, pageSize, tableName);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        /// <summary>
        ///     根据某一列，多条件查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tableName">表名</param>
        /// <param name="cloums">列名</param>
        /// <param name="values">条件值</param>
        /// <param name="typed">and/or</param>
        /// <returns>序列化WebReturnJsonModel</returns>
        public List<T> GetDataByCoumObj<T>(string tableName, string cloums, List<string> values, string typed)
            where T : class, new()
        {
            try
            {
                var obj = new DataHelper().GetDataByCloum<T>(tableName, cloums, values, typed);
                return obj;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        ///     根据某一列为条件查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tableName">表名</param>
        /// <param name="cloums">列名</param>
        /// <param name="values">条件值</param>
        /// <returns>序列化WebReturnJsonModel</returns>
        public string GetDataByCoumJson<T>(string tableName, string cloums, object values) where T : class, new()
        {
            try
            {
                var obj = new DataHelper().GetDataByCloum<T>(tableName, cloums, values);

                ReturnJson.Success = obj.Count > 0 ? "success" : "warning";

                ReturnJson.JsonMsg = JsonHelper.GetJsonO(obj);
            }
            catch (Exception ex)
            {
                ReturnJson.Success = "error";
                ReturnJson.JsonMsg = ex.Message;
            }
            return JsonHelper.GetJsonO(ReturnJson);
        }

        /// <summary>
        ///     根据某一列为条件查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tableName">表名</param>
        /// <param name="cloums">列名</param>
        /// <param name="values">条件值</param>
        /// <returns>List集合</returns>
        public List<T> GetDataByCoumObject<T>(string tableName, string cloums, object values) where T : class, new()
        {
            try
            {
                return new DataHelper().GetDataByCloum<T>(tableName, cloums, values);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///     根据某些列为条件查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tableName">查询表名</param>
        /// <param name="cloums">匹配列名集合 Key对应values</param>
        /// <param name="values">条件值集合 Key对应cloums</param>
        /// <param name="type">条件类型or/and</param>
        /// <returns>List集合</returns>
        public List<T> GetDataByCoumsObj<T>(string tableName, Dictionary<string, TableSchema.TableColumn> cloums,
            Dictionary<string, object> values, string type) where T : class, new()
        {
            try
            {
                return new DataHelper().GetDataByCloums<T>(tableName, cloums, values, type);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        ///     根据某些列为条件查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tableName">查询表名</param>
        /// <param name="cloums">匹配列名集合 Key对应values</param>
        /// <param name="values">条件值集合 Key对应cloums</param>
        /// <param name="type">条件类型or/and</param>
        /// <returns>序列化WebReturnJsonModel</returns>
        public string GetDataByCoumsJson<T>(string tableName, Dictionary<string, TableSchema.TableColumn> cloums,
            Dictionary<string, object> values, string type) where T : class, new()
        {
            try
            {
                var obj = new DataHelper().GetDataByCloums<T>(tableName, cloums, values, type);

                ReturnJson.Success = obj.Count > 0 ? "success" : "warning";

                ReturnJson.JsonMsg = JsonHelper.GetJsonO(obj);
            }
            catch (Exception ex)
            {
                ReturnJson.Success = "error";
                ReturnJson.JsonMsg = ex.Message;
            }
            return JsonHelper.GetJsonO(ReturnJson);
        }
        
        /// <summary>
        ///     删除多次数据单列
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="column">条件列</param>
        /// <param name="list">条件值</param>
        /// <returns></returns>
        public string DelData<T>(TableSchema.TableColumn column, List<string> list) where T : RecordBase<T>, new()
        {
            try
            {
                string err;
                int errrow;
                var row = new DataHelper().DelSomeData<T>(column, list.ConvertAll(x => x.ToString()), out errrow,
                    out err);

                if (row == list.Count)
                {
                    ReturnJson.Success = "success";
                    ReturnJson.JsonMsg = $"信息处理成功，共{row}条";
                }
                else if (row > 0)
                {
                    ReturnJson.Success = "warning";
                    ReturnJson.JsonMsg = $"处理失败,{row}条记录成功，{errrow}条记录异常:{err}";
                }
                else
                {
                    ReturnJson.Success = "error";
                    ReturnJson.JsonMsg = "信息处理失败,刷新页面后重试";
                }

                return JsonHelper.GetJsonO(ReturnJson);
            }
            catch (Exception ex)
            {
                ReturnJson.Success = "error";
                ReturnJson.JsonMsg = ex.Message;
            }
            return JsonHelper.GetJsonO(ReturnJson);
        }

        /// <summary>
        ///     删除单次数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="column">条件列</param>
        /// <param name="obj">条件值</param>
        /// <returns></returns>
        public WebReturnJsonModel DelData<T>(TableSchema.TableColumn column, object obj) where T : RecordBase<T>, new()
        {
            try
            {
                var row = new DataHelper().DelSomeData<T>(column, obj);

                if (row > 0)
                {
                    ReturnJson.Success = "success";
                    ReturnJson.JsonMsg = $"信息处理成功，共{row}条";
                }
                else if (row <= 0)
                {
                    ReturnJson.Success = "error";
                    ReturnJson.JsonMsg = "信息处理失败,刷新页面后重试";
                }

                return ReturnJson;
            }
            catch (Exception ex)
            {
                ReturnJson.Success = "error";
                ReturnJson.JsonMsg = ex.Message;
            }
            return ReturnJson;
        }

        /// <summary>
        ///     智能识别增加或修改，需支持ID
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tableClassTyped">表实体类</param>
        /// <param name="id"></param>
        /// <param name="dictionary">对象属性对应值,Key必须跟对象属性一致</param>
        /// <returns></returns>
        public string AddOrUpdateDataById(Type tableClassTyped, string id, Dictionary<string, object> dictionary)
        {
            try
            {
                ReturnJson.Success = "success";
                ReturnJson.JsonMsg = new DataHelper().UpdateData(tableClassTyped.FullName, id, dictionary)
                    ? "执行成功"
                    : "执行失败";
            }
            catch (Exception ex)
            {
                ReturnJson.Success = "error";
                ReturnJson.JsonMsg = ex.Message;
            }
            return JsonHelper.GetJsonO(ReturnJson);
        }


        /// <summary>
        /// 根据单列的多个条件，更新某一列的数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="updataCloumName">更新列名</param>
        /// <param name="updataValue">更新值</param>
        /// <param name="byCloum">条件列名</param>
        /// <param name="value">条件</param>
        /// <param name="type">条件类型and or</param>
        /// <returns></returns>
        public string UpdateOneCloum(string tableName, string updataCloumName, string updataValue, string byCloum, List<string> value, string type)
        {
            try
            {
                int row = new DataHelper().UpdateOneCloum(tableName, updataCloumName, updataValue, byCloum, value, type);
                ReturnJson.Success = row > 0 ? "success" : "warning";
                ReturnJson.JsonMsg = row > 0 ? $"多条数据受影响，行数：{row}" : "无受影响行数";
            }
            catch (Exception ex)
            {
                ReturnJson.Success = "error";
                ReturnJson.JsonMsg = ex.Message;
            }
            return JsonHelper.GetJsonO(ReturnJson);
        }
    }
}