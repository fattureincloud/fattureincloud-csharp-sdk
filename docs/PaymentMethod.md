# It.FattureInCloud.Sdk.Model.PaymentMethod

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Unique identifier | [optional] 
**Name** | **string** | Name of the payment method | [optional] 
**Type** | **string** | Method type | [optional] [default to TypeEnum.Standard]
**IsDefault** | **bool** | Determines if this is the default payment method. | [optional] 
**DefaultPaymentAccount** | [**PaymentAccount**](PaymentAccount.md) |  | [optional] 
**Details** | [**List&lt;PaymentMethodDetails&gt;**](PaymentMethodDetails.md) | Method details rows | [optional] 
**BankIban** | **string** | Bank iban | [optional] 
**BankName** | **string** | Bank name | [optional] 
**BankBeneficiary** | **string** | Bank beneficiary | [optional] 
**EiPaymentMethod** | **string** | EInvoice payment method | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

