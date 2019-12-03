using Dotnet.Mongo.Bus  .Request;
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
    public class SaveMemberHandler : IRequestHandler<SaveMemberRequest, Member>
    {
        private readonly IMemberContext _context;

        public SaveMemberHandler(IMemberContext context)
        {
            _context = context;
        }

        public async Task<Member> Handle(SaveMemberRequest request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.Entity.Id))
                await _context.CreateAsync(request.Entity);
            else
                await _context.UpdateAsync(x => x.Id == request.Entity.Id, request.Entity);

            return request.Entity;
        }
    }
}
