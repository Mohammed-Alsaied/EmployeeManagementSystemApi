namespace Profilees.Server;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Profiles.Server;
using System;

[Route("api/[controller]")]
[ApiController]
public class ProfileController : BaseController<Profiles.Server.Profile, ProfileViewModel>
{
    public ProfileController(IProfileUnitOfWork unitOfWork, IMapper mapper, IValidator<ProfileViewModel> validator)
        : base(unitOfWork, mapper, validator)
    {
    }

    [Authorize(Roles = "Admin")]
    public override Task Delete(Guid id)
    {
        return base.Delete(id);
    }

    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Post([FromBody] ProfileViewModel productViewModel)
    {
        return base.Post(productViewModel);
    }
    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Put(Guid id, [FromBody] ProfileViewModel productViewModel)
    {
        return base.Put(id, productViewModel);
    }
}