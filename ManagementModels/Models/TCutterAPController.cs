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
    /// Controller class for T_CutterAPS
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TCutterAPController
    {
        // Preload our schema..
        TCutterAP thisSchemaLoad = new TCutterAP();
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
        public TCutterAPCollection FetchAll()
        {
            TCutterAPCollection coll = new TCutterAPCollection();
            Query qry = new Query(TCutterAP.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TCutterAPCollection FetchByID(object Pid)
        {
            TCutterAPCollection coll = new TCutterAPCollection().Where("pid", Pid).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TCutterAPCollection FetchByQuery(Query qry)
        {
            TCutterAPCollection coll = new TCutterAPCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Pid)
        {
            return (TCutterAP.Delete(Pid) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Pid)
        {
            return (TCutterAP.Destroy(Pid) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? Apsid,int? Planmid,int? Plansid,string Sczsbh,string Filename,int? Cutternum,int? Cutcount,string Cutdate,string Cuttime,DateTime? Opdate,string Barcode,string Filestatus,string Matstatus,string Matlength,string Cutstatus,DateTime? Statusdate,string Syncd,DateTime? Stime,string PbcdName,DateTime? FirstTime)
	    {
		    TCutterAP item = new TCutterAP();
		    
            item.Apsid = Apsid;
            
            item.Planmid = Planmid;
            
            item.Plansid = Plansid;
            
            item.Sczsbh = Sczsbh;
            
            item.Filename = Filename;
            
            item.Cutternum = Cutternum;
            
            item.Cutcount = Cutcount;
            
            item.Cutdate = Cutdate;
            
            item.Cuttime = Cuttime;
            
            item.Opdate = Opdate;
            
            item.Barcode = Barcode;
            
            item.Filestatus = Filestatus;
            
            item.Matstatus = Matstatus;
            
            item.Matlength = Matlength;
            
            item.Cutstatus = Cutstatus;
            
            item.Statusdate = Statusdate;
            
            item.Syncd = Syncd;
            
            item.Stime = Stime;
            
            item.PbcdName = PbcdName;
            
            item.FirstTime = FirstTime;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int? Apsid,int? Planmid,int? Plansid,string Sczsbh,string Filename,int? Cutternum,int? Cutcount,string Cutdate,string Cuttime,DateTime? Opdate,string Barcode,string Filestatus,string Matstatus,string Matlength,string Cutstatus,DateTime? Statusdate,string Syncd,DateTime? Stime,int Pid,string PbcdName,DateTime? FirstTime)
	    {
		    TCutterAP item = new TCutterAP();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Apsid = Apsid;
				
			item.Planmid = Planmid;
				
			item.Plansid = Plansid;
				
			item.Sczsbh = Sczsbh;
				
			item.Filename = Filename;
				
			item.Cutternum = Cutternum;
				
			item.Cutcount = Cutcount;
				
			item.Cutdate = Cutdate;
				
			item.Cuttime = Cuttime;
				
			item.Opdate = Opdate;
				
			item.Barcode = Barcode;
				
			item.Filestatus = Filestatus;
				
			item.Matstatus = Matstatus;
				
			item.Matlength = Matlength;
				
			item.Cutstatus = Cutstatus;
				
			item.Statusdate = Statusdate;
				
			item.Syncd = Syncd;
				
			item.Stime = Stime;
				
			item.Pid = Pid;
				
			item.PbcdName = PbcdName;
				
			item.FirstTime = FirstTime;
				
	        item.Save(UserName);
	    }
    }
}
