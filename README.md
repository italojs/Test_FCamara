# Test_FCamara_API

This is a simple FCamara test

## Obs

 This API use:
 - CQRS pattern: entity framqord to write and Dapper to read;
 - jwt Bearer authentication;
 - Sql Server;

## Prerequisites

- .net core framework installed;
- Entity framework installed(FCamara.infra project and FCamara.API project);
- If the FCamara.infra throw some exeption ina query, install the Dapper package

### Getting Started

Setup your Sql Server connection string at `...\src\FCamara.Shared\Runtime.cs`  and `...\src\FCamara.Api\appsettings.json`

Create database:
- Set the FCamara.Infra project as "startup project";
- Write in Package Manager Console: `Enable-migrations` -> `Add-migration v1` -> `Update-database` ;
- Verify if the dabase was created;
- Verify if the tables is seeded

- Setup the FCamara.Api project as  "startup project";

- Run with FCamara.Api Server(kestrel server);

## Users

username: italo

password: nest@123

## Expiration timeout

Default expiration timeout: 1 minute.

You can change it in FCamara.API project on Security folder in TokenOptions.cs, just change the `ValidFor` propertie. 


### Routes

By deafault the server(kestrel) is ruinnig at port 5000.

#### `/v1/register/user` 
 
Crate users in database.

Type: Post

Required authentication: no

HEADERS: ```"Content-Type":"application/json"```

FromBody:
```
{
  "username":"someUserName",
  "password":"SomePassWord"
}
```

#### `v1/authenticate/user"` 

Authenticate a user in login.

Type: Post

Required authentication: no

HEADERS: ```"Content-Type":"application/json"```

FromForm:
```
{
 "username":"someUserName",
 "password":"password"
}
```

#### `v1/get/products`

List all database products

Type: Get

Required authentication: yes

HEADERS:
 ```
"Content-Type":"application/json"
"Autorization":"Bearer eyJhbGciOiJIU..."
```


