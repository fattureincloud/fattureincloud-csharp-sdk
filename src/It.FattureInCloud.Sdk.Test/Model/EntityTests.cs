/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.3
 * Contact: info@fattureincloud.it
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Model;
using It.FattureInCloud.Sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace It.FattureInCloud.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing Entity
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EntityTests : IDisposable
    {
        private Entity instance;

        public EntityTests()
        {
            var body = "{ 'id': 16451, 'code': 'AE86', 'name': 'Avv. Maria Rossi', 'type': 'person', 'first_name': 'Maria', 'last_name': 'Rossi', 'contact_person': '', 'vat_number': 'IT12345640962', 'tax_code': 'BLTGNI5ABCDA794E', 'address_street': 'Via Roma, 1', 'address_postal_code': '20900', 'address_city': 'Milano', 'address_province': 'MI', 'address_extra': '', 'country': 'Italia', 'email': 'maria.rossi@example.com', 'certified_email': 'maria.rossi@pec.example.com', 'phone': '1234567890', 'fax': '', 'notes': '', 'created_at': '2021-04-29 08:53:07', 'updated_at': '2021-04-29 08:53:07', 'default_payment_terms': 1, 'default_payment_terms_type': 'standard', 'bank_name': 'Indesa', 'bank_iban': 'IT40P123456781000000123456', 'bank_swift_code': 'AK86PCT', 'shipping_address': 'Corso Magellano 4', 'e_invoice': true, 'ei_code': '111111', 'default_vat': { 'id': 54321, 'value': 45, 'description': '', 'is_disabled': false }, 'default_payment_method': { 'id': 386092, 'name': 'Credit card' } }";
            instance = JsonConvert.DeserializeObject<Entity>(body);

        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Entity
        /// </summary>
        [Fact]
        public void EntityInstanceTest()
        {
            Assert.IsType<Entity>(instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            Assert.IsType<int>(instance.Id);
        }
        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Fact]
        public void CodeTest()
        {
            Assert.IsType<string>(instance.Code);
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            Assert.IsType<string>(instance.Name);
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            Assert.IsType<EntityType>(instance.Type);
        }
        /// <summary>
        /// Test the property 'FirstName'
        /// </summary>
        [Fact]
        public void FirstNameTest()
        {
            Assert.IsType<string>(instance.FirstName);
        }
        /// <summary>
        /// Test the property 'LastName'
        /// </summary>
        [Fact]
        public void LastNameTest()
        {
            Assert.IsType<string>(instance.LastName);
        }
        /// <summary>
        /// Test the property 'ContactPerson'
        /// </summary>
        [Fact]
        public void ContactPersonTest()
        {
            Assert.IsType<Entity>(instance);
        }
        /// <summary>
        /// Test the property 'VatNumber'
        /// </summary>
        [Fact]
        public void VatNumberTest()
        {
            Assert.IsType<string>(instance.VatNumber);
        }
        /// <summary>
        /// Test the property 'TaxCode'
        /// </summary>
        [Fact]
        public void TaxCodeTest()
        {
            Assert.IsType<string>(instance.TaxCode);
        }
        /// <summary>
        /// Test the property 'AddressStreet'
        /// </summary>
        [Fact]
        public void AddressStreetTest()
        {
            Assert.IsType<Entity>(instance);
        }
        /// <summary>
        /// Test the property 'AddressPostalCode'
        /// </summary>
        [Fact]
        public void AddressPostalCodeTest()
        {
            Assert.IsType<string>(instance.AddressPostalCode);
        }
        /// <summary>
        /// Test the property 'AddressCity'
        /// </summary>
        [Fact]
        public void AddressCityTest()
        {
            Assert.IsType<Entity>(instance);
        }
        /// <summary>
        /// Test the property 'AddressProvince'
        /// </summary>
        [Fact]
        public void AddressProvinceTest()
        {
            Assert.IsType<string>(instance.AddressProvince);
        }
        /// <summary>
        /// Test the property 'AddressExtra'
        /// </summary>
        [Fact]
        public void AddressExtraTest()
        {
            Assert.IsType<string>(instance.AddressExtra);
        }
        /// <summary>
        /// Test the property 'Country'
        /// </summary>
        [Fact]
        public void CountryTest()
        {
            Assert.IsType<string>(instance.Country);
        }
        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Fact]
        public void EmailTest()
        {
            Assert.IsType<string>(instance.Email);
        }
        /// <summary>
        /// Test the property 'CertifiedEmail'
        /// </summary>
        [Fact]
        public void CertifiedEmailTest()
        {
            Assert.IsType<Entity>(instance);
        }
        /// <summary>
        /// Test the property 'Phone'
        /// </summary>
        [Fact]
        public void PhoneTest()
        {
            Assert.IsType<string>(instance.Phone);
        }
        /// <summary>
        /// Test the property 'Fax'
        /// </summary>
        [Fact]
        public void FaxTest()
        {
            Assert.IsType<string>(instance.Fax);
        }
        /// <summary>
        /// Test the property 'Notes'
        /// </summary>
        [Fact]
        public void NotesTest()
        {
            Assert.IsType<string>(instance.Notes);
        }
        /// <summary>
        /// Test the property 'DefaultVat'
        /// </summary>
        [Fact]
        public void DefaultVatTest()
        {
            Assert.IsType<VatType>(instance.DefaultVat);
        }
        /// <summary>
        /// Test the property 'DefaultPaymentTerms'
        /// </summary>
        [Fact]
        public void DefaultPaymentTermsTest()
        {
            Assert.IsType<int>(instance.DefaultPaymentTerms);
        }
        /// <summary>
        /// Test the property 'DefaultPaymentTermsType'
        /// </summary>
        [Fact]
        public void DefaultPaymentTermsTypeTest()
        {
            Assert.IsType<PaymentTermsType>(instance.DefaultPaymentTermsType);
        }
        /// <summary>
        /// Test the property 'DefaultPaymentMethod'
        /// </summary>
        [Fact]
        public void DefaultPaymentMethodTest()
        {
            Assert.IsType<PaymentMethod>(instance.DefaultPaymentMethod);
        }
        /// <summary>
        /// Test the property 'BankName'
        /// </summary>
        [Fact]
        public void BankNameTest()
        {
            Assert.IsType<string>(instance.BankName);
        }
        /// <summary>
        /// Test the property 'BankIban'
        /// </summary>
        [Fact]
        public void BankIbanTest()
        {
            Assert.IsType<string>(instance.BankIban);
        }
        /// <summary>
        /// Test the property 'BankSwiftCode'
        /// </summary>
        [Fact]
        public void BankSwiftCodeTest()
        {
            Assert.IsType<string>(instance.BankSwiftCode);
        }
        /// <summary>
        /// Test the property 'ShippingAddress'
        /// </summary>
        [Fact]
        public void ShippingAddressTest()
        {
            Assert.IsType<string>(instance.ShippingAddress);
        }
        /// <summary>
        /// Test the property 'EInvoice'
        /// </summary>
        [Fact]
        public void EInvoiceTest()
        {
            Assert.IsType<bool>(instance.EInvoice);
        }
        /// <summary>
        /// Test the property 'EiCode'
        /// </summary>
        [Fact]
        public void EiCodeTest()
        {
            Assert.IsType<string>(instance.EiCode);
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Fact]
        public void CreatedAtTest()
        {
            Assert.IsType<string>(instance.CreatedAt);
        }
        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Fact]
        public void UpdatedAtTest()
        {
            Assert.IsType<string>(instance.UpdatedAt);
        }

    }

}
