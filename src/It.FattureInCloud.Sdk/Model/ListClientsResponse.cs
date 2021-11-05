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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = It.FattureInCloud.Sdk.Client.OpenAPIDateConverter;

namespace It.FattureInCloud.Sdk.Model
{
    /// <summary>
    /// ListClientsResponse
    /// </summary>
    [DataContract(Name = "ListClientsResponse")]
    public partial class ListClientsResponse : IEquatable<ListClientsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListClientsResponse" /> class.
        /// </summary>
        /// <param name="currentPage">Current page number..</param>
        /// <param name="firstPageUrl">First page url..</param>
        /// <param name="from">First result of the page..</param>
        /// <param name="lastPage">Last page number..</param>
        /// <param name="lastPageUrl">Last page url..</param>
        /// <param name="nextPageUrl">Next page url.</param>
        /// <param name="path">Request path..</param>
        /// <param name="perPage">Number of result per page..</param>
        /// <param name="prevPageUrl">Previous page url..</param>
        /// <param name="to">Last result of the page..</param>
        /// <param name="total">Total number of results.</param>
        /// <param name="data">data.</param>
        public ListClientsResponse(int currentPage = default(int), string firstPageUrl = default(string), int? from = default(int?), int lastPage = default(int), string lastPageUrl = default(string), string nextPageUrl = default(string), string path = default(string), int perPage = default(int), string prevPageUrl = default(string), int? to = default(int?), int total = default(int), List<ModelClient> data = default(List<ModelClient>))
        {
            this.CurrentPage = currentPage;
            this.FirstPageUrl = firstPageUrl;
            this.From = from;
            this.LastPage = lastPage;
            this.LastPageUrl = lastPageUrl;
            this.NextPageUrl = nextPageUrl;
            this.Path = path;
            this.PerPage = perPage;
            this.PrevPageUrl = prevPageUrl;
            this.To = to;
            this.Total = total;
            this.Data = data;
        }

        /// <summary>
        /// Current page number.
        /// </summary>
        /// <value>Current page number.</value>
        [DataMember(Name = "current_page", EmitDefaultValue = false)]
        public int CurrentPage { get; set; }

        /// <summary>
        /// First page url.
        /// </summary>
        /// <value>First page url.</value>
        [DataMember(Name = "first_page_url", EmitDefaultValue = false)]
        public string FirstPageUrl { get; set; }

        /// <summary>
        /// First result of the page.
        /// </summary>
        /// <value>First result of the page.</value>
        [DataMember(Name = "from", EmitDefaultValue = true)]
        public int? From { get; set; }

        /// <summary>
        /// Last page number.
        /// </summary>
        /// <value>Last page number.</value>
        [DataMember(Name = "last_page", EmitDefaultValue = false)]
        public int LastPage { get; set; }

        /// <summary>
        /// Last page url.
        /// </summary>
        /// <value>Last page url.</value>
        [DataMember(Name = "last_page_url", EmitDefaultValue = false)]
        public string LastPageUrl { get; set; }

        /// <summary>
        /// Next page url
        /// </summary>
        /// <value>Next page url</value>
        [DataMember(Name = "next_page_url", EmitDefaultValue = true)]
        public string NextPageUrl { get; set; }

        /// <summary>
        /// Request path.
        /// </summary>
        /// <value>Request path.</value>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// Number of result per page.
        /// </summary>
        /// <value>Number of result per page.</value>
        [DataMember(Name = "per_page", EmitDefaultValue = false)]
        public int PerPage { get; set; }

        /// <summary>
        /// Previous page url.
        /// </summary>
        /// <value>Previous page url.</value>
        [DataMember(Name = "prev_page_url", EmitDefaultValue = true)]
        public string PrevPageUrl { get; set; }

        /// <summary>
        /// Last result of the page.
        /// </summary>
        /// <value>Last result of the page.</value>
        [DataMember(Name = "to", EmitDefaultValue = true)]
        public int? To { get; set; }

        /// <summary>
        /// Total number of results
        /// </summary>
        /// <value>Total number of results</value>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<ModelClient> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListClientsResponse {\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  FirstPageUrl: ").Append(FirstPageUrl).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  LastPage: ").Append(LastPage).Append("\n");
            sb.Append("  LastPageUrl: ").Append(LastPageUrl).Append("\n");
            sb.Append("  NextPageUrl: ").Append(NextPageUrl).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  PrevPageUrl: ").Append(PrevPageUrl).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListClientsResponse);
        }

        /// <summary>
        /// Returns true if ListClientsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListClientsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListClientsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentPage == input.CurrentPage ||
                    this.CurrentPage.Equals(input.CurrentPage)
                ) && 
                (
                    this.FirstPageUrl == input.FirstPageUrl ||
                    (this.FirstPageUrl != null &&
                    this.FirstPageUrl.Equals(input.FirstPageUrl))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.LastPage == input.LastPage ||
                    this.LastPage.Equals(input.LastPage)
                ) && 
                (
                    this.LastPageUrl == input.LastPageUrl ||
                    (this.LastPageUrl != null &&
                    this.LastPageUrl.Equals(input.LastPageUrl))
                ) && 
                (
                    this.NextPageUrl == input.NextPageUrl ||
                    (this.NextPageUrl != null &&
                    this.NextPageUrl.Equals(input.NextPageUrl))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    this.PerPage.Equals(input.PerPage)
                ) && 
                (
                    this.PrevPageUrl == input.PrevPageUrl ||
                    (this.PrevPageUrl != null &&
                    this.PrevPageUrl.Equals(input.PrevPageUrl))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.CurrentPage.GetHashCode();
                if (this.FirstPageUrl != null)
                    hashCode = hashCode * 59 + this.FirstPageUrl.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                hashCode = hashCode * 59 + this.LastPage.GetHashCode();
                if (this.LastPageUrl != null)
                    hashCode = hashCode * 59 + this.LastPageUrl.GetHashCode();
                if (this.NextPageUrl != null)
                    hashCode = hashCode * 59 + this.NextPageUrl.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                if (this.PrevPageUrl != null)
                    hashCode = hashCode * 59 + this.PrevPageUrl.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
