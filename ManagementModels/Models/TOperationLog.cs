using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace Models
{
	/// <summary>
	/// Strongly-typed collection for the TOperationLog class.
	/// </summary>
    [Serializable]
	public partial class TOperationLogCollection : ActiveList<TOperationLog, TOperationLogCollection>
	{	   
		public TOperationLogCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TOperationLogCollection</returns>
		public TOperationLogCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TOperationLog o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the T_Operation_Log table.
	/// </summary>
	[Serializable]
	public partial class TOperationLog : ActiveRecord<TOperationLog>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TOperationLog()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TOperationLog(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TOperationLog(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TOperationLog(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("T_Operation_Log", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "id";
				colvarId.DataType = DbType.Int32;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = true;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = true;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarOperationType = new TableSchema.TableColumn(schema);
				colvarOperationType.ColumnName = "operationType";
				colvarOperationType.DataType = DbType.String;
				colvarOperationType.MaxLength = 50;
				colvarOperationType.AutoIncrement = false;
				colvarOperationType.IsNullable = true;
				colvarOperationType.IsPrimaryKey = false;
				colvarOperationType.IsForeignKey = false;
				colvarOperationType.IsReadOnly = false;
				colvarOperationType.DefaultSetting = @"";
				colvarOperationType.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOperationType);
				
				TableSchema.TableColumn colvarCustomerId = new TableSchema.TableColumn(schema);
				colvarCustomerId.ColumnName = "customerId";
				colvarCustomerId.DataType = DbType.String;
				colvarCustomerId.MaxLength = 50;
				colvarCustomerId.AutoIncrement = false;
				colvarCustomerId.IsNullable = true;
				colvarCustomerId.IsPrimaryKey = false;
				colvarCustomerId.IsForeignKey = false;
				colvarCustomerId.IsReadOnly = false;
				colvarCustomerId.DefaultSetting = @"";
				colvarCustomerId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCustomerId);
				
				TableSchema.TableColumn colvarContents = new TableSchema.TableColumn(schema);
				colvarContents.ColumnName = "contents";
				colvarContents.DataType = DbType.String;
				colvarContents.MaxLength = 1073741823;
				colvarContents.AutoIncrement = false;
				colvarContents.IsNullable = true;
				colvarContents.IsPrimaryKey = false;
				colvarContents.IsForeignKey = false;
				colvarContents.IsReadOnly = false;
				colvarContents.DefaultSetting = @"";
				colvarContents.ForeignKeyTableName = "";
				schema.Columns.Add(colvarContents);
				
				TableSchema.TableColumn colvarCreateTime = new TableSchema.TableColumn(schema);
				colvarCreateTime.ColumnName = "createTime";
				colvarCreateTime.DataType = DbType.DateTime;
				colvarCreateTime.MaxLength = 0;
				colvarCreateTime.AutoIncrement = false;
				colvarCreateTime.IsNullable = true;
				colvarCreateTime.IsPrimaryKey = false;
				colvarCreateTime.IsForeignKey = false;
				colvarCreateTime.IsReadOnly = false;
				colvarCreateTime.DefaultSetting = @"";
				colvarCreateTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreateTime);
				
				TableSchema.TableColumn colvarCreateMan = new TableSchema.TableColumn(schema);
				colvarCreateMan.ColumnName = "createMan";
				colvarCreateMan.DataType = DbType.String;
				colvarCreateMan.MaxLength = 50;
				colvarCreateMan.AutoIncrement = false;
				colvarCreateMan.IsNullable = true;
				colvarCreateMan.IsPrimaryKey = false;
				colvarCreateMan.IsForeignKey = false;
				colvarCreateMan.IsReadOnly = false;
				colvarCreateMan.DefaultSetting = @"";
				colvarCreateMan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreateMan);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_Operation_Log",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		  
		[XmlAttribute("OperationType")]
		[Bindable(true)]
		public string OperationType 
		{
			get { return GetColumnValue<string>(Columns.OperationType); }
			set { SetColumnValue(Columns.OperationType, value); }
		}
		  
		[XmlAttribute("CustomerId")]
		[Bindable(true)]
		public string CustomerId 
		{
			get { return GetColumnValue<string>(Columns.CustomerId); }
			set { SetColumnValue(Columns.CustomerId, value); }
		}
		  
		[XmlAttribute("Contents")]
		[Bindable(true)]
		public string Contents 
		{
			get { return GetColumnValue<string>(Columns.Contents); }
			set { SetColumnValue(Columns.Contents, value); }
		}
		  
		[XmlAttribute("CreateTime")]
		[Bindable(true)]
		public DateTime? CreateTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.CreateTime); }
			set { SetColumnValue(Columns.CreateTime, value); }
		}
		  
		[XmlAttribute("CreateMan")]
		[Bindable(true)]
		public string CreateMan 
		{
			get { return GetColumnValue<string>(Columns.CreateMan); }
			set { SetColumnValue(Columns.CreateMan, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varOperationType,string varCustomerId,string varContents,DateTime? varCreateTime,string varCreateMan)
		{
			TOperationLog item = new TOperationLog();
			
			item.OperationType = varOperationType;
			
			item.CustomerId = varCustomerId;
			
			item.Contents = varContents;
			
			item.CreateTime = varCreateTime;
			
			item.CreateMan = varCreateMan;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varOperationType,string varCustomerId,string varContents,DateTime? varCreateTime,string varCreateMan)
		{
			TOperationLog item = new TOperationLog();
			
				item.Id = varId;
			
				item.OperationType = varOperationType;
			
				item.CustomerId = varCustomerId;
			
				item.Contents = varContents;
			
				item.CreateTime = varCreateTime;
			
				item.CreateMan = varCreateMan;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn OperationTypeColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn CustomerIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ContentsColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn CreateTimeColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn CreateManColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"id";
			 public static string OperationType = @"operationType";
			 public static string CustomerId = @"customerId";
			 public static string Contents = @"contents";
			 public static string CreateTime = @"createTime";
			 public static string CreateMan = @"createMan";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
