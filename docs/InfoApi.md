# It.FattureInCloud.Sdk.Api.InfoApi

All URIs are relative to *https://api-v2.fattureincloud.it*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListArchiveCategories**](InfoApi.md#listarchivecategories) | **GET** /c/{company_id}/info/archive_categories | List Archive Categories |
| [**ListCities**](InfoApi.md#listcities) | **GET** /info/cities | List Cities |
| [**ListCostCenters**](InfoApi.md#listcostcenters) | **GET** /c/{company_id}/info/cost_centers | List Cost Centers |
| [**ListCountries**](InfoApi.md#listcountries) | **GET** /info/countries | List Countries |
| [**ListCurrencies**](InfoApi.md#listcurrencies) | **GET** /info/currencies | List Currencies |
| [**ListDeliveryNotesDefaultCausals**](InfoApi.md#listdeliverynotesdefaultcausals) | **GET** /info/dn_causals | List Delivery Notes Default Causals |
| [**ListDetailedCountries**](InfoApi.md#listdetailedcountries) | **GET** /info/detailed_countries | List Detailed Countries |
| [**ListLanguages**](InfoApi.md#listlanguages) | **GET** /info/languages | List Languages |
| [**ListPaymentAccounts**](InfoApi.md#listpaymentaccounts) | **GET** /c/{company_id}/info/payment_accounts | List Payment Accounts |
| [**ListPaymentMethods**](InfoApi.md#listpaymentmethods) | **GET** /c/{company_id}/info/payment_methods | List Payment Methods |
| [**ListProductCategories**](InfoApi.md#listproductcategories) | **GET** /c/{company_id}/info/product_categories | List Product Categories |
| [**ListReceivedDocumentCategories**](InfoApi.md#listreceiveddocumentcategories) | **GET** /c/{company_id}/info/received_document_categories | List Received Document Categories |
| [**ListRevenueCenters**](InfoApi.md#listrevenuecenters) | **GET** /c/{company_id}/info/revenue_centers | List Revenue Centers |
| [**ListTemplates**](InfoApi.md#listtemplates) | **GET** /info/templates | List Templates |
| [**ListUnitsOfMeasure**](InfoApi.md#listunitsofmeasure) | **GET** /info/measures | List Units of Measure |
| [**ListVatTypes**](InfoApi.md#listvattypes) | **GET** /c/{company_id}/info/vat_types | List Vat Types |

<a id="listarchivecategories"></a>
# **ListArchiveCategories**
> ListArchiveCategoriesResponse ListArchiveCategories (int companyId)

List Archive Categories

Lists the archive categories.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListArchiveCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InfoApi(config);
            var companyId = 12345;  // int | The ID of the company.

            try
            {
                // List Archive Categories
                ListArchiveCategoriesResponse result = apiInstance.ListArchiveCategories(companyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.ListArchiveCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListArchiveCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Archive Categories
    ApiResponse<ListArchiveCategoriesResponse> response = apiInstance.ListArchiveCategoriesWithHttpInfo(companyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.ListArchiveCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |

### Return type

[**ListArchiveCategoriesResponse**](ListArchiveCategoriesResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Archive Categories list. |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcities"></a>
# **ListCities**
> ListCitiesResponse ListCities (string postalCode = null, string city = null)

List Cities

Lists the Italian cities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListCitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InfoApi(config);
            var postalCode = "postalCode_example";  // string | Postal code for filtering. (optional) 
            var city = "city_example";  // string | City for filtering (ignored if postal_code is passed). (optional) 

            try
            {
                // List Cities
                ListCitiesResponse result = apiInstance.ListCities(postalCode, city);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.ListCities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Cities
    ApiResponse<ListCitiesResponse> response = apiInstance.ListCitiesWithHttpInfo(postalCode, city);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.ListCitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postalCode** | **string** | Postal code for filtering. | [optional]  |
| **city** | **string** | City for filtering (ignored if postal_code is passed). | [optional]  |

### Return type

[**ListCitiesResponse**](ListCitiesResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Cities List. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcostcenters"></a>
# **ListCostCenters**
> ListCostCentersResponse ListCostCenters (int companyId)

List Cost Centers

Lists the cost centers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListCostCentersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InfoApi(config);
            var companyId = 12345;  // int | The ID of the company.

            try
            {
                // List Cost Centers
                ListCostCentersResponse result = apiInstance.ListCostCenters(companyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.ListCostCenters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCostCentersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Cost Centers
    ApiResponse<ListCostCentersResponse> response = apiInstance.ListCostCentersWithHttpInfo(companyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.ListCostCentersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |

### Return type

[**ListCostCentersResponse**](ListCostCentersResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Cost Centers |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcountries"></a>
# **ListCountries**
> ListCountriesResponse ListCountries ()

List Countries

Lists the supported countries.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListCountriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InfoApi(config);

            try
            {
                // List Countries
                ListCountriesResponse result = apiInstance.ListCountries();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.ListCountries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCountriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Countries
    ApiResponse<ListCountriesResponse> response = apiInstance.ListCountriesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.ListCountriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ListCountriesResponse**](ListCountriesResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of countries |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcurrencies"></a>
# **ListCurrencies**
> ListCurrenciesResponse ListCurrencies ()

List Currencies

Lists the supported currencies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListCurrenciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InfoApi(config);

            try
            {
                // List Currencies
                ListCurrenciesResponse result = apiInstance.ListCurrencies();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.ListCurrencies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCurrenciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Currencies
    ApiResponse<ListCurrenciesResponse> response = apiInstance.ListCurrenciesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.ListCurrenciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ListCurrenciesResponse**](ListCurrenciesResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Currencies List. |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listdeliverynotesdefaultcausals"></a>
# **ListDeliveryNotesDefaultCausals**
> ListDeliveryNotesDefaultCausalsResponse ListDeliveryNotesDefaultCausals ()

List Delivery Notes Default Causals

Lists the delivery note default causals.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListDeliveryNotesDefaultCausalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InfoApi(config);

            try
            {
                // List Delivery Notes Default Causals
                ListDeliveryNotesDefaultCausalsResponse result = apiInstance.ListDeliveryNotesDefaultCausals();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.ListDeliveryNotesDefaultCausals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDeliveryNotesDefaultCausalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Delivery Notes Default Causals
    ApiResponse<ListDeliveryNotesDefaultCausalsResponse> response = apiInstance.ListDeliveryNotesDefaultCausalsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.ListDeliveryNotesDefaultCausalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ListDeliveryNotesDefaultCausalsResponse**](ListDeliveryNotesDefaultCausalsResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Delivery Notes Default Causals |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listdetailedcountries"></a>
# **ListDetailedCountries**
> ListDetailedCountriesResponse ListDetailedCountries ()

List Detailed Countries

Lists the supported countries.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListDetailedCountriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InfoApi(config);

            try
            {
                // List Detailed Countries
                ListDetailedCountriesResponse result = apiInstance.ListDetailedCountries();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.ListDetailedCountries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDetailedCountriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Detailed Countries
    ApiResponse<ListDetailedCountriesResponse> response = apiInstance.ListDetailedCountriesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.ListDetailedCountriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ListDetailedCountriesResponse**](ListDetailedCountriesResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of detailed countries |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listlanguages"></a>
# **ListLanguages**
> ListLanguagesResponse ListLanguages ()

List Languages

Lists the supported languages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListLanguagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InfoApi(config);

            try
            {
                // List Languages
                ListLanguagesResponse result = apiInstance.ListLanguages();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.ListLanguages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListLanguagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Languages
    ApiResponse<ListLanguagesResponse> response = apiInstance.ListLanguagesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.ListLanguagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ListLanguagesResponse**](ListLanguagesResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | LanguagesList |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listpaymentaccounts"></a>
# **ListPaymentAccounts**
> ListPaymentAccountsResponse ListPaymentAccounts (int companyId, string fields = null, string fieldset = null, string sort = null)

List Payment Accounts

Lists the available payment accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListPaymentAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InfoApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var fields = "fields_example";  // string | List of comma-separated fields. (optional) 
            var fieldset = "basic";  // string | Name of the fieldset. (optional) 
            var sort = "sort_example";  // string | List of comma-separated fields for result sorting (minus for desc sorting). (optional) 

            try
            {
                // List Payment Accounts
                ListPaymentAccountsResponse result = apiInstance.ListPaymentAccounts(companyId, fields, fieldset, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.ListPaymentAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPaymentAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Payment Accounts
    ApiResponse<ListPaymentAccountsResponse> response = apiInstance.ListPaymentAccountsWithHttpInfo(companyId, fields, fieldset, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.ListPaymentAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **fields** | **string** | List of comma-separated fields. | [optional]  |
| **fieldset** | **string** | Name of the fieldset. | [optional]  |
| **sort** | **string** | List of comma-separated fields for result sorting (minus for desc sorting). | [optional]  |

### Return type

[**ListPaymentAccountsResponse**](ListPaymentAccountsResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Payment accounts list. |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listpaymentmethods"></a>
# **ListPaymentMethods**
> ListPaymentMethodsResponse ListPaymentMethods (int companyId, string fields = null, string fieldset = null, string sort = null)

List Payment Methods

Lists the available payment methods.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListPaymentMethodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InfoApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var fields = "fields_example";  // string | List of comma-separated fields. (optional) 
            var fieldset = "basic";  // string | Name of the fieldset. (optional) 
            var sort = "sort_example";  // string | List of comma-separated fields for result sorting (minus for desc sorting). (optional) 

            try
            {
                // List Payment Methods
                ListPaymentMethodsResponse result = apiInstance.ListPaymentMethods(companyId, fields, fieldset, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.ListPaymentMethods: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPaymentMethodsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Payment Methods
    ApiResponse<ListPaymentMethodsResponse> response = apiInstance.ListPaymentMethodsWithHttpInfo(companyId, fields, fieldset, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.ListPaymentMethodsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **fields** | **string** | List of comma-separated fields. | [optional]  |
| **fieldset** | **string** | Name of the fieldset. | [optional]  |
| **sort** | **string** | List of comma-separated fields for result sorting (minus for desc sorting). | [optional]  |

### Return type

[**ListPaymentMethodsResponse**](ListPaymentMethodsResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Payment methods list. |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listproductcategories"></a>
# **ListProductCategories**
> ListProductCategoriesResponse ListProductCategories (int companyId, string context)

List Product Categories

Lists the product categories.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListProductCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InfoApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var context = "products";  // string | Categories resource type.

            try
            {
                // List Product Categories
                ListProductCategoriesResponse result = apiInstance.ListProductCategories(companyId, context);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.ListProductCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProductCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Product Categories
    ApiResponse<ListProductCategoriesResponse> response = apiInstance.ListProductCategoriesWithHttpInfo(companyId, context);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.ListProductCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **context** | **string** | Categories resource type. |  |

### Return type

[**ListProductCategoriesResponse**](ListProductCategoriesResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Product Categories List |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listreceiveddocumentcategories"></a>
# **ListReceivedDocumentCategories**
> ListReceivedDocumentCategoriesResponse ListReceivedDocumentCategories (int companyId)

List Received Document Categories

Lists the received document categories.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListReceivedDocumentCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InfoApi(config);
            var companyId = 12345;  // int | The ID of the company.

            try
            {
                // List Received Document Categories
                ListReceivedDocumentCategoriesResponse result = apiInstance.ListReceivedDocumentCategories(companyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.ListReceivedDocumentCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListReceivedDocumentCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Received Document Categories
    ApiResponse<ListReceivedDocumentCategoriesResponse> response = apiInstance.ListReceivedDocumentCategoriesWithHttpInfo(companyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.ListReceivedDocumentCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |

### Return type

[**ListReceivedDocumentCategoriesResponse**](ListReceivedDocumentCategoriesResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Received Document Categories List |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listrevenuecenters"></a>
# **ListRevenueCenters**
> ListRevenueCentersResponse ListRevenueCenters (int companyId)

List Revenue Centers

Lists the revenue centers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListRevenueCentersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InfoApi(config);
            var companyId = 12345;  // int | The ID of the company.

            try
            {
                // List Revenue Centers
                ListRevenueCentersResponse result = apiInstance.ListRevenueCenters(companyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.ListRevenueCenters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRevenueCentersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Revenue Centers
    ApiResponse<ListRevenueCentersResponse> response = apiInstance.ListRevenueCentersWithHttpInfo(companyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.ListRevenueCentersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |

### Return type

[**ListRevenueCentersResponse**](ListRevenueCentersResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Revenue Centers |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listtemplates"></a>
# **ListTemplates**
> ListTemplatesResponse ListTemplates (string type = null, bool? byType = null)

List Templates

Lists the available templates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InfoApi(config);
            var type = "all";  // string | Type of the templates. (optional)  (default to all)
            var byType = false;  // bool? | [Only if type=all] If true, splits the list in objects, grouping templates by type. (optional)  (default to false)

            try
            {
                // List Templates
                ListTemplatesResponse result = apiInstance.ListTemplates(type, byType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.ListTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Templates
    ApiResponse<ListTemplatesResponse> response = apiInstance.ListTemplatesWithHttpInfo(type, byType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.ListTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **string** | Type of the templates. | [optional] [default to all] |
| **byType** | **bool?** | [Only if type&#x3D;all] If true, splits the list in objects, grouping templates by type. | [optional] [default to false] |

### Return type

[**ListTemplatesResponse**](ListTemplatesResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Templates list. |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listunitsofmeasure"></a>
# **ListUnitsOfMeasure**
> ListUnitsOfMeasureResponse ListUnitsOfMeasure ()

List Units of Measure

Lists the units of measure.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListUnitsOfMeasureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InfoApi(config);

            try
            {
                // List Units of Measure
                ListUnitsOfMeasureResponse result = apiInstance.ListUnitsOfMeasure();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.ListUnitsOfMeasure: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListUnitsOfMeasureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Units of Measure
    ApiResponse<ListUnitsOfMeasureResponse> response = apiInstance.ListUnitsOfMeasureWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.ListUnitsOfMeasureWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ListUnitsOfMeasureResponse**](ListUnitsOfMeasureResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Units of measure. |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listvattypes"></a>
# **ListVatTypes**
> ListVatTypesResponse ListVatTypes (int companyId, string fieldset = null)

List Vat Types

Lists the available vat types.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListVatTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InfoApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var fieldset = "basic";  // string | Name of the fieldset. (optional) 

            try
            {
                // List Vat Types
                ListVatTypesResponse result = apiInstance.ListVatTypes(companyId, fieldset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.ListVatTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListVatTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Vat Types
    ApiResponse<ListVatTypesResponse> response = apiInstance.ListVatTypesWithHttpInfo(companyId, fieldset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.ListVatTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **fieldset** | **string** | Name of the fieldset. | [optional]  |

### Return type

[**ListVatTypesResponse**](ListVatTypesResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Vat Types. |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

