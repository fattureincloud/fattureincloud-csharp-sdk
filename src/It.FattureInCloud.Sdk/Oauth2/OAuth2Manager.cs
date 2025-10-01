using System;
using System.Collections.Generic;
using System.Web;
using RestSharp;
using Newtonsoft.Json;

namespace It.FattureInCloud.Sdk.OauthHelper
{
    /// <summary>
    /// Oauth2 Manager
    /// </summary>
    public abstract class OAuth2Manager
    {
        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets BaseUri
        /// </summary>
        public string BaseUri { get; set; } = "https://api-v2.fattureincloud.it";

        /// <summary>
        /// Initialize a new instance of the Oauth2 class.
        /// </summary>
        /// <param name="clientId">Client Id</param>
        /// <param name="baseUri">Base Uri</param>
        public OAuth2Manager(string clientId, string baseUri = "https://api-v2.fattureincloud.it")
        {
            ClientId = clientId;
            BaseUri = baseUri;
        }

        /// <summary>
        /// Retrieve the access token.
        /// </summary>
        /// <param name="code">Code</param>
        /// <returns>(OAuth2TokenResponse)</returns>
        public abstract OAuth2TokenResponse FetchToken(string code);

        /// <summary>
        /// Refresh the access token.
        /// </summary>
        /// <param name="refreshToken">Refresh Token</param>
        /// <returns>(OAuth2TokenResponse)</returns>
        public abstract OAuth2TokenResponse RefreshToken(string refreshToken);

        /// <summary>
        /// Build the Scope string.
        /// </summary>
        /// <param name="scopes">Scopes</param>
        /// <returns>(string)</returns>
        public static string GetScopeString(List<Scope> scopes)
        {
            string joinedScopes = string.Empty;
            foreach (Scope s in scopes)
            {
                joinedScopes += ScopeExtensions.GetScopeValue(s) + ' ';
            }

            return joinedScopes.Trim();
        }
    }

    /// <summary>
    /// Oauth2 Authorization Code Manager
    /// </summary>
    public class OAuth2AuthorizationCodeManager : OAuth2Manager
    {
        /// <summary>
        /// Gets or Sets ClientSecret
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or Sets RedirectUri
        /// </summary>
        public string RedirectUri { get; set; }

        /// <summary>
        /// Initialize a new instance of the Oauth2 Authorization Code class.
        /// </summary>
        /// <param name="clientId">Client Id</param>
        /// <param name="clientSecret">Client Secret</param>
        /// <param name="redirectUri">Redirect Uri</param>
        /// <param name="baseUri">Base Uri</param>
        public OAuth2AuthorizationCodeManager(string clientId, string clientSecret, string redirectUri, string baseUri = "https://api-v2.fattureincloud.it") : base(clientId, baseUri)
        {
            ClientSecret = clientSecret;
            RedirectUri = redirectUri;
        }

        /// <summary>
        /// Get the authorization url.
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
        /// Get parameters from the url.
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
        /// Retrieve the access token.
        /// </summary>
        /// <param name="code">Code</param>
        /// <returns>(OAuth2TokenResponse)</returns>
        public override OAuth2TokenResponse FetchToken(string code)
        {
            string tokenUri = string.Format("{0}/oauth/token", BaseUri);
            var data = new
            {
                grant_type = "authorization_code",
                client_id = ClientId,
                client_secret = ClientSecret,
                redirect_uri = RedirectUri,
                code = code
            };

            var client = new RestClient(tokenUri);
            var request = new RestRequest();
            request.AddHeader("content-type", "application/json");
            request.AddJsonBody(data);
            var response = client.Post(request);
            if ((int)response.StatusCode != 200)
            {
                throw new OAuth2Error(response.Content);
            }
            ;

            return JsonConvert.DeserializeObject<OAuth2TokenResponse>(response.Content);
        }

        /// <summary>
        /// Refresh the access token.
        /// </summary>
        /// <param name="refreshToken">Refresh Token</param>
        /// <returns>(OAuth2TokenResponse)</returns>
        public override OAuth2TokenResponse RefreshToken(string refreshToken)
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
            var request = new RestRequest();
            request.AddHeader("content-type", "application/json");
            request.AddJsonBody(data);
            var response = client.Post(request);
            if ((int)response.StatusCode != 200)
            {
                throw new OAuth2Error(response.Content);
            }
            ;

