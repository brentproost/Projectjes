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

namespace Wcf
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AP")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTbl_Rechten(Tbl_Rechten instance);
    partial void UpdateTbl_Rechten(Tbl_Rechten instance);
    partial void DeleteTbl_Rechten(Tbl_Rechten instance);
    partial void InsertTbl_Schaal(Tbl_Schaal instance);
    partial void UpdateTbl_Schaal(Tbl_Schaal instance);
    partial void DeleteTbl_Schaal(Tbl_Schaal instance);
    partial void InsertTbl_Score(Tbl_Score instance);
    partial void UpdateTbl_Score(Tbl_Score instance);
    partial void DeleteTbl_Score(Tbl_Score instance);
    partial void InsertTbl_Weersomstandigheden(Tbl_Weersomstandigheden instance);
    partial void UpdateTbl_Weersomstandigheden(Tbl_Weersomstandigheden instance);
    partial void DeleteTbl_Weersomstandigheden(Tbl_Weersomstandigheden instance);
    partial void InsertTbl_User(Tbl_User instance);
    partial void UpdateTbl_User(Tbl_User instance);
    partial void DeleteTbl_User(Tbl_User instance);
    partial void InsertTbl_Activiteiten(Tbl_Activiteiten instance);
    partial void UpdateTbl_Activiteiten(Tbl_Activiteiten instance);
    partial void DeleteTbl_Activiteiten(Tbl_Activiteiten instance);
    partial void InsertTbl_Categorien(Tbl_Categorien instance);
    partial void UpdateTbl_Categorien(Tbl_Categorien instance);
    partial void DeleteTbl_Categorien(Tbl_Categorien instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["APConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Tbl_Rechten> Tbl_Rechtens
		{
			get
			{
				return this.GetTable<Tbl_Rechten>();
			}
		}
		
		public System.Data.Linq.Table<Tbl_Schaal> Tbl_Schaals
		{
			get
			{
				return this.GetTable<Tbl_Schaal>();
			}
		}
		
		public System.Data.Linq.Table<Tbl_Score> Tbl_Scores
		{
			get
			{
				return this.GetTable<Tbl_Score>();
			}
		}
		
		public System.Data.Linq.Table<Tbl_Weersomstandigheden> Tbl_Weersomstandighedens
		{
			get
			{
				return this.GetTable<Tbl_Weersomstandigheden>();
			}
		}
		
		public System.Data.Linq.Table<Tbl_User> Tbl_Users
		{
			get
			{
				return this.GetTable<Tbl_User>();
			}
		}
		
		public System.Data.Linq.Table<Tbl_Activiteiten> Tbl_Activiteitens
		{
			get
			{
				return this.GetTable<Tbl_Activiteiten>();
			}
		}
		
		public System.Data.Linq.Table<Tbl_Categorien> Tbl_Categoriens
		{
			get
			{
				return this.GetTable<Tbl_Categorien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_Rechten")]
	public partial class Tbl_Rechten : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Omschrijving;
		
		private string _Toestemming_Omschrijving;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnOmschrijvingChanging(string value);
    partial void OnOmschrijvingChanged();
    partial void OnToestemming_OmschrijvingChanging(string value);
    partial void OnToestemming_OmschrijvingChanged();
    #endregion
		
		public Tbl_Rechten()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Omschrijving", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string Omschrijving
		{
			get
			{
				return this._Omschrijving;
			}
			set
			{
				if ((this._Omschrijving != value))
				{
					this.OnOmschrijvingChanging(value);
					this.SendPropertyChanging();
					this._Omschrijving = value;
					this.SendPropertyChanged("Omschrijving");
					this.OnOmschrijvingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Toestemming_Omschrijving", DbType="NChar(50)")]
		public string Toestemming_Omschrijving
		{
			get
			{
				return this._Toestemming_Omschrijving;
			}
			set
			{
				if ((this._Toestemming_Omschrijving != value))
				{
					this.OnToestemming_OmschrijvingChanging(value);
					this.SendPropertyChanging();
					this._Toestemming_Omschrijving = value;
					this.SendPropertyChanged("Toestemming_Omschrijving");
					this.OnToestemming_OmschrijvingChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_Schaal")]
	public partial class Tbl_Schaal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Omschrijving;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnOmschrijvingChanging(string value);
    partial void OnOmschrijvingChanged();
    #endregion
		
		public Tbl_Schaal()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Omschrijving", DbType="NChar(10)")]
		public string Omschrijving
		{
			get
			{
				return this._Omschrijving;
			}
			set
			{
				if ((this._Omschrijving != value))
				{
					this.OnOmschrijvingChanging(value);
					this.SendPropertyChanging();
					this._Omschrijving = value;
					this.SendPropertyChanged("Omschrijving");
					this.OnOmschrijvingChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_Scores")]
	public partial class Tbl_Score : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _User_ID;
		
		private int _Activiteit_ID;
		
		private System.DateTime _Datum_Uur_Ingave;
		
		private System.DateTime _Datum_Uur_Activiteit;
		
		private string _Commentaar;
		
		private int _Weersomstandigheden_ID;
		
		private int _Schaal_Nachtrust_ID;
		
		private int _Aantal_Uren_Geslapen;
		
		private byte _Vermoeidheid;
		
		private byte _Belangrijkheid;
		
		private byte _Tevredenheid;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnActiviteit_IDChanging(int value);
    partial void OnActiviteit_IDChanged();
    partial void OnDatum_Uur_IngaveChanging(System.DateTime value);
    partial void OnDatum_Uur_IngaveChanged();
    partial void OnDatum_Uur_ActiviteitChanging(System.DateTime value);
    partial void OnDatum_Uur_ActiviteitChanged();
    partial void OnCommentaarChanging(string value);
    partial void OnCommentaarChanged();
    partial void OnWeersomstandigheden_IDChanging(int value);
    partial void OnWeersomstandigheden_IDChanged();
    partial void OnSchaal_Nachtrust_IDChanging(int value);
    partial void OnSchaal_Nachtrust_IDChanged();
    partial void OnAantal_Uren_GeslapenChanging(int value);
    partial void OnAantal_Uren_GeslapenChanged();
    partial void OnVermoeidheidChanging(byte value);
    partial void OnVermoeidheidChanged();
    partial void OnBelangrijkheidChanging(byte value);
    partial void OnBelangrijkheidChanged();
    partial void OnTevredenheidChanging(byte value);
    partial void OnTevredenheidChanged();
    #endregion
		
		public Tbl_Score()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int NOT NULL")]
		public int User_ID
		{
			get
			{
				return this._User_ID;
			}
			set
			{
				if ((this._User_ID != value))
				{
					this.OnUser_IDChanging(value);
					this.SendPropertyChanging();
					this._User_ID = value;
					this.SendPropertyChanged("User_ID");
					this.OnUser_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Activiteit_ID", DbType="Int NOT NULL")]
		public int Activiteit_ID
		{
			get
			{
				return this._Activiteit_ID;
			}
			set
			{
				if ((this._Activiteit_ID != value))
				{
					this.OnActiviteit_IDChanging(value);
					this.SendPropertyChanging();
					this._Activiteit_ID = value;
					this.SendPropertyChanged("Activiteit_ID");
					this.OnActiviteit_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Datum_Uur_Ingave", DbType="DateTime NOT NULL")]
		public System.DateTime Datum_Uur_Ingave
		{
			get
			{
				return this._Datum_Uur_Ingave;
			}
			set
			{
				if ((this._Datum_Uur_Ingave != value))
				{
					this.OnDatum_Uur_IngaveChanging(value);
					this.SendPropertyChanging();
					this._Datum_Uur_Ingave = value;
					this.SendPropertyChanged("Datum_Uur_Ingave");
					this.OnDatum_Uur_IngaveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Datum_Uur_Activiteit", DbType="DateTime NOT NULL")]
		public System.DateTime Datum_Uur_Activiteit
		{
			get
			{
				return this._Datum_Uur_Activiteit;
			}
			set
			{
				if ((this._Datum_Uur_Activiteit != value))
				{
					this.OnDatum_Uur_ActiviteitChanging(value);
					this.SendPropertyChanging();
					this._Datum_Uur_Activiteit = value;
					this.SendPropertyChanged("Datum_Uur_Activiteit");
					this.OnDatum_Uur_ActiviteitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Commentaar", DbType="NChar(100) NOT NULL", CanBeNull=false)]
		public string Commentaar
		{
			get
			{
				return this._Commentaar;
			}
			set
			{
				if ((this._Commentaar != value))
				{
					this.OnCommentaarChanging(value);
					this.SendPropertyChanging();
					this._Commentaar = value;
					this.SendPropertyChanged("Commentaar");
					this.OnCommentaarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weersomstandigheden_ID", DbType="Int NOT NULL")]
		public int Weersomstandigheden_ID
		{
			get
			{
				return this._Weersomstandigheden_ID;
			}
			set
			{
				if ((this._Weersomstandigheden_ID != value))
				{
					this.OnWeersomstandigheden_IDChanging(value);
					this.SendPropertyChanging();
					this._Weersomstandigheden_ID = value;
					this.SendPropertyChanged("Weersomstandigheden_ID");
					this.OnWeersomstandigheden_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Schaal_Nachtrust_ID", DbType="Int NOT NULL")]
		public int Schaal_Nachtrust_ID
		{
			get
			{
				return this._Schaal_Nachtrust_ID;
			}
			set
			{
				if ((this._Schaal_Nachtrust_ID != value))
				{
					this.OnSchaal_Nachtrust_IDChanging(value);
					this.SendPropertyChanging();
					this._Schaal_Nachtrust_ID = value;
					this.SendPropertyChanged("Schaal_Nachtrust_ID");
					this.OnSchaal_Nachtrust_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Aantal_Uren_Geslapen", DbType="Int NOT NULL")]
		public int Aantal_Uren_Geslapen
		{
			get
			{
				return this._Aantal_Uren_Geslapen;
			}
			set
			{
				if ((this._Aantal_Uren_Geslapen != value))
				{
					this.OnAantal_Uren_GeslapenChanging(value);
					this.SendPropertyChanging();
					this._Aantal_Uren_Geslapen = value;
					this.SendPropertyChanged("Aantal_Uren_Geslapen");
					this.OnAantal_Uren_GeslapenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vermoeidheid", DbType="TinyInt NOT NULL")]
		public byte Vermoeidheid
		{
			get
			{
				return this._Vermoeidheid;
			}
			set
			{
				if ((this._Vermoeidheid != value))
				{
					this.OnVermoeidheidChanging(value);
					this.SendPropertyChanging();
					this._Vermoeidheid = value;
					this.SendPropertyChanged("Vermoeidheid");
					this.OnVermoeidheidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Belangrijkheid", DbType="TinyInt NOT NULL")]
		public byte Belangrijkheid
		{
			get
			{
				return this._Belangrijkheid;
			}
			set
			{
				if ((this._Belangrijkheid != value))
				{
					this.OnBelangrijkheidChanging(value);
					this.SendPropertyChanging();
					this._Belangrijkheid = value;
					this.SendPropertyChanged("Belangrijkheid");
					this.OnBelangrijkheidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tevredenheid", DbType="TinyInt NOT NULL")]
		public byte Tevredenheid
		{
			get
			{
				return this._Tevredenheid;
			}
			set
			{
				if ((this._Tevredenheid != value))
				{
					this.OnTevredenheidChanging(value);
					this.SendPropertyChanging();
					this._Tevredenheid = value;
					this.SendPropertyChanged("Tevredenheid");
					this.OnTevredenheidChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_Weersomstandigheden")]
	public partial class Tbl_Weersomstandigheden : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Omschrijving;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnOmschrijvingChanging(string value);
    partial void OnOmschrijvingChanged();
    #endregion
		
		public Tbl_Weersomstandigheden()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Omschrijving", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string Omschrijving
		{
			get
			{
				return this._Omschrijving;
			}
			set
			{
				if ((this._Omschrijving != value))
				{
					this.OnOmschrijvingChanging(value);
					this.SendPropertyChanging();
					this._Omschrijving = value;
					this.SendPropertyChanged("Omschrijving");
					this.OnOmschrijvingChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_Users")]
	public partial class Tbl_User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Naam;
		
		private string _Voornaam;
		
		private string _Adres;
		
		private int _Nummer;
		
		private string _Plaats;
		
		private int _Postcode;
		
		private string _Gebruikersnaam;
		
		private string _Paswoord;
		
		private int _Rechten_ID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNaamChanging(string value);
    partial void OnNaamChanged();
    partial void OnVoornaamChanging(string value);
    partial void OnVoornaamChanged();
    partial void OnAdresChanging(string value);
    partial void OnAdresChanged();
    partial void OnNummerChanging(int value);
    partial void OnNummerChanged();
    partial void OnPlaatsChanging(string value);
    partial void OnPlaatsChanged();
    partial void OnPostcodeChanging(int value);
    partial void OnPostcodeChanged();
    partial void OnGebruikersnaamChanging(string value);
    partial void OnGebruikersnaamChanged();
    partial void OnPaswoordChanging(string value);
    partial void OnPaswoordChanged();
    partial void OnRechten_IDChanging(int value);
    partial void OnRechten_IDChanged();
    #endregion
		
		public Tbl_User()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Naam", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string Naam
		{
			get
			{
				return this._Naam;
			}
			set
			{
				if ((this._Naam != value))
				{
					this.OnNaamChanging(value);
					this.SendPropertyChanging();
					this._Naam = value;
					this.SendPropertyChanged("Naam");
					this.OnNaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Voornaam", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string Voornaam
		{
			get
			{
				return this._Voornaam;
			}
			set
			{
				if ((this._Voornaam != value))
				{
					this.OnVoornaamChanging(value);
					this.SendPropertyChanging();
					this._Voornaam = value;
					this.SendPropertyChanged("Voornaam");
					this.OnVoornaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adres", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string Adres
		{
			get
			{
				return this._Adres;
			}
			set
			{
				if ((this._Adres != value))
				{
					this.OnAdresChanging(value);
					this.SendPropertyChanging();
					this._Adres = value;
					this.SendPropertyChanged("Adres");
					this.OnAdresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nummer", DbType="Int NOT NULL")]
		public int Nummer
		{
			get
			{
				return this._Nummer;
			}
			set
			{
				if ((this._Nummer != value))
				{
					this.OnNummerChanging(value);
					this.SendPropertyChanging();
					this._Nummer = value;
					this.SendPropertyChanged("Nummer");
					this.OnNummerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Plaats", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string Plaats
		{
			get
			{
				return this._Plaats;
			}
			set
			{
				if ((this._Plaats != value))
				{
					this.OnPlaatsChanging(value);
					this.SendPropertyChanging();
					this._Plaats = value;
					this.SendPropertyChanged("Plaats");
					this.OnPlaatsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Postcode", DbType="Int NOT NULL")]
		public int Postcode
		{
			get
			{
				return this._Postcode;
			}
			set
			{
				if ((this._Postcode != value))
				{
					this.OnPostcodeChanging(value);
					this.SendPropertyChanging();
					this._Postcode = value;
					this.SendPropertyChanged("Postcode");
					this.OnPostcodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gebruikersnaam", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string Gebruikersnaam
		{
			get
			{
				return this._Gebruikersnaam;
			}
			set
			{
				if ((this._Gebruikersnaam != value))
				{
					this.OnGebruikersnaamChanging(value);
					this.SendPropertyChanging();
					this._Gebruikersnaam = value;
					this.SendPropertyChanged("Gebruikersnaam");
					this.OnGebruikersnaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Paswoord", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Paswoord
		{
			get
			{
				return this._Paswoord;
			}
			set
			{
				if ((this._Paswoord != value))
				{
					this.OnPaswoordChanging(value);
					this.SendPropertyChanging();
					this._Paswoord = value;
					this.SendPropertyChanged("Paswoord");
					this.OnPaswoordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rechten_ID", DbType="Int NOT NULL")]
		public int Rechten_ID
		{
			get
			{
				return this._Rechten_ID;
			}
			set
			{
				if ((this._Rechten_ID != value))
				{
					this.OnRechten_IDChanging(value);
					this.SendPropertyChanging();
					this._Rechten_ID = value;
					this.SendPropertyChanged("Rechten_ID");
					this.OnRechten_IDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_Activiteiten")]
	public partial class Tbl_Activiteiten : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Omschrijving;
		
		private int _Categorie_ID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnOmschrijvingChanging(string value);
    partial void OnOmschrijvingChanged();
    partial void OnCategorie_IDChanging(int value);
    partial void OnCategorie_IDChanged();
    #endregion
		
		public Tbl_Activiteiten()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Omschrijving", DbType="NChar(100) NOT NULL", CanBeNull=false)]
		public string Omschrijving
		{
			get
			{
				return this._Omschrijving;
			}
			set
			{
				if ((this._Omschrijving != value))
				{
					this.OnOmschrijvingChanging(value);
					this.SendPropertyChanging();
					this._Omschrijving = value;
					this.SendPropertyChanged("Omschrijving");
					this.OnOmschrijvingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Categorie_ID", DbType="Int NOT NULL")]
		public int Categorie_ID
		{
			get
			{
				return this._Categorie_ID;
			}
			set
			{
				if ((this._Categorie_ID != value))
				{
					this.OnCategorie_IDChanging(value);
					this.SendPropertyChanging();
					this._Categorie_ID = value;
					this.SendPropertyChanged("Categorie_ID");
					this.OnCategorie_IDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_Categorien")]
	public partial class Tbl_Categorien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Omschrijving;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnOmschrijvingChanging(string value);
    partial void OnOmschrijvingChanged();
    #endregion
		
		public Tbl_Categorien()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Omschrijving", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string Omschrijving
		{
			get
			{
				return this._Omschrijving;
			}
			set
			{
				if ((this._Omschrijving != value))
				{
					this.OnOmschrijvingChanging(value);
					this.SendPropertyChanging();
					this._Omschrijving = value;
					this.SendPropertyChanged("Omschrijving");
					this.OnOmschrijvingChanged();
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
