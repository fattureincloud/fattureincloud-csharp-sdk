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
    ///  Class for testing UserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserApiTests : IDisposable
    {
        private UserApi instance;

        public UserApiTests()
        {
            instance = new UserApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UserApi
            //Assert.IsType<UserApi>(instance);
        }

        /// <summary>
        /// Test GetUserInfo
        /// </summary>
        [Fact]
        public void GetUserInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetUserInfo();
            //Assert.IsType<GetUserInfoResponse>(response);
        }

        /// <summary>
        /// Test ListUserCompanies
        /// </summary>
        [Fact]
        public void ListUserCompaniesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListUserCompanies();
            //Assert.IsType<ListUserCompaniesResponse>(response);
        }
    }
}