/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.8
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
    /// IssuedDocumentItemsList
    /// </summary>
    [DataContract(Name = "IssuedDocument_items_list")]
    public partial class IssuedDocumentItemsList : IEquatable<IssuedDocumentItemsList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedDocumentItemsList" /> class.
        /// </summary>
        /// <param name="productId">Unique identifier of the product..</param>
        /// <param name="code">Product code..</param>
        /// <param name="name">Product name..</param>
        /// <param name="description">Product description..</param>
        /// <param name="qty">Items quantity,.</param>
        /// <param name="measure">Item measure..</param>
        /// <param name="netPrice">Net price..</param>
        /// <param name="grossPrice">Gross price..</param>
        /// <param name="vat">vat.</param>
        /// <param name="notTaxable">notTaxable (default to false).</param>
        /// <param name="applyWithholdingTaxes">Apply withholding taxes, rivalsa and cassa. (default to true).</param>
        /// <param name="discount">Discount percentual value..</param>
        /// <param name="discountHighlight">discountHighlight (default to false).</param>
        /// <param name="inDdt">inDdt (default to true).</param>
        /// <param name="stock">stock.</param>
        /// <param name="eiRaw">Advanced raw attributes for e-invoices..</param>
        public IssuedDocumentItemsList(int? productId = default(int?), string code = default(string), string name = default(string), string description = default(string), decimal qty = default(decimal), string measure = default(string), decimal netPrice = default(decimal), decimal? grossPrice = default(decimal?), VatType vat = default(VatType), bool notTaxable = false, bool applyWithholdingTaxes = true, decimal discount = default(decimal), bool discountHighlight = false, bool inDdt = true, bool? stock = default(bool?), Object eiRaw = default(Object))
        {
            this.ProductId = productId;
            this.Code = code;
            this.Name = name;
            this.Description = description;
            this.Qty = qty;
            this.Measure = measure;
            this.NetPrice = netPrice;
            this.GrossPrice = grossPrice;
            this.Vat = vat;
            this.NotTaxable = notTaxable;
            this.ApplyWithholdingTaxes = applyWithholdingTaxes;
            this.Discount = discount;
            this.DiscountHighlight = discountHighlight;
            this.InDdt = inDdt;
            this.Stock = stock;
            this.EiRaw = eiRaw;
        }

        /// <summary>
        /// Unique identifier of the product.
        /// </summary>
        /// <value>Unique identifier of the product.</value>
        [DataMember(Name = "product_id", EmitDefaultValue = true)]
        public int? ProductId { get; set; }

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
        /// Product description.
        /// </summary>
        /// <value>Product description.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Items quantity,
        /// </summary>
        /// <value>Items quantity,</value>
        [DataMember(Name = "qty", EmitDefaultValue = false)]
        public decimal Qty { get; set; }

        /// <summary>
        /// Item measure.
        /// </summary>
        /// <value>Item measure.</value>
        [DataMember(Name = "measure", EmitDefaultValue = false)]
        public string Measure { get; set; }

        /// <summary>
        /// Net price.
        /// </summary>
        /// <value>Net price.</value>
        [DataMember(Name = "net_price", EmitDefaultValue = false)]
        public decimal NetPrice { get; set; }

        /// <summary>
        /// Gross price.
        /// </summary>
        /// <value>Gross price.</value>
        [DataMember(Name = "gross_price", EmitDefaultValue = true)]
        public decimal? GrossPrice { get; set; }

        /// <summary>
        /// Gets or Sets Vat
        /// </summary>
        [DataMember(Name = "vat", EmitDefaultValue = true)]
        public VatType Vat { get; set; }

        /// <summary>
        /// Gets or Sets NotTaxable
        /// </summary>
        [DataMember(Name = "not_taxable", EmitDefaultValue = true)]
        public bool NotTaxable { get; set; }

        /// <summary>
        /// Apply withholding taxes, rivalsa and cassa.
        /// </summary>
        /// <value>Apply withholding taxes, rivalsa and cassa.</value>
        [DataMember(Name = "apply_withholding_taxes", EmitDefaultValue = true)]
        public bool ApplyWithholdingTaxes { get; set; }

        /// <summary>
        /// Discount percentual value.
        /// </summary>
        /// <value>Discount percentual value.</value>
        [DataMember(Name = "discount", EmitDefaultValue = false)]
        public decimal Discount { get; set; }

        /// <summary>
        /// Gets or Sets DiscountHighlight
        /// </summary>
        [DataMember(Name = "discount_highlight", EmitDefaultValue = true)]
        public bool DiscountHighlight { get; set; }

        /// <summary>
        /// Gets or Sets InDdt
        /// </summary>
        [DataMember(Name = "in_ddt", EmitDefaultValue = true)]
        public bool InDdt { get; set; }

        /// <summary>
        /// Gets or Sets Stock
        /// </summary>
        [DataMember(Name = "stock", EmitDefaultValue = true)]
        public bool? Stock { get; set; }

        /// <summary>
        /// Advanced raw attributes for e-invoices.
        /// </summary>
        /// <value>Advanced raw attributes for e-invoices.</value>
        [DataMember(Name = "ei_raw", EmitDefaultValue = false)]
        public Object EiRaw { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssuedDocumentItemsList {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  Measure: ").Append(Measure).Append("\n");
            sb.Append("  NetPrice: ").Append(NetPrice).Append("\n");
            sb.Append("  GrossPrice: ").Append(GrossPrice).Append("\n");
            sb.Append("  Vat: ").Append(Vat).Append("\n");
            sb.Append("  NotTaxable: ").Append(NotTaxable).Append("\n");
            sb.Append("  ApplyWithholdingTaxes: ").Append(ApplyWithholdingTaxes).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  DiscountHighlight: ").Append(DiscountHighlight).Append("\n");
            sb.Append("  InDdt: ").Append(InDdt).Append("\n");
            sb.Append("  Stock: ").Append(Stock).Append("\n");
            sb.Append("  EiRaw: ").Append(EiRaw).Append("\n");
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
            return this.Equals(input as IssuedDocumentItemsList);
        }

        /// <summary>
        /// Returns true if IssuedDocumentItemsList instances are equal
        /// </summary>
        /// <param name="input">Instance of IssuedDocumentItemsList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssuedDocumentItemsList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Qty == input.Qty ||
                    this.Qty.Equals(input.Qty)
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
                    this.GrossPrice == input.GrossPrice ||
                    (this.GrossPrice != null &&
                    this.GrossPrice.Equals(input.GrossPrice))
                ) && 
                (
                    this.Vat == input.Vat ||
                    (this.Vat != null &&
                    this.Vat.Equals(input.Vat))
                ) && 
                (
                    this.NotTaxable == input.NotTaxable ||
                    this.NotTaxable.Equals(input.NotTaxable)
                ) && 
                (
                    this.ApplyWithholdingTaxes == input.ApplyWithholdingTaxes ||
                    this.ApplyWithholdingTaxes.Equals(input.ApplyWithholdingTaxes)
                ) && 
                (
                    this.Discount == input.Discount ||
                    this.Discount.Equals(input.Discount)
                ) && 
                (
                    this.DiscountHighlight == input.DiscountHighlight ||
                    this.DiscountHighlight.Equals(input.DiscountHighlight)
                ) && 
                (
                    this.InDdt == input.InDdt ||
                    this.InDdt.Equals(input.InDdt)
                ) && 
                (
                    this.Stock == input.Stock ||
                    (this.Stock != null &&
                    this.Stock.Equals(input.Stock))
                ) && 
                (
                    this.EiRaw == input.EiRaw ||
                    (this.EiRaw != null &&
                    this.EiRaw.Equals(input.EiRaw))
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
                if (this.ProductId != null)
                {
                    hashCode = (hashCode * 59) + this.ProductId.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Qty.GetHashCode();
                if (this.Measure != null)
                {
                    hashCode = (hashCode * 59) + this.Measure.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NetPrice.GetHashCode();
                if (this.GrossPrice != null)
                {
                    hashCode = (hashCode * 59) + this.GrossPrice.GetHashCode();
                }
                if (this.Vat != null)
                {
                    hashCode = (hashCode * 59) + this.Vat.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NotTaxable.GetHashCode();
                hashCode = (hashCode * 59) + this.ApplyWithholdingTaxes.GetHashCode();
                hashCode = (hashCode * 59) + this.Discount.GetHashCode();
                hashCode = (hashCode * 59) + this.DiscountHighlight.GetHashCode();
                hashCode = (hashCode * 59) + this.InDdt.GetHashCode();
                if (this.Stock != null)
                {
                    hashCode = (hashCode * 59) + this.Stock.GetHashCode();
                }
                if (this.EiRaw != null)
                {
                    hashCode = (hashCode * 59) + this.EiRaw.GetHashCode();
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
            // Discount (decimal) maximum
            if (this.Discount > (decimal)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Discount, must be a value less than or equal to 100.", new [] { "Discount" });
            }

            // Discount (decimal) minimum
            if (this.Discount < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Discount, must be a value greater than or equal to 0.", new [] { "Discount" });
            }

            yield break;
        }
    }

}
