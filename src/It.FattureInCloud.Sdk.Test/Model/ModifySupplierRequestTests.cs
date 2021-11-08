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
    ///  Class for testing ModifySupplierRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ModifySupplierRequestTests : IDisposable
    {
        private ModifySupplierRequest instance;

        public ModifySupplierRequestTests()
        {
            var body = "{ 'data': { 'id': 12345, 'code': 'AE86', 'name': 'Mario Rossi S.R.L.', 'type': 'company', 'first_name': 'Mario', 'last_name': 'Rossi', 'contact_person': '', 'vat_number': '111222333', 'tax_code': '111122233', 'address_street': 'Corso Magellano, 46', 'address_postal_code': '20146', 'address_city': 'Milano', 'address_province': 'MI', 'address_extra': '', 'country': 'Italia', 'email': 'mario.rossi@example.com', 'certified_email': 'mario.rossi@pec.example.com', 'phone': '1234567890', 'fax': '123456789', 'notes': '' } }";
            instance = JsonConvert.DeserializeObject<ModifySupplierRequest>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ModifySupplierRequest
        /// </summary>
        [Fact]
        public void ModifySupplierRequestInstanceTest()
        {
            Assert.IsType<ModifySupplierRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<Supplier>(instance.Data);
        }

    }

}
