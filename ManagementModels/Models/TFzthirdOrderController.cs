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
    /// Controller class for T_fzthirdOrder
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TFzthirdOrderController
    {
        // Preload our schema..
        TFzthirdOrder thisSchemaLoad = new TFzthirdOrder();
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
        public TFzthirdOrderCollection FetchAll()
        {
            TFzthirdOrderCollection coll = new TFzthirdOrderCollection();
            Query qry = new Query(TFzthirdOrder.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TFzthirdOrderCollection FetchByID(object OrderId)
        {
            TFzthirdOrderCollection coll = new TFzthirdOrderCollection().Where("orderId", OrderId).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TFzthirdOrderCollection FetchByQuery(Query qry)
        {
            TFzthirdOrderCollection coll = new TFzthirdOrderCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object OrderId)
        {
            return (TFzthirdOrder.Delete(OrderId) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object OrderId)
        {
            return (TFzthirdOrder.Destroy(OrderId) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string OrderId,string CustomerId,string OrderType,string CoatType,string BodyType,string Fabric,string Mflxx,DateTime? OrderTime,DateTime? DeliveryTime,int? SpecialTime,string SpecialCode,string Styles,string StylesResult,int? Numbers,string SupportingWay,string Sizes,string Customer,DateTime? CreateTime,DateTime? CreateDate,string Pbcd,string Gydm,DateTime? Audittime,string Sfbcpsy,string Tzecode,string Scggdh,string ValueX,string Time)
	    {
		    TFzthirdOrder item = new TFzthirdOrder();
		    
            item.OrderId = OrderId;
            
            item.CustomerId = CustomerId;
            
            item.OrderType = OrderType;
            
            item.CoatType = CoatType;
            
            item.BodyType = BodyType;
            
            item.Fabric = Fabric;
            
            item.Mflxx = Mflxx;
            
            item.OrderTime = OrderTime;
            
            item.DeliveryTime = DeliveryTime;
            
            item.SpecialTime = SpecialTime;
            
            item.SpecialCode = SpecialCode;
            
            item.Styles = Styles;
            
            item.StylesResult = StylesResult;
            
            item.Numbers = Numbers;
            
            item.SupportingWay = SupportingWay;
            
            item.Sizes = Sizes;
            
            item.Customer = Customer;
            
            item.CreateTime = CreateTime;
            
            item.CreateDate = CreateDate;
            
            item.Pbcd = Pbcd;
            
            item.Gydm = Gydm;
            
            item.Audittime = Audittime;
            
            item.Sfbcpsy = Sfbcpsy;
            
            item.Tzecode = Tzecode;
            
            item.Scggdh = Scggdh;
            
            item.ValueX = ValueX;
            
            item.Time = Time;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string OrderId,string CustomerId,string OrderType,string CoatType,string BodyType,string Fabric,string Mflxx,DateTime? OrderTime,DateTime? DeliveryTime,int? SpecialTime,string SpecialCode,string Styles,string StylesResult,int? Numbers,string SupportingWay,string Sizes,string Customer,DateTime? CreateTime,DateTime? CreateDate,string Pbcd,string Gydm,DateTime? Audittime,string Sfbcpsy,string Tzecode,string Scggdh,string ValueX,string Time)
	    {
		    TFzthirdOrder item = new TFzthirdOrder();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.OrderId = OrderId;
				
			item.CustomerId = CustomerId;
				
			item.OrderType = OrderType;
				
			item.CoatType = CoatType;
				
			item.BodyType = BodyType;
				
			item.Fabric = Fabric;
				
			item.Mflxx = Mflxx;
				
			item.OrderTime = OrderTime;
				
			item.DeliveryTime = DeliveryTime;
				
			item.SpecialTime = SpecialTime;
				
			item.SpecialCode = SpecialCode;
				
			item.Styles = Styles;
				
			item.StylesResult = StylesResult;
				
			item.Numbers = Numbers;
				
			item.SupportingWay = SupportingWay;
				
			item.Sizes = Sizes;
				
			item.Customer = Customer;
				
			item.CreateTime = CreateTime;
				
			item.CreateDate = CreateDate;
				
			item.Pbcd = Pbcd;
				
			item.Gydm = Gydm;
				
			item.Audittime = Audittime;
				
			item.Sfbcpsy = Sfbcpsy;
				
			item.Tzecode = Tzecode;
				
			item.Scggdh = Scggdh;
				
			item.ValueX = ValueX;
				
			item.Time = Time;
				
	        item.Save(UserName);
	    }
    }
}
