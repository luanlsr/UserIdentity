using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Application.Models.Requests;

namespace UsersApp.Application.Models.Validators
{
    public class CreateAccountRequestValidator : AbstractValidator<CreateAccountRequestDTO>
    {
        public CreateAccountRequestValidator()
        {
            RuleFor(dto => dto.Name)
                .NotEmpty().WithMessage("O nome é obrigatório.")
                .MinimumLength(8).WithMessage("Nome deve ter no mínimo 8 caracteres.")
                .MaximumLength(150).WithMessage("Nome deve ter no máximo 150 caracteres.");

            RuleFor(dto => dto.Email)
                .NotEmpty().WithMessage("O email é obrigatório.")
                .EmailAddress().WithMessage("O email fornecido é inválido.");

            RuleFor(dto => dto.Password)
                .NotEmpty().WithMessage("A senha é obrigatória.")
                .MinimumLength(6).WithMessage("A senha deve ter pelo menos 6 caracteres.")
                .Matches("^(?=.*[A-Z]).*$").WithMessage("Informe uma senha com pelo menos uma letra maiúscula")
                .Matches("^(?=.*[!@#$%^&*()_+\\-=[\\]{};':\"\\\\|,.<>/?]).+$").WithMessage("Informe uma senha com pelo menos uma um caractere especial");
        }
    }
}
