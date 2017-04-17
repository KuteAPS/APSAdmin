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
	/// Strongly-typed collection for the TBasisCoatList class.
	/// </summary>
    [Serializable]
	public partial class TBasisCoatListCollection : ActiveList<TBasisCoatList, TBasisCoatListCollection>
	{	   
		public TBasisCoatListCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TBasisCoatListCollection</returns>
		public TBasisCoatListCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TBasisCoatList o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_Basis_CoatList table.
	/// </summary>
	[Serializable]
	public partial class TBasisCoatList : ActiveRecord<TBasisCoatList>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TBasisCoatList()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TBasisCoatList(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TBasisCoatList(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TBasisCoatList(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_Basis_CoatList", TableType.Table, DataService.GetInstance("Nowthwin"));
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
				
				TableSchema.TableColumn colvarCoatName = new TableSchema.TableColumn(schema);
				colvarCoatName.ColumnName = "coatName";
				colvarCoatName.DataType = DbType.String;
				colvarCoatName.MaxLength = 50;
				colvarCoatName.AutoIncrement = false;
				colvarCoatName.IsNullable = true;
				colvarCoatName.IsPrimaryKey = false;
				colvarCoatName.IsForeignKey = false;
				colvarCoatName.IsReadOnly = false;
				colvarCoatName.DefaultSetting = @"";
				colvarCoatName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCoatName);
				
				TableSchema.TableColumn colvarCoatCode = new TableSchema.TableColumn(schema);
				colvarCoatCode.ColumnName = "coatCode";
				colvarCoatCode.DataType = DbType.String;
				colvarCoatCode.MaxLength = 50;
				colvarCoatCode.AutoIncrement = false;
				colvarCoatCode.IsNullable = true;
				colvarCoatCode.IsPrimaryKey = false;
				colvarCoatCode.IsForeignKey = false;
				colvarCoatCode.IsReadOnly = false;
				colvarCoatCode.DefaultSetting = @"";
				colvarCoatCode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCoatCode);
				
				TableSchema.TableColumn colvarCoatSign = new TableSchema.TableColumn(schema);
				colvarCoatSign.ColumnName = "coatSign";
				colvarCoatSign.DataType = DbType.Int32;
				colvarCoatSign.MaxLength = 0;
				colvarCoatSign.AutoIncrement = false;
				colvarCoatSign.IsNullable = true;
				colvarCoatSign.IsPrimaryKey = false;
				colvarCoatSign.IsForeignKey = false;
				colvarCoatSign.IsReadOnly = false;
				colvarCoatSign.DefaultSetting = @"";
				colvarCoatSign.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCoatSign);
				
				TableSchema.TableColumn colvarCoatAlias = new TableSchema.TableColumn(schema);
				colvarCoatAlias.ColumnName = "coatAlias";
				colvarCoatAlias.DataType = DbType.String;
				colvarCoatAlias.MaxLength = 50;
				colvarCoatAlias.AutoIncrement = false;
				colvarCoatAlias.IsNullable = true;
				colvarCoatAlias.IsPrimaryKey = false;
				colvarCoatAlias.IsForeignKey = false;
				colvarCoatAlias.IsReadOnly = false;
				colvarCoatAlias.DefaultSetting = @"";
				colvarCoatAlias.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCoatAlias);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_Basis_CoatList",schema);
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
		  
		[XmlAttribute("CoatName")]
		[Bindable(true)]
		public string CoatName 
		{
			get { return GetColumnValue<string>(Columns.CoatName); }
			set { SetColumnValue(Columns.CoatName, value); }
		}
		  
		[XmlAttribute("CoatCode")]
		[Bindable(true)]
		public string CoatCode 
		{
			get { return GetColumnValue<string>(Columns.CoatCode); }
			set { SetColumnValue(Columns.CoatCode, value); }
		}
		  
		[XmlAttribute("CoatSign")]
		[Bindable(true)]
		public int? CoatSign 
		{
			get { return GetColumnValue<int?>(Columns.CoatSign); }
			set { SetColumnValue(Columns.CoatSign, value); }
		}
		  
		[XmlAttribute("CoatAlias")]
		[Bindable(true)]
		public string CoatAlias 
		{
			get { return GetColumnValue<string>(Columns.CoatAlias); }
			set { SetColumnValue(Columns.CoatAlias, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varCoatName,string varCoatCode,int? varCoatSign,string varCoatAlias)
		{
			TBasisCoatList item = new TBasisCoatList();
			
			item.CoatName = varCoatName;
			
			item.CoatCode = varCoatCode;
			
			item.CoatSign = varCoatSign;
			
			item.CoatAlias = varCoatAlias;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varCoatName,string varCoatCode,int? varCoatSign,string varCoatAlias)
		{
			TBasisCoatList item = new TBasisCoatList();
			
				item.Id = varId;
			
				item.CoatName = varCoatName;
			
				item.CoatCode = varCoatCode;
			
				item.CoatSign = varCoatSign;
			
				item.CoatAlias = varCoatAlias;
			
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
        
        
        
        public static TableSchema.TableColumn CoatNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn CoatCodeColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn CoatSignColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn CoatAliasColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"id";
			 public static string CoatName = @"coatName";
			 public static string CoatCode = @"coatCode";
			 public static string CoatSign = @"coatSign";
			 public static string CoatAlias = @"coatAlias";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
