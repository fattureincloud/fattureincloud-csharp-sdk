/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.7
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
    public interface IUserApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get User Info
        /// </summary>
        /// <remarks>
        /// Gets the current user&#39;s info.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GetUserInfoResponse</returns>
        GetUserInfoResponse GetUserInfo();

        /// <summary>
        /// Get User Info
        /// </summary>
        /// <remarks>
        /// Gets the current user&#39;s info.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GetUserInfoResponse</returns>
        ApiResponse<GetUserInfoResponse> GetUserInfoWithHttpInfo();
        /// <summary>
        /// List User Companies
        /// </summary>
        /// <remarks>
        /// Lists the companies controlled by the current user.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ListUserCompaniesResponse</returns>
        ListUserCompaniesResponse ListUserCompanies();

        /// <summary>
        /// List User Companies
        /// </summary>
        /// <remarks>
        /// Lists the companies controlled by the current user.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ListUserCompaniesResponse</returns>
        ApiResponse<ListUserCompaniesResponse> ListUserCompaniesWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get User Info
        /// </summary>
        /// <remarks>
        /// Gets the current user&#39;s info.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetUserInfoResponse</returns>
        System.Threading.Tasks.Task<GetUserInfoResponse> GetUserInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get User Info
        /// </summary>
        /// <remarks>
        /// Gets the current user&#39;s info.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetUserInfoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetUserInfoResponse>> GetUserInfoWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List User Companies
        /// </summary>
        /// <remarks>
        /// Lists the companies controlled by the current user.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListUserCompaniesResponse</returns>
        System.Threading.Tasks.Task<ListUserCompaniesResponse> ListUserCompaniesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List User Companies
        /// </summary>
        /// <remarks>
        /// Lists the companies controlled by the current user.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListUserCompaniesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListUserCompaniesResponse>> ListUserCompaniesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserApi : IUserApiSync, IUserApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserApi : IUserApi
    {
        private It.FattureInCloud.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi(string basePath)
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
        /// Initializes a new instance of the <see cref="UserApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserApi(It.FattureInCloud.Sdk.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="UserApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public UserApi(It.FattureInCloud.Sdk.Client.ISynchronousClient client, It.FattureInCloud.Sdk.Client.IAsynchronousClient asyncClient, It.FattureInCloud.Sdk.Client.IReadableConfiguration configuration)
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
        /// Get User Info Gets the current user&#39;s info.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GetUserInfoResponse</returns>
        public GetUserInfoResponse GetUserInfo()
        {
            It.FattureInCloud.Sdk.Client.ApiResponse<GetUserInfoResponse> localVarResponse = GetUserInfoWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get User Info Gets the current user&#39;s info.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GetUserInfoResponse</returns>
        public It.FattureInCloud.Sdk.Client.ApiResponse<GetUserInfoResponse> GetUserInfoWithHttpInfo()
        {
            It.FattureInCloud.Sdk.Client.RequestOptions localVarRequestOptions = new It.FattureInCloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (OAuth2AuthenticationCodeFlow) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<GetUserInfoResponse>("/user/info", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUserInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get User Info Gets the current user&#39;s info.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetUserInfoResponse</returns>
        public async System.Threading.Tasks.Task<GetUserInfoResponse> GetUserInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            It.FattureInCloud.Sdk.Client.ApiResponse<GetUserInfoResponse> localVarResponse = await GetUserInfoWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get User Info Gets the current user&#39;s info.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetUserInfoResponse)</returns>
        public async System.Threading.Tasks.Task<It.FattureInCloud.Sdk.Client.ApiResponse<GetUserInfoResponse>> GetUserInfoWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            It.FattureInCloud.Sdk.Client.RequestOptions localVarRequestOptions = new It.FattureInCloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (OAuth2AuthenticationCodeFlow) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<GetUserInfoResponse>("/user/info", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUserInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List User Companies Lists the companies controlled by the current user.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ListUserCompaniesResponse</returns>
        public ListUserCompaniesResponse ListUserCompanies()
        {
            It.FattureInCloud.Sdk.Client.ApiResponse<ListUserCompaniesResponse> localVarResponse = ListUserCompaniesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// List User Companies Lists the companies controlled by the current user.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ListUserCompaniesResponse</returns>
        public It.FattureInCloud.Sdk.Client.ApiResponse<ListUserCompaniesResponse> ListUserCompaniesWithHttpInfo()
        {
            It.FattureInCloud.Sdk.Client.RequestOptions localVarRequestOptions = new It.FattureInCloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (OAuth2AuthenticationCodeFlow) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ListUserCompaniesResponse>("/user/companies", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListUserCompanies", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List User Companies Lists the companies controlled by the current user.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListUserCompaniesResponse</returns>
        public async System.Threading.Tasks.Task<ListUserCompaniesResponse> ListUserCompaniesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            It.FattureInCloud.Sdk.Client.ApiResponse<ListUserCompaniesResponse> localVarResponse = await ListUserCompaniesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List User Companies Lists the companies controlled by the current user.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListUserCompaniesResponse)</returns>
        public async System.Threading.Tasks.Task<It.FattureInCloud.Sdk.Client.ApiResponse<ListUserCompaniesResponse>> ListUserCompaniesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            It.FattureInCloud.Sdk.Client.RequestOptions localVarRequestOptions = new It.FattureInCloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (OAuth2AuthenticationCodeFlow) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ListUserCompaniesResponse>("/user/companies", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListUserCompanies", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
