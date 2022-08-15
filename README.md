# NortwindBackEnd

## ⭐ Introduction

## Installation

```bash
# Clone to repository
$ git clone https://github.com/MiracOzan/NortwindBackEnd.git

$ cd NortwindBackEnd

$ dotnet restore
```

## Layers
🗃 **``Entities Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Employees.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Entities/Concrete/Employees.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``DTOs`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UserForLoginDto.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Dtos/UserForLoginDto.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UserForRegisterDto.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Entities/Dtos/UsersForLoginDtos.cs) <br><br>

🗃 **``Business Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Abstract`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IAuthService.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Business/Abstrack/IAuthService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IUserService.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Business/Abstrack/IUserService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IEmployessService](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Business/Abstrack/IEmployessService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``BusinessAspect`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Autofac`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [SecuredOperation.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Business/BusinessAspect/AutoFact/SecuredOperations.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Manager`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [AuthManager.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Business/Concrete/Manager/AuthManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [EmplotyessManager.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Business/Concrete/Manager/EmployessManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UserManager.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Business/Concrete/Manager/UserManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Constants`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Messages.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Business/Constants/Messages.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``DependencyResolvers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Autofac`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [AutofacBusinessModule.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Business/DependencyResolvers/Autofac/AutofacBusinessModule.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``ValidationRules`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``FluentValidation`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [EmployeesValidator.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Business/ValidationRules/FluentValidation/EmployeesValidator.cs) <br><br>

🗃 **``Core Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Aspects`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Autofac`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Logging`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [LogAspect.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Aspects/Autofac/Logging/LogAspect.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [LogDetailWithException.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Aspects/Autofac/Logging/LogDetailWithException.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Validation`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ValidationAspect.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Aspects/Autofac/Validation/ValidationAspect.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``CrossCuttingConcerns`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Exceptions`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ExceptionLogAspect.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/CrossCuttingConcerns/Exceptions/ExceptionLogAspect.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Loging`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Log4Net`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Layouts`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [JsonLayout.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/CrossCuttingConcerns/Logging/Log4Net/Layouts/JsonLayout.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Loggers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [DatabaseLogger.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/CrossCuttingConcerns/Logging/Log4Net/Loggers/DatabaseLogger.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [FileLogger.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/CrossCuttingConcerns/Logging/Log4Net/Loggers/FileLogger.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [LoggersServiceBase.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/CrossCuttingConcerns/Logging/Log4Net/LoggersServiceBase.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [SerializableLogEvent.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/CrossCuttingConcerns/Logging/Log4Net/SerializableLogEvent.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [LogDetail.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/CrossCuttingConcerns/Logging/LogDetail.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [LogParameter.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/CrossCuttingConcerns/Logging/LogParameter.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Validation`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ValidationTool.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/CrossCuttingConcerns/Validation/ValidationTool.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``DataAccess`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``EntityFramework`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [EfEntityRepositoryBase.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IEntityRepository.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/DataAccess/IEntityRepository.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``DependecyResolvers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CoreModule.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/DependencyResolvers/CoreModule.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Entities`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [OperationClaim.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Entities/Concrete/OperationClaim.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [User.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Entities/Concrete/User.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UserOperationClaim.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Entities/Concrete/UserOperationClaim.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IDto.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Entities/IDto.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IEntity.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Entities/IEntity.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Extensions`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ClaimExtensions.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Extensions/ClaimExtensions.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ClaimsPrincipalExtensions.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Extensions/ClaimsPrincipalExtensions.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ErrorDetails.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Extensions/ErrorDetails.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ExceptionMiddleware.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Extensions/ExceptionMiddleware.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ExceptionMiddlewareExtensions.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Extensions/ExceptionMiddlewareExtensions.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ServiceCollectionExtensions.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Extensions/ServiceCollectionExtensions.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Utilities`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Business`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [BusinessRules.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Business/BusinessRules.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Interceptors`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [AspectInterceptorSelector.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Interceptors/AspectInterceptorSelector.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [MethodInterception.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Interceptors/MethodInterception.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [MethodInterceptionBaseAttribute.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Interceptors/MethodInterceptionBaseAttribute.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``IoC`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICoreModule.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/IoC/ICoreModule.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ServiceTool.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/IoC/ServiceTool.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Message`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [AspectMessages.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Message/AspectMessages.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Result`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [DataResult.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Result/DataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ErrorDataResult.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Result/ErrorDataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ErrorResult.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Result/ErrorResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IDataResult.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Result/IDataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IResult.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Result/IResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Result.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Result/Result.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [SuccessDataResult.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Result/SuccessDataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [SuccessResult.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Result/SuccessResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Security`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Encryption`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [SecurityKeyHelper.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Security/Encryption/SecurityKeyHelper.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [SigningCredentialsHelper.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Security/Encryption/SigningCredentialsHelper.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Hashing`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [HashingHelper.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Security/Hashing/HashingHelper.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Jwt`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [AccessToken.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Security/Jwt/AccessToken.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ITokenHelper.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Security/Jwt/ITokenHelper.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [JwtHelper.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Security/Jwt/JwtHelper.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [TokenOptions.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Core/Utilities/Security/Jwt/TokenOptions.cs) <br><br>

🗃 **``Data Access Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Abstract`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IEmployessDal](https://github.com/MiracOzan/NortwindBackEnd/blob/master/DataAccess/Abstrack/IEmployessDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IUsersDal.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/DataAccess/Abstrack/IUsersDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``EntityFramework`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [EfEmployessDal.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/DataAccess/Concrete/EntityFramework/EfEmployessDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [EfUserDal.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/DataAccess/Concrete/EntityFramework/EfUserDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Contexts`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [NorthwindContext.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/DataAccess/Concrete/EntityFramework/Contexts/NorthwindContext.cs) <br><br>

🗃 **``WebAPI Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Startup.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/WebApi/Startup.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Controllers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [AuthController.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/WebApi/Controllers/AuthController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [EmployesController.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/WebApi/Controllers/EmployesController.cs) <br>


## SQL Query

-

## Tables in Database

<table>
  <tr>
     <td>Users</td>
     <td>UserOperationClaims</td>
     <td>UserForRegisterDto</td>
     <td>UserForLoginDto</td>
     <td>TokenOptions</td>
     <td>OperationClaims</td>
     <td>AccessToken</td>
     <td>Employes</td>
  </tr>
  <tr>
    <td>

Variable Name | Data Type
------------ | -------------
Id | INT
FirstName | NVARCHAR(50)
LastName | NVARCHAR(50)
Email | NVARCHAR(50)
PasswordSalt | VARBİNARY(MAX)
PasswordHash | VARBİNARY(MAX)
Status | BIT
      
   </td>
    <td>

Variable Name | Data Type
------------ | -------------
Id | INT
UserId | INT
OperationClaimId | DATETIME

   </td>
    <td>

Variable Name | Data Type
------------ | -------------
Id | INT
Email | NVARCHAR(50)
Password | NVARCHAR(50)
FirstName | NVARCHAR(50)
LastName | NVARCHAR(50)

   </td>
    <td>

Variable Name | Data Type
------------ | -------------
Id | INT
Email | NVARCHAR(50)
Password | VARBİNARY(MAX)

   </td>
    <td>

Variable Name | Data Type
------------ | -------------
Id | INT
Audience  | NVARCHAR(50)
Issuer | NVARCHAR(50)
AccessTokenExpiration | INT
SecurityKey | NVARCHAR(50)
      
   </td>
   <td>

Variable Name | Data Type
------------ | -------------
Id | INT
Name | NVARCHAR(50)

   </td>
    <td>

Variable Name | Data Type
------------ | -------------
Id | INT
Token | NVARCHAR(50)
Expiration | DATE
      
   </td>
    <td>

Variable Name | Data Type
------------ | -------------
EmployeeID | INT
FirstName | NVARCHAR(50)
LastName | NVARCHAR(50)
Title | NVARCHAR(30)
BirthDate | DATE
HireDate | DATE
Address | NVARCHAR(30)
City | NVARCHAR(50)
Region | NVARCHAR(50)
PostalCode | NVARCHAR(50)
Country | NVARCHAR(50)
HomePhone | NVARCHAR(50)
Extension | NVARCHAR(4)
Photo | BYTE
Notes | NVARCHAR(50)
ReportsTo | INT
      
   </td>
  </tr>
 </table>

 
## License
[MIT © Miraç Ozan T.]() 
