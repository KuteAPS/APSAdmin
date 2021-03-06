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
	/// Strongly-typed collection for the TApsClientClickCount class.
	/// </summary>
    [Serializable]
	public partial class TApsClientClickCountCollection : ActiveList<TApsClientClickCount, TApsClientClickCountCollection>
	{	   
		public TApsClientClickCountCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TApsClientClickCountCollection</returns>
		public TApsClientClickCountCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TApsClientClickCount o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_ApsClientClickCount table.
	/// </summary>
	[Serializable]
	public partial class TApsClientClickCount : ActiveRecord<TApsClientClickCount>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TApsClientClickCount()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TApsClientClickCount(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TApsClientClickCount(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TApsClientClickCount(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_ApsClientClickCount", TableType.Table, DataService.GetInstance("Nowthwin"));
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
				
				TableSchema.TableColumn colvarCreateDate = new TableSchema.TableColumn(schema);
				colvarCreateDate.ColumnName = "CreateDate";
				colvarCreateDate.DataType = DbType.AnsiString;
				colvarCreateDate.MaxLength = 0;
				colvarCreateDate.AutoIncrement = false;
				colvarCreateDate.IsNullable = true;
				colvarCreateDate.IsPrimaryKey = false;
				colvarCreateDate.IsForeignKey = false;
				colvarCreateDate.IsReadOnly = false;
				colvarCreateDate.DefaultSetting = @"";
				colvarCreateDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreateDate);
				
				TableSchema.TableColumn colvarClickCount = new TableSchema.TableColumn(schema);
				colvarClickCount.ColumnName = "ClickCount";
				colvarClickCount.DataType = DbType.Int32;
				colvarClickCount.MaxLength = 0;
				colvarClickCount.AutoIncrement = false;
				colvarClickCount.IsNullable = true;
				colvarClickCount.IsPrimaryKey = false;
				colvarClickCount.IsForeignKey = false;
				colvarClickCount.IsReadOnly = false;
				colvarClickCount.DefaultSetting = @"";
				colvarClickCount.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClickCount);
				
				TableSchema.TableColumn colvarNowClickCount = new TableSchema.TableColumn(schema);
				colvarNowClickCount.ColumnName = "NowClickCount";
				colvarNowClickCount.DataType = DbType.Int32;
				colvarNowClickCount.MaxLength = 0;
				colvarNowClickCount.AutoIncrement = false;
				colvarNowClickCount.IsNullable = true;
				colvarNowClickCount.IsPrimaryKey = false;
				colvarNowClickCount.IsForeignKey = false;
				colvarNowClickCount.IsReadOnly = false;
				
						colvarNowClickCount.DefaultSetting = @"((0))";
				colvarNowClickCount.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNowClickCount);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_ApsClientClickCount",schema);
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
		  
		[XmlAttribute("CreateDate")]
		[Bindable(true)]
		public string CreateDate 
		{
			get { return GetColumnValue<string>(Columns.CreateDate); }
			set { SetColumnValue(Columns.CreateDate, value); }
		}
		  
		[XmlAttribute("ClickCount")]
		[Bindable(true)]
		public int? ClickCount 
		{
			get { return GetColumnValue<int?>(Columns.ClickCount); }
			set { SetColumnValue(Columns.ClickCount, value); }
		}
		  
		[XmlAttribute("NowClickCount")]
		[Bindable(true)]
		public int? NowClickCount 
		{
			get { return GetColumnValue<int?>(Columns.NowClickCount); }
			set { SetColumnValue(Columns.NowClickCount, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varCreateDate,int? varClickCount,int? varNowClickCount)
		{
			TApsClientClickCount item = new TApsClientClickCount();
			
			item.CreateDate = varCreateDate;
			
			item.ClickCount = varClickCount;
			
			item.NowClickCount = varNowClickCount;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varCreateDate,int? varClickCount,int? varNowClickCount)
		{
			TApsClientClickCount item = new TApsClientClickCount();
			
				item.Id = varId;
			
				item.CreateDate = varCreateDate;
			
				item.ClickCount = varClickCount;
			
				item.NowClickCount = varNowClickCount;
			
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
        
        
        
        public static TableSchema.TableColumn CreateDateColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ClickCountColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn NowClickCountColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"id";
			 public static string CreateDate = @"CreateDate";
			 public static string ClickCount = @"ClickCount";
			 public static string NowClickCount = @"NowClickCount";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
