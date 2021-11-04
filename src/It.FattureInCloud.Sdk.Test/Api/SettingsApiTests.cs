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
    ///  Class for testing SettingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SettingsApiTests : IDisposable
    {
        private SettingsApi instance;

        public SettingsApiTests()
        {
            instance = new SettingsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsApi
            //Assert.IsType<SettingsApi>(instance);
        }

        /// <summary>
        /// Test CreatePaymentAccount
        /// </summary>
        [Fact]
        public void CreatePaymentAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //CreatePaymentAccountRequest createPaymentAccountRequest = null;
            //var response = instance.CreatePaymentAccount(companyId, createPaymentAccountRequest);
            //Assert.IsType<CreatePaymentAccountResponse>(response);
        }

        /// <summary>
        /// Test CreatePaymentMethod
        /// </summary>
        [Fact]
        public void CreatePaymentMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //CreatePaymentMethodRequest createPaymentMethodRequest = null;
            //var response = instance.CreatePaymentMethod(companyId, createPaymentMethodRequest);
            //Assert.IsType<CreatePaymentMethodResponse>(response);
        }

        /// <summary>
        /// Test DeletePaymentAccount
        /// </summary>
        [Fact]
        public void DeletePaymentAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //string paymentAccountId = null;
            //instance.DeletePaymentAccount(companyId, paymentAccountId);
        }

        /// <summary>
        /// Test DeletePaymentMethod
        /// </summary>
        [Fact]
        public void DeletePaymentMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //int paymentMethodId = null;
            //instance.DeletePaymentMethod(companyId, paymentMethodId);
        }

        /// <summary>
        /// Test GetPaymentAccount
        /// </summary>
        [Fact]
        public void GetPaymentAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //string paymentAccountId = null;
            //string fields = null;
            //string fieldset = null;
            //Object body = null;
            //var response = instance.GetPaymentAccount(companyId, paymentAccountId, fields, fieldset, body);
            //Assert.IsType<GetPaymentAccountResponse>(response);
        }

        /// <summary>
        /// Test GetPaymentMethod
        /// </summary>
        [Fact]
        public void GetPaymentMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //int paymentMethodId = null;
            //string fields = null;
            //string fieldset = null;
            //var response = instance.GetPaymentMethod(companyId, paymentMethodId, fields, fieldset);
            //Assert.IsType<GetPaymentMethodResponse>(response);
        }

        /// <summary>
        /// Test ModifyPaymentAccount
        /// </summary>
        [Fact]
        public void ModifyPaymentAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //string paymentAccountId = null;
            //ModifyPaymentAccountRequest modifyPaymentAccountRequest = null;
            //var response = instance.ModifyPaymentAccount(companyId, paymentAccountId, modifyPaymentAccountRequest);
            //Assert.IsType<ModifyPaymentAccountResponse>(response);
        }

        /// <summary>
        /// Test ModifyPaymentMethod
        /// </summary>
        [Fact]
        public void ModifyPaymentMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //int paymentMethodId = null;
            //ModifyPaymentMethodRequest modifyPaymentMethodRequest = null;
            //var response = instance.ModifyPaymentMethod(companyId, paymentMethodId, modifyPaymentMethodRequest);
            //Assert.IsType<ModifyPaymentMethodResponse>(response);
        }
    }
}