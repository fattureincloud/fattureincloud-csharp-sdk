/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol. For more information, please visit https://www.fattureincloud.it.
 *
 * The version of the OpenAPI document: 2.0.2
 * Contact: info@fattureincloud.it
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Api;
// uncomment below to import models
//using It.FattureInCloud.Sdk.Model;

namespace It.FattureInCloud.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing ClientsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ClientsApiTests : IDisposable
    {
        private ClientsApi instance;

        public ClientsApiTests()
        {
            instance = new ClientsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ClientsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ClientsApi
            //Assert.IsType<ClientsApi>(instance);
        }

        /// <summary>
        /// Test CreateClient
        /// </summary>
        [Fact]
        public void CreateClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //CreateClientRequest createClientRequest = null;
            //var response = instance.CreateClient(companyId, createClientRequest);
            //Assert.IsType<CreateClientResponse>(response);
        }

        /// <summary>
        /// Test DeleteClient
        /// </summary>
        [Fact]
        public void DeleteClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //int clientId = null;
            //instance.DeleteClient(companyId, clientId);
        }

        /// <summary>
        /// Test GetClient
        /// </summary>
        [Fact]
        public void GetClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //int clientId = null;
            //string fields = null;
            //string fieldset = null;
            //var response = instance.GetClient(companyId, clientId, fields, fieldset);
            //Assert.IsType<GetClientResponse>(response);
        }

        /// <summary>
        /// Test ListClients
        /// </summary>
        [Fact]
        public void ListClientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //string fields = null;
            //string fieldset = null;
            //string sort = null;
            //int? page = null;
            //int? perPage = null;
            //var response = instance.ListClients(companyId, fields, fieldset, sort, page, perPage);
            //Assert.IsType<ListClientsResponse>(response);
        }

        /// <summary>
        /// Test ModifyClient
        /// </summary>
        [Fact]
        public void ModifyClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //int clientId = null;
            //ModifyClientRequest modifyClientRequest = null;
            //var response = instance.ModifyClient(companyId, clientId, modifyClientRequest);
            //Assert.IsType<ModifyClientResponse>(response);
        }
    }
}
