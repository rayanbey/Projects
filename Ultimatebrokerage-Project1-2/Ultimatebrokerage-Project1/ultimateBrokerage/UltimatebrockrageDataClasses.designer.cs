﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ultimateBrokerage
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Ultimatebrockrage")]
	public partial class UltimatebrockrageDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertRequestss(Requestss instance);
    partial void UpdateRequestss(Requestss instance);
    partial void DeleteRequestss(Requestss instance);
    partial void Insertproperty(property instance);
    partial void Updateproperty(property instance);
    partial void Deleteproperty(property instance);
    #endregion
		
		public UltimatebrockrageDataClassesDataContext() : 
				base(global::ultimateBrokerage.Properties.Settings.Default.UltimatebrockrageConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public UltimatebrockrageDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UltimatebrockrageDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UltimatebrockrageDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UltimatebrockrageDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Requestss> Requestsses
		{
			get
			{
				return this.GetTable<Requestss>();
			}
		}
		
		public System.Data.Linq.Table<property> properties
		{
			get
			{
				return this.GetTable<property>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Requestss")]
	public partial class Requestss : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _request_Id;
		
		private string _name;
		
		private string _phone;
		
		private string _refernces;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onrequest_IdChanging(string value);
    partial void Onrequest_IdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    partial void OnreferncesChanging(string value);
    partial void OnreferncesChanged();
    #endregion
		
		public Requestss()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_request_Id", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string request_Id
		{
			get
			{
				return this._request_Id;
			}
			set
			{
				if ((this._request_Id != value))
				{
					this.Onrequest_IdChanging(value);
					this.SendPropertyChanging();
					this._request_Id = value;
					this.SendPropertyChanged("request_Id");
					this.Onrequest_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_refernces", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string refernces
		{
			get
			{
				return this._refernces;
			}
			set
			{
				if ((this._refernces != value))
				{
					this.OnreferncesChanging(value);
					this.SendPropertyChanging();
					this._refernces = value;
					this.SendPropertyChanged("refernces");
					this.OnreferncesChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.property")]
	public partial class property : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _reference;
		
		private string _exchange;
		
		private string _type;
		
		private string _areaname;
		
		private string _size;
		
		private string _bedrooms;
		
		private string _bathrooms;
		
		private string _floor;
		
		private string _parking;
		
		private string _price;
		
		private System.Data.Linq.Binary _Photo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnreferenceChanging(string value);
    partial void OnreferenceChanged();
    partial void OnexchangeChanging(string value);
    partial void OnexchangeChanged();
    partial void OntypeChanging(string value);
    partial void OntypeChanged();
    partial void OnareanameChanging(string value);
    partial void OnareanameChanged();
    partial void OnsizeChanging(string value);
    partial void OnsizeChanged();
    partial void OnbedroomsChanging(string value);
    partial void OnbedroomsChanged();
    partial void OnbathroomsChanging(string value);
    partial void OnbathroomsChanged();
    partial void OnfloorChanging(string value);
    partial void OnfloorChanged();
    partial void OnparkingChanging(string value);
    partial void OnparkingChanged();
    partial void OnpriceChanging(string value);
    partial void OnpriceChanged();
    partial void OnPhotoChanging(System.Data.Linq.Binary value);
    partial void OnPhotoChanged();
    #endregion
		
		public property()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_reference", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string reference
		{
			get
			{
				return this._reference;
			}
			set
			{
				if ((this._reference != value))
				{
					this.OnreferenceChanging(value);
					this.SendPropertyChanging();
					this._reference = value;
					this.SendPropertyChanged("reference");
					this.OnreferenceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_exchange", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string exchange
		{
			get
			{
				return this._exchange;
			}
			set
			{
				if ((this._exchange != value))
				{
					this.OnexchangeChanging(value);
					this.SendPropertyChanging();
					this._exchange = value;
					this.SendPropertyChanged("exchange");
					this.OnexchangeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this.OntypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("type");
					this.OntypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_areaname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string areaname
		{
			get
			{
				return this._areaname;
			}
			set
			{
				if ((this._areaname != value))
				{
					this.OnareanameChanging(value);
					this.SendPropertyChanging();
					this._areaname = value;
					this.SendPropertyChanged("areaname");
					this.OnareanameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_size", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string size
		{
			get
			{
				return this._size;
			}
			set
			{
				if ((this._size != value))
				{
					this.OnsizeChanging(value);
					this.SendPropertyChanging();
					this._size = value;
					this.SendPropertyChanged("size");
					this.OnsizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bedrooms", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string bedrooms
		{
			get
			{
				return this._bedrooms;
			}
			set
			{
				if ((this._bedrooms != value))
				{
					this.OnbedroomsChanging(value);
					this.SendPropertyChanging();
					this._bedrooms = value;
					this.SendPropertyChanged("bedrooms");
					this.OnbedroomsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bathrooms", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string bathrooms
		{
			get
			{
				return this._bathrooms;
			}
			set
			{
				if ((this._bathrooms != value))
				{
					this.OnbathroomsChanging(value);
					this.SendPropertyChanging();
					this._bathrooms = value;
					this.SendPropertyChanged("bathrooms");
					this.OnbathroomsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_floor", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string floor
		{
			get
			{
				return this._floor;
			}
			set
			{
				if ((this._floor != value))
				{
					this.OnfloorChanging(value);
					this.SendPropertyChanging();
					this._floor = value;
					this.SendPropertyChanged("floor");
					this.OnfloorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_parking", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string parking
		{
			get
			{
				return this._parking;
			}
			set
			{
				if ((this._parking != value))
				{
					this.OnparkingChanging(value);
					this.SendPropertyChanging();
					this._parking = value;
					this.SendPropertyChanged("parking");
					this.OnparkingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Photo", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Photo
		{
			get
			{
				return this._Photo;
			}
			set
			{
				if ((this._Photo != value))
				{
					this.OnPhotoChanging(value);
					this.SendPropertyChanging();
					this._Photo = value;
					this.SendPropertyChanged("Photo");
					this.OnPhotoChanged();
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