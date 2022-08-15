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
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Employees.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Entities/Concrete/Employees.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``DTOs`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UserForLoginDto.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Dtos/UserForLoginDto.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UserForRegisterDto.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Entities/Dtos/UsersForLoginDtos.cs) <br><br>

🗃 **``Business Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Abstract`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IAuthService.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Business/Abstrack/IAuthService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IUserService.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Business/Abstrack/IUserService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IEmployessService](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Business/Abstrack/IEmployessService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``BusinessAspect`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Autofac`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [SecuredOperation.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Business/BusinessAspect/AutoFact/SecuredOperations.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Manager`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [AuthManager.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Business/Concrete/Manager/AuthManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [EmplotyessManager.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Business/Concrete/Manager/EmployessManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UserManager.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Business/Concrete/Manager/UserManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Constants`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [AuthManager.cs](https://github.com/MiracOzan/NortwindBackEnd/blob/master/Business/Concrete/Manager/AuthManager.cs) <br>
