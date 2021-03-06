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
	/// Strongly-typed collection for the TBasisResource class.
	/// </summary>
    [Serializable]
	public partial class TBasisResourceCollection : ActiveList<TBasisResource, TBasisResourceCollection>
	{	   
		public TBasisResourceCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TBasisResourceCollection</returns>
		public TBasisResourceCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TBasisResource o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_Basis_resource table.
	/// </summary>
	[Serializable]
	public partial class TBasisResource : ActiveRecord<TBasisResource>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TBasisResource()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TBasisResource(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TBasisResource(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TBasisResource(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_Basis_resource", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarResources = new TableSchema.TableColumn(schema);
				colvarResources.ColumnName = "resources";
				colvarResources.DataType = DbType.AnsiString;
				colvarResources.MaxLength = 10;
				colvarResources.AutoIncrement = false;
				colvarResources.IsNullable = false;
				colvarResources.IsPrimaryKey = true;
				colvarResources.IsForeignKey = false;
				colvarResources.IsReadOnly = false;
				colvarResources.DefaultSetting = @"";
				colvarResources.ForeignKeyTableName = "";
				schema.Columns.Add(colvarResources);
				
				TableSchema.TableColumn colvarResourcesCode = new TableSchema.TableColumn(schema);
				colvarResourcesCode.ColumnName = "resourcesCode";
				colvarResourcesCode.DataType = DbType.AnsiString;
				colvarResourcesCode.MaxLength = 50;
				colvarResourcesCode.AutoIncrement = false;
				colvarResourcesCode.IsNullable = false;
				colvarResourcesCode.IsPrimaryKey = true;
				colvarResourcesCode.IsForeignKey = false;
				colvarResourcesCode.IsReadOnly = false;
				colvarResourcesCode.DefaultSetting = @"";
				colvarResourcesCode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarResourcesCode);
				
				TableSchema.TableColumn colvarResourcesName = new TableSchema.TableColumn(schema);
				colvarResourcesName.ColumnName = "resourcesName";
				colvarResourcesName.DataType = DbType.AnsiString;
				colvarResourcesName.MaxLength = 50;
				colvarResourcesName.AutoIncrement = false;
				colvarResourcesName.IsNullable = true;
				colvarResourcesName.IsPrimaryKey = false;
				colvarResourcesName.IsForeignKey = false;
				colvarResourcesName.IsReadOnly = false;
				colvarResourcesName.DefaultSetting = @"";
				colvarResourcesName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarResourcesName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_Basis_resource",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Resources")]
		[Bindable(true)]
		public string Resources 
		{
			get { return GetColumnValue<string>(Columns.Resources); }
			set { SetColumnValue(Columns.Resources, value); }
		}
		  
		[XmlAttribute("ResourcesCode")]
		[Bindable(true)]
		public string ResourcesCode 
		{
			get { return GetColumnValue<string>(Columns.ResourcesCode); }
			set { SetColumnValue(Columns.ResourcesCode, value); }
		}
		  
		[XmlAttribute("ResourcesName")]
		[Bindable(true)]
		public string ResourcesName 
		{
			get { return GetColumnValue<string>(Columns.ResourcesName); }
			set { SetColumnValue(Columns.ResourcesName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varResources,string varResourcesCode,string varResourcesName)
		{
			TBasisResource item = new TBasisResource();
			
			item.Resources = varResources;
			
			item.ResourcesCode = varResourcesCode;
			
			item.ResourcesName = varResourcesName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varResources,string varResourcesCode,string varResourcesName)
		{
			TBasisResource item = new TBasisResource();
			
				item.Resources = varResources;
			
				item.ResourcesCode = varResourcesCode;
			
				item.ResourcesName = varResourcesName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ResourcesColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ResourcesCodeColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ResourcesNameColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Resources = @"resources";
			 public static string ResourcesCode = @"resourcesCode";
			 public static string ResourcesName = @"resourcesName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
