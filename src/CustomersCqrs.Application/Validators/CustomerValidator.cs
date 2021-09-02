using CustomersCqrs.Domain.Entities;
using FluentValidation;

namespace CustomersCqrs.Application.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("FirstName is required");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("LastName is required");
            RuleFor(x => x.UserName).MinimumLength(4).WithMessage("Min length for UserName is 4 chars");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email format not valid");
        }
    }
}
