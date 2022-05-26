/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.17
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
    /// F24
    /// </summary>
    [DataContract(Name = "F24")]
    public partial class F24 : IEquatable<F24>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>

        [DataMember(Name = "status", EmitDefaultValue = false)]
        public F24Status? Status
        {
            get { return _Status; }
            set
            {
                _Status = value;
                _flagStatus = true;
            }
        }
        private F24Status? _Status;
        private bool _flagStatus;

        /// <summary>
        /// Returns false as Status should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatus()
        {
            return _flagStatus;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="F24" /> class.
        /// </summary>
        /// <param name="id">Unique F24 identifier..</param>
        /// <param name="dueDate">Due date..</param>
        /// <param name="status">status.</param>
        /// <param name="paymentAccount">paymentAccount.</param>
        /// <param name="amount">Taxes amount..</param>
        /// <param name="attachmentToken">[Write Only] Attachment token returned by POST /taxes/attachment. Used to attach the file already uploaded..</param>
        /// <param name="description">Name or brief description..</param>
        public F24(int? id = default(int?), DateTime? dueDate = default(DateTime?), F24Status? status = default(F24Status?), PaymentAccount paymentAccount = default(PaymentAccount), decimal? amount = default(decimal?), string attachmentToken = default(string), string description = default(string))
        {
            this._Id = id;
            if (this.Id != null) this._flagId = true;
            this._DueDate = dueDate;
            if (this.DueDate != null) this._flagDueDate = true;
            this._Status = status;
            if (this.Status != null) this._flagStatus = true;
            this._PaymentAccount = paymentAccount;
            if (this.PaymentAccount != null) this._flagPaymentAccount = true;
            this._Amount = amount;
            if (this.Amount != null) this._flagAmount = true;
            this._AttachmentToken = attachmentToken;
            if (this.AttachmentToken != null) this._flagAttachmentToken = true;
            this._Description = description;
            if (this.Description != null) this._flagDescription = true;
        }

        /// <summary>
        /// Unique F24 identifier.
        /// </summary>
        /// <value>Unique F24 identifier.</value>
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
        /// Due date.
        /// </summary>
        /// <value>Due date.</value>
        [JsonConverter(typeof(OpenAPIDateConverter))]
        [DataMember(Name = "due_date", EmitDefaultValue = true)]
        public DateTime? DueDate
        {
            get { return _DueDate; }
            set
            {
                _DueDate = value;
                _flagDueDate = true;
            }
        }
        private DateTime? _DueDate;
        private bool _flagDueDate;

        /// <summary>
        /// Returns false as DueDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDueDate()
        {
            return _flagDueDate;
        }
        /// <summary>
        /// Gets or Sets PaymentAccount
        /// </summary>
        [DataMember(Name = "payment_account", EmitDefaultValue = true)]
        public PaymentAccount PaymentAccount
        {
            get { return _PaymentAccount; }
            set
            {
                _PaymentAccount = value;
                _flagPaymentAccount = true;
            }
        }
        private PaymentAccount _PaymentAccount;
        private bool _flagPaymentAccount;

        /// <summary>
        /// Returns false as PaymentAccount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentAccount()
        {
            return _flagPaymentAccount;
        }
        /// <summary>
        /// Taxes amount.
        /// </summary>
        /// <value>Taxes amount.</value>
        [DataMember(Name = "amount", EmitDefaultValue = true)]
        public decimal? Amount
        {
            get { return _Amount; }
            set
            {
                _Amount = value;
                _flagAmount = true;
            }
        }
        private decimal? _Amount;
        private bool _flagAmount;

        /// <summary>
        /// Returns false as Amount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmount()
        {
            return _flagAmount;
        }
        /// <summary>
        /// [Read Only] Absolute url of the attached file. Authomatically set if a valid attachment token is passed via POST /taxes or PUT /taxes/{documentId}.
        /// </summary>
        /// <value>[Read Only] Absolute url of the attached file. Authomatically set if a valid attachment token is passed via POST /taxes or PUT /taxes/{documentId}.</value>
        [DataMember(Name = "attachment_url", EmitDefaultValue = true)]
        public string AttachmentUrl { get; private set; }

        /// <summary>
        /// Returns false as AttachmentUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAttachmentUrl()
        {
            return false;
        }
        /// <summary>
        /// [Write Only] Attachment token returned by POST /taxes/attachment. Used to attach the file already uploaded.
        /// </summary>
        /// <value>[Write Only] Attachment token returned by POST /taxes/attachment. Used to attach the file already uploaded.</value>
        [DataMember(Name = "attachment_token", EmitDefaultValue = true)]
        public string AttachmentToken
        {
            get { return _AttachmentToken; }
            set
            {
                _AttachmentToken = value;
                _flagAttachmentToken = true;
            }
        }
        private string _AttachmentToken;
        private bool _flagAttachmentToken;

        /// <summary>
        /// Returns false as AttachmentToken should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAttachmentToken()
        {
            return _flagAttachmentToken;
        }
        /// <summary>
        /// Name or brief description.
        /// </summary>
        /// <value>Name or brief description.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description
        {
            get { return _Description; }
            set
            {
                _Description = value;
                _flagDescription = true;
            }
        }
        private string _Description;
        private bool _flagDescription;

        /// <summary>
        /// Returns false as Description should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDescription()
        {
            return _flagDescription;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class F24 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PaymentAccount: ").Append(PaymentAccount).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AttachmentUrl: ").Append(AttachmentUrl).Append("\n");
            sb.Append("  AttachmentToken: ").Append(AttachmentToken).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as F24);
        }

        /// <summary>
        /// Returns true if F24 instances are equal
        /// </summary>
        /// <param name="input">Instance of F24 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(F24 input)
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
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) &&
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) &&
                (
                    this.PaymentAccount == input.PaymentAccount ||
                    (this.PaymentAccount != null &&
                    this.PaymentAccount.Equals(input.PaymentAccount))
                ) &&
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) &&
                (
                    this.AttachmentUrl == input.AttachmentUrl ||
                    (this.AttachmentUrl != null &&
                    this.AttachmentUrl.Equals(input.AttachmentUrl))
                ) &&
                (
                    this.AttachmentToken == input.AttachmentToken ||
                    (this.AttachmentToken != null &&
                    this.AttachmentToken.Equals(input.AttachmentToken))
                ) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.DueDate != null)
                {
                    hashCode = (hashCode * 59) + this.DueDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.PaymentAccount != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentAccount.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.AttachmentUrl != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentUrl.GetHashCode();
                }
                if (this.AttachmentToken != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentToken.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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
