namespace Persons.Shared;
public abstract class PersonValidator<T> : AbstractValidator<T>
    where T : PersonViewModel
{
    public PersonValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Age).NotEmpty();
        RuleFor(x => x.NickName).NotEmpty();
        RuleFor(x => x.BirthDate).NotEmpty();
        RuleFor(x => x.PlaceOfBirth).NotEmpty();
        RuleFor(x => x.Address1).NotEmpty();
        RuleFor(x => x.Gender).NotEmpty();
    }
}