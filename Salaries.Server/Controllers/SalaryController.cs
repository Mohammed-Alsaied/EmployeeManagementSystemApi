
namespace Salarys.Server;
[Route("api/[controller]")]
[ApiController]
public class SalaryController : BaseController<Salary, SalaryViewModel>
{
    public SalaryController(ISalaryUnitOfWork unitOfWork, IMapper mapper, IValidator<SalaryViewModel> validator)
        : base(unitOfWork, mapper, validator)
    {
    }

    [Authorize(Roles = "Admin")]
    public override Task Delete(Guid id)
    {
        return base.Delete(id);
    }

    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Post([FromBody] SalaryViewModel productViewModel)
    {
        return base.Post(productViewModel);
    }
    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Put(Guid id, [FromBody] SalaryViewModel productViewModel)
    {
        return base.Put(id, productViewModel);
    }
}