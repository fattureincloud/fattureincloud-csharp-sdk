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
    /// CompanyInfoAccessInfo
    /// </summary>
    [DataContract(Name = "CompanyInfo_access_info")]
    public partial class CompanyInfoAccessInfo : IEquatable<CompanyInfoAccessInfo>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Role
        /// </summary>

        [DataMember(Name = "role", EmitDefaultValue = false)]
        public UserCompanyRole? Role
        {
            get { return _Role; }
            set
            {
                _Role = value;
                _flagRole = true;
            }
        }
        private UserCompanyRole? _Role;
        private bool _flagRole;

        /// <summary>
        /// Returns false as Role should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRole()
        {
            return _flagRole;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyInfoAccessInfo" /> class.
        /// </summary>
        /// <param name="role">role.</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="throughAccountant">Company activated through accountant.</param>
        public CompanyInfoAccessInfo(UserCompanyRole? role = default(UserCompanyRole?), Permissions permissions = default(Permissions), bool? throughAccountant = default(bool?))
        {
            this._Role = role;
            if (this.Role != null)
            {
                this._flagRole = true;
            }
            this._Permissions = permissions;
            if (this.Permissions != null)
            {
                this._flagPermissions = true;
            }
            this._ThroughAccountant = throughAccountant;
            if (this.ThroughAccountant != null)
            {
                this._flagThroughAccountant = true;
            }
        }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public Permissions Permissions
        {
            get { return _Permissions; }
            set
            {
                _Permissions = value;
                _flagPermissions = true;
            }
        }
        private Permissions _Permissions;
        private bool _flagPermissions;

        /// <summary>
        /// Returns false as Permissions should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePermissions()
        {
            return _flagPermissions;
        }
        /// <summary>
        /// Company activated through accountant
        /// </summary>
        /// <value>Company activated through accountant</value>
        [DataMember(Name = "through_accountant", EmitDefaultValue = true)]
        public bool? ThroughAccountant
        {
            get { return _ThroughAccountant; }
            set
            {
                _ThroughAccountant = value;
                _flagThroughAccountant = true;
            }
        }
        private bool? _ThroughAccountant;
        private bool _flagThroughAccountant;

        /// <summary>
        /// Returns false as ThroughAccountant should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeThroughAccountant()
        {
            return _flagThroughAccountant;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyInfoAccessInfo {\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  ThroughAccountant: ").Append(ThroughAccountant).Append("\n");
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
            return this.Equals(input as CompanyInfoAccessInfo);
        }

        /// <summary>
        /// Returns true if CompanyInfoAccessInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyInfoAccessInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyInfoAccessInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Role == input.Role ||
                    this.Role.Equals(input.Role)
                ) &&
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) &&
                (
                    this.ThroughAccountant == input.ThroughAccountant ||
                    (this.ThroughAccountant != null &&
                    this.ThroughAccountant.Equals(input.ThroughAccountant))
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
                hashCode = (hashCode * 59) + this.Role.GetHashCode();
                if (this.Permissions != null)
                {
                    hashCode = (hashCode * 59) + this.Permissions.GetHashCode();
                }
                if (this.ThroughAccountant != null)
                {
                    hashCode = (hashCode * 59) + this.ThroughAccountant.GetHashCode();
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