            return JsonConvert.DeserializeObject<OAuth2TokenResponse>(response.Content);
        }
    }

    /// <summary>
    /// Oauth2 Device Code Manager
    /// </summary>
    public class OAuth2DeviceCodeManager : OAuth2Manager
    {

        /// <summary>
        /// Initialize a new instance of the Oauth2 Device Code class.
        /// </summary>
        /// <param name="clientId">Client Id</param>
        /// <param name="baseUri">Base Uri</param>
        public OAuth2DeviceCodeManager(string clientId, string baseUri = "https://api-v2.fattureincloud.it") : base(clientId, baseUri)
        {
        }

        /// <summary>
        /// Retrieve the device code.
        /// </summary>
        /// <param name="scopes">Scopes</param>
        /// <returns>(OAuth2DeviceCodeResponse)</returns>
        public OAuth2DeviceCodeResponse GetDeviceCode(List<Scope> scopes)
        {
            string tokenUri = string.Format("{0}/oauth/device", BaseUri);

            string scopesString = GetScopeString(scopes);

            var data = new
            {
                client_id = ClientId,
                scope = scopesString
            };

            var client = new RestClient(tokenUri);
            var request = new RestRequest();
            request.AddHeader("content-type", "application/json");
            request.AddJsonBody(data);
            var response = client.Post(request);
            if ((int)response.StatusCode != 200)
            {
                throw new OAuth2Error(response.Content);
            }
            ;
            var dataResponse = JsonConvert.DeserializeObject<OAuth2DeviceCodeRawResponse>(response.Content);

            return dataResponse.Data;
        }

        /// <summary>
        /// Retrieve the access token.
        /// </summary>
        /// <param name="code">Code</param>
        /// <returns>(OAuth2TokenResponse)</returns>
        public override OAuth2TokenResponse FetchToken(string code)
        {
            string tokenUri = string.Format("{0}/oauth/token", BaseUri);
            var data = new
            {
                grant_type = "urn:ietf:params:oauth:grant-type:device_code",
                client_id = ClientId,
                device_code = code
            };

            var client = new RestClient(tokenUri);
            var request = new RestRequest();
            request.AddHeader("content-type", "application/json");
            request.AddJsonBody(data);
            var response = client.Post(request);
            if ((int)response.StatusCode != 200)
            {
                throw new OAuth2Error(response.Content);
            }
            ;

            return JsonConvert.DeserializeObject<OAuth2TokenResponse>(response.Content);
        }

        /// <summary>
        /// Refresh the access token.
        /// </summary>
        /// <param name="refreshToken">Refresh Token</param>
        /// <returns>(OAuth2TokenResponse)</returns>
        public override OAuth2TokenResponse RefreshToken(string refreshToken)
        {
            string tokenUri = string.Format("{0}/oauth/token", BaseUri);
            var data = new
            {
                grant_type = "refresh_token",
                client_id = ClientId,
                refresh_token = refreshToken
            };

            var client = new RestClient(tokenUri);
            var request = new RestRequest();
            request.AddHeader("content-type", "application/json");
            request.AddJsonBody(data);
            var response = client.Post(request);
            if ((int)response.StatusCode != 200)
            {
                throw new OAuth2Error(response.Content);
            }
            ;

            return JsonConvert.DeserializeObject<OAuth2TokenResponse>(response.Content);
        }
    }

    /// <summary>
    /// OAuth2AuthorizationCodeParams
    /// </summary>
    public class OAuth2AuthorizationCodeParams
    {
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// OAuth2AuthorizationCodeParams
        /// </summary>
        public OAuth2AuthorizationCodeParams(string code, string state)
        {
            AuthorizationCode = code;
            State = state;
        }
    }

    /// <summary>
    /// OAuth2TokenResponse
    /// </summary>
    public class OAuth2TokenResponse
    {
        /// <summary>
        /// Gets or Sets TokenType
        /// </summary>
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets RefreshToken
        /// </summary>
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresIn
        /// </summary>
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// OAuth2TokenResponse
        /// </summary>
        public OAuth2TokenResponse(string tokenType, string accessToken, string refreshToken, int expiresIn)
        {
            TokenType = tokenType;
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            ExpiresIn = expiresIn;
        }
    }

    /// <summary>
    /// OAuth2DeviceCodeRawResponse
    /// </summary>
    public class OAuth2DeviceCodeRawResponse
    {

        /// <summary>
        /// Gets or Sets ExpiresIn
        /// </summary>
        [JsonProperty("data")]
        public OAuth2DeviceCodeResponse Data { get; set; }

        /// <summary>
        /// OAuth2DeviceCodeRawResponse
        /// </summary>
        public OAuth2DeviceCodeRawResponse(OAuth2DeviceCodeResponse data)
        {
            Data = data;
        }
    }

    /// <summary>
    /// OAuth2DeviceCodeResponse
    /// </summary>
    public class OAuth2DeviceCodeResponse
    {
        /// <summary>
        /// Gets or Sets Device Code
        /// </summary>
        [JsonProperty("device_code")]
        public string DeviceCode { get; set; }

        /// <summary>
        /// Gets or Sets UserCode
        /// </summary>
        [JsonProperty("user_code")]
        public string UserCode { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [JsonProperty("scope")]
        public Dictionary<string, string> Scope { get; set; }

        /// <summary>
        /// Gets or Sets VerificationUri
        /// </summary>
        [JsonProperty("verification_uri")]
        public string VerificationUri { get; set; }

        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [JsonProperty("interval")]
        public int Interval { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresIn
        /// </summary>
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// OAuth2DeviceCodeResponse
        /// </summary>
        public OAuth2DeviceCodeResponse(string deviceCode, string userCode, Dictionary<string, string> scope, string verificationUri, int interval, int expiresIn)
        {
            DeviceCode = deviceCode;
            UserCode = userCode;
            Scope = scope;
            VerificationUri = verificationUri;
            Interval = interval;
            ExpiresIn = expiresIn;
        }
    }

    /// <summary>
    /// OAuth2Error
    /// </summary>
    public class OAuth2Error : Exception
    {
        /// <summary>
        /// OAuth2Error
        /// </summary>
        public OAuth2Error()
        {
        }

        /// <summary>
        /// OAuth2Error
        /// </summary>
        public OAuth2Error(string message) : base(message)
        {
        }

        /// <summary>
        /// OAuth2Error
        /// </summary>
        public OAuth2Error(string message, Exception inner)
            : base("An error occurred while retrieving token: " + message, inner)
        {
        }
    }
}
