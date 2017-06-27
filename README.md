# Test_FCamara_API

This is a simple FCamara test 

## Prerequisites

- .net core framework installed

### Getting Started

Setup your connection string at `...\src\FCamara.Shared\Runtime.cs`  and `...\src\FCamara.Api\appsettings.json`

Create database:
- Set the TestFCamara.Infra project as "startup project";
- Write in Package Manager Console: `Enable-migrations` -> `Add-migration v1` -> `Update-database` ;
- Verify if the dabase was created;

Stup the FCamara.Api project as  "startup project";
Run with FCamara.Api Server(kestrel server);

### Routes
By deafault the server is ruinnig at port 5000.
#### `/v1/register/user`  
use this route to crate users in database.

Type: Post

HEADERS: ```"Content-Type":"application/json"```

FromBody:
```
{
  "username":"someUserName",
  "password":"SomePassWord"
}
```

#### `v1/authenticate/user"` 
use this route to authenticate a user in login.

Type: Post

HEADERS: ```"Content-Type":"application/json"```

FromForm:
```
{
 "username":"someUserName",
 "password":"password"
}
```

#### `v1/get/products`
Required athentication
