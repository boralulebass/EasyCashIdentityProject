﻿using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator() 
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("E-posta adresi boş geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(X => X.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(X => X.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
            RuleFor(X => X.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(X => X.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez");

            RuleFor(x=>x.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter girişi yapınız.");
            RuleFor(x=>x.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız.");
            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter girişi yapınız.");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız.");

            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Parolanız eşleşmiyor");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir e-posta adresi giriniz");


        }
    }
}
