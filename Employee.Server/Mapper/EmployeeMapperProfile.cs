namespace Employees.Server;
public class EmployeeMapperProfile : Profile
{
	public EmployeeMapperProfile()
	{
		CreateMap<Employee, EmployeeViewModel>().ReverseMap();
	}
}