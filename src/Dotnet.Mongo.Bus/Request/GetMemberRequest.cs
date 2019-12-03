using Dotnet.Mongo.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnet.Mongo.Bus.Request
{
    public class GetMemberRequest : IRequest<Member>
    {
        public string Id { get; set; }
    }
}
