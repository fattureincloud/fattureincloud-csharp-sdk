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
    ///  Class for testing GetIssuedDocumentPreCreateInfoResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetIssuedDocumentPreCreateInfoResponseTests : IDisposable
    {
        private GetIssuedDocumentPreCreateInfoResponse instance;

        public GetIssuedDocumentPreCreateInfoResponseTests()
        {
            var body = "{ 'data': { 'numerations': { '2018': { 'AB123': 2 }, '2019': { '123': 0 }, '2020': { 'ABC': 2 }, '2021': { 'rec123': 2 } }, 'dn_numerations': { '2017': { '': 1000 }, '2018': { '': 112 }, '2019': { '': 526 }, '2020': { '': 11 }, '2021': { '': 110 } }, 'default_values': { 'template': { 'id': 111, 'type': 'standard', 'name': 'Light Smoke' }, 'dn_template': { 'id': 222, 'type': 'delivery_note', 'name': 'DDT 1' }, 'ai_template': { 'id': 333, 'type': 'accompanying_invoice', 'name': 'FT Accompagnatoria 1' }, 'notes': '', 'rivalsa': 0, 'cassa': 0, 'withholding_tax': 0, 'withholding_tax_taxable': 100, 'other_withholding_tax': 0, 'use_gross_prices': false } } }";
            instance = JsonConvert.DeserializeObject<GetIssuedDocumentPreCreateInfoResponse>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetIssuedDocumentPreCreateInfoResponse
        /// </summary>
        [Fact]
        public void GetIssuedDocumentPreCreateInfoResponseInstanceTest()
        {
            Assert.IsType<GetIssuedDocumentPreCreateInfoResponse>(instance);
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<IssuedDocumentPreCreateInfo>(instance.Data);
        }

    }

}
