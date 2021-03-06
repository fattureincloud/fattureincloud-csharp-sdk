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
    ///  Class for testing Supplier
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SupplierTests : IDisposable
    {
        private Supplier instance;

        public SupplierTests()
        {
            var body = "{'id':12345,'code':'AE86','name':'Mario Rossi S.R.L.','type':'company','first_name':'Mario','last_name':'Rossi','contact_person':'','vat_number':'111222333','tax_code':'111122233','address_street':'Corso Magellano, 46','address_postal_code':'20146','address_city':'Milano','address_province':'MI','address_extra':'','country':'Italia','email':'mario.rossi@example.com','certified_email':'mario.rossi@pec.example.com','phone':'1234567890','fax':'123456789','notes':'','created_at':'2021-15-08','updated_at':'2021-15-08'}";
            instance = JsonConvert.DeserializeObject<Supplier>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Supplier
        /// </summary>
        [Fact]
        public void SupplierInstanceTest()
        {
            Assert.IsType<Supplier>(instance);
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
            Assert.IsType<SupplierType>(instance.Type);
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
            Assert.IsType<string>(instance.ContactPerson);
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
            Assert.IsType<string>(instance.AddressStreet);
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
            Assert.IsType<string>(instance.AddressCity);
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
            Assert.IsType<string>(instance.CertifiedEmail);
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
