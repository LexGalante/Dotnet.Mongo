using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet.Mongo.Bus.Request;
using Dotnet.Mongo.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Dotnet.Mongo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly ILogger<MemberController> _logger;
        private readonly IMediator _mediator;

        public MemberController(ILogger<MemberController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<Member> Get([FromBody] GetMemberRequest request) => await _mediator.Send(request);

        public async Task<Member> Save([FromBody] SaveMemberRequest request) => await _mediator.Send(request);

        public async Task<bool> Delete([FromBody] DeleteMemberRequest request) => await _mediator.Send(request);
    }
}
