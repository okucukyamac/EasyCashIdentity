using DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(a => a.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez.");
            RuleFor(a => a.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez.");
            RuleFor(a => a.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez.");
            RuleFor(a => a.Email).NotEmpty().WithMessage("Email alanı boş geçilemez.");
            RuleFor(a => a.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez.");
            RuleFor(a => a.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez.");
            RuleFor(a => a.Name).MinimumLength(2).WithMessage("En az 2 karakter olmalıdır");
            RuleFor(a => a.Name).MaximumLength(30).WithMessage("En çok 30 karakter olmalıdır.");
            RuleFor(a => a.ConfirmPassword).Equal(y => y.Password).WithMessage("Parolalar eşleşmiyor");
            RuleFor(a => a.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz.");

        }
    }
}
