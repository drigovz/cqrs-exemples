using Ecommerce.Application.Commands.Clients;
using Ecommerce.Domain.Validators;
using FluentValidation;

namespace Ecommerce.Application.Validators
{
    public class ClientValidator : AbstractValidator<ClientCreateCommand>
    {
        public ClientValidator()
        {
            RuleFor(x => x.FirstName).FirstName();
            RuleFor(x => x.LastName).LastName();
            RuleFor(x => x.Email).Email();
        }
    }
}
