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
	/// Strongly-typed collection for the TBasisNeedPermission class.
	/// </summary>
    [Serializable]
	public partial class TBasisNeedPermissionCollection : ActiveList<TBasisNeedPermission, TBasisNeedPermissionCollection>
	{	   
		public TBasisNeedPermissionCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TBasisNeedPermissionCollection</returns>
		public TBasisNeedPermissionCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TBasisNeedPermission o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_Basis_NeedPermissions table.
	/// </summary>
	[Serializable]
	public partial class TBasisNeedPermission : ActiveRecord<TBasisNeedPermission>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TBasisNeedPermission()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TBasisNeedPermission(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TBasisNeedPermission(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TBasisNeedPermission(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_Basis_NeedPermissions", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "ID";
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
				
				TableSchema.TableColumn colvarUserID = new TableSchema.TableColumn(schema);
				colvarUserID.ColumnName = "UserID";
				colvarUserID.DataType = DbType.Int32;
				colvarUserID.MaxLength = 0;
				colvarUserID.AutoIncrement = false;
				colvarUserID.IsNullable = false;
				colvarUserID.IsPrimaryKey = false;
				colvarUserID.IsForeignKey = false;
				colvarUserID.IsReadOnly = false;
				colvarUserID.DefaultSetting = @"";
				colvarUserID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUserID);
				
				TableSchema.TableColumn colvarPageID = new TableSchema.TableColumn(schema);
				colvarPageID.ColumnName = "PageID";
				colvarPageID.DataType = DbType.Int32;
				colvarPageID.MaxLength = 0;
				colvarPageID.AutoIncrement = false;
				colvarPageID.IsNullable = false;
				colvarPageID.IsPrimaryKey = false;
				colvarPageID.IsForeignKey = false;
				colvarPageID.IsReadOnly = false;
				colvarPageID.DefaultSetting = @"";
				colvarPageID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPageID);
				
				TableSchema.TableColumn colvarContent = new TableSchema.TableColumn(schema);
				colvarContent.ColumnName = "Content";
				colvarContent.DataType = DbType.String;
				colvarContent.MaxLength = 200;
				colvarContent.AutoIncrement = false;
				colvarContent.IsNullable = false;
				colvarContent.IsPrimaryKey = false;
				colvarContent.IsForeignKey = false;
				colvarContent.IsReadOnly = false;
				colvarContent.DefaultSetting = @"";
				colvarContent.ForeignKeyTableName = "";
				schema.Columns.Add(colvarContent);
				
				TableSchema.TableColumn colvarCreateTime = new TableSchema.TableColumn(schema);
				colvarCreateTime.ColumnName = "CreateTime";
				colvarCreateTime.DataType = DbType.DateTime;
				colvarCreateTime.MaxLength = 0;
				colvarCreateTime.AutoIncrement = false;
				colvarCreateTime.IsNullable = false;
				colvarCreateTime.IsPrimaryKey = false;
				colvarCreateTime.IsForeignKey = false;
				colvarCreateTime.IsReadOnly = false;
				
						colvarCreateTime.DefaultSetting = @"(getdate())";
				colvarCreateTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreateTime);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_Basis_NeedPermissions",schema);
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
		  
		[XmlAttribute("UserID")]
		[Bindable(true)]
		public int UserID 
		{
			get { return GetColumnValue<int>(Columns.UserID); }
			set { SetColumnValue(Columns.UserID, value); }
		}
		  
		[XmlAttribute("PageID")]
		[Bindable(true)]
		public int PageID 
		{
			get { return GetColumnValue<int>(Columns.PageID); }
			set { SetColumnValue(Columns.PageID, value); }
		}
		  
		[XmlAttribute("Content")]
		[Bindable(true)]
		public string Content 
		{
			get { return GetColumnValue<string>(Columns.Content); }
			set { SetColumnValue(Columns.Content, value); }
		}
		  
		[XmlAttribute("CreateTime")]
		[Bindable(true)]
		public DateTime CreateTime 
		{
			get { return GetColumnValue<DateTime>(Columns.CreateTime); }
			set { SetColumnValue(Columns.CreateTime, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varUserID,int varPageID,string varContent,DateTime varCreateTime)
		{
			TBasisNeedPermission item = new TBasisNeedPermission();
			
			item.UserID = varUserID;
			
			item.PageID = varPageID;
			
			item.Content = varContent;
			
			item.CreateTime = varCreateTime;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,int varUserID,int varPageID,string varContent,DateTime varCreateTime)
		{
			TBasisNeedPermission item = new TBasisNeedPermission();
			
				item.Id = varId;
			
				item.UserID = varUserID;
			
				item.PageID = varPageID;
			
				item.Content = varContent;
			
				item.CreateTime = varCreateTime;
			
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
        
        
        
        public static TableSchema.TableColumn UserIDColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn PageIDColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ContentColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn CreateTimeColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string UserID = @"UserID";
			 public static string PageID = @"PageID";
			 public static string Content = @"Content";
			 public static string CreateTime = @"CreateTime";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
