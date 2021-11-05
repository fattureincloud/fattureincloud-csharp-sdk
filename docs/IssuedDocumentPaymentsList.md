# It.FattureInCloud.Sdk.Model.IssuedDocumentPaymentsList

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DueDate** | **DateTimeOffset** | Due date. | [optional] 
**Amount** | **decimal** | Payment amount. | [optional] 
**Status** | **string** | Payment status. | [optional] [default to StatusEnum.NotPaid]
**PaymentAccount** | [**PaymentAccount**](PaymentAccount.md) |  | [optional] 
**PaidDate** | **DateTimeOffset** | Payment date. [Only if status is paid] | [optional] 
**EiRaw** | **Object** | Advanced raw attributes for e-invoices. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
