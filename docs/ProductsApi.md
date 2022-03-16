# It.FattureInCloud.Sdk.Api.ProductsApi

All URIs are relative to *https://api-v2.fattureincloud.it*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProduct**](ProductsApi.md#createproduct) | **POST** /c/{company_id}/products | Create Product
[**DeleteProduct**](ProductsApi.md#deleteproduct) | **DELETE** /c/{company_id}/products/{product_id} | Delete Product
[**GetProduct**](ProductsApi.md#getproduct) | **GET** /c/{company_id}/products/{product_id} | Get Product
[**ListProducts**](ProductsApi.md#listproducts) | **GET** /c/{company_id}/products | List Products
[**ModifyProduct**](ProductsApi.md#modifyproduct) | **PUT** /c/{company_id}/products/{product_id} | Modify Product


<a name="createproduct"></a>
# **CreateProduct**
> CreateProductResponse CreateProduct (int companyId, CreateProductRequest createProductRequest = null)

Create Product

Creates a new product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class CreateProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var createProductRequest = new CreateProductRequest(); // CreateProductRequest |  (optional) 

            try
            {
                // Create Product
                CreateProductResponse result = apiInstance.CreateProduct(companyId, createProductRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.CreateProduct: " + e.Message );
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
 **createProductRequest** | [**CreateProductRequest**](CreateProductRequest.md)|  | [optional] 

### Return type

[**CreateProductResponse**](CreateProductResponse.md)

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

<a name="deleteproduct"></a>
# **DeleteProduct**
> void DeleteProduct (int companyId, int productId)

Delete Product

Deletes the specified product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class DeleteProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var productId = 56;  // int | The ID of the product.

            try
            {
                // Delete Product
                apiInstance.DeleteProduct(companyId, productId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.DeleteProduct: " + e.Message );
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
 **productId** | **int**| The ID of the product. | 

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
| **200** | Product removed. |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproduct"></a>
# **GetProduct**
> GetProductResponse GetProduct (int companyId, int productId, string fields = null, string fieldset = null)

Get Product

Gets the specified product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var productId = 56;  // int | The ID of the product.
            var fields = "fields_example";  // string | List of comma-separated fields. (optional) 
            var fieldset = "basic";  // string | Name of the fieldset. (optional) 

            try
            {
                // Get Product
                GetProductResponse result = apiInstance.GetProduct(companyId, productId, fields, fieldset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProduct: " + e.Message );
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
 **productId** | **int**| The ID of the product. | 
 **fields** | **string**| List of comma-separated fields. | [optional] 
 **fieldset** | **string**| Name of the fieldset. | [optional] 

### Return type

[**GetProductResponse**](GetProductResponse.md)

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

<a name="listproducts"></a>
# **ListProducts**
> ListProductsResponse ListProducts (int companyId, string fields = null, string fieldset = null, string sort = null, int? page = null, int? perPage = null, string q = null)

List Products

Lists the products.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListProductsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var fields = "fields_example";  // string | List of comma-separated fields. (optional) 
            var fieldset = "basic";  // string | Name of the fieldset. (optional) 
            var sort = "sort_example";  // string | List of comma-separated fields for result sorting (minus for desc sorting). (optional) 
            var page = 1;  // int? | The page to retrieve. (optional)  (default to 1)
            var perPage = 5;  // int? | The size of the page. (optional)  (default to 5)
            var q = "q_example";  // string | Query for filtering the results. (optional) 

            try
            {
                // List Products
                ListProductsResponse result = apiInstance.ListProducts(companyId, fields, fieldset, sort, page, perPage, q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.ListProducts: " + e.Message );
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

[**ListProductsResponse**](ListProductsResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Products List. |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modifyproduct"></a>
# **ModifyProduct**
> ModifyProductResponse ModifyProduct (int companyId, int productId, ModifyProductRequest modifyProductRequest = null)

Modify Product

Modifies the specified product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ModifyProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var productId = 56;  // int | The ID of the product.
            var modifyProductRequest = new ModifyProductRequest(); // ModifyProductRequest | Modified product details. (optional) 

            try
            {
                // Modify Product
                ModifyProductResponse result = apiInstance.ModifyProduct(companyId, productId, modifyProductRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.ModifyProduct: " + e.Message );
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
 **productId** | **int**| The ID of the product. | 
 **modifyProductRequest** | [**ModifyProductRequest**](ModifyProductRequest.md)| Modified product details. | [optional] 

### Return type

[**ModifyProductResponse**](ModifyProductResponse.md)

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

