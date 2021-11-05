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
    ///  Class for testing ReceiptsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReceiptsApiTests : IDisposable
    {
        private ReceiptsApi instance;

        public ReceiptsApiTests()
        {
            instance = new ReceiptsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReceiptsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ReceiptsApi
            //Assert.IsType<ReceiptsApi>(instance);
        }

        /// <summary>
        /// Test CreateReceipt
        /// </summary>
        [Fact]
        public void CreateReceiptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //CreateReceiptRequest createReceiptRequest = null;
            //var response = instance.CreateReceipt(companyId, createReceiptRequest);
            //Assert.IsType<CreateReceiptResponse>(response);
        }

        /// <summary>
        /// Test DeleteReceipt
        /// </summary>
        [Fact]
        public void DeleteReceiptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //int documentId = null;
            //instance.DeleteReceipt(companyId, documentId);
        }

        /// <summary>
        /// Test GetReceipt
        /// </summary>
        [Fact]
        public void GetReceiptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //int documentId = null;
            //string fields = null;
            //string fieldset = null;
            //var response = instance.GetReceipt(companyId, documentId, fields, fieldset);
            //Assert.IsType<GetReceiptResponse>(response);
        }

        /// <summary>
        /// Test GetReceiptPreCreateInfo
        /// </summary>
        [Fact]
        public void GetReceiptPreCreateInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //var response = instance.GetReceiptPreCreateInfo(companyId);
            //Assert.IsType<GetReceiptPreCreateInfoResponse>(response);
        }

        /// <summary>
        /// Test GetReceiptsMonthlyTotals
        /// </summary>
        [Fact]
        public void GetReceiptsMonthlyTotalsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //string type = null;
            //string year = null;
            //var response = instance.GetReceiptsMonthlyTotals(companyId, type, year);
            //Assert.IsType<GetReceiptsMonthlyTotalsResponse>(response);
        }

        /// <summary>
        /// Test ListReceipts
        /// </summary>
        [Fact]
        public void ListReceiptsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //string fields = null;
            //string fieldset = null;
            //int? page = null;
            //int? perPage = null;
            //string sort = null;
            //var response = instance.ListReceipts(companyId, fields, fieldset, page, perPage, sort);
            //Assert.IsType<ListReceiptsResponse>(response);
        }

        /// <summary>
        /// Test ModifyReceipt
        /// </summary>
        [Fact]
        public void ModifyReceiptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //int documentId = null;
            //ModifyReceiptRequest modifyReceiptRequest = null;
            //var response = instance.ModifyReceipt(companyId, documentId, modifyReceiptRequest);
            //Assert.IsType<ModifyReceiptResponse>(response);
        }
    }
}