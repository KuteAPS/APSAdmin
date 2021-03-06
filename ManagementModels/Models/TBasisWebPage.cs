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
	/// Strongly-typed collection for the TBasisWebPage class.
	/// </summary>
    [Serializable]
	public partial class TBasisWebPageCollection : ActiveList<TBasisWebPage, TBasisWebPageCollection>
	{	   
		public TBasisWebPageCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TBasisWebPageCollection</returns>
		public TBasisWebPageCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TBasisWebPage o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_Basis_WebPage table.
	/// </summary>
	[Serializable]
	public partial class TBasisWebPage : ActiveRecord<TBasisWebPage>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TBasisWebPage()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TBasisWebPage(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TBasisWebPage(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TBasisWebPage(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_Basis_WebPage", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "id";
				colvarId.DataType = DbType.Int32;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = false;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = true;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarPageName = new TableSchema.TableColumn(schema);
				colvarPageName.ColumnName = "PageName";
				colvarPageName.DataType = DbType.String;
				colvarPageName.MaxLength = 255;
				colvarPageName.AutoIncrement = false;
				colvarPageName.IsNullable = false;
				colvarPageName.IsPrimaryKey = false;
				colvarPageName.IsForeignKey = false;
				colvarPageName.IsReadOnly = false;
				colvarPageName.DefaultSetting = @"";
				colvarPageName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPageName);
				
				TableSchema.TableColumn colvarPageUrl = new TableSchema.TableColumn(schema);
				colvarPageUrl.ColumnName = "PageUrl";
				colvarPageUrl.DataType = DbType.String;
				colvarPageUrl.MaxLength = 255;
				colvarPageUrl.AutoIncrement = false;
				colvarPageUrl.IsNullable = true;
				colvarPageUrl.IsPrimaryKey = false;
				colvarPageUrl.IsForeignKey = false;
				colvarPageUrl.IsReadOnly = false;
				colvarPageUrl.DefaultSetting = @"";
				colvarPageUrl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPageUrl);
				
				TableSchema.TableColumn colvarLocked = new TableSchema.TableColumn(schema);
				colvarLocked.ColumnName = "Locked";
				colvarLocked.DataType = DbType.Int32;
				colvarLocked.MaxLength = 0;
				colvarLocked.AutoIncrement = false;
				colvarLocked.IsNullable = false;
				colvarLocked.IsPrimaryKey = false;
				colvarLocked.IsForeignKey = false;
				colvarLocked.IsReadOnly = false;
				
						colvarLocked.DefaultSetting = @"((0))";
				colvarLocked.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLocked);
				
				TableSchema.TableColumn colvarJurisdiction = new TableSchema.TableColumn(schema);
				colvarJurisdiction.ColumnName = "Jurisdiction";
				colvarJurisdiction.DataType = DbType.Int32;
				colvarJurisdiction.MaxLength = 0;
				colvarJurisdiction.AutoIncrement = false;
				colvarJurisdiction.IsNullable = true;
				colvarJurisdiction.IsPrimaryKey = false;
				colvarJurisdiction.IsForeignKey = false;
				colvarJurisdiction.IsReadOnly = false;
				
						colvarJurisdiction.DefaultSetting = @"((0))";
				colvarJurisdiction.ForeignKeyTableName = "";
				schema.Columns.Add(colvarJurisdiction);
				
				TableSchema.TableColumn colvarGroupId = new TableSchema.TableColumn(schema);
				colvarGroupId.ColumnName = "GroupId";
				colvarGroupId.DataType = DbType.Int32;
				colvarGroupId.MaxLength = 0;
				colvarGroupId.AutoIncrement = false;
				colvarGroupId.IsNullable = true;
				colvarGroupId.IsPrimaryKey = false;
				colvarGroupId.IsForeignKey = false;
				colvarGroupId.IsReadOnly = false;
				colvarGroupId.DefaultSetting = @"";
				colvarGroupId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGroupId);
				
				TableSchema.TableColumn colvarShowMenu = new TableSchema.TableColumn(schema);
				colvarShowMenu.ColumnName = "ShowMenu";
				colvarShowMenu.DataType = DbType.Int32;
				colvarShowMenu.MaxLength = 0;
				colvarShowMenu.AutoIncrement = false;
				colvarShowMenu.IsNullable = true;
				colvarShowMenu.IsPrimaryKey = false;
				colvarShowMenu.IsForeignKey = false;
				colvarShowMenu.IsReadOnly = false;
				colvarShowMenu.DefaultSetting = @"";
				colvarShowMenu.ForeignKeyTableName = "";
				schema.Columns.Add(colvarShowMenu);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_Basis_WebPage",schema);
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
		  
		[XmlAttribute("PageName")]
		[Bindable(true)]
		public string PageName 
		{
			get { return GetColumnValue<string>(Columns.PageName); }
			set { SetColumnValue(Columns.PageName, value); }
		}
		  
		[XmlAttribute("PageUrl")]
		[Bindable(true)]
		public string PageUrl 
		{
			get { return GetColumnValue<string>(Columns.PageUrl); }
			set { SetColumnValue(Columns.PageUrl, value); }
		}
		  
		[XmlAttribute("Locked")]
		[Bindable(true)]
		public int Locked 
		{
			get { return GetColumnValue<int>(Columns.Locked); }
			set { SetColumnValue(Columns.Locked, value); }
		}
		  
		[XmlAttribute("Jurisdiction")]
		[Bindable(true)]
		public int? Jurisdiction 
		{
			get { return GetColumnValue<int?>(Columns.Jurisdiction); }
			set { SetColumnValue(Columns.Jurisdiction, value); }
		}
		  
		[XmlAttribute("GroupId")]
		[Bindable(true)]
		public int? GroupId 
		{
			get { return GetColumnValue<int?>(Columns.GroupId); }
			set { SetColumnValue(Columns.GroupId, value); }
		}
		  
		[XmlAttribute("ShowMenu")]
		[Bindable(true)]
		public int? ShowMenu 
		{
			get { return GetColumnValue<int?>(Columns.ShowMenu); }
			set { SetColumnValue(Columns.ShowMenu, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varId,string varPageName,string varPageUrl,int varLocked,int? varJurisdiction,int? varGroupId,int? varShowMenu)
		{
			TBasisWebPage item = new TBasisWebPage();
			
			item.Id = varId;
			
			item.PageName = varPageName;
			
			item.PageUrl = varPageUrl;
			
			item.Locked = varLocked;
			
			item.Jurisdiction = varJurisdiction;
			
			item.GroupId = varGroupId;
			
			item.ShowMenu = varShowMenu;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varPageName,string varPageUrl,int varLocked,int? varJurisdiction,int? varGroupId,int? varShowMenu)
		{
			TBasisWebPage item = new TBasisWebPage();
			
				item.Id = varId;
			
				item.PageName = varPageName;
			
				item.PageUrl = varPageUrl;
			
				item.Locked = varLocked;
			
				item.Jurisdiction = varJurisdiction;
			
				item.GroupId = varGroupId;
			
				item.ShowMenu = varShowMenu;
			
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
        
        
        
        public static TableSchema.TableColumn PageNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn PageUrlColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn LockedColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn JurisdictionColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn GroupIdColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ShowMenuColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"id";
			 public static string PageName = @"PageName";
			 public static string PageUrl = @"PageUrl";
			 public static string Locked = @"Locked";
			 public static string Jurisdiction = @"Jurisdiction";
			 public static string GroupId = @"GroupId";
			 public static string ShowMenu = @"ShowMenu";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
