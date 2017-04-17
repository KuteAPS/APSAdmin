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
    /// Controller class for T_TempMES
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TTempMEController
    {
        // Preload our schema..
        TTempME thisSchemaLoad = new TTempME();
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
        public TTempMECollection FetchAll()
        {
            TTempMECollection coll = new TTempMECollection();
            Query qry = new Query(TTempME.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TTempMECollection FetchByID(object Scggdh)
        {
            TTempMECollection coll = new TTempMECollection().Where("SCGGDH", Scggdh).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TTempMECollection FetchByQuery(Query qry)
        {
            TTempMECollection coll = new TTempMECollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Scggdh)
        {
            return (TTempME.Delete(Scggdh) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Scggdh)
        {
            return (TTempME.Destroy(Scggdh) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Sczsbh,string Scggdh,string Khddbh,int? Pcccbh,string Pcccsj,DateTime? Sccjjq,DateTime? Scjhrq,string Sclsbh,string Scfzxh,string Status,string Wrong)
	    {
		    TTempME item = new TTempME();
		    
            item.Sczsbh = Sczsbh;
            
            item.Scggdh = Scggdh;
            
            item.Khddbh = Khddbh;
            
            item.Pcccbh = Pcccbh;
            
            item.Pcccsj = Pcccsj;
            
            item.Sccjjq = Sccjjq;
            
            item.Scjhrq = Scjhrq;
            
            item.Sclsbh = Sclsbh;
            
            item.Scfzxh = Scfzxh;
            
            item.Status = Status;
            
            item.Wrong = Wrong;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string Sczsbh,string Scggdh,string Khddbh,int? Pcccbh,string Pcccsj,DateTime? Sccjjq,DateTime? Scjhrq,string Sclsbh,string Scfzxh,string Status,string Wrong)
	    {
		    TTempME item = new TTempME();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Sczsbh = Sczsbh;
				
			item.Scggdh = Scggdh;
				
			item.Khddbh = Khddbh;
				
			item.Pcccbh = Pcccbh;
				
			item.Pcccsj = Pcccsj;
				
			item.Sccjjq = Sccjjq;
				
			item.Scjhrq = Scjhrq;
				
			item.Sclsbh = Sclsbh;
				
			item.Scfzxh = Scfzxh;
				
			item.Status = Status;
				
			item.Wrong = Wrong;
				
	        item.Save(UserName);
	    }
    }
}