using FluentValidation;
using Webapi_Validation_With_FluentValidation.Models;

namespace Webapi_Validation_With_FluentValidation.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator() 
        {
            RuleFor(x => x.Surname).NotNull().NotEmpty().WithName("Last name");
            RuleFor(x => x.Addresses).SetValidator(new AddressValidator());
            RuleForEach(x => x.Orders).SetValidator(new OrderValidators());
            RuleFor(x => x.Orders)
                   .Must(x => x.Count <= 10).WithMessage("No more than 10 orders are allowed");


        }
    }
}
