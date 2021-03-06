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
    /// Controller class for T_Basis_SpecialList
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TBasisSpecialListController
    {
        // Preload our schema..
        TBasisSpecialList thisSchemaLoad = new TBasisSpecialList();
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
        public TBasisSpecialListCollection FetchAll()
        {
            TBasisSpecialListCollection coll = new TBasisSpecialListCollection();
            Query qry = new Query(TBasisSpecialList.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBasisSpecialListCollection FetchByID(object Id)
        {
            TBasisSpecialListCollection coll = new TBasisSpecialListCollection().Where("id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBasisSpecialListCollection FetchByQuery(Query qry)
        {
            TBasisSpecialListCollection coll = new TBasisSpecialListCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TBasisSpecialList.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TBasisSpecialList.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string SpecialName,string SpecialCode,int? SpecialTime)
	    {
		    TBasisSpecialList item = new TBasisSpecialList();
		    
            item.SpecialName = SpecialName;
            
            item.SpecialCode = SpecialCode;
            
            item.SpecialTime = SpecialTime;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string SpecialName,string SpecialCode,int? SpecialTime)
	    {
		    TBasisSpecialList item = new TBasisSpecialList();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.SpecialName = SpecialName;
				
			item.SpecialCode = SpecialCode;
				
			item.SpecialTime = SpecialTime;
				
	        item.Save(UserName);
	    }
    }
}
