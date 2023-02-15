namespace EmployeeTasks.Server;
public class EmployeeTaskMapperProfile : Profile
{
	public EmployeeTaskMapperProfile()
	{
		CreateMap<EmployeeTask, EmployeeTaskViewModel>().ReverseMap();
	}
}