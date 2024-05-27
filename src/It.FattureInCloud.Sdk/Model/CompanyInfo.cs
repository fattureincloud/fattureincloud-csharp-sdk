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
    /// CompanyInfo
    /// </summary>
    [DataContract(Name = "CompanyInfo")]
    public partial class CompanyInfo : IEquatable<CompanyInfo>, IValidatableObject
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
        /// Gets or Sets FicPlanName
        /// </summary>

        [DataMember(Name = "fic_plan_name", EmitDefaultValue = false)]
        public FattureInCloudPlanType? FicPlanName
        {
            get { return _FicPlanName; }
            set
            {
                _FicPlanName = value;
                _flagFicPlanName = true;
            }
        }
        private FattureInCloudPlanType? _FicPlanName;
        private bool _flagFicPlanName;

        /// <summary>
        /// Returns false as FicPlanName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicPlanName()
        {
            return _flagFicPlanName;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyInfo" /> class.
        /// </summary>
        /// <param name="id">Company id.</param>
        /// <param name="name">Company name.</param>
        /// <param name="email">Company email.</param>
        /// <param name="type">type.</param>
        /// <param name="accessInfo">accessInfo.</param>
        /// <param name="ficLicenseExpire">ficLicenseExpire.</param>
        /// <param name="ficPlanName">ficPlanName.</param>
        /// <param name="planInfo">planInfo.</param>
        /// <param name="accountantId">Company accountant id.</param>
        /// <param name="isAccountant">Is the logged account an accountant..</param>
        public CompanyInfo(int? id = default(int?), string name = default(string), string email = default(string), CompanyType? type = default(CompanyType?), CompanyInfoAccessInfo accessInfo = default(CompanyInfoAccessInfo), DateTime? ficLicenseExpire = default(DateTime?), FattureInCloudPlanType? ficPlanName = default(FattureInCloudPlanType?), CompanyInfoPlanInfo planInfo = default(CompanyInfoPlanInfo), int? accountantId = default(int?), bool? isAccountant = default(bool?))
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
            this._Email = email;
            if (this.Email != null)
            {
                this._flagEmail = true;
            }
            this._Type = type;
            if (this.Type != null)
            {
                this._flagType = true;
            }
            this._AccessInfo = accessInfo;
            if (this.AccessInfo != null)
            {
                this._flagAccessInfo = true;
            }
            this._FicLicenseExpire = ficLicenseExpire;
            if (this.FicLicenseExpire != null)
            {
                this._flagFicLicenseExpire = true;
            }
            this._FicPlanName = ficPlanName;
            if (this.FicPlanName != null)
            {
                this._flagFicPlanName = true;
            }
            this._PlanInfo = planInfo;
            if (this.PlanInfo != null)
            {
                this._flagPlanInfo = true;
            }
            this._AccountantId = accountantId;
            if (this.AccountantId != null)
            {
                this._flagAccountantId = true;
            }
            this._IsAccountant = isAccountant;
            if (this.IsAccountant != null)
            {
                this._flagIsAccountant = true;
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
        /// <example>Mario Rossi S.r.l.</example>
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
        /// Company email
        /// </summary>
        /// <value>Company email</value>
        /// <example>mario@rossi-example.it</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email
        {
            get { return _Email; }
            set
            {
                _Email = value;
                _flagEmail = true;
            }
        }
        private string _Email;
        private bool _flagEmail;

        /// <summary>
        /// Returns false as Email should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmail()
        {
            return _flagEmail;
        }
        /// <summary>
        /// Gets or Sets AccessInfo
        /// </summary>
        [DataMember(Name = "access_info", EmitDefaultValue = true)]
        public CompanyInfoAccessInfo AccessInfo
        {
            get { return _AccessInfo; }
            set
            {
                _AccessInfo = value;
                _flagAccessInfo = true;
            }
        }
        private CompanyInfoAccessInfo _AccessInfo;
        private bool _flagAccessInfo;

        /// <summary>
        /// Returns false as AccessInfo should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccessInfo()
        {
            return _flagAccessInfo;
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
        /// Gets or Sets PlanInfo
        /// </summary>
        [DataMember(Name = "plan_info", EmitDefaultValue = true)]
        public CompanyInfoPlanInfo PlanInfo
        {
            get { return _PlanInfo; }
            set
            {
                _PlanInfo = value;
                _flagPlanInfo = true;
            }
        }
        private CompanyInfoPlanInfo _PlanInfo;
        private bool _flagPlanInfo;

        /// <summary>
        /// Returns false as PlanInfo should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePlanInfo()
        {
            return _flagPlanInfo;
        }
        /// <summary>
        /// Company accountant id
        /// </summary>
        /// <value>Company accountant id</value>
        [DataMember(Name = "accountant_id", EmitDefaultValue = true)]
        public int? AccountantId
        {
            get { return _AccountantId; }
            set
            {
                _AccountantId = value;
                _flagAccountantId = true;
            }
        }
        private int? _AccountantId;
        private bool _flagAccountantId;

        /// <summary>
        /// Returns false as AccountantId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccountantId()
        {
            return _flagAccountantId;
        }
        /// <summary>
        /// Is the logged account an accountant.
        /// </summary>
        /// <value>Is the logged account an accountant.</value>
        [DataMember(Name = "is_accountant", EmitDefaultValue = true)]
        public bool? IsAccountant
        {
            get { return _IsAccountant; }
            set
            {
                _IsAccountant = value;
                _flagIsAccountant = true;
            }
        }
        private bool? _IsAccountant;
        private bool _flagIsAccountant;

        /// <summary>
        /// Returns false as IsAccountant should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsAccountant()
        {
            return _flagIsAccountant;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AccessInfo: ").Append(AccessInfo).Append("\n");
            sb.Append("  FicLicenseExpire: ").Append(FicLicenseExpire).Append("\n");
            sb.Append("  FicPlanName: ").Append(FicPlanName).Append("\n");
            sb.Append("  PlanInfo: ").Append(PlanInfo).Append("\n");
            sb.Append("  AccountantId: ").Append(AccountantId).Append("\n");
            sb.Append("  IsAccountant: ").Append(IsAccountant).Append("\n");
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
            return this.Equals(input as CompanyInfo);
        }

        /// <summary>
        /// Returns true if CompanyInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyInfo input)
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
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) &&
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) &&
                (
                    this.AccessInfo == input.AccessInfo ||
                    (this.AccessInfo != null &&
                    this.AccessInfo.Equals(input.AccessInfo))
                ) &&
                (
                    this.FicLicenseExpire == input.FicLicenseExpire ||
                    (this.FicLicenseExpire != null &&
                    this.FicLicenseExpire.Equals(input.FicLicenseExpire))
                ) &&
                (
                    this.FicPlanName == input.FicPlanName ||
                    this.FicPlanName.Equals(input.FicPlanName)
                ) &&
                (
                    this.PlanInfo == input.PlanInfo ||
                    (this.PlanInfo != null &&
                    this.PlanInfo.Equals(input.PlanInfo))
                ) &&
                (
                    this.AccountantId == input.AccountantId ||
                    (this.AccountantId != null &&
                    this.AccountantId.Equals(input.AccountantId))
                ) &&
                (
                    this.IsAccountant == input.IsAccountant ||
                    (this.IsAccountant != null &&
                    this.IsAccountant.Equals(input.IsAccountant))
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
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.AccessInfo != null)
                {
                    hashCode = (hashCode * 59) + this.AccessInfo.GetHashCode();
                }
                if (this.FicLicenseExpire != null)
                {
                    hashCode = (hashCode * 59) + this.FicLicenseExpire.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FicPlanName.GetHashCode();
                if (this.PlanInfo != null)
                {
                    hashCode = (hashCode * 59) + this.PlanInfo.GetHashCode();
                }
                if (this.AccountantId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountantId.GetHashCode();
                }
                if (this.IsAccountant != null)
                {
                    hashCode = (hashCode * 59) + this.IsAccountant.GetHashCode();
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
