namespace Profiles.Server;
public class ProfileMapperProfile : AutoMapper.Profile
{
    public ProfileMapperProfile()
    {
        CreateMap<Profile, ProfileViewModel>().ReverseMap();
    }
}