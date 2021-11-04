# It.FattureInCloud.Sdk.Model.ModelClient
Client.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier | [optional] 
**Code** | **string** | Client code. | [optional] 
**Name** | **string** | Client name | [optional] 
**Type** | **string** | Client type | [optional] 
**FirstName** | **string** | Client first name. | [optional] 
**LastName** | **string** | Client last name. | [optional] 
**ContactPerson** | **string** |  | [optional] 
**VatNumber** | **string** | Client vat number | [optional] 
**TaxCode** | **string** | Client tax code. | [optional] 
**AddressStreet** | **string** | Client street address. | [optional] 
**AddressPostalCode** | **string** | Client postal code. | [optional] 
**AddressCity** | **string** | Client city. | [optional] 
**AddressProvince** | **string** | Client province. | [optional] 
**AddressExtra** | **string** | Client address extra info. | [optional] 
**Country** | **string** | Client country | [optional] [default to "Italia"]
**Email** | **string** | Client email. | [optional] 
**CertifiedEmail** | **string** | Client certified email. | [optional] 
**Phone** | **string** | Client phone. | [optional] 
**Fax** | **string** | Client fax. | [optional] 
**Notes** | **string** | Extra notes. | [optional] 
**DefaultVat** | [**VatType**](VatType.md) |  | [optional] 
**DefaultPaymentTerms** | **int** |  | [optional] 
**DefaultPaymentTermsType** | **string** |  | [optional] [default to DefaultPaymentTermsTypeEnum.Standard]
**DefaultPaymentMethod** | [**PaymentMethod**](PaymentMethod.md) |  | [optional] 
**BankName** | **string** | Client bank name. | [optional] 
**BankIban** | **string** | Client iban. | [optional] 
**BankSwiftCode** | **string** | Client bank swift code. | [optional] 
**ShippingAddress** | **string** | Client shipping address. | [optional] 
**EInvoice** | **bool** | Use e-invoices for this entity | [optional] [default to false]
**EiCode** | **string** | E-invoice code | [optional] 
**CreatedAt** | **string** |  | [optional] 
**UpdatedAt** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
