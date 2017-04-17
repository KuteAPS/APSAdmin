using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ManagementModels;
using Models;
using SubSonic;

namespace ManagementDAL
{
    public class DataHelper
    {

        #region 查询帮助类

        /// <summary>
        /// 查询某张表的所有数据
        /// </summary>
        /// <typeparam name="T">返回List泛型</typeparam>
        /// <param name="tableName">查询表名</param>
        /// <returns></returns>
        public List<T> GetDataByTable<T>(string tableName) where T : class, new()
        {
            try
            {
                return new SqlQuery().From(tableName).ExecuteTypedList<T>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 通用分页查询BootstrapTable
        /// </summary>
        /// <param name="currentPage">页数</param>
        /// <param name="pageSize">行数</param>
        /// <param name="tableName">查询表名</param>
        /// <returns> BootstrapTable 分页集合对象</returns>
        public BootstrapTableOnPageModel GetPagedModel<T>(int currentPage, int pageSize, string tableName, string sort, string order) where T : new()
        {
            try
            {
                SqlQuery query = new Select().From(tableName);

                if (!string.IsNullOrWhiteSpace(sort) && !string.IsNullOrWhiteSpace(order))
                {
                    if (order.ToLower() == "asc")
                        query.OrderAsc(sort);
                    else
                        query.OrderDesc(sort);
                }
                query.Paged(currentPage, pageSize);

                SqlQuery query1 = new Select("count(*)").From(tableName);
                return new BootstrapTableOnPageModel() { total = (int)query1.ExecuteScalar(), rows = query.ExecuteTypedList<T>() };
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 通用分页查询JqGrid
        /// </summary>
        /// <param name="currentPage">页数</param>
        /// <param name="pageSize">行数</param>
        /// <param name="tableName">查询表名</param>
        /// <returns> BootstrapTable 分页集合对象</returns>
        public JqGridOnPageModel GetJqGridOnPageModel<T>(int currentPage, int pageSize, string tableName) where T : new()
        {
            try
            {
                SqlQuery query = new Select().From(tableName);
                query.Paged(currentPage, pageSize);
                var list = query.ExecuteTypedList<T>();
                SqlQuery query1 = new Select("count(*)").From(tableName);
                int count = (int)query1.ExecuteScalar();
                return new JqGridOnPageModel() { total = (int)Math.Ceiling(((double)count / pageSize)), page = currentPage, records = count, rows = list };
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 根据单列列条件查询
        /// </summary>
        /// <typeparam name="T">返回List泛型</typeparam>
        /// <param name="tableName">查询表名</param>
        /// <param name="cloums">匹配列名</param>
        /// <param name="values">条件值</param>
        /// <returns></returns>
        public List<T> GetDataByCloum<T>(string tableName, string cloums, object values) where T : class, new()
        {
            try
            {
                SqlQuery query = new SqlQuery().From(tableName);
                query.Where(cloums).IsEqualTo(values);

                return query.ExecuteTypedList<T>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 根据单列列多条件查询
        /// </summary>
        /// <typeparam name="T">返回List泛型</typeparam>
        /// <param name="tableName">查询表名</param>
        /// <param name="cloums">匹配列名</param>
        /// <param name="values">条件值</param>
        /// <returns></returns>
        public List<T> GetDataByCloum<T>(string tableName, string cloums, List<string> values, string typed) where T : class, new()
        {
            try
            {
                SqlQuery query = new SqlQuery().From(tableName);
                query.Where(cloums).IsEqualTo(values.First());
                values.Remove(values.First());

                foreach (var value in values)
                {
                    if (typed.ToLower() == "and")
                    {
                        query.And(cloums).IsEqualTo(value);
                    }
                    else
                    {
                        query.Or(cloums).IsEqualTo(value);
                    }

                }

                return query.ExecuteTypedList<T>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 根据多列条件查询
        /// </summary>
        /// <typeparam name="T">返回List泛型</typeparam>
        /// <param name="tableName">查询表名</param>
        /// <param name="cloums">匹配列名集合 Key对应values</param>
        /// <param name="values">条件值集合 Key对应cloums</param>
        /// <param name="type">条件类型or/and</param>
        /// <returns></returns>
        public List<T> GetDataByCloums<T>(string tableName, Dictionary<string, TableSchema.TableColumn> cloums, Dictionary<string, object> values, string type) where T : class, new()
        {
            try
            {
                SqlQuery query = new SqlQuery().From(tableName);
                query.Where(cloums[cloums.Keys.ToList().First()]).IsEqualTo(values[cloums.Keys.ToList().First()]);
                cloums.Remove(cloums.Keys.ToList().First());

                foreach (var cloum in cloums.Keys)
                {
                    if (type.ToLower() == "and")
                    {
                        query.And(cloums[cloum]).IsEqualTo(values[cloum]);
                    }
                    else
                    {
                        query.Or(cloums[cloum]).IsEqualTo(values[cloum]);
                    }
                }

                return query.ExecuteTypedList<T>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region 删除帮助类
        /// <summary>
        /// 根据某一列批量删除数据
        /// </summary>
        /// <param name="column">匹配列名(单个)</param>
        /// <param name="list">匹配值</param>
        /// <param name="errRow">传出参数 错误行</param>
        /// <param name="err">传出参数 错误匹配值</param>
        /// <returns></returns>
        public int DelSomeData<T>(TableSchema.TableColumn column, List<string> list, out int errRow, out string err) where T : RecordBase<T>, new()
        {
            try
            {
                int row = 0;
                errRow = 0;
                err = string.Empty;

                foreach (var o in list)
                {
                    if (new Delete().From<T>().Where(column).IsEqualTo(o).Execute() < 1)
                    {
                        err += $"【{o}】";
                        errRow++;
                    }
                    else { row++; }
                }

                return row;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 根据某一列批量删除数据
        /// </summary>
        /// <param name="column">匹配列名(单个)</param>
        /// <param name="list">匹配值</param>
        /// <param name="errRow">传出参数 错误行</param>
        /// <param name="err">传出参数 错误匹配值</param>
        /// <returns></returns>
        public int DelSomeData<T>(TableSchema.TableColumn column, object obj) where T : RecordBase<T>, new()
        {
            try
            {
                return new Delete().From<T>().Where(column).IsEqualTo(obj).Execute();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region 增加/更新帮助类

        /// <summary>
        /// 根据主键适配增加/更新
        /// </summary> 
        /// <param name="tableClassName">类的完全限定名</param>
        /// <param name="id">主键</param>
        /// <param name="dictionary">对象属性对应值,Key必须跟对象属性一致</param>
        /// <returns></returns>
        public bool UpdateData(string tableClassName, object id, Dictionary<string, object> dictionary)
        {
            try
            {
                string msg = string.Empty;
                //根据ID判断新增或修改 生成有参数或无参实例对象
                object obj;
                if (string.IsNullOrWhiteSpace(id.ToString()))
                {

                    obj = Assembly.Load("ManagementModels").CreateInstance(tableClassName, false); ;//类的完全限定名（即包括命名空间）
                }
                else
                {
                    object[] parameters = new object[1];
                    parameters[0] = id;

                    obj = Assembly.Load("ManagementModels").CreateInstance(tableClassName, true, System.Reflection.BindingFlags.Default, null, parameters, null, null);// 创建类的实例
                }

                //获取反射类所有方法
                var mi = obj.GetType().GetMethods();


                //筛选属性的SET方法
                var miSet = mi.ToList().FindAll(x => x.Name.ToLower().Contains("set"));
                var keys = dictionary.Keys.ToList();
                foreach (var key in keys)
                {
                    var setMethod = miSet.Find(x => x.Name.Replace("set_", "").ToLower() == key.ToLower());
                    if (setMethod != null)
                    {
                        object[] parameter = { dictionary[key] };
                        setMethod.Invoke(obj, parameter);
                    }
                    else
                    {
                        throw new Exception($"异常没找到与{key}对应的字段");
                    }
                }

                //筛选过滤执行Save方法
                foreach (var methodInfo in mi)
                {
                    //指定执行方法
                    if (methodInfo.Name.Equals("Save", StringComparison.Ordinal))
                    {
                        if (methodInfo.GetParameters().Length < 1)
                        {
                            methodInfo.Invoke(obj, null);
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
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
        public int UpdateOneCloum(string tableName, string updataCloumName, string updataValue, string byCloum, List<string> value, string type)
        {
            try
            {
                SqlQuery query = new Update(tableName)
                    .Set(updataCloumName).EqualTo(updataValue);

                query.Where(byCloum).IsEqualTo(value.First());

                foreach (var str in value)
                {
                    if(str== value.First())
                        continue;

                    if (type.ToLower() == "and")
                    {
                        query.And(byCloum).IsEqualTo(str);
                    }
                    else
                    {
                        query.Or(byCloum).IsEqualTo(str);
                    }
                }
                return query.Execute();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion
    }
}
