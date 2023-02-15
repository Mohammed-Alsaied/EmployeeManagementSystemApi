namespace EmployeeTaskes.Server;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class EmployeeTasksController : BaseController<EmployeeTask, EmployeeTaskViewModel>
{
    public EmployeeTasksController(IEmployeeTaskUnitOfWork unitOfWork, IMapper mapper, IValidator<EmployeeTaskViewModel> validator)
        : base(unitOfWork, mapper, validator)
    {
    }

    [Authorize(Roles = "Admin,Manager")]
    public override Task<IEnumerable<EmployeeTaskViewModel>> Get()
    {
        return base.Get();
    }
    [Authorize(Roles = "Admin,Manager")]
    public override Task Delete(Guid id)
    {
        return base.Delete(id);
    }

    [Authorize(Roles = "Admin,Manager")]
    public override Task<IActionResult> Post([FromBody] EmployeeTaskViewModel productViewModel)
    {
        return base.Post(productViewModel);
    }
    [Authorize(Roles = "Admin,Manager")]
    public override Task<IActionResult> Put(Guid id, [FromBody] EmployeeTaskViewModel productViewModel)
    {
        return base.Put(id, productViewModel);
    }
}