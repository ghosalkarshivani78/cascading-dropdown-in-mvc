//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("test3Model", "city_ibfk_1", "state", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(cascading_dropdown_mvc.Models.state), "city", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(cascading_dropdown_mvc.Models.city), true)]
[assembly: EdmRelationshipAttribute("test3Model", "state_ibfk_1", "country", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(cascading_dropdown_mvc.Models.country), "state", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(cascading_dropdown_mvc.Models.state), true)]

#endregion

namespace cascading_dropdown_mvc.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class test3Entities1 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new test3Entities1 object using the connection string found in the 'test3Entities1' section of the application configuration file.
        /// </summary>
        public test3Entities1() : base("name=test3Entities1", "test3Entities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new test3Entities1 object.
        /// </summary>
        public test3Entities1(string connectionString) : base(connectionString, "test3Entities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new test3Entities1 object.
        /// </summary>
        public test3Entities1(EntityConnection connection) : base(connection, "test3Entities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<city> cities
        {
            get
            {
                if ((_cities == null))
                {
                    _cities = base.CreateObjectSet<city>("cities");
                }
                return _cities;
            }
        }
        private ObjectSet<city> _cities;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<country> countries
        {
            get
            {
                if ((_countries == null))
                {
                    _countries = base.CreateObjectSet<country>("countries");
                }
                return _countries;
            }
        }
        private ObjectSet<country> _countries;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<state> states
        {
            get
            {
                if ((_states == null))
                {
                    _states = base.CreateObjectSet<state>("states");
                }
                return _states;
            }
        }
        private ObjectSet<state> _states;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the cities EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTocities(city city)
        {
            base.AddObject("cities", city);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the countries EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTocountries(country country)
        {
            base.AddObject("countries", country);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the states EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTostates(state state)
        {
            base.AddObject("states", state);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="test3Model", Name="city")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class city : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new city object.
        /// </summary>
        /// <param name="cityid">Initial value of the cityid property.</param>
        /// <param name="cityname">Initial value of the cityname property.</param>
        /// <param name="stateid">Initial value of the stateid property.</param>
        public static city Createcity(global::System.Int32 cityid, global::System.String cityname, global::System.Int32 stateid)
        {
            city city = new city();
            city.cityid = cityid;
            city.cityname = cityname;
            city.stateid = stateid;
            return city;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 cityid
        {
            get
            {
                return _cityid;
            }
            set
            {
                if (_cityid != value)
                {
                    OncityidChanging(value);
                    ReportPropertyChanging("cityid");
                    _cityid = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("cityid");
                    OncityidChanged();
                }
            }
        }
        private global::System.Int32 _cityid;
        partial void OncityidChanging(global::System.Int32 value);
        partial void OncityidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String cityname
        {
            get
            {
                return _cityname;
            }
            set
            {
                OncitynameChanging(value);
                ReportPropertyChanging("cityname");
                _cityname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("cityname");
                OncitynameChanged();
            }
        }
        private global::System.String _cityname;
        partial void OncitynameChanging(global::System.String value);
        partial void OncitynameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 stateid
        {
            get
            {
                return _stateid;
            }
            set
            {
                OnstateidChanging(value);
                ReportPropertyChanging("stateid");
                _stateid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("stateid");
                OnstateidChanged();
            }
        }
        private global::System.Int32 _stateid;
        partial void OnstateidChanging(global::System.Int32 value);
        partial void OnstateidChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("test3Model", "city_ibfk_1", "state")]
        public state state
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<state>("test3Model.city_ibfk_1", "state").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<state>("test3Model.city_ibfk_1", "state").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<state> stateReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<state>("test3Model.city_ibfk_1", "state");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<state>("test3Model.city_ibfk_1", "state", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="test3Model", Name="country")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class country : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new country object.
        /// </summary>
        /// <param name="countryid">Initial value of the countryid property.</param>
        /// <param name="countryname">Initial value of the countryname property.</param>
        public static country Createcountry(global::System.Int32 countryid, global::System.String countryname)
        {
            country country = new country();
            country.countryid = countryid;
            country.countryname = countryname;
            return country;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 countryid
        {
            get
            {
                return _countryid;
            }
            set
            {
                if (_countryid != value)
                {
                    OncountryidChanging(value);
                    ReportPropertyChanging("countryid");
                    _countryid = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("countryid");
                    OncountryidChanged();
                }
            }
        }
        private global::System.Int32 _countryid;
        partial void OncountryidChanging(global::System.Int32 value);
        partial void OncountryidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String countryname
        {
            get
            {
                return _countryname;
            }
            set
            {
                OncountrynameChanging(value);
                ReportPropertyChanging("countryname");
                _countryname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("countryname");
                OncountrynameChanged();
            }
        }
        private global::System.String _countryname;
        partial void OncountrynameChanging(global::System.String value);
        partial void OncountrynameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("test3Model", "state_ibfk_1", "state")]
        public EntityCollection<state> states
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<state>("test3Model.state_ibfk_1", "state");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<state>("test3Model.state_ibfk_1", "state", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="test3Model", Name="state")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class state : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new state object.
        /// </summary>
        /// <param name="stateid">Initial value of the stateid property.</param>
        /// <param name="statename">Initial value of the statename property.</param>
        /// <param name="countryid">Initial value of the countryid property.</param>
        public static state Createstate(global::System.Int32 stateid, global::System.String statename, global::System.Int32 countryid)
        {
            state state = new state();
            state.stateid = stateid;
            state.statename = statename;
            state.countryid = countryid;
            return state;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 stateid
        {
            get
            {
                return _stateid;
            }
            set
            {
                if (_stateid != value)
                {
                    OnstateidChanging(value);
                    ReportPropertyChanging("stateid");
                    _stateid = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("stateid");
                    OnstateidChanged();
                }
            }
        }
        private global::System.Int32 _stateid;
        partial void OnstateidChanging(global::System.Int32 value);
        partial void OnstateidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String statename
        {
            get
            {
                return _statename;
            }
            set
            {
                OnstatenameChanging(value);
                ReportPropertyChanging("statename");
                _statename = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("statename");
                OnstatenameChanged();
            }
        }
        private global::System.String _statename;
        partial void OnstatenameChanging(global::System.String value);
        partial void OnstatenameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 countryid
        {
            get
            {
                return _countryid;
            }
            set
            {
                OncountryidChanging(value);
                ReportPropertyChanging("countryid");
                _countryid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("countryid");
                OncountryidChanged();
            }
        }
        private global::System.Int32 _countryid;
        partial void OncountryidChanging(global::System.Int32 value);
        partial void OncountryidChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("test3Model", "city_ibfk_1", "city")]
        public EntityCollection<city> cities
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<city>("test3Model.city_ibfk_1", "city");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<city>("test3Model.city_ibfk_1", "city", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("test3Model", "state_ibfk_1", "country")]
        public country country
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<country>("test3Model.state_ibfk_1", "country").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<country>("test3Model.state_ibfk_1", "country").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<country> countryReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<country>("test3Model.state_ibfk_1", "country");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<country>("test3Model.state_ibfk_1", "country", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
