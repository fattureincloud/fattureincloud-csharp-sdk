# It.FattureInCloud.Sdk.Api.ClientsApi

All URIs are relative to *https://api-v2.fattureincloud.it*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateClient**](ClientsApi.md#createclient) | **POST** /c/{company_id}/entities/clients | Create Client
[**DeleteClient**](ClientsApi.md#deleteclient) | **DELETE** /c/{company_id}/entities/clients/{client_id} | Delete Client
[**GetClient**](ClientsApi.md#getclient) | **GET** /c/{company_id}/entities/clients/{client_id} | Get Client
[**ListClients**](ClientsApi.md#listclients) | **GET** /c/{company_id}/entities/clients | List Clients
[**ModifyClient**](ClientsApi.md#modifyclient) | **PUT** /c/{company_id}/entities/clients/{client_id} | Modify Client


<a name="createclient"></a>
# **CreateClient**
> CreateClientResponse CreateClient (int companyId, CreateClientRequest createClientRequest = null)

Create Client

Creates a new client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class CreateClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClientsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var createClientRequest = new CreateClientRequest(); // CreateClientRequest | The client to create (optional) 

            try
            {
                // Create Client
                CreateClientResponse result = apiInstance.CreateClient(companyId, createClientRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.CreateClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **int**| The ID of the company. | 
 **createClientRequest** | [**CreateClientRequest**](CreateClientRequest.md)| The client to create | [optional] 

### Return type

[**CreateClientResponse**](CreateClientResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Example response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteclient"></a>
# **DeleteClient**
> void DeleteClient (int companyId, int clientId)

Delete Client

Deletes the specified client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class DeleteClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClientsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var clientId = 56;  // int | The ID of the client.

            try
            {
                // Delete Client
                apiInstance.DeleteClient(companyId, clientId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.DeleteClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **int**| The ID of the company. | 
 **clientId** | **int**| The ID of the client. | 

### Return type

void (empty response body)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Entity Removed |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclient"></a>
# **GetClient**
> GetClientResponse GetClient (int companyId, int clientId, string fields = null, string fieldset = null)

Get Client

Gets the specified client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClientsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var clientId = 56;  // int | The ID of the client.
            var fields = fields_example;  // string | List of comma-separated fields. (optional) 
            var fieldset = fieldset_example;  // string | Name of the fieldset. (optional) 

            try
            {
                // Get Client
                GetClientResponse result = apiInstance.GetClient(companyId, clientId, fields, fieldset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.GetClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **int**| The ID of the company. | 
 **clientId** | **int**| The ID of the client. | 
 **fields** | **string**| List of comma-separated fields. | [optional] 
 **fieldset** | **string**| Name of the fieldset. | [optional] 

### Return type

[**GetClientResponse**](GetClientResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Client Details. |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listclients"></a>
# **ListClients**
> ListClientsResponse ListClients (int companyId, string fields = null, string fieldset = null, string sort = null, int? page = null, int? perPage = null)

List Clients

Lists the clients.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListClientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClientsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var fields = fields_example;  // string | List of comma-separated fields. (optional) 
            var fieldset = fieldset_example;  // string | Name of the fieldset. (optional) 
            var sort = sort_example;  // string | List of comma-separated fields for result sorting (minus for desc sorting). (optional) 
            var page = 56;  // int? | The page to retrieve. (optional)  (default to 1)
            var perPage = 56;  // int? | The size of the page. (optional)  (default to 5)

            try
            {
                // List Clients
                ListClientsResponse result = apiInstance.ListClients(companyId, fields, fieldset, sort, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.ListClients: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **int**| The ID of the company. | 
 **fields** | **string**| List of comma-separated fields. | [optional] 
 **fieldset** | **string**| Name of the fieldset. | [optional] 
 **sort** | **string**| List of comma-separated fields for result sorting (minus for desc sorting). | [optional] 
 **page** | **int?**| The page to retrieve. | [optional] [default to 1]
 **perPage** | **int?**| The size of the page. | [optional] [default to 5]

### Return type

[**ListClientsResponse**](ListClientsResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Example response |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modifyclient"></a>
# **ModifyClient**
> ModifyClientResponse ModifyClient (int companyId, int clientId, ModifyClientRequest modifyClientRequest = null)

Modify Client

Modifies the specified client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ModifyClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClientsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var clientId = 56;  // int | The ID of the client.
            var modifyClientRequest = new ModifyClientRequest(); // ModifyClientRequest | The modified Client. First level parameters are managed in delta mode. (optional) 

            try
            {
                // Modify Client
                ModifyClientResponse result = apiInstance.ModifyClient(companyId, clientId, modifyClientRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.ModifyClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **int**| The ID of the company. | 
 **clientId** | **int**| The ID of the client. | 
 **modifyClientRequest** | [**ModifyClientRequest**](ModifyClientRequest.md)| The modified Client. First level parameters are managed in delta mode. | [optional] 

### Return type

[**ModifyClientResponse**](ModifyClientResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Client modified. |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
