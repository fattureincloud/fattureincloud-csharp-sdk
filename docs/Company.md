# It.FattureInCloud.Sdk.Model.Company
Description of a company.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Company unique identifier. | [optional] 
**Name** | **string** | Company name. | [optional] 
**Type** | **string** | Company type. | [optional] 
**AccessToken** | **string** | CompanyAuthentication token for this company. [Only if type&#x3D;company] | [optional] 
**Permissions** | [**Permissions**](Permissions.md) |  | [optional] 
**ControlledCompanies** | [**List&lt;Company&gt;**](Company.md) | List of controlled companies. [Only if type&#x3D;accountant] | [optional] 
**ConnectionId** | **decimal** | Company connection id. | [optional] 
**Dic** | **bool** | Determine if the company has a DIC account. | [optional] 
**Fic** | **bool** | Determine if the company has a FIC account. | [optional] 
**FicLicenseExpire** | **DateTimeOffset** | Company FIC license expiration date. | [optional] 
**FicPlan** | **string** | Company FIC account plan. | [optional] 
**TaxCode** | **string** | Tax code. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

