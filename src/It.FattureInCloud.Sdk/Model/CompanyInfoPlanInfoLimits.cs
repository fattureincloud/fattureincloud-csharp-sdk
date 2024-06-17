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
    /// Company plan limits
    /// </summary>
    [DataContract(Name = "CompanyInfo_plan_info_limits")]
    public partial class CompanyInfoPlanInfoLimits : IEquatable<CompanyInfoPlanInfoLimits>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyInfoPlanInfoLimits" /> class.
        /// </summary>
        /// <param name="clients">Company plan clients limits.</param>
        /// <param name="suppliers">Company plan suppliers limits.</param>
        /// <param name="products">Company plan products limits.</param>
        /// <param name="documents">Company plan documents limits.</param>
        public CompanyInfoPlanInfoLimits(int? clients = default(int?), int? suppliers = default(int?), int? products = default(int?), int? documents = default(int?))
        {
            this._Clients = clients;
            if (this.Clients != null)
            {
                this._flagClients = true;
            }
            this._Suppliers = suppliers;
            if (this.Suppliers != null)
            {
                this._flagSuppliers = true;
            }
            this._Products = products;
            if (this.Products != null)
            {
                this._flagProducts = true;
            }
            this._Documents = documents;
            if (this.Documents != null)
            {
                this._flagDocuments = true;
            }
        }

        /// <summary>
        /// Company plan clients limits
        /// </summary>
        /// <value>Company plan clients limits</value>
        [DataMember(Name = "clients", EmitDefaultValue = true)]
        public int? Clients
        {
            get { return _Clients; }
            set
            {
                _Clients = value;
                _flagClients = true;
            }
        }
        private int? _Clients;
        private bool _flagClients;

        /// <summary>
        /// Returns false as Clients should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeClients()
        {
            return _flagClients;
        }
        /// <summary>
        /// Company plan suppliers limits
        /// </summary>
        /// <value>Company plan suppliers limits</value>
        [DataMember(Name = "suppliers", EmitDefaultValue = true)]
        public int? Suppliers
        {
            get { return _Suppliers; }
            set
            {
                _Suppliers = value;
                _flagSuppliers = true;
            }
        }
        private int? _Suppliers;
        private bool _flagSuppliers;

        /// <summary>
        /// Returns false as Suppliers should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSuppliers()
        {
            return _flagSuppliers;
        }
        /// <summary>
        /// Company plan products limits
        /// </summary>
        /// <value>Company plan products limits</value>
        [DataMember(Name = "products", EmitDefaultValue = true)]
        public int? Products
        {
            get { return _Products; }
            set
            {
                _Products = value;
                _flagProducts = true;
            }
        }
        private int? _Products;
        private bool _flagProducts;

        /// <summary>
        /// Returns false as Products should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProducts()
        {
            return _flagProducts;
        }
        /// <summary>
        /// Company plan documents limits
        /// </summary>
        /// <value>Company plan documents limits</value>
        [DataMember(Name = "documents", EmitDefaultValue = true)]
        public int? Documents
        {
            get { return _Documents; }
            set
            {
                _Documents = value;
                _flagDocuments = true;
            }
        }
        private int? _Documents;
        private bool _flagDocuments;

        /// <summary>
        /// Returns false as Documents should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDocuments()
        {
            return _flagDocuments;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyInfoPlanInfoLimits {\n");
            sb.Append("  Clients: ").Append(Clients).Append("\n");
            sb.Append("  Suppliers: ").Append(Suppliers).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
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
            return this.Equals(input as CompanyInfoPlanInfoLimits);
        }

        /// <summary>
        /// Returns true if CompanyInfoPlanInfoLimits instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyInfoPlanInfoLimits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyInfoPlanInfoLimits input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Clients == input.Clients ||
                    (this.Clients != null &&
                    this.Clients.Equals(input.Clients))
                ) &&
                (
                    this.Suppliers == input.Suppliers ||
                    (this.Suppliers != null &&
                    this.Suppliers.Equals(input.Suppliers))
                ) &&
                (
                    this.Products == input.Products ||
                    (this.Products != null &&
                    this.Products.Equals(input.Products))
                ) &&
                (
                    this.Documents == input.Documents ||
                    (this.Documents != null &&
                    this.Documents.Equals(input.Documents))
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
                if (this.Clients != null)
                {
                    hashCode = (hashCode * 59) + this.Clients.GetHashCode();
                }
                if (this.Suppliers != null)
                {
                    hashCode = (hashCode * 59) + this.Suppliers.GetHashCode();
                }
                if (this.Products != null)
                {
                    hashCode = (hashCode * 59) + this.Products.GetHashCode();
                }
                if (this.Documents != null)
                {
                    hashCode = (hashCode * 59) + this.Documents.GetHashCode();
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
