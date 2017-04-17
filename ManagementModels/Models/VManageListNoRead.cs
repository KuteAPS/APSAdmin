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
    /// Strongly-typed collection for the VManageListNoRead class.
    /// </summary>
    [Serializable]
    public partial class VManageListNoReadCollection : ReadOnlyList<VManageListNoRead, VManageListNoReadCollection>
    {        
        public VManageListNoReadCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the V_ManageListNoRead view.
    /// </summary>
    [Serializable]
    public partial class VManageListNoRead : ReadOnlyRecord<VManageListNoRead>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("V_ManageListNoRead", TableType.View, DataService.GetInstance("Nowthwin"));
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
                
                TableSchema.TableColumn colvarSendUser = new TableSchema.TableColumn(schema);
                colvarSendUser.ColumnName = "SendUser";
                colvarSendUser.DataType = DbType.String;
                colvarSendUser.MaxLength = 20;
                colvarSendUser.AutoIncrement = false;
                colvarSendUser.IsNullable = true;
                colvarSendUser.IsPrimaryKey = false;
                colvarSendUser.IsForeignKey = false;
                colvarSendUser.IsReadOnly = false;
                
                schema.Columns.Add(colvarSendUser);
                
                TableSchema.TableColumn colvarRecipientUserID = new TableSchema.TableColumn(schema);
                colvarRecipientUserID.ColumnName = "RecipientUserID";
                colvarRecipientUserID.DataType = DbType.Int32;
                colvarRecipientUserID.MaxLength = 0;
                colvarRecipientUserID.AutoIncrement = false;
                colvarRecipientUserID.IsNullable = false;
                colvarRecipientUserID.IsPrimaryKey = false;
                colvarRecipientUserID.IsForeignKey = false;
                colvarRecipientUserID.IsReadOnly = false;
                
                schema.Columns.Add(colvarRecipientUserID);
                
                TableSchema.TableColumn colvarTitle = new TableSchema.TableColumn(schema);
                colvarTitle.ColumnName = "Title";
                colvarTitle.DataType = DbType.String;
                colvarTitle.MaxLength = 500;
                colvarTitle.AutoIncrement = false;
                colvarTitle.IsNullable = false;
                colvarTitle.IsPrimaryKey = false;
                colvarTitle.IsForeignKey = false;
                colvarTitle.IsReadOnly = false;
                
                schema.Columns.Add(colvarTitle);
                
                TableSchema.TableColumn colvarReding = new TableSchema.TableColumn(schema);
                colvarReding.ColumnName = "Reding";
                colvarReding.DataType = DbType.Int32;
                colvarReding.MaxLength = 0;
                colvarReding.AutoIncrement = false;
                colvarReding.IsNullable = false;
                colvarReding.IsPrimaryKey = false;
                colvarReding.IsForeignKey = false;
                colvarReding.IsReadOnly = false;
                
                schema.Columns.Add(colvarReding);
                
                TableSchema.TableColumn colvarSendState = new TableSchema.TableColumn(schema);
                colvarSendState.ColumnName = "SendState";
                colvarSendState.DataType = DbType.Int32;
                colvarSendState.MaxLength = 0;
                colvarSendState.AutoIncrement = false;
                colvarSendState.IsNullable = false;
                colvarSendState.IsPrimaryKey = false;
                colvarSendState.IsForeignKey = false;
                colvarSendState.IsReadOnly = false;
                
                schema.Columns.Add(colvarSendState);
                
                TableSchema.TableColumn colvarCreateTime = new TableSchema.TableColumn(schema);
                colvarCreateTime.ColumnName = "CreateTime";
                colvarCreateTime.DataType = DbType.DateTime;
                colvarCreateTime.MaxLength = 0;
                colvarCreateTime.AutoIncrement = false;
                colvarCreateTime.IsNullable = false;
                colvarCreateTime.IsPrimaryKey = false;
                colvarCreateTime.IsForeignKey = false;
                colvarCreateTime.IsReadOnly = false;
                
                schema.Columns.Add(colvarCreateTime);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Nowthwin"].AddSchema("V_ManageListNoRead",schema);
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
	    public VManageListNoRead()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VManageListNoRead(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VManageListNoRead(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VManageListNoRead(string columnName, object columnValue)
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
	      
        [XmlAttribute("SendUser")]
        [Bindable(true)]
        public string SendUser 
	    {
		    get
		    {
			    return GetColumnValue<string>("SendUser");
		    }
            set 
		    {
			    SetColumnValue("SendUser", value);
            }
        }
	      
        [XmlAttribute("RecipientUserID")]
        [Bindable(true)]
        public int RecipientUserID 
	    {
		    get
		    {
			    return GetColumnValue<int>("RecipientUserID");
		    }
            set 
		    {
			    SetColumnValue("RecipientUserID", value);
            }
        }
	      
        [XmlAttribute("Title")]
        [Bindable(true)]
        public string Title 
	    {
		    get
		    {
			    return GetColumnValue<string>("Title");
		    }
            set 
		    {
			    SetColumnValue("Title", value);
            }
        }
	      
        [XmlAttribute("Reding")]
        [Bindable(true)]
        public int Reding 
	    {
		    get
		    {
			    return GetColumnValue<int>("Reding");
		    }
            set 
		    {
			    SetColumnValue("Reding", value);
            }
        }
	      
        [XmlAttribute("SendState")]
        [Bindable(true)]
        public int SendState 
	    {
		    get
		    {
			    return GetColumnValue<int>("SendState");
		    }
            set 
		    {
			    SetColumnValue("SendState", value);
            }
        }
	      
        [XmlAttribute("CreateTime")]
        [Bindable(true)]
        public DateTime CreateTime 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("CreateTime");
		    }
            set 
		    {
			    SetColumnValue("CreateTime", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Id = @"id";
            
            public static string SendUser = @"SendUser";
            
            public static string RecipientUserID = @"RecipientUserID";
            
            public static string Title = @"Title";
            
            public static string Reding = @"Reding";
            
            public static string SendState = @"SendState";
            
            public static string CreateTime = @"CreateTime";
            
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
