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
namespace Models{
    /// <summary>
    /// Strongly-typed collection for the VGroupWeb class.
    /// </summary>
    [Serializable]
    public partial class VGroupWebCollection : ReadOnlyList<VGroupWeb, VGroupWebCollection>
    {        
        public VGroupWebCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the V_GroupWebs view.
    /// </summary>
    [Serializable]
    public partial class VGroupWeb : ReadOnlyRecord<VGroupWeb>, IReadOnlyRecord
    {
    
	    #region Default Settings
	    protected static void SetSQLProps() 
	    {
		    GetTableSchema();
	    }
	    #endregion
        #region Schema Accessor
	    public static TableSchema.Table Schema
        {
            get
            {
                if (BaseSchema == null)
                {
                    SetSQLProps();
                }
                return BaseSchema;
            }
        }
    	
        private static void GetTableSchema() 
        {
            if(!IsSchemaInitialized)
            {
                //Schema declaration
                TableSchema.Table schema = new TableSchema.Table("V_GroupWebs", TableType.View, DataService.GetInstance("Nowthwin"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
                colvarId.ColumnName = "id";
                colvarId.DataType = DbType.Int32;
                colvarId.MaxLength = 0;
                colvarId.AutoIncrement = false;
                colvarId.IsNullable = false;
                colvarId.IsPrimaryKey = false;
                colvarId.IsForeignKey = false;
                colvarId.IsReadOnly = false;
                
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
                
                schema.Columns.Add(colvarPageName);
                
                TableSchema.TableColumn colvarGroupName = new TableSchema.TableColumn(schema);
                colvarGroupName.ColumnName = "GroupName";
                colvarGroupName.DataType = DbType.String;
                colvarGroupName.MaxLength = 100;
                colvarGroupName.AutoIncrement = false;
                colvarGroupName.IsNullable = false;
                colvarGroupName.IsPrimaryKey = false;
                colvarGroupName.IsForeignKey = false;
                colvarGroupName.IsReadOnly = false;
                
                schema.Columns.Add(colvarGroupName);
                
                TableSchema.TableColumn colvarGroupIcon = new TableSchema.TableColumn(schema);
                colvarGroupIcon.ColumnName = "GroupIcon";
                colvarGroupIcon.DataType = DbType.String;
                colvarGroupIcon.MaxLength = 100;
                colvarGroupIcon.AutoIncrement = false;
                colvarGroupIcon.IsNullable = false;
                colvarGroupIcon.IsPrimaryKey = false;
                colvarGroupIcon.IsForeignKey = false;
                colvarGroupIcon.IsReadOnly = false;
                
                schema.Columns.Add(colvarGroupIcon);
                
                TableSchema.TableColumn colvarPageUrl = new TableSchema.TableColumn(schema);
                colvarPageUrl.ColumnName = "PageUrl";
                colvarPageUrl.DataType = DbType.String;
                colvarPageUrl.MaxLength = 255;
                colvarPageUrl.AutoIncrement = false;
                colvarPageUrl.IsNullable = true;
                colvarPageUrl.IsPrimaryKey = false;
                colvarPageUrl.IsForeignKey = false;
                colvarPageUrl.IsReadOnly = false;
                
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
                
                schema.Columns.Add(colvarJurisdiction);
                
                TableSchema.TableColumn colvarShowMenu = new TableSchema.TableColumn(schema);
                colvarShowMenu.ColumnName = "ShowMenu";
                colvarShowMenu.DataType = DbType.Int32;
                colvarShowMenu.MaxLength = 0;
                colvarShowMenu.AutoIncrement = false;
                colvarShowMenu.IsNullable = true;
                colvarShowMenu.IsPrimaryKey = false;
                colvarShowMenu.IsForeignKey = false;
                colvarShowMenu.IsReadOnly = false;
                
                schema.Columns.Add(colvarShowMenu);
                
                TableSchema.TableColumn colvarSort = new TableSchema.TableColumn(schema);
                colvarSort.ColumnName = "sort";
                colvarSort.DataType = DbType.Int32;
                colvarSort.MaxLength = 0;
                colvarSort.AutoIncrement = false;
                colvarSort.IsNullable = true;
                colvarSort.IsPrimaryKey = false;
                colvarSort.IsForeignKey = false;
                colvarSort.IsReadOnly = false;
                
                schema.Columns.Add(colvarSort);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Nowthwin"].AddSchema("V_GroupWebs",schema);
            }
        }
        #endregion
        
        #region Query Accessor
	    public static Query CreateQuery()
	    {
		    return new Query(Schema);
	    }
	    #endregion
	    
	    #region .ctors
	    public VGroupWeb()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VGroupWeb(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VGroupWeb(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VGroupWeb(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("Id")]
        [Bindable(true)]
        public int Id 
	    {
		    get
		    {
			    return GetColumnValue<int>("id");
		    }
            set 
		    {
			    SetColumnValue("id", value);
            }
        }
	      
        [XmlAttribute("PageName")]
        [Bindable(true)]
        public string PageName 
	    {
		    get
		    {
			    return GetColumnValue<string>("PageName");
		    }
            set 
		    {
			    SetColumnValue("PageName", value);
            }
        }
	      
        [XmlAttribute("GroupName")]
        [Bindable(true)]
        public string GroupName 
	    {
		    get
		    {
			    return GetColumnValue<string>("GroupName");
		    }
            set 
		    {
			    SetColumnValue("GroupName", value);
            }
        }
	      
        [XmlAttribute("GroupIcon")]
        [Bindable(true)]
        public string GroupIcon 
	    {
		    get
		    {
			    return GetColumnValue<string>("GroupIcon");
		    }
            set 
		    {
			    SetColumnValue("GroupIcon", value);
            }
        }
	      
        [XmlAttribute("PageUrl")]
        [Bindable(true)]
        public string PageUrl 
	    {
		    get
		    {
			    return GetColumnValue<string>("PageUrl");
		    }
            set 
		    {
			    SetColumnValue("PageUrl", value);
            }
        }
	      
        [XmlAttribute("Locked")]
        [Bindable(true)]
        public int Locked 
	    {
		    get
		    {
			    return GetColumnValue<int>("Locked");
		    }
            set 
		    {
			    SetColumnValue("Locked", value);
            }
        }
	      
        [XmlAttribute("Jurisdiction")]
        [Bindable(true)]
        public int? Jurisdiction 
	    {
		    get
		    {
			    return GetColumnValue<int?>("Jurisdiction");
		    }
            set 
		    {
			    SetColumnValue("Jurisdiction", value);
            }
        }
	      
        [XmlAttribute("ShowMenu")]
        [Bindable(true)]
        public int? ShowMenu 
	    {
		    get
		    {
			    return GetColumnValue<int?>("ShowMenu");
		    }
            set 
		    {
			    SetColumnValue("ShowMenu", value);
            }
        }
	      
        [XmlAttribute("Sort")]
        [Bindable(true)]
        public int? Sort 
	    {
		    get
		    {
			    return GetColumnValue<int?>("sort");
		    }
            set 
		    {
			    SetColumnValue("sort", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Id = @"id";
            
            public static string PageName = @"PageName";
            
            public static string GroupName = @"GroupName";
            
            public static string GroupIcon = @"GroupIcon";
            
            public static string PageUrl = @"PageUrl";
            
            public static string Locked = @"Locked";
            
            public static string Jurisdiction = @"Jurisdiction";
            
            public static string ShowMenu = @"ShowMenu";
            
            public static string Sort = @"sort";
            
	    }
	    #endregion
	    
	    
	    #region IAbstractRecord Members
        public new CT GetColumnValue<CT>(string columnName) {
            return base.GetColumnValue<CT>(columnName);
        }
        public object GetColumnValue(string columnName) {
            return base.GetColumnValue<object>(columnName);
        }
        #endregion
	    
    }
}