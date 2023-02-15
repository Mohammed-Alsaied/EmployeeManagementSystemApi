namespace Salaries.Server;
public class SalaryMapperProfile : Profile
{
    public SalaryMapperProfile()
    {
        CreateMap<Salary, SalaryViewModel>().ReverseMap();
    }
}