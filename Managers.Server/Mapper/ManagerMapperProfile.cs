namespace Managers.Server;
public class ManagerMapperProfile : Profile
{
	public ManagerMapperProfile()
	{
		CreateMap<Manager, ManagerViewModel>().ReverseMap();
	}
}