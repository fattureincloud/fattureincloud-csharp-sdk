/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol. For more information, please visit https://www.fattureincloud.it.
 *
 * The version of the OpenAPI document: 2.0.2
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
        public IssuedDocumentPreCreateInfoExtraDataDefaultValues(bool tsCommunication = default(bool), string tsTipoSpesa = default(string), int tsFlagTipoSpesa = default(int), bool tsPagamentoTracciato = default(bool))
        {
            this.TsCommunication = tsCommunication;
            this.TsTipoSpesa = tsTipoSpesa;
            this.TsFlagTipoSpesa = tsFlagTipoSpesa;
            this.TsPagamentoTracciato = tsPagamentoTracciato;
        }

        /// <summary>
        /// Gets or Sets TsCommunication
        /// </summary>
        [DataMember(Name = "ts_communication", EmitDefaultValue = true)]
        public bool TsCommunication { get; set; }

        /// <summary>
        /// Gets or Sets TsTipoSpesa
        /// </summary>
        [DataMember(Name = "ts_tipo_spesa", EmitDefaultValue = false)]
        public string TsTipoSpesa { get; set; }

        /// <summary>
        /// Gets or Sets TsFlagTipoSpesa
        /// </summary>
        [DataMember(Name = "ts_flag_tipo_spesa", EmitDefaultValue = false)]
        public int TsFlagTipoSpesa { get; set; }

        /// <summary>
        /// Gets or Sets TsPagamentoTracciato
        /// </summary>
        [DataMember(Name = "ts_pagamento_tracciato", EmitDefaultValue = true)]
        public bool TsPagamentoTracciato { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
                return false;

            return 
                (
                    this.TsCommunication == input.TsCommunication ||
                    this.TsCommunication.Equals(input.TsCommunication)
                ) && 
                (
                    this.TsTipoSpesa == input.TsTipoSpesa ||
                    (this.TsTipoSpesa != null &&
                    this.TsTipoSpesa.Equals(input.TsTipoSpesa))
                ) && 
                (
                    this.TsFlagTipoSpesa == input.TsFlagTipoSpesa ||
                    this.TsFlagTipoSpesa.Equals(input.TsFlagTipoSpesa)
                ) && 
                (
                    this.TsPagamentoTracciato == input.TsPagamentoTracciato ||
                    this.TsPagamentoTracciato.Equals(input.TsPagamentoTracciato)
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
                hashCode = hashCode * 59 + this.TsCommunication.GetHashCode();
                if (this.TsTipoSpesa != null)
                    hashCode = hashCode * 59 + this.TsTipoSpesa.GetHashCode();
                hashCode = hashCode * 59 + this.TsFlagTipoSpesa.GetHashCode();
                hashCode = hashCode * 59 + this.TsPagamentoTracciato.GetHashCode();
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
