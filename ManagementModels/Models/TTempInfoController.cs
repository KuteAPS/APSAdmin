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
    /// Controller class for T_TempInfo
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TTempInfoController
    {
        // Preload our schema..
        TTempInfo thisSchemaLoad = new TTempInfo();
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
        public TTempInfoCollection FetchAll()
        {
            TTempInfoCollection coll = new TTempInfoCollection();
            Query qry = new Query(TTempInfo.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TTempInfoCollection FetchByID(object Id)
        {
            TTempInfoCollection coll = new TTempInfoCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TTempInfoCollection FetchByQuery(Query qry)
        {
            TTempInfoCollection coll = new TTempInfoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TTempInfo.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TTempInfo.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string IpAdress,int? Cutternum,string Sczsbh,string Khdhxh,string Khdh,string Gyfl,string Sldl,int? Wlxh,string Wlbm,string Wlbmbz,string Wlbmdh,string Wlhy,string Wlfk,string Tgsx,string Tgkd,string Wlbw,string Wlcd,string Czry,string Wltm,string Cutetime,string Apsid,string ReMark,DateTime? Sccjjq,DateTime? Sctcrq,string Scfzxh)
	    {
		    TTempInfo item = new TTempInfo();
		    
            item.IpAdress = IpAdress;
            
            item.Cutternum = Cutternum;
            
            item.Sczsbh = Sczsbh;
            
            item.Khdhxh = Khdhxh;
            
            item.Khdh = Khdh;
            
            item.Gyfl = Gyfl;
            
            item.Sldl = Sldl;
            
            item.Wlxh = Wlxh;
            
            item.Wlbm = Wlbm;
            
            item.Wlbmbz = Wlbmbz;
            
            item.Wlbmdh = Wlbmdh;
            
            item.Wlhy = Wlhy;
            
            item.Wlfk = Wlfk;
            
            item.Tgsx = Tgsx;
            
            item.Tgkd = Tgkd;
            
            item.Wlbw = Wlbw;
            
            item.Wlcd = Wlcd;
            
            item.Czry = Czry;
            
            item.Wltm = Wltm;
            
            item.Cutetime = Cutetime;
            
            item.Apsid = Apsid;
            
            item.ReMark = ReMark;
            
            item.Sccjjq = Sccjjq;
            
            item.Sctcrq = Sctcrq;
            
            item.Scfzxh = Scfzxh;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string IpAdress,int? Cutternum,string Sczsbh,string Khdhxh,string Khdh,string Gyfl,string Sldl,int? Wlxh,string Wlbm,string Wlbmbz,string Wlbmdh,string Wlhy,string Wlfk,string Tgsx,string Tgkd,string Wlbw,string Wlcd,string Czry,string Wltm,string Cutetime,string Apsid,string ReMark,DateTime? Sccjjq,DateTime? Sctcrq,string Scfzxh)
	    {
		    TTempInfo item = new TTempInfo();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.IpAdress = IpAdress;
				
			item.Cutternum = Cutternum;
				
			item.Sczsbh = Sczsbh;
				
			item.Khdhxh = Khdhxh;
				
			item.Khdh = Khdh;
				
			item.Gyfl = Gyfl;
				
			item.Sldl = Sldl;
				
			item.Wlxh = Wlxh;
				
			item.Wlbm = Wlbm;
				
			item.Wlbmbz = Wlbmbz;
				
			item.Wlbmdh = Wlbmdh;
				
			item.Wlhy = Wlhy;
				
			item.Wlfk = Wlfk;
				
			item.Tgsx = Tgsx;
				
			item.Tgkd = Tgkd;
				
			item.Wlbw = Wlbw;
				
			item.Wlcd = Wlcd;
				
			item.Czry = Czry;
				
			item.Wltm = Wltm;
				
			item.Cutetime = Cutetime;
				
			item.Apsid = Apsid;
				
			item.ReMark = ReMark;
				
			item.Sccjjq = Sccjjq;
				
			item.Sctcrq = Sctcrq;
				
			item.Scfzxh = Scfzxh;
				
	        item.Save(UserName);
	    }
    }
}
