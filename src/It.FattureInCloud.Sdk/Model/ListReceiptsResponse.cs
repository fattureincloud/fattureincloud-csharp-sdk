/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.16
 * Contact: info@fattureincloud.it
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


namespace It.FattureInCloud.Sdk.Model
{
    /// <summary>
    ///     ListReceiptsResponse
    /// </summary>
    [DataContract(Name = "ListReceiptsResponse")]
    public class ListReceiptsResponse : IEquatable<ListReceiptsResponse>, IValidatableObject
    {
        private int? _CurrentPage;
        private List<Receipt> _Data;
        private string _FirstPageUrl;
        private bool _flagCurrentPage;
        private bool _flagData;
        private bool _flagFirstPageUrl;
        private bool _flagFrom;
        private bool _flagLastPage;
        private bool _flagLastPageUrl;
        private bool _flagNextPageUrl;
        private bool _flagPath;
        private bool _flagPerPage;
        private bool _flagPrevPageUrl;
        private bool _flagTo;
        private bool _flagTotal;
        private int? _From;
        private int? _LastPage;
        private string _LastPageUrl;
        private string _NextPageUrl;
        private string _Path;
        private int? _PerPage;
        private string _PrevPageUrl;
        private int? _To;
        private int? _Total;

        /// <summary>
        ///     Initializes a new instance of the <see cref="ListReceiptsResponse" /> class.
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
        public ListReceiptsResponse(int? currentPage = default(int?), string firstPageUrl = default(string),
            int? from = default(int?), int? lastPage = default(int?), string lastPageUrl = default(string),
            string nextPageUrl = default(string), string path = default(string), int? perPage = default(int?),
            string prevPageUrl = default(string), int? to = default(int?), int? total = default(int?),
            List<Receipt> data = default(List<Receipt>))
        {
            _CurrentPage = currentPage;
            if (CurrentPage != null) _flagCurrentPage = true;
            _FirstPageUrl = firstPageUrl;
            if (FirstPageUrl != null) _flagFirstPageUrl = true;
            _From = from;
            if (From != null) _flagFrom = true;
            _LastPage = lastPage;
            if (LastPage != null) _flagLastPage = true;
            _LastPageUrl = lastPageUrl;
            if (LastPageUrl != null) _flagLastPageUrl = true;
            _NextPageUrl = nextPageUrl;
            if (NextPageUrl != null) _flagNextPageUrl = true;
            _Path = path;
            if (Path != null) _flagPath = true;
            _PerPage = perPage;
            if (PerPage != null) _flagPerPage = true;
            _PrevPageUrl = prevPageUrl;
            if (PrevPageUrl != null) _flagPrevPageUrl = true;
            _To = to;
            if (To != null) _flagTo = true;
            _Total = total;
            if (Total != null) _flagTotal = true;
            _Data = data;
            if (Data != null) _flagData = true;
        }

        /// <summary>
        ///     Current page number.
        /// </summary>
        /// <value>Current page number.</value>
        [DataMember(Name = "current_page", EmitDefaultValue = true)]
        public int? CurrentPage
        {
            get => _CurrentPage;
            set
            {
                _CurrentPage = value;
                _flagCurrentPage = true;
            }
        }

        /// <summary>
        ///     First page url.
        /// </summary>
        /// <value>First page url.</value>
        [DataMember(Name = "first_page_url", EmitDefaultValue = true)]
        public string FirstPageUrl
        {
            get => _FirstPageUrl;
            set
            {
                _FirstPageUrl = value;
                _flagFirstPageUrl = true;
            }
        }

        /// <summary>
        ///     First result of the page.
        /// </summary>
        /// <value>First result of the page.</value>
        [DataMember(Name = "from", EmitDefaultValue = true)]
        public int? From
        {
            get => _From;
            set
            {
                _From = value;
                _flagFrom = true;
            }
        }

        /// <summary>
        ///     Last page number.
        /// </summary>
        /// <value>Last page number.</value>
        [DataMember(Name = "last_page", EmitDefaultValue = true)]
        public int? LastPage
        {
            get => _LastPage;
            set
            {
                _LastPage = value;
                _flagLastPage = true;
            }
        }

        /// <summary>
        ///     Last page url.
        /// </summary>
        /// <value>Last page url.</value>
        [DataMember(Name = "last_page_url", EmitDefaultValue = true)]
        public string LastPageUrl
        {
            get => _LastPageUrl;
            set
            {
                _LastPageUrl = value;
                _flagLastPageUrl = true;
            }
        }

        /// <summary>
        ///     Next page url
        /// </summary>
        /// <value>Next page url</value>
        [DataMember(Name = "next_page_url", EmitDefaultValue = true)]
        public string NextPageUrl
        {
            get => _NextPageUrl;
            set
            {
                _NextPageUrl = value;
                _flagNextPageUrl = true;
            }
        }

        /// <summary>
        ///     Request path.
        /// </summary>
        /// <value>Request path.</value>
        [DataMember(Name = "path", EmitDefaultValue = true)]
        public string Path
        {
            get => _Path;
            set
            {
                _Path = value;
                _flagPath = true;
            }
        }

        /// <summary>
        ///     Number of result per page.
        /// </summary>
        /// <value>Number of result per page.</value>
        [DataMember(Name = "per_page", EmitDefaultValue = true)]
        public int? PerPage
        {
            get => _PerPage;
            set
            {
                _PerPage = value;
                _flagPerPage = true;
            }
        }

