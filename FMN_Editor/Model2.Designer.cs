﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace FMN_Editor
{
    #region Kontexte
    
    /// <summary>
    /// Keine Dokumentation für Metadaten verfügbar.
    /// </summary>
    public partial class Model2Container : ObjectContext
    {
        #region Konstruktoren
    
        /// <summary>
        /// Initialisiert ein neues Model2Container-Objekt mithilfe der in Abschnitt 'Model2Container' der Anwendungskonfigurationsdatei gefundenen Verbindungszeichenfolge.
        /// </summary>
        public Model2Container() : base("name=Model2Container", "Model2Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialisiert ein neues Model2Container-Objekt.
        /// </summary>
        public Model2Container(string connectionString) : base(connectionString, "Model2Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialisiert ein neues Model2Container-Objekt.
        /// </summary>
        public Model2Container(EntityConnection connection) : base(connection, "Model2Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partielle Methoden
    
        partial void OnContextCreated();
    
        #endregion
    
    }
    

    #endregion
    
    
}
