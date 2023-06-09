﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.ViewModels.Systems.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is Required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is Required")
                .MinimumLength(6).WithMessage("Password is at least 6 character");
        }
    }
}