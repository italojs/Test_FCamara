# Test_FCamara_API

This is a simple FCamara test 

## Prerequisites

- .net core framework installed

### Getting Started

Creatting database:
- After open the solution set the TestFCamara.Infra project as "startup project";
- Write `update-database` in Package Manager Console;
- Verify if the dabase was created;a

### Routes
#### `/v1/customers`  
use this route to crate users in database.

Type: Post

HEADERS: ```"Content-Type":"application/json"```

FromBody:
```
{
  "firstname":"your first name",
  "lastname":"your last nam",
  "username":"someUserName",
  "password":"SomePassWord"
}
```

#### `v1/authenticateUser"` 
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