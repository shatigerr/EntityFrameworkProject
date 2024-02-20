﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Data.Entity.Core.Metadata;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region Metadatos de relaciones en EDM

[assembly: EdmRelationshipAttribute("practicaEdifModel", "FK__Paises__id_conti__4CA06362", "Continentes", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(EntityFrameworkProject.Continentes), "Paises", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(EntityFrameworkProject.Paises), true)]
[assembly: EdmRelationshipAttribute("practicaEdifModel", "FK__Edificios__id_pa__4F7CD00D", "Paises", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(EntityFrameworkProject.Paises), "EdificiosReligiosos", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(EntityFrameworkProject.EdificiosReligiosos), true)]

#endregion

namespace EntityFrameworkProject
{
    #region Contextos

    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class practicaEdifEntities : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto practicaEdifEntities usando la cadena de conexión encontrada en la sección 'practicaEdifEntities' del archivo de configuración de la aplicación.
        /// </summary>
        public practicaEdifEntities() : base("name=practicaEdifEntities", "practicaEdifEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto practicaEdifEntities.
        /// </summary>
        public practicaEdifEntities(string connectionString) : base(connectionString, "practicaEdifEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto practicaEdifEntities.
        /// </summary>
        public practicaEdifEntities(EntityConnection connection) : base(connection, "practicaEdifEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Continentes> Continentes
        {
            get
            {
                if ((_Continentes == null))
                {
                    _Continentes = base.CreateObjectSet<Continentes>("Continentes");
                }
                return _Continentes;
            }
        }
        private ObjectSet<Continentes> _Continentes;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<EdificiosReligiosos> EdificiosReligiosos
        {
            get
            {
                if ((_EdificiosReligiosos == null))
                {
                    _EdificiosReligiosos = base.CreateObjectSet<EdificiosReligiosos>("EdificiosReligiosos");
                }
                return _EdificiosReligiosos;
            }
        }
        private ObjectSet<EdificiosReligiosos> _EdificiosReligiosos;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Paises> Paises
        {
            get
            {
                if ((_Paises == null))
                {
                    _Paises = base.CreateObjectSet<Paises>("Paises");
                }
                return _Paises;
            }
        }
        private ObjectSet<Paises> _Paises;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Continentes. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToContinentes(Continentes continentes)
        {
            base.AddObject("Continentes", continentes);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet EdificiosReligiosos. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToEdificiosReligiosos(EdificiosReligiosos edificiosReligiosos)
        {
            base.AddObject("EdificiosReligiosos", edificiosReligiosos);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Paises. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToPaises(Paises paises)
        {
            base.AddObject("Paises", paises);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="practicaEdifModel", Name="Continentes")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Continentes : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Continentes.
        /// </summary>
        /// <param name="id_continente">Valor inicial de la propiedad id_continente.</param>
        public static Continentes CreateContinentes(global::System.Int32 id_continente)
        {
            Continentes continentes = new Continentes();
            continentes.id_continente = id_continente;
            return continentes;
        }

        #endregion

        #region Propiedades simples
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id_continente
        {
            get
            {
                return _id_continente;
            }
            set
            {
                if (_id_continente != value)
                {
                    Onid_continenteChanging(value);
                    ReportPropertyChanging("id_continente");
                    _id_continente = StructuralObject.SetValidValue(value, "id_continente");
                    ReportPropertyChanged("id_continente");
                    Onid_continenteChanged();
                }
            }
        }
        private global::System.Int32 _id_continente;
        partial void Onid_continenteChanging(global::System.Int32 value);
        partial void Onid_continenteChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String nombre_continente
        {
            get
            {
                return _nombre_continente;
            }
            set
            {
                Onnombre_continenteChanging(value);
                ReportPropertyChanging("nombre_continente");
                _nombre_continente = StructuralObject.SetValidValue(value, true, "nombre_continente");
                ReportPropertyChanged("nombre_continente");
                Onnombre_continenteChanged();
            }
        }
        private global::System.String _nombre_continente;
        partial void Onnombre_continenteChanging(global::System.String value);
        partial void Onnombre_continenteChanged();

        #endregion

        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("practicaEdifModel", "FK__Paises__id_conti__4CA06362", "Paises")]
        public EntityCollection<Paises> Paises
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Paises>("practicaEdifModel.FK__Paises__id_conti__4CA06362", "Paises");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Paises>("practicaEdifModel.FK__Paises__id_conti__4CA06362", "Paises", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="practicaEdifModel", Name="EdificiosReligiosos")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EdificiosReligiosos : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto EdificiosReligiosos.
        /// </summary>
        /// <param name="id_edificio">Valor inicial de la propiedad id_edificio.</param>
        public static EdificiosReligiosos CreateEdificiosReligiosos(global::System.Int32 id_edificio)
        {
            EdificiosReligiosos edificiosReligiosos = new EdificiosReligiosos();
            edificiosReligiosos.id_edificio = id_edificio;
            return edificiosReligiosos;
        }

        #endregion

        #region Propiedades simples
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id_edificio
        {
            get
            {
                return _id_edificio;
            }
            set
            {
                if (_id_edificio != value)
                {
                    Onid_edificioChanging(value);
                    ReportPropertyChanging("id_edificio");
                    _id_edificio = StructuralObject.SetValidValue(value, "id_edificio");
                    ReportPropertyChanged("id_edificio");
                    Onid_edificioChanged();
                }
            }
        }
        private global::System.Int32 _id_edificio;
        partial void Onid_edificioChanging(global::System.Int32 value);
        partial void Onid_edificioChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                OnnombreChanging(value);
                ReportPropertyChanging("nombre");
                _nombre = StructuralObject.SetValidValue(value, true, "nombre");
                ReportPropertyChanged("nombre");
                OnnombreChanged();
            }
        }
        private global::System.String _nombre;
        partial void OnnombreChanging(global::System.String value);
        partial void OnnombreChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ubicacion
        {
            get
            {
                return _ubicacion;
            }
            set
            {
                OnubicacionChanging(value);
                ReportPropertyChanging("ubicacion");
                _ubicacion = StructuralObject.SetValidValue(value, true, "ubicacion");
                ReportPropertyChanged("ubicacion");
                OnubicacionChanged();
            }
        }
        private global::System.String _ubicacion;
        partial void OnubicacionChanging(global::System.String value);
        partial void OnubicacionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> capacidad
        {
            get
            {
                return _capacidad;
            }
            set
            {
                OncapacidadChanging(value);
                ReportPropertyChanging("capacidad");
                _capacidad = StructuralObject.SetValidValue(value, "capacidad");
                ReportPropertyChanged("capacidad");
                OncapacidadChanged();
            }
        }
        private Nullable<global::System.Int32> _capacidad;
        partial void OncapacidadChanging(Nullable<global::System.Int32> value);
        partial void OncapacidadChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> fecha_construccion
        {
            get
            {
                return _fecha_construccion;
            }
            set
            {
                Onfecha_construccionChanging(value);
                ReportPropertyChanging("fecha_construccion");
                _fecha_construccion = StructuralObject.SetValidValue(value, "fecha_construccion");
                ReportPropertyChanged("fecha_construccion");
                Onfecha_construccionChanged();
            }
        }
        private Nullable<global::System.DateTime> _fecha_construccion;
        partial void Onfecha_construccionChanging(Nullable<global::System.DateTime> value);
        partial void Onfecha_construccionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String denominacion_religiosa
        {
            get
            {
                return _denominacion_religiosa;
            }
            set
            {
                Ondenominacion_religiosaChanging(value);
                ReportPropertyChanging("denominacion_religiosa");
                _denominacion_religiosa = StructuralObject.SetValidValue(value, true, "denominacion_religiosa");
                ReportPropertyChanged("denominacion_religiosa");
                Ondenominacion_religiosaChanged();
            }
        }
        private global::System.String _denominacion_religiosa;
        partial void Ondenominacion_religiosaChanging(global::System.String value);
        partial void Ondenominacion_religiosaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ressenya
        {
            get
            {
                return _ressenya;
            }
            set
            {
                OnressenyaChanging(value);
                ReportPropertyChanging("ressenya");
                _ressenya = StructuralObject.SetValidValue(value, true, "ressenya");
                ReportPropertyChanged("ressenya");
                OnressenyaChanged();
            }
        }
        private global::System.String _ressenya;
        partial void OnressenyaChanging(global::System.String value);
        partial void OnressenyaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> id_pais
        {
            get
            {
                return _id_pais;
            }
            set
            {
                Onid_paisChanging(value);
                ReportPropertyChanging("id_pais");
                _id_pais = StructuralObject.SetValidValue(value, "id_pais");
                ReportPropertyChanged("id_pais");
                Onid_paisChanged();
            }
        }
        private Nullable<global::System.Int32> _id_pais;
        partial void Onid_paisChanging(Nullable<global::System.Int32> value);
        partial void Onid_paisChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String google_maps_link
        {
            get
            {
                return _google_maps_link;
            }
            set
            {
                Ongoogle_maps_linkChanging(value);
                ReportPropertyChanging("google_maps_link");
                _google_maps_link = StructuralObject.SetValidValue(value, true, "google_maps_link");
                ReportPropertyChanged("google_maps_link");
                Ongoogle_maps_linkChanged();
            }
        }
        private global::System.String _google_maps_link;
        partial void Ongoogle_maps_linkChanging(global::System.String value);
        partial void Ongoogle_maps_linkChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String web_link
        {
            get
            {
                return _web_link;
            }
            set
            {
                Onweb_linkChanging(value);
                ReportPropertyChanging("web_link");
                _web_link = StructuralObject.SetValidValue(value, true, "web_link");
                ReportPropertyChanged("web_link");
                Onweb_linkChanged();
            }
        }
        private global::System.String _web_link;
        partial void Onweb_linkChanging(global::System.String value);
        partial void Onweb_linkChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String wikipedia_link
        {
            get
            {
                return _wikipedia_link;
            }
            set
            {
                Onwikipedia_linkChanging(value);
                ReportPropertyChanging("wikipedia_link");
                _wikipedia_link = StructuralObject.SetValidValue(value, true, "wikipedia_link");
                ReportPropertyChanged("wikipedia_link");
                Onwikipedia_linkChanged();
            }
        }
        private global::System.String _wikipedia_link;
        partial void Onwikipedia_linkChanging(global::System.String value);
        partial void Onwikipedia_linkChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String imagen_portada_base64
        {
            get
            {
                return _imagen_portada_base64;
            }
            set
            {
                Onimagen_portada_base64Changing(value);
                ReportPropertyChanging("imagen_portada_base64");
                _imagen_portada_base64 = StructuralObject.SetValidValue(value, true, "imagen_portada_base64");
                ReportPropertyChanged("imagen_portada_base64");
                Onimagen_portada_base64Changed();
            }
        }
        private global::System.String _imagen_portada_base64;
        partial void Onimagen_portada_base64Changing(global::System.String value);
        partial void Onimagen_portada_base64Changed();

        #endregion

        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("practicaEdifModel", "FK__Edificios__id_pa__4F7CD00D", "Paises")]
        public Paises Paises
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Paises>("practicaEdifModel.FK__Edificios__id_pa__4F7CD00D", "Paises").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Paises>("practicaEdifModel.FK__Edificios__id_pa__4F7CD00D", "Paises").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Paises> PaisesReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Paises>("practicaEdifModel.FK__Edificios__id_pa__4F7CD00D", "Paises");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Paises>("practicaEdifModel.FK__Edificios__id_pa__4F7CD00D", "Paises", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="practicaEdifModel", Name="Paises")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Paises : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Paises.
        /// </summary>
        /// <param name="id_pais">Valor inicial de la propiedad id_pais.</param>
        public static Paises CreatePaises(global::System.Int32 id_pais)
        {
            Paises paises = new Paises();
            paises.id_pais = id_pais;
            return paises;
        }

        #endregion

        #region Propiedades simples
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id_pais
        {
            get
            {
                return _id_pais;
            }
            set
            {
                if (_id_pais != value)
                {
                    Onid_paisChanging(value);
                    ReportPropertyChanging("id_pais");
                    _id_pais = StructuralObject.SetValidValue(value, "id_pais");
                    ReportPropertyChanged("id_pais");
                    Onid_paisChanged();
                }
            }
        }
        private global::System.Int32 _id_pais;
        partial void Onid_paisChanging(global::System.Int32 value);
        partial void Onid_paisChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String nombre_pais
        {
            get
            {
                return _nombre_pais;
            }
            set
            {
                Onnombre_paisChanging(value);
                ReportPropertyChanging("nombre_pais");
                _nombre_pais = StructuralObject.SetValidValue(value, true, "nombre_pais");
                ReportPropertyChanged("nombre_pais");
                Onnombre_paisChanged();
            }
        }
        private global::System.String _nombre_pais;
        partial void Onnombre_paisChanging(global::System.String value);
        partial void Onnombre_paisChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> id_continente
        {
            get
            {
                return _id_continente;
            }
            set
            {
                Onid_continenteChanging(value);
                ReportPropertyChanging("id_continente");
                _id_continente = StructuralObject.SetValidValue(value, "id_continente");
                ReportPropertyChanged("id_continente");
                Onid_continenteChanged();
            }
        }
        private Nullable<global::System.Int32> _id_continente;
        partial void Onid_continenteChanging(Nullable<global::System.Int32> value);
        partial void Onid_continenteChanged();

        #endregion

        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("practicaEdifModel", "FK__Paises__id_conti__4CA06362", "Continentes")]
        public Continentes Continentes
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Continentes>("practicaEdifModel.FK__Paises__id_conti__4CA06362", "Continentes").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Continentes>("practicaEdifModel.FK__Paises__id_conti__4CA06362", "Continentes").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Continentes> ContinentesReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Continentes>("practicaEdifModel.FK__Paises__id_conti__4CA06362", "Continentes");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Continentes>("practicaEdifModel.FK__Paises__id_conti__4CA06362", "Continentes", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("practicaEdifModel", "FK__Edificios__id_pa__4F7CD00D", "EdificiosReligiosos")]
        public EntityCollection<EdificiosReligiosos> EdificiosReligiosos
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<EdificiosReligiosos>("practicaEdifModel.FK__Edificios__id_pa__4F7CD00D", "EdificiosReligiosos");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<EdificiosReligiosos>("practicaEdifModel.FK__Edificios__id_pa__4F7CD00D", "EdificiosReligiosos", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
