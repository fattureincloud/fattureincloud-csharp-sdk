namespace It.FattureInCloud.Sdk.OauthHelper
{
    /// <summary>
    ///     Oauth2
    /// </summary>
    public class OAuth2AuthorizationCodeManager
    {
        /// <summary>
        ///     Initialize a new instance of the Oauth2 class.
        /// </summary>
        /// <param name="clientId">Client Id</param>
        /// <param name="clientSecret">Client Secret</param>
        /// <param name="redirectUri">Redirect Uri</param>
        /// <param name="baseUri">Base Uri</param>
        public OAuth2AuthorizationCodeManager(string clientId, string clientSecret, string redirectUri,
            string baseUri = "https://api-v2.fattureincloud.it")
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            RedirectUri = redirectUri;
            BaseUri = baseUri;
        }

        /// <summary>
        ///     Gets or Sets ClientId
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        ///     Gets or Sets ClientSecret
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        ///     Gets or Sets RedirectUri
        /// </summary>
        public string RedirectUri { get; set; }

        /// <summary>
        ///     Gets or Sets BaseUri
        /// </summary>
        public string BaseUri { get; set; } = "https://api-v2.fattureincloud.it";

        /// <summary>
        ///     Get the authorization url.
        /// </summary>
        /// <param name="scopes">Scopes</param>
        /// <param name="state">state</param>
        /// <returns>(string)</returns>
        public string GetAuthorizationUrl(List<Scope> scopes, string state)
        {
            string authorizationUri = string.Format("{0}/oauth/authorize", BaseUri);
            string scopesString = GetScopeString(scopes);

            var query = HttpUtility.ParseQueryString(string.Empty);
            query.Add("response_type", "code");
            query.Add("client_id", ClientId);
            query.Add("redirect_uri", RedirectUri);
            query.Add("scope", scopesString);
            query.Add("state", state);

            return authorizationUri + '?' + query;
        }

        /// <summary>
        ///     Get parameters from the url.
        /// </summary>
        /// <param name="url">Url</param>
        /// <returns>(OAuth2AuthorizationCodeParams)</returns>
        public OAuth2AuthorizationCodeParams GetParamsFromUrl(string url)
        {
            var uri = new Uri(url);

            var state = HttpUtility.ParseQueryString(uri.Query).Get("state");
            var code = HttpUtility.ParseQueryString(uri.Query).Get("code");

            return new OAuth2AuthorizationCodeParams(code, state);
        }

        /// <summary>
        ///     Retrieve the access token.
        /// </summary>
        /// <param name="code">Code</param>
        /// <returns>(OAuth2AuthorizationCodeTokenResponse)</returns>
        public OAuth2AuthorizationCodeTokenResponse FetchToken(string code)
        {
            string tokenUri = string.Format("{0}/oauth/token", BaseUri);
            var data = new
            {
                grant_type = "authorization_code",
                client_id = ClientId,
                client_secret = ClientSecret,
                redirect_uri = RedirectUri,
                code
            };

            var client = new RestClient(tokenUri);
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddJsonBody(data);
            IRestResponse response = client.Execute(request);
            if ((int)response.StatusCode != 200) throw new OAuth2AuthorizationCodeError(response.Content);
            ;

            return JsonConvert.DeserializeObject<OAuth2AuthorizationCodeTokenResponse>(response.Content);
        }

        /// <summary>
        ///     Refresh the access token.
        /// </summary>
        /// <param name="refreshToken">Refresh Token</param>
        /// <returns>(OAuth2AuthorizationCodeTokenResponse)</returns>
        public OAuth2AuthorizationCodeTokenResponse RefreshToken(string refreshToken)
        {
            string tokenUri = string.Format("{0}/oauth/token", BaseUri);
            var data = new
            {
                grant_type = "refresh_token",
                client_id = ClientId,
                client_secret = ClientSecret,
                refresh_token = refreshToken
            };

            var client = new RestClient(tokenUri);
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddJsonBody(data);
            IRestResponse response = client.Execute(request);
            if ((int)response.StatusCode != 200) throw new OAuth2AuthorizationCodeError(response.Content);
            ;

            return JsonConvert.DeserializeObject<OAuth2AuthorizationCodeTokenResponse>(response.Content);
        }

        /// <summary>
        ///     Build the Scope string.
        /// </summary>
        /// <param name="scopes">Scopes</param>
        /// <returns>(string)</returns>
        public static string GetScopeString(List<Scope> scopes)
        {
            string joinedScopes = string.Empty;
            foreach (Scope s in scopes) joinedScopes += ScopeExtensions.GetScopeValue(s) + ' ';

            return joinedScopes.Trim();
        }
    }

    /// <summary>
    ///     OAuth2AuthorizationCodeParams
    /// </summary>
    public class OAuth2AuthorizationCodeParams
    {
        /// <summary>
        ///     OAuth2AuthorizationCodeParams
        /// </summary>
        public OAuth2AuthorizationCodeParams(string code, string state)
        {
            AuthorizationCode = code;
            State = state;
        }

        /// <summary>
        ///     Gets or Sets Code
        /// </summary>
        public string AuthorizationCode { get; set; }

        /// <summary>
        ///     Gets or Sets State
        /// </summary>
        public string State { get; set; }
    }

    /// <summary>
    ///     OAuth2AuthorizationCodeTokenResponse
    /// </summary>
    public class OAuth2AuthorizationCodeTokenResponse
    {
        /// <summary>
        ///     OAuth2AuthorizationCodeTokenResponse
        /// </summary>
        public OAuth2AuthorizationCodeTokenResponse(string tokenType, string accessToken, string refreshToken,
            int expiresIn)
        {
            TokenType = tokenType;
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            ExpiresIn = expiresIn;
        }

        /// <summary>
        ///     Gets or Sets TokenType
        /// </summary>
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        /// <summary>
        ///     Gets or Sets AccessToken
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        ///     Gets or Sets RefreshToken
        /// </summary>
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        ///     Gets or Sets ExpiresIn
        /// </summary>
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }
    }

    /// <summary>
    ///     OAuth2AuthorizationCodeError
    /// </summary>
    public class OAuth2AuthorizationCodeError : Exception
    {
        /// <summary>
        ///     OAuth2AuthorizationCodeError
        /// </summary>
        public OAuth2AuthorizationCodeError()
        {
        }

        /// <summary>
        ///     OAuth2AuthorizationCodeError
        /// </summary>
        public OAuth2AuthorizationCodeError(string message) : base(message)
        {
        }

        /// <summary>
        ///     OAuth2AuthorizationCodeError
        /// </summary>
        public OAuth2AuthorizationCodeError(string message, Exception inner)
            : base("An error occurred while retrieving token: " + message, inner)
        {
        }
    }
}