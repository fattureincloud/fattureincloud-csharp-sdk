/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.28
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
    /// ListArchiveDocumentsResponse
    /// </summary>
    [DataContract(Name = "ListArchiveDocumentsResponse")]
    public partial class ListArchiveDocumentsResponse : IEquatable<ListArchiveDocumentsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListArchiveDocumentsResponse" /> class.
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
        public ListArchiveDocumentsResponse(int? currentPage = default(int?), string firstPageUrl = default(string), int? from = default(int?), int? lastPage = default(int?), string lastPageUrl = default(string), string nextPageUrl = default(string), string path = default(string), int? perPage = default(int?), string prevPageUrl = default(string), int? to = default(int?), int? total = default(int?), List<ArchiveDocument> data = default(List<ArchiveDocument>))
        {
            this._CurrentPage = currentPage;
            if (this.CurrentPage != null)
            {
                this._flagCurrentPage = true;
            }
            this._FirstPageUrl = firstPageUrl;
            if (this.FirstPageUrl != null)
            {
                this._flagFirstPageUrl = true;
            }
            this._From = from;
            if (this.From != null)
            {
                this._flagFrom = true;
            }
            this._LastPage = lastPage;
            if (this.LastPage != null)
            {
                this._flagLastPage = true;
            }
            this._LastPageUrl = lastPageUrl;
            if (this.LastPageUrl != null)
            {
                this._flagLastPageUrl = true;
            }
            this._NextPageUrl = nextPageUrl;
            if (this.NextPageUrl != null)
            {
                this._flagNextPageUrl = true;
            }
            this._Path = path;
            if (this.Path != null)
            {
                this._flagPath = true;
            }
            this._PerPage = perPage;
            if (this.PerPage != null)
            {
                this._flagPerPage = true;
            }
            this._PrevPageUrl = prevPageUrl;
            if (this.PrevPageUrl != null)
            {
                this._flagPrevPageUrl = true;
            }
            this._To = to;
            if (this.To != null)
            {
                this._flagTo = true;
            }
            this._Total = total;
            if (this.Total != null)
            {
                this._flagTotal = true;
            }
            this._Data = data;
            if (this.Data != null)
            {
                this._flagData = true;
            }
        }

        /// <summary>
        /// Current page number.
        /// </summary>
        /// <value>Current page number.</value>
        [DataMember(Name = "current_page", EmitDefaultValue = true)]
        public int? CurrentPage
        {
            get { return _CurrentPage; }
            set
            {
                _CurrentPage = value;
                _flagCurrentPage = true;
            }
        }
        private int? _CurrentPage;
        private bool _flagCurrentPage;

        /// <summary>
        /// Returns false as CurrentPage should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrentPage()
        {
            return _flagCurrentPage;
        }
        /// <summary>
        /// First page url.
        /// </summary>
        /// <value>First page url.</value>
        [DataMember(Name = "first_page_url", EmitDefaultValue = true)]
        public string FirstPageUrl
        {
            get { return _FirstPageUrl; }
            set
            {
                _FirstPageUrl = value;
                _flagFirstPageUrl = true;
            }
        }
        private string _FirstPageUrl;
        private bool _flagFirstPageUrl;

        /// <summary>
        /// Returns false as FirstPageUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFirstPageUrl()
        {
            return _flagFirstPageUrl;
        }
        /// <summary>
        /// First result of the page.
        /// </summary>
        /// <value>First result of the page.</value>
        [DataMember(Name = "from", EmitDefaultValue = true)]
        public int? From
        {
            get { return _From; }
            set
            {
                _From = value;
                _flagFrom = true;
            }
        }
        private int? _From;
        private bool _flagFrom;

        /// <summary>
        /// Returns false as From should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFrom()
        {
            return _flagFrom;
        }
        /// <summary>
        /// Last page number.
        /// </summary>
        /// <value>Last page number.</value>
        [DataMember(Name = "last_page", EmitDefaultValue = true)]
        public int? LastPage
        {
            get { return _LastPage; }
            set
            {
                _LastPage = value;
                _flagLastPage = true;
            }
        }
        private int? _LastPage;
        private bool _flagLastPage;

        /// <summary>
        /// Returns false as LastPage should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastPage()
        {
            return _flagLastPage;
        }
        /// <summary>
        /// Last page url.
        /// </summary>
        /// <value>Last page url.</value>
        [DataMember(Name = "last_page_url", EmitDefaultValue = true)]
        public string LastPageUrl
        {
            get { return _LastPageUrl; }
            set
            {
                _LastPageUrl = value;
                _flagLastPageUrl = true;
            }
        }
        private string _LastPageUrl;
        private bool _flagLastPageUrl;

        /// <summary>
        /// Returns false as LastPageUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastPageUrl()
        {
            return _flagLastPageUrl;
        }
        /// <summary>
        /// Next page url
        /// </summary>
        /// <value>Next page url</value>
        [DataMember(Name = "next_page_url", EmitDefaultValue = true)]
        public string NextPageUrl
        {
            get { return _NextPageUrl; }
            set
            {
                _NextPageUrl = value;
                _flagNextPageUrl = true;
            }
        }
        private string _NextPageUrl;
        private bool _flagNextPageUrl;

        /// <summary>
        /// Returns false as NextPageUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNextPageUrl()
        {
            return _flagNextPageUrl;
        }
        /// <summary>
        /// Request path.
        /// </summary>
        /// <value>Request path.</value>
        [DataMember(Name = "path", EmitDefaultValue = true)]
        public string Path
        {
            get { return _Path; }
            set
            {
                _Path = value;
                _flagPath = true;
            }
        }
        private string _Path;
        private bool _flagPath;

        /// <summary>
        /// Returns false as Path should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePath()
        {
            return _flagPath;
        }
        /// <summary>
        /// Number of result per page.
        /// </summary>
        /// <value>Number of result per page.</value>
        [DataMember(Name = "per_page", EmitDefaultValue = true)]
        public int? PerPage
        {
            get { return _PerPage; }
            set
            {
                _PerPage = value;
                _flagPerPage = true;
            }
        }
        private int? _PerPage;
        private bool _flagPerPage;

        /// <summary>
        /// Returns false as PerPage should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePerPage()
        {
            return _flagPerPage;
        }
        /// <summary>
        /// Previous page url.
        /// </summary>
        /// <value>Previous page url.</value>
        [DataMember(Name = "prev_page_url", EmitDefaultValue = true)]
        public string PrevPageUrl
        {
            get { return _PrevPageUrl; }
            set
            {
                _PrevPageUrl = value;
                _flagPrevPageUrl = true;
            }
        }
        private string _PrevPageUrl;
        private bool _flagPrevPageUrl;

        /// <summary>
        /// Returns false as PrevPageUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePrevPageUrl()
        {
            return _flagPrevPageUrl;
        }
        /// <summary>
        /// Last result of the page.
        /// </summary>
        /// <value>Last result of the page.</value>
        [DataMember(Name = "to", EmitDefaultValue = true)]
        public int? To
        {
            get { return _To; }
            set
            {
                _To = value;
                _flagTo = true;
            }
        }
        private int? _To;
        private bool _flagTo;

        /// <summary>
        /// Returns false as To should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTo()
        {
            return _flagTo;
        }
        /// <summary>
        /// Total number of results
        /// </summary>
        /// <value>Total number of results</value>
        [DataMember(Name = "total", EmitDefaultValue = true)]
        public int? Total
        {
            get { return _Total; }
            set
            {
                _Total = value;
                _flagTotal = true;
            }
        }
        private int? _Total;
        private bool _flagTotal;

        /// <summary>
        /// Returns false as Total should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotal()
        {
            return _flagTotal;
        }
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public List<ArchiveDocument> Data
        {
            get { return _Data; }
            set
            {
                _Data = value;
                _flagData = true;
            }
        }
        private List<ArchiveDocument> _Data;
        private bool _flagData;

        /// <summary>
        /// Returns false as Data should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeData()
        {
            return _flagData;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListArchiveDocumentsResponse {\n");
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
            return this.Equals(input as ListArchiveDocumentsResponse);
        }

        /// <summary>
        /// Returns true if ListArchiveDocumentsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListArchiveDocumentsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListArchiveDocumentsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CurrentPage == input.CurrentPage ||
                    (this.CurrentPage != null &&
                    this.CurrentPage.Equals(input.CurrentPage))
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
                    (this.LastPage != null &&
                    this.LastPage.Equals(input.LastPage))
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
                    (this.PerPage != null &&
                    this.PerPage.Equals(input.PerPage))
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
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.CurrentPage != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentPage.GetHashCode();
                }
                if (this.FirstPageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.FirstPageUrl.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.LastPage != null)
                {
                    hashCode = (hashCode * 59) + this.LastPage.GetHashCode();
                }
                if (this.LastPageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LastPageUrl.GetHashCode();
                }
                if (this.NextPageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NextPageUrl.GetHashCode();
                }
                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
                }
                if (this.PerPage != null)
                {
                    hashCode = (hashCode * 59) + this.PerPage.GetHashCode();
                }
                if (this.PrevPageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PrevPageUrl.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.Total != null)
                {
                    hashCode = (hashCode * 59) + this.Total.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
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
