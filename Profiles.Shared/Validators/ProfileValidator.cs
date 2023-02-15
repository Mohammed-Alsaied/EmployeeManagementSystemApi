using Common.Validators;
using EmployeeTasks.Shared;

namespace Profiles.Shared;
public class ProfileValidator : BaseViewModelValidator<ProfileViewModel>
{
    public ProfileValidator()
    {
        RuleFor(x => x.EmployeeId).NotEmpty();
        RuleFor(x => x.Team).NotEmpty();
        RuleFor(x => x.ManagerName).NotEmpty();
        RuleFor(x => x.Knowledge).NotEmpty();
        RuleFor(x => x.Expertise).NotEmpty();
        RuleFor(x => x.CurrentWorkProjects).NotEmpty();
    }
}