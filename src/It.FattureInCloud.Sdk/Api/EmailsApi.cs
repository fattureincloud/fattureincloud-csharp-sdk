/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.23
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
    public interface IEmailsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List emails
        /// </summary>
        /// <remarks>
        /// List Emails.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ListEmailsResponse</returns>
        ListEmailsResponse ListEmails(int companyId, int operationIndex = 0);

        /// <summary>
        /// List emails
        /// </summary>
        /// <remarks>
        /// List Emails.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ListEmailsResponse</returns>
        ApiResponse<ListEmailsResponse> ListEmailsWithHttpInfo(int companyId, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEmailsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// List emails
        /// </summary>
        /// <remarks>
        /// List Emails.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListEmailsResponse</returns>
        System.Threading.Tasks.Task<ListEmailsResponse> ListEmailsAsync(int companyId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List emails
        /// </summary>
        /// <remarks>
        /// List Emails.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListEmailsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListEmailsResponse>> ListEmailsWithHttpInfoAsync(int companyId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEmailsApi : IEmailsApiSync, IEmailsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EmailsApi : IEmailsApi
    {
        private It.FattureInCloud.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EmailsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EmailsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="EmailsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EmailsApi(It.FattureInCloud.Sdk.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="EmailsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public EmailsApi(It.FattureInCloud.Sdk.Client.ISynchronousClient client, It.FattureInCloud.Sdk.Client.IAsynchronousClient asyncClient, It.FattureInCloud.Sdk.Client.IReadableConfiguration configuration)
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
        /// List emails List Emails.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ListEmailsResponse</returns>
        public ListEmailsResponse ListEmails(int companyId, int operationIndex = 0)
        {
            It.FattureInCloud.Sdk.Client.ApiResponse<ListEmailsResponse> localVarResponse = ListEmailsWithHttpInfo(companyId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List emails List Emails.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ListEmailsResponse</returns>
        public It.FattureInCloud.Sdk.Client.ApiResponse<ListEmailsResponse> ListEmailsWithHttpInfo(int companyId, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "EmailsApi.ListEmails";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2AuthenticationCodeFlow) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ListEmailsResponse>("/c/{company_id}/emails", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListEmails", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List emails List Emails.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListEmailsResponse</returns>
        public async System.Threading.Tasks.Task<ListEmailsResponse> ListEmailsAsync(int companyId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            It.FattureInCloud.Sdk.Client.ApiResponse<ListEmailsResponse> localVarResponse = await ListEmailsWithHttpInfoAsync(companyId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List emails List Emails.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListEmailsResponse)</returns>
        public async System.Threading.Tasks.Task<It.FattureInCloud.Sdk.Client.ApiResponse<ListEmailsResponse>> ListEmailsWithHttpInfoAsync(int companyId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Operation = "EmailsApi.ListEmails";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2AuthenticationCodeFlow) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ListEmailsResponse>("/c/{company_id}/emails", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListEmails", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
