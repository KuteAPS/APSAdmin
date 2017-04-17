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
    /// Strongly-typed collection for the View3 class.
    /// </summary>
    [Serializable]
    public partial class View3Collection : ReadOnlyList<View3, View3Collection>
    {        
        public View3Collection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the View_3 view.
    /// </summary>
    [Serializable]
    public partial class View3 : ReadOnlyRecord<View3>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("View_3", TableType.View, DataService.GetInstance("Nowthwin"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarFzfl = new TableSchema.TableColumn(schema);
                colvarFzfl.ColumnName = "fzfl";
                colvarFzfl.DataType = DbType.String;
                colvarFzfl.MaxLength = 250;
                colvarFzfl.AutoIncrement = false;
                colvarFzfl.IsNullable = true;
                colvarFzfl.IsPrimaryKey = false;
                colvarFzfl.IsForeignKey = false;
                colvarFzfl.IsReadOnly = false;
                
                schema.Columns.Add(colvarFzfl);
                
                TableSchema.TableColumn colvarPkid = new TableSchema.TableColumn(schema);
                colvarPkid.ColumnName = "pkid";
                colvarPkid.DataType = DbType.Int32;
                colvarPkid.MaxLength = 0;
                colvarPkid.AutoIncrement = false;
                colvarPkid.IsNullable = false;
                colvarPkid.IsPrimaryKey = false;
                colvarPkid.IsForeignKey = false;
                colvarPkid.IsReadOnly = false;
                
                schema.Columns.Add(colvarPkid);
                
                TableSchema.TableColumn colvarCustomerId = new TableSchema.TableColumn(schema);
                colvarCustomerId.ColumnName = "customerId";
                colvarCustomerId.DataType = DbType.AnsiString;
                colvarCustomerId.MaxLength = 50;
                colvarCustomerId.AutoIncrement = false;
                colvarCustomerId.IsNullable = true;
                colvarCustomerId.IsPrimaryKey = false;
                colvarCustomerId.IsForeignKey = false;
                colvarCustomerId.IsReadOnly = false;
                
                schema.Columns.Add(colvarCustomerId);
                
                TableSchema.TableColumn colvarBeginTime = new TableSchema.TableColumn(schema);
                colvarBeginTime.ColumnName = "beginTime";
                colvarBeginTime.DataType = DbType.DateTime;
                colvarBeginTime.MaxLength = 0;
                colvarBeginTime.AutoIncrement = false;
                colvarBeginTime.IsNullable = true;
                colvarBeginTime.IsPrimaryKey = false;
                colvarBeginTime.IsForeignKey = false;
                colvarBeginTime.IsReadOnly = false;
                
                schema.Columns.Add(colvarBeginTime);
                
                TableSchema.TableColumn colvarCoatCode = new TableSchema.TableColumn(schema);
                colvarCoatCode.ColumnName = "coatCode";
                colvarCoatCode.DataType = DbType.AnsiString;
                colvarCoatCode.MaxLength = 50;
                colvarCoatCode.AutoIncrement = false;
                colvarCoatCode.IsNullable = true;
                colvarCoatCode.IsPrimaryKey = false;
                colvarCoatCode.IsForeignKey = false;
                colvarCoatCode.IsReadOnly = false;
                
                schema.Columns.Add(colvarCoatCode);
                
                TableSchema.TableColumn colvarNum = new TableSchema.TableColumn(schema);
                colvarNum.ColumnName = "num";
                colvarNum.DataType = DbType.AnsiString;
                colvarNum.MaxLength = 50;
                colvarNum.AutoIncrement = false;
                colvarNum.IsNullable = true;
                colvarNum.IsPrimaryKey = false;
                colvarNum.IsForeignKey = false;
                colvarNum.IsReadOnly = false;
                
                schema.Columns.Add(colvarNum);
                
                TableSchema.TableColumn colvarTypeT = new TableSchema.TableColumn(schema);
                colvarTypeT.ColumnName = "typeT";
                colvarTypeT.DataType = DbType.Int32;
                colvarTypeT.MaxLength = 0;
                colvarTypeT.AutoIncrement = false;
                colvarTypeT.IsNullable = true;
                colvarTypeT.IsPrimaryKey = false;
                colvarTypeT.IsForeignKey = false;
                colvarTypeT.IsReadOnly = false;
                
                schema.Columns.Add(colvarTypeT);
                
                TableSchema.TableColumn colvarGylx = new TableSchema.TableColumn(schema);
                colvarGylx.ColumnName = "gylx";
                colvarGylx.DataType = DbType.AnsiString;
                colvarGylx.MaxLength = -1;
                colvarGylx.AutoIncrement = false;
                colvarGylx.IsNullable = true;
                colvarGylx.IsPrimaryKey = false;
                colvarGylx.IsForeignKey = false;
                colvarGylx.IsReadOnly = false;
                
                schema.Columns.Add(colvarGylx);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Nowthwin"].AddSchema("View_3",schema);
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
	    public View3()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public View3(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public View3(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public View3(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("Fzfl")]
        [Bindable(true)]
        public string Fzfl 
	    {
		    get
		    {
			    return GetColumnValue<string>("fzfl");
		    }
            set 
		    {
			    SetColumnValue("fzfl", value);
            }
        }
	      
        [XmlAttribute("Pkid")]
        [Bindable(true)]
        public int Pkid 
	    {
		    get
		    {
			    return GetColumnValue<int>("pkid");
		    }
            set 
		    {
			    SetColumnValue("pkid", value);
            }
        }
	      
        [XmlAttribute("CustomerId")]
        [Bindable(true)]
        public string CustomerId 
	    {
		    get
		    {
			    return GetColumnValue<string>("customerId");
		    }
            set 
		    {
			    SetColumnValue("customerId", value);
            }
        }
	      
        [XmlAttribute("BeginTime")]
        [Bindable(true)]
        public DateTime? BeginTime 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("beginTime");
		    }
            set 
		    {
			    SetColumnValue("beginTime", value);
            }
        }
	      
        [XmlAttribute("CoatCode")]
        [Bindable(true)]
        public string CoatCode 
	    {
		    get
		    {
			    return GetColumnValue<string>("coatCode");
		    }
            set 
		    {
			    SetColumnValue("coatCode", value);
            }
        }
	      
        [XmlAttribute("Num")]
        [Bindable(true)]
        public string Num 
	    {
		    get
		    {
			    return GetColumnValue<string>("num");
		    }
            set 
		    {
			    SetColumnValue("num", value);
            }
        }
	      
        [XmlAttribute("TypeT")]
        [Bindable(true)]
        public int? TypeT 
	    {
		    get
		    {
			    return GetColumnValue<int?>("typeT");
		    }
            set 
		    {
			    SetColumnValue("typeT", value);
            }
        }
	      
        [XmlAttribute("Gylx")]
        [Bindable(true)]
        public string Gylx 
	    {
		    get
		    {
			    return GetColumnValue<string>("gylx");
		    }
            set 
		    {
			    SetColumnValue("gylx", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Fzfl = @"fzfl";
            
            public static string Pkid = @"pkid";
            
            public static string CustomerId = @"customerId";
            
            public static string BeginTime = @"beginTime";
            
            public static string CoatCode = @"coatCode";
            
            public static string Num = @"num";
            
            public static string TypeT = @"typeT";
            
            public static string Gylx = @"gylx";
            
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
