
namespace Offices.Shared;
public class OfficeValidator : BaseViewModelValidator<OfficeViewModel>
{
    public OfficeValidator()
    {
        RuleFor(x => x.City).NotEmpty();
        RuleFor(x => x.PhoneNumber).NotEmpty();
        RuleFor(x => x.Address1).NotEmpty();
        RuleFor(x => x.State).NotEmpty();
        RuleFor(x => x.Country).NotEmpty();
    }
}