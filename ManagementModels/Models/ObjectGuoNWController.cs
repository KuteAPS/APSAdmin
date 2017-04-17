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
    /// Controller class for ObjectGuoNW
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class ObjectGuoNWController
    {
        // Preload our schema..
        ObjectGuoNW thisSchemaLoad = new ObjectGuoNW();
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
        public ObjectGuoNWCollection FetchAll()
        {
            ObjectGuoNWCollection coll = new ObjectGuoNWCollection();
            Query qry = new Query(ObjectGuoNW.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public ObjectGuoNWCollection FetchByID(object CustomerId)
        {
            ObjectGuoNWCollection coll = new ObjectGuoNWCollection().Where("CustomerId", CustomerId).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public ObjectGuoNWCollection FetchByQuery(Query qry)
        {
            ObjectGuoNWCollection coll = new ObjectGuoNWCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object CustomerId)
        {
            return (ObjectGuoNW.Delete(CustomerId) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object CustomerId)
        {
            return (ObjectGuoNW.Destroy(CustomerId) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string CustomerId)
	    {
		    ObjectGuoNW item = new ObjectGuoNW();
		    
            item.CustomerId = CustomerId;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string CustomerId)
	    {
		    ObjectGuoNW item = new ObjectGuoNW();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.CustomerId = CustomerId;
				
	        item.Save(UserName);
	    }
    }
}
