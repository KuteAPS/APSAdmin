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
    /// Strongly-typed collection for the VUser class.
    /// </summary>
    [Serializable]
    public partial class VUserCollection : ReadOnlyList<VUser, VUserCollection>
    {        
        public VUserCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the V_Users view.
    /// </summary>
    [Serializable]
    public partial class VUser : ReadOnlyRecord<VUser>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("V_Users", TableType.View, DataService.GetInstance("Nowthwin"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
                colvarId.ColumnName = "ID";
                colvarId.DataType = DbType.Int32;
                colvarId.MaxLength = 0;
                colvarId.AutoIncrement = false;
                colvarId.IsNullable = false;
                colvarId.IsPrimaryKey = false;
                colvarId.IsForeignKey = false;
                colvarId.IsReadOnly = false;
                
                schema.Columns.Add(colvarId);
                
                TableSchema.TableColumn colvarUserName = new TableSchema.TableColumn(schema);
                colvarUserName.ColumnName = "UserName";
                colvarUserName.DataType = DbType.String;
                colvarUserName.MaxLength = 20;
                colvarUserName.AutoIncrement = false;
                colvarUserName.IsNullable = false;
                colvarUserName.IsPrimaryKey = false;
                colvarUserName.IsForeignKey = false;
                colvarUserName.IsReadOnly = false;
                
                schema.Columns.Add(colvarUserName);
                
                TableSchema.TableColumn colvarUserPwd = new TableSchema.TableColumn(schema);
                colvarUserPwd.ColumnName = "UserPwd";
                colvarUserPwd.DataType = DbType.String;
                colvarUserPwd.MaxLength = 50;
                colvarUserPwd.AutoIncrement = false;
                colvarUserPwd.IsNullable = false;
                colvarUserPwd.IsPrimaryKey = false;
                colvarUserPwd.IsForeignKey = false;
                colvarUserPwd.IsReadOnly = false;
                
                schema.Columns.Add(colvarUserPwd);
                
                TableSchema.TableColumn colvarEmail = new TableSchema.TableColumn(schema);
                colvarEmail.ColumnName = "Email";
                colvarEmail.DataType = DbType.String;
                colvarEmail.MaxLength = 100;
                colvarEmail.AutoIncrement = false;
                colvarEmail.IsNullable = true;
                colvarEmail.IsPrimaryKey = false;
                colvarEmail.IsForeignKey = false;
                colvarEmail.IsReadOnly = false;
                
                schema.Columns.Add(colvarEmail);
                
                TableSchema.TableColumn colvarTelphone = new TableSchema.TableColumn(schema);
                colvarTelphone.ColumnName = "Telphone";
                colvarTelphone.DataType = DbType.String;
                colvarTelphone.MaxLength = 20;
                colvarTelphone.AutoIncrement = false;
                colvarTelphone.IsNullable = true;
                colvarTelphone.IsPrimaryKey = false;
                colvarTelphone.IsForeignKey = false;
                colvarTelphone.IsReadOnly = false;
                
                schema.Columns.Add(colvarTelphone);
                
                TableSchema.TableColumn colvarAccount = new TableSchema.TableColumn(schema);
                colvarAccount.ColumnName = "Account";
                colvarAccount.DataType = DbType.String;
                colvarAccount.MaxLength = 255;
                colvarAccount.AutoIncrement = false;
                colvarAccount.IsNullable = false;
                colvarAccount.IsPrimaryKey = false;
                colvarAccount.IsForeignKey = false;
                colvarAccount.IsReadOnly = false;
                
                schema.Columns.Add(colvarAccount);
                
                TableSchema.TableColumn colvarSecurityLock = new TableSchema.TableColumn(schema);
                colvarSecurityLock.ColumnName = "SecurityLock";
                colvarSecurityLock.DataType = DbType.Int32;
                colvarSecurityLock.MaxLength = 0;
                colvarSecurityLock.AutoIncrement = false;
                colvarSecurityLock.IsNullable = false;
                colvarSecurityLock.IsPrimaryKey = false;
                colvarSecurityLock.IsForeignKey = false;
                colvarSecurityLock.IsReadOnly = false;
                
                schema.Columns.Add(colvarSecurityLock);
                
                TableSchema.TableColumn colvarHavingPage = new TableSchema.TableColumn(schema);
                colvarHavingPage.ColumnName = "HavingPage";
                colvarHavingPage.DataType = DbType.String;
                colvarHavingPage.MaxLength = -1;
                colvarHavingPage.AutoIncrement = false;
                colvarHavingPage.IsNullable = true;
                colvarHavingPage.IsPrimaryKey = false;
                colvarHavingPage.IsForeignKey = false;
                colvarHavingPage.IsReadOnly = false;
                
                schema.Columns.Add(colvarHavingPage);
                
                TableSchema.TableColumn colvarGroupLock = new TableSchema.TableColumn(schema);
                colvarGroupLock.ColumnName = "GroupLock";
                colvarGroupLock.DataType = DbType.Int32;
                colvarGroupLock.MaxLength = 0;
                colvarGroupLock.AutoIncrement = false;
                colvarGroupLock.IsNullable = true;
                colvarGroupLock.IsPrimaryKey = false;
                colvarGroupLock.IsForeignKey = false;
                colvarGroupLock.IsReadOnly = false;
                
                schema.Columns.Add(colvarGroupLock);
                
                TableSchema.TableColumn colvarGroupName = new TableSchema.TableColumn(schema);
                colvarGroupName.ColumnName = "GroupName";
                colvarGroupName.DataType = DbType.String;
                colvarGroupName.MaxLength = 255;
                colvarGroupName.AutoIncrement = false;
                colvarGroupName.IsNullable = true;
                colvarGroupName.IsPrimaryKey = false;
                colvarGroupName.IsForeignKey = false;
                colvarGroupName.IsReadOnly = false;
                
                schema.Columns.Add(colvarGroupName);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Nowthwin"].AddSchema("V_Users",schema);
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
	    public VUser()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VUser(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VUser(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VUser(string columnName, object columnValue)
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
			    return GetColumnValue<int>("ID");
		    }
            set 
		    {
			    SetColumnValue("ID", value);
            }
        }
	      
        [XmlAttribute("UserName")]
        [Bindable(true)]
        public string UserName 
	    {
		    get
		    {
			    return GetColumnValue<string>("UserName");
		    }
            set 
		    {
			    SetColumnValue("UserName", value);
            }
        }
	      
        [XmlAttribute("UserPwd")]
        [Bindable(true)]
        public string UserPwd 
	    {
		    get
		    {
			    return GetColumnValue<string>("UserPwd");
		    }
            set 
		    {
			    SetColumnValue("UserPwd", value);
            }
        }
	      
        [XmlAttribute("Email")]
        [Bindable(true)]
        public string Email 
	    {
		    get
		    {
			    return GetColumnValue<string>("Email");
		    }
            set 
		    {
			    SetColumnValue("Email", value);
            }
        }
	      
        [XmlAttribute("Telphone")]
        [Bindable(true)]
        public string Telphone 
	    {
		    get
		    {
			    return GetColumnValue<string>("Telphone");
		    }
            set 
		    {
			    SetColumnValue("Telphone", value);
            }
        }
	      
        [XmlAttribute("Account")]
        [Bindable(true)]
        public string Account 
	    {
		    get
		    {
			    return GetColumnValue<string>("Account");
		    }
            set 
		    {
			    SetColumnValue("Account", value);
            }
        }
	      
        [XmlAttribute("SecurityLock")]
        [Bindable(true)]
        public int SecurityLock 
	    {
		    get
		    {
			    return GetColumnValue<int>("SecurityLock");
		    }
            set 
		    {
			    SetColumnValue("SecurityLock", value);
            }
        }
	      
        [XmlAttribute("HavingPage")]
        [Bindable(true)]
        public string HavingPage 
	    {
		    get
		    {
			    return GetColumnValue<string>("HavingPage");
		    }
            set 
		    {
			    SetColumnValue("HavingPage", value);
            }
        }
	      
        [XmlAttribute("GroupLock")]
        [Bindable(true)]
        public int? GroupLock 
	    {
		    get
		    {
			    return GetColumnValue<int?>("GroupLock");
		    }
            set 
		    {
			    SetColumnValue("GroupLock", value);
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
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Id = @"ID";
            
            public static string UserName = @"UserName";
            
            public static string UserPwd = @"UserPwd";
            
            public static string Email = @"Email";
            
            public static string Telphone = @"Telphone";
            
            public static string Account = @"Account";
            
            public static string SecurityLock = @"SecurityLock";
            
            public static string HavingPage = @"HavingPage";
            
            public static string GroupLock = @"GroupLock";
            
            public static string GroupName = @"GroupName";
            
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
