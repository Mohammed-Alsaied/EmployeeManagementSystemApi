using FluentValidation;

namespace Employees.Shared;
public class EmployeeValidator : PersonValidator<EmployeeViewModel>
{
    public EmployeeValidator()
    {
        RuleFor(x => x.OfficeCode).NotEmpty().WithMessage("Office Code is Required");
        RuleFor(x => x.Email).NotEmpty().WithMessage("Email is Required");
        RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Phone Number is Required");
        RuleFor(x => x.JobTitle).NotEmpty().WithMessage("Job Title is Required");
    }
}