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
    /// Controller class for T_Basis_SystemManageBox
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TBasisSystemManageBoxController
    {
        // Preload our schema..
        TBasisSystemManageBox thisSchemaLoad = new TBasisSystemManageBox();
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
        public TBasisSystemManageBoxCollection FetchAll()
        {
            TBasisSystemManageBoxCollection coll = new TBasisSystemManageBoxCollection();
            Query qry = new Query(TBasisSystemManageBox.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBasisSystemManageBoxCollection FetchByID(object Id)
        {
            TBasisSystemManageBoxCollection coll = new TBasisSystemManageBoxCollection().Where("id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBasisSystemManageBoxCollection FetchByQuery(Query qry)
        {
            TBasisSystemManageBoxCollection coll = new TBasisSystemManageBoxCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TBasisSystemManageBox.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TBasisSystemManageBox.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int SendUserId,int RecipientUserID,string Title,string Content,int Reding,int SendState,DateTime CreateTime)
	    {
		    TBasisSystemManageBox item = new TBasisSystemManageBox();
		    
            item.SendUserId = SendUserId;
            
            item.RecipientUserID = RecipientUserID;
            
            item.Title = Title;
            
            item.Content = Content;
            
            item.Reding = Reding;
            
            item.SendState = SendState;
            
            item.CreateTime = CreateTime;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,int SendUserId,int RecipientUserID,string Title,string Content,int Reding,int SendState,DateTime CreateTime)
	    {
		    TBasisSystemManageBox item = new TBasisSystemManageBox();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.SendUserId = SendUserId;
				
			item.RecipientUserID = RecipientUserID;
				
			item.Title = Title;
				
			item.Content = Content;
				
			item.Reding = Reding;
				
			item.SendState = SendState;
				
			item.CreateTime = CreateTime;
				
	        item.Save(UserName);
	    }
    }
}
