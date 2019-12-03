using Dotnet.Mongo.Bus.Request;
using Dotnet.Mongo.Infra.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dotnet.Mongo.Bus.Handlers
{
    public class DeleteMemberHandler : IRequestHandler<DeleteMemberRequest, bool>
    {
        private readonly IMemberContext _context;

        public DeleteMemberHandler(IMemberContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteMemberRequest request, CancellationToken cancellationToken)
        {
            await _context.DeleteAsync(x => x.Id == request.Entity.Id);

            return true;
        }
    }
}
