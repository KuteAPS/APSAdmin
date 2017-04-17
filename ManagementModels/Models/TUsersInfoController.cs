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
    /// Controller class for T_UsersInfo
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TUsersInfoController
    {
        // Preload our schema..
        TUsersInfo thisSchemaLoad = new TUsersInfo();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public TUsersInfoCollection FetchAll()
        {
            TUsersInfoCollection coll = new TUsersInfoCollection();
            Query qry = new Query(TUsersInfo.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TUsersInfoCollection FetchByID(object Id)
        {
            TUsersInfoCollection coll = new TUsersInfoCollection().Where("id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TUsersInfoCollection FetchByQuery(Query qry)
        {
            TUsersInfoCollection coll = new TUsersInfoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TUsersInfo.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TUsersInfo.Destroy(Id) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(int Id,string UserName)
        {
            Query qry = new Query(TUsersInfo.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("Id", Id).AND("UserName", UserName);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string UserName,string UserPwd,int? IsLock,DateTime? LoginLastTime,string MenberType,string HavingPage)
	    {
		    TUsersInfo item = new TUsersInfo();
		    
            item.UserName = UserName;
            
            item.UserPwd = UserPwd;
            
            item.IsLock = IsLock;
            
            item.LoginLastTime = LoginLastTime;
            
            item.MenberType = MenberType;
            
            item.HavingPage = HavingPage;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string UserName,string UserPwd,int? IsLock,DateTime? LoginLastTime,string MenberType,string HavingPage)
	    {
		    TUsersInfo item = new TUsersInfo();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.UserName = UserName;
				
			item.UserPwd = UserPwd;
				
			item.IsLock = IsLock;
				
			item.LoginLastTime = LoginLastTime;
				
			item.MenberType = MenberType;
				
			item.HavingPage = HavingPage;
				
	        item.Save(UserName);
	    }
    }
}