using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class EmployeesValidator:AbstractValidator<Employees>
    {
        public EmployeesValidator()
        {
            RuleFor(p => p.EmployeeID).NotEmpty();
            
        }
    }
}
