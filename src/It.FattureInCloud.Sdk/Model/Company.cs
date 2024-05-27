/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.33
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
    /// Company
    /// </summary>
    [DataContract(Name = "Company")]
    public partial class Company : IEquatable<Company>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>

        [DataMember(Name = "type", EmitDefaultValue = false)]
        public CompanyType? Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                _flagType = true;
            }
        }
        private CompanyType? _Type;
        private bool _flagType;

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return _flagType;
        }

        /// <summary>
        /// Gets or Sets FicPlan
        /// </summary>

        [DataMember(Name = "fic_plan", EmitDefaultValue = false)]
        public FattureInCloudPlanType? FicPlan
        {
            get { return _FicPlan; }
            set
            {
                _FicPlan = value;
                _flagFicPlan = true;
            }
        }
        private FattureInCloudPlanType? _FicPlan;
        private bool _flagFicPlan;

        /// <summary>
        /// Returns false as FicPlan should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicPlan()
        {
            return _flagFicPlan;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class.
        /// </summary>
        /// <param name="id">Company id.</param>
        /// <param name="name">Company name.</param>
        /// <param name="type">type.</param>
        /// <param name="accessToken">Company authentication token for this company. [Only if type&#x3D;company].</param>
        /// <param name="controlledCompanies">Company list of controlled companies [Only if type&#x3D;accountant].</param>
        /// <param name="ficLicenseExpire">ficLicenseExpire.</param>
        /// <param name="ficPlan">ficPlan.</param>
        /// <param name="connectionId">Company connection id.</param>
        /// <param name="taxCode">Company tax code.</param>
        /// <param name="vatNumber">Company vat number.</param>
        public Company(int? id = default(int?), string name = default(string), CompanyType? type = default(CompanyType?), string accessToken = default(string), List<ControlledCompany> controlledCompanies = default(List<ControlledCompany>), DateTime? ficLicenseExpire = default(DateTime?), FattureInCloudPlanType? ficPlan = default(FattureInCloudPlanType?), int? connectionId = default(int?), string taxCode = default(string), string vatNumber = default(string))
        {
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._Name = name;
            if (this.Name != null)
            {
                this._flagName = true;
            }
            this._Type = type;
            if (this.Type != null)
            {
                this._flagType = true;
            }
            this._AccessToken = accessToken;
            if (this.AccessToken != null)
            {
                this._flagAccessToken = true;
            }
            this._ControlledCompanies = controlledCompanies;
            if (this.ControlledCompanies != null)
            {
                this._flagControlledCompanies = true;
            }
            this._FicLicenseExpire = ficLicenseExpire;
            if (this.FicLicenseExpire != null)
            {
                this._flagFicLicenseExpire = true;
            }
            this._FicPlan = ficPlan;
            if (this.FicPlan != null)
            {
                this._flagFicPlan = true;
            }
            this._ConnectionId = connectionId;
            if (this.ConnectionId != null)
            {
                this._flagConnectionId = true;
            }
            this._TaxCode = taxCode;
            if (this.TaxCode != null)
            {
                this._flagTaxCode = true;
            }
            this._VatNumber = vatNumber;
            if (this.VatNumber != null)
            {
                this._flagVatNumber = true;
            }
        }

        /// <summary>
        /// Company id
        /// </summary>
        /// <value>Company id</value>
        /// <example>12345</example>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id
        {
            get { return _Id; }
            set
            {
                _Id = value;
                _flagId = true;
            }
        }
        private int? _Id;
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
        /// Company name
        /// </summary>
        /// <value>Company name</value>
        /// <example>Rossi S.r.l.</example>
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
        /// Company authentication token for this company. [Only if type&#x3D;company]
        /// </summary>
        /// <value>Company authentication token for this company. [Only if type&#x3D;company]</value>
        /// <example>fd015011d2dbf8a9d38e810b325b11b56d02e51688e5261a245933b8e677b8b44ff5f0fe5ccaaf1d7157fa13ca72ab62b6183db0667a576a0e19164801c18c4fd81273fc1f95bf460b869015cf99acba</example>
        [DataMember(Name = "access_token", EmitDefaultValue = true)]
        public string AccessToken
        {
            get { return _AccessToken; }
            set
            {
                _AccessToken = value;
                _flagAccessToken = true;
            }
        }
        private string _AccessToken;
        private bool _flagAccessToken;

        /// <summary>
        /// Returns false as AccessToken should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccessToken()
        {
            return _flagAccessToken;
        }
        /// <summary>
        /// Company list of controlled companies [Only if type&#x3D;accountant]
        /// </summary>
        /// <value>Company list of controlled companies [Only if type&#x3D;accountant]</value>
        [DataMember(Name = "controlled_companies", EmitDefaultValue = true)]
        public List<ControlledCompany> ControlledCompanies
        {
            get { return _ControlledCompanies; }
            set
            {
                _ControlledCompanies = value;
                _flagControlledCompanies = true;
            }
        }
        private List<ControlledCompany> _ControlledCompanies;
        private bool _flagControlledCompanies;

        /// <summary>
        /// Returns false as ControlledCompanies should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeControlledCompanies()
        {
            return _flagControlledCompanies;
        }
        /// <summary>
        /// Gets or Sets FicLicenseExpire
        /// </summary>
        [JsonConverter(typeof(OpenAPIDateConverter))]
        [DataMember(Name = "fic_license_expire", EmitDefaultValue = true)]
        public DateTime? FicLicenseExpire
        {
            get { return _FicLicenseExpire; }
            set
            {
                _FicLicenseExpire = value;
                _flagFicLicenseExpire = true;
            }
        }
        private DateTime? _FicLicenseExpire;
        private bool _flagFicLicenseExpire;

        /// <summary>
        /// Returns false as FicLicenseExpire should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicLicenseExpire()
        {
            return _flagFicLicenseExpire;
        }
        /// <summary>
        /// Company connection id
        /// </summary>
        /// <value>Company connection id</value>
        [DataMember(Name = "connection_id", EmitDefaultValue = true)]
        public int? ConnectionId
        {
            get { return _ConnectionId; }
            set
            {
                _ConnectionId = value;
                _flagConnectionId = true;
            }
        }
        private int? _ConnectionId;
        private bool _flagConnectionId;

        /// <summary>
        /// Returns false as ConnectionId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeConnectionId()
        {
            return _flagConnectionId;
        }
        /// <summary>
        /// Company tax code
        /// </summary>
        /// <value>Company tax code</value>
        [DataMember(Name = "tax_code", EmitDefaultValue = true)]
        public string TaxCode
        {
            get { return _TaxCode; }
            set
            {
                _TaxCode = value;
                _flagTaxCode = true;
            }
        }
        private string _TaxCode;
        private bool _flagTaxCode;

        /// <summary>
        /// Returns false as TaxCode should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTaxCode()
        {
            return _flagTaxCode;
        }
        /// <summary>
        /// Company vat number
        /// </summary>
        /// <value>Company vat number</value>
        [DataMember(Name = "vat_number", EmitDefaultValue = true)]
        public string VatNumber
        {
            get { return _VatNumber; }
            set
            {
                _VatNumber = value;
                _flagVatNumber = true;
            }
        }
        private string _VatNumber;
        private bool _flagVatNumber;

        /// <summary>
        /// Returns false as VatNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVatNumber()
        {
            return _flagVatNumber;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Company {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ControlledCompanies: ").Append(ControlledCompanies).Append("\n");
            sb.Append("  FicLicenseExpire: ").Append(FicLicenseExpire).Append("\n");
            sb.Append("  FicPlan: ").Append(FicPlan).Append("\n");
            sb.Append("  ConnectionId: ").Append(ConnectionId).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  VatNumber: ").Append(VatNumber).Append("\n");
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
                    this.FicLicenseExpire == input.FicLicenseExpire ||
                    (this.FicLicenseExpire != null &&
                    this.FicLicenseExpire.Equals(input.FicLicenseExpire))
                ) &&
                (
                    this.FicPlan == input.FicPlan ||
                    this.FicPlan.Equals(input.FicPlan)
                ) &&
                (
                    this.ConnectionId == input.ConnectionId ||
                    (this.ConnectionId != null &&
                    this.ConnectionId.Equals(input.ConnectionId))
                ) &&
                (
                    this.TaxCode == input.TaxCode ||
                    (this.TaxCode != null &&
                    this.TaxCode.Equals(input.TaxCode))
                ) &&
                (
                    this.VatNumber == input.VatNumber ||
                    (this.VatNumber != null &&
                    this.VatNumber.Equals(input.VatNumber))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.AccessToken != null)
                {
                    hashCode = (hashCode * 59) + this.AccessToken.GetHashCode();
                }
                if (this.ControlledCompanies != null)
                {
                    hashCode = (hashCode * 59) + this.ControlledCompanies.GetHashCode();
                }
                if (this.FicLicenseExpire != null)
                {
                    hashCode = (hashCode * 59) + this.FicLicenseExpire.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FicPlan.GetHashCode();
                if (this.ConnectionId != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionId.GetHashCode();
                }
                if (this.TaxCode != null)
                {
                    hashCode = (hashCode * 59) + this.TaxCode.GetHashCode();
                }
                if (this.VatNumber != null)
                {
                    hashCode = (hashCode * 59) + this.VatNumber.GetHashCode();
                }
                return hashCode;
            }
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
