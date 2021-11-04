/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.3
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
    /// Client.
    /// </summary>
    [DataContract(Name = "_Client")]
    public partial class ModelClient : IEquatable<ModelClient>, IValidatableObject
    {
        /// <summary>
        /// Client type
        /// </summary>
        /// <value>Client type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Company for value: company
            /// </summary>
            [EnumMember(Value = "company")]
            Company = 1,

            /// <summary>
            /// Enum Person for value: person
            /// </summary>
            [EnumMember(Value = "person")]
            Person = 2,

            /// <summary>
            /// Enum Pa for value: pa
            /// </summary>
            [EnumMember(Value = "pa")]
            Pa = 3,

            /// <summary>
            /// Enum Condo for value: condo
            /// </summary>
            [EnumMember(Value = "condo")]
            Condo = 4

        }


        /// <summary>
        /// Client type
        /// </summary>
        /// <value>Client type</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Defines DefaultPaymentTermsType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DefaultPaymentTermsTypeEnum
        {
            /// <summary>
            /// Enum Standard for value: standard
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard = 1,

            /// <summary>
            /// Enum EndOfMonth for value: end_of_month
            /// </summary>
            [EnumMember(Value = "end_of_month")]
            EndOfMonth = 2

        }


        /// <summary>
        /// Gets or Sets DefaultPaymentTermsType
        /// </summary>
        [DataMember(Name = "default_payment_terms_type", EmitDefaultValue = false)]
        public DefaultPaymentTermsTypeEnum? DefaultPaymentTermsType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelClient" /> class.
        /// </summary>
        /// <param name="id">Unique identifier.</param>
        /// <param name="code">Client code..</param>
        /// <param name="name">Client name.</param>
        /// <param name="type">Client type.</param>
        /// <param name="firstName">Client first name..</param>
        /// <param name="lastName">Client last name..</param>
        /// <param name="contactPerson">contactPerson.</param>
        /// <param name="vatNumber">Client vat number.</param>
        /// <param name="taxCode">Client tax code..</param>
        /// <param name="addressStreet">Client street address..</param>
        /// <param name="addressPostalCode">Client postal code..</param>
        /// <param name="addressCity">Client city..</param>
        /// <param name="addressProvince">Client province..</param>
        /// <param name="addressExtra">Client address extra info..</param>
        /// <param name="country">Client country (default to &quot;Italia&quot;).</param>
        /// <param name="email">Client email..</param>
        /// <param name="certifiedEmail">Client certified email..</param>
        /// <param name="phone">Client phone..</param>
        /// <param name="fax">Client fax..</param>
        /// <param name="notes">Extra notes..</param>
        /// <param name="defaultVat">defaultVat.</param>
        /// <param name="defaultPaymentTerms">defaultPaymentTerms.</param>
        /// <param name="defaultPaymentTermsType">defaultPaymentTermsType (default to DefaultPaymentTermsTypeEnum.Standard).</param>
        /// <param name="defaultPaymentMethod">defaultPaymentMethod.</param>
        /// <param name="bankName">Client bank name..</param>
        /// <param name="bankIban">Client iban..</param>
        /// <param name="bankSwiftCode">Client bank swift code..</param>
        /// <param name="shippingAddress">Client shipping address..</param>
        /// <param name="eInvoice">Use e-invoices for this entity (default to false).</param>
        /// <param name="eiCode">E-invoice code.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public ModelClient(int id = default(int), string code = default(string), string name = default(string), TypeEnum? type = default(TypeEnum?), string firstName = default(string), string lastName = default(string), string contactPerson = default(string), string vatNumber = default(string), string taxCode = default(string), string addressStreet = default(string), string addressPostalCode = default(string), string addressCity = default(string), string addressProvince = default(string), string addressExtra = default(string), string country = "Italia", string email = default(string), string certifiedEmail = default(string), string phone = default(string), string fax = default(string), string notes = default(string), VatType defaultVat = default(VatType), int defaultPaymentTerms = default(int), DefaultPaymentTermsTypeEnum? defaultPaymentTermsType = DefaultPaymentTermsTypeEnum.Standard, PaymentMethod defaultPaymentMethod = default(PaymentMethod), string bankName = default(string), string bankIban = default(string), string bankSwiftCode = default(string), string shippingAddress = default(string), bool eInvoice = false, string eiCode = default(string), string createdAt = default(string), string updatedAt = default(string))
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
            this.Type = type;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ContactPerson = contactPerson;
            this.VatNumber = vatNumber;
            this.TaxCode = taxCode;
            this.AddressStreet = addressStreet;
            this.AddressPostalCode = addressPostalCode;
            this.AddressCity = addressCity;
            this.AddressProvince = addressProvince;
            this.AddressExtra = addressExtra;
            // use default value if no "country" provided
            this.Country = country ?? "Italia";
            this.Email = email;
            this.CertifiedEmail = certifiedEmail;
            this.Phone = phone;
            this.Fax = fax;
            this.Notes = notes;
            this.DefaultVat = defaultVat;
            this.DefaultPaymentTerms = defaultPaymentTerms;
            this.DefaultPaymentTermsType = defaultPaymentTermsType;
            this.DefaultPaymentMethod = defaultPaymentMethod;
            this.BankName = bankName;
            this.BankIban = bankIban;
            this.BankSwiftCode = bankSwiftCode;
            this.ShippingAddress = shippingAddress;
            this.EInvoice = eInvoice;
            this.EiCode = eiCode;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Unique identifier
        /// </summary>
        /// <value>Unique identifier</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Client code.
        /// </summary>
        /// <value>Client code.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Client name
        /// </summary>
        /// <value>Client name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Client first name.
        /// </summary>
        /// <value>Client first name.</value>
        [DataMember(Name = "first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Client last name.
        /// </summary>
        /// <value>Client last name.</value>
        [DataMember(Name = "last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets ContactPerson
        /// </summary>
        [DataMember(Name = "contact_person", EmitDefaultValue = false)]
        public string ContactPerson { get; set; }

        /// <summary>
        /// Client vat number
        /// </summary>
        /// <value>Client vat number</value>
        [DataMember(Name = "vat_number", EmitDefaultValue = false)]
        public string VatNumber { get; set; }

        /// <summary>
        /// Client tax code.
        /// </summary>
        /// <value>Client tax code.</value>
        [DataMember(Name = "tax_code", EmitDefaultValue = false)]
        public string TaxCode { get; set; }

        /// <summary>
        /// Client street address.
        /// </summary>
        /// <value>Client street address.</value>
        [DataMember(Name = "address_street", EmitDefaultValue = false)]
        public string AddressStreet { get; set; }

        /// <summary>
        /// Client postal code.
        /// </summary>
        /// <value>Client postal code.</value>
        [DataMember(Name = "address_postal_code", EmitDefaultValue = false)]
        public string AddressPostalCode { get; set; }

        /// <summary>
        /// Client city.
        /// </summary>
        /// <value>Client city.</value>
        [DataMember(Name = "address_city", EmitDefaultValue = false)]
        public string AddressCity { get; set; }

        /// <summary>
        /// Client province.
        /// </summary>
        /// <value>Client province.</value>
        [DataMember(Name = "address_province", EmitDefaultValue = false)]
        public string AddressProvince { get; set; }

        /// <summary>
        /// Client address extra info.
        /// </summary>
        /// <value>Client address extra info.</value>
        [DataMember(Name = "address_extra", EmitDefaultValue = false)]
        public string AddressExtra { get; set; }

        /// <summary>
        /// Client country
        /// </summary>
        /// <value>Client country</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Client email.
        /// </summary>
        /// <value>Client email.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Client certified email.
        /// </summary>
        /// <value>Client certified email.</value>
        [DataMember(Name = "certified_email", EmitDefaultValue = false)]
        public string CertifiedEmail { get; set; }

        /// <summary>
        /// Client phone.
        /// </summary>
        /// <value>Client phone.</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Client fax.
        /// </summary>
        /// <value>Client fax.</value>
        [DataMember(Name = "fax", EmitDefaultValue = false)]
        public string Fax { get; set; }

        /// <summary>
        /// Extra notes.
        /// </summary>
        /// <value>Extra notes.</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets DefaultVat
        /// </summary>
        [DataMember(Name = "default_vat", EmitDefaultValue = true)]
        public VatType DefaultVat { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPaymentTerms
        /// </summary>
        [DataMember(Name = "default_payment_terms", EmitDefaultValue = false)]
        public int DefaultPaymentTerms { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPaymentMethod
        /// </summary>
        [DataMember(Name = "default_payment_method", EmitDefaultValue = false)]
        public PaymentMethod DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Client bank name.
        /// </summary>
        /// <value>Client bank name.</value>
        [DataMember(Name = "bank_name", EmitDefaultValue = false)]
        public string BankName { get; set; }

        /// <summary>
        /// Client iban.
        /// </summary>
        /// <value>Client iban.</value>
        [DataMember(Name = "bank_iban", EmitDefaultValue = false)]
        public string BankIban { get; set; }

        /// <summary>
        /// Client bank swift code.
        /// </summary>
        /// <value>Client bank swift code.</value>
        [DataMember(Name = "bank_swift_code", EmitDefaultValue = false)]
        public string BankSwiftCode { get; set; }

        /// <summary>
        /// Client shipping address.
        /// </summary>
        /// <value>Client shipping address.</value>
        [DataMember(Name = "shipping_address", EmitDefaultValue = false)]
        public string ShippingAddress { get; set; }

        /// <summary>
        /// Use e-invoices for this entity
        /// </summary>
        /// <value>Use e-invoices for this entity</value>
        [DataMember(Name = "e_invoice", EmitDefaultValue = true)]
        public bool EInvoice { get; set; }

        /// <summary>
        /// E-invoice code
        /// </summary>
        /// <value>E-invoice code</value>
        [DataMember(Name = "ei_code", EmitDefaultValue = false)]
        public string EiCode { get; set; }

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
            sb.Append("class ModelClient {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  ContactPerson: ").Append(ContactPerson).Append("\n");
            sb.Append("  VatNumber: ").Append(VatNumber).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  AddressStreet: ").Append(AddressStreet).Append("\n");
            sb.Append("  AddressPostalCode: ").Append(AddressPostalCode).Append("\n");
            sb.Append("  AddressCity: ").Append(AddressCity).Append("\n");
            sb.Append("  AddressProvince: ").Append(AddressProvince).Append("\n");
            sb.Append("  AddressExtra: ").Append(AddressExtra).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  CertifiedEmail: ").Append(CertifiedEmail).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  DefaultVat: ").Append(DefaultVat).Append("\n");
            sb.Append("  DefaultPaymentTerms: ").Append(DefaultPaymentTerms).Append("\n");
            sb.Append("  DefaultPaymentTermsType: ").Append(DefaultPaymentTermsType).Append("\n");
            sb.Append("  DefaultPaymentMethod: ").Append(DefaultPaymentMethod).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  BankIban: ").Append(BankIban).Append("\n");
            sb.Append("  BankSwiftCode: ").Append(BankSwiftCode).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  EInvoice: ").Append(EInvoice).Append("\n");
            sb.Append("  EiCode: ").Append(EiCode).Append("\n");
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
            return this.Equals(input as ModelClient);
        }

        /// <summary>
        /// Returns true if ModelClient instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelClient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelClient input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.ContactPerson == input.ContactPerson ||
                    (this.ContactPerson != null &&
                    this.ContactPerson.Equals(input.ContactPerson))
                ) && 
                (
                    this.VatNumber == input.VatNumber ||
                    (this.VatNumber != null &&
                    this.VatNumber.Equals(input.VatNumber))
                ) && 
                (
                    this.TaxCode == input.TaxCode ||
                    (this.TaxCode != null &&
                    this.TaxCode.Equals(input.TaxCode))
                ) && 
                (
                    this.AddressStreet == input.AddressStreet ||
                    (this.AddressStreet != null &&
                    this.AddressStreet.Equals(input.AddressStreet))
                ) && 
                (
                    this.AddressPostalCode == input.AddressPostalCode ||
                    (this.AddressPostalCode != null &&
                    this.AddressPostalCode.Equals(input.AddressPostalCode))
                ) && 
                (
                    this.AddressCity == input.AddressCity ||
                    (this.AddressCity != null &&
                    this.AddressCity.Equals(input.AddressCity))
                ) && 
                (
                    this.AddressProvince == input.AddressProvince ||
                    (this.AddressProvince != null &&
                    this.AddressProvince.Equals(input.AddressProvince))
                ) && 
                (
                    this.AddressExtra == input.AddressExtra ||
                    (this.AddressExtra != null &&
                    this.AddressExtra.Equals(input.AddressExtra))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.CertifiedEmail == input.CertifiedEmail ||
                    (this.CertifiedEmail != null &&
                    this.CertifiedEmail.Equals(input.CertifiedEmail))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.DefaultVat == input.DefaultVat ||
                    (this.DefaultVat != null &&
                    this.DefaultVat.Equals(input.DefaultVat))
                ) && 
                (
                    this.DefaultPaymentTerms == input.DefaultPaymentTerms ||
                    this.DefaultPaymentTerms.Equals(input.DefaultPaymentTerms)
                ) && 
                (
                    this.DefaultPaymentTermsType == input.DefaultPaymentTermsType ||
                    this.DefaultPaymentTermsType.Equals(input.DefaultPaymentTermsType)
                ) && 
                (
                    this.DefaultPaymentMethod == input.DefaultPaymentMethod ||
                    (this.DefaultPaymentMethod != null &&
                    this.DefaultPaymentMethod.Equals(input.DefaultPaymentMethod))
                ) && 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.BankIban == input.BankIban ||
                    (this.BankIban != null &&
                    this.BankIban.Equals(input.BankIban))
                ) && 
                (
                    this.BankSwiftCode == input.BankSwiftCode ||
                    (this.BankSwiftCode != null &&
                    this.BankSwiftCode.Equals(input.BankSwiftCode))
                ) && 
                (
                    this.ShippingAddress == input.ShippingAddress ||
                    (this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(input.ShippingAddress))
                ) && 
                (
                    this.EInvoice == input.EInvoice ||
                    this.EInvoice.Equals(input.EInvoice)
                ) && 
                (
                    this.EiCode == input.EiCode ||
                    (this.EiCode != null &&
                    this.EiCode.Equals(input.EiCode))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.ContactPerson != null)
                    hashCode = hashCode * 59 + this.ContactPerson.GetHashCode();
                if (this.VatNumber != null)
                    hashCode = hashCode * 59 + this.VatNumber.GetHashCode();
                if (this.TaxCode != null)
                    hashCode = hashCode * 59 + this.TaxCode.GetHashCode();
                if (this.AddressStreet != null)
                    hashCode = hashCode * 59 + this.AddressStreet.GetHashCode();
                if (this.AddressPostalCode != null)
                    hashCode = hashCode * 59 + this.AddressPostalCode.GetHashCode();
                if (this.AddressCity != null)
                    hashCode = hashCode * 59 + this.AddressCity.GetHashCode();
                if (this.AddressProvince != null)
                    hashCode = hashCode * 59 + this.AddressProvince.GetHashCode();
                if (this.AddressExtra != null)
                    hashCode = hashCode * 59 + this.AddressExtra.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.CertifiedEmail != null)
                    hashCode = hashCode * 59 + this.CertifiedEmail.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.DefaultVat != null)
                    hashCode = hashCode * 59 + this.DefaultVat.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultPaymentTerms.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultPaymentTermsType.GetHashCode();
                if (this.DefaultPaymentMethod != null)
                    hashCode = hashCode * 59 + this.DefaultPaymentMethod.GetHashCode();
                if (this.BankName != null)
                    hashCode = hashCode * 59 + this.BankName.GetHashCode();
                if (this.BankIban != null)
                    hashCode = hashCode * 59 + this.BankIban.GetHashCode();
                if (this.BankSwiftCode != null)
                    hashCode = hashCode * 59 + this.BankSwiftCode.GetHashCode();
                if (this.ShippingAddress != null)
                    hashCode = hashCode * 59 + this.ShippingAddress.GetHashCode();
                hashCode = hashCode * 59 + this.EInvoice.GetHashCode();
                if (this.EiCode != null)
                    hashCode = hashCode * 59 + this.EiCode.GetHashCode();
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