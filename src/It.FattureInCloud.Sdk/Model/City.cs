/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.12
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
    /// City
    /// </summary>
    [DataContract(Name = "City")]
    public partial class City : IEquatable<City>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="City" /> class.
        /// </summary>
        /// <param name="postalCode">City postal code..</param>
        /// <param name="city">City name..</param>
        /// <param name="province">Province..</param>
        public City(string postalCode = default(string), string city = default(string), string province = default(string))
        {
            this._PostalCode = postalCode;
            this.__City = city;
            this._Province = province;
        }

        /// <summary>
        /// City postal code.
        /// </summary>
        /// <value>City postal code.</value>
        [DataMember(Name = "postal_code", EmitDefaultValue = true)]
        public string PostalCode
        {
            get{ return _PostalCode;}
            set
            {
                _PostalCode = value;
                _flagPostalCode = true;
            }
        }
        private string _PostalCode;
        private bool _flagPostalCode;

        /// <summary>
        /// Returns false as PostalCode should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePostalCode()
        {
            return _flagPostalCode;
        }
        /// <summary>
        /// City name.
        /// </summary>
        /// <value>City name.</value>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string _City
        {
            get{ return __City;}
            set
            {
                __City = value;
                _flag_City = true;
            }
        }
        private string __City;
        private bool _flag_City;

        /// <summary>
        /// Returns false as _City should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerialize_City()
        {
            return _flag_City;
        }
        /// <summary>
        /// Province.
        /// </summary>
        /// <value>Province.</value>
        [DataMember(Name = "province", EmitDefaultValue = true)]
        public string Province
        {
            get{ return _Province;}
            set
            {
                _Province = value;
                _flagProvince = true;
            }
        }
        private string _Province;
        private bool _flagProvince;

        /// <summary>
        /// Returns false as Province should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProvince()
        {
            return _flagProvince;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class City {\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  _City: ").Append(_City).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
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
            return this.Equals(input as City);
        }

        /// <summary>
        /// Returns true if City instances are equal
        /// </summary>
        /// <param name="input">Instance of City to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(City input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this._City == input._City ||
                    (this._City != null &&
                    this._City.Equals(input._City))
                ) && 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
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
                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
                }
                if (this._City != null)
                {
                    hashCode = (hashCode * 59) + this._City.GetHashCode();
                }
                if (this.Province != null)
                {
                    hashCode = (hashCode * 59) + this.Province.GetHashCode();
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
