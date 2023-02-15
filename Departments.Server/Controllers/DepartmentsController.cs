namespace Departments.Server;
[Route("api/[controller]")]
[ApiController]
public class DepartmentsController : BaseController<Department, DepartmentViewModel>
{
    public DepartmentsController(IDepartmentUnitOfWork unitOfWork, IMapper mapper, IValidator<DepartmentViewModel> validator)
        : base(unitOfWork, mapper, validator)
    {
    }

    [Authorize(Roles = "Admin")]
    public override Task Delete(Guid id)
    {
        return base.Delete(id);
    }

    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Post([FromBody] DepartmentViewModel productViewModel)
    {
        return base.Post(productViewModel);
    }
    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Put(Guid id, [FromBody] DepartmentViewModel productViewModel)
    {
        return base.Put(id, productViewModel);
    }
}