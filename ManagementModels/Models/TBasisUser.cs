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
	/// Strongly-typed collection for the TBasisUser class.
	/// </summary>
    [Serializable]
	public partial class TBasisUserCollection : ActiveList<TBasisUser, TBasisUserCollection>
	{	   
		public TBasisUserCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TBasisUserCollection</returns>
		public TBasisUserCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TBasisUser o = this[i];
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
	/// This is an ActiveRecord class which wraps the T_Basis_Users table.
	/// </summary>
	[Serializable]
	public partial class TBasisUser : ActiveRecord<TBasisUser>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TBasisUser()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TBasisUser(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TBasisUser(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TBasisUser(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("T_Basis_Users", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "ID";
				colvarId.DataType = DbType.Int32;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = true;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = false;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
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
				colvarUserName.DefaultSetting = @"";
				colvarUserName.ForeignKeyTableName = "";
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
				colvarUserPwd.DefaultSetting = @"";
				colvarUserPwd.ForeignKeyTableName = "";
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
				colvarEmail.DefaultSetting = @"";
				colvarEmail.ForeignKeyTableName = "";
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
				colvarTelphone.DefaultSetting = @"";
				colvarTelphone.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTelphone);
				
				TableSchema.TableColumn colvarAccount = new TableSchema.TableColumn(schema);
				colvarAccount.ColumnName = "Account";
				colvarAccount.DataType = DbType.String;
				colvarAccount.MaxLength = 255;
				colvarAccount.AutoIncrement = false;
				colvarAccount.IsNullable = false;
				colvarAccount.IsPrimaryKey = true;
				colvarAccount.IsForeignKey = false;
				colvarAccount.IsReadOnly = false;
				colvarAccount.DefaultSetting = @"";
				colvarAccount.ForeignKeyTableName = "";
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
				
						colvarSecurityLock.DefaultSetting = @"((0))";
				colvarSecurityLock.ForeignKeyTableName = "";
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
				colvarHavingPage.DefaultSetting = @"";
				colvarHavingPage.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHavingPage);
				
				TableSchema.TableColumn colvarUsersGroup = new TableSchema.TableColumn(schema);
				colvarUsersGroup.ColumnName = "UsersGroup";
				colvarUsersGroup.DataType = DbType.Int32;
				colvarUsersGroup.MaxLength = 0;
				colvarUsersGroup.AutoIncrement = false;
				colvarUsersGroup.IsNullable = false;
				colvarUsersGroup.IsPrimaryKey = false;
				colvarUsersGroup.IsForeignKey = false;
				colvarUsersGroup.IsReadOnly = false;
				colvarUsersGroup.DefaultSetting = @"";
				colvarUsersGroup.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUsersGroup);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_Basis_Users",schema);
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
		  
		[XmlAttribute("UserName")]
		[Bindable(true)]
		public string UserName 
		{
			get { return GetColumnValue<string>(Columns.UserName); }
			set { SetColumnValue(Columns.UserName, value); }
		}
		  
		[XmlAttribute("UserPwd")]
		[Bindable(true)]
		public string UserPwd 
		{
			get { return GetColumnValue<string>(Columns.UserPwd); }
			set { SetColumnValue(Columns.UserPwd, value); }
		}
		  
		[XmlAttribute("Email")]
		[Bindable(true)]
		public string Email 
		{
			get { return GetColumnValue<string>(Columns.Email); }
			set { SetColumnValue(Columns.Email, value); }
		}
		  
		[XmlAttribute("Telphone")]
		[Bindable(true)]
		public string Telphone 
		{
			get { return GetColumnValue<string>(Columns.Telphone); }
			set { SetColumnValue(Columns.Telphone, value); }
		}
		  
		[XmlAttribute("Account")]
		[Bindable(true)]
		public string Account 
		{
			get { return GetColumnValue<string>(Columns.Account); }
			set { SetColumnValue(Columns.Account, value); }
		}
		  
		[XmlAttribute("SecurityLock")]
		[Bindable(true)]
		public int SecurityLock 
		{
			get { return GetColumnValue<int>(Columns.SecurityLock); }
			set { SetColumnValue(Columns.SecurityLock, value); }
		}
		  
		[XmlAttribute("HavingPage")]
		[Bindable(true)]
		public string HavingPage 
		{
			get { return GetColumnValue<string>(Columns.HavingPage); }
			set { SetColumnValue(Columns.HavingPage, value); }
		}
		  
		[XmlAttribute("UsersGroup")]
		[Bindable(true)]
		public int UsersGroup 
		{
			get { return GetColumnValue<int>(Columns.UsersGroup); }
			set { SetColumnValue(Columns.UsersGroup, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varUserName,string varUserPwd,string varEmail,string varTelphone,string varAccount,int varSecurityLock,string varHavingPage,int varUsersGroup)
		{
			TBasisUser item = new TBasisUser();
			
			item.UserName = varUserName;
			
			item.UserPwd = varUserPwd;
			
			item.Email = varEmail;
			
			item.Telphone = varTelphone;
			
			item.Account = varAccount;
			
			item.SecurityLock = varSecurityLock;
			
			item.HavingPage = varHavingPage;
			
			item.UsersGroup = varUsersGroup;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varUserName,string varUserPwd,string varEmail,string varTelphone,string varAccount,int varSecurityLock,string varHavingPage,int varUsersGroup)
		{
			TBasisUser item = new TBasisUser();
			
				item.Id = varId;
			
				item.UserName = varUserName;
			
				item.UserPwd = varUserPwd;
			
				item.Email = varEmail;
			
				item.Telphone = varTelphone;
			
				item.Account = varAccount;
			
				item.SecurityLock = varSecurityLock;
			
				item.HavingPage = varHavingPage;
			
				item.UsersGroup = varUsersGroup;
			
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
        
        
        
        public static TableSchema.TableColumn UserNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn UserPwdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn EmailColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn TelphoneColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn AccountColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn SecurityLockColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn HavingPageColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn UsersGroupColumn
        {
            get { return Schema.Columns[8]; }
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
			 public static string UsersGroup = @"UsersGroup";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
