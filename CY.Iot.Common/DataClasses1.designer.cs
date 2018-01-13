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
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertIot_FunctionMenu(Iot_FunctionMenu instance);
    partial void UpdateIot_FunctionMenu(Iot_FunctionMenu instance);
    partial void DeleteIot_FunctionMenu(Iot_FunctionMenu instance);
    partial void InsertIot_FunctionDefine(Iot_FunctionDefine instance);
    partial void UpdateIot_FunctionDefine(Iot_FunctionDefine instance);
    partial void DeleteIot_FunctionDefine(Iot_FunctionDefine instance);
    partial void InsertIot_ChildFunctionBar(Iot_ChildFunctionBar instance);
    partial void UpdateIot_ChildFunctionBar(Iot_ChildFunctionBar instance);
    partial void DeleteIot_ChildFunctionBar(Iot_ChildFunctionBar instance);
    partial void InsertIot_OperatorMaping(Iot_OperatorMaping instance);
    partial void UpdateIot_OperatorMaping(Iot_OperatorMaping instance);
    partial void DeleteIot_OperatorMaping(Iot_OperatorMaping instance);
    partial void InsertCompanyAccount(CompanyAccount instance);
    partial void UpdateCompanyAccount(CompanyAccount instance);
    partial void DeleteCompanyAccount(CompanyAccount instance);
    partial void InsertFrame_MainMenu(Frame_MainMenu instance);
    partial void UpdateFrame_MainMenu(Frame_MainMenu instance);
    partial void DeleteFrame_MainMenu(Frame_MainMenu instance);
    partial void InsertDictionary(Dictionary instance);
    partial void UpdateDictionary(Dictionary instance);
    partial void DeleteDictionary(Dictionary instance);
    partial void InsertReportTemplate(ReportTemplate instance);
    partial void UpdateReportTemplate(ReportTemplate instance);
    partial void DeleteReportTemplate(ReportTemplate instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::CY.Iot.Common.Properties.Settings.Default.sf_database_qxConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Iot_FunctionMenu> Iot_FunctionMenu
		{
			get
			{
				return this.GetTable<Iot_FunctionMenu>();
			}
		}
		
		public System.Data.Linq.Table<Iot_FunctionDefine> Iot_FunctionDefine
		{
			get
			{
				return this.GetTable<Iot_FunctionDefine>();
			}
		}
		
		public System.Data.Linq.Table<Iot_ChildFunctionBar> Iot_ChildFunctionBar
		{
			get
			{
				return this.GetTable<Iot_ChildFunctionBar>();
			}
		}
		
		public System.Data.Linq.Table<Iot_OperatorMaping> Iot_OperatorMaping
		{
			get
			{
				return this.GetTable<Iot_OperatorMaping>();
			}
		}
		
		public System.Data.Linq.Table<CompanyAccount> CompanyAccount
		{
			get
			{
				return this.GetTable<CompanyAccount>();
			}
		}
		
		public System.Data.Linq.Table<Frame_MainMenu> Frame_MainMenu
		{
			get
			{
				return this.GetTable<Frame_MainMenu>();
			}
		}
		
		public System.Data.Linq.Table<Dictionary> Dictionary
		{
			get
			{
				return this.GetTable<Dictionary>();
			}
		}
		
		public System.Data.Linq.Table<ReportTemplate> ReportTemplate
		{
			get
			{
				return this.GetTable<ReportTemplate>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Iot_FunctionMenu")]
	public partial class Iot_FunctionMenu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _MenuName;
		
		private bool _IsGroup;
		
		private int _MainMenuID;
		
		private int _MenuOrder;
		
		private int _RootID;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMenuNameChanging(string value);
    partial void OnMenuNameChanged();
    partial void OnIsGroupChanging(bool value);
    partial void OnIsGroupChanged();
    partial void OnMainMenuIDChanging(int value);
    partial void OnMainMenuIDChanged();
    partial void OnMenuOrderChanging(int value);
    partial void OnMenuOrderChanged();
    partial void OnRootIDChanging(int value);
    partial void OnRootIDChanged();
    #endregion
		
		public Iot_FunctionMenu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuName", DbType="VarChar(50)")]
		public string MenuName
		{
			get
			{
				return this._MenuName;
			}
			set
			{
				if ((this._MenuName != value))
				{
					this.OnMenuNameChanging(value);
					this.SendPropertyChanging();
					this._MenuName = value;
					this.SendPropertyChanged("MenuName");
					this.OnMenuNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsGroup", DbType="Bit NOT NULL")]
		public bool IsGroup
		{
			get
			{
				return this._IsGroup;
			}
			set
			{
				if ((this._IsGroup != value))
				{
					this.OnIsGroupChanging(value);
					this.SendPropertyChanging();
					this._IsGroup = value;
					this.SendPropertyChanged("IsGroup");
					this.OnIsGroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MainMenuID", DbType="Int NOT NULL")]
		public int MainMenuID
		{
			get
			{
				return this._MainMenuID;
			}
			set
			{
				if ((this._MainMenuID != value))
				{
					this.OnMainMenuIDChanging(value);
					this.SendPropertyChanging();
					this._MainMenuID = value;
					this.SendPropertyChanged("MainMenuID");
					this.OnMainMenuIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuOrder", DbType="Int NOT NULL")]
		public int MenuOrder
		{
			get
			{
				return this._MenuOrder;
			}
			set
			{
				if ((this._MenuOrder != value))
				{
					this.OnMenuOrderChanging(value);
					this.SendPropertyChanging();
					this._MenuOrder = value;
					this.SendPropertyChanged("MenuOrder");
					this.OnMenuOrderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RootID", DbType="Int NOT NULL")]
		public int RootID
		{
			get
			{
				return this._RootID;
			}
			set
			{
				if ((this._RootID != value))
				{
					this.OnRootIDChanging(value);
					this.SendPropertyChanging();
					this._RootID = value;
					this.SendPropertyChanged("RootID");
					this.OnRootIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Iot_FunctionDefine")]
	public partial class Iot_FunctionDefine : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RootID;
		
		private string _FunName;
		
		private string _URI;
		
		private System.Nullable<int> _WinType;
		
		private System.Nullable<int> _RightCode;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRootIDChanging(int value);
    partial void OnRootIDChanged();
    partial void OnFunNameChanging(string value);
    partial void OnFunNameChanged();
    partial void OnURIChanging(string value);
    partial void OnURIChanged();
    partial void OnWinTypeChanging(System.Nullable<int> value);
    partial void OnWinTypeChanged();
    partial void OnRightCodeChanging(System.Nullable<int> value);
    partial void OnRightCodeChanged();
    #endregion
		
		public Iot_FunctionDefine()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RootID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int RootID
		{
			get
			{
				return this._RootID;
			}
			set
			{
				if ((this._RootID != value))
				{
					this.OnRootIDChanging(value);
					this.SendPropertyChanging();
					this._RootID = value;
					this.SendPropertyChanged("RootID");
					this.OnRootIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FunName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string FunName
		{
			get
			{
				return this._FunName;
			}
			set
			{
				if ((this._FunName != value))
				{
					this.OnFunNameChanging(value);
					this.SendPropertyChanging();
					this._FunName = value;
					this.SendPropertyChanged("FunName");
					this.OnFunNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URI", DbType="VarChar(200)")]
		public string URI
		{
			get
			{
				return this._URI;
			}
			set
			{
				if ((this._URI != value))
				{
					this.OnURIChanging(value);
					this.SendPropertyChanging();
					this._URI = value;
					this.SendPropertyChanged("URI");
					this.OnURIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WinType", DbType="Int")]
		public System.Nullable<int> WinType
		{
			get
			{
				return this._WinType;
			}
			set
			{
				if ((this._WinType != value))
				{
					this.OnWinTypeChanging(value);
					this.SendPropertyChanging();
					this._WinType = value;
					this.SendPropertyChanged("WinType");
					this.OnWinTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RightCode", DbType="Int")]
		public System.Nullable<int> RightCode
		{
			get
			{
				return this._RightCode;
			}
			set
			{
				if ((this._RightCode != value))
				{
					this.OnRightCodeChanging(value);
					this.SendPropertyChanging();
					this._RightCode = value;
					this.SendPropertyChanged("RightCode");
					this.OnRightCodeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Iot_ChildFunctionBar")]
	public partial class Iot_ChildFunctionBar : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CID;
		
		private System.Nullable<int> _RootID;
		
		private string _FunName;
		
		private string _URI;
		
		private System.Nullable<int> _WinType;
		
		private System.Nullable<int> _RightCode;
		
		private System.Nullable<int> _OrderID;
		
		private System.Nullable<bool> _IsGroup;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCIDChanging(int value);
    partial void OnCIDChanged();
    partial void OnRootIDChanging(System.Nullable<int> value);
    partial void OnRootIDChanged();
    partial void OnFunNameChanging(string value);
    partial void OnFunNameChanged();
    partial void OnURIChanging(string value);
    partial void OnURIChanged();
    partial void OnWinTypeChanging(System.Nullable<int> value);
    partial void OnWinTypeChanged();
    partial void OnRightCodeChanging(System.Nullable<int> value);
    partial void OnRightCodeChanged();
    partial void OnOrderIDChanging(System.Nullable<int> value);
    partial void OnOrderIDChanged();
    partial void OnIsGroupChanging(System.Nullable<bool> value);
    partial void OnIsGroupChanged();
    #endregion
		
		public Iot_ChildFunctionBar()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CID
		{
			get
			{
				return this._CID;
			}
			set
			{
				if ((this._CID != value))
				{
					this.OnCIDChanging(value);
					this.SendPropertyChanging();
					this._CID = value;
					this.SendPropertyChanged("CID");
					this.OnCIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RootID", DbType="Int")]
		public System.Nullable<int> RootID
		{
			get
			{
				return this._RootID;
			}
			set
			{
				if ((this._RootID != value))
				{
					this.OnRootIDChanging(value);
					this.SendPropertyChanging();
					this._RootID = value;
					this.SendPropertyChanged("RootID");
					this.OnRootIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FunName", DbType="VarChar(100)")]
		public string FunName
		{
			get
			{
				return this._FunName;
			}
			set
			{
				if ((this._FunName != value))
				{
					this.OnFunNameChanging(value);
					this.SendPropertyChanging();
					this._FunName = value;
					this.SendPropertyChanged("FunName");
					this.OnFunNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URI", DbType="VarChar(200)")]
		public string URI
		{
			get
			{
				return this._URI;
			}
			set
			{
				if ((this._URI != value))
				{
					this.OnURIChanging(value);
					this.SendPropertyChanging();
					this._URI = value;
					this.SendPropertyChanged("URI");
					this.OnURIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WinType", DbType="Int")]
		public System.Nullable<int> WinType
		{
			get
			{
				return this._WinType;
			}
			set
			{
				if ((this._WinType != value))
				{
					this.OnWinTypeChanging(value);
					this.SendPropertyChanging();
					this._WinType = value;
					this.SendPropertyChanged("WinType");
					this.OnWinTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RightCode", DbType="Int")]
		public System.Nullable<int> RightCode
		{
			get
			{
				return this._RightCode;
			}
			set
			{
				if ((this._RightCode != value))
				{
					this.OnRightCodeChanging(value);
					this.SendPropertyChanging();
					this._RightCode = value;
					this.SendPropertyChanged("RightCode");
					this.OnRightCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderID", DbType="Int")]
		public System.Nullable<int> OrderID
		{
			get
			{
				return this._OrderID;
			}
			set
			{
				if ((this._OrderID != value))
				{
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._OrderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsGroup", DbType="Bit")]
		public System.Nullable<bool> IsGroup
		{
			get
			{
				return this._IsGroup;
			}
			set
			{
				if ((this._IsGroup != value))
				{
					this.OnIsGroupChanging(value);
					this.SendPropertyChanging();
					this._IsGroup = value;
					this.SendPropertyChanged("IsGroup");
					this.OnIsGroupChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Iot_OperatorMaping")]
	public partial class Iot_OperatorMaping : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _OperID;
		
		private string _IotOperID;
		
		private string _IotOperName;
		
		private string _IotOperPwd;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOperIDChanging(string value);
    partial void OnOperIDChanged();
    partial void OnIotOperIDChanging(string value);
    partial void OnIotOperIDChanged();
    partial void OnIotOperNameChanging(string value);
    partial void OnIotOperNameChanged();
    partial void OnIotOperPwdChanging(string value);
    partial void OnIotOperPwdChanged();
    #endregion
		
		public Iot_OperatorMaping()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OperID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string OperID
		{
			get
			{
				return this._OperID;
			}
			set
			{
				if ((this._OperID != value))
				{
					this.OnOperIDChanging(value);
					this.SendPropertyChanging();
					this._OperID = value;
					this.SendPropertyChanged("OperID");
					this.OnOperIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IotOperID", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string IotOperID
		{
			get
			{
				return this._IotOperID;
			}
			set
			{
				if ((this._IotOperID != value))
				{
					this.OnIotOperIDChanging(value);
					this.SendPropertyChanging();
					this._IotOperID = value;
					this.SendPropertyChanged("IotOperID");
					this.OnIotOperIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IotOperName", DbType="VarChar(50)")]
		public string IotOperName
		{
			get
			{
				return this._IotOperName;
			}
			set
			{
				if ((this._IotOperName != value))
				{
					this.OnIotOperNameChanging(value);
					this.SendPropertyChanging();
					this._IotOperName = value;
					this.SendPropertyChanged("IotOperName");
					this.OnIotOperNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IotOperPwd", DbType="VarChar(50)")]
		public string IotOperPwd
		{
			get
			{
				return this._IotOperPwd;
			}
			set
			{
				if ((this._IotOperPwd != value))
				{
					this.OnIotOperPwdChanging(value);
					this.SendPropertyChanging();
					this._IotOperPwd = value;
					this.SendPropertyChanged("IotOperPwd");
					this.OnIotOperPwdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Iot_CompanyAccount")]
	public partial class CompanyAccount : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CompanyID;
		
		private string _CompanyName;
		
		private string _CompanyPwd;
		
		private string _ServiceURL;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCompanyIDChanging(string value);
    partial void OnCompanyIDChanged();
    partial void OnCompanyNameChanging(string value);
    partial void OnCompanyNameChanged();
    partial void OnCompanyPwdChanging(string value);
    partial void OnCompanyPwdChanged();
    partial void OnServiceURLChanging(string value);
    partial void OnServiceURLChanged();
    #endregion
		
		public CompanyAccount()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyID", DbType="VarChar(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyName", DbType="VarChar(50)")]
		public string CompanyName
		{
			get
			{
				return this._CompanyName;
			}
			set
			{
				if ((this._CompanyName != value))
				{
					this.OnCompanyNameChanging(value);
					this.SendPropertyChanging();
					this._CompanyName = value;
					this.SendPropertyChanged("CompanyName");
					this.OnCompanyNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyPwd", DbType="VarChar(50)")]
		public string CompanyPwd
		{
			get
			{
				return this._CompanyPwd;
			}
			set
			{
				if ((this._CompanyPwd != value))
				{
					this.OnCompanyPwdChanging(value);
					this.SendPropertyChanging();
					this._CompanyPwd = value;
					this.SendPropertyChanged("CompanyPwd");
					this.OnCompanyPwdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceURL", DbType="VarChar(100)")]
		public string ServiceURL
		{
			get
			{
				return this._ServiceURL;
			}
			set
			{
				if ((this._ServiceURL != value))
				{
					this.OnServiceURLChanging(value);
					this.SendPropertyChanging();
					this._ServiceURL = value;
					this.SendPropertyChanged("ServiceURL");
					this.OnServiceURLChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Frame_MainMenu")]
	public partial class Frame_MainMenu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MainMenuID;
		
		private System.Nullable<int> _MenuOrderID;
		
		private string _MenuName;
		
		private System.Nullable<bool> _IsMdiChildrenListItem;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMainMenuIDChanging(int value);
    partial void OnMainMenuIDChanged();
    partial void OnMenuOrderIDChanging(System.Nullable<int> value);
    partial void OnMenuOrderIDChanged();
    partial void OnMenuNameChanging(string value);
    partial void OnMenuNameChanged();
    partial void OnIsMdiChildrenListItemChanging(System.Nullable<bool> value);
    partial void OnIsMdiChildrenListItemChanged();
    #endregion
		
		public Frame_MainMenu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MainMenuID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MainMenuID
		{
			get
			{
				return this._MainMenuID;
			}
			set
			{
				if ((this._MainMenuID != value))
				{
					this.OnMainMenuIDChanging(value);
					this.SendPropertyChanging();
					this._MainMenuID = value;
					this.SendPropertyChanged("MainMenuID");
					this.OnMainMenuIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuOrderID", DbType="Int")]
		public System.Nullable<int> MenuOrderID
		{
			get
			{
				return this._MenuOrderID;
			}
			set
			{
				if ((this._MenuOrderID != value))
				{
					this.OnMenuOrderIDChanging(value);
					this.SendPropertyChanging();
					this._MenuOrderID = value;
					this.SendPropertyChanged("MenuOrderID");
					this.OnMenuOrderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuName", DbType="VarChar(20)")]
		public string MenuName
		{
			get
			{
				return this._MenuName;
			}
			set
			{
				if ((this._MenuName != value))
				{
					this.OnMenuNameChanging(value);
					this.SendPropertyChanging();
					this._MenuName = value;
					this.SendPropertyChanged("MenuName");
					this.OnMenuNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsMdiChildrenListItem", DbType="Bit")]
		public System.Nullable<bool> IsMdiChildrenListItem
		{
			get
			{
				return this._IsMdiChildrenListItem;
			}
			set
			{
				if ((this._IsMdiChildrenListItem != value))
				{
					this.OnIsMdiChildrenListItemChanging(value);
					this.SendPropertyChanging();
					this._IsMdiChildrenListItem = value;
					this.SendPropertyChanged("IsMdiChildrenListItem");
					this.OnIsMdiChildrenListItemChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Dictionary")]
	public partial class Dictionary : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID;
		
		private string _PType;
		
		private string _PValue1;
		
		private string _PValue2;
		
		private System.Nullable<bool> _IsEdit;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnPTypeChanging(string value);
    partial void OnPTypeChanged();
    partial void OnPValue1Changing(string value);
    partial void OnPValue1Changed();
    partial void OnPValue2Changing(string value);
    partial void OnPValue2Changed();
    partial void OnIsEditChanging(System.Nullable<bool> value);
    partial void OnIsEditChanged();
    #endregion
		
		public Dictionary()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Char(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PType", DbType="VarChar(50)")]
		public string PType
		{
			get
			{
				return this._PType;
			}
			set
			{
				if ((this._PType != value))
				{
					this.OnPTypeChanging(value);
					this.SendPropertyChanging();
					this._PType = value;
					this.SendPropertyChanged("PType");
					this.OnPTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PValue1", DbType="VarChar(50)")]
		public string PValue1
		{
			get
			{
				return this._PValue1;
			}
			set
			{
				if ((this._PValue1 != value))
				{
					this.OnPValue1Changing(value);
					this.SendPropertyChanging();
					this._PValue1 = value;
					this.SendPropertyChanged("PValue1");
					this.OnPValue1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PValue2", DbType="VarChar(100)")]
		public string PValue2
		{
			get
			{
				return this._PValue2;
			}
			set
			{
				if ((this._PValue2 != value))
				{
					this.OnPValue2Changing(value);
					this.SendPropertyChanging();
					this._PValue2 = value;
					this.SendPropertyChanged("PValue2");
					this.OnPValue2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsEdit", DbType="Bit")]
		public System.Nullable<bool> IsEdit
		{
			get
			{
				return this._IsEdit;
			}
			set
			{
				if ((this._IsEdit != value))
				{
					this.OnIsEditChanging(value);
					this.SendPropertyChanging();
					this._IsEdit = value;
					this.SendPropertyChanged("IsEdit");
					this.OnIsEditChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ReportTemplate")]
	public partial class ReportTemplate : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RID;
		
		private string _ReportName;
		
		private System.Nullable<short> _ReportType;
		
		private System.Nullable<int> _RD_ID;
		
		private System.Data.Linq.Binary _ReportTemplate1;
		
		private string _MenuName;
		
		private System.Nullable<bool> _IsUse;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRIDChanging(int value);
    partial void OnRIDChanged();
    partial void OnReportNameChanging(string value);
    partial void OnReportNameChanged();
    partial void OnReportTypeChanging(System.Nullable<short> value);
    partial void OnReportTypeChanged();
    partial void OnRD_IDChanging(System.Nullable<int> value);
    partial void OnRD_IDChanged();
    partial void OnReportTemplate1Changing(System.Data.Linq.Binary value);
    partial void OnReportTemplate1Changed();
    partial void OnMenuNameChanging(string value);
    partial void OnMenuNameChanged();
    partial void OnIsUseChanging(System.Nullable<bool> value);
    partial void OnIsUseChanged();
    #endregion
		
		public ReportTemplate()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RID
		{
			get
			{
				return this._RID;
			}
			set
			{
				if ((this._RID != value))
				{
					this.OnRIDChanging(value);
					this.SendPropertyChanging();
					this._RID = value;
					this.SendPropertyChanged("RID");
					this.OnRIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReportName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ReportName
		{
			get
			{
				return this._ReportName;
			}
			set
			{
				if ((this._ReportName != value))
				{
					this.OnReportNameChanging(value);
					this.SendPropertyChanging();
					this._ReportName = value;
					this.SendPropertyChanged("ReportName");
					this.OnReportNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReportType", DbType="SmallInt")]
		public System.Nullable<short> ReportType
		{
			get
			{
				return this._ReportType;
			}
			set
			{
				if ((this._ReportType != value))
				{
					this.OnReportTypeChanging(value);
					this.SendPropertyChanging();
					this._ReportType = value;
					this.SendPropertyChanged("ReportType");
					this.OnReportTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RD_ID", DbType="Int")]
		public System.Nullable<int> RD_ID
		{
			get
			{
				return this._RD_ID;
			}
			set
			{
				if ((this._RD_ID != value))
				{
					this.OnRD_IDChanging(value);
					this.SendPropertyChanging();
					this._RD_ID = value;
					this.SendPropertyChanged("RD_ID");
					this.OnRD_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="ReportTemplate", Storage="_ReportTemplate1", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary ReportTemplate1
		{
			get
			{
				return this._ReportTemplate1;
			}
			set
			{
				if ((this._ReportTemplate1 != value))
				{
					this.OnReportTemplate1Changing(value);
					this.SendPropertyChanging();
					this._ReportTemplate1 = value;
					this.SendPropertyChanged("ReportTemplate1");
					this.OnReportTemplate1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuName", DbType="VarChar(50)")]
		public string MenuName
		{
			get
			{
				return this._MenuName;
			}
			set
			{
				if ((this._MenuName != value))
				{
					this.OnMenuNameChanging(value);
					this.SendPropertyChanging();
					this._MenuName = value;
					this.SendPropertyChanged("MenuName");
					this.OnMenuNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsUse", DbType="Bit")]
		public System.Nullable<bool> IsUse
		{
			get
			{
				return this._IsUse;
			}
			set
			{
				if ((this._IsUse != value))
				{
					this.OnIsUseChanging(value);
					this.SendPropertyChanging();
					this._IsUse = value;
					this.SendPropertyChanged("IsUse");
					this.OnIsUseChanged();
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