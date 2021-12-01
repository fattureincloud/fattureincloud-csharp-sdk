/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.6
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
    public interface IIssuedEInvoicesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Send the e-invoice
        /// </summary>
        /// <remarks>
        /// Sends the e-invoice to SDI.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="documentId">The ID of the document.</param>
        /// <param name="sendEInvoiceRequest"> (optional)</param>
        /// <returns>SendEInvoiceResponse</returns>
        SendEInvoiceResponse SendEInvoice(int companyId, int documentId, SendEInvoiceRequest sendEInvoiceRequest = default(SendEInvoiceRequest));

        /// <summary>
        /// Send the e-invoice
        /// </summary>
        /// <remarks>
        /// Sends the e-invoice to SDI.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="documentId">The ID of the document.</param>
        /// <param name="sendEInvoiceRequest"> (optional)</param>
        /// <returns>ApiResponse of SendEInvoiceResponse</returns>
        ApiResponse<SendEInvoiceResponse> SendEInvoiceWithHttpInfo(int companyId, int documentId, SendEInvoiceRequest sendEInvoiceRequest = default(SendEInvoiceRequest));
        /// <summary>
        /// Verify e-invoice xml
        /// </summary>
        /// <remarks>
        /// Verifies the e-invoice xml format. Checks if all of the mandatory fields are filled and compliant to the right format.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="documentId">The ID of the document.</param>
        /// <returns>VerifyEInvoiceXmlResponse</returns>
        VerifyEInvoiceXmlResponse VerifyEInvoiceXml(int companyId, int documentId);

        /// <summary>
        /// Verify e-invoice xml
        /// </summary>
        /// <remarks>
        /// Verifies the e-invoice xml format. Checks if all of the mandatory fields are filled and compliant to the right format.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="documentId">The ID of the document.</param>
        /// <returns>ApiResponse of VerifyEInvoiceXmlResponse</returns>
        ApiResponse<VerifyEInvoiceXmlResponse> VerifyEInvoiceXmlWithHttpInfo(int companyId, int documentId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIssuedEInvoicesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Send the e-invoice
        /// </summary>
        /// <remarks>
        /// Sends the e-invoice to SDI.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="documentId">The ID of the document.</param>
        /// <param name="sendEInvoiceRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SendEInvoiceResponse</returns>
        System.Threading.Tasks.Task<SendEInvoiceResponse> SendEInvoiceAsync(int companyId, int documentId, SendEInvoiceRequest sendEInvoiceRequest = default(SendEInvoiceRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Send the e-invoice
        /// </summary>
        /// <remarks>
        /// Sends the e-invoice to SDI.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="documentId">The ID of the document.</param>
        /// <param name="sendEInvoiceRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SendEInvoiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SendEInvoiceResponse>> SendEInvoiceWithHttpInfoAsync(int companyId, int documentId, SendEInvoiceRequest sendEInvoiceRequest = default(SendEInvoiceRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Verify e-invoice xml
        /// </summary>
        /// <remarks>
        /// Verifies the e-invoice xml format. Checks if all of the mandatory fields are filled and compliant to the right format.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="documentId">The ID of the document.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VerifyEInvoiceXmlResponse</returns>
        System.Threading.Tasks.Task<VerifyEInvoiceXmlResponse> VerifyEInvoiceXmlAsync(int companyId, int documentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Verify e-invoice xml
        /// </summary>
        /// <remarks>
        /// Verifies the e-invoice xml format. Checks if all of the mandatory fields are filled and compliant to the right format.
        /// </remarks>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="documentId">The ID of the document.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VerifyEInvoiceXmlResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VerifyEInvoiceXmlResponse>> VerifyEInvoiceXmlWithHttpInfoAsync(int companyId, int documentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIssuedEInvoicesApi : IIssuedEInvoicesApiSync, IIssuedEInvoicesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class IssuedEInvoicesApi : IIssuedEInvoicesApi
    {
        private It.FattureInCloud.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedEInvoicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IssuedEInvoicesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedEInvoicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IssuedEInvoicesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="IssuedEInvoicesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public IssuedEInvoicesApi(It.FattureInCloud.Sdk.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="IssuedEInvoicesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public IssuedEInvoicesApi(It.FattureInCloud.Sdk.Client.ISynchronousClient client, It.FattureInCloud.Sdk.Client.IAsynchronousClient asyncClient, It.FattureInCloud.Sdk.Client.IReadableConfiguration configuration)
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
        /// Send the e-invoice Sends the e-invoice to SDI.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="documentId">The ID of the document.</param>
        /// <param name="sendEInvoiceRequest"> (optional)</param>
        /// <returns>SendEInvoiceResponse</returns>
        public SendEInvoiceResponse SendEInvoice(int companyId, int documentId, SendEInvoiceRequest sendEInvoiceRequest = default(SendEInvoiceRequest))
        {
            It.FattureInCloud.Sdk.Client.ApiResponse<SendEInvoiceResponse> localVarResponse = SendEInvoiceWithHttpInfo(companyId, documentId, sendEInvoiceRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send the e-invoice Sends the e-invoice to SDI.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="documentId">The ID of the document.</param>
        /// <param name="sendEInvoiceRequest"> (optional)</param>
        /// <returns>ApiResponse of SendEInvoiceResponse</returns>
        public It.FattureInCloud.Sdk.Client.ApiResponse<SendEInvoiceResponse> SendEInvoiceWithHttpInfo(int companyId, int documentId, SendEInvoiceRequest sendEInvoiceRequest = default(SendEInvoiceRequest))
        {
            It.FattureInCloud.Sdk.Client.RequestOptions localVarRequestOptions = new It.FattureInCloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("company_id", It.FattureInCloud.Sdk.Client.ClientUtils.ParameterToString(companyId)); // path parameter
            localVarRequestOptions.PathParameters.Add("document_id", It.FattureInCloud.Sdk.Client.ClientUtils.ParameterToString(documentId)); // path parameter
            localVarRequestOptions.Data = sendEInvoiceRequest;

            // authentication (OAuth2AuthenticationCodeFlow) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<SendEInvoiceResponse>("/c/{company_id}/issued_documents/{document_id}/e_invoice/send", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SendEInvoice", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send the e-invoice Sends the e-invoice to SDI.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="documentId">The ID of the document.</param>
        /// <param name="sendEInvoiceRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SendEInvoiceResponse</returns>
        public async System.Threading.Tasks.Task<SendEInvoiceResponse> SendEInvoiceAsync(int companyId, int documentId, SendEInvoiceRequest sendEInvoiceRequest = default(SendEInvoiceRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            It.FattureInCloud.Sdk.Client.ApiResponse<SendEInvoiceResponse> localVarResponse = await SendEInvoiceWithHttpInfoAsync(companyId, documentId, sendEInvoiceRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send the e-invoice Sends the e-invoice to SDI.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="documentId">The ID of the document.</param>
        /// <param name="sendEInvoiceRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SendEInvoiceResponse)</returns>
        public async System.Threading.Tasks.Task<It.FattureInCloud.Sdk.Client.ApiResponse<SendEInvoiceResponse>> SendEInvoiceWithHttpInfoAsync(int companyId, int documentId, SendEInvoiceRequest sendEInvoiceRequest = default(SendEInvoiceRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            It.FattureInCloud.Sdk.Client.RequestOptions localVarRequestOptions = new It.FattureInCloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = It.FattureInCloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("company_id", It.FattureInCloud.Sdk.Client.ClientUtils.ParameterToString(companyId)); // path parameter
            localVarRequestOptions.PathParameters.Add("document_id", It.FattureInCloud.Sdk.Client.ClientUtils.ParameterToString(documentId)); // path parameter
            localVarRequestOptions.Data = sendEInvoiceRequest;

            // authentication (OAuth2AuthenticationCodeFlow) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<SendEInvoiceResponse>("/c/{company_id}/issued_documents/{document_id}/e_invoice/send", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SendEInvoice", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Verify e-invoice xml Verifies the e-invoice xml format. Checks if all of the mandatory fields are filled and compliant to the right format.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="documentId">The ID of the document.</param>
        /// <returns>VerifyEInvoiceXmlResponse</returns>
        public VerifyEInvoiceXmlResponse VerifyEInvoiceXml(int companyId, int documentId)
        {
            It.FattureInCloud.Sdk.Client.ApiResponse<VerifyEInvoiceXmlResponse> localVarResponse = VerifyEInvoiceXmlWithHttpInfo(companyId, documentId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Verify e-invoice xml Verifies the e-invoice xml format. Checks if all of the mandatory fields are filled and compliant to the right format.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="documentId">The ID of the document.</param>
        /// <returns>ApiResponse of VerifyEInvoiceXmlResponse</returns>
        public It.FattureInCloud.Sdk.Client.ApiResponse<VerifyEInvoiceXmlResponse> VerifyEInvoiceXmlWithHttpInfo(int companyId, int documentId)
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

            localVarRequestOptions.PathParameters.Add("company_id", It.FattureInCloud.Sdk.Client.ClientUtils.ParameterToString(companyId)); // path parameter
            localVarRequestOptions.PathParameters.Add("document_id", It.FattureInCloud.Sdk.Client.ClientUtils.ParameterToString(documentId)); // path parameter

            // authentication (OAuth2AuthenticationCodeFlow) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<VerifyEInvoiceXmlResponse>("/c/{company_id}/issued_documents/{document_id}/e_invoice/xml_verify", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("VerifyEInvoiceXml", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Verify e-invoice xml Verifies the e-invoice xml format. Checks if all of the mandatory fields are filled and compliant to the right format.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="documentId">The ID of the document.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VerifyEInvoiceXmlResponse</returns>
        public async System.Threading.Tasks.Task<VerifyEInvoiceXmlResponse> VerifyEInvoiceXmlAsync(int companyId, int documentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            It.FattureInCloud.Sdk.Client.ApiResponse<VerifyEInvoiceXmlResponse> localVarResponse = await VerifyEInvoiceXmlWithHttpInfoAsync(companyId, documentId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Verify e-invoice xml Verifies the e-invoice xml format. Checks if all of the mandatory fields are filled and compliant to the right format.
        /// </summary>
        /// <exception cref="It.FattureInCloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">The ID of the company.</param>
        /// <param name="documentId">The ID of the document.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VerifyEInvoiceXmlResponse)</returns>
        public async System.Threading.Tasks.Task<It.FattureInCloud.Sdk.Client.ApiResponse<VerifyEInvoiceXmlResponse>> VerifyEInvoiceXmlWithHttpInfoAsync(int companyId, int documentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("company_id", It.FattureInCloud.Sdk.Client.ClientUtils.ParameterToString(companyId)); // path parameter
            localVarRequestOptions.PathParameters.Add("document_id", It.FattureInCloud.Sdk.Client.ClientUtils.ParameterToString(documentId)); // path parameter

            // authentication (OAuth2AuthenticationCodeFlow) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<VerifyEInvoiceXmlResponse>("/c/{company_id}/issued_documents/{document_id}/e_invoice/xml_verify", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("VerifyEInvoiceXml", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
