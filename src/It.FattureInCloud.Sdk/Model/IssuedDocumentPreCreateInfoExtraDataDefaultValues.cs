/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.20
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
    /// IssuedDocumentPreCreateInfoExtraDataDefaultValues
    /// </summary>
    [DataContract(Name = "IssuedDocumentPreCreateInfo_extra_data_default_values")]
    public partial class IssuedDocumentPreCreateInfoExtraDataDefaultValues : IEquatable<IssuedDocumentPreCreateInfoExtraDataDefaultValues>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedDocumentPreCreateInfoExtraDataDefaultValues" /> class.
        /// </summary>
        /// <param name="tsCommunication">tsCommunication.</param>
        /// <param name="tsTipoSpesa">tsTipoSpesa.</param>
        /// <param name="tsFlagTipoSpesa">tsFlagTipoSpesa.</param>
        /// <param name="tsPagamentoTracciato">tsPagamentoTracciato.</param>
        public IssuedDocumentPreCreateInfoExtraDataDefaultValues(bool? tsCommunication = default(bool?), string tsTipoSpesa = default(string), int? tsFlagTipoSpesa = default(int?), bool? tsPagamentoTracciato = default(bool?))
        {
            this._TsCommunication = tsCommunication;
            if (this.TsCommunication != null)
            {
                this._flagTsCommunication = true;
            }
            this._TsTipoSpesa = tsTipoSpesa;
            if (this.TsTipoSpesa != null)
            {
                this._flagTsTipoSpesa = true;
            }
            this._TsFlagTipoSpesa = tsFlagTipoSpesa;
            if (this.TsFlagTipoSpesa != null)
            {
                this._flagTsFlagTipoSpesa = true;
            }
            this._TsPagamentoTracciato = tsPagamentoTracciato;
            if (this.TsPagamentoTracciato != null)
            {
                this._flagTsPagamentoTracciato = true;
            }
        }

        /// <summary>
        /// Gets or Sets TsCommunication
        /// </summary>
        [DataMember(Name = "ts_communication", EmitDefaultValue = true)]
        public bool? TsCommunication
        {
            get { return _TsCommunication; }
            set
            {
                _TsCommunication = value;
                _flagTsCommunication = true;
            }
        }
        private bool? _TsCommunication;
        private bool _flagTsCommunication;

        /// <summary>
        /// Returns false as TsCommunication should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTsCommunication()
        {
            return _flagTsCommunication;
        }
        /// <summary>
        /// Gets or Sets TsTipoSpesa
        /// </summary>
        [DataMember(Name = "ts_tipo_spesa", EmitDefaultValue = true)]
        public string TsTipoSpesa
        {
            get { return _TsTipoSpesa; }
            set
            {
                _TsTipoSpesa = value;
                _flagTsTipoSpesa = true;
            }
        }
        private string _TsTipoSpesa;
        private bool _flagTsTipoSpesa;

        /// <summary>
        /// Returns false as TsTipoSpesa should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTsTipoSpesa()
        {
            return _flagTsTipoSpesa;
        }
        /// <summary>
        /// Gets or Sets TsFlagTipoSpesa
        /// </summary>
        [DataMember(Name = "ts_flag_tipo_spesa", EmitDefaultValue = true)]
        public int? TsFlagTipoSpesa
        {
            get { return _TsFlagTipoSpesa; }
            set
            {
                _TsFlagTipoSpesa = value;
                _flagTsFlagTipoSpesa = true;
            }
        }
        private int? _TsFlagTipoSpesa;
        private bool _flagTsFlagTipoSpesa;

        /// <summary>
        /// Returns false as TsFlagTipoSpesa should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTsFlagTipoSpesa()
        {
            return _flagTsFlagTipoSpesa;
        }
        /// <summary>
        /// Gets or Sets TsPagamentoTracciato
        /// </summary>
        [DataMember(Name = "ts_pagamento_tracciato", EmitDefaultValue = true)]
        public bool? TsPagamentoTracciato
        {
            get { return _TsPagamentoTracciato; }
            set
            {
                _TsPagamentoTracciato = value;
                _flagTsPagamentoTracciato = true;
            }
        }
        private bool? _TsPagamentoTracciato;
        private bool _flagTsPagamentoTracciato;

        /// <summary>
        /// Returns false as TsPagamentoTracciato should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTsPagamentoTracciato()
        {
            return _flagTsPagamentoTracciato;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssuedDocumentPreCreateInfoExtraDataDefaultValues {\n");
            sb.Append("  TsCommunication: ").Append(TsCommunication).Append("\n");
            sb.Append("  TsTipoSpesa: ").Append(TsTipoSpesa).Append("\n");
            sb.Append("  TsFlagTipoSpesa: ").Append(TsFlagTipoSpesa).Append("\n");
            sb.Append("  TsPagamentoTracciato: ").Append(TsPagamentoTracciato).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssuedDocumentPreCreateInfoExtraDataDefaultValues);
        }

        /// <summary>
        /// Returns true if IssuedDocumentPreCreateInfoExtraDataDefaultValues instances are equal
        /// </summary>
        /// <param name="input">Instance of IssuedDocumentPreCreateInfoExtraDataDefaultValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssuedDocumentPreCreateInfoExtraDataDefaultValues input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.TsCommunication == input.TsCommunication ||
                    (this.TsCommunication != null &&
                    this.TsCommunication.Equals(input.TsCommunication))
                ) &&
                (
                    this.TsTipoSpesa == input.TsTipoSpesa ||
                    (this.TsTipoSpesa != null &&
                    this.TsTipoSpesa.Equals(input.TsTipoSpesa))
                ) &&
                (
                    this.TsFlagTipoSpesa == input.TsFlagTipoSpesa ||
                    (this.TsFlagTipoSpesa != null &&
                    this.TsFlagTipoSpesa.Equals(input.TsFlagTipoSpesa))
                ) &&
                (
                    this.TsPagamentoTracciato == input.TsPagamentoTracciato ||
                    (this.TsPagamentoTracciato != null &&
                    this.TsPagamentoTracciato.Equals(input.TsPagamentoTracciato))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TsCommunication != null)
                {
                    hashCode = (hashCode * 59) + this.TsCommunication.GetHashCode();
                }
                if (this.TsTipoSpesa != null)
                {
                    hashCode = (hashCode * 59) + this.TsTipoSpesa.GetHashCode();
                }
                if (this.TsFlagTipoSpesa != null)
                {
                    hashCode = (hashCode * 59) + this.TsFlagTipoSpesa.GetHashCode();
                }
                if (this.TsPagamentoTracciato != null)
                {
                    hashCode = (hashCode * 59) + this.TsPagamentoTracciato.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
