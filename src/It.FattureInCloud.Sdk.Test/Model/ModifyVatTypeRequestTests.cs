/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.8
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
    ///  Class for testing ModifyVatTypeRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ModifyVatTypeRequestTests : IDisposable
    {
        private ModifyVatTypeRequest instance;

        public ModifyVatTypeRequestTests()
        {
            var body = "{'data':{'id':0,'value':22,'description':'Non imponibile art. 123','notes':'IVA non imponibile ai sensi dell articolo 123, comma 2','e_invoice':true,'ei_type':2,'ei_description':'string','editable':true,'is_disabled':true}}";
            instance = JsonConvert.DeserializeObject<ModifyVatTypeRequest>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ModifyVatTypeRequest
        /// </summary>
        [Fact]
        public void ModifyVatTypeRequestInstanceTest()
        {
            Assert.IsType<ModifyVatTypeRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<VatType>(instance.Data);
        }

    }

}