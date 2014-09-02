﻿
using Demo.Presentation.Inventory.Models.SerialNumbers.Services;
using ServiceStack.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Presentation.Inventory.SerialNumbers.Validators
{
    public class FindSerialNumbersValidator : AbstractValidator<FindSerialNumbers>
    {
        public FindSerialNumbersValidator() : base() { }
    }
}