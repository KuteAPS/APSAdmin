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
    /// Controller class for T_ClientType
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TClientTypeController
    {
        // Preload our schema..
        TClientType thisSchemaLoad = new TClientType();
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
        public TClientTypeCollection FetchAll()
        {
            TClientTypeCollection coll = new TClientTypeCollection();
            Query qry = new Query(TClientType.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TClientTypeCollection FetchByID(object Id)
        {
            TClientTypeCollection coll = new TClientTypeCollection().Where("id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TClientTypeCollection FetchByQuery(Query qry)
        {
            TClientTypeCollection coll = new TClientTypeCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TClientType.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TClientType.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string LineName,string TypeNames,int? TypeValues,int? Type)
	    {
		    TClientType item = new TClientType();
		    
            item.LineName = LineName;
            
            item.TypeNames = TypeNames;
            
            item.TypeValues = TypeValues;
            
            item.Type = Type;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string LineName,string TypeNames,int? TypeValues,int? Type)
	    {
		    TClientType item = new TClientType();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.LineName = LineName;
				
			item.TypeNames = TypeNames;
				
			item.TypeValues = TypeValues;
				
			item.Type = Type;
				
	        item.Save(UserName);
	    }
    }
}
