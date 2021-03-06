﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CY.Iot.Common
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="sf_database_qx")]
	public partial class IotDataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertIot_TopUpRecord(Iot_TopUpRecord instance);
    partial void UpdateIot_TopUpRecord(Iot_TopUpRecord instance);
    partial void DeleteIot_TopUpRecord(Iot_TopUpRecord instance);
    #endregion
		
		public IotDataContextDataContext() : 
				base(global::CY.Iot.Common.Properties.Settings.Default.sf_database_qxConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public IotDataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IotDataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IotDataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IotDataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<View_MeterTopUp> View_MeterTopUp
		{
			get
			{
				return this.GetTable<View_MeterTopUp>();
			}
		}
		
		public System.Data.Linq.Table<Iot_TopUpRecord> Iot_TopUpRecord
		{
			get
			{
				return this.GetTable<Iot_TopUpRecord>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.View_MeterTopUp")]
	public partial class View_MeterTopUp
	{
		
		private long _ID;
		
		private System.Nullable<int> _Ser;
		
		private string _UserID;
		
		private string _UserName;
		
		private string _Phone;
		
		private string _Street;
		
		private string _Community;
		
		private string _Door;
		
		private string _Address;
		
		private System.Nullable<long> _MeterID;
		
		private string _MeterNo;
		
		private System.Nullable<decimal> _Amount;
		
		private System.Nullable<System.DateTime> _TopUpDate;
		
		private System.Nullable<char> _TopUpType;
		
		private string _Oper;
		
		private string _OrgCode;
		
		private System.Nullable<char> _State;
		
		private string _CompanyID;
		
		private string _TaskID;
		
		private string _Context;
		
		private System.Nullable<bool> _IsPrint;
		
		private System.Nullable<char> _PayType;
		
		private string _SFOperID;
		
		private string _SFOperName;
		
		public View_MeterTopUp()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="BigInt NOT NULL")]
		public long ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ser", DbType="Int")]
		public System.Nullable<int> Ser
		{
			get
			{
				return this._Ser;
			}
			set
			{
				if ((this._Ser != value))
				{
					this._Ser = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="VarChar(50)")]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this._UserName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(50)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this._Phone = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Street", DbType="VarChar(50)")]
		public string Street
		{
			get
			{
				return this._Street;
			}
			set
			{
				if ((this._Street != value))
				{
					this._Street = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Community", DbType="VarChar(50)")]
		public string Community
		{
			get
			{
				return this._Community;
			}
			set
			{
				if ((this._Community != value))
				{
					this._Community = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Door", DbType="VarChar(50)")]
		public string Door
		{
			get
			{
				return this._Door;
			}
			set
			{
				if ((this._Door != value))
				{
					this._Door = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(100)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MeterID", DbType="BigInt")]
		public System.Nullable<long> MeterID
		{
			get
			{
				return this._MeterID;
			}
			set
			{
				if ((this._MeterID != value))
				{
					this._MeterID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MeterNo", DbType="VarChar(20)")]
		public string MeterNo
		{
			get
			{
				return this._MeterNo;
			}
			set
			{
				if ((this._MeterNo != value))
				{
					this._MeterNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Money")]
		public System.Nullable<decimal> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this._Amount = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TopUpDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> TopUpDate
		{
			get
			{
				return this._TopUpDate;
			}
			set
			{
				if ((this._TopUpDate != value))
				{
					this._TopUpDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TopUpType", DbType="Char(1)")]
		public System.Nullable<char> TopUpType
		{
			get
			{
				return this._TopUpType;
			}
			set
			{
				if ((this._TopUpType != value))
				{
					this._TopUpType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Oper", DbType="VarChar(50)")]
		public string Oper
		{
			get
			{
				return this._Oper;
			}
			set
			{
				if ((this._Oper != value))
				{
					this._Oper = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgCode", DbType="VarChar(10)")]
		public string OrgCode
		{
			get
			{
				return this._OrgCode;
			}
			set
			{
				if ((this._OrgCode != value))
				{
					this._OrgCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="Char(1)")]
		public System.Nullable<char> State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this._State = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyID", DbType="Char(4)")]
		public string CompanyID
		{
			get
			{
				return this._CompanyID;
			}
			set
			{
				if ((this._CompanyID != value))
				{
					this._CompanyID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskID", DbType="VarChar(50)")]
		public string TaskID
		{
			get
			{
				return this._TaskID;
			}
			set
			{
				if ((this._TaskID != value))
				{
					this._TaskID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Context", DbType="VarChar(50)")]
		public string Context
		{
			get
			{
				return this._Context;
			}
			set
			{
				if ((this._Context != value))
				{
					this._Context = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsPrint", DbType="Bit")]
		public System.Nullable<bool> IsPrint
		{
			get
			{
				return this._IsPrint;
			}
			set
			{
				if ((this._IsPrint != value))
				{
					this._IsPrint = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PayType", DbType="Char(1)")]
		public System.Nullable<char> PayType
		{
			get
			{
				return this._PayType;
			}
			set
			{
				if ((this._PayType != value))
				{
					this._PayType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SFOperID", DbType="NVarChar(50)")]
		public string SFOperID
		{
			get
			{
				return this._SFOperID;
			}
			set
			{
				if ((this._SFOperID != value))
				{
					this._SFOperID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SFOperName", DbType="NVarChar(50)")]
		public string SFOperName
		{
			get
			{
				return this._SFOperName;
			}
			set
			{
				if ((this._SFOperName != value))
				{
					this._SFOperName = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Iot_TopUpRecord")]
	public partial class Iot_TopUpRecord : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _ID;
		
		private System.Nullable<int> _Ser;
		
		private string _UserID;
		
		private System.Nullable<long> _MeterID;
		
		private string _MeterNo;
		
		private System.Nullable<decimal> _Amount;
		
		private System.Nullable<System.DateTime> _TopUpDate;
		
		private char _TopUpType;
		
		private string _Oper;
		
		private string _OrgCode;
		
		private char _State;
		
		private string _CompanyID;
		
		private string _TaskID;
		
		private string _Context;
		
		private System.Nullable<char> _PayType;
		
		private string _UserName;
		
		private string _Address;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(long value);
    partial void OnIDChanged();
    partial void OnSerChanging(System.Nullable<int> value);
    partial void OnSerChanged();
    partial void OnUserIDChanging(string value);
    partial void OnUserIDChanged();
    partial void OnMeterIDChanging(System.Nullable<long> value);
    partial void OnMeterIDChanged();
    partial void OnMeterNoChanging(string value);
    partial void OnMeterNoChanged();
    partial void OnAmountChanging(System.Nullable<decimal> value);
    partial void OnAmountChanged();
    partial void OnTopUpDateChanging(System.Nullable<System.DateTime> value);
    partial void OnTopUpDateChanged();
    partial void OnTopUpTypeChanging(char value);
    partial void OnTopUpTypeChanged();
    partial void OnOperChanging(string value);
    partial void OnOperChanged();
    partial void OnOrgCodeChanging(string value);
    partial void OnOrgCodeChanged();
    partial void OnStateChanging(char value);
    partial void OnStateChanged();
    partial void OnCompanyIDChanging(string value);
    partial void OnCompanyIDChanged();
    partial void OnTaskIDChanging(string value);
    partial void OnTaskIDChanged();
    partial void OnContextChanging(string value);
    partial void OnContextChanged();
    partial void OnPayTypeChanging(System.Nullable<char> value);
    partial void OnPayTypeChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    #endregion
		
		public Iot_TopUpRecord()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ser", DbType="Int")]
		public System.Nullable<int> Ser
		{
			get
			{
				return this._Ser;
			}
			set
			{
				if ((this._Ser != value))
				{
					this.OnSerChanging(value);
					this.SendPropertyChanging();
					this._Ser = value;
					this.SendPropertyChanged("Ser");
					this.OnSerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="VarChar(50)")]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MeterID", DbType="BigInt")]
		public System.Nullable<long> MeterID
		{
			get
			{
				return this._MeterID;
			}
			set
			{
				if ((this._MeterID != value))
				{
					this.OnMeterIDChanging(value);
					this.SendPropertyChanging();
					this._MeterID = value;
					this.SendPropertyChanged("MeterID");
					this.OnMeterIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MeterNo", DbType="VarChar(20)")]
		public string MeterNo
		{
			get
			{
				return this._MeterNo;
			}
			set
			{
				if ((this._MeterNo != value))
				{
					this.OnMeterNoChanging(value);
					this.SendPropertyChanging();
					this._MeterNo = value;
					this.SendPropertyChanged("MeterNo");
					this.OnMeterNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Money")]
		public System.Nullable<decimal> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TopUpDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> TopUpDate
		{
			get
			{
				return this._TopUpDate;
			}
			set
			{
				if ((this._TopUpDate != value))
				{
					this.OnTopUpDateChanging(value);
					this.SendPropertyChanging();
					this._TopUpDate = value;
					this.SendPropertyChanged("TopUpDate");
					this.OnTopUpDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TopUpType", DbType="Char(1) NOT NULL")]
		public char TopUpType
		{
			get
			{
				return this._TopUpType;
			}
			set
			{
				if ((this._TopUpType != value))
				{
					this.OnTopUpTypeChanging(value);
					this.SendPropertyChanging();
					this._TopUpType = value;
					this.SendPropertyChanged("TopUpType");
					this.OnTopUpTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Oper", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Oper
		{
			get
			{
				return this._Oper;
			}
			set
			{
				if ((this._Oper != value))
				{
					this.OnOperChanging(value);
					this.SendPropertyChanging();
					this._Oper = value;
					this.SendPropertyChanged("Oper");
					this.OnOperChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgCode", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string OrgCode
		{
			get
			{
				return this._OrgCode;
			}
			set
			{
				if ((this._OrgCode != value))
				{
					this.OnOrgCodeChanging(value);
					this.SendPropertyChanging();
					this._OrgCode = value;
					this.SendPropertyChanged("OrgCode");
					this.OnOrgCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="Char(1) NOT NULL")]
		public char State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyID", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string CompanyID
		{
			get
			{
				return this._CompanyID;
			}
			set
			{
				if ((this._CompanyID != value))
				{
					this.OnCompanyIDChanging(value);
					this.SendPropertyChanging();
					this._CompanyID = value;
					this.SendPropertyChanged("CompanyID");
					this.OnCompanyIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskID", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string TaskID
		{
			get
			{
				return this._TaskID;
			}
			set
			{
				if ((this._TaskID != value))
				{
					this.OnTaskIDChanging(value);
					this.SendPropertyChanging();
					this._TaskID = value;
					this.SendPropertyChanged("TaskID");
					this.OnTaskIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Context", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Context
		{
			get
			{
				return this._Context;
			}
			set
			{
				if ((this._Context != value))
				{
					this.OnContextChanging(value);
					this.SendPropertyChanging();
					this._Context = value;
					this.SendPropertyChanged("Context");
					this.OnContextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PayType", DbType="Char(1)")]
		public System.Nullable<char> PayType
		{
			get
			{
				return this._PayType;
			}
			set
			{
				if ((this._PayType != value))
				{
					this.OnPayTypeChanging(value);
					this.SendPropertyChanging();
					this._PayType = value;
					this.SendPropertyChanged("PayType");
					this.OnPayTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
