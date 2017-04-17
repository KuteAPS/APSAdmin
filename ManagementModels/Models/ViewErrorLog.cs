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
    /// Strongly-typed collection for the ViewErrorLog class.
    /// </summary>
    [Serializable]
    public partial class ViewErrorLogCollection : ReadOnlyList<ViewErrorLog, ViewErrorLogCollection>
    {        
        public ViewErrorLogCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the View_ErrorLogs view.
    /// </summary>
    [Serializable]
    public partial class ViewErrorLog : ReadOnlyRecord<ViewErrorLog>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("View_ErrorLogs", TableType.View, DataService.GetInstance("Nowthwin"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarErrorID = new TableSchema.TableColumn(schema);
                colvarErrorID.ColumnName = "ErrorID";
                colvarErrorID.DataType = DbType.Int32;
                colvarErrorID.MaxLength = 0;
                colvarErrorID.AutoIncrement = false;
                colvarErrorID.IsNullable = false;
                colvarErrorID.IsPrimaryKey = false;
                colvarErrorID.IsForeignKey = false;
                colvarErrorID.IsReadOnly = false;
                
                schema.Columns.Add(colvarErrorID);
                
                TableSchema.TableColumn colvarLogID = new TableSchema.TableColumn(schema);
                colvarLogID.ColumnName = "LogID";
                colvarLogID.DataType = DbType.Int32;
                colvarLogID.MaxLength = 0;
                colvarLogID.AutoIncrement = false;
                colvarLogID.IsNullable = true;
                colvarLogID.IsPrimaryKey = false;
                colvarLogID.IsForeignKey = false;
                colvarLogID.IsReadOnly = false;
                
                schema.Columns.Add(colvarLogID);
                
                TableSchema.TableColumn colvarProject = new TableSchema.TableColumn(schema);
                colvarProject.ColumnName = "project";
                colvarProject.DataType = DbType.String;
                colvarProject.MaxLength = 255;
                colvarProject.AutoIncrement = false;
                colvarProject.IsNullable = true;
                colvarProject.IsPrimaryKey = false;
                colvarProject.IsForeignKey = false;
                colvarProject.IsReadOnly = false;
                
                schema.Columns.Add(colvarProject);
                
                TableSchema.TableColumn colvarContent = new TableSchema.TableColumn(schema);
                colvarContent.ColumnName = "content";
                colvarContent.DataType = DbType.AnsiString;
                colvarContent.MaxLength = 2147483647;
                colvarContent.AutoIncrement = false;
                colvarContent.IsNullable = true;
                colvarContent.IsPrimaryKey = false;
                colvarContent.IsForeignKey = false;
                colvarContent.IsReadOnly = false;
                
                schema.Columns.Add(colvarContent);
                
                TableSchema.TableColumn colvarTyped = new TableSchema.TableColumn(schema);
                colvarTyped.ColumnName = "Typed";
                colvarTyped.DataType = DbType.String;
                colvarTyped.MaxLength = 255;
                colvarTyped.AutoIncrement = false;
                colvarTyped.IsNullable = true;
                colvarTyped.IsPrimaryKey = false;
                colvarTyped.IsForeignKey = false;
                colvarTyped.IsReadOnly = false;
                
                schema.Columns.Add(colvarTyped);
                
                TableSchema.TableColumn colvarCreateTime = new TableSchema.TableColumn(schema);
                colvarCreateTime.ColumnName = "CreateTime";
                colvarCreateTime.DataType = DbType.DateTime;
                colvarCreateTime.MaxLength = 0;
                colvarCreateTime.AutoIncrement = false;
                colvarCreateTime.IsNullable = true;
                colvarCreateTime.IsPrimaryKey = false;
                colvarCreateTime.IsForeignKey = false;
                colvarCreateTime.IsReadOnly = false;
                
                schema.Columns.Add(colvarCreateTime);
                
                TableSchema.TableColumn colvarComtext = new TableSchema.TableColumn(schema);
                colvarComtext.ColumnName = "comtext";
                colvarComtext.DataType = DbType.AnsiString;
                colvarComtext.MaxLength = 2147483647;
                colvarComtext.AutoIncrement = false;
                colvarComtext.IsNullable = true;
                colvarComtext.IsPrimaryKey = false;
                colvarComtext.IsForeignKey = false;
                colvarComtext.IsReadOnly = false;
                
                schema.Columns.Add(colvarComtext);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Nowthwin"].AddSchema("View_ErrorLogs",schema);
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
	    public ViewErrorLog()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewErrorLog(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public ViewErrorLog(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public ViewErrorLog(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("ErrorID")]
        [Bindable(true)]
        public int ErrorID 
	    {
		    get
		    {
			    return GetColumnValue<int>("ErrorID");
		    }
            set 
		    {
			    SetColumnValue("ErrorID", value);
            }
        }
	      
        [XmlAttribute("LogID")]
        [Bindable(true)]
        public int? LogID 
	    {
		    get
		    {
			    return GetColumnValue<int?>("LogID");
		    }
            set 
		    {
			    SetColumnValue("LogID", value);
            }
        }
	      
        [XmlAttribute("Project")]
        [Bindable(true)]
        public string Project 
	    {
		    get
		    {
			    return GetColumnValue<string>("project");
		    }
            set 
		    {
			    SetColumnValue("project", value);
            }
        }
	      
        [XmlAttribute("Content")]
        [Bindable(true)]
        public string Content 
	    {
		    get
		    {
			    return GetColumnValue<string>("content");
		    }
            set 
		    {
			    SetColumnValue("content", value);
            }
        }
	      
        [XmlAttribute("Typed")]
        [Bindable(true)]
        public string Typed 
	    {
		    get
		    {
			    return GetColumnValue<string>("Typed");
		    }
            set 
		    {
			    SetColumnValue("Typed", value);
            }
        }
	      
        [XmlAttribute("CreateTime")]
        [Bindable(true)]
        public DateTime? CreateTime 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("CreateTime");
		    }
            set 
		    {
			    SetColumnValue("CreateTime", value);
            }
        }
	      
        [XmlAttribute("Comtext")]
        [Bindable(true)]
        public string Comtext 
	    {
		    get
		    {
			    return GetColumnValue<string>("comtext");
		    }
            set 
		    {
			    SetColumnValue("comtext", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string ErrorID = @"ErrorID";
            
            public static string LogID = @"LogID";
            
            public static string Project = @"project";
            
            public static string Content = @"content";
            
            public static string Typed = @"Typed";
            
            public static string CreateTime = @"CreateTime";
            
            public static string Comtext = @"comtext";
            
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