using FluentValidation;
using UsersApp.Application.Models.Requests;

namespace UsersApp.API.Validators
{
    public class AuthenticateRequestValidator : AbstractValidator<AuthenticateRequestDTO>
    {
        public AuthenticateRequestValidator()
        {
            RuleFor(dto => dto.Email)
                .NotEmpty().WithMessage("O email é obrigatório.")
                .EmailAddress().WithMessage("O email fornecido é inválido.");

            RuleFor(dto => dto.Password)
                .NotEmpty().WithMessage("A senha é obrigatória.");
        }
    }
}
