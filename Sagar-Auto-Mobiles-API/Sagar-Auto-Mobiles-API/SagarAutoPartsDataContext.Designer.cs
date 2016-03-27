﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 27-03-2016 10:07:31
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using Devart.Data.Linq;
using Devart.Data.Linq.Mapping;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;

namespace SagarautopartContext
{

    [DatabaseAttribute(Name = "sagar-auto-parts")]
    [ProviderAttribute(typeof(Devart.Data.MySql.Linq.Provider.MySqlDataProvider))]
    public partial class SagarautopartDataContext : Devart.Data.Linq.DataContext
    {
        public static CompiledQueryCache compiledQueryCache = CompiledQueryCache.RegisterDataContext(typeof(SagarautopartDataContext));
        private static MappingSource mappingSource = new Devart.Data.Linq.Mapping.AttributeMappingSource();

        #region Extensibility Method Definitions
    
        partial void OnCreated();
        partial void OnSubmitError(Devart.Data.Linq.SubmitErrorEventArgs args);
        partial void InsertAdmin(Admin instance);
        partial void UpdateAdmin(Admin instance);
        partial void DeleteAdmin(Admin instance);

        #endregion

        public SagarautopartDataContext() :
        base(GetConnectionString("SagarAutoParts"), mappingSource)
        {
            OnCreated();
        }

        public SagarautopartDataContext(MappingSource mappingSource) :
        base(GetConnectionString("SagarAutoParts"), mappingSource)
        {
            OnCreated();
        }

        private static string GetConnectionString(string connectionStringName)
        {
            System.Configuration.ConnectionStringSettings connectionStringSettings = System.Configuration.ConfigurationManager.ConnectionStrings[connectionStringName];
            if (connectionStringSettings == null)
                throw new InvalidOperationException("Connection string \"" + connectionStringName +"\" could not be found in the configuration file.");
            return connectionStringSettings.ConnectionString;
        }

        public SagarautopartDataContext(string connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public SagarautopartDataContext(System.Data.IDbConnection connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public SagarautopartDataContext(string connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public SagarautopartDataContext(System.Data.IDbConnection connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public Devart.Data.Linq.Table<Admin> Admins
        {
            get
            {
                return this.GetTable<Admin>();
            }
        }
    }
}

namespace SagarautopartContext
{

    /// <summary>
    /// There are no comments for SagarautopartContext.Admin in the schema.
    /// </summary>
    [Table(Name = @"`sagar-auto-parts`.admin")]
    public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private string _Email;

        private string _FirstName;

        private string _LastName;

        private string _Password;
        #pragma warning restore 0649
    
        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnEmailChanging(string value);
        partial void OnEmailChanged();
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
        partial void OnPasswordChanging(string value);
        partial void OnPasswordChanged();
        #endregion

        public Admin()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for Email in the schema.
        /// </summary>
        [Column(Storage = "_Email", CanBeNull = false, DbType = "VARCHAR(100) NOT NULL", IsPrimaryKey = true)]
        public string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                if (this._Email != value)
                {
                    this.OnEmailChanging(value);
                    this.SendPropertyChanging();
                    this._Email = value;
                    this.SendPropertyChanged("Email");
                    this.OnEmailChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for FirstName in the schema.
        /// </summary>
        [Column(Storage = "_FirstName", CanBeNull = false, DbType = "VARCHAR(30) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                if (this._FirstName != value)
                {
                    this.OnFirstNameChanging(value);
                    this.SendPropertyChanging();
                    this._FirstName = value;
                    this.SendPropertyChanged("FirstName");
                    this.OnFirstNameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for LastName in the schema.
        /// </summary>
        [Column(Storage = "_LastName", DbType = "VARCHAR(30) NULL", UpdateCheck = UpdateCheck.Never)]
        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                if (this._LastName != value)
                {
                    this.OnLastNameChanging(value);
                    this.SendPropertyChanging();
                    this._LastName = value;
                    this.SendPropertyChanged("LastName");
                    this.OnLastNameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Password in the schema.
        /// </summary>
        [Column(Name = @"`Password`", Storage = "_Password", CanBeNull = false, DbType = "VARCHAR(35) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Password
        {
            get
            {
                return this._Password;
            }
            set
            {
                if (this._Password != value)
                {
                    this.OnPasswordChanging(value);
                    this.SendPropertyChanging();
                    this._Password = value;
                    this.SendPropertyChanged("Password");
                    this.OnPasswordChanged();
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {    
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {    
		        var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
