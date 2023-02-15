namespace Offices.Server;
public class OfficeMapperProfile : Profile
{
    public OfficeMapperProfile()
    {
        CreateMap<Office, OfficeViewModel>().ReverseMap();
    }
}