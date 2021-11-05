# It.FattureInCloud.Sdk.Model.Receipt
Receipt

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **decimal** | Receipt unique identifier. | [optional] 
**Date** | **DateTimeOffset** | Receipt date. | [optional] 
**Number** | **decimal?** | Receipt number. | [optional] 
**Numeration** | **string** | If it&#39;s null or empty string use the default numeration. | [optional] 
**AmountNet** | **decimal** | Total net amount. | [optional] 
**AmountVat** | **decimal** | Total vat amount. | [optional] 
**AmountGross** | **decimal** | Total gross amount. | [optional] 
**UseGrossPrices** | **bool** |  | [optional] [default to false]
**Type** | **ReceiptType** |  | [optional] 
**Description** | **string** | Receipt description. | [optional] 
**RcCenter** | **string** | Revenue center. | [optional] 
**CreatedAt** | **string** |  | [optional] 
**UpdatedAt** | **string** |  | [optional] 
**PaymentAccount** | [**PaymentAccount**](PaymentAccount.md) |  | [optional] 
**ItemsList** | [**List&lt;ReceiptItemsListItem&gt;**](ReceiptItemsListItem.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

