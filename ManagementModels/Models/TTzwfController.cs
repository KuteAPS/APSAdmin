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
    /// Controller class for T_TZWF
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TTzwfController
    {
        // Preload our schema..
        TTzwf thisSchemaLoad = new TTzwf();
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
        public TTzwfCollection FetchAll()
        {
            TTzwfCollection coll = new TTzwfCollection();
            Query qry = new Query(TTzwf.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TTzwfCollection FetchByID(object Tzwfks)
        {
            TTzwfCollection coll = new TTzwfCollection().Where("tzwfks", Tzwfks).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TTzwfCollection FetchByQuery(Query qry)
        {
            TTzwfCollection coll = new TTzwfCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Tzwfks)
        {
            return (TTzwf.Delete(Tzwfks) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Tzwfks)
        {
            return (TTzwf.Destroy(Tzwfks) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Tzwfks)
	    {
		    TTzwf item = new TTzwf();
		    
            item.Tzwfks = Tzwfks;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Tzwfks)
	    {
		    TTzwf item = new TTzwf();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Tzwfks = Tzwfks;
				
	        item.Save(UserName);
	    }
    }
}
