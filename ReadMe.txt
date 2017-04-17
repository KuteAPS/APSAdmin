******************************************************************************************
******************************************************************************************
*******************************Management手册*********************************************
******************************************************************************************
******************************************************************************************

									应用技术

MVC5框架 + Subsonic2.2 + SqlServer2008 + MSMQ消息队列 + BootStrap + 多继承JS框架 + 数据对称加密



									分层结构
UI:ManagementAdmin
逻辑层：ManagementBLL
核心层：ManagementCore
数据层：ManagementDAL
实体层：ManagementModels
消息队列：ManagementMsmq
数据安全：MangementSecurity


逻辑层ManagementBLL  --  快捷公共帮助（DataHelperBll）

1.查询数据的各种方法
	1-1.查询某张表的所有数据 (适用于表,视图)---- GetDataByTable<T>(string tableName)
		泛型为要返回的List泛型
		参数tableName 为要查询的表名 
		返回传入泛型的List集合
		例：new DataHelperBll().GetDataByTable<TBasisWebGroup>(TBasisWebGroup.Schema.TableName)

	1-2.查询某张表的所有数据 (适用于表,视图)---- GetDataByTableJson<T>(string tableName)
		泛型为要返回的List泛型
		参数tableName 为要查询的表名 
		返回 JSON 序列化的 WebReturnJsonModel，其中 属性Success为此次执行的状态  JsonMsg 为JSON序列化的传入泛型的List集合
		例：new DataHelperBll().GetDataByTable<TBasisWebGroup>(TBasisWebGroup.Schema.TableName)
	
	1-3.分页获取数据 (适用于表,视图)---  GetDataByPage<T>(int currentPage, int pageSize, string tableName)
		泛型为要返回的List泛型
		参数currentPage 为偏移量 比如：每页行数是10，第一页为0，第二页为10
		参数pageSize 为每页行数 
		参数tableName 为要查询的表名 
		返回传入泛型的List集合
		例：new DataHelperBll().GetDataByPage<VUser>(1, 10, VUser.Schema.TableName) 完全适配于BootStrap-Table分页

	1-4.根据某一列，多条件查询 (适用于表,视图)  --- GetDataByCoumObj<T>(string tableName, string cloums, List<string> values, string typed)
		泛型为要返回的List泛型
		参数tableName 为要查询的表名 
		参数cloums 为条件列名 
		参数values 为条件集合 
		参数typed 为条件类型,参数为 and / or 
		返回传入泛型的List集合

	1-5. 根据某一列，单个条件查询 (适用于表,视图)  --- GetDataByCoumObject<T>(string tableName, string cloums, object values)
		泛型为要返回的List泛型
		参数tableName 为要查询的表名 
		参数cloums 为条件列名 
		参数values 为条件值
		返回传入泛型的List集合

	1-6. 根据某一列，单个条件查询 (适用于表,视图)  --- GetDataByCoumJson<T>(string tableName, string cloums, object values)
		泛型为要返回的List泛型
		参数tableName 为要查询的表名 
		参数cloums 为条件列名 
		参数values 为条件值
		返回 JSON 序列化的 WebReturnJsonModel，其中 属性Success为此次执行的状态  JsonMsg 为JSON序列化的传入泛型的List集合

	1-7. 根据多列，多条件查询 (适用于表,视图)  --- GetDataByCoumsObj<T>(string tableName, Dictionary<string, TableSchema.TableColumn> cloums, Dictionary<string, object> values, string type)
		泛型为要返回的List泛型
		参数tableName 为要查询的表名 
		参数cloums 为条件键值对集合 Key对应values的key
		参数values 为条件值的键值对集合 Key对应cloums的key
		参数type 为条件类型,参数为 and / or 
		返回 传入泛型的List集合


	1-8. 根据多列，多条件查询 (适用于表,视图)  --- GetDataByCoumsJson<T>(string tableName, Dictionary<string, TableSchema.TableColumn> cloums, Dictionary<string, object> values, string type)
		泛型为要返回的List泛型
		参数tableName 为要查询的表名 
		参数cloums 为条件键值对集合 Key对应values的key
		参数values 为条件值的键值对集合 Key对应cloums的key
		参数type 为条件类型,参数为 and / or 
		返回 JSON 序列化的 WebReturnJsonModel，其中 属性Success为此次执行的状态  JsonMsg 为JSON序列化的传入泛型的List集合




