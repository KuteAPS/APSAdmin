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
    /// Controller class for T_Basis_BodyList
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TBasisBodyListController
    {
        // Preload our schema..
        TBasisBodyList thisSchemaLoad = new TBasisBodyList();
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
        public TBasisBodyListCollection FetchAll()
        {
            TBasisBodyListCollection coll = new TBasisBodyListCollection();
            Query qry = new Query(TBasisBodyList.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBasisBodyListCollection FetchByID(object Id)
        {
            TBasisBodyListCollection coll = new TBasisBodyListCollection().Where("id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBasisBodyListCollection FetchByQuery(Query qry)
        {
            TBasisBodyListCollection coll = new TBasisBodyListCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TBasisBodyList.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TBasisBodyList.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string BodyCode,string BodyName,string BodyTypeCode,string BodyTypeName,double? Efficiency,string AliasX)
	    {
		    TBasisBodyList item = new TBasisBodyList();
		    
            item.BodyCode = BodyCode;
            
            item.BodyName = BodyName;
            
            item.BodyTypeCode = BodyTypeCode;
            
            item.BodyTypeName = BodyTypeName;
            
            item.Efficiency = Efficiency;
            
            item.AliasX = AliasX;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string BodyCode,string BodyName,string BodyTypeCode,string BodyTypeName,double? Efficiency,string AliasX)
	    {
		    TBasisBodyList item = new TBasisBodyList();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.BodyCode = BodyCode;
				
			item.BodyName = BodyName;
				
			item.BodyTypeCode = BodyTypeCode;
				
			item.BodyTypeName = BodyTypeName;
				
			item.Efficiency = Efficiency;
				
			item.AliasX = AliasX;
				
	        item.Save(UserName);
	    }
    }
}
