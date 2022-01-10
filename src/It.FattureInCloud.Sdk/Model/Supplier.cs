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
    /// Supplier
    /// </summary>
    [DataContract(Name = "Supplier")]
    public partial class Supplier : IEquatable<Supplier>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public SupplierType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Supplier" /> class.
        /// </summary>
        /// <param name="id">Unique identifier.</param>
        /// <param name="code">Supplier code..</param>
        /// <param name="name">Supplier name..</param>
        /// <param name="type">type.</param>
        /// <param name="firstName">Supplier first name..</param>
        /// <param name="lastName">Supplier last name..</param>
        /// <param name="contactPerson">contactPerson.</param>
        /// <param name="vatNumber">Supplier vat number..</param>
        /// <param name="taxCode">Supplier tax code..</param>
        /// <param name="addressStreet">Supplier street address..</param>
        /// <param name="addressPostalCode">Supplier postal code..</param>
        /// <param name="addressCity">Supplier city..</param>
        /// <param name="addressProvince">Supplier province..</param>
        /// <param name="addressExtra">Supplier address extra info..</param>
        /// <param name="country">Supplier country. (default to &quot;Italia&quot;).</param>
        /// <param name="email">Supplier email..</param>
        /// <param name="certifiedEmail">Supplier certified email..</param>
        /// <param name="phone">Supplier phone..</param>
        /// <param name="fax">Supplier fax..</param>
        /// <param name="notes">Supplier extra notes..</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public Supplier(int id = default(int), string code = default(string), string name = default(string), SupplierType? type = default(SupplierType?), string firstName = default(string), string lastName = default(string), string contactPerson = default(string), string vatNumber = default(string), string taxCode = default(string), string addressStreet = default(string), string addressPostalCode = default(string), string addressCity = default(string), string addressProvince = default(string), string addressExtra = default(string), string country = "Italia", string email = default(string), string certifiedEmail = default(string), string phone = default(string), string fax = default(string), string notes = default(string), string createdAt = default(string), string updatedAt = default(string))
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
        /// Supplier code.
        /// </summary>
        /// <value>Supplier code.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Supplier name.
        /// </summary>
        /// <value>Supplier name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Supplier first name.
        /// </summary>
        /// <value>Supplier first name.</value>
        [DataMember(Name = "first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Supplier last name.
        /// </summary>
        /// <value>Supplier last name.</value>
        [DataMember(Name = "last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets ContactPerson
        /// </summary>
        [DataMember(Name = "contact_person", EmitDefaultValue = false)]
        public string ContactPerson { get; set; }

        /// <summary>
        /// Supplier vat number.
        /// </summary>
        /// <value>Supplier vat number.</value>
        [DataMember(Name = "vat_number", EmitDefaultValue = false)]
        public string VatNumber { get; set; }

        /// <summary>
        /// Supplier tax code.
        /// </summary>
        /// <value>Supplier tax code.</value>
        [DataMember(Name = "tax_code", EmitDefaultValue = false)]
        public string TaxCode { get; set; }

        /// <summary>
        /// Supplier street address.
        /// </summary>
        /// <value>Supplier street address.</value>
        [DataMember(Name = "address_street", EmitDefaultValue = false)]
        public string AddressStreet { get; set; }

        /// <summary>
        /// Supplier postal code.
        /// </summary>
        /// <value>Supplier postal code.</value>
        [DataMember(Name = "address_postal_code", EmitDefaultValue = false)]
        public string AddressPostalCode { get; set; }

        /// <summary>
        /// Supplier city.
        /// </summary>
        /// <value>Supplier city.</value>
        [DataMember(Name = "address_city", EmitDefaultValue = false)]
        public string AddressCity { get; set; }

        /// <summary>
        /// Supplier province.
        /// </summary>
        /// <value>Supplier province.</value>
        [DataMember(Name = "address_province", EmitDefaultValue = false)]
        public string AddressProvince { get; set; }

        /// <summary>
        /// Supplier address extra info.
        /// </summary>
        /// <value>Supplier address extra info.</value>
        [DataMember(Name = "address_extra", EmitDefaultValue = false)]
        public string AddressExtra { get; set; }

        /// <summary>
        /// Supplier country.
        /// </summary>
        /// <value>Supplier country.</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Supplier email.
        /// </summary>
        /// <value>Supplier email.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Supplier certified email.
        /// </summary>
        /// <value>Supplier certified email.</value>
        [DataMember(Name = "certified_email", EmitDefaultValue = false)]
        public string CertifiedEmail { get; set; }

        /// <summary>
        /// Supplier phone.
        /// </summary>
        /// <value>Supplier phone.</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Supplier fax.
        /// </summary>
        /// <value>Supplier fax.</value>
        [DataMember(Name = "fax", EmitDefaultValue = false)]
        public string Fax { get; set; }

        /// <summary>
        /// Supplier extra notes.
        /// </summary>
        /// <value>Supplier extra notes.</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

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
            sb.Append("class Supplier {\n");
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
            return this.Equals(input as Supplier);
        }

        /// <summary>
        /// Returns true if Supplier instances are equal
        /// </summary>
        /// <param name="input">Instance of Supplier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Supplier input)
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
