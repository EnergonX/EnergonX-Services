# Guarantee Of Origin 
When purchase of Green hydrogen occurs via EnergonX Marketplace, 
**Guarantees of Origin** are stored on decentralized Swarm storage and can be verified by other parties

Feel free to ask your supplier to send you:
- a reference to document called **Cancellation Statement**,
- check your executed order which includes reference number 
- see reference formation within your regular invoice.

The **Cancellation Statement** declares that certain amount of hydrogen, produced by a electrolyser,
used green electricity from PV, OVE, Wind turbines or other green power splant, is accounted on your 
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
     Check `goo-cs-sample.json` to see sample object. 
- [ ] UI Schema
- [ ] Form Data


## Setup
To run, clone repo
`git clone https://github.com/EnergonX/EnergonX-Services.git`

## Run 
Open solution in VS Code and run `GOOUploader` project.

### Development mode 
Go to https://localhost:5001/swagger/index.html to see Swagger dashboard and definitions for GOO CS Services. 
OpenAPI json is available at https://localhost:5001/swagger/v1/swagger.json  

## Supported Configurations
- IIS Express
- Self hosted Kestrel Server
- Docker 

Choose configuration based on your preference. Requires NET.Core 5. 

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

## Network and Security 
Never tested if gateways are supported. URI of Bee must be reachable on network to this app.  
We suggest environment where bee is **only** accessible from this app, and not from outside. 



