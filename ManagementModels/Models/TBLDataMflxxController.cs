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
    /// Controller class for T_BLData_Mflxx
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TBLDataMflxxController
    {
        // Preload our schema..
        TBLDataMflxx thisSchemaLoad = new TBLDataMflxx();
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
        public TBLDataMflxxCollection FetchAll()
        {
            TBLDataMflxxCollection coll = new TBLDataMflxxCollection();
            Query qry = new Query(TBLDataMflxx.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBLDataMflxxCollection FetchByID(object Mflxxid)
        {
            TBLDataMflxxCollection coll = new TBLDataMflxxCollection().Where("mflxxid", Mflxxid).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TBLDataMflxxCollection FetchByQuery(Query qry)
        {
            TBLDataMflxxCollection coll = new TBLDataMflxxCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Mflxxid)
        {
            return (TBLDataMflxx.Delete(Mflxxid) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Mflxxid)
        {
            return (TBLDataMflxx.Destroy(Mflxxid) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? Mxid,string Orderid,string Khdh,string Ylbm,string Mtml,string Yllx,string Yllxmc,int? FlagDelete)
	    {
		    TBLDataMflxx item = new TBLDataMflxx();
		    
            item.Mxid = Mxid;
            
            item.Orderid = Orderid;
            
            item.Khdh = Khdh;
            
            item.Ylbm = Ylbm;
            
            item.Mtml = Mtml;
            
            item.Yllx = Yllx;
            
            item.Yllxmc = Yllxmc;
            
            item.FlagDelete = FlagDelete;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Mflxxid,int? Mxid,string Orderid,string Khdh,string Ylbm,string Mtml,string Yllx,string Yllxmc,int? FlagDelete)
	    {
		    TBLDataMflxx item = new TBLDataMflxx();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Mflxxid = Mflxxid;
				
			item.Mxid = Mxid;
				
			item.Orderid = Orderid;
				
			item.Khdh = Khdh;
				
			item.Ylbm = Ylbm;
				
			item.Mtml = Mtml;
				
			item.Yllx = Yllx;
				
			item.Yllxmc = Yllxmc;
				
			item.FlagDelete = FlagDelete;
				
	        item.Save(UserName);
	    }
    }
}
