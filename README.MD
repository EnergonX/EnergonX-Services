## Guarantees Of Origin Cancelation Statement Storage Services
This project uses Bee to store and retrieve Guarantees of Origin Cancelation Statements (GOOCS). 
Requires bee to be running on `localhost`

## Service 
This service is used to store GOOCS from executed orders on Marketplace.

# Swagger Reference 
go to `/swagger/v1/swagger.json` to see API Endpoints and Schemas used.


## Cancelation Statement
Uses generalized data model, see GOOModel.cs for additional info  
-[ ] JSON Schema
     Check `goo-cs-sample.json` to see sample object. 
-[ ] UI Schema
-[ ] Form Data


## Setup
To run, clone repo
`git clone https://github.com/EnergonX/EnergonX-Services.git`

## Run 
Open solution in VS Code and run `GOOUploader` project.

### Development mode 
Go to https://localhost:5001/swagger/index.html to see Swagger dashboard and definitions for GOO CS Services. 
OpenAPI json is available at https://localhost:5001/swagger/v1/swagger.json  

## Supported Configurations
IIS Express
Self hosted Kestrel Server
Docker 

Choose configuration based on your preference. 
Requires NET.CORE 5. 


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


