/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.31
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
        public SupplierType? Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                _flagType = true;
            }
        }
        private SupplierType? _Type;
        private bool _flagType;

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return _flagType;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Supplier" /> class.
        /// </summary>
        /// <param name="id">Supplier id.</param>
        /// <param name="code">Supplier code.</param>
        /// <param name="name">Supplier name.</param>
        /// <param name="type">type.</param>
        /// <param name="firstName">Supplier first name.</param>
        /// <param name="lastName">Supplier last name.</param>
        /// <param name="contactPerson">Supplier contact person.</param>
        /// <param name="vatNumber">Supplier vat number.</param>
        /// <param name="taxCode">Supplier tax code.</param>
        /// <param name="addressStreet">Supplier street address.</param>
        /// <param name="addressPostalCode">Supplier postal code.</param>
        /// <param name="addressCity">Supplier city.</param>
        /// <param name="addressProvince">Supplier province.</param>
        /// <param name="addressExtra">Supplier address extra info.</param>
        /// <param name="country">Supplier country.</param>
        /// <param name="countryIso">Supplier country iso code.</param>
        /// <param name="email">Supplier email.</param>
        /// <param name="certifiedEmail">Supplier certified email.</param>
        /// <param name="phone">Supplier phone.</param>
        /// <param name="fax">Supplier fax.</param>
        /// <param name="notes">Supplier extra notes.</param>
        /// <param name="bankIban">Supplier bank IBAN.</param>
        /// <param name="createdAt">Supplier creation date.</param>
        /// <param name="updatedAt">Supplier last update date.</param>
        public Supplier(int? id = default(int?), string code = default(string), string name = default(string), SupplierType? type = default(SupplierType?), string firstName = default(string), string lastName = default(string), string contactPerson = default(string), string vatNumber = default(string), string taxCode = default(string), string addressStreet = default(string), string addressPostalCode = default(string), string addressCity = default(string), string addressProvince = default(string), string addressExtra = default(string), string country = default(string), string countryIso = default(string), string email = default(string), string certifiedEmail = default(string), string phone = default(string), string fax = default(string), string notes = default(string), string bankIban = default(string), string createdAt = default(string), string updatedAt = default(string))
        {
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._Code = code;
            if (this.Code != null)
            {
                this._flagCode = true;
            }
            this._Name = name;
            if (this.Name != null)
            {
                this._flagName = true;
            }
            this._Type = type;
            if (this.Type != null)
            {
                this._flagType = true;
            }
            this._FirstName = firstName;
            if (this.FirstName != null)
            {
                this._flagFirstName = true;
            }
            this._LastName = lastName;
            if (this.LastName != null)
            {
                this._flagLastName = true;
            }
            this._ContactPerson = contactPerson;
            if (this.ContactPerson != null)
            {
                this._flagContactPerson = true;
            }
            this._VatNumber = vatNumber;
            if (this.VatNumber != null)
            {
                this._flagVatNumber = true;
            }
            this._TaxCode = taxCode;
            if (this.TaxCode != null)
            {
                this._flagTaxCode = true;
            }
            this._AddressStreet = addressStreet;
            if (this.AddressStreet != null)
            {
                this._flagAddressStreet = true;
            }
            this._AddressPostalCode = addressPostalCode;
            if (this.AddressPostalCode != null)
            {
                this._flagAddressPostalCode = true;
            }
            this._AddressCity = addressCity;
            if (this.AddressCity != null)
            {
                this._flagAddressCity = true;
            }
            this._AddressProvince = addressProvince;
            if (this.AddressProvince != null)
            {
                this._flagAddressProvince = true;
            }
            this._AddressExtra = addressExtra;
            if (this.AddressExtra != null)
            {
                this._flagAddressExtra = true;
            }
            this._Country = country;
            if (this.Country != null)
            {
                this._flagCountry = true;
            }
            this._CountryIso = countryIso;
            if (this.CountryIso != null)
            {
                this._flagCountryIso = true;
            }
            this._Email = email;
            if (this.Email != null)
            {
                this._flagEmail = true;
            }
            this._CertifiedEmail = certifiedEmail;
            if (this.CertifiedEmail != null)
            {
                this._flagCertifiedEmail = true;
            }
            this._Phone = phone;
            if (this.Phone != null)
            {
                this._flagPhone = true;
            }
            this._Fax = fax;
            if (this.Fax != null)
            {
                this._flagFax = true;
            }
            this._Notes = notes;
            if (this.Notes != null)
            {
                this._flagNotes = true;
            }
            this._BankIban = bankIban;
            if (this.BankIban != null)
            {
                this._flagBankIban = true;
            }
            this._CreatedAt = createdAt;
            if (this.CreatedAt != null)
            {
                this._flagCreatedAt = true;
            }
            this._UpdatedAt = updatedAt;
            if (this.UpdatedAt != null)
            {
                this._flagUpdatedAt = true;
            }
        }

        /// <summary>
        /// Supplier id
        /// </summary>
        /// <value>Supplier id</value>
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
        /// Supplier code
        /// </summary>
        /// <value>Supplier code</value>
        /// <example>123</example>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code
        {
            get { return _Code; }
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
        /// Supplier name
        /// </summary>
        /// <value>Supplier name</value>
        /// <example>Rossi S.r.l.</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name
        {
            get { return _Name; }
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
        /// Supplier first name
        /// </summary>
        /// <value>Supplier first name</value>
        [DataMember(Name = "first_name", EmitDefaultValue = true)]
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                _FirstName = value;
                _flagFirstName = true;
            }
        }
        private string _FirstName;
        private bool _flagFirstName;

        /// <summary>
        /// Returns false as FirstName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFirstName()
        {
            return _flagFirstName;
        }
        /// <summary>
        /// Supplier last name
        /// </summary>
        /// <value>Supplier last name</value>
        [DataMember(Name = "last_name", EmitDefaultValue = true)]
        public string LastName
        {
            get { return _LastName; }
            set
            {
                _LastName = value;
                _flagLastName = true;
            }
        }
        private string _LastName;
        private bool _flagLastName;

        /// <summary>
        /// Returns false as LastName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastName()
        {
            return _flagLastName;
        }
        /// <summary>
        /// Supplier contact person
        /// </summary>
        /// <value>Supplier contact person</value>
        [DataMember(Name = "contact_person", EmitDefaultValue = true)]
        public string ContactPerson
        {
            get { return _ContactPerson; }
            set
            {
                _ContactPerson = value;
                _flagContactPerson = true;
            }
        }
        private string _ContactPerson;
        private bool _flagContactPerson;

        /// <summary>
        /// Returns false as ContactPerson should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContactPerson()
        {
            return _flagContactPerson;
        }
        /// <summary>
        /// Supplier vat number
        /// </summary>
        /// <value>Supplier vat number</value>
        /// <example>IT01234567890</example>
        [DataMember(Name = "vat_number", EmitDefaultValue = true)]
        public string VatNumber
        {
            get { return _VatNumber; }
            set
            {
                _VatNumber = value;
                _flagVatNumber = true;
            }
        }
        private string _VatNumber;
        private bool _flagVatNumber;

        /// <summary>
        /// Returns false as VatNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVatNumber()
        {
            return _flagVatNumber;
        }
        /// <summary>
        /// Supplier tax code
        /// </summary>
        /// <value>Supplier tax code</value>
        /// <example>RSSMRA44A12E890Q</example>
        [DataMember(Name = "tax_code", EmitDefaultValue = true)]
        public string TaxCode
        {
            get { return _TaxCode; }
            set
            {
                _TaxCode = value;
                _flagTaxCode = true;
            }
        }
        private string _TaxCode;
        private bool _flagTaxCode;

        /// <summary>
        /// Returns false as TaxCode should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTaxCode()
        {
            return _flagTaxCode;
        }
        /// <summary>
        /// Supplier street address
        /// </summary>
        /// <value>Supplier street address</value>
        /// <example>Via dei tigli, 12</example>
        [DataMember(Name = "address_street", EmitDefaultValue = true)]
        public string AddressStreet
        {
            get { return _AddressStreet; }
            set
            {
                _AddressStreet = value;
                _flagAddressStreet = true;
            }
        }
        private string _AddressStreet;
        private bool _flagAddressStreet;

        /// <summary>
        /// Returns false as AddressStreet should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAddressStreet()
        {
            return _flagAddressStreet;
        }
        /// <summary>
        /// Supplier postal code
        /// </summary>
        /// <value>Supplier postal code</value>
        /// <example>24010</example>
        [DataMember(Name = "address_postal_code", EmitDefaultValue = true)]
        public string AddressPostalCode
        {
            get { return _AddressPostalCode; }
            set
            {
                _AddressPostalCode = value;
                _flagAddressPostalCode = true;
            }
        }
        private string _AddressPostalCode;
        private bool _flagAddressPostalCode;

        /// <summary>
        /// Returns false as AddressPostalCode should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAddressPostalCode()
        {
            return _flagAddressPostalCode;
        }
        /// <summary>
        /// Supplier city
        /// </summary>
        /// <value>Supplier city</value>
        /// <example>Bergamo</example>
        [DataMember(Name = "address_city", EmitDefaultValue = true)]
        public string AddressCity
        {
            get { return _AddressCity; }
            set
            {
                _AddressCity = value;
                _flagAddressCity = true;
            }
        }
        private string _AddressCity;
        private bool _flagAddressCity;

        /// <summary>
        /// Returns false as AddressCity should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAddressCity()
        {
            return _flagAddressCity;
        }
        /// <summary>
        /// Supplier province
        /// </summary>
        /// <value>Supplier province</value>
        /// <example>BG</example>
        [DataMember(Name = "address_province", EmitDefaultValue = true)]
        public string AddressProvince
        {
            get { return _AddressProvince; }
            set
            {
                _AddressProvince = value;
                _flagAddressProvince = true;
            }
        }
        private string _AddressProvince;
        private bool _flagAddressProvince;

        /// <summary>
        /// Returns false as AddressProvince should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAddressProvince()
        {
            return _flagAddressProvince;
        }
        /// <summary>
        /// Supplier address extra info
        /// </summary>
        /// <value>Supplier address extra info</value>
        [DataMember(Name = "address_extra", EmitDefaultValue = true)]
        public string AddressExtra
        {
            get { return _AddressExtra; }
            set
            {
                _AddressExtra = value;
                _flagAddressExtra = true;
            }
        }
        private string _AddressExtra;
        private bool _flagAddressExtra;

        /// <summary>
        /// Returns false as AddressExtra should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAddressExtra()
        {
            return _flagAddressExtra;
        }
        /// <summary>
        /// Supplier country
        /// </summary>
        /// <value>Supplier country</value>
        /// <example>Italia</example>
        [DataMember(Name = "country", EmitDefaultValue = true)]
        public string Country
        {
            get { return _Country; }
            set
            {
                _Country = value;
                _flagCountry = true;
            }
        }
        private string _Country;
        private bool _flagCountry;

        /// <summary>
        /// Returns false as Country should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCountry()
        {
            return _flagCountry;
        }
        /// <summary>
        /// Supplier country iso code
        /// </summary>
        /// <value>Supplier country iso code</value>
        /// <example>Italia</example>
        [DataMember(Name = "country_iso", EmitDefaultValue = true)]
        public string CountryIso
        {
            get { return _CountryIso; }
            set
            {
                _CountryIso = value;
                _flagCountryIso = true;
            }
        }
        private string _CountryIso;
        private bool _flagCountryIso;

        /// <summary>
        /// Returns false as CountryIso should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCountryIso()
        {
            return _flagCountryIso;
        }
        /// <summary>
        /// Supplier email
        /// </summary>
        /// <value>Supplier email</value>
        /// <example>mario.rossi@example.it</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email
        {
            get { return _Email; }
            set
            {
                _Email = value;
                _flagEmail = true;
            }
        }
        private string _Email;
        private bool _flagEmail;

        /// <summary>
        /// Returns false as Email should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmail()
        {
            return _flagEmail;
        }
        /// <summary>
        /// Supplier certified email
        /// </summary>
        /// <value>Supplier certified email</value>
        /// <example>mario.rossi@pec.example.it</example>
        [DataMember(Name = "certified_email", EmitDefaultValue = true)]
        public string CertifiedEmail
        {
            get { return _CertifiedEmail; }
            set
            {
                _CertifiedEmail = value;
                _flagCertifiedEmail = true;
            }
        }
        private string _CertifiedEmail;
        private bool _flagCertifiedEmail;

        /// <summary>
        /// Returns false as CertifiedEmail should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCertifiedEmail()
        {
            return _flagCertifiedEmail;
        }
        /// <summary>
        /// Supplier phone
        /// </summary>
        /// <value>Supplier phone</value>
        [DataMember(Name = "phone", EmitDefaultValue = true)]
        public string Phone
        {
            get { return _Phone; }
            set
            {
                _Phone = value;
                _flagPhone = true;
            }
        }
        private string _Phone;
        private bool _flagPhone;

        /// <summary>
        /// Returns false as Phone should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePhone()
        {
            return _flagPhone;
        }
        /// <summary>
        /// Supplier fax
        /// </summary>
        /// <value>Supplier fax</value>
        [DataMember(Name = "fax", EmitDefaultValue = true)]
        public string Fax
        {
            get { return _Fax; }
            set
            {
                _Fax = value;
                _flagFax = true;
            }
        }
        private string _Fax;
        private bool _flagFax;

        /// <summary>
        /// Returns false as Fax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFax()
        {
            return _flagFax;
        }
        /// <summary>
        /// Supplier extra notes
        /// </summary>
        /// <value>Supplier extra notes</value>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes
        {
            get { return _Notes; }
            set
            {
                _Notes = value;
                _flagNotes = true;
            }
        }
        private string _Notes;
        private bool _flagNotes;

        /// <summary>
        /// Returns false as Notes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNotes()
        {
            return _flagNotes;
        }
        /// <summary>
        /// Supplier bank IBAN
        /// </summary>
        /// <value>Supplier bank IBAN</value>
        [DataMember(Name = "bank_iban", EmitDefaultValue = true)]
        public string BankIban
        {
            get { return _BankIban; }
            set
            {
                _BankIban = value;
                _flagBankIban = true;
            }
        }
        private string _BankIban;
        private bool _flagBankIban;

        /// <summary>
        /// Returns false as BankIban should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBankIban()
        {
            return _flagBankIban;
        }
        /// <summary>
        /// Supplier creation date
        /// </summary>
        /// <value>Supplier creation date</value>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public string CreatedAt
        {
            get { return _CreatedAt; }
            set
            {
                _CreatedAt = value;
                _flagCreatedAt = true;
            }
        }
        private string _CreatedAt;
        private bool _flagCreatedAt;

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return _flagCreatedAt;
        }
        /// <summary>
        /// Supplier last update date
        /// </summary>
        /// <value>Supplier last update date</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public string UpdatedAt
        {
            get { return _UpdatedAt; }
            set
            {
                _UpdatedAt = value;
                _flagUpdatedAt = true;
            }
        }
        private string _UpdatedAt;
        private bool _flagUpdatedAt;

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return _flagUpdatedAt;
        }
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
            sb.Append("  CountryIso: ").Append(CountryIso).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  CertifiedEmail: ").Append(CertifiedEmail).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  BankIban: ").Append(BankIban).Append("\n");
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
                    this.CountryIso == input.CountryIso ||
                    (this.CountryIso != null &&
                    this.CountryIso.Equals(input.CountryIso))
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
                    this.BankIban == input.BankIban ||
                    (this.BankIban != null &&
                    this.BankIban.Equals(input.BankIban))
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
                if (this.CountryIso != null)
                {
                    hashCode = (hashCode * 59) + this.CountryIso.GetHashCode();
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
                if (this.BankIban != null)
                {
                    hashCode = (hashCode * 59) + this.BankIban.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
