using Dotnet.Mongo.Bus.Request;
using Dotnet.Mongo.Domain.Entities;
using Dotnet.Mongo.Infra.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dotnet.Mongo.Bus.Handlers
{
    public class GetMemberHandler : IRequestHandler<GetMemberRequest, Member>
    {
        private readonly IMemberContext _context;

        public GetMemberHandler(IMemberContext context)
        {
            _context = context;
        }

        public async Task<Member> Handle(GetMemberRequest request, CancellationToken cancellationToken)
        {
            return await _context.FindAsync(x => x.Id == request.Id);
        }
    }
}
