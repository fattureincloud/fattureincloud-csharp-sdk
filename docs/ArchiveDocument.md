# It.FattureInCloud.Sdk.Model.ArchiveDocument

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Archive document unique identifier. | [optional] 
**Date** | **DateTime?** | Archive document date. | [optional] 
**Description** | **string** | Archive Document description. | [optional] 
**AttachmentUrl** | **string** | [Temporary] [Read Only] Absolute url of the attached file. Authomatically set if a valid attachment token is passed via POST /archive or PUT /archive/{documentId}. | [optional] [readonly] 
**Category** | **string** | Archive document category. | [optional] 
**AttachmentToken** | **string** | [Write Only]  [Required] Attachment token returned by POST /archive/attachment. Used to attach the file already uploaded. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

