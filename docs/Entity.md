# It.FattureInCloud.Sdk.Model.Entity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier | [optional] 
**Code** | **string** | Supplier code. | [optional] 
**Name** | **string** | Supplier name. | [optional] 
**Type** | **string** | Supplier type. | [optional] 
**FirstName** | **string** | Supplier first name. | [optional] 
**LastName** | **string** | Supplier last name. | [optional] 
**ContactPerson** | **string** |  | [optional] 
**VatNumber** | **string** | Supplier vat number. | [optional] 
**TaxCode** | **string** | Supplier tax code. | [optional] 
**AddressStreet** | **string** | Supplier street address. | [optional] 
**AddressPostalCode** | **string** | Supplier postal code. | [optional] 
**AddressCity** | **string** | Supplier city. | [optional] 
**AddressProvince** | **string** | Supplier province. | [optional] 
**AddressExtra** | **string** | Supplier address extra info. | [optional] 
**Country** | **string** | Supplier country. | [optional] [default to "Italia"]
**Email** | **string** | Supplier email. | [optional] 
**CertifiedEmail** | **string** | Supplier certified email. | [optional] 
**Phone** | **string** | Supplier phone. | [optional] 
**Fax** | **string** | Supplier fax. | [optional] 
**Notes** | **string** | Supplier extra notes. | [optional] 
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
