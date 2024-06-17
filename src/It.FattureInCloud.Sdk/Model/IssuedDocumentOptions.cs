/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.1.0
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
    /// IssuedDocumentOptions
    /// </summary>
    [DataContract(Name = "IssuedDocumentOptions")]
    public partial class IssuedDocumentOptions : IEquatable<IssuedDocumentOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedDocumentOptions" /> class.
        /// </summary>
        /// <param name="fixPayments">Fixes your last payment amount to match your document total.</param>
        /// <param name="createFrom">Original documents ids [only for join/transform].</param>
        /// <param name="transform">Tranform a document [only for transform].</param>
        /// <param name="keepCopy">Keep original document [only for transform].</param>
        /// <param name="joinType">Join type [only for join].</param>
        public IssuedDocumentOptions(bool? fixPayments = default(bool?), List<string> createFrom = default(List<string>), bool? transform = default(bool?), bool? keepCopy = default(bool?), string joinType = default(string))
        {
            this._FixPayments = fixPayments;
            if (this.FixPayments != null)
            {
                this._flagFixPayments = true;
            }
            this._CreateFrom = createFrom;
            if (this.CreateFrom != null)
            {
                this._flagCreateFrom = true;
            }
            this._Transform = transform;
            if (this.Transform != null)
            {
                this._flagTransform = true;
            }
            this._KeepCopy = keepCopy;
            if (this.KeepCopy != null)
            {
                this._flagKeepCopy = true;
            }
            this._JoinType = joinType;
            if (this.JoinType != null)
            {
                this._flagJoinType = true;
            }
        }

        /// <summary>
        /// Fixes your last payment amount to match your document total
        /// </summary>
        /// <value>Fixes your last payment amount to match your document total</value>
        [DataMember(Name = "fix_payments", EmitDefaultValue = true)]
        public bool? FixPayments
        {
            get { return _FixPayments; }
            set
            {
                _FixPayments = value;
                _flagFixPayments = true;
            }
        }
        private bool? _FixPayments;
        private bool _flagFixPayments;

        /// <summary>
        /// Returns false as FixPayments should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFixPayments()
        {
            return _flagFixPayments;
        }
        /// <summary>
        /// Original documents ids [only for join/transform]
        /// </summary>
        /// <value>Original documents ids [only for join/transform]</value>
        [DataMember(Name = "create_from", EmitDefaultValue = true)]
        public List<string> CreateFrom
        {
            get { return _CreateFrom; }
            set
            {
                _CreateFrom = value;
                _flagCreateFrom = true;
            }
        }
        private List<string> _CreateFrom;
        private bool _flagCreateFrom;

        /// <summary>
        /// Returns false as CreateFrom should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreateFrom()
        {
            return _flagCreateFrom;
        }
        /// <summary>
        /// Tranform a document [only for transform]
        /// </summary>
        /// <value>Tranform a document [only for transform]</value>
        [DataMember(Name = "transform", EmitDefaultValue = true)]
        public bool? Transform
        {
            get { return _Transform; }
            set
            {
                _Transform = value;
                _flagTransform = true;
            }
        }
        private bool? _Transform;
        private bool _flagTransform;

        /// <summary>
        /// Returns false as Transform should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTransform()
        {
            return _flagTransform;
        }
        /// <summary>
        /// Keep original document [only for transform]
        /// </summary>
        /// <value>Keep original document [only for transform]</value>
        [DataMember(Name = "keep_copy", EmitDefaultValue = true)]
        public bool? KeepCopy
        {
            get { return _KeepCopy; }
            set
            {
                _KeepCopy = value;
                _flagKeepCopy = true;
            }
        }
        private bool? _KeepCopy;
        private bool _flagKeepCopy;

        /// <summary>
        /// Returns false as KeepCopy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeKeepCopy()
        {
            return _flagKeepCopy;
        }
        /// <summary>
        /// Join type [only for join]
        /// </summary>
        /// <value>Join type [only for join]</value>
        [DataMember(Name = "join_type", EmitDefaultValue = true)]
        public string JoinType
        {
            get { return _JoinType; }
            set
            {
                _JoinType = value;
                _flagJoinType = true;
            }
        }
        private string _JoinType;
        private bool _flagJoinType;

        /// <summary>
        /// Returns false as JoinType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeJoinType()
        {
            return _flagJoinType;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssuedDocumentOptions {\n");
            sb.Append("  FixPayments: ").Append(FixPayments).Append("\n");
            sb.Append("  CreateFrom: ").Append(CreateFrom).Append("\n");
            sb.Append("  Transform: ").Append(Transform).Append("\n");
            sb.Append("  KeepCopy: ").Append(KeepCopy).Append("\n");
            sb.Append("  JoinType: ").Append(JoinType).Append("\n");
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
            return this.Equals(input as IssuedDocumentOptions);
        }

        /// <summary>
        /// Returns true if IssuedDocumentOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of IssuedDocumentOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssuedDocumentOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.FixPayments == input.FixPayments ||
                    (this.FixPayments != null &&
                    this.FixPayments.Equals(input.FixPayments))
                ) &&
                (
                    this.CreateFrom == input.CreateFrom ||
                    this.CreateFrom != null &&
                    input.CreateFrom != null &&
                    this.CreateFrom.SequenceEqual(input.CreateFrom)
                ) &&
                (
                    this.Transform == input.Transform ||
                    (this.Transform != null &&
                    this.Transform.Equals(input.Transform))
                ) &&
                (
                    this.KeepCopy == input.KeepCopy ||
                    (this.KeepCopy != null &&
                    this.KeepCopy.Equals(input.KeepCopy))
                ) &&
                (
                    this.JoinType == input.JoinType ||
                    (this.JoinType != null &&
                    this.JoinType.Equals(input.JoinType))
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
                if (this.FixPayments != null)
                {
                    hashCode = (hashCode * 59) + this.FixPayments.GetHashCode();
                }
                if (this.CreateFrom != null)
                {
                    hashCode = (hashCode * 59) + this.CreateFrom.GetHashCode();
                }
                if (this.Transform != null)
                {
                    hashCode = (hashCode * 59) + this.Transform.GetHashCode();
                }
                if (this.KeepCopy != null)
                {
                    hashCode = (hashCode * 59) + this.KeepCopy.GetHashCode();
                }
                if (this.JoinType != null)
                {
                    hashCode = (hashCode * 59) + this.JoinType.GetHashCode();
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