        /// <summary>
        ///     Previous page url.
        /// </summary>
        /// <value>Previous page url.</value>
        [DataMember(Name = "prev_page_url", EmitDefaultValue = true)]
        public string PrevPageUrl
        {
            get => _PrevPageUrl;
            set
            {
                _PrevPageUrl = value;
                _flagPrevPageUrl = true;
            }
        }

        /// <summary>
        ///     Last result of the page.
        /// </summary>
        /// <value>Last result of the page.</value>
        [DataMember(Name = "to", EmitDefaultValue = true)]
        public int? To
        {
            get => _To;
            set
            {
                _To = value;
                _flagTo = true;
            }
        }

        /// <summary>
        ///     Total number of results
        /// </summary>
        /// <value>Total number of results</value>
        [DataMember(Name = "total", EmitDefaultValue = true)]
        public int? Total
        {
            get => _Total;
            set
            {
                _Total = value;
                _flagTotal = true;
            }
        }

        /// <summary>
        ///     Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public List<Receipt> Data
        {
            get => _Data;
            set
            {
                _Data = value;
                _flagData = true;
            }
        }

        /// <summary>
        ///     Returns false as CurrentPage should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrentPage()
        {
            return _flagCurrentPage;
        }

        /// <summary>
        ///     Returns false as FirstPageUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFirstPageUrl()
        {
            return _flagFirstPageUrl;
        }

        /// <summary>
        ///     Returns false as From should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFrom()
        {
            return _flagFrom;
        }

        /// <summary>
        ///     Returns false as LastPage should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastPage()
        {
            return _flagLastPage;
        }

        /// <summary>
        ///     Returns false as LastPageUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastPageUrl()
        {
            return _flagLastPageUrl;
        }

        /// <summary>
        ///     Returns false as NextPageUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNextPageUrl()
        {
            return _flagNextPageUrl;
        }

        /// <summary>
        ///     Returns false as Path should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePath()
        {
            return _flagPath;
        }

        /// <summary>
        ///     Returns false as PerPage should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePerPage()
        {
            return _flagPerPage;
        }

        /// <summary>
        ///     Returns false as PrevPageUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePrevPageUrl()
        {
            return _flagPrevPageUrl;
        }

        /// <summary>
        ///     Returns false as To should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTo()
        {
            return _flagTo;
        }

        /// <summary>
        ///     Returns false as Total should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotal()
        {
            return _flagTotal;
        }

        /// <summary>
        ///     Returns false as Data should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeData()
        {
            return _flagData;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListReceiptsResponse {\n");
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
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as ListReceiptsResponse);
        }

        /// <summary>
        ///     Returns true if ListReceiptsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListReceiptsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListReceiptsResponse input)
        {
            if (input == null) return false;
            return
                (
                    CurrentPage == input.CurrentPage ||
                    (CurrentPage != null &&
                     CurrentPage.Equals(input.CurrentPage))
                ) &&
                (
                    FirstPageUrl == input.FirstPageUrl ||
                    (FirstPageUrl != null &&
                     FirstPageUrl.Equals(input.FirstPageUrl))
                ) &&
                (
                    From == input.From ||
                    (From != null &&
                     From.Equals(input.From))
                ) &&
                (
                    LastPage == input.LastPage ||
                    (LastPage != null &&
                     LastPage.Equals(input.LastPage))
                ) &&
                (
                    LastPageUrl == input.LastPageUrl ||
                    (LastPageUrl != null &&
                     LastPageUrl.Equals(input.LastPageUrl))
                ) &&
                (
                    NextPageUrl == input.NextPageUrl ||
                    (NextPageUrl != null &&
                     NextPageUrl.Equals(input.NextPageUrl))
                ) &&
                (
                    Path == input.Path ||
                    (Path != null &&
                     Path.Equals(input.Path))
                ) &&
                (
                    PerPage == input.PerPage ||
                    (PerPage != null &&
                     PerPage.Equals(input.PerPage))
                ) &&
                (
                    PrevPageUrl == input.PrevPageUrl ||
                    (PrevPageUrl != null &&
                     PrevPageUrl.Equals(input.PrevPageUrl))
                ) &&
                (
                    To == input.To ||
                    (To != null &&
                     To.Equals(input.To))
                ) &&
                (
                    Total == input.Total ||
                    (Total != null &&
                     Total.Equals(input.Total))
                ) &&
                (
                    Data == input.Data ||
                    (Data != null &&
                     input.Data != null &&
                     Data.SequenceEqual(input.Data))
                );
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (CurrentPage != null) hashCode = hashCode * 59 + CurrentPage.GetHashCode();
                if (FirstPageUrl != null) hashCode = hashCode * 59 + FirstPageUrl.GetHashCode();
                if (From != null) hashCode = hashCode * 59 + From.GetHashCode();
                if (LastPage != null) hashCode = hashCode * 59 + LastPage.GetHashCode();
                if (LastPageUrl != null) hashCode = hashCode * 59 + LastPageUrl.GetHashCode();
                if (NextPageUrl != null) hashCode = hashCode * 59 + NextPageUrl.GetHashCode();
                if (Path != null) hashCode = hashCode * 59 + Path.GetHashCode();
                if (PerPage != null) hashCode = hashCode * 59 + PerPage.GetHashCode();
                if (PrevPageUrl != null) hashCode = hashCode * 59 + PrevPageUrl.GetHashCode();
                if (To != null) hashCode = hashCode * 59 + To.GetHashCode();
                if (Total != null) hashCode = hashCode * 59 + Total.GetHashCode();
                if (Data != null) hashCode = hashCode * 59 + Data.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}