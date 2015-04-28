﻿using FluentValidation;
using Demo.Library.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.HumanResources.Employee.Validators
{
    public class UpdateDirectPhone : AbstractValidator<Commands.UpdateDirectPhone>
    {
        public UpdateDirectPhone()
        {
            RuleFor(x => x.EmployeeId).NotEmpty();
        }
    }
}