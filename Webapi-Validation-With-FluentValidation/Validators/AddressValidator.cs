using FluentValidation;
using Webapi_Validation_With_FluentValidation.Models;

namespace Webapi_Validation_With_FluentValidation.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator() 
        {
            RuleFor(o => o.Postcode).NotNull().NotEmpty();
        }
    }
}
