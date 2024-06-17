/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.1.0
 * Contact: info@fattureincloud.it
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace It.FattureInCloud.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICompaniesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Company Info
        /// </summary>
        /// <remarks>
        /// Gets the company detailed info.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetCompanyInfoResponse</returns>
        GetCompanyInfoResponse GetCompanyInfo(int companyId, int operationIndex = 0);

        /// <summary>
        /// Get Company Info
        /// </summary>
        /// <remarks>
        /// Gets the company detailed info.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetCompanyInfoResponse</returns>
        ApiResponse<GetCompanyInfoResponse> GetCompanyInfoWithHttpInfo(int companyId, int operationIndex = 0);
        /// <summary>
        /// Get Company Plan Usage
        /// </summary>
        /// <remarks>
        /// Gets the company limits usage.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="category">Category</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetCompanyPlanUsageResponse</returns>
        GetCompanyPlanUsageResponse GetCompanyPlanUsage(int companyId, string category, int operationIndex = 0);

        /// <summary>
        /// Get Company Plan Usage
        /// </summary>
        /// <remarks>
        /// Gets the company limits usage.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="category">Category</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetCompanyPlanUsageResponse</returns>
        ApiResponse<GetCompanyPlanUsageResponse> GetCompanyPlanUsageWithHttpInfo(int companyId, string category, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICompaniesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get Company Info
        /// </summary>
        /// <remarks>
        /// Gets the company detailed info.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetCompanyInfoResponse</returns>
        System.Threading.Tasks.Task<GetCompanyInfoResponse> GetCompanyInfoAsync(int companyId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Company Info
        /// </summary>
        /// <remarks>
        /// Gets the company detailed info.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetCompanyInfoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetCompanyInfoResponse>> GetCompanyInfoWithHttpInfoAsync(int companyId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get Company Plan Usage
        /// </summary>
        /// <remarks>
        /// Gets the company limits usage.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="category">Category</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetCompanyPlanUsageResponse</returns>
        System.Threading.Tasks.Task<GetCompanyPlanUsageResponse> GetCompanyPlanUsageAsync(int companyId, string category, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Company Plan Usage
        /// </summary>
        /// <remarks>
        /// Gets the company limits usage.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="category">Category</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetCompanyPlanUsageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetCompanyPlanUsageResponse>> GetCompanyPlanUsageWithHttpInfoAsync(int companyId, string category, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICompaniesApi : ICompaniesApiSync, ICompaniesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CompaniesApi : ICompaniesApi
    {
        private It.FattureInCloud.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompaniesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CompaniesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompaniesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CompaniesApi(string basePath)
        {
            this.Configuration = It.FattureInCloud.Sdk.Client.Configuration.MergeConfigurations(
                It.FattureInCloud.Sdk.Client.GlobalConfiguration.Instance,
                new It.FattureInCloud.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new It.FattureInCloud.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new It.FattureInCloud.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = It.FattureInCloud.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompaniesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CompaniesApi(It.FattureInCloud.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = It.FattureInCloud.Sdk.Client.Configuration.MergeConfigurations(
                It.FattureInCloud.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new It.FattureInCloud.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new It.FattureInCloud.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = It.FattureInCloud.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompaniesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CompaniesApi(It.FattureInCloud.Sdk.Client.ISynchronousClient client, It.FattureInCloud.Sdk.Client.IAsynchronousClient asyncClient, It.FattureInCloud.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = It.FattureInCloud.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public It.FattureInCloud.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public It.FattureInCloud.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public It.FattureInCloud.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public It.FattureInCloud.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get Company Info Gets the company detailed info.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetCompanyInfoResponse</returns>
        public GetCompanyInfoResponse GetCompanyInfo(int companyId, int operationIndex = 0)
        {
            It.FattureInCloud.Sdk.Client.ApiResponse<GetCompanyInfoResponse> localVarResponse = GetCompanyInfoWithHttpInfo(companyId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Company Info Gets the company detailed info.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetCompanyInfoResponse</returns>
        public It.FattureInCloud.Sdk.Client.ApiResponse<GetCompanyInfoResponse> GetCompanyInfoWithHttpInfo(int companyId, int operationIndex = 0)
        {
            It.FattureInCloud.Sdk.Client.RequestOptions localVarRequestOptions = new It.FattureInCloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("company_id", It.FattureInCloud.Sdk.Client.ClientUtils.ParameterToString(companyId)); // path parameter

            localVarRequestOptions.Operation = "CompaniesApi.GetCompanyInfo";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2AuthenticationCodeFlow) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<GetCompanyInfoResponse>("/c/{company_id}/company/info", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCompanyInfo", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Company Info Gets the company detailed info.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetCompanyInfoResponse</returns>
        public async System.Threading.Tasks.Task<GetCompanyInfoResponse> GetCompanyInfoAsync(int companyId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            It.FattureInCloud.Sdk.Client.ApiResponse<GetCompanyInfoResponse> localVarResponse = await GetCompanyInfoWithHttpInfoAsync(companyId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Company Info Gets the company detailed info.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetCompanyInfoResponse)</returns>
        public async System.Threading.Tasks.Task<It.FattureInCloud.Sdk.Client.ApiResponse<GetCompanyInfoResponse>> GetCompanyInfoWithHttpInfoAsync(int companyId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            It.FattureInCloud.Sdk.Client.RequestOptions localVarRequestOptions = new It.FattureInCloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("company_id", It.FattureInCloud.Sdk.Client.ClientUtils.ParameterToString(companyId)); // path parameter

            localVarRequestOptions.Operation = "CompaniesApi.GetCompanyInfo";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2AuthenticationCodeFlow) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<GetCompanyInfoResponse>("/c/{company_id}/company/info", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCompanyInfo", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Company Plan Usage Gets the company limits usage.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="category">Category</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetCompanyPlanUsageResponse</returns>
        public GetCompanyPlanUsageResponse GetCompanyPlanUsage(int companyId, string category, int operationIndex = 0)
        {
            It.FattureInCloud.Sdk.Client.ApiResponse<GetCompanyPlanUsageResponse> localVarResponse = GetCompanyPlanUsageWithHttpInfo(companyId, category);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Company Plan Usage Gets the company limits usage.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="category">Category</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetCompanyPlanUsageResponse</returns>
        public It.FattureInCloud.Sdk.Client.ApiResponse<GetCompanyPlanUsageResponse> GetCompanyPlanUsageWithHttpInfo(int companyId, string category, int operationIndex = 0)
        {
            // verify the required parameter 'category' is set
            if (category == null)
            {
                throw new It.FattureInCloud.Sdk.Client.ApiException(400, "Missing required parameter 'category' when calling CompaniesApi->GetCompanyPlanUsage");
            }

            It.FattureInCloud.Sdk.Client.RequestOptions localVarRequestOptions = new It.FattureInCloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("company_id", It.FattureInCloud.Sdk.Client.ClientUtils.ParameterToString(companyId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(It.FattureInCloud.Sdk.Client.ClientUtils.ParameterToMultiMap("", "category", category));

            localVarRequestOptions.Operation = "CompaniesApi.GetCompanyPlanUsage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2AuthenticationCodeFlow) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<GetCompanyPlanUsageResponse>("/c/{company_id}/company/plan_usage", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCompanyPlanUsage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Company Plan Usage Gets the company limits usage.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="category">Category</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetCompanyPlanUsageResponse</returns>
        public async System.Threading.Tasks.Task<GetCompanyPlanUsageResponse> GetCompanyPlanUsageAsync(int companyId, string category, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            It.FattureInCloud.Sdk.Client.ApiResponse<GetCompanyPlanUsageResponse> localVarResponse = await GetCompanyPlanUsageWithHttpInfoAsync(companyId, category, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Company Plan Usage Gets the company limits usage.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="category">Category</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetCompanyPlanUsageResponse)</returns>
        public async System.Threading.Tasks.Task<It.FattureInCloud.Sdk.Client.ApiResponse<GetCompanyPlanUsageResponse>> GetCompanyPlanUsageWithHttpInfoAsync(int companyId, string category, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'category' is set
            if (category == null)
            {
                throw new It.FattureInCloud.Sdk.Client.ApiException(400, "Missing required parameter 'category' when calling CompaniesApi->GetCompanyPlanUsage");
            }


            It.FattureInCloud.Sdk.Client.RequestOptions localVarRequestOptions = new It.FattureInCloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("company_id", It.FattureInCloud.Sdk.Client.ClientUtils.ParameterToString(companyId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(It.FattureInCloud.Sdk.Client.ClientUtils.ParameterToMultiMap("", "category", category));

            localVarRequestOptions.Operation = "CompaniesApi.GetCompanyPlanUsage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2AuthenticationCodeFlow) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<GetCompanyPlanUsageResponse>("/c/{company_id}/company/plan_usage", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCompanyPlanUsage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
