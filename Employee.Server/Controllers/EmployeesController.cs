namespace Employees.Server;
[Route("api/[controller]")]
[ApiController]
public class EmployeesController : BaseController<Employee, EmployeeViewModel>
{
    public EmployeesController(IEmployeeUnitOfWork unitOfWork, IMapper mapper, IValidator<EmployeeViewModel> validator)
        : base(unitOfWork, mapper, validator)
    {
    }
    [Authorize(Roles = "Admin,Manager")]
    public override Task<IEnumerable<EmployeeViewModel>> Get()
    {
        return base.Get();
    }
    [Authorize(Roles = "Admin")]
    public override Task Delete(Guid id)
    {
        return base.Delete(id);
    }

    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Post([FromBody] EmployeeViewModel productViewModel)
    {
        return base.Post(productViewModel);
    }
    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Put(Guid id, [FromBody] EmployeeViewModel productViewModel)
    {
        return base.Put(id, productViewModel);
    }
}