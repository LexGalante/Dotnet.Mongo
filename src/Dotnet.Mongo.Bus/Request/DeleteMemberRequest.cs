using Dotnet.Mongo.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnet.Mongo.Bus.Request
{
    public class DeleteMemberRequest : IRequest<bool>
    {
        public Member Entity { get; set; }
    }
}
