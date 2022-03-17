# It.FattureInCloud.Sdk.Api.SuppliersApi

All URIs are relative to *https://api-v2.fattureincloud.it*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSupplier**](SuppliersApi.md#createsupplier) | **POST** /c/{company_id}/entities/suppliers | Create Supplier
[**DeleteSupplier**](SuppliersApi.md#deletesupplier) | **DELETE** /c/{company_id}/entities/suppliers/{supplier_id} | Delete Supplier
[**GetSupplier**](SuppliersApi.md#getsupplier) | **GET** /c/{company_id}/entities/suppliers/{supplier_id} | Get Supplier
[**ListSuppliers**](SuppliersApi.md#listsuppliers) | **GET** /c/{company_id}/entities/suppliers | List Suppliers
[**ModifySupplier**](SuppliersApi.md#modifysupplier) | **PUT** /c/{company_id}/entities/suppliers/{supplier_id} | Modify Supplier


<a name="createsupplier"></a>
# **CreateSupplier**
> CreateSupplierResponse CreateSupplier (int companyId, CreateSupplierRequest createSupplierRequest = null)

Create Supplier

Creates a new supplier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class CreateSupplierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SuppliersApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var createSupplierRequest = new CreateSupplierRequest(); // CreateSupplierRequest | The supplier to create (optional) 

            try
            {
                // Create Supplier
                CreateSupplierResponse result = apiInstance.CreateSupplier(companyId, createSupplierRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppliersApi.CreateSupplier: " + e.Message );
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
 **createSupplierRequest** | [**CreateSupplierRequest**](CreateSupplierRequest.md)| The supplier to create | [optional] 

### Return type

[**CreateSupplierResponse**](CreateSupplierResponse.md)

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

<a name="deletesupplier"></a>
# **DeleteSupplier**
> void DeleteSupplier (int companyId, int supplierId)

Delete Supplier

Deletes the specified supplier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class DeleteSupplierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SuppliersApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var supplierId = 56;  // int | The ID of the supplier.

            try
            {
                // Delete Supplier
                apiInstance.DeleteSupplier(companyId, supplierId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppliersApi.DeleteSupplier: " + e.Message );
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
 **supplierId** | **int**| The ID of the supplier. | 

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

<a name="getsupplier"></a>
# **GetSupplier**
> GetSupplierResponse GetSupplier (int companyId, int supplierId, string fields = null, string fieldset = null)

Get Supplier

Gets the specified supplier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetSupplierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SuppliersApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var supplierId = 56;  // int | The ID of the supplier.
            var fields = "fields_example";  // string | List of comma-separated fields. (optional) 
            var fieldset = "basic";  // string | Name of the fieldset. (optional) 

            try
            {
                // Get Supplier
                GetSupplierResponse result = apiInstance.GetSupplier(companyId, supplierId, fields, fieldset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppliersApi.GetSupplier: " + e.Message );
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
 **supplierId** | **int**| The ID of the supplier. | 
 **fields** | **string**| List of comma-separated fields. | [optional] 
 **fieldset** | **string**| Name of the fieldset. | [optional] 

### Return type

[**GetSupplierResponse**](GetSupplierResponse.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsuppliers"></a>
# **ListSuppliers**
> ListSuppliersResponse ListSuppliers (int companyId, string fields = null, string fieldset = null, string sort = null, int? page = null, int? perPage = null, string q = null)

List Suppliers

Lists the suppliers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListSuppliersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SuppliersApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var fields = "fields_example";  // string | List of comma-separated fields. (optional) 
            var fieldset = "basic";  // string | Name of the fieldset. (optional) 
            var sort = "sort_example";  // string | List of comma-separated fields for result sorting (minus for desc sorting). (optional) 
            var page = 1;  // int? | The page to retrieve. (optional)  (default to 1)
            var perPage = 5;  // int? | The size of the page. (optional)  (default to 5)
            var q = "q_example";  // string | Query for filtering the results. (optional) 

            try
            {
                // List Suppliers
                ListSuppliersResponse result = apiInstance.ListSuppliers(companyId, fields, fieldset, sort, page, perPage, q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppliersApi.ListSuppliers: " + e.Message );
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
 **q** | **string**| Query for filtering the results. | [optional] 

### Return type

[**ListSuppliersResponse**](ListSuppliersResponse.md)

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

<a name="modifysupplier"></a>
# **ModifySupplier**
> ModifySupplierResponse ModifySupplier (int companyId, int supplierId, ModifySupplierRequest modifySupplierRequest = null)

Modify Supplier

Modifies the specified supplier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ModifySupplierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SuppliersApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var supplierId = 56;  // int | The ID of the supplier.
            var modifySupplierRequest = new ModifySupplierRequest(); // ModifySupplierRequest | The modified Supplier. First level parameters are managed in delta mode. (optional) 

            try
            {
                // Modify Supplier
                ModifySupplierResponse result = apiInstance.ModifySupplier(companyId, supplierId, modifySupplierRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppliersApi.ModifySupplier: " + e.Message );
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
 **supplierId** | **int**| The ID of the supplier. | 
 **modifySupplierRequest** | [**ModifySupplierRequest**](ModifySupplierRequest.md)| The modified Supplier. First level parameters are managed in delta mode. | [optional] 

### Return type

[**ModifySupplierResponse**](ModifySupplierResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Example response |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

