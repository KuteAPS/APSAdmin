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
    /// Controller class for T_FZsecondOut
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TFZsecondOutController
    {
        // Preload our schema..
        TFZsecondOut thisSchemaLoad = new TFZsecondOut();
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
        public TFZsecondOutCollection FetchAll()
        {
            TFZsecondOutCollection coll = new TFZsecondOutCollection();
            Query qry = new Query(TFZsecondOut.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TFZsecondOutCollection FetchByID(object PkId)
        {
            TFZsecondOutCollection coll = new TFZsecondOutCollection().Where("pkId", PkId).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TFZsecondOutCollection FetchByQuery(Query qry)
        {
            TFZsecondOutCollection coll = new TFZsecondOutCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object PkId)
        {
            return (TFZsecondOut.Delete(PkId) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object PkId)
        {
            return (TFZsecondOut.Destroy(PkId) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int PkId,string CustomerId,DateTime? BeginTime,DateTime? EndTime,string Gylx,string CoatCode,string Resoure,int? TypeT,string Num,string Fzx)
	    {
		    TFZsecondOut item = new TFZsecondOut();
		    
            item.PkId = PkId;
            
            item.CustomerId = CustomerId;
            
            item.BeginTime = BeginTime;
            
            item.EndTime = EndTime;
            
            item.Gylx = Gylx;
            
            item.CoatCode = CoatCode;
            
            item.Resoure = Resoure;
            
            item.TypeT = TypeT;
            
            item.Num = Num;
            
            item.Fzx = Fzx;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int PkId,string CustomerId,DateTime? BeginTime,DateTime? EndTime,string Gylx,string CoatCode,string Resoure,int? TypeT,string Num,string Fzx)
	    {
		    TFZsecondOut item = new TFZsecondOut();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.PkId = PkId;
				
			item.CustomerId = CustomerId;
				
			item.BeginTime = BeginTime;
				
			item.EndTime = EndTime;
				
			item.Gylx = Gylx;
				
			item.CoatCode = CoatCode;
				
			item.Resoure = Resoure;
				
			item.TypeT = TypeT;
				
			item.Num = Num;
				
			item.Fzx = Fzx;
				
	        item.Save(UserName);
	    }
    }
}
