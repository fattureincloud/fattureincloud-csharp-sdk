/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.10
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
    /// ReceivedDocumentItemsListItem
    /// </summary>
    [DataContract(Name = "ReceivedDocumentItemsListItem")]
    public partial class ReceivedDocumentItemsListItem : IEquatable<ReceivedDocumentItemsListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceivedDocumentItemsListItem" /> class.
        /// </summary>
        /// <param name="id">Unique identifier..</param>
        /// <param name="productId">Unique identifier of the product.</param>
        /// <param name="code">Product code..</param>
        /// <param name="name">Product name..</param>
        /// <param name="measure">Product measure..</param>
        /// <param name="netPrice">Product net price..</param>
        /// <param name="category">Product category..</param>
        /// <param name="qty">Product quantity..</param>
        /// <param name="vat">vat.</param>
        /// <param name="stock">Number of items in stock.</param>
        public ReceivedDocumentItemsListItem(int id = default(int), int productId = default(int), string code = default(string), string name = default(string), string measure = default(string), decimal netPrice = default(decimal), string category = default(string), decimal qty = default(decimal), VatType vat = default(VatType), decimal stock = default(decimal))
        {
            this.Id = id;
            this.ProductId = productId;
            this.Code = code;
            this.Name = name;
            this.Measure = measure;
            this.NetPrice = netPrice;
            this.Category = category;
            this.Qty = qty;
            this.Vat = vat;
            this.Stock = stock;
        }

        /// <summary>
        /// Unique identifier.
        /// </summary>
        /// <value>Unique identifier.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Unique identifier of the product
        /// </summary>
        /// <value>Unique identifier of the product</value>
        [DataMember(Name = "product_id", EmitDefaultValue = false)]
        public int ProductId { get; set; }

        /// <summary>
        /// Product code.
        /// </summary>
        /// <value>Product code.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        /// <value>Product name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Product measure.
        /// </summary>
        /// <value>Product measure.</value>
        [DataMember(Name = "measure", EmitDefaultValue = false)]
        public string Measure { get; set; }

        /// <summary>
        /// Product net price.
        /// </summary>
        /// <value>Product net price.</value>
        [DataMember(Name = "net_price", EmitDefaultValue = false)]
        public decimal NetPrice { get; set; }

        /// <summary>
        /// Product category.
        /// </summary>
        /// <value>Product category.</value>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Product quantity.
        /// </summary>
        /// <value>Product quantity.</value>
        [DataMember(Name = "qty", EmitDefaultValue = false)]
        public decimal Qty { get; set; }

        /// <summary>
        /// Gets or Sets Vat
        /// </summary>
        [DataMember(Name = "vat", EmitDefaultValue = true)]
        public VatType Vat { get; set; }

        /// <summary>
        /// Number of items in stock
        /// </summary>
        /// <value>Number of items in stock</value>
        [DataMember(Name = "stock", EmitDefaultValue = false)]
        public decimal Stock { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReceivedDocumentItemsListItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Measure: ").Append(Measure).Append("\n");
            sb.Append("  NetPrice: ").Append(NetPrice).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  Vat: ").Append(Vat).Append("\n");
            sb.Append("  Stock: ").Append(Stock).Append("\n");
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
            return this.Equals(input as ReceivedDocumentItemsListItem);
        }

        /// <summary>
        /// Returns true if ReceivedDocumentItemsListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ReceivedDocumentItemsListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceivedDocumentItemsListItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    this.ProductId.Equals(input.ProductId)
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Measure == input.Measure ||
                    (this.Measure != null &&
                    this.Measure.Equals(input.Measure))
                ) && 
                (
                    this.NetPrice == input.NetPrice ||
                    this.NetPrice.Equals(input.NetPrice)
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Qty == input.Qty ||
                    this.Qty.Equals(input.Qty)
                ) && 
                (
                    this.Vat == input.Vat ||
                    (this.Vat != null &&
                    this.Vat.Equals(input.Vat))
                ) && 
                (
                    this.Stock == input.Stock ||
                    this.Stock.Equals(input.Stock)
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                hashCode = (hashCode * 59) + this.ProductId.GetHashCode();
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Measure != null)
                {
                    hashCode = (hashCode * 59) + this.Measure.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NetPrice.GetHashCode();
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Qty.GetHashCode();
                if (this.Vat != null)
                {
                    hashCode = (hashCode * 59) + this.Vat.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Stock.GetHashCode();
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
