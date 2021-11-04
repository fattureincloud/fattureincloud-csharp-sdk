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
    ///  Class for testing CashbookApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CashbookApiTests : IDisposable
    {
        private CashbookApi instance;

        public CashbookApiTests()
        {
            instance = new CashbookApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CashbookApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CashbookApi
            //Assert.IsType<CashbookApi>(instance);
        }

        /// <summary>
        /// Test CreateCashbookEntry
        /// </summary>
        [Fact]
        public void CreateCashbookEntryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //CreateCashbookEntryRequest createCashbookEntryRequest = null;
            //var response = instance.CreateCashbookEntry(companyId, createCashbookEntryRequest);
            //Assert.IsType<CreateCashbookEntryResponse>(response);
        }

        /// <summary>
        /// Test DeleteCashbookEntry
        /// </summary>
        [Fact]
        public void DeleteCashbookEntryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //int documentId = null;
            //instance.DeleteCashbookEntry(companyId, documentId);
        }

        /// <summary>
        /// Test GetCashbookEntry
        /// </summary>
        [Fact]
        public void GetCashbookEntryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //int documentId = null;
            //string fields = null;
            //string fieldset = null;
            //var response = instance.GetCashbookEntry(companyId, documentId, fields, fieldset);
            //Assert.IsType<GetCashbookEntryResponse>(response);
        }

        /// <summary>
        /// Test ListCashbookEntries
        /// </summary>
        [Fact]
        public void ListCashbookEntriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //string dateFrom = null;
            //string dateTo = null;
            //int? year = null;
            //string type = null;
            //int? paymentAccountId = null;
            //var response = instance.ListCashbookEntries(companyId, dateFrom, dateTo, year, type, paymentAccountId);
            //Assert.IsType<ListCashbookEntriesResponse>(response);
        }

        /// <summary>
        /// Test ModifyCashbookEntry
        /// </summary>
        [Fact]
        public void ModifyCashbookEntryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //int documentId = null;
            //ModifyCashbookEntryRequest modifyCashbookEntryRequest = null;
            //var response = instance.ModifyCashbookEntry(companyId, documentId, modifyCashbookEntryRequest);
            //Assert.IsType<ModifyCashbookEntryResponse>(response);
        }
    }
}