2.删除数据的各种方法
	
	2-1. 根据单列，单条件，删除多次数据 (适用于表)  --- DelData<T>(TableSchema.TableColumn column, List<string> list) 
		泛型为要删除的表泛型
		参数column 为要删除的列 
		参数list 为条件集合,会对每个条件进行单独的删除
		返回 JSON 序列化的 WebReturnJsonModel，其中 属性Success为此次执行的状态（success 执行成功，warning 部分成功，error 失败）  JsonMsg 处理结果提示文本
	
	2-2. 根据单列，单条件，删除一次数据 (适用于表)  --- DelData<T>(TableSchema.TableColumn column, object obj) 
		泛型为要删除的表泛型
		参数column 为要删除的列 
		参数list 为条件集合,会对每个条件进行单独的删除
		返回 JSON 序列化的 WebReturnJsonModel，其中 属性Success为此次执行的状态（success 执行成功，error 失败）  JsonMsg 处理结果提示文本


3.智能识别增加修改更新数据			

	3-1. 根据单列，单条件，删除一次数据 (适用于表)  --- AddOrUpdateDataById(Type tableClassTyped, string id, Dictionary<string, object> dictionary)
		泛型为要删除的表泛型
		参数tableClassTyped 为要执行Model类的完全限定名  
		参数id 为要执行Model类的主键 
		参数dictionary 为对象属性对应值,Key必须跟对象属性一致  
		返回 JSON 序列化的 WebReturnJsonModel，其中 属性Success为此次执行的状态（success 执行成功，error 执行失败）  JsonMsg 处理结果提示文本






JS帮助类

基于表格的导出 -------引用压缩JS包   @Scripts.Render("~/system/bootstraptableExport")

//将TableAdmin表格导出至png格式
 <button type="button" class="btn btn-outline btn-default" onclick="doExport('#TableAdmin', { type: 'png' });">
	<i aria-hidden="true">PNG</i>
</button>

//将TableAdmin表格导出至excel格式
<button type="button" class="btn btn-outline btn-default" onclick="doExport('#TableAdmin', { type: 'excel' });">
	<i aria-hidden="true">excel</i>
</button>

//将TableAdmin表格导出至pdf格式
<button type="button" class="btn btn-outline btn-default" onclick="doExport('#TableAdmin', { type: 'pdf', jspdf: { orientation: 'p', unit: 'mm', autotable: false } });">
	<i aria-hidden="true">PDF</i>
</button>


 赋予回车按键的键盘监听
	
	keydowntrigger(JS对象)
	将页面ID为 btn_submit 的 全部默认赋予


表单提交并消息提示

	FormSubmit(提交地址, 序列化表单)
	提交后返回状态用Toast提示


所选表格提交
	PostData(tables, url, o, refreshTable)
	将所选行提交至后台，一般用于表格的删除等操作，提交后返回状态用Toast提示


JS用Toast提示解析数据
	AjaxDataToastShow(JSON序列化的WebReturnJsonModel对象)

需弹窗编辑的数据
	EditData(tables, url)
	传入要编辑数据所在的表格和编辑数据所用的URL窗口，数据必须选择一条，默认传递的参数为选中数据的ID列自动URL静态化，传入的URL不需要参数且要支持参数有且必须支持参数ID


Toast公共提示JS方法
	ToastShow(title, msg, timeOut, clickMsg, type) 
	传入参数依次为，标题，显示信息，显示时间，点击时提示信息，类型
