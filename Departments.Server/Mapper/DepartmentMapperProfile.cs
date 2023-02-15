namespace Departments.Server;
public class DepartmentMapperProfile : Profile
{
	public DepartmentMapperProfile()
	{
		CreateMap<Department, DepartmentViewModel>().ReverseMap();
	}
}