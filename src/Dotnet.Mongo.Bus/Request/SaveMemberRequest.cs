using Dotnet.Mongo.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Mongo.Bus.Request
{
    public class SaveMemberRequest : IRequest<Member>
    {
        public Member Entity { get; set; }
    }
}
