/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.5
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
    /// Description of a company.
    /// </summary>
    [DataContract(Name = "Company")]
    public partial class Company : IEquatable<Company>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public CompanyType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class.
        /// </summary>
        /// <param name="id">Company unique identifier..</param>
        /// <param name="name">Company name..</param>
        /// <param name="type">type.</param>
        /// <param name="accessToken">CompanyAuthentication token for this company. [Only if type&#x3D;company].</param>
        /// <param name="controlledCompanies">List of controlled companies. [Only if type&#x3D;accountant].</param>
        /// <param name="connectionId">Company connection id..</param>
        /// <param name="taxCode">Tax code..</param>
        public Company(int id = default(int), string name = default(string), CompanyType? type = default(CompanyType?), string accessToken = default(string), List<Company> controlledCompanies = default(List<Company>), decimal connectionId = default(decimal), string taxCode = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.AccessToken = accessToken;
            this.ControlledCompanies = controlledCompanies;
            this.ConnectionId = connectionId;
            this.TaxCode = taxCode;
        }

        /// <summary>
        /// Company unique identifier.
        /// </summary>
        /// <value>Company unique identifier.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Company name.
        /// </summary>
        /// <value>Company name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// CompanyAuthentication token for this company. [Only if type&#x3D;company]
        /// </summary>
        /// <value>CompanyAuthentication token for this company. [Only if type&#x3D;company]</value>
        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// List of controlled companies. [Only if type&#x3D;accountant]
        /// </summary>
        /// <value>List of controlled companies. [Only if type&#x3D;accountant]</value>
        [DataMember(Name = "controlled_companies", EmitDefaultValue = false)]
        public List<Company> ControlledCompanies { get; set; }

        /// <summary>
        /// Company connection id.
        /// </summary>
        /// <value>Company connection id.</value>
        [DataMember(Name = "connection_id", EmitDefaultValue = false)]
        public decimal ConnectionId { get; set; }

        /// <summary>
        /// Tax code.
        /// </summary>
        /// <value>Tax code.</value>
        [DataMember(Name = "tax_code", EmitDefaultValue = false)]
        public string TaxCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Company {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ControlledCompanies: ").Append(ControlledCompanies).Append("\n");
            sb.Append("  ConnectionId: ").Append(ConnectionId).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
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
            return this.Equals(input as Company);
        }

        /// <summary>
        /// Returns true if Company instances are equal
        /// </summary>
        /// <param name="input">Instance of Company to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Company input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.ControlledCompanies == input.ControlledCompanies ||
                    this.ControlledCompanies != null &&
                    input.ControlledCompanies != null &&
                    this.ControlledCompanies.SequenceEqual(input.ControlledCompanies)
                ) && 
                (
                    this.ConnectionId == input.ConnectionId ||
                    this.ConnectionId.Equals(input.ConnectionId)
                ) && 
                (
                    this.TaxCode == input.TaxCode ||
                    (this.TaxCode != null &&
                    this.TaxCode.Equals(input.TaxCode))
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.ControlledCompanies != null)
                    hashCode = hashCode * 59 + this.ControlledCompanies.GetHashCode();
                hashCode = hashCode * 59 + this.ConnectionId.GetHashCode();
                if (this.TaxCode != null)
                    hashCode = hashCode * 59 + this.TaxCode.GetHashCode();
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
