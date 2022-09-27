<a name='assembly'></a>
# GOOUploader

## Contents

- [GOOCSUploaderController](#T-GOOUploader-Controllers-GOOCSUploaderController 'GOOUploader.Controllers.GOOCSUploaderController')
  - [#ctor(logger)](#M-GOOUploader-Controllers-GOOCSUploaderController-#ctor-Microsoft-Extensions-Logging-ILogger{GOOUploader-Controllers-GOOCSUploaderController}- 'GOOUploader.Controllers.GOOCSUploaderController.#ctor(Microsoft.Extensions.Logging.ILogger{GOOUploader.Controllers.GOOCSUploaderController})')
  - [batchId](#F-GOOUploader-Controllers-GOOCSUploaderController-batchId 'GOOUploader.Controllers.GOOCSUploaderController.batchId')
  - [beeUri](#F-GOOUploader-Controllers-GOOCSUploaderController-beeUri 'GOOUploader.Controllers.GOOCSUploaderController.beeUri')
  - [version](#F-GOOUploader-Controllers-GOOCSUploaderController-version 'GOOUploader.Controllers.GOOCSUploaderController.version')
  - [GetGOOCS(hash)](#M-GOOUploader-Controllers-GOOCSUploaderController-GetGOOCS-System-String- 'GOOUploader.Controllers.GOOCSUploaderController.GetGOOCS(System.String)')
  - [PostGOOCS(cancelationStatement,swarmBatchId)](#M-GOOUploader-Controllers-GOOCSUploaderController-PostGOOCS-GOO_Model-CancelationStatement,System-String- 'GOOUploader.Controllers.GOOCSUploaderController.PostGOOCS(GOO_Model.CancelationStatement,System.String)')
  - [Put(textData)](#M-GOOUploader-Controllers-GOOCSUploaderController-Put-System-String- 'GOOUploader.Controllers.GOOCSUploaderController.Put(System.String)')
  - [UploadFileData(name,data,swarmBatchId)](#M-GOOUploader-Controllers-GOOCSUploaderController-UploadFileData-System-String,System-String,System-String- 'GOOUploader.Controllers.GOOCSUploaderController.UploadFileData(System.String,System.String,System.String)')

<a name='T-GOOUploader-Controllers-GOOCSUploaderController'></a>
## GOOCSUploaderController `type`

##### Namespace

GOOUploader.Controllers

##### Summary

Controller to upload / download data from Bee

<a name='M-GOOUploader-Controllers-GOOCSUploaderController-#ctor-Microsoft-Extensions-Logging-ILogger{GOOUploader-Controllers-GOOCSUploaderController}-'></a>
### #ctor(logger) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Microsoft.Extensions.Logging.ILogger{GOOUploader.Controllers.GOOCSUploaderController}](#T-Microsoft-Extensions-Logging-ILogger{GOOUploader-Controllers-GOOCSUploaderController} 'Microsoft.Extensions.Logging.ILogger{GOOUploader.Controllers.GOOCSUploaderController}') |  |

<a name='F-GOOUploader-Controllers-GOOCSUploaderController-batchId'></a>
### batchId `constants`

##### Summary

Development swarm batchId

<a name='F-GOOUploader-Controllers-GOOCSUploaderController-beeUri'></a>
### beeUri `constants`

##### Summary

Specify bee location

<a name='F-GOOUploader-Controllers-GOOCSUploaderController-version'></a>
### version `constants`

##### Summary

Cancelation Statement version

<a name='M-GOOUploader-Controllers-GOOCSUploaderController-GetGOOCS-System-String-'></a>
### GetGOOCS(hash) `method`

##### Summary

Download GOO Cancelation statement from Bee

##### Returns

CancelationStatement
and Return Code of Request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hash | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GOOUploader-Controllers-GOOCSUploaderController-PostGOOCS-GOO_Model-CancelationStatement,System-String-'></a>
### PostGOOCS(cancelationStatement,swarmBatchId) `method`

##### Summary

Upload GOO Cancelation Statement to bee

##### Returns

reference

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancelationStatement | [GOO_Model.CancelationStatement](#T-GOO_Model-CancelationStatement 'GOO_Model.CancelationStatement') |  |
| swarmBatchId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GOOUploader-Controllers-GOOCSUploaderController-Put-System-String-'></a>
### Put(textData) `method`

##### Summary

Test Upload data to Bee, with default batchId (will not work outside test environment)

##### Returns

content location

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textData | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GOOUploader-Controllers-GOOCSUploaderController-UploadFileData-System-String,System-String,System-String-'></a>
### UploadFileData(name,data,swarmBatchId) `method`

##### Summary

Upload text to bee with filename and batchId

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Filename to be used |
| data | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Contents of text file |
| swarmBatchId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Batch Id |
