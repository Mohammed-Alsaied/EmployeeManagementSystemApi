namespace Managers.Server;
[Route("api/[controller]")]
[ApiController]
public class ManagersController : BaseController<Manager, ManagerViewModel>
{
    public ManagersController(IManagerUnitOfWork unitOfWork,
        IMapper mapper,
        IValidator<ManagerViewModel> validator)
        : base(unitOfWork, mapper, validator)
    {
    }

    [Authorize(Roles = "Admin")]
    public override Task Delete(Guid id)
    {
        return base.Delete(id);
    }

    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Post([FromBody] ManagerViewModel productViewModel)
    {
        return base.Post(productViewModel);
    }
    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Put(Guid id, [FromBody] ManagerViewModel productViewModel)
    {
        return base.Put(id, productViewModel);
    }
}