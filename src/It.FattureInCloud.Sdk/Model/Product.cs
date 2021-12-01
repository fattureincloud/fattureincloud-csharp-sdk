/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.6
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
    /// Product
    /// </summary>
    [DataContract(Name = "Product")]
    public partial class Product : IEquatable<Product>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        /// <param name="id">Unique identifier..</param>
        /// <param name="name">Product name..</param>
        /// <param name="code">Product code..</param>
        /// <param name="netPrice">Net sale price (used if use_gross_price is false, otherwise it&#39;s competed automatically)..</param>
        /// <param name="grossPrice">Gross sale price (used if use_gross_price is false, otherwise it&#39;s competed automatically)..</param>
        /// <param name="useGrossPrice">Determine which price to use for calculations..</param>
        /// <param name="defaultVat">defaultVat.</param>
        /// <param name="netCost">Net cost of the product (used for received documents)..</param>
        /// <param name="measure">Unit of measure..</param>
        /// <param name="description">Product description..</param>
        /// <param name="category">Product category..</param>
        /// <param name="notes">Extra notes..</param>
        /// <param name="inStock">Determine if the product is in stock..</param>
        /// <param name="stockInitial">Product initial stock..</param>
        /// <param name="averageCost">Product average cost..</param>
        /// <param name="averagePrice">Product average price..</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public Product(int id = default(int), string name = default(string), string code = default(string), decimal? netPrice = default(decimal?), decimal? grossPrice = default(decimal?), bool useGrossPrice = default(bool), VatType defaultVat = default(VatType), decimal? netCost = default(decimal?), string measure = default(string), string description = default(string), string category = default(string), string notes = default(string), bool inStock = default(bool), decimal stockInitial = default(decimal), decimal averageCost = default(decimal), decimal averagePrice = default(decimal), string createdAt = default(string), string updatedAt = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Code = code;
            this.NetPrice = netPrice;
            this.GrossPrice = grossPrice;
            this.UseGrossPrice = useGrossPrice;
            this.DefaultVat = defaultVat;
            this.NetCost = netCost;
            this.Measure = measure;
            this.Description = description;
            this.Category = category;
            this.Notes = notes;
            this.InStock = inStock;
            this.StockInitial = stockInitial;
            this.AverageCost = averageCost;
            this.AveragePrice = averagePrice;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Unique identifier.
        /// </summary>
        /// <value>Unique identifier.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        /// <value>Product name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Product code.
        /// </summary>
        /// <value>Product code.</value>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Net sale price (used if use_gross_price is false, otherwise it&#39;s competed automatically).
        /// </summary>
        /// <value>Net sale price (used if use_gross_price is false, otherwise it&#39;s competed automatically).</value>
        [DataMember(Name = "net_price", EmitDefaultValue = true)]
        public decimal? NetPrice { get; set; }

        /// <summary>
        /// Gross sale price (used if use_gross_price is false, otherwise it&#39;s competed automatically).
        /// </summary>
        /// <value>Gross sale price (used if use_gross_price is false, otherwise it&#39;s competed automatically).</value>
        [DataMember(Name = "gross_price", EmitDefaultValue = true)]
        public decimal? GrossPrice { get; set; }

        /// <summary>
        /// Determine which price to use for calculations.
        /// </summary>
        /// <value>Determine which price to use for calculations.</value>
        [DataMember(Name = "use_gross_price", EmitDefaultValue = true)]
        public bool UseGrossPrice { get; set; }

        /// <summary>
        /// Gets or Sets DefaultVat
        /// </summary>
        [DataMember(Name = "default_vat", EmitDefaultValue = true)]
        public VatType DefaultVat { get; set; }

        /// <summary>
        /// Net cost of the product (used for received documents).
        /// </summary>
        /// <value>Net cost of the product (used for received documents).</value>
        [DataMember(Name = "net_cost", EmitDefaultValue = true)]
        public decimal? NetCost { get; set; }

        /// <summary>
        /// Unit of measure.
        /// </summary>
        /// <value>Unit of measure.</value>
        [DataMember(Name = "measure", EmitDefaultValue = true)]
        public string Measure { get; set; }

        /// <summary>
        /// Product description.
        /// </summary>
        /// <value>Product description.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Product category.
        /// </summary>
        /// <value>Product category.</value>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Extra notes.
        /// </summary>
        /// <value>Extra notes.</value>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// Determine if the product is in stock.
        /// </summary>
        /// <value>Determine if the product is in stock.</value>
        [DataMember(Name = "in_stock", EmitDefaultValue = true)]
        public bool InStock { get; set; }

        /// <summary>
        /// Product initial stock.
        /// </summary>
        /// <value>Product initial stock.</value>
        [DataMember(Name = "stock_initial", EmitDefaultValue = false)]
        public decimal StockInitial { get; set; }

        /// <summary>
        /// [Read Only] Product current stock.
        /// </summary>
        /// <value>[Read Only] Product current stock.</value>
        [DataMember(Name = "stock_current", EmitDefaultValue = false)]
        public decimal StockCurrent { get; private set; }

        /// <summary>
        /// Returns false as StockCurrent should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStockCurrent()
        {
            return false;
        }
        /// <summary>
        /// Product average cost.
        /// </summary>
        /// <value>Product average cost.</value>
        [DataMember(Name = "average_cost", EmitDefaultValue = false)]
        public decimal AverageCost { get; set; }

        /// <summary>
        /// Product average price.
        /// </summary>
        /// <value>Product average price.</value>
        [DataMember(Name = "average_price", EmitDefaultValue = false)]
        public decimal AveragePrice { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Product {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  NetPrice: ").Append(NetPrice).Append("\n");
            sb.Append("  GrossPrice: ").Append(GrossPrice).Append("\n");
            sb.Append("  UseGrossPrice: ").Append(UseGrossPrice).Append("\n");
            sb.Append("  DefaultVat: ").Append(DefaultVat).Append("\n");
            sb.Append("  NetCost: ").Append(NetCost).Append("\n");
            sb.Append("  Measure: ").Append(Measure).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  InStock: ").Append(InStock).Append("\n");
            sb.Append("  StockInitial: ").Append(StockInitial).Append("\n");
            sb.Append("  StockCurrent: ").Append(StockCurrent).Append("\n");
            sb.Append("  AverageCost: ").Append(AverageCost).Append("\n");
            sb.Append("  AveragePrice: ").Append(AveragePrice).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as Product);
        }

        /// <summary>
        /// Returns true if Product instances are equal
        /// </summary>
        /// <param name="input">Instance of Product to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Product input)
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
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.NetPrice == input.NetPrice ||
                    (this.NetPrice != null &&
                    this.NetPrice.Equals(input.NetPrice))
                ) && 
                (
                    this.GrossPrice == input.GrossPrice ||
                    (this.GrossPrice != null &&
                    this.GrossPrice.Equals(input.GrossPrice))
                ) && 
                (
                    this.UseGrossPrice == input.UseGrossPrice ||
                    this.UseGrossPrice.Equals(input.UseGrossPrice)
                ) && 
                (
                    this.DefaultVat == input.DefaultVat ||
                    (this.DefaultVat != null &&
                    this.DefaultVat.Equals(input.DefaultVat))
                ) && 
                (
                    this.NetCost == input.NetCost ||
                    (this.NetCost != null &&
                    this.NetCost.Equals(input.NetCost))
                ) && 
                (
                    this.Measure == input.Measure ||
                    (this.Measure != null &&
                    this.Measure.Equals(input.Measure))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.InStock == input.InStock ||
                    this.InStock.Equals(input.InStock)
                ) && 
                (
                    this.StockInitial == input.StockInitial ||
                    this.StockInitial.Equals(input.StockInitial)
                ) && 
                (
                    this.StockCurrent == input.StockCurrent ||
                    this.StockCurrent.Equals(input.StockCurrent)
                ) && 
                (
                    this.AverageCost == input.AverageCost ||
                    this.AverageCost.Equals(input.AverageCost)
                ) && 
                (
                    this.AveragePrice == input.AveragePrice ||
                    this.AveragePrice.Equals(input.AveragePrice)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.NetPrice != null)
                    hashCode = hashCode * 59 + this.NetPrice.GetHashCode();
                if (this.GrossPrice != null)
                    hashCode = hashCode * 59 + this.GrossPrice.GetHashCode();
                hashCode = hashCode * 59 + this.UseGrossPrice.GetHashCode();
                if (this.DefaultVat != null)
                    hashCode = hashCode * 59 + this.DefaultVat.GetHashCode();
                if (this.NetCost != null)
                    hashCode = hashCode * 59 + this.NetCost.GetHashCode();
                if (this.Measure != null)
                    hashCode = hashCode * 59 + this.Measure.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                hashCode = hashCode * 59 + this.InStock.GetHashCode();
                hashCode = hashCode * 59 + this.StockInitial.GetHashCode();
                hashCode = hashCode * 59 + this.StockCurrent.GetHashCode();
                hashCode = hashCode * 59 + this.AverageCost.GetHashCode();
                hashCode = hashCode * 59 + this.AveragePrice.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
