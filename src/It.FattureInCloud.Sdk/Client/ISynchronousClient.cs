/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.8
 * Contact: info@fattureincloud.it
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.IO;

namespace It.FattureInCloud.Sdk.Client
{
    /// <summary>
    /// Contract for Synchronous RESTful API interactions.
    ///
    /// This interface allows consumers to provide a custom API accessor client.
    /// </summary>
    public interface ISynchronousClient
    {
        /// <summary>
        /// Executes a blocking call to some <paramref name="path"/> using the GET http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <param name="configuration">Per-request configurable settings.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>The response data, decorated with <see cref="ApiResponse{T}"/></returns>
        ApiResponse<T> Get<T>(string path, RequestOptions options, IReadableConfiguration configuration = null);

        /// <summary>
        /// Executes a blocking call to some <paramref name="path"/> using the POST http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <param name="configuration">Per-request configurable settings.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>The response data, decorated with <see cref="ApiResponse{T}"/></returns>
        ApiResponse<T> Post<T>(string path, RequestOptions options, IReadableConfiguration configuration = null);

        /// <summary>
        /// Executes a blocking call to some <paramref name="path"/> using the PUT http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <param name="configuration">Per-request configurable settings.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>The response data, decorated with <see cref="ApiResponse{T}"/></returns>
        ApiResponse<T> Put<T>(string path, RequestOptions options, IReadableConfiguration configuration = null);

        /// <summary>
        /// Executes a blocking call to some <paramref name="path"/> using the DELETE http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <param name="configuration">Per-request configurable settings.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>The response data, decorated with <see cref="ApiResponse{T}"/></returns>
        ApiResponse<T> Delete<T>(string path, RequestOptions options, IReadableConfiguration configuration = null);

        /// <summary>
        /// Executes a blocking call to some <paramref name="path"/> using the HEAD http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <param name="configuration">Per-request configurable settings.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>The response data, decorated with <see cref="ApiResponse{T}"/></returns>
        ApiResponse<T> Head<T>(string path, RequestOptions options, IReadableConfiguration configuration = null);

        /// <summary>
        /// Executes a blocking call to some <paramref name="path"/> using the OPTIONS http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <param name="configuration">Per-request configurable settings.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>The response data, decorated with <see cref="ApiResponse{T}"/></returns>
        ApiResponse<T> Options<T>(string path, RequestOptions options, IReadableConfiguration configuration = null);

        /// <summary>
        /// Executes a blocking call to some <paramref name="path"/> using the PATCH http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <param name="configuration">Per-request configurable settings.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>The response data, decorated with <see cref="ApiResponse{T}"/></returns>
        ApiResponse<T> Patch<T>(string path, RequestOptions options, IReadableConfiguration configuration = null);
    }
}
