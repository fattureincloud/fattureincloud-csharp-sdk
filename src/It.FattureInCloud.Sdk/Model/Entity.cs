/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.11
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
    /// Entity
    /// </summary>
    [DataContract(Name = "Entity")]
    public partial class Entity : IEquatable<Entity>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public EntityType? Type { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPaymentTermsType
        /// </summary>
        [DataMember(Name = "default_payment_terms_type", EmitDefaultValue = false)]
        public DefaultPaymentTermsType? DefaultPaymentTermsType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" /> class.
        /// </summary>
        /// <param name="id">Unique identifier.</param>
        /// <param name="code">Code..</param>
        /// <param name="name">Name.</param>
        /// <param name="type">type.</param>
        /// <param name="firstName">First name..</param>
        /// <param name="lastName">Last name..</param>
        /// <param name="contactPerson">contactPerson.</param>
        /// <param name="vatNumber">Vat number.</param>
        /// <param name="taxCode">Tax code..</param>
        /// <param name="addressStreet">Street address..</param>
        /// <param name="addressPostalCode">Postal code..</param>
        /// <param name="addressCity">City..</param>
        /// <param name="addressProvince">Province..</param>
        /// <param name="addressExtra">Address extra info..</param>
        /// <param name="country">Country.</param>
        /// <param name="email">Email..</param>
        /// <param name="certifiedEmail">Certified email..</param>
        /// <param name="phone">Phone..</param>
        /// <param name="fax">Fax..</param>
        /// <param name="notes">Extra notes..</param>
        /// <param name="defaultVat">defaultVat.</param>
        /// <param name="defaultPaymentTerms">[Only for client] Default payment terms..</param>
        /// <param name="defaultPaymentTermsType">defaultPaymentTermsType.</param>
        /// <param name="defaultPaymentMethod">defaultPaymentMethod.</param>
        /// <param name="bankName">[Only for client] Bank name..</param>
        /// <param name="bankIban">[Only for client] Iban..</param>
        /// <param name="bankSwiftCode">[Only for client] Bank swift code..</param>
        /// <param name="shippingAddress">[Only for client] Shipping address..</param>
        /// <param name="eInvoice">[Only for client] Use e-invoices..</param>
        /// <param name="eiCode">[Only for client] E-invoices code..</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public Entity(int? id = default(int?), string code = default(string), string name = default(string), EntityType? type = default(EntityType?), string firstName = default(string), string lastName = default(string), string contactPerson = default(string), string vatNumber = default(string), string taxCode = default(string), string addressStreet = default(string), string addressPostalCode = default(string), string addressCity = default(string), string addressProvince = default(string), string addressExtra = default(string), string country = default(string), string email = default(string), string certifiedEmail = default(string), string phone = default(string), string fax = default(string), string notes = default(string), VatType defaultVat = default(VatType), int? defaultPaymentTerms = default(int?), DefaultPaymentTermsType? defaultPaymentTermsType = default(DefaultPaymentTermsType?), PaymentMethod defaultPaymentMethod = default(PaymentMethod), string bankName = default(string), string bankIban = default(string), string bankSwiftCode = default(string), string shippingAddress = default(string), bool? eInvoice = default(bool?), string eiCode = default(string), string createdAt = default(string), string updatedAt = default(string))
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
            this.Country = country;
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
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id { get; set; }

        /// <summary>
        /// Code.
        /// </summary>
        /// <value>Code.</value>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// First name.
        /// </summary>
        /// <value>First name.</value>
        [DataMember(Name = "first_name", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        /// <value>Last name.</value>
        [DataMember(Name = "last_name", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets ContactPerson
        /// </summary>
        [DataMember(Name = "contact_person", EmitDefaultValue = true)]
        public string ContactPerson { get; set; }

        /// <summary>
        /// Vat number
        /// </summary>
        /// <value>Vat number</value>
        [DataMember(Name = "vat_number", EmitDefaultValue = true)]
        public string VatNumber { get; set; }

        /// <summary>
        /// Tax code.
        /// </summary>
        /// <value>Tax code.</value>
        [DataMember(Name = "tax_code", EmitDefaultValue = true)]
        public string TaxCode { get; set; }

        /// <summary>
        /// Street address.
        /// </summary>
        /// <value>Street address.</value>
        [DataMember(Name = "address_street", EmitDefaultValue = true)]
        public string AddressStreet { get; set; }

        /// <summary>
        /// Postal code.
        /// </summary>
        /// <value>Postal code.</value>
        [DataMember(Name = "address_postal_code", EmitDefaultValue = true)]
        public string AddressPostalCode { get; set; }

        /// <summary>
        /// City.
        /// </summary>
        /// <value>City.</value>
        [DataMember(Name = "address_city", EmitDefaultValue = true)]
        public string AddressCity { get; set; }

        /// <summary>
        /// Province.
        /// </summary>
        /// <value>Province.</value>
        [DataMember(Name = "address_province", EmitDefaultValue = true)]
        public string AddressProvince { get; set; }

        /// <summary>
        /// Address extra info.
        /// </summary>
        /// <value>Address extra info.</value>
        [DataMember(Name = "address_extra", EmitDefaultValue = true)]
        public string AddressExtra { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        /// <value>Country</value>
        [DataMember(Name = "country", EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        /// <value>Email.</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Certified email.
        /// </summary>
        /// <value>Certified email.</value>
        [DataMember(Name = "certified_email", EmitDefaultValue = true)]
        public string CertifiedEmail { get; set; }

        /// <summary>
        /// Phone.
        /// </summary>
        /// <value>Phone.</value>
        [DataMember(Name = "phone", EmitDefaultValue = true)]
        public string Phone { get; set; }

        /// <summary>
        /// Fax.
        /// </summary>
        /// <value>Fax.</value>
        [DataMember(Name = "fax", EmitDefaultValue = true)]
        public string Fax { get; set; }

        /// <summary>
        /// Extra notes.
        /// </summary>
        /// <value>Extra notes.</value>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets DefaultVat
        /// </summary>
        [DataMember(Name = "default_vat", EmitDefaultValue = true)]
        public VatType DefaultVat { get; set; }

        /// <summary>
        /// [Only for client] Default payment terms.
        /// </summary>
        /// <value>[Only for client] Default payment terms.</value>
        [DataMember(Name = "default_payment_terms", EmitDefaultValue = true)]
        public int? DefaultPaymentTerms { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPaymentMethod
        /// </summary>
        [DataMember(Name = "default_payment_method", EmitDefaultValue = false)]
        public PaymentMethod DefaultPaymentMethod { get; set; }

        /// <summary>
        /// [Only for client] Bank name.
        /// </summary>
        /// <value>[Only for client] Bank name.</value>
        [DataMember(Name = "bank_name", EmitDefaultValue = true)]
        public string BankName { get; set; }

        /// <summary>
        /// [Only for client] Iban.
        /// </summary>
        /// <value>[Only for client] Iban.</value>
        [DataMember(Name = "bank_iban", EmitDefaultValue = true)]
        public string BankIban { get; set; }

        /// <summary>
        /// [Only for client] Bank swift code.
        /// </summary>
        /// <value>[Only for client] Bank swift code.</value>
        [DataMember(Name = "bank_swift_code", EmitDefaultValue = true)]
        public string BankSwiftCode { get; set; }

        /// <summary>
        /// [Only for client] Shipping address.
        /// </summary>
        /// <value>[Only for client] Shipping address.</value>
        [DataMember(Name = "shipping_address", EmitDefaultValue = true)]
        public string ShippingAddress { get; set; }

        /// <summary>
        /// [Only for client] Use e-invoices.
        /// </summary>
        /// <value>[Only for client] Use e-invoices.</value>
        [DataMember(Name = "e_invoice", EmitDefaultValue = true)]
        public bool? EInvoice { get; set; }

        /// <summary>
        /// [Only for client] E-invoices code.
        /// </summary>
        /// <value>[Only for client] E-invoices code.</value>
        [DataMember(Name = "ei_code", EmitDefaultValue = true)]
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
            StringBuilder sb = new StringBuilder();
            sb.Append("class Entity {\n");
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
            return this.Equals(input as Entity);
        }

        /// <summary>
        /// Returns true if Entity instances are equal
        /// </summary>
        /// <param name="input">Instance of Entity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Entity input)
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
                    (this.DefaultPaymentTerms != null &&
                    this.DefaultPaymentTerms.Equals(input.DefaultPaymentTerms))
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
                    (this.EInvoice != null &&
                    this.EInvoice.Equals(input.EInvoice))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.ContactPerson != null)
                {
                    hashCode = (hashCode * 59) + this.ContactPerson.GetHashCode();
                }
                if (this.VatNumber != null)
                {
                    hashCode = (hashCode * 59) + this.VatNumber.GetHashCode();
                }
                if (this.TaxCode != null)
                {
                    hashCode = (hashCode * 59) + this.TaxCode.GetHashCode();
                }
                if (this.AddressStreet != null)
                {
                    hashCode = (hashCode * 59) + this.AddressStreet.GetHashCode();
                }
                if (this.AddressPostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.AddressPostalCode.GetHashCode();
                }
                if (this.AddressCity != null)
                {
                    hashCode = (hashCode * 59) + this.AddressCity.GetHashCode();
                }
                if (this.AddressProvince != null)
                {
                    hashCode = (hashCode * 59) + this.AddressProvince.GetHashCode();
                }
                if (this.AddressExtra != null)
                {
                    hashCode = (hashCode * 59) + this.AddressExtra.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.CertifiedEmail != null)
                {
                    hashCode = (hashCode * 59) + this.CertifiedEmail.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.Fax != null)
                {
                    hashCode = (hashCode * 59) + this.Fax.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.DefaultVat != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultVat.GetHashCode();
                }
                if (this.DefaultPaymentTerms != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultPaymentTerms.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DefaultPaymentTermsType.GetHashCode();
                if (this.DefaultPaymentMethod != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultPaymentMethod.GetHashCode();
                }
                if (this.BankName != null)
                {
                    hashCode = (hashCode * 59) + this.BankName.GetHashCode();
                }
                if (this.BankIban != null)
                {
                    hashCode = (hashCode * 59) + this.BankIban.GetHashCode();
                }
                if (this.BankSwiftCode != null)
                {
                    hashCode = (hashCode * 59) + this.BankSwiftCode.GetHashCode();
                }
                if (this.ShippingAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ShippingAddress.GetHashCode();
                }
                if (this.EInvoice != null)
                {
                    hashCode = (hashCode * 59) + this.EInvoice.GetHashCode();
                }
                if (this.EiCode != null)
                {
                    hashCode = (hashCode * 59) + this.EiCode.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
