# It.FattureInCloud.Sdk.Model.CompanyInfo
Detailed information for the company.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Company unique identifier. | [optional] 
**Name** | **string** | Company name. | [optional] 
**Email** | **string** | Company email. | [optional] 
**Type** | **string** | Company type. | [optional] 
**Fic** | **bool** | Determine if the company has a FIC account. | [optional] 
**FicPlanName** | **string** | Company FIC account plan. | [optional] 
**FicLicenseType** | **string** | Company FIC account plan.  | [optional] 
**FicPaymentSubject** | **string** | Company FIC account payment subject. | [optional] 
**FicLicenseExpire** | **DateTime?** | Company FIC license expiration date. | [optional] 
**FicSignupDate** | **string** | FIC account sign up date. | [optional] 
**UseFic** | **bool** | Determine if the FIC account is actually used. If type&#x3D;\&quot;company\&quot; this is always true; if type&#x3D;\&quot;accountant\&quot; it can be true or false. If false, it means that the accountant uses FIC only to control other companies and not to control itself. | [optional] 
**FicNeedSetup** | **bool** | Indicate that the initial setup for FIC is required. | [optional] 
**Dic** | **bool** | Determine if the company has a DIC account. | [optional] 
**DicPlan** | **string** | Company DIC account plan. | [optional] 
**DicLicenseExpire** | **DateTime?** | Company FIC license expiration date. | [optional] 
**UseDic** | **bool** | Determine if the DIC account is actually used. If type&#x3D;“company” this is always true; if type&#x3D;“accountant” it can be true or false. If false, it means that the accountant uses DIC only to control other companies and not to control itself. | [optional] 
**DicNeedSetup** | **bool** | Indicate that the initial setup for DIC is required. | [optional] 
**AccessInfo** | [**CompanyInfoAccessInfo**](CompanyInfoAccessInfo.md) |  | [optional] 
**PlanInfo** | [**CompanyInfoPlanInfo**](CompanyInfoPlanInfo.md) |  | [optional] 
**CanUseCoupon** | **bool** | Determine if a coupon can be used. | [optional] 
**AccountantId** | **int?** | Accountant unique identifier. | [optional] 
**DicLicenseType** | **string** | Company DIC account license type. | [optional] 
**DicPaymentSubject** | **string** | Company DIC account payment subject. | [optional] 
**DicPlanName** | **string** | Company DIC account plan name. | [optional] 
**DicSignupDate** | **string** | DIC account sign up date. | [optional] 
**IsAccountant** | **bool** | Determine if the logged account is an accountant. | [optional] 
**RegistrationService** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

