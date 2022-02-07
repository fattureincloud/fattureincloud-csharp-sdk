# It.FattureInCloud.Sdk.Model.CashbookEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Cashbook unique identifier. | [optional] 
**Date** | **DateTimeOffset** | Cashbook date. | [optional] 
**Description** | **string** | Cashbook description. | [optional] 
**Kind** | **CashbookEntryKind** |  | [optional] 
**Type** | **CashbookEntryType** |  | [optional] 
**EntityName** | **string** | Entity name. | [optional] 
**Document** | [**CashbookEntryDocument**](CashbookEntryDocument.md) |  | [optional] 
**AmountIn** | **decimal?** | [Only for cashbook entry in] Total amount in. | [optional] 
**PaymentAccountIn** | [**PaymentAccount**](PaymentAccount.md) |  | [optional] 
**AmountOut** | **decimal?** | [Only for cashbook entry out] Total amount out. | [optional] 
**PaymentAccountOut** | [**PaymentAccount**](PaymentAccount.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

