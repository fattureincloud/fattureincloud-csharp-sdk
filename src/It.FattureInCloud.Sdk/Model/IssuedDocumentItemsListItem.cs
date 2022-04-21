/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.15
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
    /// IssuedDocumentItemsListItem
    /// </summary>
    [DataContract(Name = "IssuedDocumentItemsListItem")]
    public partial class IssuedDocumentItemsListItem : IEquatable<IssuedDocumentItemsListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedDocumentItemsListItem" /> class.
        /// </summary>
        /// <param name="id">Unique identifier..</param>
        /// <param name="productId">Unique identifier of the product..</param>
        /// <param name="code">Product code..</param>
        /// <param name="name">Product name..</param>
        /// <param name="category">Product category.</param>
        /// <param name="description">Product description..</param>
        /// <param name="qty">Items quantity,.</param>
        /// <param name="measure">Item measure..</param>
        /// <param name="netPrice">Net price..</param>
        /// <param name="grossPrice">Gross price..</param>
        /// <param name="vat">vat.</param>
        /// <param name="notTaxable">notTaxable.</param>
        /// <param name="applyWithholdingTaxes">Apply withholding taxes, rivalsa and cassa..</param>
        /// <param name="discount">Discount percentual value..</param>
        /// <param name="discountHighlight">discountHighlight.</param>
        /// <param name="inDdt">inDdt.</param>
        /// <param name="stock">stock.</param>
        /// <param name="eiRaw">Advanced raw attributes for e-invoices..</param>
        public IssuedDocumentItemsListItem(int? id = default(int?), int? productId = default(int?), string code = default(string), string name = default(string), string category = default(string), string description = default(string), decimal? qty = default(decimal?), string measure = default(string), decimal? netPrice = default(decimal?), decimal? grossPrice = default(decimal?), VatType vat = default(VatType), bool? notTaxable = default(bool?), bool? applyWithholdingTaxes = default(bool?), decimal? discount = default(decimal?), bool? discountHighlight = default(bool?), bool? inDdt = default(bool?), bool? stock = default(bool?), Object eiRaw = default(Object))
        {
            this._Id = id;
            if (this.Id != null) this._flagId = true;
            this._ProductId = productId;
            if (this.ProductId != null) this._flagProductId = true;
            this._Code = code;
            if (this.Code != null) this._flagCode = true;
            this._Name = name;
            if (this.Name != null) this._flagName = true;
            this._Category = category;
            if (this.Category != null) this._flagCategory = true;
            this._Description = description;
            if (this.Description != null) this._flagDescription = true;
            this._Qty = qty;
            if (this.Qty != null) this._flagQty = true;
            this._Measure = measure;
            if (this.Measure != null) this._flagMeasure = true;
            this._NetPrice = netPrice;
            if (this.NetPrice != null) this._flagNetPrice = true;
            this._GrossPrice = grossPrice;
            if (this.GrossPrice != null) this._flagGrossPrice = true;
            this._Vat = vat;
            if (this.Vat != null) this._flagVat = true;
            this._NotTaxable = notTaxable;
            if (this.NotTaxable != null) this._flagNotTaxable = true;
            this._ApplyWithholdingTaxes = applyWithholdingTaxes;
            if (this.ApplyWithholdingTaxes != null) this._flagApplyWithholdingTaxes = true;
            this._Discount = discount;
            if (this.Discount != null) this._flagDiscount = true;
            this._DiscountHighlight = discountHighlight;
            if (this.DiscountHighlight != null) this._flagDiscountHighlight = true;
            this._InDdt = inDdt;
            if (this.InDdt != null) this._flagInDdt = true;
            this._Stock = stock;
            if (this.Stock != null) this._flagStock = true;
            this._EiRaw = eiRaw;
            if (this.EiRaw != null) this._flagEiRaw = true;
        }

        /// <summary>
        /// Unique identifier.
        /// </summary>
        /// <value>Unique identifier.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id
        {
            get{ return _Id;}
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
        /// Unique identifier of the product.
        /// </summary>
        /// <value>Unique identifier of the product.</value>
        [DataMember(Name = "product_id", EmitDefaultValue = true)]
        public int? ProductId
        {
            get{ return _ProductId;}
            set
            {
                _ProductId = value;
                _flagProductId = true;
            }
        }
        private int? _ProductId;
        private bool _flagProductId;

        /// <summary>
        /// Returns false as ProductId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProductId()
        {
            return _flagProductId;
        }
        /// <summary>
        /// Product code.
        /// </summary>
        /// <value>Product code.</value>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code
        {
            get{ return _Code;}
            set
            {
                _Code = value;
                _flagCode = true;
            }
        }
        private string _Code;
        private bool _flagCode;

        /// <summary>
        /// Returns false as Code should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCode()
        {
            return _flagCode;
        }
        /// <summary>
        /// Product name.
        /// </summary>
        /// <value>Product name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name
        {
            get{ return _Name;}
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
        /// Product category
        /// </summary>
        /// <value>Product category</value>
        [DataMember(Name = "category", EmitDefaultValue = true)]
        public string Category
        {
            get{ return _Category;}
            set
            {
                _Category = value;
                _flagCategory = true;
            }
        }
        private string _Category;
        private bool _flagCategory;

        /// <summary>
        /// Returns false as Category should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCategory()
        {
            return _flagCategory;
        }
        /// <summary>
        /// Product description.
        /// </summary>
        /// <value>Product description.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description
        {
            get{ return _Description;}
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
        /// Items quantity,
        /// </summary>
        /// <value>Items quantity,</value>
        [DataMember(Name = "qty", EmitDefaultValue = true)]
        public decimal? Qty
        {
            get{ return _Qty;}
            set
            {
                _Qty = value;
                _flagQty = true;
            }
        }
        private decimal? _Qty;
        private bool _flagQty;

        /// <summary>
        /// Returns false as Qty should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeQty()
        {
            return _flagQty;
        }
        /// <summary>
        /// Item measure.
        /// </summary>
        /// <value>Item measure.</value>
        [DataMember(Name = "measure", EmitDefaultValue = true)]
        public string Measure
        {
            get{ return _Measure;}
            set
            {
                _Measure = value;
                _flagMeasure = true;
            }
        }
        private string _Measure;
        private bool _flagMeasure;

        /// <summary>
        /// Returns false as Measure should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMeasure()
        {
            return _flagMeasure;
        }
        /// <summary>
        /// Net price.
        /// </summary>
        /// <value>Net price.</value>
        [DataMember(Name = "net_price", EmitDefaultValue = true)]
        public decimal? NetPrice
        {
            get{ return _NetPrice;}
            set
            {
                _NetPrice = value;
                _flagNetPrice = true;
            }
        }
        private decimal? _NetPrice;
        private bool _flagNetPrice;

        /// <summary>
        /// Returns false as NetPrice should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNetPrice()
        {
            return _flagNetPrice;
        }
        /// <summary>
        /// Gross price.
        /// </summary>
        /// <value>Gross price.</value>
        [DataMember(Name = "gross_price", EmitDefaultValue = true)]
        public decimal? GrossPrice
        {
            get{ return _GrossPrice;}
            set
            {
                _GrossPrice = value;
                _flagGrossPrice = true;
            }
        }
        private decimal? _GrossPrice;
        private bool _flagGrossPrice;

        /// <summary>
        /// Returns false as GrossPrice should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGrossPrice()
        {
            return _flagGrossPrice;
        }
        /// <summary>
        /// Gets or Sets Vat
        /// </summary>
        [DataMember(Name = "vat", EmitDefaultValue = true)]
        public VatType Vat
        {
            get{ return _Vat;}
            set
            {
                _Vat = value;
                _flagVat = true;
            }
        }
        private VatType _Vat;
        private bool _flagVat;

        /// <summary>
        /// Returns false as Vat should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVat()
        {
            return _flagVat;
        }
        /// <summary>
        /// Gets or Sets NotTaxable
        /// </summary>
        [DataMember(Name = "not_taxable", EmitDefaultValue = true)]
        public bool? NotTaxable
        {
            get{ return _NotTaxable;}
            set
            {
                _NotTaxable = value;
                _flagNotTaxable = true;
            }
        }
        private bool? _NotTaxable;
        private bool _flagNotTaxable;

        /// <summary>
        /// Returns false as NotTaxable should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNotTaxable()
        {
            return _flagNotTaxable;
        }
        /// <summary>
        /// Apply withholding taxes, rivalsa and cassa.
        /// </summary>
        /// <value>Apply withholding taxes, rivalsa and cassa.</value>
        [DataMember(Name = "apply_withholding_taxes", EmitDefaultValue = true)]
        public bool? ApplyWithholdingTaxes
        {
            get{ return _ApplyWithholdingTaxes;}
            set
            {
                _ApplyWithholdingTaxes = value;
                _flagApplyWithholdingTaxes = true;
            }
        }
        private bool? _ApplyWithholdingTaxes;
        private bool _flagApplyWithholdingTaxes;

        /// <summary>
        /// Returns false as ApplyWithholdingTaxes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeApplyWithholdingTaxes()
        {
            return _flagApplyWithholdingTaxes;
        }
        /// <summary>
        /// Discount percentual value.
        /// </summary>
        /// <value>Discount percentual value.</value>
        [DataMember(Name = "discount", EmitDefaultValue = true)]
        public decimal? Discount
        {
            get{ return _Discount;}
            set
            {
                _Discount = value;
                _flagDiscount = true;
            }
        }
        private decimal? _Discount;
        private bool _flagDiscount;

        /// <summary>
        /// Returns false as Discount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDiscount()
        {
            return _flagDiscount;
        }
        /// <summary>
        /// Gets or Sets DiscountHighlight
        /// </summary>
        [DataMember(Name = "discount_highlight", EmitDefaultValue = true)]
        public bool? DiscountHighlight
        {
            get{ return _DiscountHighlight;}
            set
            {
                _DiscountHighlight = value;
                _flagDiscountHighlight = true;
            }
        }
        private bool? _DiscountHighlight;
        private bool _flagDiscountHighlight;

        /// <summary>
        /// Returns false as DiscountHighlight should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDiscountHighlight()
        {
            return _flagDiscountHighlight;
        }
        /// <summary>
        /// Gets or Sets InDdt
        /// </summary>
        [DataMember(Name = "in_ddt", EmitDefaultValue = true)]
        public bool? InDdt
        {
            get{ return _InDdt;}
            set
            {
                _InDdt = value;
                _flagInDdt = true;
            }
        }
        private bool? _InDdt;
        private bool _flagInDdt;

        /// <summary>
        /// Returns false as InDdt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInDdt()
        {
            return _flagInDdt;
        }
        /// <summary>
        /// Gets or Sets Stock
        /// </summary>
        [DataMember(Name = "stock", EmitDefaultValue = true)]
        public bool? Stock
        {
            get{ return _Stock;}
            set
            {
                _Stock = value;
                _flagStock = true;
            }
        }
        private bool? _Stock;
        private bool _flagStock;

        /// <summary>
        /// Returns false as Stock should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStock()
        {
            return _flagStock;
        }
        /// <summary>
        /// Advanced raw attributes for e-invoices.
        /// </summary>
        /// <value>Advanced raw attributes for e-invoices.</value>
        [DataMember(Name = "ei_raw", EmitDefaultValue = true)]
        public Object EiRaw
        {
            get{ return _EiRaw;}
            set
            {
                _EiRaw = value;
                _flagEiRaw = true;
            }
        }
        private Object _EiRaw;
        private bool _flagEiRaw;

        /// <summary>
        /// Returns false as EiRaw should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEiRaw()
        {
            return _flagEiRaw;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssuedDocumentItemsListItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return this.Equals(input as IssuedDocumentItemsListItem);
        }

        /// <summary>
        /// Returns true if IssuedDocumentItemsListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of IssuedDocumentItemsListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssuedDocumentItemsListItem input)
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
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && 
                (
                    this.Measure == input.Measure ||
                    (this.Measure != null &&
                    this.Measure.Equals(input.Measure))
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
                    this.Vat == input.Vat ||
                    (this.Vat != null &&
                    this.Vat.Equals(input.Vat))
                ) && 
                (
                    this.NotTaxable == input.NotTaxable ||
                    (this.NotTaxable != null &&
                    this.NotTaxable.Equals(input.NotTaxable))
                ) && 
                (
                    this.ApplyWithholdingTaxes == input.ApplyWithholdingTaxes ||
                    (this.ApplyWithholdingTaxes != null &&
                    this.ApplyWithholdingTaxes.Equals(input.ApplyWithholdingTaxes))
                ) && 
                (
                    this.Discount == input.Discount ||
                    (this.Discount != null &&
                    this.Discount.Equals(input.Discount))
                ) && 
                (
                    this.DiscountHighlight == input.DiscountHighlight ||
                    (this.DiscountHighlight != null &&
                    this.DiscountHighlight.Equals(input.DiscountHighlight))
                ) && 
                (
                    this.InDdt == input.InDdt ||
                    (this.InDdt != null &&
                    this.InDdt.Equals(input.InDdt))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
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
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Qty != null)
                {
                    hashCode = (hashCode * 59) + this.Qty.GetHashCode();
                }
                if (this.Measure != null)
                {
                    hashCode = (hashCode * 59) + this.Measure.GetHashCode();
                }
                if (this.NetPrice != null)
                {
                    hashCode = (hashCode * 59) + this.NetPrice.GetHashCode();
                }
                if (this.GrossPrice != null)
                {
                    hashCode = (hashCode * 59) + this.GrossPrice.GetHashCode();
                }
                if (this.Vat != null)
                {
                    hashCode = (hashCode * 59) + this.Vat.GetHashCode();
                }
                if (this.NotTaxable != null)
                {
                    hashCode = (hashCode * 59) + this.NotTaxable.GetHashCode();
                }
                if (this.ApplyWithholdingTaxes != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyWithholdingTaxes.GetHashCode();
                }
                if (this.Discount != null)
                {
                    hashCode = (hashCode * 59) + this.Discount.GetHashCode();
                }
                if (this.DiscountHighlight != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountHighlight.GetHashCode();
                }
                if (this.InDdt != null)
                {
                    hashCode = (hashCode * 59) + this.InDdt.GetHashCode();
                }
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
            yield break;
        }
    }

}
