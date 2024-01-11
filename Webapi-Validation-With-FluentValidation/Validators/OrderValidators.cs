using FluentValidation;
using Webapi_Validation_With_FluentValidation.Models;

namespace Webapi_Validation_With_FluentValidation.Validators
{
    public class OrderValidators : AbstractValidator<Order>
    {
        public OrderValidators() 
        {
            RuleFor(x => x.Total).GreaterThan(0)
                                 .WithMessage("Order Total must be greater than 0");
           

        }
    }
}
