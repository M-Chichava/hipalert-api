using Application.Features.Authentications.Commands.RequestModels;
using FluentValidation;

namespace Application.Features.Authentications.Commands.Validators;

public class LoginValidator : AbstractValidator<LoginCommand>
{
    public LoginValidator()
    {
        RuleFor(x => x.Email).NotEmpty();
        RuleFor(x => x.Password).NotEmpty();
    }
    
}