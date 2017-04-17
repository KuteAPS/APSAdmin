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
    /// Controller class for T_Basis_CoatList
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TBasisCoatListController
    {
        // Preload our schema..
        TBasisCoatList thisSchemaLoad = new TBasisCoatList();
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
        public TBasisCoatListCollection FetchAll()
        {
            TBasisCoatListCollection coll = new TBasisCoatListCollection();
            Query qry = new Query(TBasisCoatList.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBasisCoatListCollection FetchByID(object Id)
        {
            TBasisCoatListCollection coll = new TBasisCoatListCollection().Where("id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBasisCoatListCollection FetchByQuery(Query qry)
        {
            TBasisCoatListCollection coll = new TBasisCoatListCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TBasisCoatList.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TBasisCoatList.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string CoatName,string CoatCode,int? CoatSign,string CoatAlias)
	    {
		    TBasisCoatList item = new TBasisCoatList();
		    
            item.CoatName = CoatName;
            
            item.CoatCode = CoatCode;
            
            item.CoatSign = CoatSign;
            
            item.CoatAlias = CoatAlias;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string CoatName,string CoatCode,int? CoatSign,string CoatAlias)
	    {
		    TBasisCoatList item = new TBasisCoatList();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.CoatName = CoatName;
				
			item.CoatCode = CoatCode;
				
			item.CoatSign = CoatSign;
				
			item.CoatAlias = CoatAlias;
				
	        item.Save(UserName);
	    }
    }
}
