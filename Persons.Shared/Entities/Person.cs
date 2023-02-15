namespace Persons.Shared;
public class Person : BaseEntity
{
    public string Name { get; set; }
    public string NickName { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public string PlaceOfBirth { get; set; }
    public DateTime BirthDate { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
}
