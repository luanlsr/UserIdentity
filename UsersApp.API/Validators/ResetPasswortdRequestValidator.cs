using FluentValidation;
using UsersApp.Application.Models.Requests;

namespace UsersApp.API.Validators
{
    public class ResetPasswordRequestValidator : AbstractValidator<ResetPasswordRequestDTO>
    {
        public ResetPasswordRequestValidator()
        {
            RuleFor(dto => dto.Email)
                .NotEmpty().WithMessage("O email é obrigatório.")
                .EmailAddress().WithMessage("O email fornecido é inválido.");
        }
    }
}
