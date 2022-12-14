# Guarantee Of Origin 
When purchase of Green hydrogen occurs via EnergonX Marketplace, 
**Guarantees of Origin** are stored on decentralized Swarm storage and can be verified by other parties

Feel free to ask your supplier to send you:
- a reference to document called **Cancellation Statement**,
- check your executed order which includes reference number 
- see reference formation within your regular invoice.

The **Cancellation Statement** declares that certain amount of hydrogen, produced by a electrolyser,
used green electricity from PV, OVE, Wind turbines or other green power plant, is accounted on your 
consumption and it can´t be used for a consumption anywhere else.

Please see https://energonx.com/blog for more information. 

## Guarantees Of Origin Cancelation Statement Storage Services
This project uses Bee to store and retrieve Guarantees of Origin Cancelation Statements (GOOCS). 
Requires bee to be running on `localhost`.

Part of EnergonX Marketplace Services. 

## Service 
This service is used to store GOOCS from executed orders on Marketplace.

## Swagger Reference 
go to `/swagger/v1/swagger.json` to see API Endpoints and Schemas used.


## Cancelation Statement
Uses generalized data model, featuring dynamic property definitions, see GOOModel.cs for additional info  
- [ ] JSON Schema
     Check https://github.com/EnergonX/EnergonX-Services/blob/master/goo-cs-sample.json to see sample object. 
- [ ] UI Schema
- [ ] Form Data


## Setup
To run, clone repo
`git clone https://github.com/EnergonX/EnergonX-Services.git`

## Run locally 
Open solution in VS Code and run `GOOUploader` project.

### Development mode 
Go to https://localhost:5001/swagger/index.html to see Swagger dashboard and definitions for GOO CS Services. 
OpenAPI json is available at https://localhost:5001/swagger/v1/swagger.json  

## Supported Configurations
- IIS Express
- Self hosted Kestrel Server
- Docker 

Choose configuration based on your preference. Requires NET.Core 5. 

### Clean
`dotnet clean`

### Build 
To build use  `dotnet build --configuration Release`

Add Runtime to build for specific OSs
- Ubuntu  `--runtime ubuntu.18.04-x64`
- Windows `--runtime osx.10.11-x64`
- Mac     `--runtime ubuntu.18.04-x64`

### Publish:
`dotnet publish --runtime osx.10.11-x64 --configuration Release --self-contained true`

## Available API Calls
See https://github.com/EnergonX/EnergonX-Services/blob/master/GOOUploader/GOOUploader.md for documentation on API REST Calls. 

- **POST** ​/GOOCS​/Post
Upload GOO Cancelation Statement to bee
- **GET** ​/GOOCS​/Get
Download GOO Cancelation statement from Bee
- **GET** ​/GOOCS​/GetContentsFor
- **POST** ​/GOOCS​/UploadFile
Upload text to bee with filename and batchId
- **PUT** ​/GOOCS​/Test 
Test Upload data to Bee, with default batchId (will not work outside test environment)

## Development 
EnergonX and EnergonX Services are under active development. 
You can use Controller on how to use Bee to store data from C# using `HttpClient`. 

## Network consideration
Never tested if gateways are supported. URI of Bee must be reachable on network to this app.  
We suggest environment where bee is **only** accessible from this app, and not from outside. 

## Security 
This app service requires **NO** authorization and authentification. 
- GOOCSs are signed by issuers and can be verified any time. 
- Services that wish to store their GOOCS must buy and provide their `batchId` and store references in their databases. 
- EnergonX Marketplace will never be aware of those GOOCSs. 
- This app has logger for development purpuses, but collects no other data from requests. 
- Any one can setup Bee node and use this app service to upload files and data as long as they provide their batchId. 
- Privacy is preserved for all callers to service.
- Anyone with reference to GOOCS can view and download it and verify signatures.  
- Immutability of data is assured by Swarm.


Advent of cloud data and the Internet of Things (IoT) face organizations with a huge volume of transaction data 
that needs to be securely stored. Immutable files and storage are a suitable solution for storing logs. 
Organizations need to consider the need for historical data. With data privacy regulations getting stricter, many organizations 
need to preserve their historical data. To be compliant when a customer or government requests past data, 
a storage that stores data in the provable immutable store is best suited for this use case. 

Organizations, users and verifiers often need to compare their current data to historical records to understand user trends, measure growth or for verification purpuses. 
Overwriting the historical data is not a good idea in such cases. Immutable data also helps organizations to keep 
track of the changes they went through over the years; it is especially helpful in software systems. 
To implement immutability with standard database approach is hard to prove. Although this app service stores typed data to Swarm,
a reference to all past executed orders are kept on Markeplace and are stored in a database, from where order information can be retreived.
Even if data availability is degraded in any way, a user or third party can still provide data that can be prove validity later in time.

FMF TF