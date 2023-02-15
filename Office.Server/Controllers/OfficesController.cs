namespace Offices.Server;
[Route("api/[controller]")]
[ApiController]
public class OfficesController : BaseController<Office, OfficeViewModel>
{
    public OfficesController(IOfficeUnitOfWork unitOfWork, IMapper mapper, IValidator<OfficeViewModel> validator)
        : base(unitOfWork, mapper, validator)
    {
    }

    [Authorize(Roles = "Admin")]
    public override Task Delete(Guid id)
    {
        return base.Delete(id);
    }

    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Post([FromBody] OfficeViewModel productViewModel)
    {
        return base.Post(productViewModel);
    }
    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Put(Guid id, [FromBody] OfficeViewModel productViewModel)
    {
        return base.Put(id, productViewModel);
    }
}