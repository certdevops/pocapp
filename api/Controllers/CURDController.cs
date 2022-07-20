using mediatr.cqrs.Features.WebUserFeature.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CURDController : ControllerBase
    {
        private readonly ILogger<CURDController> _logger;
        private readonly IMediator _mediator;
        public CURDController(ILogger<CURDController> logger, IMediator mediator)
        {
            _logger = logger;
            this._mediator = mediator;
        }

        [HttpGet]
        [Route("InsertTestRecord")]
        public async Task<int> InsertTestRecord(string companyCode)
        {
            return await _mediator.Send(new AddWebUserCommand(new WebUserViewModel() { CompanyCode = companyCode, EmailID = "bsmadhusudanan@gmail.com", Username = "bsmadhusudanan", UserPassword = "@dm1n123" }));
        }
    }
}
