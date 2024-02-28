/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.32
 * Contact: info@fattureincloud.it
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = It.FattureInCloud.Sdk.Client.OpenAPIDateConverter;

namespace It.FattureInCloud.Sdk.Model
{
    /// <summary>
    /// DetailedCountry
    /// </summary>
    [DataContract(Name = "DetailedCountry")]
    public partial class DetailedCountry : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedCountry" /> class.
        /// </summary>
        /// <param name="name">Country name.</param>
        /// <param name="settingsName">Country settings name.</param>
        /// <param name="iso">Country iso code.</param>
        /// <param name="fiscalIso">Country fiscal iso code.</param>
        /// <param name="uic">Country uic.</param>
        public DetailedCountry(string name = default(string), string settingsName = default(string), string iso = default(string), string fiscalIso = default(string), string uic = default(string))
        {
            this._Name = name;
            if (this.Name != null)
            {
                this._flagName = true;
            }
            this._SettingsName = settingsName;
            if (this.SettingsName != null)
            {
                this._flagSettingsName = true;
            }
            this._Iso = iso;
            if (this.Iso != null)
            {
                this._flagIso = true;
            }
            this._FiscalIso = fiscalIso;
            if (this.FiscalIso != null)
            {
                this._flagFiscalIso = true;
            }
            this._Uic = uic;
            if (this.Uic != null)
            {
                this._flagUic = true;
            }
        }

        /// <summary>
        /// Country name
        /// </summary>
        /// <value>Country name</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                _flagName = true;
            }
        }
        private string _Name;
        private bool _flagName;

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return _flagName;
        }
        /// <summary>
        /// Country settings name
        /// </summary>
        /// <value>Country settings name</value>
        [DataMember(Name = "settings_name", EmitDefaultValue = true)]
        public string SettingsName
        {
            get { return _SettingsName; }
            set
            {
                _SettingsName = value;
                _flagSettingsName = true;
            }
        }
        private string _SettingsName;
        private bool _flagSettingsName;

        /// <summary>
        /// Returns false as SettingsName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSettingsName()
        {
            return _flagSettingsName;
        }
        /// <summary>
        /// Country iso code
        /// </summary>
        /// <value>Country iso code</value>
        [DataMember(Name = "iso", EmitDefaultValue = true)]
        public string Iso
        {
            get { return _Iso; }
            set
            {
                _Iso = value;
                _flagIso = true;
            }
        }
        private string _Iso;
        private bool _flagIso;

        /// <summary>
        /// Returns false as Iso should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIso()
        {
            return _flagIso;
        }
        /// <summary>
        /// Country fiscal iso code
        /// </summary>
        /// <value>Country fiscal iso code</value>
        [DataMember(Name = "fiscal_iso", EmitDefaultValue = true)]
        public string FiscalIso
        {
            get { return _FiscalIso; }
            set
            {
                _FiscalIso = value;
                _flagFiscalIso = true;
            }
        }
        private string _FiscalIso;
        private bool _flagFiscalIso;

        /// <summary>
        /// Returns false as FiscalIso should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFiscalIso()
        {
            return _flagFiscalIso;
        }
        /// <summary>
        /// Country uic
        /// </summary>
        /// <value>Country uic</value>
        [DataMember(Name = "uic", EmitDefaultValue = true)]
        public string Uic
        {
            get { return _Uic; }
            set
            {
                _Uic = value;
                _flagUic = true;
            }
        }
        private string _Uic;
        private bool _flagUic;

        /// <summary>
        /// Returns false as Uic should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUic()
        {
            return _flagUic;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DetailedCountry {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SettingsName: ").Append(SettingsName).Append("\n");
            sb.Append("  Iso: ").Append(Iso).Append("\n");
            sb.Append("  FiscalIso: ").Append(FiscalIso).Append("\n");
            sb.Append("  Uic: ").Append(Uic).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
