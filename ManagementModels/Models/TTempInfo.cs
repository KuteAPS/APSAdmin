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
	/// Strongly-typed collection for the TTempInfo class.
	/// </summary>
    [Serializable]
	public partial class TTempInfoCollection : ActiveList<TTempInfo, TTempInfoCollection>
	{	   
		public TTempInfoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TTempInfoCollection</returns>
		public TTempInfoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TTempInfo o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the T_TempInfo table.
	/// </summary>
	[Serializable]
	public partial class TTempInfo : ActiveRecord<TTempInfo>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TTempInfo()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TTempInfo(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TTempInfo(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TTempInfo(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("T_TempInfo", TableType.Table, DataService.GetInstance("Nowthwin"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "ID";
				colvarId.DataType = DbType.Int32;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = true;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = true;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarIpAdress = new TableSchema.TableColumn(schema);
				colvarIpAdress.ColumnName = "IpAdress";
				colvarIpAdress.DataType = DbType.AnsiString;
				colvarIpAdress.MaxLength = 16;
				colvarIpAdress.AutoIncrement = false;
				colvarIpAdress.IsNullable = true;
				colvarIpAdress.IsPrimaryKey = false;
				colvarIpAdress.IsForeignKey = false;
				colvarIpAdress.IsReadOnly = false;
				colvarIpAdress.DefaultSetting = @"";
				colvarIpAdress.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIpAdress);
				
				TableSchema.TableColumn colvarCutternum = new TableSchema.TableColumn(schema);
				colvarCutternum.ColumnName = "CUTTERNUM";
				colvarCutternum.DataType = DbType.Int32;
				colvarCutternum.MaxLength = 0;
				colvarCutternum.AutoIncrement = false;
				colvarCutternum.IsNullable = true;
				colvarCutternum.IsPrimaryKey = false;
				colvarCutternum.IsForeignKey = false;
				colvarCutternum.IsReadOnly = false;
				colvarCutternum.DefaultSetting = @"";
				colvarCutternum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCutternum);
				
				TableSchema.TableColumn colvarSczsbh = new TableSchema.TableColumn(schema);
				colvarSczsbh.ColumnName = "SCZSBH";
				colvarSczsbh.DataType = DbType.AnsiString;
				colvarSczsbh.MaxLength = 12;
				colvarSczsbh.AutoIncrement = false;
				colvarSczsbh.IsNullable = true;
				colvarSczsbh.IsPrimaryKey = false;
				colvarSczsbh.IsForeignKey = false;
				colvarSczsbh.IsReadOnly = false;
				colvarSczsbh.DefaultSetting = @"";
				colvarSczsbh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSczsbh);
				
				TableSchema.TableColumn colvarKhdhxh = new TableSchema.TableColumn(schema);
				colvarKhdhxh.ColumnName = "KHDHXH";
				colvarKhdhxh.DataType = DbType.AnsiString;
				colvarKhdhxh.MaxLength = 20;
				colvarKhdhxh.AutoIncrement = false;
				colvarKhdhxh.IsNullable = true;
				colvarKhdhxh.IsPrimaryKey = false;
				colvarKhdhxh.IsForeignKey = false;
				colvarKhdhxh.IsReadOnly = false;
				colvarKhdhxh.DefaultSetting = @"";
				colvarKhdhxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKhdhxh);
				
				TableSchema.TableColumn colvarKhdh = new TableSchema.TableColumn(schema);
				colvarKhdh.ColumnName = "KHDH";
				colvarKhdh.DataType = DbType.AnsiString;
				colvarKhdh.MaxLength = 30;
				colvarKhdh.AutoIncrement = false;
				colvarKhdh.IsNullable = true;
				colvarKhdh.IsPrimaryKey = false;
				colvarKhdh.IsForeignKey = false;
				colvarKhdh.IsReadOnly = false;
				colvarKhdh.DefaultSetting = @"";
				colvarKhdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKhdh);
				
				TableSchema.TableColumn colvarGyfl = new TableSchema.TableColumn(schema);
				colvarGyfl.ColumnName = "GYFL";
				colvarGyfl.DataType = DbType.AnsiString;
				colvarGyfl.MaxLength = 30;
				colvarGyfl.AutoIncrement = false;
				colvarGyfl.IsNullable = true;
				colvarGyfl.IsPrimaryKey = false;
				colvarGyfl.IsForeignKey = false;
				colvarGyfl.IsReadOnly = false;
				colvarGyfl.DefaultSetting = @"";
				colvarGyfl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGyfl);
				
				TableSchema.TableColumn colvarSldl = new TableSchema.TableColumn(schema);
				colvarSldl.ColumnName = "SLDL";
				colvarSldl.DataType = DbType.AnsiString;
				colvarSldl.MaxLength = 30;
				colvarSldl.AutoIncrement = false;
				colvarSldl.IsNullable = true;
				colvarSldl.IsPrimaryKey = false;
				colvarSldl.IsForeignKey = false;
				colvarSldl.IsReadOnly = false;
				colvarSldl.DefaultSetting = @"";
				colvarSldl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSldl);
				
				TableSchema.TableColumn colvarWlxh = new TableSchema.TableColumn(schema);
				colvarWlxh.ColumnName = "WLXH";
				colvarWlxh.DataType = DbType.Int32;
				colvarWlxh.MaxLength = 0;
				colvarWlxh.AutoIncrement = false;
				colvarWlxh.IsNullable = true;
				colvarWlxh.IsPrimaryKey = false;
				colvarWlxh.IsForeignKey = false;
				colvarWlxh.IsReadOnly = false;
				colvarWlxh.DefaultSetting = @"";
				colvarWlxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlxh);
				
				TableSchema.TableColumn colvarWlbm = new TableSchema.TableColumn(schema);
				colvarWlbm.ColumnName = "WLBM";
				colvarWlbm.DataType = DbType.AnsiString;
				colvarWlbm.MaxLength = 50;
				colvarWlbm.AutoIncrement = false;
				colvarWlbm.IsNullable = true;
				colvarWlbm.IsPrimaryKey = false;
				colvarWlbm.IsForeignKey = false;
				colvarWlbm.IsReadOnly = false;
				colvarWlbm.DefaultSetting = @"";
				colvarWlbm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlbm);
				
				TableSchema.TableColumn colvarWlbmbz = new TableSchema.TableColumn(schema);
				colvarWlbmbz.ColumnName = "WLBMBZ";
				colvarWlbmbz.DataType = DbType.AnsiString;
				colvarWlbmbz.MaxLength = 2;
				colvarWlbmbz.AutoIncrement = false;
				colvarWlbmbz.IsNullable = true;
				colvarWlbmbz.IsPrimaryKey = false;
				colvarWlbmbz.IsForeignKey = false;
				colvarWlbmbz.IsReadOnly = false;
				colvarWlbmbz.DefaultSetting = @"";
				colvarWlbmbz.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlbmbz);
				
				TableSchema.TableColumn colvarWlbmdh = new TableSchema.TableColumn(schema);
				colvarWlbmdh.ColumnName = "WLBMDH";
				colvarWlbmdh.DataType = DbType.AnsiString;
				colvarWlbmdh.MaxLength = 20;
				colvarWlbmdh.AutoIncrement = false;
				colvarWlbmdh.IsNullable = true;
				colvarWlbmdh.IsPrimaryKey = false;
				colvarWlbmdh.IsForeignKey = false;
				colvarWlbmdh.IsReadOnly = false;
				colvarWlbmdh.DefaultSetting = @"";
				colvarWlbmdh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlbmdh);
				
				TableSchema.TableColumn colvarWlhy = new TableSchema.TableColumn(schema);
				colvarWlhy.ColumnName = "WLHY";
				colvarWlhy.DataType = DbType.AnsiString;
				colvarWlhy.MaxLength = 20;
				colvarWlhy.AutoIncrement = false;
				colvarWlhy.IsNullable = true;
				colvarWlhy.IsPrimaryKey = false;
				colvarWlhy.IsForeignKey = false;
				colvarWlhy.IsReadOnly = false;
				colvarWlhy.DefaultSetting = @"";
				colvarWlhy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlhy);
				
				TableSchema.TableColumn colvarWlfk = new TableSchema.TableColumn(schema);
				colvarWlfk.ColumnName = "WLFK";
				colvarWlfk.DataType = DbType.AnsiString;
				colvarWlfk.MaxLength = 20;
				colvarWlfk.AutoIncrement = false;
				colvarWlfk.IsNullable = true;
				colvarWlfk.IsPrimaryKey = false;
				colvarWlfk.IsForeignKey = false;
				colvarWlfk.IsReadOnly = false;
				colvarWlfk.DefaultSetting = @"";
				colvarWlfk.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlfk);
				
				TableSchema.TableColumn colvarTgsx = new TableSchema.TableColumn(schema);
				colvarTgsx.ColumnName = "TGSX";
				colvarTgsx.DataType = DbType.AnsiString;
				colvarTgsx.MaxLength = 30;
				colvarTgsx.AutoIncrement = false;
				colvarTgsx.IsNullable = true;
				colvarTgsx.IsPrimaryKey = false;
				colvarTgsx.IsForeignKey = false;
				colvarTgsx.IsReadOnly = false;
				colvarTgsx.DefaultSetting = @"";
				colvarTgsx.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTgsx);
				
				TableSchema.TableColumn colvarTgkd = new TableSchema.TableColumn(schema);
				colvarTgkd.ColumnName = "TGKD";
				colvarTgkd.DataType = DbType.AnsiString;
				colvarTgkd.MaxLength = 20;
				colvarTgkd.AutoIncrement = false;
				colvarTgkd.IsNullable = true;
				colvarTgkd.IsPrimaryKey = false;
				colvarTgkd.IsForeignKey = false;
				colvarTgkd.IsReadOnly = false;
				colvarTgkd.DefaultSetting = @"";
				colvarTgkd.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTgkd);
				
				TableSchema.TableColumn colvarWlbw = new TableSchema.TableColumn(schema);
				colvarWlbw.ColumnName = "WLBW";
				colvarWlbw.DataType = DbType.AnsiString;
				colvarWlbw.MaxLength = 60;
				colvarWlbw.AutoIncrement = false;
				colvarWlbw.IsNullable = true;
				colvarWlbw.IsPrimaryKey = false;
				colvarWlbw.IsForeignKey = false;
				colvarWlbw.IsReadOnly = false;
				colvarWlbw.DefaultSetting = @"";
				colvarWlbw.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlbw);
				
				TableSchema.TableColumn colvarWlcd = new TableSchema.TableColumn(schema);
				colvarWlcd.ColumnName = "WLCD";
				colvarWlcd.DataType = DbType.AnsiString;
				colvarWlcd.MaxLength = 20;
				colvarWlcd.AutoIncrement = false;
				colvarWlcd.IsNullable = true;
				colvarWlcd.IsPrimaryKey = false;
				colvarWlcd.IsForeignKey = false;
				colvarWlcd.IsReadOnly = false;
				colvarWlcd.DefaultSetting = @"";
				colvarWlcd.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWlcd);
				
				TableSchema.TableColumn colvarCzry = new TableSchema.TableColumn(schema);
				colvarCzry.ColumnName = "CZRY";
				colvarCzry.DataType = DbType.AnsiString;
				colvarCzry.MaxLength = 20;
				colvarCzry.AutoIncrement = false;
				colvarCzry.IsNullable = true;
				colvarCzry.IsPrimaryKey = false;
				colvarCzry.IsForeignKey = false;
				colvarCzry.IsReadOnly = false;
				colvarCzry.DefaultSetting = @"";
				colvarCzry.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCzry);
				
				TableSchema.TableColumn colvarWltm = new TableSchema.TableColumn(schema);
				colvarWltm.ColumnName = "WLTM";
				colvarWltm.DataType = DbType.AnsiString;
				colvarWltm.MaxLength = 80;
				colvarWltm.AutoIncrement = false;
				colvarWltm.IsNullable = true;
				colvarWltm.IsPrimaryKey = false;
				colvarWltm.IsForeignKey = false;
				colvarWltm.IsReadOnly = false;
				colvarWltm.DefaultSetting = @"";
				colvarWltm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWltm);
				
				TableSchema.TableColumn colvarCutetime = new TableSchema.TableColumn(schema);
				colvarCutetime.ColumnName = "CUTETIME";
				colvarCutetime.DataType = DbType.AnsiString;
				colvarCutetime.MaxLength = 22;
				colvarCutetime.AutoIncrement = false;
				colvarCutetime.IsNullable = true;
				colvarCutetime.IsPrimaryKey = false;
				colvarCutetime.IsForeignKey = false;
				colvarCutetime.IsReadOnly = false;
				colvarCutetime.DefaultSetting = @"";
				colvarCutetime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCutetime);
				
				TableSchema.TableColumn colvarApsid = new TableSchema.TableColumn(schema);
				colvarApsid.ColumnName = "APSID";
				colvarApsid.DataType = DbType.AnsiString;
				colvarApsid.MaxLength = 10;
				colvarApsid.AutoIncrement = false;
				colvarApsid.IsNullable = true;
				colvarApsid.IsPrimaryKey = false;
				colvarApsid.IsForeignKey = false;
				colvarApsid.IsReadOnly = false;
				colvarApsid.DefaultSetting = @"";
				colvarApsid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApsid);
				
				TableSchema.TableColumn colvarReMark = new TableSchema.TableColumn(schema);
				colvarReMark.ColumnName = "ReMark";
				colvarReMark.DataType = DbType.AnsiString;
				colvarReMark.MaxLength = 120;
				colvarReMark.AutoIncrement = false;
				colvarReMark.IsNullable = true;
				colvarReMark.IsPrimaryKey = false;
				colvarReMark.IsForeignKey = false;
				colvarReMark.IsReadOnly = false;
				colvarReMark.DefaultSetting = @"";
				colvarReMark.ForeignKeyTableName = "";
				schema.Columns.Add(colvarReMark);
				
				TableSchema.TableColumn colvarSccjjq = new TableSchema.TableColumn(schema);
				colvarSccjjq.ColumnName = "SCCJJQ";
				colvarSccjjq.DataType = DbType.DateTime;
				colvarSccjjq.MaxLength = 0;
				colvarSccjjq.AutoIncrement = false;
				colvarSccjjq.IsNullable = true;
				colvarSccjjq.IsPrimaryKey = false;
				colvarSccjjq.IsForeignKey = false;
				colvarSccjjq.IsReadOnly = false;
				colvarSccjjq.DefaultSetting = @"";
				colvarSccjjq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSccjjq);
				
				TableSchema.TableColumn colvarSctcrq = new TableSchema.TableColumn(schema);
				colvarSctcrq.ColumnName = "SCTCRQ";
				colvarSctcrq.DataType = DbType.DateTime;
				colvarSctcrq.MaxLength = 0;
				colvarSctcrq.AutoIncrement = false;
				colvarSctcrq.IsNullable = true;
				colvarSctcrq.IsPrimaryKey = false;
				colvarSctcrq.IsForeignKey = false;
				colvarSctcrq.IsReadOnly = false;
				colvarSctcrq.DefaultSetting = @"";
				colvarSctcrq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSctcrq);
				
				TableSchema.TableColumn colvarScfzxh = new TableSchema.TableColumn(schema);
				colvarScfzxh.ColumnName = "SCFZXH";
				colvarScfzxh.DataType = DbType.AnsiString;
				colvarScfzxh.MaxLength = 22;
				colvarScfzxh.AutoIncrement = false;
				colvarScfzxh.IsNullable = true;
				colvarScfzxh.IsPrimaryKey = false;
				colvarScfzxh.IsForeignKey = false;
				colvarScfzxh.IsReadOnly = false;
				colvarScfzxh.DefaultSetting = @"";
				colvarScfzxh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScfzxh);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Nowthwin"].AddSchema("T_TempInfo",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		  
		[XmlAttribute("IpAdress")]
		[Bindable(true)]
		public string IpAdress 
		{
			get { return GetColumnValue<string>(Columns.IpAdress); }
			set { SetColumnValue(Columns.IpAdress, value); }
		}
		  
		[XmlAttribute("Cutternum")]
		[Bindable(true)]
		public int? Cutternum 
		{
			get { return GetColumnValue<int?>(Columns.Cutternum); }
			set { SetColumnValue(Columns.Cutternum, value); }
		}
		  
		[XmlAttribute("Sczsbh")]
		[Bindable(true)]
		public string Sczsbh 
		{
			get { return GetColumnValue<string>(Columns.Sczsbh); }
			set { SetColumnValue(Columns.Sczsbh, value); }
		}
		  
		[XmlAttribute("Khdhxh")]
		[Bindable(true)]
		public string Khdhxh 
		{
			get { return GetColumnValue<string>(Columns.Khdhxh); }
			set { SetColumnValue(Columns.Khdhxh, value); }
		}
		  
		[XmlAttribute("Khdh")]
		[Bindable(true)]
		public string Khdh 
		{
			get { return GetColumnValue<string>(Columns.Khdh); }
			set { SetColumnValue(Columns.Khdh, value); }
		}
		  
		[XmlAttribute("Gyfl")]
		[Bindable(true)]
		public string Gyfl 
		{
			get { return GetColumnValue<string>(Columns.Gyfl); }
			set { SetColumnValue(Columns.Gyfl, value); }
		}
		  
		[XmlAttribute("Sldl")]
		[Bindable(true)]
		public string Sldl 
		{
			get { return GetColumnValue<string>(Columns.Sldl); }
			set { SetColumnValue(Columns.Sldl, value); }
		}
		  
		[XmlAttribute("Wlxh")]
		[Bindable(true)]
		public int? Wlxh 
		{
			get { return GetColumnValue<int?>(Columns.Wlxh); }
			set { SetColumnValue(Columns.Wlxh, value); }
		}
		  
		[XmlAttribute("Wlbm")]
		[Bindable(true)]
		public string Wlbm 
		{
			get { return GetColumnValue<string>(Columns.Wlbm); }
			set { SetColumnValue(Columns.Wlbm, value); }
		}
		  
		[XmlAttribute("Wlbmbz")]
		[Bindable(true)]
		public string Wlbmbz 
		{
			get { return GetColumnValue<string>(Columns.Wlbmbz); }
			set { SetColumnValue(Columns.Wlbmbz, value); }
		}
		  
		[XmlAttribute("Wlbmdh")]
		[Bindable(true)]
		public string Wlbmdh 
		{
			get { return GetColumnValue<string>(Columns.Wlbmdh); }
			set { SetColumnValue(Columns.Wlbmdh, value); }
		}
		  
		[XmlAttribute("Wlhy")]
		[Bindable(true)]
		public string Wlhy 
		{
			get { return GetColumnValue<string>(Columns.Wlhy); }
			set { SetColumnValue(Columns.Wlhy, value); }
		}
		  
		[XmlAttribute("Wlfk")]
		[Bindable(true)]
		public string Wlfk 
		{
			get { return GetColumnValue<string>(Columns.Wlfk); }
			set { SetColumnValue(Columns.Wlfk, value); }
		}
		  
		[XmlAttribute("Tgsx")]
		[Bindable(true)]
		public string Tgsx 
		{
			get { return GetColumnValue<string>(Columns.Tgsx); }
			set { SetColumnValue(Columns.Tgsx, value); }
		}
		  
		[XmlAttribute("Tgkd")]
		[Bindable(true)]
		public string Tgkd 
		{
			get { return GetColumnValue<string>(Columns.Tgkd); }
			set { SetColumnValue(Columns.Tgkd, value); }
		}
		  
		[XmlAttribute("Wlbw")]
		[Bindable(true)]
		public string Wlbw 
		{
			get { return GetColumnValue<string>(Columns.Wlbw); }
			set { SetColumnValue(Columns.Wlbw, value); }
		}
		  
		[XmlAttribute("Wlcd")]
		[Bindable(true)]
		public string Wlcd 
		{
			get { return GetColumnValue<string>(Columns.Wlcd); }
			set { SetColumnValue(Columns.Wlcd, value); }
		}
		  
		[XmlAttribute("Czry")]
		[Bindable(true)]
		public string Czry 
		{
			get { return GetColumnValue<string>(Columns.Czry); }
			set { SetColumnValue(Columns.Czry, value); }
		}
		  
		[XmlAttribute("Wltm")]
		[Bindable(true)]
		public string Wltm 
		{
			get { return GetColumnValue<string>(Columns.Wltm); }
			set { SetColumnValue(Columns.Wltm, value); }
		}
		  
		[XmlAttribute("Cutetime")]
		[Bindable(true)]
		public string Cutetime 
		{
			get { return GetColumnValue<string>(Columns.Cutetime); }
			set { SetColumnValue(Columns.Cutetime, value); }
		}
		  
		[XmlAttribute("Apsid")]
		[Bindable(true)]
		public string Apsid 
		{
			get { return GetColumnValue<string>(Columns.Apsid); }
			set { SetColumnValue(Columns.Apsid, value); }
		}
		  
		[XmlAttribute("ReMark")]
		[Bindable(true)]
		public string ReMark 
		{
			get { return GetColumnValue<string>(Columns.ReMark); }
			set { SetColumnValue(Columns.ReMark, value); }
		}
		  
		[XmlAttribute("Sccjjq")]
		[Bindable(true)]
		public DateTime? Sccjjq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Sccjjq); }
			set { SetColumnValue(Columns.Sccjjq, value); }
		}
		  
		[XmlAttribute("Sctcrq")]
		[Bindable(true)]
		public DateTime? Sctcrq 
		{
			get { return GetColumnValue<DateTime?>(Columns.Sctcrq); }
			set { SetColumnValue(Columns.Sctcrq, value); }
		}
		  
		[XmlAttribute("Scfzxh")]
		[Bindable(true)]
		public string Scfzxh 
		{
			get { return GetColumnValue<string>(Columns.Scfzxh); }
			set { SetColumnValue(Columns.Scfzxh, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varIpAdress,int? varCutternum,string varSczsbh,string varKhdhxh,string varKhdh,string varGyfl,string varSldl,int? varWlxh,string varWlbm,string varWlbmbz,string varWlbmdh,string varWlhy,string varWlfk,string varTgsx,string varTgkd,string varWlbw,string varWlcd,string varCzry,string varWltm,string varCutetime,string varApsid,string varReMark,DateTime? varSccjjq,DateTime? varSctcrq,string varScfzxh)
		{
			TTempInfo item = new TTempInfo();
			
			item.IpAdress = varIpAdress;
			
			item.Cutternum = varCutternum;
			
			item.Sczsbh = varSczsbh;
			
			item.Khdhxh = varKhdhxh;
			
			item.Khdh = varKhdh;
			
			item.Gyfl = varGyfl;
			
			item.Sldl = varSldl;
			
			item.Wlxh = varWlxh;
			
			item.Wlbm = varWlbm;
			
			item.Wlbmbz = varWlbmbz;
			
			item.Wlbmdh = varWlbmdh;
			
			item.Wlhy = varWlhy;
			
			item.Wlfk = varWlfk;
			
			item.Tgsx = varTgsx;
			
			item.Tgkd = varTgkd;
			
			item.Wlbw = varWlbw;
			
			item.Wlcd = varWlcd;
			
			item.Czry = varCzry;
			
			item.Wltm = varWltm;
			
			item.Cutetime = varCutetime;
			
			item.Apsid = varApsid;
			
			item.ReMark = varReMark;
			
			item.Sccjjq = varSccjjq;
			
			item.Sctcrq = varSctcrq;
			
			item.Scfzxh = varScfzxh;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varIpAdress,int? varCutternum,string varSczsbh,string varKhdhxh,string varKhdh,string varGyfl,string varSldl,int? varWlxh,string varWlbm,string varWlbmbz,string varWlbmdh,string varWlhy,string varWlfk,string varTgsx,string varTgkd,string varWlbw,string varWlcd,string varCzry,string varWltm,string varCutetime,string varApsid,string varReMark,DateTime? varSccjjq,DateTime? varSctcrq,string varScfzxh)
		{
			TTempInfo item = new TTempInfo();
			
				item.Id = varId;
			
				item.IpAdress = varIpAdress;
			
				item.Cutternum = varCutternum;
			
				item.Sczsbh = varSczsbh;
			
				item.Khdhxh = varKhdhxh;
			
				item.Khdh = varKhdh;
			
				item.Gyfl = varGyfl;
			
				item.Sldl = varSldl;
			
				item.Wlxh = varWlxh;
			
				item.Wlbm = varWlbm;
			
				item.Wlbmbz = varWlbmbz;
			
				item.Wlbmdh = varWlbmdh;
			
				item.Wlhy = varWlhy;
			
				item.Wlfk = varWlfk;
			
				item.Tgsx = varTgsx;
			
				item.Tgkd = varTgkd;
			
				item.Wlbw = varWlbw;
			
				item.Wlcd = varWlcd;
			
				item.Czry = varCzry;
			
				item.Wltm = varWltm;
			
				item.Cutetime = varCutetime;
			
				item.Apsid = varApsid;
			
				item.ReMark = varReMark;
			
				item.Sccjjq = varSccjjq;
			
				item.Sctcrq = varSctcrq;
			
				item.Scfzxh = varScfzxh;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IpAdressColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn CutternumColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn SczsbhColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn KhdhxhColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn KhdhColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn GyflColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn SldlColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn WlxhColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn WlbmColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn WlbmbzColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn WlbmdhColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn WlhyColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn WlfkColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn TgsxColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn TgkdColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn WlbwColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn WlcdColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn CzryColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn WltmColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn CutetimeColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn ApsidColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn ReMarkColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn SccjjqColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn SctcrqColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn ScfzxhColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string IpAdress = @"IpAdress";
			 public static string Cutternum = @"CUTTERNUM";
			 public static string Sczsbh = @"SCZSBH";
			 public static string Khdhxh = @"KHDHXH";
			 public static string Khdh = @"KHDH";
			 public static string Gyfl = @"GYFL";
			 public static string Sldl = @"SLDL";
			 public static string Wlxh = @"WLXH";
			 public static string Wlbm = @"WLBM";
			 public static string Wlbmbz = @"WLBMBZ";
			 public static string Wlbmdh = @"WLBMDH";
			 public static string Wlhy = @"WLHY";
			 public static string Wlfk = @"WLFK";
			 public static string Tgsx = @"TGSX";
			 public static string Tgkd = @"TGKD";
			 public static string Wlbw = @"WLBW";
			 public static string Wlcd = @"WLCD";
			 public static string Czry = @"CZRY";
			 public static string Wltm = @"WLTM";
			 public static string Cutetime = @"CUTETIME";
			 public static string Apsid = @"APSID";
			 public static string ReMark = @"ReMark";
			 public static string Sccjjq = @"SCCJJQ";
			 public static string Sctcrq = @"SCTCRQ";
			 public static string Scfzxh = @"SCFZXH";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
