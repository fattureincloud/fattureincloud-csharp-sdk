# It.FattureInCloud.Sdk.Model.Company

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Company unique identifier. | [optional] 
**Name** | **string** | Company name. | [optional] 
**Type** | **CompanyType** |  | [optional] 
**AccessToken** | **string** | CompanyAuthentication token for this company. [Only if type&#x3D;company] | [optional] 
**ControlledCompanies** | [**List&lt;ControlledCompany&gt;**](ControlledCompany.md) | List of controlled companies. [Only if type&#x3D;accountant] | [optional] 
**ConnectionId** | **int?** | Company connection id. | [optional] 
**TaxCode** | **string** | Tax code. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

