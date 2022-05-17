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
using It.FattureInCloud.Sdk.Model;

namespace It.FattureInCloud.Sdk.Test.Model
{
    /// <summary>
    ///     Class for testing ModifyClientResponse
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class ModifyClientResponseTests : IDisposable
    {
        private readonly ModifyClientResponse instance;

        public ModifyClientResponseTests()
        {
            var body =
                "{ 'data': { 'code': 'AE86', 'name': 'Avv. Maria Rossi', 'type': 'person', 'first_name': 'Maria', 'last_name': 'Rossi', 'contact_person': '', 'vat_number': 'IT12345640962', 'tax_code': 'BLTGNI5ABCDA794E', 'address_street': 'Via Roma, 1', 'address_postal_code': '20900', 'address_city': 'Milano', 'address_province': 'MI', 'address_extra': '', 'country': 'Italia', 'email': 'maria.rossi@example.com', 'certified_email': 'maria.rossi@pec.example.com', 'phone': '1234567890', 'fax': '', 'notes': '', 'default_payment_terms': 1, 'default_payment_terms_type': 'standard', 'bank_name': 'Indesa', 'bank_iban': 'IT40P123456781000000123456', 'bank_swift_code': 'AK86PCT', 'shipping_address': 'Corso Magellano 4', 'e_invoice': true, 'ei_code': '111111', 'default_vat': { 'id': 54321, 'value': 45, 'description': '', 'is_disabled': false } } }";
            instance = JsonConvert.DeserializeObject<ModifyClientResponse>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of ModifyClientResponse
        /// </summary>
        [Fact]
        public void ModifyClientResponseInstanceTest()
        {
            Assert.IsType<ModifyClientResponse>(instance);
        }


        /// <summary>
        ///     Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<ModelClient>(instance.Data);
        }
    }
}