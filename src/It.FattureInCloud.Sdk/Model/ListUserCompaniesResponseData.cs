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
    /// ListUserCompaniesResponseData
    /// </summary>
    [DataContract(Name = "ListUserCompaniesResponse_data")]
    public partial class ListUserCompaniesResponseData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListUserCompaniesResponseData" /> class.
        /// </summary>
        /// <param name="companies">companies.</param>
        public ListUserCompaniesResponseData(List<Company> companies = default(List<Company>))
        {
            this._Companies = companies;
            if (this.Companies != null)
            {
                this._flagCompanies = true;
            }
        }

        /// <summary>
        /// Gets or Sets Companies
        /// </summary>
        [DataMember(Name = "companies", EmitDefaultValue = true)]
        public List<Company> Companies
        {
            get { return _Companies; }
            set
            {
                _Companies = value;
                _flagCompanies = true;
            }
        }
        private List<Company> _Companies;
        private bool _flagCompanies;

        /// <summary>
        /// Returns false as Companies should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCompanies()
        {
            return _flagCompanies;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListUserCompaniesResponseData {\n");
            sb.Append("  Companies: ").Append(Companies).Append("\n");
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
