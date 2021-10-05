using Ecommerce.Domain.Entities;
using FluentValidation;

namespace Ecommerce.Domain.Validations
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(x => x.FirstName)
                        .NotNull()
                        .NotEmpty()
                        .WithMessage("FirstName is required!");

            RuleFor(x => x.LastName)
                        .NotNull()
                        .NotEmpty()
                        .WithMessage("LastName is required!");

            RuleFor(x => x.Email)
                        .NotNull()
                        .NotEmpty()
                        .EmailAddress();
        }
    }
}
