using FluentValidation;
using Webapi_Validation_With_FluentValidation.Models;

namespace Webapi_Validation_With_FluentValidation.Validators
{

    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotEmpty()
                                 .NotNull();
            RuleFor(x => x.Email).NotEmpty()
                                 .EmailAddress();
            RuleFor(x => x.Address).NotNull()
                                   .MaximumLength(10)
                                   .Must(x => x?.ToLower().Contains("street") == true)
                                   .WithMessage("Please add street to your address");


            RuleForEach(x => x.Memberships).SetValidator(new MembershipValidator());    

        }
    }

    public class MembershipValidator : AbstractValidator<Membership>
    {
        public MembershipValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull();
        }
    }

}
