using Dotnet.Mongo.Domain.Entities;
using Dotnet.Mongo.Infra.Contracts;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnet.Mongo.Infra
{
    public class MemberContext : MongoContext<Member>, IMemberContext
    {
        private readonly IConfiguration _configuration;

        public MemberContext(IConfiguration configuration) : base(configuration, "member")
        {
            _configuration = configuration;
        }
    }
}
