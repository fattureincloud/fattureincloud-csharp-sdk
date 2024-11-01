/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.1.3
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
    /// Currency
    /// </summary>
    [DataContract(Name = "Currency")]
    public partial class Currency : IEquatable<Currency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Currency" /> class.
        /// </summary>
        /// <param name="id">Currency code.</param>
        /// <param name="symbol">Currency symbol.</param>
        /// <param name="exchangeRate">Currency exchange rate (EUR to this).</param>
        /// <param name="htmlSymbol">Currency html code.</param>
        public Currency(string id = default(string), string symbol = default(string), string exchangeRate = default(string), string htmlSymbol = default(string))
        {
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._Symbol = symbol;
            if (this.Symbol != null)
            {
                this._flagSymbol = true;
            }
            this._ExchangeRate = exchangeRate;
            if (this.ExchangeRate != null)
            {
                this._flagExchangeRate = true;
            }
            this._HtmlSymbol = htmlSymbol;
            if (this.HtmlSymbol != null)
            {
                this._flagHtmlSymbol = true;
            }
        }

        /// <summary>
        /// Currency code
        /// </summary>
        /// <value>Currency code</value>
        /// <example>EUR</example>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id
        {
            get { return _Id; }
            set
            {
                _Id = value;
                _flagId = true;
            }
        }
        private string _Id;
        private bool _flagId;

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return _flagId;
        }
        /// <summary>
        /// Currency symbol
        /// </summary>
        /// <value>Currency symbol</value>
        /// <example>€</example>
        [DataMember(Name = "symbol", EmitDefaultValue = true)]
        public string Symbol
        {
            get { return _Symbol; }
            set
            {
                _Symbol = value;
                _flagSymbol = true;
            }
        }
        private string _Symbol;
        private bool _flagSymbol;

        /// <summary>
        /// Returns false as Symbol should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSymbol()
        {
            return _flagSymbol;
        }
        /// <summary>
        /// Currency exchange rate (EUR to this)
        /// </summary>
        /// <value>Currency exchange rate (EUR to this)</value>
        /// <example>1</example>
        [DataMember(Name = "exchange_rate", EmitDefaultValue = true)]
        public string ExchangeRate
        {
            get { return _ExchangeRate; }
            set
            {
                _ExchangeRate = value;
                _flagExchangeRate = true;
            }
        }
        private string _ExchangeRate;
        private bool _flagExchangeRate;

        /// <summary>
        /// Returns false as ExchangeRate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExchangeRate()
        {
            return _flagExchangeRate;
        }
        /// <summary>
        /// Currency html code
        /// </summary>
        /// <value>Currency html code</value>
        /// <example>EUR</example>
        [DataMember(Name = "html_symbol", EmitDefaultValue = true)]
        public string HtmlSymbol
        {
            get { return _HtmlSymbol; }
            set
            {
                _HtmlSymbol = value;
                _flagHtmlSymbol = true;
            }
        }
        private string _HtmlSymbol;
        private bool _flagHtmlSymbol;

        /// <summary>
        /// Returns false as HtmlSymbol should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHtmlSymbol()
        {
            return _flagHtmlSymbol;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Currency {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  HtmlSymbol: ").Append(HtmlSymbol).Append("\n");
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
            return this.Equals(input as Currency);
        }

        /// <summary>
        /// Returns true if Currency instances are equal
        /// </summary>
        /// <param name="input">Instance of Currency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Currency input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) &&
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) &&
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
                ) &&
                (
                    this.HtmlSymbol == input.HtmlSymbol ||
                    (this.HtmlSymbol != null &&
                    this.HtmlSymbol.Equals(input.HtmlSymbol))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                if (this.ExchangeRate != null)
                {
                    hashCode = (hashCode * 59) + this.ExchangeRate.GetHashCode();
                }
                if (this.HtmlSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.HtmlSymbol.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
